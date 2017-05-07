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

public class FbxSceneRenamer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxSceneRenamer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSceneRenamer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxSceneRenamer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxSceneRenamer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxSceneRenamer(FbxScene pScene) : this(fbx_wrapperPINVOKE.new_FbxSceneRenamer(FbxScene.getCPtr(pScene)), true) {
  }

  public void RenameFor(FbxSceneRenamer.ERenamingMode pMode) {
    fbx_wrapperPINVOKE.FbxSceneRenamer_RenameFor(swigCPtr, (int)pMode);
  }

  public enum ERenamingMode {
    eNone,
    eMAYA_TO_FBX5,
    eMAYA_TO_FBX_MB75,
    eMAYA_TO_FBX_MB70,
    eFBXMB75_TO_FBXMB70,
    eFBX_TO_FBX,
    eMAYA_TO_FBX,
    eFBX_TO_MAYA,
    eLW_TO_FBX,
    eFBX_TO_LW,
    eXSI_TO_FBX,
    eFBX_TO_XSI,
    eMAX_TO_FBX,
    eFBX_TO_MAX,
    eMB_TO_FBX,
    eFBX_TO_MB,
    eDAE_TO_FBX,
    eFBX_TO_DAE
  }

}

}
