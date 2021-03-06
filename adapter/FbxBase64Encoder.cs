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

public class FbxBase64Encoder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxBase64Encoder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxBase64Encoder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxBase64Encoder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxBase64Encoder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int Encode(SWIGTYPE_p_void pInBuffer, int pInSize, SWIGTYPE_p_void pOutBuffer, int pOutSize) {
    int ret = fbx_wrapperPINVOKE.FbxBase64Encoder_Encode__SWIG_0(swigCPtr, SWIGTYPE_p_void.getCPtr(pInBuffer), pInSize, SWIGTYPE_p_void.getCPtr(pOutBuffer), pOutSize);
    return ret;
  }

  public int Encode(SWIGTYPE_p_void pInBuffer, int pInSize, FbxString pOutBuffer) {
    int ret = fbx_wrapperPINVOKE.FbxBase64Encoder_Encode__SWIG_1(swigCPtr, SWIGTYPE_p_void.getCPtr(pInBuffer), pInSize, FbxString.getCPtr(pOutBuffer));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxBase64Encoder() : this(fbx_wrapperPINVOKE.new_FbxBase64Encoder(), true) {
  }

}

}
