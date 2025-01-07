#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AkPositioningInfo : global::System.IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPositioningInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkPositioningInfo obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkPositioningInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkUnitySoundEnginePINVOKE.CSharp_delete_AkPositioningInfo(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float fCenterPct { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fCenterPct_get(swigCPtr); } 
  }

  public AkSpeakerPanningType pannerType { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_set(swigCPtr, (int)value); }  get { return (AkSpeakerPanningType)AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_pannerType_get(swigCPtr); } 
  }

  public Ak3DPositionType e3dPositioningType { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_e3dPositioningType_set(swigCPtr, (int)value); }  get { return (Ak3DPositionType)AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_e3dPositioningType_get(swigCPtr); } 
  }

  public bool bHoldEmitterPosAndOrient { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bHoldEmitterPosAndOrient_get(swigCPtr); } 
  }

  public Ak3DSpatializationMode e3DSpatializationMode { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_e3DSpatializationMode_set(swigCPtr, (int)value); }  get { return (Ak3DSpatializationMode)AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_e3DSpatializationMode_get(swigCPtr); } 
  }

  public bool bEnableAttenuation { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bEnableAttenuation_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bEnableAttenuation_get(swigCPtr); } 
  }

  public bool bUseConeAttenuation { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_bUseConeAttenuation_get(swigCPtr); } 
  }

  public float fInnerAngle { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fInnerAngle_get(swigCPtr); } 
  }

  public float fOuterAngle { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fOuterAngle_get(swigCPtr); } 
  }

  public float fConeMaxAttenuation { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fConeMaxAttenuation_get(swigCPtr); } 
  }

  public float LPFCone { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFCone_get(swigCPtr); } 
  }

  public float HPFCone { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFCone_get(swigCPtr); } 
  }

  public float fMaxDistance { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fMaxDistance_get(swigCPtr); } 
  }

  public float fVolDryAtMaxDist { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolDryAtMaxDist_get(swigCPtr); } 
  }

  public float fVolAuxGameDefAtMaxDist { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxGameDefAtMaxDist_get(swigCPtr); } 
  }

  public float fVolAuxUserDefAtMaxDist { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_fVolAuxUserDefAtMaxDist_get(swigCPtr); } 
  }

  public float LPFValueAtMaxDist { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_LPFValueAtMaxDist_get(swigCPtr); } 
  }

  public float HPFValueAtMaxDist { set { AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_set(swigCPtr, value); }  get { return AkUnitySoundEnginePINVOKE.CSharp_AkPositioningInfo_HPFValueAtMaxDist_get(swigCPtr); } 
  }

  public AkPositioningInfo() : this(AkUnitySoundEnginePINVOKE.CSharp_new_AkPositioningInfo(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.