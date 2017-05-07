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

public class FbxPeripheral : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxPeripheral(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxPeripheral obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxPeripheral() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxPeripheral(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void Reset() {
    fbx_wrapperPINVOKE.FbxPeripheral_Reset(swigCPtr);
  }

  public virtual bool UnloadContentOf(FbxObject pObject) {
    bool ret = fbx_wrapperPINVOKE.FbxPeripheral_UnloadContentOf(swigCPtr, FbxObject.getCPtr(pObject));
    return ret;
  }

  public virtual bool LoadContentOf(FbxObject pObject) {
    bool ret = fbx_wrapperPINVOKE.FbxPeripheral_LoadContentOf(swigCPtr, FbxObject.getCPtr(pObject));
    return ret;
  }

  public virtual bool CanUnloadContentOf(FbxObject pObject) {
    bool ret = fbx_wrapperPINVOKE.FbxPeripheral_CanUnloadContentOf(swigCPtr, FbxObject.getCPtr(pObject));
    return ret;
  }

  public virtual bool CanLoadContentOf(FbxObject pObject) {
    bool ret = fbx_wrapperPINVOKE.FbxPeripheral_CanLoadContentOf(swigCPtr, FbxObject.getCPtr(pObject));
    return ret;
  }

  public virtual void InitializeConnectionsOf(FbxObject pObject) {
    fbx_wrapperPINVOKE.FbxPeripheral_InitializeConnectionsOf(swigCPtr, FbxObject.getCPtr(pObject));
  }

  public virtual void UninitializeConnectionsOf(FbxObject pObject) {
    fbx_wrapperPINVOKE.FbxPeripheral_UninitializeConnectionsOf(swigCPtr, FbxObject.getCPtr(pObject));
  }

}

}
