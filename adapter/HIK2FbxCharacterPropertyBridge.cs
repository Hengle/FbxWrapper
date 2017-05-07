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

public class HIK2FbxCharacterPropertyBridge : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal HIK2FbxCharacterPropertyBridge(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(HIK2FbxCharacterPropertyBridge obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~HIK2FbxCharacterPropertyBridge() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_HIK2FbxCharacterPropertyBridge(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FbxCharacterPropertyInfo GetAt(int i) {
    FbxCharacterPropertyInfo ret = new FbxCharacterPropertyInfo(fbx_wrapperPINVOKE.HIK2FbxCharacterPropertyBridge_GetAt(i), false);
    return ret;
  }

  public static FbxCharacterPropertyInfo GetPropertyInfoFromFbxCharacterProperty(string pCharacterPropertyName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.HIK2FbxCharacterPropertyBridge_GetPropertyInfoFromFbxCharacterProperty(pCharacterPropertyName);
    FbxCharacterPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCharacterPropertyInfo(cPtr, false);
    return ret;
  }

  public static FbxCharacterPropertyInfo GetPropertyInfoFromHIKProperty(string pHIKPropertyName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.HIK2FbxCharacterPropertyBridge_GetPropertyInfoFromHIKProperty(pHIKPropertyName);
    FbxCharacterPropertyInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxCharacterPropertyInfo(cPtr, false);
    return ret;
  }

  public HIK2FbxCharacterPropertyBridge() : this(fbx_wrapperPINVOKE.new_HIK2FbxCharacterPropertyBridge(), true) {
  }

  public static readonly int mParamCount = fbx_wrapperPINVOKE.HIK2FbxCharacterPropertyBridge_mParamCount_get();

}

}