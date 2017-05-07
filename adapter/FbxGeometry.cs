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

public class FbxGeometry : FbxGeometryBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxGeometry(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxGeometry_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxGeometry obj) {
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
      fbx_wrapperPINVOKE.FbxGeometry_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxGeometry_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxGeometry Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxGeometry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometry(cPtr, false);
    return ret;
  }

  public new static FbxGeometry Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxGeometry ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometry(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxGeometry_GetAttributeType(swigCPtr);
    return ret;
  }

  public int AddDeformer(FbxDeformer pDeformer) {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_AddDeformer(swigCPtr, FbxDeformer.getCPtr(pDeformer));
    return ret;
  }

  public FbxDeformer RemoveDeformer(int pIndex, FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_RemoveDeformer__SWIG_0(swigCPtr, pIndex, FbxStatus.getCPtr(pStatus));
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public FbxDeformer RemoveDeformer(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_RemoveDeformer__SWIG_1(swigCPtr, pIndex);
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public int GetDeformerCount() {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetDeformerCount__SWIG_0(swigCPtr);
    return ret;
  }

  public FbxDeformer GetDeformer(int pIndex, FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetDeformer__SWIG_0(swigCPtr, pIndex, FbxStatus.getCPtr(pStatus));
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public FbxDeformer GetDeformer(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetDeformer__SWIG_1(swigCPtr, pIndex);
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public int GetDeformerCount(FbxDeformer.EDeformerType pType) {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetDeformerCount__SWIG_1(swigCPtr, (int)pType);
    return ret;
  }

  public FbxDeformer GetDeformer(int pIndex, FbxDeformer.EDeformerType pType, FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetDeformer__SWIG_2(swigCPtr, pIndex, (int)pType, FbxStatus.getCPtr(pStatus));
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public FbxDeformer GetDeformer(int pIndex, FbxDeformer.EDeformerType pType) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetDeformer__SWIG_3(swigCPtr, pIndex, (int)pType);
    FbxDeformer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDeformer(cPtr, false);
    return ret;
  }

  public FbxGeometryWeightedMap GetSourceGeometryWeightedMap() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetSourceGeometryWeightedMap(swigCPtr);
    FbxGeometryWeightedMap ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometryWeightedMap(cPtr, false);
    return ret;
  }

  public int GetDestinationGeometryWeightedMapCount() {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetDestinationGeometryWeightedMapCount(swigCPtr);
    return ret;
  }

  public FbxGeometryWeightedMap GetDestinationGeometryWeightedMap(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetDestinationGeometryWeightedMap(swigCPtr, pIndex);
    FbxGeometryWeightedMap ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxGeometryWeightedMap(cPtr, false);
    return ret;
  }

  public bool AddShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxShape pShape, double pPercent, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometry_AddShape__SWIG_0(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxShape.getCPtr(pShape), pPercent, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool AddShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxShape pShape, double pPercent) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometry_AddShape__SWIG_1(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxShape.getCPtr(pShape), pPercent);
    return ret;
  }

  public bool AddShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxShape pShape) {
    bool ret = fbx_wrapperPINVOKE.FbxGeometry_AddShape__SWIG_2(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxShape.getCPtr(pShape));
    return ret;
  }

  public void ClearShape() {
    fbx_wrapperPINVOKE.FbxGeometry_ClearShape(swigCPtr);
  }

  public int GetShapeCount() {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetShapeCount__SWIG_0(swigCPtr);
    return ret;
  }

  public int GetShapeCount(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxStatus pStatus) {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetShapeCount__SWIG_1(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public int GetShapeCount(int pBlendShapeIndex, int pBlendShapeChannelIndex) {
    int ret = fbx_wrapperPINVOKE.FbxGeometry_GetShapeCount__SWIG_2(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex);
    return ret;
  }

  public FbxShape GetShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, int pShapeIndex, FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetShape__SWIG_0(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, pShapeIndex, FbxStatus.getCPtr(pStatus));
    FbxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxShape(cPtr, false);
    return ret;
  }

  public FbxShape GetShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, int pShapeIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetShape__SWIG_1(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, pShapeIndex);
    FbxShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxShape(cPtr, false);
    return ret;
  }

  public FbxAnimCurve GetShapeChannel(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxAnimLayer pLayer, bool pCreateAsNeeded, FbxStatus pStatus) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetShapeChannel__SWIG_0(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxAnimLayer.getCPtr(pLayer), pCreateAsNeeded, FbxStatus.getCPtr(pStatus));
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

  public FbxAnimCurve GetShapeChannel(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxAnimLayer pLayer, bool pCreateAsNeeded) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetShapeChannel__SWIG_1(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxAnimLayer.getCPtr(pLayer), pCreateAsNeeded);
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

  public FbxAnimCurve GetShapeChannel(int pBlendShapeIndex, int pBlendShapeChannelIndex, FbxAnimLayer pLayer) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_GetShapeChannel__SWIG_2(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, FbxAnimLayer.getCPtr(pLayer));
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

  public FbxAMatrix GetPivot(FbxAMatrix pXMatrix) {
    FbxAMatrix ret = new FbxAMatrix(fbx_wrapperPINVOKE.FbxGeometry_GetPivot(swigCPtr, FbxAMatrix.getCPtr(pXMatrix)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPivot(FbxAMatrix pXMatrix) {
    fbx_wrapperPINVOKE.FbxGeometry_SetPivot(swigCPtr, FbxAMatrix.getCPtr(pXMatrix));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ApplyPivot() {
    fbx_wrapperPINVOKE.FbxGeometry_ApplyPivot(swigCPtr);
  }

  public void SetDefaultShape(int pBlendShapeIndex, int pBlendShapeChannelIndex, double pPercent) {
    fbx_wrapperPINVOKE.FbxGeometry_SetDefaultShape__SWIG_0(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex, pPercent);
  }

  public void SetDefaultShape(FbxBlendShapeChannel pBlendShapeChannel, double pPercent) {
    fbx_wrapperPINVOKE.FbxGeometry_SetDefaultShape__SWIG_1(swigCPtr, FbxBlendShapeChannel.getCPtr(pBlendShapeChannel), pPercent);
  }

  public double GetDefaultShape(int pBlendShapeIndex, int pBlendShapeChannelIndex) {
    double ret = fbx_wrapperPINVOKE.FbxGeometry_GetDefaultShape__SWIG_0(swigCPtr, pBlendShapeIndex, pBlendShapeChannelIndex);
    return ret;
  }

  public double GetDefaultShape(FbxBlendShapeChannel pBlendShapeChannel) {
    double ret = fbx_wrapperPINVOKE.FbxGeometry_GetDefaultShape__SWIG_1(swigCPtr, FbxBlendShapeChannel.getCPtr(pBlendShapeChannel));
    return ret;
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(fbx_wrapperPINVOKE.FbxGeometry_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType, FbxObject pContainer, SWIGTYPE_p_void pSet) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Clone__SWIG_0(swigCPtr, (int)pCloneType, FbxObject.getCPtr(pContainer), SWIGTYPE_p_void.getCPtr(pSet));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType, FbxObject pContainer) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Clone__SWIG_1(swigCPtr, (int)pCloneType, FbxObject.getCPtr(pContainer));
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone(FbxObject.ECloneType pCloneType) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Clone__SWIG_2(swigCPtr, (int)pCloneType);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public override FbxObject Clone() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxGeometry_Clone__SWIG_3(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public void CleanShapeChannels(FbxAnimLayer pAnimLayer) {
    fbx_wrapperPINVOKE.FbxGeometry_CleanShapeChannels(swigCPtr, FbxAnimLayer.getCPtr(pAnimLayer));
  }

  public void CleanShapeChannel(FbxAnimLayer pAnimLayer, int pShapeIndex) {
    fbx_wrapperPINVOKE.FbxGeometry_CleanShapeChannel(swigCPtr, FbxAnimLayer.getCPtr(pAnimLayer), pShapeIndex);
  }

  public void CreateShapeChannelProperties(FbxString pShapeName) {
    fbx_wrapperPINVOKE.FbxGeometry_CreateShapeChannelProperties(swigCPtr, FbxString.getCPtr(pShapeName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ConvertShapeNamesToV5Format(FbxString pTakeNodeName) {
    fbx_wrapperPINVOKE.FbxGeometry_ConvertShapeNamesToV5Format__SWIG_0(swigCPtr, FbxString.getCPtr(pTakeNodeName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ConvertShapeNamesToV5Format(FbxString pTakeNodeName, int pShapeIndex) {
    fbx_wrapperPINVOKE.FbxGeometry_ConvertShapeNamesToV5Format__SWIG_1(swigCPtr, FbxString.getCPtr(pTakeNodeName), pShapeIndex);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RevertShapeNamesToV6Format(FbxString pTakeNodeName) {
    fbx_wrapperPINVOKE.FbxGeometry_RevertShapeNamesToV6Format__SWIG_0(swigCPtr, FbxString.getCPtr(pTakeNodeName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RevertShapeNamesToV6Format(FbxString pTakeNodeName, int pShapeIndex) {
    fbx_wrapperPINVOKE.FbxGeometry_RevertShapeNamesToV6Format__SWIG_1(swigCPtr, FbxString.getCPtr(pTakeNodeName), pShapeIndex);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearTemporaryShapeNames() {
    fbx_wrapperPINVOKE.FbxGeometry_ClearTemporaryShapeNames(swigCPtr);
  }

  public enum ESurfaceMode {
    eRaw,
    eLowNoNormals,
    eLow,
    eHighNoNormals,
    eHigh
  }

}

}
