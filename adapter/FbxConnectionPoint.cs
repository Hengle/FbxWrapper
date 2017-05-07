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

public class FbxConnectionPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxConnectionPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxConnectionPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxConnectionPoint() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxConnectionPoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxConnectionPoint(SWIGTYPE_p_void pData) : this(fbx_wrapperPINVOKE.new_FbxConnectionPoint__SWIG_0(SWIGTYPE_p_void.getCPtr(pData)), true) {
  }

  public FbxConnectionPoint() : this(fbx_wrapperPINVOKE.new_FbxConnectionPoint__SWIG_1(), true) {
  }

  public void SetFilter(FbxConnectionPointFilter pConnectFilter, FbxConnectionPoint.EType pType) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetFilter__SWIG_0(swigCPtr, FbxConnectionPointFilter.getCPtr(pConnectFilter), (int)pType);
  }

  public void SetFilter(FbxConnectionPointFilter pConnectFilter) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetFilter__SWIG_1(swigCPtr, FbxConnectionPointFilter.getCPtr(pConnectFilter));
  }

  public void InternalClear() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_InternalClear(swigCPtr);
  }

  public void WipeConnectionList() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_WipeConnectionList(swigCPtr);
  }

  public void Destroy() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_Destroy(swigCPtr);
  }

  public void SubConnectRemoveAll() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SubConnectRemoveAll(swigCPtr);
  }

  public FbxConnectionPoint GetSubOwnerConnect() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetSubOwnerConnect(swigCPtr);
    FbxConnectionPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPoint(cPtr, false);
    return ret;
  }

  public FbxConnectionPointFilter GetFilter() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetFilter(swigCPtr);
    FbxConnectionPointFilter ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPointFilter(cPtr, false);
    return ret;
  }

  public virtual bool IsInReplace(FbxConnectionPoint p1, FbxConnectionPoint p2) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsInReplace(swigCPtr, FbxConnectionPoint.getCPtr(p1), FbxConnectionPoint.getCPtr(p2));
    return ret;
  }

  public void SetConnectType(FbxConnectionPoint.EType pType) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetConnectType(swigCPtr, (int)pType);
  }

  public FbxConnectionPoint.EType GetConnectType() {
    FbxConnectionPoint.EType ret = (FbxConnectionPoint.EType)fbx_wrapperPINVOKE.FbxConnectionPoint_GetConnectType(swigCPtr);
    return ret;
  }

  public void SetDirection(int pDirections) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetDirection(swigCPtr, pDirections);
  }

  public FbxConnectionPoint.EDirection GetDirection() {
    FbxConnectionPoint.EDirection ret = (FbxConnectionPoint.EDirection)fbx_wrapperPINVOKE.FbxConnectionPoint_GetDirection(swigCPtr);
    return ret;
  }

  public void SetAttribute(int pAttributes) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetAttribute(swigCPtr, pAttributes);
  }

  public FbxConnectionPoint.EAttribute GetAttribute() {
    FbxConnectionPoint.EAttribute ret = (FbxConnectionPoint.EAttribute)fbx_wrapperPINVOKE.FbxConnectionPoint_GetAttribute(swigCPtr);
    return ret;
  }

  public void SetAllocatedFlag(bool pBool) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetAllocatedFlag(swigCPtr, pBool);
  }

  public bool GetAllocatedFlag() {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetAllocatedFlag(swigCPtr);
    return ret;
  }

  public void SetCleanedFlag(bool pBool) {
    fbx_wrapperPINVOKE.FbxConnectionPoint_SetCleanedFlag(swigCPtr, pBool);
  }

  public bool GetCleanedFlag() {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetCleanedFlag(swigCPtr);
    return ret;
  }

  public bool IsValidSrc(FbxConnectionPoint pConnect) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsValidSrc(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public bool IsValidDst(FbxConnectionPoint pConnect) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsValidDst(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public bool IsValidSrcConnection(FbxConnectionPoint pConnect, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsValidSrcConnection(swigCPtr, FbxConnectionPoint.getCPtr(pConnect), (int)pConnectionType);
    return ret;
  }

  public bool IsValidDstConnection(FbxConnectionPoint pConnect, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsValidDstConnection(swigCPtr, FbxConnectionPoint.getCPtr(pConnect), (int)pConnectionType);
    return ret;
  }

  public bool RequestValidSrcConnection(FbxConnectionPoint pConnect, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_RequestValidSrcConnection(swigCPtr, FbxConnectionPoint.getCPtr(pConnect), (int)pConnectionType);
    return ret;
  }

  public bool RequestValidDstConnection(FbxConnectionPoint pConnect, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_RequestValidDstConnection(swigCPtr, FbxConnectionPoint.getCPtr(pConnect), (int)pConnectionType);
    return ret;
  }

  public bool ConnectSrc(FbxConnectionPoint pSrc, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectSrc__SWIG_0(swigCPtr, FbxConnectionPoint.getCPtr(pSrc), (int)pConnectionType);
    return ret;
  }

  public bool ConnectSrc(FbxConnectionPoint pSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectSrc__SWIG_1(swigCPtr, FbxConnectionPoint.getCPtr(pSrc));
    return ret;
  }

  public bool ConnectDst(FbxConnectionPoint pDst, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectDst__SWIG_0(swigCPtr, FbxConnectionPoint.getCPtr(pDst), (int)pConnectionType);
    return ret;
  }

  public bool ConnectDst(FbxConnectionPoint pDst) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectDst__SWIG_1(swigCPtr, FbxConnectionPoint.getCPtr(pDst));
    return ret;
  }

  public bool ConnectSrcAt(int pDst_SrcIndex, FbxConnectionPoint pSrc, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectSrcAt__SWIG_0(swigCPtr, pDst_SrcIndex, FbxConnectionPoint.getCPtr(pSrc), (int)pConnectionType);
    return ret;
  }

  public bool ConnectSrcAt(int pDst_SrcIndex, FbxConnectionPoint pSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectSrcAt__SWIG_1(swigCPtr, pDst_SrcIndex, FbxConnectionPoint.getCPtr(pSrc));
    return ret;
  }

  public bool ConnectDstAt(int pSrc_DstIndex, FbxConnectionPoint pDst, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectDstAt__SWIG_0(swigCPtr, pSrc_DstIndex, FbxConnectionPoint.getCPtr(pDst), (int)pConnectionType);
    return ret;
  }

  public bool ConnectDstAt(int pSrc_DstIndex, FbxConnectionPoint pDst) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectDstAt__SWIG_1(swigCPtr, pSrc_DstIndex, FbxConnectionPoint.getCPtr(pDst));
    return ret;
  }

  public static bool ConnectConnect(FbxConnectionPoint pSrc, FbxConnectionPoint pDst, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectConnect(FbxConnectionPoint.getCPtr(pSrc), FbxConnectionPoint.getCPtr(pDst), (int)pConnectionType);
    return ret;
  }

  public static bool ConnectAt(FbxConnectionPoint pSrc, int pSrc_DstIndex, FbxConnectionPoint pDst, int pDst_SrcIndex, FbxConnection.EType pConnectionType) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ConnectAt(FbxConnectionPoint.getCPtr(pSrc), pSrc_DstIndex, FbxConnectionPoint.getCPtr(pDst), pDst_SrcIndex, (int)pConnectionType);
    return ret;
  }

  public bool DisconnectDst(FbxConnectionPoint pSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectDst(swigCPtr, FbxConnectionPoint.getCPtr(pSrc));
    return ret;
  }

  public bool DisconnectSrc(FbxConnectionPoint pSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectSrc(swigCPtr, FbxConnectionPoint.getCPtr(pSrc));
    return ret;
  }

  public void DisconnectAllSrc() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectAllSrc(swigCPtr);
  }

  public void DisconnectAllDst() {
    fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectAllDst(swigCPtr);
  }

  public static bool DisconnectConnect(FbxConnectionPoint pSrc, FbxConnectionPoint pDst) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectConnect(FbxConnectionPoint.getCPtr(pSrc), FbxConnectionPoint.getCPtr(pDst));
    return ret;
  }

  public bool DisconnectDstAt(int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectDstAt(swigCPtr, pIndex);
    return ret;
  }

  public bool DisconnectSrcAt(int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_DisconnectSrcAt(swigCPtr, pIndex);
    return ret;
  }

  public bool ReplaceInDst(FbxConnectionPoint pDstOld, FbxConnectionPoint pDstNew, int pIndexInNew) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ReplaceInDst(swigCPtr, FbxConnectionPoint.getCPtr(pDstOld), FbxConnectionPoint.getCPtr(pDstNew), pIndexInNew);
    return ret;
  }

  public bool ReplaceInSrc(FbxConnectionPoint pSrcOld, FbxConnectionPoint pSrcNew, int pIndexInNew) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ReplaceInSrc(swigCPtr, FbxConnectionPoint.getCPtr(pSrcOld), FbxConnectionPoint.getCPtr(pSrcNew), pIndexInNew);
    return ret;
  }

  public bool ReplaceDstAt(int pIndex, FbxConnectionPoint pDst) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ReplaceDstAt(swigCPtr, pIndex, FbxConnectionPoint.getCPtr(pDst));
    return ret;
  }

  public bool ReplaceSrcAt(int pIndex, FbxConnectionPoint pSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_ReplaceSrcAt(swigCPtr, pIndex, FbxConnectionPoint.getCPtr(pSrc));
    return ret;
  }

  public bool SwapSrc(int pIndexA, int pIndexB) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_SwapSrc(swigCPtr, pIndexA, pIndexB);
    return ret;
  }

  public bool MoveSrcAt(int pIndex, int pAtIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_MoveSrcAt__SWIG_0(swigCPtr, pIndex, pAtIndex);
    return ret;
  }

  public bool MoveSrcAt(FbxConnectionPoint pSrc, FbxConnectionPoint pAtSrc) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_MoveSrcAt__SWIG_1(swigCPtr, FbxConnectionPoint.getCPtr(pSrc), FbxConnectionPoint.getCPtr(pAtSrc));
    return ret;
  }

  public bool IsConnectedSrc(FbxConnectionPoint arg0) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsConnectedSrc(swigCPtr, FbxConnectionPoint.getCPtr(arg0));
    return ret;
  }

  public bool IsConnectedDst(FbxConnectionPoint arg0) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsConnectedDst(swigCPtr, FbxConnectionPoint.getCPtr(arg0));
    return ret;
  }

  public bool IsConnected(FbxConnectionPoint pConnect) {
    bool ret = fbx_wrapperPINVOKE.FbxConnectionPoint_IsConnected(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public int GetSrcCount() {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrcCount__SWIG_0(swigCPtr);
    return ret;
  }

  public FbxConnectionPoint GetSrc(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrc__SWIG_0(swigCPtr, pIndex);
    FbxConnectionPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPoint(cPtr, false);
    return ret;
  }

  public FbxConnection.EType GetSrcType(int pIndex) {
    FbxConnection.EType ret = (FbxConnection.EType)fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrcType__SWIG_0(swigCPtr, pIndex);
    return ret;
  }

  public int GetDstCount() {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetDstCount__SWIG_0(swigCPtr);
    return ret;
  }

  public FbxConnectionPoint GetDst(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetDst__SWIG_0(swigCPtr, pIndex);
    FbxConnectionPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPoint(cPtr, false);
    return ret;
  }

  public FbxConnection.EType GetDstType(int pIndex) {
    FbxConnection.EType ret = (FbxConnection.EType)fbx_wrapperPINVOKE.FbxConnectionPoint_GetDstType__SWIG_0(swigCPtr, pIndex);
    return ret;
  }

  public int FindSrc(FbxConnectionPoint pConnect) {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_FindSrc(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public int FindDst(FbxConnectionPoint pConnect) {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_FindDst(swigCPtr, FbxConnectionPoint.getCPtr(pConnect));
    return ret;
  }

  public int GetSrcCount(FbxConnectionPointFilter pFilter) {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrcCount__SWIG_1(swigCPtr, FbxConnectionPointFilter.getCPtr(pFilter));
    return ret;
  }

  public FbxConnectionPoint GetSrc(int pIndex, FbxConnectionPointFilter pFilter) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrc__SWIG_1(swigCPtr, pIndex, FbxConnectionPointFilter.getCPtr(pFilter));
    FbxConnectionPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPoint(cPtr, false);
    return ret;
  }

  public FbxConnection.EType GetSrcType(int pIndex, FbxConnectionPointFilter pFilter) {
    FbxConnection.EType ret = (FbxConnection.EType)fbx_wrapperPINVOKE.FbxConnectionPoint_GetSrcType__SWIG_1(swigCPtr, pIndex, FbxConnectionPointFilter.getCPtr(pFilter));
    return ret;
  }

  public int GetDstCount(FbxConnectionPointFilter pFilter) {
    int ret = fbx_wrapperPINVOKE.FbxConnectionPoint_GetDstCount__SWIG_1(swigCPtr, FbxConnectionPointFilter.getCPtr(pFilter));
    return ret;
  }

  public FbxConnectionPoint GetDst(int pIndex, FbxConnectionPointFilter pFilter) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetDst__SWIG_1(swigCPtr, pIndex, FbxConnectionPointFilter.getCPtr(pFilter));
    FbxConnectionPoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConnectionPoint(cPtr, false);
    return ret;
  }

  public FbxConnection.EType GetDstType(int pIndex, FbxConnectionPointFilter pFilter) {
    FbxConnection.EType ret = (FbxConnection.EType)fbx_wrapperPINVOKE.FbxConnectionPoint_GetDstType__SWIG_1(swigCPtr, pIndex, FbxConnectionPointFilter.getCPtr(pFilter));
    return ret;
  }

  public SWIGTYPE_p_void GetData() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxConnectionPoint_GetData(swigCPtr);
    SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
    return ret;
  }

  public enum EDirection {
    eDirSrc = 1 << 0,
    eDirDst = 1 << 1,
    eDirUni = 1 << 2,
    eDirBoth = eDirSrc|eDirDst,
    eDirMask = eDirSrc|eDirDst|eDirUni
  }

  public enum EType {
    eStandard = 0,
    eSubConnection = 1 << 3,
    eTypeMask = eSubConnection
  }

  public enum EAttribute {
    eDefault = 0,
    eCache = 1 << 4,
    eAttributeMask = eCache
  }

  public enum EAllocFlag {
    eNotAllocated = 0,
    eAllocated = 1 << 5,
    eAllocFlagMask = eAllocated
  }

  public enum ECleanedFlag {
    eNotCleaned = 0,
    eCleaned = 1 << 6,
    eCleanedFlagMask = eCleaned
  }

  public enum EEvent {
    eSrcConnectRequest,
    eDstConnectRequest,
    eSrcConnect,
    eDstConnect,
    eSrcConnected,
    eDstConnected,
    eSrcDisconnect,
    eDstDisconnect,
    eSrcDisconnected,
    eDstDisconnected,
    eSrcReplaceBegin,
    eSrcReplaceEnd,
    eDstReplaceBegin,
    eDstReplaceEnd,
    eSrcReorder,
    eSrcReordered
  }

}

}
