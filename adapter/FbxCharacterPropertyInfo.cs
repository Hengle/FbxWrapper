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

public class FbxCharacterPropertyInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxCharacterPropertyInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxCharacterPropertyInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxCharacterPropertyInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxCharacterPropertyInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string mHIKPropertyName {
    set {
      fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mHIKPropertyName_set(swigCPtr, value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mHIKPropertyName_get(swigCPtr);
      return ret;
    } 
  }

  public string mFbxCharacterPropertyModeName {
    set {
      fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyModeName_set(swigCPtr, value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyModeName_get(swigCPtr);
      return ret;
    } 
  }

  public string mFbxCharacterPropertyName {
    set {
      fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyName_set(swigCPtr, value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mFbxCharacterPropertyName_get(swigCPtr);
      return ret;
    } 
  }

  public int mIndex {
    set {
      fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mIndex_set(swigCPtr, value);
    } 
    get {
      int ret = fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mIndex_get(swigCPtr);
      return ret;
    } 
  }

  public FbxCharacter.EPropertyUnit mUnit {
    set {
      fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mUnit_set(swigCPtr, (int)value);
    } 
    get {
      FbxCharacter.EPropertyUnit ret = (FbxCharacter.EPropertyUnit)fbx_wrapperPINVOKE.FbxCharacterPropertyInfo_mUnit_get(swigCPtr);
      return ret;
    } 
  }

  public FbxCharacterPropertyInfo() : this(fbx_wrapperPINVOKE.new_FbxCharacterPropertyInfo(), true) {
  }

}

}