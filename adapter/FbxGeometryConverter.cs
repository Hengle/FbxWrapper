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

public class FbxGeometryConverter : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxGeometryConverter(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxGeometryConverter obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxGeometryConverter() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxGeometryConverter(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool Triangulate(FbxScene pScene, bool pReplace, bool pLegacy) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_Triangulate__SWIG_0(swigCPtr, FbxScene.getCPtr(pScene), pReplace, pLegacy);
    return ret;
  }

  public bool Triangulate(FbxScene pScene, bool pReplace) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_Triangulate__SWIG_1(swigCPtr, FbxScene.getCPtr(pScene), pReplace);
    return ret;
  }

  public FbxNodeAttribute Triangulate(FbxNodeAttribute pNodeAttribute, bool pReplace, bool pLegacy) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_Triangulate__SWIG_2(swigCPtr, FbxNodeAttribute.getCPtr(pNodeAttribute), pReplace, pLegacy);
    FbxNodeAttribute ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNodeAttribute(cPtr, false);
    return ret;
  }

  public FbxNodeAttribute Triangulate(FbxNodeAttribute pNodeAttribute, bool pReplace) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_Triangulate__SWIG_3(swigCPtr, FbxNodeAttribute.getCPtr(pNodeAttribute), pReplace);
    FbxNodeAttribute ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNodeAttribute(cPtr, false);
    return ret;
  }

  public bool ComputeGeometryControlPointsWeightedMapping(FbxGeometry pSrcGeom, FbxGeometry pDstGeom, FbxWeightedMapping pSrcToDstWeightedMapping, bool pSwapUV) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputeGeometryControlPointsWeightedMapping__SWIG_0(swigCPtr, FbxGeometry.getCPtr(pSrcGeom), FbxGeometry.getCPtr(pDstGeom), FbxWeightedMapping.getCPtr(pSrcToDstWeightedMapping), pSwapUV);
    return ret;
  }

  public bool ComputeGeometryControlPointsWeightedMapping(FbxGeometry pSrcGeom, FbxGeometry pDstGeom, FbxWeightedMapping pSrcToDstWeightedMapping) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputeGeometryControlPointsWeightedMapping__SWIG_1(swigCPtr, FbxGeometry.getCPtr(pSrcGeom), FbxGeometry.getCPtr(pDstGeom), FbxWeightedMapping.getCPtr(pSrcToDstWeightedMapping));
    return ret;
  }

  public FbxNurbs ConvertPatchToNurbs(FbxPatch pPatch) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertPatchToNurbs(swigCPtr, FbxPatch.getCPtr(pPatch));
    FbxNurbs ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbs(cPtr, false);
    return ret;
  }

  public bool ConvertPatchToNurbsInPlace(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertPatchToNurbsInPlace(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public FbxNurbsSurface ConvertPatchToNurbsSurface(FbxPatch pPatch) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertPatchToNurbsSurface(swigCPtr, FbxPatch.getCPtr(pPatch));
    FbxNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsSurface(cPtr, false);
    return ret;
  }

  public bool ConvertPatchToNurbsSurfaceInPlace(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertPatchToNurbsSurfaceInPlace(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public FbxNurbsSurface ConvertNurbsToNurbsSurface(FbxNurbs pNurbs) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertNurbsToNurbsSurface(swigCPtr, FbxNurbs.getCPtr(pNurbs));
    FbxNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsSurface(cPtr, false);
    return ret;
  }

  public FbxNurbs ConvertNurbsSurfaceToNurbs(FbxNurbsSurface pNurbs) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertNurbsSurfaceToNurbs(swigCPtr, FbxNurbsSurface.getCPtr(pNurbs));
    FbxNurbs ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbs(cPtr, false);
    return ret;
  }

  public bool ConvertNurbsToNurbsSurfaceInPlace(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertNurbsToNurbsSurfaceInPlace(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public bool ConvertNurbsSurfaceToNurbsInPlace(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ConvertNurbsSurfaceToNurbsInPlace(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public FbxNurbs FlipNurbs(FbxNurbs pNurbs, bool pSwapUV, bool pSwapClusters) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_FlipNurbs(swigCPtr, FbxNurbs.getCPtr(pNurbs), pSwapUV, pSwapClusters);
    FbxNurbs ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbs(cPtr, false);
    return ret;
  }

  public FbxNurbsSurface FlipNurbsSurface(FbxNurbsSurface pNurbs, bool pSwapUV, bool pSwapClusters) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_FlipNurbsSurface(swigCPtr, FbxNurbsSurface.getCPtr(pNurbs), pSwapUV, pSwapClusters);
    FbxNurbsSurface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNurbsSurface(cPtr, false);
    return ret;
  }

  public bool EmulateNormalsByPolygonVertex(FbxMesh pMesh) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_EmulateNormalsByPolygonVertex(swigCPtr, FbxMesh.getCPtr(pMesh));
    return ret;
  }

  public bool ComputeEdgeSmoothingFromNormals(FbxMesh pMesh) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputeEdgeSmoothingFromNormals(swigCPtr, FbxMesh.getCPtr(pMesh));
    return ret;
  }

  public bool ComputePolygonSmoothingFromEdgeSmoothing(FbxMesh pMesh, int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputePolygonSmoothingFromEdgeSmoothing__SWIG_0(swigCPtr, FbxMesh.getCPtr(pMesh), pIndex);
    return ret;
  }

  public bool ComputePolygonSmoothingFromEdgeSmoothing(FbxMesh pMesh) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputePolygonSmoothingFromEdgeSmoothing__SWIG_1(swigCPtr, FbxMesh.getCPtr(pMesh));
    return ret;
  }

  public bool ComputeEdgeSmoothingFromPolygonSmoothing(FbxMesh pMesh, int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputeEdgeSmoothingFromPolygonSmoothing__SWIG_0(swigCPtr, FbxMesh.getCPtr(pMesh), pIndex);
    return ret;
  }

  public bool ComputeEdgeSmoothingFromPolygonSmoothing(FbxMesh pMesh) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_ComputeEdgeSmoothingFromPolygonSmoothing__SWIG_1(swigCPtr, FbxMesh.getCPtr(pMesh));
    return ret;
  }

  public bool SplitMeshesPerMaterial(FbxScene pScene, bool pReplace) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_SplitMeshesPerMaterial(swigCPtr, FbxScene.getCPtr(pScene), pReplace);
    return ret;
  }

  public bool SplitMeshPerMaterial(FbxMesh pMesh, bool pReplace) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_SplitMeshPerMaterial(swigCPtr, FbxMesh.getCPtr(pMesh), pReplace);
    return ret;
  }

  public bool RecenterSceneToWorldCenter(FbxScene pScene, double pThreshold) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometryConverter_RecenterSceneToWorldCenter(swigCPtr, FbxScene.getCPtr(pScene), pThreshold);
    return ret;
  }

  public FbxNode MergeMeshes(SWIGTYPE_p_FbxArrayT_FbxNode_p_t pMeshNodes, string pNodeName, FbxScene pScene) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometryConverter_MergeMeshes(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pMeshNodes), pNodeName, FbxScene.getCPtr(pScene));
    FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveBadPolygonsFromMeshes(FbxScene pScene, SWIGTYPE_p_FbxArrayT_FbxNode_p_t pAffectedNodes) {
    fbx_wrapperPINVOKE.FbxGeometryConverter_RemoveBadPolygonsFromMeshes__SWIG_0(swigCPtr, FbxScene.getCPtr(pScene), SWIGTYPE_p_FbxArrayT_FbxNode_p_t.getCPtr(pAffectedNodes));
  }

  public void RemoveBadPolygonsFromMeshes(FbxScene pScene) {
    fbx_wrapperPINVOKE.FbxGeometryConverter_RemoveBadPolygonsFromMeshes__SWIG_1(swigCPtr, FbxScene.getCPtr(pScene));
  }

  public FbxGeometryConverter(FbxManager pManager) : this(fbx_wrapperPINVOKE.new_FbxGeometryConverter(FbxManager.getCPtr(pManager)), true) {
  }

}

}
