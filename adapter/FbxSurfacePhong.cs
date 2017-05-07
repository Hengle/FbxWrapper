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

public class FbxSurfacePhong : FbxSurfaceLambert {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSurfacePhong(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxSurfacePhong_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSurfacePhong obj) {
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

  public static FbxClassId ClassId {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxSurfacePhong_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSurfacePhong Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSurfacePhong ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfacePhong(cPtr, false);
    return ret;
  }

  public new static FbxSurfacePhong Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSurfacePhong ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfacePhong(cPtr, false);
    return ret;
  }

  public FbxPropertyTDouble3 Specular {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_Specular_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_Specular_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble SpecularFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_SpecularFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_SpecularFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble Shininess {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_Shininess_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_Shininess_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Reflection {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_Reflection_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_Reflection_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble ReflectionFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfacePhong_ReflectionFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_ReflectionFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public static FbxDouble3 sSpecularDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_sSpecularDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sSpecularFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfacePhong_sSpecularFactorDefault_get();
      return ret;
    } 
  }

  public static double sShininessDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfacePhong_sShininessDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sReflectionDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfacePhong_sReflectionDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sReflectionFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfacePhong_sReflectionFactorDefault_get();
      return ret;
    } 
  }

}

}
