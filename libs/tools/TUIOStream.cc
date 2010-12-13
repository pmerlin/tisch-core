/*************************************************************************\
*    Part of the TISCH framework - see http://tisch.sourceforge.net/      *
*  Copyright (c) 2006 - 2010 by Florian Echtler, TUM <echtler@in.tum.de>  *
*   Licensed under GNU Lesser General Public License (LGPL) 3 or later    *
\*************************************************************************/

#include "TUIOStream.h"
#include <time.h>


TUIOStream::TUIOStream( const char* target, int port ):
	oscOut( buffer, TUIOSTREAM_BUFFER_SIZE ), 
	transmitSocket( IpEndpointName( target, port ) ),
	frame( 0 )
{ }


void TUIOStream::start() {

	oscOut << osc::BeginBundleImmediate;

	// frame message
	oscOut << osc::BeginMessage( "/tuio2/frm" ) << frame++ << osc::TimeTag(time(NULL)) << osc::EndMessage;
}


template <> TUIOStream& operator<< <BasicBlob> ( TUIOStream& s, const BasicBlob& b ) {

	double w = b.axis1.length();
	double h = b.axis2.length();

	// /tuio2/bnd s_id x_pos y_pos angle width height area [x_vel y_vel a_vel m_acc r_acc]
	s.oscOut << osc::BeginMessage( "/tuio2/bnd" )
		<< b.id << b.pos.x << b.pos.y
		<< acos((b.axis1*(1.0/w))*Vector(1,0,0))
		<< w << h << b.size/(w*h)
		<< osc::EndMessage;

	// /tuio2/ptr s_id tu_id c_id x_pos y_pos width press [x_vel y_vel m_acc] 
	s.oscOut << osc::BeginMessage( "/tuio2/ptr" )
		<< b.id << b.type << osc::int32(0)
		<< b.peak.x << b.peak.y
		<< b.axis1.length() << double(1.0)
		<< osc::EndMessage;
	
	if (b.pid)
		s.oscOut << osc::BeginMessage( "/tuio2/lia" )
			<< b.pid << true << b.id << osc::int32(0)
			<< osc::EndMessage;

	s.alive.push_back( b.id );
	return s;
}


void TUIOStream::send() {

	// alive message
	oscOut << osc::BeginMessage( "/tuio2/alv" );
	for (std::vector<osc::int32>::iterator id = alive.begin(); id != alive.end(); id++) oscOut << *id;
	oscOut << osc::EndMessage;

	oscOut << osc::EndBundle;

	transmitSocket.Send( oscOut.Data(), oscOut.Size() );

	oscOut.Clear();
	alive.clear();
}

