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

public class FbxDataType : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxDataType(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxDataType obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxDataType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxDataType(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxDataType Create(string pName, EFbxType pType) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxDataType_Create__SWIG_0(pName, (int)pType), true);
    return ret;
  }

  public static FbxDataType Create(string pName, FbxDataType pDataType) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxDataType_Create__SWIG_1(pName, FbxDataType.getCPtr(pDataType)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDataType() : this(fbx_wrapperPINVOKE.new_FbxDataType__SWIG_0(), true) {
  }

  public FbxDataType(FbxDataType pDataType) : this(fbx_wrapperPINVOKE.new_FbxDataType__SWIG_1(FbxDataType.getCPtr(pDataType)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Destroy() {
    fbx_wrapperPINVOKE.FbxDataType_Destroy(swigCPtr);
  }

  public FbxDataType(FbxPropertyHandle pTypeInfoHandle) : this(fbx_wrapperPINVOKE.new_FbxDataType__SWIG_2(FbxPropertyHandle.getCPtr(pTypeInfoHandle)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxDataType assign(FbxDataType pDataType) {
    FbxDataType ret = new FbxDataType(fbx_wrapperPINVOKE.FbxDataType_assign(swigCPtr, FbxDataType.getCPtr(pDataType)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(FbxDataType pDataType) {
    bool ret = fbx_wrapperPINVOKE.FbxDataType_eq(swigCPtr, FbxDataType.getCPtr(pDataType));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxDataType pDataType) {
    bool ret = fbx_wrapperPINVOKE.FbxDataType_ne(swigCPtr, FbxDataType.getCPtr(pDataType));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Valid() {
    bool ret = fbx_wrapperPINVOKE.FbxDataType_Valid(swigCPtr);
    return ret;
  }

  public bool Is(FbxDataType pDataType) {
    bool ret = fbx_wrapperPINVOKE.FbxDataType_Is(swigCPtr, FbxDataType.getCPtr(pDataType));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public EFbxType GetType() {
    EFbxType ret = (EFbxType)fbx_wrapperPINVOKE.FbxDataType_GetType(swigCPtr);
    return ret;
  }

  public string GetName() {
    string ret = fbx_wrapperPINVOKE.FbxDataType_GetName(swigCPtr);
    return ret;
  }

  public FbxPropertyHandle GetTypeInfoHandle() {
    FbxPropertyHandle ret = new FbxPropertyHandle(fbx_wrapperPINVOKE.FbxDataType_GetTypeInfoHandle(swigCPtr), false);
    return ret;
  }

}

}