//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxIteratorSrcBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxIteratorSrcBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxIteratorSrcBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxIteratorSrcBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxIteratorSrcBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxIteratorSrcBase(FbxProperty pProperty, FbxClassId pClassId) : this(fbx_wrapperPINVOKE.new_FbxIteratorSrcBase__SWIG_0(FbxProperty.getCPtr(pProperty), FbxClassId.getCPtr(pClassId)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxIteratorSrcBase(FbxObject pObject, FbxClassId pClassId) : this(fbx_wrapperPINVOKE.new_FbxIteratorSrcBase__SWIG_1(FbxObject.getCPtr(pObject), FbxClassId.getCPtr(pClassId)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxObject GetFirst() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetFirst(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetNext() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetNext(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetSafeNext() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetSafeNext(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetLast() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetLast(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetPrevious() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetPrevious(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject GetSafePrevious() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxIteratorSrcBase_GetSafePrevious(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

}

}
