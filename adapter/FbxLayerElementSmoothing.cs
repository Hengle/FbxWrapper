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

public class FbxLayerElementSmoothing : FbxLayerElementTemplateFbxInt {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementSmoothing(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLayerElementSmoothing_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementSmoothing obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementSmoothing() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxLayerElementSmoothing(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxLayerElementSmoothing Create(FbxLayerContainer pOwner, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementSmoothing_Create(FbxLayerContainer.getCPtr(pOwner), pName);
    FbxLayerElementSmoothing ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementSmoothing(cPtr, false);
    return ret;
  }

  public new void SetReferenceMode(FbxLayerElement.EReferenceMode pMode) {
    fbx_wrapperPINVOKE.FbxLayerElementSmoothing_SetReferenceMode(swigCPtr, (int)pMode);
  }

}

}
