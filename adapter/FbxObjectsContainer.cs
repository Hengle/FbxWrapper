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

public class FbxObjectsContainer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxObjectsContainer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxObjectsContainer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxObjectsContainer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxObjectsContainer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxObjectsContainer() : this(fbx_wrapperPINVOKE.new_FbxObjectsContainer(), true) {
  }

  public SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t mFCurvesT {
    set {
      fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesT_set(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesT_get(swigCPtr);
      SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t mFCurvesR {
    set {
      fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesR_set(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesR_get(swigCPtr);
      SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t mFCurvesS {
    set {
      fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesS_set(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxObjectsContainer_mFCurvesS_get(swigCPtr);
      SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxAnimCurveNode_p_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxArrayT_FbxNode_p_t mNodes {
    set {
      fbx_wrapperPINVOKE.FbxObjectsContainer_mNodes_set(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxObjectsContainer_mNodes_get(swigCPtr);
      SWIGTYPE_p_FbxArrayT_FbxNode_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxArrayT_FbxNode_p_t(cPtr, false);
      return ret;
    } 
  }

  public void ExtractSceneObjects(FbxScene pScene, FbxObjectsContainer.EDepth pDepth, SWIGTYPE_p_FbxArrayT_FbxNodeAttribute__EType_t pFilters) {
    fbx_wrapperPINVOKE.FbxObjectsContainer_ExtractSceneObjects__SWIG_0(swigCPtr, FbxScene.getCPtr(pScene), (int)pDepth, SWIGTYPE_p_FbxArrayT_FbxNodeAttribute__EType_t.getCPtr(pFilters));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ExtractSceneObjects(FbxNode pRootNode, FbxObjectsContainer.EDepth pDepth, SWIGTYPE_p_FbxArrayT_FbxNodeAttribute__EType_t pFilters) {
    fbx_wrapperPINVOKE.FbxObjectsContainer_ExtractSceneObjects__SWIG_1(swigCPtr, FbxNode.getCPtr(pRootNode), (int)pDepth, SWIGTYPE_p_FbxArrayT_FbxNodeAttribute__EType_t.getCPtr(pFilters));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Clear() {
    fbx_wrapperPINVOKE.FbxObjectsContainer_Clear(swigCPtr);
  }

  public enum EDepth {
    eChildOnly,
    eChildAndSubChild,
    eSubChildWithNoScaleInherit
  }

}

}
