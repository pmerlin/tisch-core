/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Rotation : FeatureDouble {
  private HandleRef swigCPtr;

  internal Rotation(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.RotationUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Rotation obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Rotation() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_Rotation(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Rotation(uint tf) : this(libtischPINVOKE.new_Rotation__SWIG_0(tf), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public Rotation() : this(libtischPINVOKE.new_Rotation__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FeatureBase clone() {
    IntPtr cPtr = libtischPINVOKE.Rotation_clone(swigCPtr);
    Rotation ret = (cPtr == IntPtr.Zero) ? null : new Rotation(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.Rotation_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override string name() {
    string ret = libtischPINVOKE.Rotation_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static Rotation dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.Rotation_dynamic_cast(FeatureBase.getCPtr(arg0));
    Rotation ret = (cPtr == IntPtr.Zero) ? null : new Rotation(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
