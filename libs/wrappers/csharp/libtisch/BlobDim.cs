/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class BlobDim : FeatureDimensions {
  private HandleRef swigCPtr;

  internal BlobDim(IntPtr cPtr, bool cMemoryOwn) : base(libtischPINVOKE.BlobDimUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BlobDim obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BlobDim() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          libtischPINVOKE.delete_BlobDim(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public BlobDim(uint tf) : this(libtischPINVOKE.new_BlobDim__SWIG_0(tf), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public BlobDim() : this(libtischPINVOKE.new_BlobDim__SWIG_1(), true) {
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override FeatureBase clone() {
    IntPtr cPtr = libtischPINVOKE.BlobDim_clone(swigCPtr);
    BlobDim ret = (cPtr == IntPtr.Zero) ? null : new BlobDim(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void load(InputState state) {
    libtischPINVOKE.BlobDim_load(swigCPtr, InputState.getCPtr(state));
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
  }

  public override int next() {
    int ret = libtischPINVOKE.BlobDim_next(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string name() {
    string ret = libtischPINVOKE.BlobDim_name(swigCPtr);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static BlobDim dynamic_cast(FeatureBase arg0) {
    IntPtr cPtr = libtischPINVOKE.BlobDim_dynamic_cast(FeatureBase.getCPtr(arg0));
    BlobDim ret = (cPtr == IntPtr.Zero) ? null : new BlobDim(cPtr, false);
    if (libtischPINVOKE.SWIGPendingException.Pending) throw libtischPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
