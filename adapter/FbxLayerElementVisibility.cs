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

public class FbxLayerElementVisibility : FbxLayerElementTemplateFbxBool {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementVisibility(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLayerElementVisibility_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementVisibility obj) {
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

  public static FbxLayerElementVisibility Create(FbxLayerContainer pOwner, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementVisibility_Create(FbxLayerContainer.getCPtr(pOwner), pName);
    FbxLayerElementVisibility ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxLayerElementVisibility(cPtr, false);
    return ret;
  }

}

}
