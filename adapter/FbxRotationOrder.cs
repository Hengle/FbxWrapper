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

public class FbxRotationOrder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxRotationOrder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRotationOrder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxRotationOrder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxRotationOrder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxRotationOrder(FbxEuler.EOrder pOrder) : this(fbx_wrapperPINVOKE.new_FbxRotationOrder__SWIG_0((int)pOrder), true) {
  }

  public FbxRotationOrder() : this(fbx_wrapperPINVOKE.new_FbxRotationOrder__SWIG_1(), true) {
  }

  public FbxEuler.EOrder GetOrder() {
    FbxEuler.EOrder ret = (FbxEuler.EOrder)fbx_wrapperPINVOKE.FbxRotationOrder_GetOrder(swigCPtr);
    return ret;
  }

  public void SetOrder(FbxEuler.EOrder pOrder) {
    fbx_wrapperPINVOKE.FbxRotationOrder_SetOrder(swigCPtr, (int)pOrder);
  }

  public void V2M(FbxAMatrix pRM, FbxVector4 pV) {
    fbx_wrapperPINVOKE.FbxRotationOrder_V2M(swigCPtr, FbxAMatrix.getCPtr(pRM), FbxVector4.getCPtr(pV));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void M2V(FbxVector4 pV, FbxAMatrix pRM) {
    fbx_wrapperPINVOKE.FbxRotationOrder_M2V(swigCPtr, FbxVector4.getCPtr(pV), FbxAMatrix.getCPtr(pRM));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool V2VRef(FbxVector4 pVOut, FbxVector4 pVIn, FbxVector4 pVRef) {
    bool ret = fbx_wrapperPINVOKE.FbxRotationOrder_V2VRef(swigCPtr, FbxVector4.getCPtr(pVOut), FbxVector4.getCPtr(pVIn), FbxVector4.getCPtr(pVRef));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
