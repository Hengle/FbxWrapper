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

public class FbxLayerElementTemplateFbxVector4 : FbxLayerElement {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementTemplateFbxVector4(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementTemplateFbxVector4 obj) {
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

  public DirectArrayFbxVector4 GetDirectArray() {
    DirectArrayFbxVector4 ret = new DirectArrayFbxVector4(fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_GetDirectArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public DirectArrayFbxInt GetIndexArray() {
    DirectArrayFbxInt ret = new DirectArrayFbxInt(fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_GetIndexArray__SWIG_0(swigCPtr), false);
    return ret;
  }

  public override bool Clear() {
    bool ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_Clear(swigCPtr);
    return ret;
  }

  public bool eq(FbxLayerElementTemplateFbxVector4 pOther) {
    bool ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_eq(swigCPtr, FbxLayerElementTemplateFbxVector4.getCPtr(pOther));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxLayerElementTemplateFbxVector4 assign(FbxLayerElementTemplateFbxVector4 pOther) {
    FbxLayerElementTemplateFbxVector4 ret = new FbxLayerElementTemplateFbxVector4(fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_assign(swigCPtr, FbxLayerElementTemplateFbxVector4.getCPtr(pOther)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int RemapIndexTo(FbxLayerElement.EMappingMode pNewMapping) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_RemapIndexTo(swigCPtr, (int)pNewMapping);
    return ret;
  }

  public override int MemorySize() {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_MemorySize(swigCPtr);
    return ret;
  }

  public override bool ContentWriteTo(FbxStream pStream) {
    bool ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_ContentWriteTo(swigCPtr, FbxStream.getCPtr(pStream));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override bool ContentReadFrom(FbxStream pStream) {
    bool ret = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_ContentReadFrom(swigCPtr, FbxStream.getCPtr(pStream));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DirectArrayFbxVector4 mDirectArray {
    set {
      fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_mDirectArray_set(swigCPtr, DirectArrayFbxVector4.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_mDirectArray_get(swigCPtr);
      DirectArrayFbxVector4 ret = (cPtr == global::System.IntPtr.Zero) ? null : new DirectArrayFbxVector4(cPtr, false);
      return ret;
    } 
  }

  public DirectArrayFbxInt mIndexArray {
    set {
      fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_mIndexArray_set(swigCPtr, DirectArrayFbxInt.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementTemplateFbxVector4_mIndexArray_get(swigCPtr);
      DirectArrayFbxInt ret = (cPtr == global::System.IntPtr.Zero) ? null : new DirectArrayFbxInt(cPtr, false);
      return ret;
    } 
  }

}

}
