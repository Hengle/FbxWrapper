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

public class FbxPropertyTReference : FbxProperty {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxPropertyTReference(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxPropertyTReference_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPropertyTReference obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPropertyTReference() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxPropertyTReference(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxPropertyTReference() : this(fbx_wrapperPINVOKE.new_FbxPropertyTReference__SWIG_0(), true) {
  }

  public FbxPropertyTReference(FbxProperty pProperty) : this(fbx_wrapperPINVOKE.new_FbxPropertyTReference__SWIG_1(FbxProperty.getCPtr(pProperty)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxObject pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTReference_StaticInit__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxObject.getCPtr(pValue), pForceSet, (int)pFlags), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxObject pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTReference_StaticInit__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxObject.getCPtr(pValue), pForceSet), false);
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, FbxObject pValue, bool pForceSet, FbxPropertyFlags.EFlags pFlags) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTReference_StaticInit__SWIG_2(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), FbxObject.getCPtr(pValue), pForceSet, (int)pFlags), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxProperty StaticInit(FbxObject pObject, string pName, FbxDataType pDataType, FbxObject pValue, bool pForceSet) {
    FbxProperty ret = new FbxProperty(fbx_wrapperPINVOKE.FbxPropertyTReference_StaticInit__SWIG_3(swigCPtr, FbxObject.getCPtr(pObject), pName, FbxDataType.getCPtr(pDataType), FbxObject.getCPtr(pValue), pForceSet), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxObject Get() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxPropertyTReference_Get(swigCPtr);
    FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
    return ret;
  }

  public FbxPropertyTReference Set(FbxObject pValue) {
    FbxPropertyTReference ret = new FbxPropertyTReference(fbx_wrapperPINVOKE.FbxPropertyTReference_Set(swigCPtr, FbxObject.getCPtr(pValue)), false);
    return ret;
  }

  public FbxPropertyTReference assign(FbxObject pValue) {
    FbxPropertyTReference ret = new FbxPropertyTReference(fbx_wrapperPINVOKE.FbxPropertyTReference_assign(swigCPtr, FbxObject.getCPtr(pValue)), false);
    return ret;
  }

}

}
