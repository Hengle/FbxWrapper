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

public class FbxRenamingStrategy : FbxRenamingStrategyInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxRenamingStrategy(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxRenamingStrategy_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxRenamingStrategy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxRenamingStrategy() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxRenamingStrategy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public FbxRenamingStrategy(FbxRenamingStrategy.EDirection pMod, bool pOnCreationRun) : this(fbx_wrapperPINVOKE.new_FbxRenamingStrategy__SWIG_0((int)pMod, pOnCreationRun), true) {
  }

  public FbxRenamingStrategy(FbxRenamingStrategy.EDirection pMod) : this(fbx_wrapperPINVOKE.new_FbxRenamingStrategy__SWIG_1((int)pMod), true) {
  }

  public override bool Rename(FbxNameHandler pName) {
    bool ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_Rename(swigCPtr, FbxNameHandler.getCPtr(pName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override void Clear() {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_Clear(swigCPtr);
  }

  public override FbxRenamingStrategyInterface Clone() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxRenamingStrategy_Clone(swigCPtr);
    FbxRenamingStrategyInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxRenamingStrategyInterface(cPtr, false);
    return ret;
  }

  public void SetClashSoverType(FbxRenamingStrategy.EClashType pType) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetClashSoverType(swigCPtr, (int)pType);
  }

  public static string NoPrefixName(string pName) {
    string ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_NoPrefixName__SWIG_0(pName);
    return ret;
  }

  public static string NoPrefixName(FbxString pName) {
    string ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_NoPrefixName__SWIG_1(FbxString.getCPtr(pName));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string GetNameSpace() {
    string ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_GetNameSpace(swigCPtr);
    return ret;
  }

  public virtual void SetInNameSpaceSymbol(FbxString pNameSpaceSymbol) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetInNameSpaceSymbol(swigCPtr, FbxString.getCPtr(pNameSpaceSymbol));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetOutNameSpaceSymbol(FbxString pNameSpaceSymbol) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetOutNameSpaceSymbol(swigCPtr, FbxString.getCPtr(pNameSpaceSymbol));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void SetCaseSensibility(bool pIsCaseSensitive) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetCaseSensibility(swigCPtr, pIsCaseSensitive);
  }

  public virtual void SetReplaceNonAlphaNum(bool pReplaceNonAlphaNum) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetReplaceNonAlphaNum(swigCPtr, pReplaceNonAlphaNum);
  }

  public virtual void SetFirstNotNum(bool pFirstNotNum) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_SetFirstNotNum(swigCPtr, pFirstNotNum);
  }

  public virtual bool RenameUnparentNameSpace(FbxNode pNode, bool pIsRoot) {
    bool ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_RenameUnparentNameSpace__SWIG_0(swigCPtr, FbxNode.getCPtr(pNode), pIsRoot);
    return ret;
  }

  public virtual bool RenameUnparentNameSpace(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_RenameUnparentNameSpace__SWIG_1(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public virtual bool RemoveImportNameSpaceClash(FbxNode pNode) {
    bool ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_RemoveImportNameSpaceClash(swigCPtr, FbxNode.getCPtr(pNode));
    return ret;
  }

  public virtual void GetParentsNameSpaceList(FbxNode pNode, SWIGTYPE_p_FbxArrayT_FbxString_p_t pNameSpaceList) {
    fbx_wrapperPINVOKE.FbxRenamingStrategy_GetParentsNameSpaceList(swigCPtr, FbxNode.getCPtr(pNode), SWIGTYPE_p_FbxArrayT_FbxString_p_t.getCPtr(pNameSpaceList));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool PropagateNameSpaceChange(FbxNode pNode, FbxString OldNS, FbxString NewNS) {
    bool ret = fbx_wrapperPINVOKE.FbxRenamingStrategy_PropagateNameSpaceChange(swigCPtr, FbxNode.getCPtr(pNode), FbxString.getCPtr(OldNS), FbxString.getCPtr(NewNS));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum EDirection {
    eToFBX,
    eFromFBX
  }

  public enum EClashType {
    eNameClashAuto,
    eNameClashType1,
    eNameClashType2
  }

}

}