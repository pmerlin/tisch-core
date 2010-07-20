/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package libtisch;

public class MultiBlobScale extends Scale {
  private long swigCPtr;

  protected MultiBlobScale(long cPtr, boolean cMemoryOwn) {
    super(libtischJNI.SWIGMultiBlobScaleUpcast(cPtr), cMemoryOwn);
    swigCPtr = cPtr;
  }

  protected static long getCPtr(MultiBlobScale obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        libtischJNI.delete_MultiBlobScale(swigCPtr);
      }
      swigCPtr = 0;
    }
    super.delete();
  }

  public MultiBlobScale(int tf) {
    this(libtischJNI.new_MultiBlobScale__SWIG_0(tf), true);
  }

  public MultiBlobScale() {
    this(libtischJNI.new_MultiBlobScale__SWIG_1(), true);
  }

  public void load(InputState state) {
    libtischJNI.MultiBlobScale_load(swigCPtr, this, InputState.getCPtr(state), state);
  }

  public String name() {
    return libtischJNI.MultiBlobScale_name(swigCPtr, this);
  }

  public static MultiBlobScale dynamic_cast(FeatureBase base) {
    long cPtr = libtischJNI.MultiBlobScale_dynamic_cast(FeatureBase.getCPtr(base), base);
    return (cPtr == 0) ? null : new MultiBlobScale(cPtr, false);
  }

}