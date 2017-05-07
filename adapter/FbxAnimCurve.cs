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

public class FbxAnimCurve : FbxAnimCurveBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxAnimCurve(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxAnimCurve_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurve obj) {
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
      fbx_wrapperPINVOKE.FbxAnimCurve_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurve_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxAnimCurve_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxAnimCurve Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurve_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

  public static FbxAnimCurve Create(FbxScene pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurve_Create__SWIG_1(FbxScene.getCPtr(pContainer), pName);
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

  public virtual void ResizeKeyBuffer(int pKeyCount) {
    fbx_wrapperPINVOKE.FbxAnimCurve_ResizeKeyBuffer(swigCPtr, pKeyCount);
  }

  public virtual void KeyModifyBegin() {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyModifyBegin(swigCPtr);
  }

  public virtual void KeyModifyEnd() {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyModifyEnd(swigCPtr);
  }

  public override void KeyClear() {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyClear(swigCPtr);
  }

  public override int KeyGetCount() {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetCount(swigCPtr);
    return ret;
  }

  public override int KeyAdd(FbxTime pTime, FbxAnimCurveKeyBase pKey, SWIGTYPE_p_int pLast) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyAdd__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), FbxAnimCurveKeyBase.getCPtr(pKey), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int KeyAdd(FbxTime pTime, FbxAnimCurveKeyBase pKey) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyAdd__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime), FbxAnimCurveKeyBase.getCPtr(pKey));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int KeyAdd(FbxTime pTime, SWIGTYPE_p_int pLast) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyAdd__SWIG_2(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int KeyAdd(FbxTime pTime) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyAdd__SWIG_3(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool KeySet(int pIndex, FbxAnimCurveKeyBase pKey) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_0(swigCPtr, pIndex, FbxAnimCurveKeyBase.getCPtr(pKey));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool KeyRemove(int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyRemove__SWIG_0(swigCPtr, pIndex);
    return ret;
  }

  public override bool KeyRemove(int pStartIndex, int pEndIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyRemove__SWIG_1(swigCPtr, pStartIndex, pEndIndex);
    return ret;
  }

  public virtual int KeyInsert(FbxTime pTime, SWIGTYPE_p_int pLast) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyInsert__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int KeyInsert(FbxTime pTime) {
    int ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyInsert__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double KeyFind(FbxTime pTime, SWIGTYPE_p_int pLast) {
    double ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyFind__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual double KeyFind(FbxTime pTime) {
    double ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyFind__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool KeyScaleValue(float pMultValue) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyScaleValue(swigCPtr, pMultValue);
    return ret;
  }

  public virtual bool KeyScaleValueAndTangent(float pMultValue) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyScaleValueAndTangent(swigCPtr, pMultValue);
    return ret;
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1, FbxAnimCurveDef.EWeightedMode pTangentWeightMode, float pWeight0, float pWeight1, float pVelocity0, float pVelocity1) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_1(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1, (int)pTangentWeightMode, pWeight0, pWeight1, pVelocity0, pVelocity1);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1, FbxAnimCurveDef.EWeightedMode pTangentWeightMode, float pWeight0, float pWeight1, float pVelocity0) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_2(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1, (int)pTangentWeightMode, pWeight0, pWeight1, pVelocity0);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1, FbxAnimCurveDef.EWeightedMode pTangentWeightMode, float pWeight0, float pWeight1) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_3(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1, (int)pTangentWeightMode, pWeight0, pWeight1);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1, FbxAnimCurveDef.EWeightedMode pTangentWeightMode, float pWeight0) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_4(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1, (int)pTangentWeightMode, pWeight0);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1, FbxAnimCurveDef.EWeightedMode pTangentWeightMode) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_5(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1, (int)pTangentWeightMode);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0, float pData1) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_6(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0, pData1);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode, float pData0) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_7(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode, pData0);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation, FbxAnimCurveDef.ETangentMode pTangentMode) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_8(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation, (int)pTangentMode);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue, FbxAnimCurveDef.EInterpolationType pInterpolation) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_9(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, (int)pInterpolation);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySet(int pKeyIndex, FbxTime pTime, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySet__SWIG_10(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetTCB(int pKeyIndex, FbxTime pTime, float pValue, float pData0, float pData1, float pData2) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTCB__SWIG_0(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, pData0, pData1, pData2);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetTCB(int pKeyIndex, FbxTime pTime, float pValue, float pData0, float pData1) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTCB__SWIG_1(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, pData0, pData1);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetTCB(int pKeyIndex, FbxTime pTime, float pValue, float pData0) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTCB__SWIG_2(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue, pData0);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetTCB(int pKeyIndex, FbxTime pTime, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTCB__SWIG_3(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime), pValue);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual FbxAnimCurveDef.EInterpolationType KeyGetInterpolation(int pKeyIndex) {
    FbxAnimCurveDef.EInterpolationType ret = (FbxAnimCurveDef.EInterpolationType)fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetInterpolation(swigCPtr, pKeyIndex);
    return ret;
  }

  public virtual void KeySetInterpolation(int pKeyIndex, FbxAnimCurveDef.EInterpolationType pInterpolation) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetInterpolation(swigCPtr, pKeyIndex, (int)pInterpolation);
  }

  public virtual FbxAnimCurveDef.EConstantMode KeyGetConstantMode(int pKeyIndex) {
    FbxAnimCurveDef.EConstantMode ret = (FbxAnimCurveDef.EConstantMode)fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetConstantMode(swigCPtr, pKeyIndex);
    return ret;
  }

  public virtual FbxAnimCurveDef.ETangentMode KeyGetTangentMode(int pKeyIndex, bool pIncludeOverrides) {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetTangentMode__SWIG_0(swigCPtr, pKeyIndex, pIncludeOverrides);
    return ret;
  }

  public virtual FbxAnimCurveDef.ETangentMode KeyGetTangentMode(int pKeyIndex) {
    FbxAnimCurveDef.ETangentMode ret = (FbxAnimCurveDef.ETangentMode)fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetTangentMode__SWIG_1(swigCPtr, pKeyIndex);
    return ret;
  }

  public virtual void KeySetConstantMode(int pKeyIndex, FbxAnimCurveDef.EConstantMode pMode) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetConstantMode(swigCPtr, pKeyIndex, (int)pMode);
  }

  public virtual void KeySetTangentMode(int pKeyIndex, FbxAnimCurveDef.ETangentMode pTangent) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTangentMode(swigCPtr, pKeyIndex, (int)pTangent);
  }

  public virtual FbxAnimCurveKey KeyGet(int pIndex) {
    FbxAnimCurveKey ret = new FbxAnimCurveKey(fbx_wrapperPINVOKE.FbxAnimCurve_KeyGet(swigCPtr, pIndex), true);
    return ret;
  }

  public virtual float KeyGetValue(int pKeyIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetValue(swigCPtr, pKeyIndex);
    return ret;
  }

  public virtual void KeySetValue(int pKeyIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetValue(swigCPtr, pKeyIndex, pValue);
  }

  public virtual void KeyIncValue(int pKeyIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyIncValue(swigCPtr, pKeyIndex, pValue);
  }

  public virtual void KeyMultValue(int pKeyIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyMultValue(swigCPtr, pKeyIndex, pValue);
  }

  public virtual void KeyMultTangent(int pKeyIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeyMultTangent(swigCPtr, pKeyIndex, pValue);
  }

  public override FbxTime KeyGetTime(int pKeyIndex) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetTime(swigCPtr, pKeyIndex), true);
    return ret;
  }

  public override void KeySetTime(int pKeyIndex, FbxTime pTime) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetTime(swigCPtr, pKeyIndex, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetBreak(int pKeyIndex, bool pVal) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetBreak(swigCPtr, pKeyIndex, pVal);
  }

  public virtual bool KeyGetBreak(int pKeyIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetBreak(swigCPtr, pKeyIndex);
    return ret;
  }

  public virtual float KeyGetLeftDerivative(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftDerivative(swigCPtr, pIndex);
    return ret;
  }

  public virtual void KeySetLeftDerivative(int pIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetLeftDerivative(swigCPtr, pIndex, pValue);
  }

  public virtual float KeyGetLeftAuto(int pIndex, bool pApplyOvershootProtection) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftAuto__SWIG_0(swigCPtr, pIndex, pApplyOvershootProtection);
    return ret;
  }

  public virtual float KeyGetLeftAuto(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftAuto__SWIG_1(swigCPtr, pIndex);
    return ret;
  }

  public virtual FbxAnimCurveTangentInfo KeyGetLeftDerivativeInfo(int pIndex) {
    FbxAnimCurveTangentInfo ret = new FbxAnimCurveTangentInfo(fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftDerivativeInfo(swigCPtr, pIndex), true);
    return ret;
  }

  public virtual void KeySetLeftDerivativeInfo(int pIndex, FbxAnimCurveTangentInfo pValue, bool pForceDerivative) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetLeftDerivativeInfo__SWIG_0(swigCPtr, pIndex, FbxAnimCurveTangentInfo.getCPtr(pValue), pForceDerivative);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetLeftDerivativeInfo(int pIndex, FbxAnimCurveTangentInfo pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetLeftDerivativeInfo__SWIG_1(swigCPtr, pIndex, FbxAnimCurveTangentInfo.getCPtr(pValue));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float KeyGetRightDerivative(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightDerivative(swigCPtr, pIndex);
    return ret;
  }

  public virtual void KeySetRightDerivative(int pIndex, float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetRightDerivative(swigCPtr, pIndex, pValue);
  }

  public virtual float KeyGetRightAuto(int pIndex, bool pApplyOvershootProtection) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightAuto__SWIG_0(swigCPtr, pIndex, pApplyOvershootProtection);
    return ret;
  }

  public virtual float KeyGetRightAuto(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightAuto__SWIG_1(swigCPtr, pIndex);
    return ret;
  }

  public virtual FbxAnimCurveTangentInfo KeyGetRightDerivativeInfo(int pIndex) {
    FbxAnimCurveTangentInfo ret = new FbxAnimCurveTangentInfo(fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightDerivativeInfo(swigCPtr, pIndex), true);
    return ret;
  }

  public virtual void KeySetRightDerivativeInfo(int pIndex, FbxAnimCurveTangentInfo pValue, bool pForceDerivative) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetRightDerivativeInfo__SWIG_0(swigCPtr, pIndex, FbxAnimCurveTangentInfo.getCPtr(pValue), pForceDerivative);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void KeySetRightDerivativeInfo(int pIndex, FbxAnimCurveTangentInfo pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetRightDerivativeInfo__SWIG_1(swigCPtr, pIndex, FbxAnimCurveTangentInfo.getCPtr(pValue));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool KeyIsLeftTangentWeighted(int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyIsLeftTangentWeighted(swigCPtr, pIndex);
    return ret;
  }

  public virtual bool KeyIsRightTangentWeighted(int pIndex) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyIsRightTangentWeighted(swigCPtr, pIndex);
    return ret;
  }

  public virtual float KeyGetLeftTangentWeight(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftTangentWeight(swigCPtr, pIndex);
    return ret;
  }

  public virtual float KeyGetRightTangentWeight(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightTangentWeight(swigCPtr, pIndex);
    return ret;
  }

  public virtual void KeySetLeftTangentWeight(int pIndex, float pWeight, bool pAdjustTan) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetLeftTangentWeight__SWIG_0(swigCPtr, pIndex, pWeight, pAdjustTan);
  }

  public virtual void KeySetLeftTangentWeight(int pIndex, float pWeight) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetLeftTangentWeight__SWIG_1(swigCPtr, pIndex, pWeight);
  }

  public virtual void KeySetRightTangentWeight(int pIndex, float pWeight, bool pAdjustTan) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetRightTangentWeight__SWIG_0(swigCPtr, pIndex, pWeight, pAdjustTan);
  }

  public virtual void KeySetRightTangentWeight(int pIndex, float pWeight) {
    fbx_wrapperPINVOKE.FbxAnimCurve_KeySetRightTangentWeight__SWIG_1(swigCPtr, pIndex, pWeight);
  }

  public virtual float KeyGetLeftTangentVelocity(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetLeftTangentVelocity(swigCPtr, pIndex);
    return ret;
  }

  public virtual float KeyGetRightTangentVelocity(int pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_KeyGetRightTangentVelocity(swigCPtr, pIndex);
    return ret;
  }

  public override float Evaluate(FbxTime pTime, SWIGTYPE_p_int pLast) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_Evaluate__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float Evaluate(FbxTime pTime) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_Evaluate__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override float EvaluateIndex(double pIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_EvaluateIndex(swigCPtr, pIndex);
    return ret;
  }

  public virtual float EvaluateLeftDerivative(FbxTime pTime, SWIGTYPE_p_int pLast) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_EvaluateLeftDerivative__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float EvaluateLeftDerivative(FbxTime pTime) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_EvaluateLeftDerivative__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float EvaluateRightDerivative(FbxTime pTime, SWIGTYPE_p_int pLast) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_EvaluateRightDerivative__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), SWIGTYPE_p_int.getCPtr(pLast));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual float EvaluateRightDerivative(FbxTime pTime) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_EvaluateRightDerivative__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool GetTimeInterval(FbxTimeSpan pTimeInterval) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_GetTimeInterval(swigCPtr, FbxTimeSpan.getCPtr(pTimeInterval));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void CopyFrom(FbxAnimCurve pSource, bool pWithKeys) {
    fbx_wrapperPINVOKE.FbxAnimCurve_CopyFrom__SWIG_0(swigCPtr, FbxAnimCurve.getCPtr(pSource), pWithKeys);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void CopyFrom(FbxAnimCurve pSource) {
    fbx_wrapperPINVOKE.FbxAnimCurve_CopyFrom__SWIG_1(swigCPtr, FbxAnimCurve.getCPtr(pSource));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float GetValue(int pCurveNodeIndex) {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_GetValue__SWIG_0(swigCPtr, pCurveNodeIndex);
    return ret;
  }

  public virtual float GetValue() {
    float ret = fbx_wrapperPINVOKE.FbxAnimCurve_GetValue__SWIG_1(swigCPtr);
    return ret;
  }

  public virtual void SetValue(float pValue, int pCurveNodeIndex) {
    fbx_wrapperPINVOKE.FbxAnimCurve_SetValue__SWIG_0(swigCPtr, pValue, pCurveNodeIndex);
  }

  public virtual void SetValue(float pValue) {
    fbx_wrapperPINVOKE.FbxAnimCurve_SetValue__SWIG_1(swigCPtr, pValue);
  }

  public virtual SWIGTYPE_p_KFCurve GetKFCurve() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurve_GetKFCurve(swigCPtr);
    SWIGTYPE_p_KFCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_KFCurve(cPtr, false);
    return ret;
  }

  public override bool Store(FbxIO pFileObject, bool pLegacyVersion) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_Store__SWIG_0(swigCPtr, FbxIO.getCPtr(pFileObject), pLegacyVersion);
    return ret;
  }

  public override bool Store(FbxIO pFileObject) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_Store__SWIG_1(swigCPtr, FbxIO.getCPtr(pFileObject));
    return ret;
  }

  public override bool Retrieve(FbxIO pFileObject) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimCurve_Retrieve(swigCPtr, FbxIO.getCPtr(pFileObject));
    return ret;
  }

  public static FbxAnimCurve Cast(FbxObject arg0) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurve_Cast(FbxObject.getCPtr(arg0));
    FbxAnimCurve ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurve(cPtr, false);
    return ret;
  }

}

}