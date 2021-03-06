/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Gesture : vectorSmartPtrFeatureBase {
  private HandleRef swigCPtr;

  internal Gesture(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.GestureUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Gesture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Gesture() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_Gesture(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Gesture() : this(libtischPINVOKE.new_Gesture__SWIG_0(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gesture(string _name, int _flags) : this(libtischPINVOKE.new_Gesture__SWIG_1(_name, _flags), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gesture(string _name) : this(libtischPINVOKE.new_Gesture__SWIG_2(_name), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gesture(Gesture g) : this(libtischPINVOKE.new_Gesture__SWIG_3(Gesture.getCPtr(g)), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Gesture assign(Gesture g) {
    Gesture ret = new Gesture(libtischPINVOKE.Gesture_assign(swigCPtr, Gesture.getCPtr(g)), false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void load(InputState state) {
    libtischPINVOKE.Gesture_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public void check() {
    libtischPINVOKE.Gesture_check(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public int next() {
    int ret = libtischPINVOKE.Gesture_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int match() {
    int ret = libtischPINVOKE.Gesture_match(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = libtischPINVOKE.Gesture_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int flags() {
    int ret = libtischPINVOKE.Gesture_flags(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
