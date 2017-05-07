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

public class FbxAnimLayer : FbxCollection {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxAnimLayer(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxAnimLayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimLayer obj) {
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
      fbx_wrapperPINVOKE.FbxAnimLayer_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxAnimLayer_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxAnimLayer Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxAnimLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimLayer(cPtr, false);
    return ret;
  }

  public new static FbxAnimLayer Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxAnimLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimLayer(cPtr, false);
    return ret;
  }

  public FbxPropertyTDouble Weight {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_Weight_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Weight_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool Mute {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_Mute_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Mute_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool Solo {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_Solo_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Solo_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool Lock {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_Lock_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Lock_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Color {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_Color_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Color_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_int_t BlendMode {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_BlendMode_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_BlendMode_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_int_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_int_t RotationAccumulationMode {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_RotationAccumulationMode_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_RotationAccumulationMode_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_int_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_int_t ScaleAccumulationMode {
    set {
      fbx_wrapperPINVOKE.FbxAnimLayer_ScaleAccumulationMode_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_ScaleAccumulationMode_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_int_t(cPtr, false);
      return ret;
    } 
  }

  public void Reset() {
    fbx_wrapperPINVOKE.FbxAnimLayer_Reset(swigCPtr);
  }

  public void SetBlendModeBypass(EFbxType pType, bool pState) {
    fbx_wrapperPINVOKE.FbxAnimLayer_SetBlendModeBypass(swigCPtr, (int)pType, pState);
  }

  public bool GetBlendModeBypass(EFbxType pType) {
    bool ret = fbx_wrapperPINVOKE.FbxAnimLayer_GetBlendModeBypass(swigCPtr, (int)pType);
    return ret;
  }

  public FbxAnimCurveNode CreateCurveNode(FbxProperty pProperty) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_CreateCurveNode(swigCPtr, FbxProperty.getCPtr(pProperty));
    FbxAnimCurveNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimCurveNode(cPtr, false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FbxAnimLayer Cast(FbxObject arg0) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimLayer_Cast(FbxObject.getCPtr(arg0));
    FbxAnimLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxAnimLayer(cPtr, false);
    return ret;
  }

  public enum EBlendMode {
    eBlendAdditive,
    eBlendOverride,
    eBlendOverridePassthrough
  }

  public enum ERotationAccumulationMode {
    eRotationByLayer,
    eRotationByChannel
  }

  public enum EScaleAccumulationMode {
    eScaleMultiply,
    eScaleAdditive
  }

}

}