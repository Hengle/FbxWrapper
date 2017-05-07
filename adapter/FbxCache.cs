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

public class FbxCache : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxCache(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxCache_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCache obj) {
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
      fbx_wrapperPINVOKE.FbxCache_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCache_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxCache_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxCache Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCache_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCache(cPtr, false);
    return ret;
  }

  public new static FbxCache Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxCache_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxCache ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCache(cPtr, false);
    return ret;
  }

  public void SetCacheFileFormat(FbxCache.EFileFormat pFileFormat, FbxStatus pStatus) {
    fbx_wrapperPINVOKE.FbxCache_SetCacheFileFormat__SWIG_0(swigCPtr, (int)pFileFormat, FbxStatus.getCPtr(pStatus));
  }

  public void SetCacheFileFormat(FbxCache.EFileFormat pFileFormat) {
    fbx_wrapperPINVOKE.FbxCache_SetCacheFileFormat__SWIG_1(swigCPtr, (int)pFileFormat);
  }

  public FbxCache.EFileFormat GetCacheFileFormat() {
    FbxCache.EFileFormat ret = (FbxCache.EFileFormat)fbx_wrapperPINVOKE.FbxCache_GetCacheFileFormat(swigCPtr);
    return ret;
  }

  public void SetCacheFileName(string pRelativeFileName_UTF8, string pAbsoluteFileName_UTF8, FbxStatus pStatus) {
    fbx_wrapperPINVOKE.FbxCache_SetCacheFileName__SWIG_0(swigCPtr, pRelativeFileName_UTF8, pAbsoluteFileName_UTF8, FbxStatus.getCPtr(pStatus));
  }

  public void SetCacheFileName(string pRelativeFileName_UTF8, string pAbsoluteFileName_UTF8) {
    fbx_wrapperPINVOKE.FbxCache_SetCacheFileName__SWIG_1(swigCPtr, pRelativeFileName_UTF8, pAbsoluteFileName_UTF8);
  }

  public void GetCacheFileName(FbxString pRelativeFileName_UTF8, FbxString pAbsoluteFileName_UTF8) {
    fbx_wrapperPINVOKE.FbxCache_GetCacheFileName(swigCPtr, FbxString.getCPtr(pRelativeFileName_UTF8), FbxString.getCPtr(pAbsoluteFileName_UTF8));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool OpenFileForRead(FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForRead__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool OpenFileForRead() {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForRead__SWIG_1(swigCPtr);
    return ret;
  }

  public bool IsOpen(FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_IsOpen__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool IsOpen() {
    bool ret = fbx_wrapperPINVOKE.FbxCache_IsOpen__SWIG_1(swigCPtr);
    return ret;
  }

  public bool Read(SWIGTYPE_p_p_float pBuffer, SWIGTYPE_p_unsigned_int pBufferLength, FbxTime pTime, uint pChannel) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_0(swigCPtr, SWIGTYPE_p_p_float.getCPtr(pBuffer), SWIGTYPE_p_unsigned_int.getCPtr(pBufferLength), FbxTime.getCPtr(pTime), pChannel);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(SWIGTYPE_p_p_float pBuffer, SWIGTYPE_p_unsigned_int pBufferLength, FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_1(swigCPtr, SWIGTYPE_p_p_float.getCPtr(pBuffer), SWIGTYPE_p_unsigned_int.getCPtr(pBufferLength), FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CloseFile(FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_CloseFile__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool CloseFile() {
    bool ret = fbx_wrapperPINVOKE.FbxCache_CloseFile__SWIG_1(swigCPtr);
    return ret;
  }

  public double GetSamplingFrameRate(FbxStatus pStatus) {
    double ret = fbx_wrapperPINVOKE.FbxCache_GetSamplingFrameRate__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public double GetSamplingFrameRate() {
    double ret = fbx_wrapperPINVOKE.FbxCache_GetSamplingFrameRate__SWIG_1(swigCPtr);
    return ret;
  }

  public FbxTime GetCacheTimePerFrame(FbxStatus pStatus) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxCache_GetCacheTimePerFrame__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus)), true);
    return ret;
  }

  public FbxTime GetCacheTimePerFrame() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxCache_GetCacheTimePerFrame__SWIG_1(swigCPtr), true);
    return ret;
  }

  public int GetChannelCount(FbxStatus pStatus) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetChannelCount__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public int GetChannelCount() {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetChannelCount__SWIG_1(swigCPtr);
    return ret;
  }

  public bool GetChannelName(int pChannelIndex, FbxString pChannelName, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelName__SWIG_0(swigCPtr, pChannelIndex, FbxString.getCPtr(pChannelName), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelName(int pChannelIndex, FbxString pChannelName) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelName__SWIG_1(swigCPtr, pChannelIndex, FbxString.getCPtr(pChannelName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool OpenFileForWrite(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, string pChannelName, FbxCache.EMCBinaryFormat pBinaryFormat, FbxCache.EMCDataType pMCDataType, string pInterpretation, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_0(swigCPtr, (int)pFileCount, pSamplingFrameRate, pChannelName, (int)pBinaryFormat, (int)pMCDataType, pInterpretation, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool OpenFileForWrite(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, string pChannelName, FbxCache.EMCBinaryFormat pBinaryFormat, FbxCache.EMCDataType pMCDataType, string pInterpretation) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_1(swigCPtr, (int)pFileCount, pSamplingFrameRate, pChannelName, (int)pBinaryFormat, (int)pMCDataType, pInterpretation);
    return ret;
  }

  public bool OpenFileForWrite(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, string pChannelName, FbxCache.EMCBinaryFormat pBinaryFormat, FbxCache.EMCDataType pMCDataType) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_2(swigCPtr, (int)pFileCount, pSamplingFrameRate, pChannelName, (int)pBinaryFormat, (int)pMCDataType);
    return ret;
  }

  public bool OpenFileForWrite(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, string pChannelName, FbxCache.EMCBinaryFormat pBinaryFormat) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_3(swigCPtr, (int)pFileCount, pSamplingFrameRate, pChannelName, (int)pBinaryFormat);
    return ret;
  }

  public bool AddChannel(string pChannelName, FbxCache.EMCDataType pMCDataType, string pInterpretation, SWIGTYPE_p_unsigned_int pChannelIndex, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_AddChannel__SWIG_0(swigCPtr, pChannelName, (int)pMCDataType, pInterpretation, SWIGTYPE_p_unsigned_int.getCPtr(pChannelIndex), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AddChannel(string pChannelName, FbxCache.EMCDataType pMCDataType, string pInterpretation, SWIGTYPE_p_unsigned_int pChannelIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_AddChannel__SWIG_1(swigCPtr, pChannelName, (int)pMCDataType, pInterpretation, SWIGTYPE_p_unsigned_int.getCPtr(pChannelIndex));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelDataType(int pChannelIndex, SWIGTYPE_p_FbxCache__EMCDataType pChannelType, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelDataType__SWIG_0(swigCPtr, pChannelIndex, SWIGTYPE_p_FbxCache__EMCDataType.getCPtr(pChannelType), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelDataType(int pChannelIndex, SWIGTYPE_p_FbxCache__EMCDataType pChannelType) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelDataType__SWIG_1(swigCPtr, pChannelIndex, SWIGTYPE_p_FbxCache__EMCDataType.getCPtr(pChannelType));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetChannelIndex(string pChannelName, FbxStatus pStatus) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetChannelIndex__SWIG_0(swigCPtr, pChannelName, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public int GetChannelIndex(string pChannelName) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetChannelIndex__SWIG_1(swigCPtr, pChannelName);
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_double pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_2(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_double pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_3(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_float pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_4(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_float.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_float pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_5(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_float.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_int pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_6(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Read(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_int pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_7(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool BeginWriteAt(FbxTime pTime, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_BeginWriteAt__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool BeginWriteAt(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_BeginWriteAt__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_double pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_0(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_double pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_1(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_float pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_2(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_float.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_float pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_3(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_float.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_int pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_4(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Write(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_int pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_5(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pBuffer), pPointCount);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EndWriteAt(FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_EndWriteAt__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool EndWriteAt() {
    bool ret = fbx_wrapperPINVOKE.FbxCache_EndWriteAt__SWIG_1(swigCPtr);
    return ret;
  }

  public bool GetAnimationRange(int pChannelIndex, FbxTime pTimeStart, FbxTime pTimeEnd, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetAnimationRange__SWIG_0(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTimeStart), FbxTime.getCPtr(pTimeEnd), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetAnimationRange(int pChannelIndex, FbxTime pTimeStart, FbxTime pTimeEnd) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetAnimationRange__SWIG_1(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTimeStart), FbxTime.getCPtr(pTimeEnd));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetCacheType(SWIGTYPE_p_FbxCache__EMCFileCount pFileCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetCacheType__SWIG_0(swigCPtr, SWIGTYPE_p_FbxCache__EMCFileCount.getCPtr(pFileCount), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetCacheType(SWIGTYPE_p_FbxCache__EMCFileCount pFileCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetCacheType__SWIG_1(swigCPtr, SWIGTYPE_p_FbxCache__EMCFileCount.getCPtr(pFileCount));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelInterpretation(int pChannelIndex, FbxString pInterpretation, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelInterpretation__SWIG_0(swigCPtr, pChannelIndex, FbxString.getCPtr(pInterpretation), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelInterpretation(int pChannelIndex, FbxString pInterpretation) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelInterpretation__SWIG_1(swigCPtr, pChannelIndex, FbxString.getCPtr(pInterpretation));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSamplingType(int pChannelIndex, SWIGTYPE_p_FbxCache__EMCSamplingType pSamplingType, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSamplingType__SWIG_0(swigCPtr, pChannelIndex, SWIGTYPE_p_FbxCache__EMCSamplingType.getCPtr(pSamplingType), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSamplingType(int pChannelIndex, SWIGTYPE_p_FbxCache__EMCSamplingType pSamplingType) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSamplingType__SWIG_1(swigCPtr, pChannelIndex, SWIGTYPE_p_FbxCache__EMCSamplingType.getCPtr(pSamplingType));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSamplingRate(int pChannelIndex, FbxTime pSamplingRate, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSamplingRate__SWIG_0(swigCPtr, pChannelIndex, FbxTime.getCPtr(pSamplingRate), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSamplingRate(int pChannelIndex, FbxTime pSamplingRate) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSamplingRate__SWIG_1(swigCPtr, pChannelIndex, FbxTime.getCPtr(pSamplingRate));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSampleCount(int pChannelIndex, SWIGTYPE_p_unsigned_int pSampleCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSampleCount__SWIG_0(swigCPtr, pChannelIndex, SWIGTYPE_p_unsigned_int.getCPtr(pSampleCount), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelSampleCount(int pChannelIndex, SWIGTYPE_p_unsigned_int pSampleCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelSampleCount__SWIG_1(swigCPtr, pChannelIndex, SWIGTYPE_p_unsigned_int.getCPtr(pSampleCount));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelPointCount(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_unsigned_int pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelPointCount__SWIG_0(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_unsigned_int.getCPtr(pPointCount), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetChannelPointCount(int pChannelIndex, FbxTime pTime, SWIGTYPE_p_unsigned_int pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetChannelPointCount__SWIG_1(swigCPtr, pChannelIndex, FbxTime.getCPtr(pTime), SWIGTYPE_p_unsigned_int.getCPtr(pPointCount));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetCacheDataFileCount(FbxStatus pStatus) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetCacheDataFileCount__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public int GetCacheDataFileCount() {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetCacheDataFileCount__SWIG_1(swigCPtr);
    return ret;
  }

  public bool GetCacheDataFileName(int pIndex, FbxString pRelativeFileName, FbxString pAbsoluteFileName, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetCacheDataFileName__SWIG_0(swigCPtr, pIndex, FbxString.getCPtr(pRelativeFileName), FbxString.getCPtr(pAbsoluteFileName), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetCacheDataFileName(int pIndex, FbxString pRelativeFileName, FbxString pAbsoluteFileName) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetCacheDataFileName__SWIG_1(swigCPtr, pIndex, FbxString.getCPtr(pRelativeFileName), FbxString.getCPtr(pAbsoluteFileName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EnableMultiChannelFetching(bool pMultiChannelFetching, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_EnableMultiChannelFetching__SWIG_0(swigCPtr, pMultiChannelFetching, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool EnableMultiChannelFetching(bool pMultiChannelFetching) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_EnableMultiChannelFetching__SWIG_1(swigCPtr, pMultiChannelFetching);
    return ret;
  }

  public bool GetNextTimeWithData(FbxTime pCurTime, FbxTime pNextTime, int pChannelIndex, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetNextTimeWithData__SWIG_0(swigCPtr, FbxTime.getCPtr(pCurTime), FbxTime.getCPtr(pNextTime), pChannelIndex, FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetNextTimeWithData(FbxTime pCurTime, FbxTime pNextTime, int pChannelIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetNextTimeWithData__SWIG_1(swigCPtr, FbxTime.getCPtr(pCurTime), FbxTime.getCPtr(pNextTime), pChannelIndex);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetNextTimeWithData(FbxTime pCurTime, FbxTime pNextTime) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetNextTimeWithData__SWIG_2(swigCPtr, FbxTime.getCPtr(pCurTime), FbxTime.getCPtr(pNextTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetDataCount(int pChannelIndex, FbxStatus pStatus) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetDataCount__SWIG_0(swigCPtr, pChannelIndex, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public int GetDataCount(int pChannelIndex) {
    int ret = fbx_wrapperPINVOKE.FbxCache_GetDataCount__SWIG_1(swigCPtr, pChannelIndex);
    return ret;
  }

  public bool GetDataTime(int pChannelIndex, uint pDataIndex, FbxTime pTime, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetDataTime__SWIG_0(swigCPtr, pChannelIndex, pDataIndex, FbxTime.getCPtr(pTime), FbxStatus.getCPtr(pStatus));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetDataTime(int pChannelIndex, uint pDataIndex, FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_GetDataTime__SWIG_1(swigCPtr, pChannelIndex, pDataIndex, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool OpenFileForWrite(double pFrameStartOffset, double pSamplingFrameRate, uint pSampleCount, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_4(swigCPtr, pFrameStartOffset, pSamplingFrameRate, pSampleCount, pPointCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool OpenFileForWrite(double pFrameStartOffset, double pSamplingFrameRate, uint pSampleCount, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_OpenFileForWrite__SWIG_5(swigCPtr, pFrameStartOffset, pSamplingFrameRate, pSampleCount, pPointCount);
    return ret;
  }

  public uint GetSampleCount(FbxStatus pStatus) {
    uint ret = fbx_wrapperPINVOKE.FbxCache_GetSampleCount__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public uint GetSampleCount() {
    uint ret = fbx_wrapperPINVOKE.FbxCache_GetSampleCount__SWIG_1(swigCPtr);
    return ret;
  }

  public uint GetPointCount(FbxStatus pStatus) {
    uint ret = fbx_wrapperPINVOKE.FbxCache_GetPointCount__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public uint GetPointCount() {
    uint ret = fbx_wrapperPINVOKE.FbxCache_GetPointCount__SWIG_1(swigCPtr);
    return ret;
  }

  public double GetFrameStartOffset(FbxStatus pStatus) {
    double ret = fbx_wrapperPINVOKE.FbxCache_GetFrameStartOffset__SWIG_0(swigCPtr, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public double GetFrameStartOffset() {
    double ret = fbx_wrapperPINVOKE.FbxCache_GetFrameStartOffset__SWIG_1(swigCPtr);
    return ret;
  }

  public bool Read(uint pFrameIndex, SWIGTYPE_p_double pBuffer, uint pPointCount, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_8(swigCPtr, pFrameIndex, SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool Read(uint pFrameIndex, SWIGTYPE_p_double pBuffer, uint pPointCount) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Read__SWIG_9(swigCPtr, pFrameIndex, SWIGTYPE_p_double.getCPtr(pBuffer), pPointCount);
    return ret;
  }

  public bool Write(uint pFrameIndex, SWIGTYPE_p_double pBuffer, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_6(swigCPtr, pFrameIndex, SWIGTYPE_p_double.getCPtr(pBuffer), FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool Write(uint pFrameIndex, SWIGTYPE_p_double pBuffer) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_Write__SWIG_7(swigCPtr, pFrameIndex, SWIGTYPE_p_double.getCPtr(pBuffer));
    return ret;
  }

  public bool ConvertFromPC2ToMC(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, FbxCache.EMCBinaryFormat pBinaryFormat, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_ConvertFromPC2ToMC__SWIG_0(swigCPtr, (int)pFileCount, pSamplingFrameRate, (int)pBinaryFormat, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool ConvertFromPC2ToMC(FbxCache.EMCFileCount pFileCount, double pSamplingFrameRate, FbxCache.EMCBinaryFormat pBinaryFormat) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_ConvertFromPC2ToMC__SWIG_1(swigCPtr, (int)pFileCount, pSamplingFrameRate, (int)pBinaryFormat);
    return ret;
  }

  public bool ConvertFromMCToPC2(double pSamplingFrameRate, uint pChannelIndex, FbxStatus pStatus) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_ConvertFromMCToPC2__SWIG_0(swigCPtr, pSamplingFrameRate, pChannelIndex, FbxStatus.getCPtr(pStatus));
    return ret;
  }

  public bool ConvertFromMCToPC2(double pSamplingFrameRate, uint pChannelIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxCache_ConvertFromMCToPC2__SWIG_1(swigCPtr, pSamplingFrameRate, pChannelIndex);
    return ret;
  }

  public enum EFileFormat {
    eUnknownFileFormat,
    eMaxPointCacheV2,
    eMayaCache,
    eAlembic
  }

  public enum EMCFileCount {
    eMCOneFile,
    eMCOneFilePerFrame
  }

  public enum EMCDataType {
    eUnknownData,
    eDouble,
    eDoubleArray,
    eDoubleVectorArray,
    eInt32Array,
    eFloatArray,
    eFloatVectorArray
  }

  public enum EMCBinaryFormat {
    eMCC,
    eMCX
  }

  public enum EMCSamplingType {
    eSamplingRegular,
    eSamplingIrregular
  }

  public enum EOpenFlag {
    eReadOnly,
    eWriteOnly
  }

}

}
