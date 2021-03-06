/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class MasterContainer extends Container {
  private long swigCPtr;

  protected MasterContainer(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGMasterContainerUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MasterContainer obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_MasterContainer(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  protected void swigDirectorDisconnect() {
    swigCMemOwn = false;
    delete();
  }

  public void swigReleaseOwnership() {
    swigCMemOwn = false;
    libtischJNI.MasterContainer_change_ownership(this, swigCPtr, false);
  }

  public void swigTakeOwnership() {
    swigCMemOwn = true;
    libtischJNI.MasterContainer_change_ownership(this, swigCPtr, true);
  }

  public MasterContainer(int w, int h, int defaults) {
    this(libtischJNI.new_MasterContainer__SWIG_0(w, h, defaults), true);
    libtischJNI.MasterContainer_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public MasterContainer(int w, int h) {
    this(libtischJNI.new_MasterContainer__SWIG_1(w, h), true);
    libtischJNI.MasterContainer_director_connect(this, swigCPtr, swigCMemOwn, true);
  }

  public void doUpdate(Widget target) {
    if (getClass() == MasterContainer.class) libtischJNI.MasterContainer_doUpdate__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target); else libtischJNI.MasterContainer_doUpdateSwigExplicitMasterContainer__SWIG_0(swigCPtr, this, libtischJNI.getCPtrAddRef(target), target);
  }

  public void doUpdate() {
    if (getClass() == MasterContainer.class) libtischJNI.MasterContainer_doUpdate__SWIG_1(swigCPtr, this); else libtischJNI.MasterContainer_doUpdateSwigExplicitMasterContainer__SWIG_1(swigCPtr, this);
  }

  public void adjust(int w, int h) {
    libtischJNI.MasterContainer_adjust(swigCPtr, this, w, h);
  }

  public void usePeak() {
    libtischJNI.MasterContainer_usePeak(swigCPtr, this);
  }

  public int process_gestures() {
    return libtischJNI.MasterContainer_process_gestures(swigCPtr, this);
  }

  protected void setMatcher(SWIGTYPE_p_InternalMatcher value) {
    libtischJNI.MasterContainer_matcher_set(swigCPtr, this, SWIGTYPE_p_InternalMatcher.getCPtr(value));
  }

  protected SWIGTYPE_p_InternalMatcher getMatcher() {
    long cPtr = libtischJNI.MasterContainer_matcher_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_InternalMatcher(cPtr, false);
  }

  protected void setInput(MatcherTUIOInput value) {
    libtischJNI.MasterContainer_input_set(swigCPtr, this, MatcherTUIOInput.getCPtr(value), value);
  }

  protected MatcherTUIOInput getInput() {
    long cPtr = libtischJNI.MasterContainer_input_get(swigCPtr, this);
    return (cPtr == 0) ? null : new MatcherTUIOInput(cPtr, false);
  }

  protected void setInthread(SWIGTYPE_p_InputThread value) {
    libtischJNI.MasterContainer_inthread_set(swigCPtr, this, SWIGTYPE_p_InputThread.getCPtr(value));
  }

  protected SWIGTYPE_p_InputThread getInthread() {
    long cPtr = libtischJNI.MasterContainer_inthread_get(swigCPtr, this);
    return (cPtr == 0) ? null : new SWIGTYPE_p_InputThread(cPtr, false);
  }

}
