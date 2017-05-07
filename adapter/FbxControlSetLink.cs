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

public class FbxControlSetLink : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxControlSetLink(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxControlSetLink obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxControlSetLink() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxControlSetLink(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxControlSetLink() : this(fbx_wrapperPINVOKE.new_FbxControlSetLink__SWIG_0(), true) {
  }

  public FbxControlSetLink(FbxControlSetLink pControlSetLink) : this(fbx_wrapperPINVOKE.new_FbxControlSetLink__SWIG_1(FbxControlSetLink.getCPtr(pControlSetLink)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxControlSetLink assign(FbxControlSetLink pControlSetLink) {
    FbxControlSetLink ret = new FbxControlSetLink(fbx_wrapperPINVOKE.FbxControlSetLink_assign(swigCPtr, FbxControlSetLink.getCPtr(pControlSetLink)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reset() {
    fbx_wrapperPINVOKE.FbxControlSetLink_Reset(swigCPtr);
  }

  public FbxNode mNode {
    set {
      fbx_wrapperPINVOKE.FbxControlSetLink_mNode_set(swigCPtr, FbxNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxControlSetLink_mNode_get(swigCPtr);
      FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
      return ret;
    } 
  }

  public FbxString mTemplateName {
    set {
      fbx_wrapperPINVOKE.FbxControlSetLink_mTemplateName_set(swigCPtr, FbxString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxControlSetLink_mTemplateName_get(swigCPtr);
      FbxString ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxString(cPtr, false);
      return ret;
    } 
  }

}

}
