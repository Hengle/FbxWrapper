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

public class FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr : FbxLayerElementArray {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr(EFbxType pDataType) : this(fbx_wrapperPINVOKE.new_FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr((int)pDataType), true) {
  }

  public int Add(FbxSurfaceMaterial pItem) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_Add(swigCPtr, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public int InsertAt(int pIndex, FbxSurfaceMaterial pItem) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_InsertAt(swigCPtr, pIndex, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public void SetAt(int pIndex, FbxSurfaceMaterial pItem) {
    fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_SetAt(swigCPtr, pIndex, FbxSurfaceMaterial.getCPtr(pItem));
  }

  public void SetLast(FbxSurfaceMaterial pItem) {
    fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_SetLast(swigCPtr, FbxSurfaceMaterial.getCPtr(pItem));
  }

  public FbxSurfaceMaterial RemoveAt(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_RemoveAt(swigCPtr, pIndex);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public FbxSurfaceMaterial RemoveLast() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_RemoveLast(swigCPtr);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public bool RemoveIt(FbxSurfaceMaterial pItem) {
    bool ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_RemoveIt(swigCPtr, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public FbxSurfaceMaterial GetAt(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_GetAt(swigCPtr, pIndex);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public FbxSurfaceMaterial GetFirst() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_GetFirst(swigCPtr);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public FbxSurfaceMaterial GetLast() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_GetLast(swigCPtr);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public int Find(FbxSurfaceMaterial pItem) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_Find(swigCPtr, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public int FindAfter(int pAfterIndex, FbxSurfaceMaterial pItem) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_FindAfter(swigCPtr, pAfterIndex, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public int FindBefore(int pBeforeIndex, FbxSurfaceMaterial pItem) {
    int ret = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_FindBefore(swigCPtr, pBeforeIndex, FbxSurfaceMaterial.getCPtr(pItem));
    return ret;
  }

  public FbxSurfaceMaterial at(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_at(swigCPtr, pIndex);
    FbxSurfaceMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceMaterial(cPtr, false);
    return ret;
  }

  public FbxLayerElementArray assign(SWIGTYPE_p_FbxArrayT_FbxSurfaceMaterial_p_t pArrayTemplate) {
    FbxLayerElementArray ret = new FbxLayerElementArray(fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_assign__SWIG_0(swigCPtr, SWIGTYPE_p_FbxArrayT_FbxSurfaceMaterial_p_t.getCPtr(pArrayTemplate)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DirectArrayFbxSurfaceMaterialPtr assign(DirectArrayFbxSurfaceMaterialPtr pArrayTemplate) {
    DirectArrayFbxSurfaceMaterialPtr ret = new DirectArrayFbxSurfaceMaterialPtr(fbx_wrapperPINVOKE.FbxLayerElementArrayTemplateFbxSurfaceMaterialPtr_assign__SWIG_1(swigCPtr, DirectArrayFbxSurfaceMaterialPtr.getCPtr(pArrayTemplate)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
