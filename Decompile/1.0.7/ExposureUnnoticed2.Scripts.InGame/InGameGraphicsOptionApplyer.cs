using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.ObjectUI.OptionMenu;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace ExposureUnnoticed2.Scripts.InGame;

public class InGameGraphicsOptionApplyer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_postProcessLayers;

	private static readonly IntPtr NativeFieldInfoPtr_postProcessVolume;

	private static readonly IntPtr NativeFieldInfoPtr_postProcessVolumeSelfCamera;

	private static readonly IntPtr NativeFieldInfoPtr_isTitle;

	private static readonly IntPtr NativeFieldInfoPtr_initBrightness;

	private static readonly IntPtr NativeFieldInfoPtr_optionData;

	private static readonly IntPtr NativeFieldInfoPtr_ColorGrading;

	private static readonly IntPtr NativeFieldInfoPtr_ColorGradingSelfCamera;

	private static readonly IntPtr NativeFieldInfoPtr_AmbientOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_ScreenSpaceReflections;

	private static readonly IntPtr NativeFieldInfoPtr_Bloom;

	private static readonly IntPtr NativeFieldInfoPtr_BloomSelf;

	private static readonly IntPtr NativeFieldInfoPtr_MotionBlur;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeStage_Private_Void_CompleteTransitionStageEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChange_Private_Void_GraphicsOptionChangeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetBloomThreshold_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<PostProcessLayer> postProcessLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessLayers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PostProcessLayer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessLayers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PostProcessVolume postProcessVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessVolume);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessVolume), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PostProcessVolume postProcessVolumeSelfCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessVolumeSelfCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PostProcessVolume>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postProcessVolumeSelfCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isTitle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTitle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTitle)) = flag;
		}
	}

	public unsafe float initBrightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initBrightness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initBrightness)) = num;
		}
	}

	public unsafe OptionData optionData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OptionData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_optionData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ColorGrading ColorGrading
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorGrading);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ColorGrading>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorGrading), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ColorGrading ColorGradingSelfCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorGradingSelfCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ColorGrading>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorGradingSelfCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AmbientOcclusion AmbientOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmbientOcclusion);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AmbientOcclusion>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AmbientOcclusion), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ScreenSpaceReflections ScreenSpaceReflections
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScreenSpaceReflections);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ScreenSpaceReflections>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ScreenSpaceReflections), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Bloom Bloom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bloom);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Bloom>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bloom), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Bloom BloomSelf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomSelf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Bloom>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomSelf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MotionBlur MotionBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionBlur);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MotionBlur>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionBlur), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 75058, RefRangeEnd = 75060, XrefRangeStart = 74998, XrefRangeEnd = 75058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75060, XrefRangeEnd = 75090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75090, XrefRangeEnd = 75091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeTime([DefaultParameterValue(null)] ChangeTimeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeStage([DefaultParameterValue(null)] CompleteTransitionStageEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeStage_Private_Void_CompleteTransitionStageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 75113, RefRangeEnd = 75114, XrefRangeStart = 75091, XrefRangeEnd = 75113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChange([DefaultParameterValue(null)] GraphicsOptionChangeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChange_Private_Void_GraphicsOptionChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 75117, RefRangeEnd = 75119, XrefRangeStart = 75114, XrefRangeEnd = 75117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBloomThreshold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBloomThreshold_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameGraphicsOptionApplyer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InGameGraphicsOptionApplyer()
	{
		Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "InGameGraphicsOptionApplyer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr);
		NativeFieldInfoPtr_postProcessLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "postProcessLayers");
		NativeFieldInfoPtr_postProcessVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "postProcessVolume");
		NativeFieldInfoPtr_postProcessVolumeSelfCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "postProcessVolumeSelfCamera");
		NativeFieldInfoPtr_isTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "isTitle");
		NativeFieldInfoPtr_initBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "initBrightness");
		NativeFieldInfoPtr_optionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "optionData");
		NativeFieldInfoPtr_ColorGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "ColorGrading");
		NativeFieldInfoPtr_ColorGradingSelfCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "ColorGradingSelfCamera");
		NativeFieldInfoPtr_AmbientOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "AmbientOcclusion");
		NativeFieldInfoPtr_ScreenSpaceReflections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "ScreenSpaceReflections");
		NativeFieldInfoPtr_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "Bloom");
		NativeFieldInfoPtr_BloomSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "BloomSelf");
		NativeFieldInfoPtr_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, "MotionBlur");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668775);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668776);
		NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668777);
		NativeMethodInfoPtr_OnChangeStage_Private_Void_CompleteTransitionStageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668778);
		NativeMethodInfoPtr_OnChange_Private_Void_GraphicsOptionChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668779);
		NativeMethodInfoPtr_SetBloomThreshold_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668780);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameGraphicsOptionApplyer>.NativeClassPtr, 100668781);
	}

	public InGameGraphicsOptionApplyer(IntPtr pointer)
		: base(pointer)
	{
	}
}
