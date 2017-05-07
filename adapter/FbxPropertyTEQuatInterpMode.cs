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

public class FbxPropertyTEQuatInterpMode : FbxProperty {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPropertyTEQuatInterpMode(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyTEQuatInterpMode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPropertyTEQuatInterpMode() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxPropertyTEQuatInterpMode(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, EFbxQuatInterpMode pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pName, (int)pValue, pForceSet, (int)pFlags), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, EFbxQuatInterpMode pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject), pName, (int)pValue, pForceSet), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, EFbxQuatInterpMode pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_2(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), (int)pValue, pForceSet, (int)pFlags), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, EFbxQuatInterpMode pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_3(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), (int)pValue, pForceSet), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, EFbxQuatInterpMode pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_4(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), (int)pValue, pForceSet, (int)pFlags), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, EFbxQuatInterpMode pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_5(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), (int)pValue, pForceSet), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxProperty pCompound, string pName, FbxDataType pDataType, EFbxQuatInterpMode pValue) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_StaticInit__SWIG_6(swigCPtr, FbxProperty.getCPtr(pCompound), pName, FbxDataType.getCPtr(pDataType), (int)pValue), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyTEQuatInterpMode Set(EFbxQuatInterpMode pValue) {
    FbxPropertyTEQuatInterpMode ret = new FbxPropertyTEQuatInterpMode(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_Set(swigCPtr, (int)pValue), false);
    return ret;
  }

  public EFbxQuatInterpMode Get() {
    EFbxQuatInterpMode ret = (EFbxQuatInterpMode)fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_Get(swigCPtr);
    return ret;
  }

  public FbxPropertyTEQuatInterpMode assign(EFbxQuatInterpMode pValue) {
    FbxPropertyTEQuatInterpMode ret = new FbxPropertyTEQuatInterpMode(fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_assign(swigCPtr, (int)pValue), false);
    return ret;
  }

  public EFbxQuatInterpMode EvaluateValue(FbxTime pTime, bool pForceEval) {
    EFbxQuatInterpMode ret = (EFbxQuatInterpMode)fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_EvaluateValue__SWIG_0(swigCPtr, FbxTime.getCPtr(pTime), pForceEval);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EFbxQuatInterpMode EvaluateValue(FbxTime pTime) {
    EFbxQuatInterpMode ret = (EFbxQuatInterpMode)fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_EvaluateValue__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EFbxQuatInterpMode EvaluateValue() {
    EFbxQuatInterpMode ret = (EFbxQuatInterpMode)fbx_wrapperPINVOKE.FbxPropertyTEQuatInterpMode_EvaluateValue__SWIG_2(swigCPtr);
    return ret;
  }

  public FbxPropertyTEQuatInterpMode() : this(fbx_wrapperPINVOKE.new_FbxPropertyTEQuatInterpMode__SWIG_0(), true) {
  }

  public FbxPropertyTEQuatInterpMode(FbxProperty pProperty) : this(fbx_wrapperPINVOKE.new_FbxPropertyTEQuatInterpMode__SWIG_1(FbxProperty.getCPtr(pProperty)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
