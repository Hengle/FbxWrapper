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

public class FbxManager : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxManager(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxManager obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxManager Create() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_Create();
    FbxManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxManager(cPtr, false);
    return ret;
  }

  public virtual void Destroy() {
    fbx_wrapperPINVOKE.FbxManager_Destroy(swigCPtr);
  }

  public static string GetVersion(bool pFull) {
    string ret = fbx_wrapperPINVOKE.FbxManager_GetVersion__SWIG_0(pFull);
    return ret;
  }

  public static string GetVersion() {
    string ret = fbx_wrapperPINVOKE.FbxManager_GetVersion__SWIG_1();
    return ret;
  }

  public static void GetFileFormatVersion(SWIGTYPE_p_int pMajor, SWIGTYPE_p_int pMinor, SWIGTYPE_p_int pRevision) {
    fbx_wrapperPINVOKE.FbxManager_GetFileFormatVersion(SWIGTYPE_p_int.getCPtr(pMajor), SWIGTYPE_p_int.getCPtr(pMinor), SWIGTYPE_p_int.getCPtr(pRevision));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UnregisterRuntimeFbxClass(string pName) {
    fbx_wrapperPINVOKE.FbxManager_UnregisterRuntimeFbxClass(swigCPtr, pName);
  }

  public FbxObject CreateNewObjectFromClassId(FbxClassId pClassId, string pName, FbxObject pContainer, FbxObject pCloneFrom) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_CreateNewObjectFromClassId__SWIG_0(swigCPtr, FbxClassId.getCPtr(pClassId), pName, FbxObject.getCPtr(pContainer), FbxObject.getCPtr(pCloneFrom));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxObject CreateNewObjectFromClassId(FbxClassId pClassId, string pName, FbxObject pContainer) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_CreateNewObjectFromClassId__SWIG_1(swigCPtr, FbxClassId.getCPtr(pClassId), pName, FbxObject.getCPtr(pContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxObject CreateNewObjectFromClassId(FbxClassId pClassId, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_CreateNewObjectFromClassId__SWIG_2(swigCPtr, FbxClassId.getCPtr(pClassId), pName);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxClassId FindClass(string pClassName) {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxManager_FindClass(swigCPtr, pClassName), true);
    return ret;
  }

  public FbxClassId FindFbxFileClass(string pFbxFileTypeName, string pFbxFileSubTypeName) {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxManager_FindFbxFileClass(swigCPtr, pFbxFileTypeName, pFbxFileSubTypeName), true);
    return ret;
  }

  public FbxDataType CreateDataType(string pName, EFbxType pType) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxManager_CreateDataType(swigCPtr, pName, (int)pType), true);
    return ret;
  }

  public int GetDataTypeCount() {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetDataTypeCount(swigCPtr);
    return ret;
  }

  public FbxDataType GetDataType(int pIndex) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxManager_GetDataType(swigCPtr, pIndex), false);
    return ret;
  }

  public FbxDataType GetDataTypeFromName(string pDataType) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxManager_GetDataTypeFromName(swigCPtr, pDataType), false);
    return ret;
  }

  public FbxUserNotification GetUserNotification() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetUserNotification(swigCPtr);
    FbxUserNotification ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxUserNotification(cPtr, false);
    return ret;
  }

  public void SetUserNotification(FbxUserNotification pUN) {
    fbx_wrapperPINVOKE.FbxManager_SetUserNotification(swigCPtr, FbxUserNotification.getCPtr(pUN));
  }

  public virtual FbxIOSettings GetIOSettings() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetIOSettings(swigCPtr);
    FbxIOSettings ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOSettings(cPtr, false);
    return ret;
  }

  public virtual void SetIOSettings(FbxIOSettings pIOSettings) {
    fbx_wrapperPINVOKE.FbxManager_SetIOSettings(swigCPtr, FbxIOSettings.getCPtr(pIOSettings));
  }

  public SWIGTYPE_p_FbxMessageEmitter GetMessageEmitter() {
    SWIGTYPE_p_FbxMessageEmitter ret = new SWIGTYPE_p_FbxMessageEmitter(fbx_wrapperPINVOKE.FbxManager_GetMessageEmitter(swigCPtr), false);
    return ret;
  }

  public bool SetMessageEmitter(SWIGTYPE_p_FbxMessageEmitter pMessageEmitter) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_SetMessageEmitter(swigCPtr, SWIGTYPE_p_FbxMessageEmitter.getCPtr(pMessageEmitter));
    return ret;
  }

  public void AddLocalization(SWIGTYPE_p_FbxLocalizationManager pLocManager) {
    fbx_wrapperPINVOKE.FbxManager_AddLocalization(swigCPtr, SWIGTYPE_p_FbxLocalizationManager.getCPtr(pLocManager));
  }

  public void RemoveLocalization(SWIGTYPE_p_FbxLocalizationManager pLocManager) {
    fbx_wrapperPINVOKE.FbxManager_RemoveLocalization(swigCPtr, SWIGTYPE_p_FbxLocalizationManager.getCPtr(pLocManager));
  }

  public bool SetLocale(string pLocale) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_SetLocale(swigCPtr, pLocale);
    return ret;
  }

  public string Localize(string pID, string pDefault) {
    string ret = fbx_wrapperPINVOKE.FbxManager_Localize__SWIG_0(swigCPtr, pID, pDefault);
    return ret;
  }

  public string Localize(string pID) {
    string ret = fbx_wrapperPINVOKE.FbxManager_Localize__SWIG_1(swigCPtr, pID);
    return ret;
  }

  public FbxXRefManager GetXRefManager() {
    FbxXRefManager ret = new FbxXRefManager(fbx_wrapperPINVOKE.FbxManager_GetXRefManager(swigCPtr), false);
    return ret;
  }

  public FbxLibrary GetRootLibrary() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetRootLibrary(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public FbxLibrary GetSystemLibraries() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetSystemLibraries(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public FbxLibrary GetUserLibraries() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetUserLibraries(swigCPtr);
    FbxLibrary ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLibrary(cPtr, false);
    return ret;
  }

  public FbxIOPluginRegistry GetIOPluginRegistry() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetIOPluginRegistry(swigCPtr);
    FbxIOPluginRegistry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxIOPluginRegistry(cPtr, false);
    return ret;
  }

  public bool LoadPluginsDirectory(string pFilename, string pExtensions) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_LoadPluginsDirectory__SWIG_0(swigCPtr, pFilename, pExtensions);
    return ret;
  }

  public bool LoadPluginsDirectory(string pFilename) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_LoadPluginsDirectory__SWIG_1(swigCPtr, pFilename);
    return ret;
  }

  public bool LoadPlugin(string pFilename) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_LoadPlugin(swigCPtr, pFilename);
    return ret;
  }

  public bool UnloadPlugins() {
    bool ret = fbx_wrapperPINVOKE.FbxManager_UnloadPlugins(swigCPtr);
    return ret;
  }

  public bool EmitPluginsEvent(FbxEventBase pEvent) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_EmitPluginsEvent(swigCPtr, FbxEventBase.getCPtr(pEvent));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_FbxArrayT_FbxPlugin_const_p_t GetPlugins() {
    SWIGTYPE_p_FbxArrayT_FbxPlugin_const_p_t ret = new SWIGTYPE_p_FbxArrayT_FbxPlugin_const_p_t(fbx_wrapperPINVOKE.FbxManager_GetPlugins(swigCPtr), true);
    return ret;
  }

  public int GetPluginCount() {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetPluginCount(swigCPtr);
    return ret;
  }

  public FbxPlugin FindPlugin(string pName, string pVersion) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_FindPlugin(swigCPtr, pName, pVersion);
    FbxPlugin ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPlugin(cPtr, false);
    return ret;
  }

  public void FillIOSettingsForReadersRegistered(FbxIOSettings pIOS) {
    fbx_wrapperPINVOKE.FbxManager_FillIOSettingsForReadersRegistered(swigCPtr, FbxIOSettings.getCPtr(pIOS));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void FillIOSettingsForWritersRegistered(FbxIOSettings pIOS) {
    fbx_wrapperPINVOKE.FbxManager_FillIOSettingsForWritersRegistered(swigCPtr, FbxIOSettings.getCPtr(pIOS));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void FillCommonIOSettings(FbxIOSettings pIOS, bool pImport) {
    fbx_wrapperPINVOKE.FbxManager_FillCommonIOSettings(swigCPtr, FbxIOSettings.getCPtr(pIOS), pImport);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RegisterObject(FbxObject pObject) {
    fbx_wrapperPINVOKE.FbxManager_RegisterObject(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public void UnregisterObject(FbxObject pObject) {
    fbx_wrapperPINVOKE.FbxManager_UnregisterObject(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public void RegisterObjects(SWIGTYPE_p_FbxArrayT_FbxObject_p_t pArray) {
    fbx_wrapperPINVOKE.FbxManager_RegisterObjects(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxObject_p_t.getCPtr(pArray));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UnregisterObjects(SWIGTYPE_p_FbxArrayT_FbxObject_p_t pArray) {
    fbx_wrapperPINVOKE.FbxManager_UnregisterObjects(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxObject_p_t.getCPtr(pArray));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void IncreaseDestroyingSceneFlag() {
    fbx_wrapperPINVOKE.FbxManager_IncreaseDestroyingSceneFlag(swigCPtr);
  }

  public void DecreaseDestroyingSceneFlag() {
    fbx_wrapperPINVOKE.FbxManager_DecreaseDestroyingSceneFlag(swigCPtr);
  }

  public int GetReferenceCount() {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetReferenceCount(swigCPtr);
    return ret;
  }

  public FbxSceneReference GetReference(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetReference(swigCPtr, pIndex);
    FbxSceneReference ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSceneReference(cPtr, false);
    return ret;
  }

  public int AddReference(FbxSceneReference pReference) {
    int ret = fbx_wrapperPINVOKE.FbxManager_AddReference(swigCPtr, FbxSceneReference.getCPtr(pReference));
    return ret;
  }

  public bool RemoveReference(FbxSceneReference pReference) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_RemoveReference(swigCPtr, FbxSceneReference.getCPtr(pReference));
    return ret;
  }

  public bool ClearReference(FbxSceneReference pReference) {
    bool ret = fbx_wrapperPINVOKE.FbxManager_ClearReference(swigCPtr, FbxSceneReference.getCPtr(pReference));
    return ret;
  }

  public static FbxString PrefixName(string pPrefix, string pName) {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxManager_PrefixName(pPrefix, pName), true);
    return ret;
  }

  public int GetDocumentCount() {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetDocumentCount(swigCPtr);
    return ret;
  }

  public FbxDocument GetDocument(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetDocument(swigCPtr, pIndex);
    FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
    return ret;
  }

  public static FbxManager GetDefaultManager() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxManager_GetDefaultManager();
    FbxManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxManager(cPtr, false);
    return ret;
  }

  public void CreateMissingBindPoses(FbxScene pScene) {
    fbx_wrapperPINVOKE.FbxManager_CreateMissingBindPoses(swigCPtr, FbxScene.getCPtr(pScene));
  }

  public int GetBindPoseCount(FbxScene pScene) {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetBindPoseCount(swigCPtr, FbxScene.getCPtr(pScene));
    return ret;
  }

  public int GetFbxClassCount() {
    int ret = fbx_wrapperPINVOKE.FbxManager_GetFbxClassCount(swigCPtr);
    return ret;
  }

  public FbxClassId GetNextFbxClass(FbxClassId pClassId) {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxManager_GetNextFbxClass(swigCPtr, FbxClassId.getCPtr(pClassId)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
