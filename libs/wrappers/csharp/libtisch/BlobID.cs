/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BlobID : FeatureInt {
  private HandleRef swigCPtr;

  internal BlobID(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.BlobIDUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BlobID obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlobID() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_BlobID(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BlobID(uint tf) : this(libtischPINVOKE.new_BlobID__SWIG_0(tf), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobID() : this(libtischPINVOKE.new_BlobID__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FeatureBase clone() {
    IntPtr cPtr = libtischPINVOKE.BlobID_clone(swigCPtr);
    BlobID ret = (cPtr == IntPtr.Zero) ? null : new BlobID(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.BlobID_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int next() {
    int ret = libtischPINVOKE.BlobID_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string name() {
    string ret = libtischPINVOKE.BlobID_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static BlobID dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.BlobID_dynamic_cast(FeatureBase.getCPtr(arg0));
    BlobID ret = (cPtr == IntPtr.Zero) ? null : new BlobID(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
