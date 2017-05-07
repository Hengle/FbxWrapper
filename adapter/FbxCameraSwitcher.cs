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

public class FbxCameraSwitcher : FbxNodeAttribute {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxCameraSwitcher(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxCameraSwitcher_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCameraSwitcher obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      fbx_wrapperPINVOKE.FbxCameraSwitcher_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraSwitcher_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxCameraSwitcher_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxCameraSwitcher Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraSwitcher_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxCameraSwitcher ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCameraSwitcher(cPtr, false);
    return ret;
  }

  public new static FbxCameraSwitcher Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraSwitcher_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxCameraSwitcher ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCameraSwitcher(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_int_t CameraIndex {
    set {
      fbx_wrapperPINVOKE.FbxCameraSwitcher_CameraIndex_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCameraSwitcher_CameraIndex_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_int_t(cPtr, false);
      return ret;
    } 
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxCameraSwitcher_GetAttributeType(swigCPtr);
    return ret;
  }

  public int GetDefaultCameraIndex() {
    int ret = fbx_wrapperPINVOKE.FbxCameraSwitcher_GetDefaultCameraIndex(swigCPtr);
    return ret;
  }

  public void SetDefaultCameraIndex(int pIndex) {
    fbx_wrapperPINVOKE.FbxCameraSwitcher_SetDefaultCameraIndex(swigCPtr, pIndex);
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(fbx_wrapperPINVOKE.FbxCameraSwitcher_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddCameraName(string pCameraName) {
    fbx_wrapperPINVOKE.FbxCameraSwitcher_AddCameraName(swigCPtr, pCameraName);
  }

  public string GetCameraName(uint pIndex) {
    string ret = fbx_wrapperPINVOKE.FbxCameraSwitcher_GetCameraName(swigCPtr, pIndex);
    return ret;
  }

  public uint GetCameraNameCount() {
    uint ret = fbx_wrapperPINVOKE.FbxCameraSwitcher_GetCameraNameCount(swigCPtr);
    return ret;
  }

  public void ClearCameraNames() {
    fbx_wrapperPINVOKE.FbxCameraSwitcher_ClearCameraNames(swigCPtr);
  }

}

}
