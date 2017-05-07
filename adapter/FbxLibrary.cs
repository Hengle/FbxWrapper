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

public class FbxLibrary : FbxDocument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLibrary(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLibrary_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLibrary obj) {
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
      fbx_wrapperPINVOKE.FbxLibrary_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxLibrary_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxLibrary Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public new static FbxLibrary Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public new FbxLibrary GetParentLibrary() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_GetParentLibrary(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public void SystemLibrary(bool pSystemLibrary) {
    fbx_wrapperPINVOKE.FbxLibrary_SystemLibrary(swigCPtr, pSystemLibrary);
  }

  public bool IsSystemLibrary() {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_IsSystemLibrary(swigCPtr);
    return ret;
  }

  public void LocalizationBaseNamePrefix(string pPrefix) {
    fbx_wrapperPINVOKE.FbxLibrary_LocalizationBaseNamePrefix__SWIG_0(swigCPtr, pPrefix);
  }

  public FbxString LocalizationBaseNamePrefix() {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxLibrary_LocalizationBaseNamePrefix__SWIG_1(swigCPtr), true);
    return ret;
  }

  public bool AddSubLibrary(FbxLibrary pSubLibrary) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_AddSubLibrary(swigCPtr, FbxLibrary.getCPtr(pSubLibrary));
    return ret;
  }

  public bool RemoveSubLibrary(FbxLibrary pSubLibrary) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_RemoveSubLibrary(swigCPtr, FbxLibrary.getCPtr(pSubLibrary));
    return ret;
  }

  public int GetSubLibraryCount() {
    int ret = fbx_wrapperPINVOKE.FbxLibrary_GetSubLibraryCount(swigCPtr);
    return ret;
  }

  public FbxLibrary GetSubLibrary(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_GetSubLibrary(swigCPtr, pIndex);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public FbxObject CloneAsset(FbxObject pToClone, FbxObject pOptionalDestinationContainer) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_CloneAsset__SWIG_0(swigCPtr, FbxObject.getCPtr(pToClone), FbxObject.getCPtr(pOptionalDestinationContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxObject CloneAsset(FbxObject pToClone) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_CloneAsset__SWIG_1(swigCPtr, FbxObject.getCPtr(pToClone));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public static FbxCriteria GetAssetCriteriaFilter() {
    FbxCriteria ret = new FbxCriteria(fbx_wrapperPINVOKE.FbxLibrary_GetAssetCriteriaFilter(), true);
    return ret;
  }

  public static FbxCriteria GetAssetDependentsFilter() {
    FbxCriteria ret = new FbxCriteria(fbx_wrapperPINVOKE.FbxLibrary_GetAssetDependentsFilter(), true);
    return ret;
  }

  public bool ImportAssets(FbxLibrary pSrcLibrary) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_ImportAssets__SWIG_0(swigCPtr, FbxLibrary.getCPtr(pSrcLibrary));
    return ret;
  }

  public bool ImportAssets(FbxLibrary pSrcLibrary, FbxCriteria pAssetFilter) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_ImportAssets__SWIG_1(swigCPtr, FbxLibrary.getCPtr(pSrcLibrary), FbxCriteria.getCPtr(pAssetFilter));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_FbxLocalizationManager GetLocalizationManager() {
    SWIGTYPE_p_FbxLocalizationManager ret = new SWIGTYPE_p_FbxLocalizationManager(fbx_wrapperPINVOKE.FbxLibrary_GetLocalizationManager(swigCPtr), false);
    return ret;
  }

  public override string Localize(string pID, string pDefault) {
    string ret = fbx_wrapperPINVOKE.FbxLibrary_Localize__SWIG_0(swigCPtr, pID, pDefault);
    return ret;
  }

  public override string Localize(string pID) {
    string ret = fbx_wrapperPINVOKE.FbxLibrary_Localize__SWIG_1(swigCPtr, pID);
    return ret;
  }

  public bool AddShadingObject(FbxObject pShadingObject) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_AddShadingObject(swigCPtr, FbxObject.getCPtr(pShadingObject));
    return ret;
  }

  public bool RemoveShadingObject(FbxObject pShadingObject) {
    bool ret = fbx_wrapperPINVOKE.FbxLibrary_RemoveShadingObject(swigCPtr, FbxObject.getCPtr(pShadingObject));
    return ret;
  }

  public int GetShadingObjectCount() {
    int ret = fbx_wrapperPINVOKE.FbxLibrary_GetShadingObjectCount__SWIG_0(swigCPtr);
    return ret;
  }

  public FbxObject GetShadingObject(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_GetShadingObject__SWIG_0(swigCPtr, pIndex);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public int GetShadingObjectCount(FbxImplementationFilter pCriteria) {
    int ret = fbx_wrapperPINVOKE.FbxLibrary_GetShadingObjectCount__SWIG_1(swigCPtr, FbxImplementationFilter.getCPtr(pCriteria));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxObject GetShadingObject(int pIndex, FbxImplementationFilter pCriteria) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLibrary_GetShadingObject__SWIG_1(swigCPtr, pIndex, FbxImplementationFilter.getCPtr(pCriteria));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
