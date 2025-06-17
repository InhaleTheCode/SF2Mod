using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.CommonUI.CommonGauge;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class SlowAssistManager : MonoBehaviour
{
	public enum State
	{
		Normal,
		Slow,
		GameOver
	}

	private static readonly IntPtr NativeFieldInfoPtr_SlowScale;

	private static readonly IntPtr NativeFieldInfoPtr_RiseTimePerSecond;

	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeFieldInfoPtr_remainTimeGauge;

	private static readonly IntPtr NativeFieldInfoPtr_viewAnimator;

	private static readonly IntPtr NativeFieldInfoPtr_slowInAudioSource;

	private static readonly IntPtr NativeFieldInfoPtr_slowOutAudioSource;

	private static readonly IntPtr NativeFieldInfoPtr_gogogoAudioSource;

	private static readonly IntPtr NativeFieldInfoPtr_currentTimeScale;

	private static readonly IntPtr NativeFieldInfoPtr_currentGogogoVolume;

	private static readonly IntPtr NativeFieldInfoPtr__currentState_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_maxSlowRemainTime;

	private static readonly IntPtr NativeFieldInfoPtr_isCancelSlow;

	private static readonly IntPtr NativeFieldInfoPtr_inSlowByAutoSkill;

	private static readonly IntPtr NativeFieldInfoPtr_inSlowByAutoBaretaSkill;

	private static readonly IntPtr NativeFieldInfoPtr_isCancelAutoBaretaSlowSkill;

	private static readonly IntPtr NativeFieldInfoPtr_disableAutoSlowRemainTime;

	private static readonly IntPtr NativeFieldInfoPtr_IsDisplayMain;

	private static readonly IntPtr NativeFieldInfoPtr_IsDisplayGauge;

	private static readonly IntPtr NativeMethodInfoPtr_get_currentState_Public_get_State_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_currentState_Private_set_Void_State_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlaySe_Private_Void_SeType_0;

	private static readonly IntPtr NativeMethodInfoPtr_NormalUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SlowUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GameOverUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnSkillUp_Private_Void_SkillUpEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_CancelSlow_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnTransitionStageEvent_Private_Void_StartTransitionStageEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float SlowScale
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlowScale, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlowScale, &num);
		}
	}

	public unsafe static float RiseTimePerSecond
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RiseTimePerSecond, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RiseTimePerSecond, &num);
		}
	}

	public unsafe static SlowAssistManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SlowAssistManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GaugeView remainTimeGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainTimeGauge);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GaugeView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainTimeGauge), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Animator viewAnimator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewAnimator);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewAnimator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource slowInAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowInAudioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowInAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource slowOutAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowOutAudioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowOutAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource gogogoAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gogogoAudioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gogogoAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat currentTimeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentTimeScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat currentGogogoVolume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGogogoVolume);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentGogogoVolume), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe State _currentState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentState_k__BackingField);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__currentState_k__BackingField)) = state;
		}
	}

	public unsafe float maxSlowRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlowRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSlowRemainTime)) = num;
		}
	}

	public unsafe bool isCancelSlow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCancelSlow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCancelSlow)) = flag;
		}
	}

	public unsafe bool inSlowByAutoSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSlowByAutoSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSlowByAutoSkill)) = flag;
		}
	}

	public unsafe bool inSlowByAutoBaretaSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSlowByAutoBaretaSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inSlowByAutoBaretaSkill)) = flag;
		}
	}

	public unsafe bool isCancelAutoBaretaSlowSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCancelAutoBaretaSlowSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCancelAutoBaretaSlowSkill)) = flag;
		}
	}

	public unsafe float disableAutoSlowRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableAutoSlowRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disableAutoSlowRemainTime)) = num;
		}
	}

	public unsafe static int IsDisplayMain
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDisplayMain, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDisplayMain, &num);
		}
	}

	public unsafe static int IsDisplayGauge
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDisplayGauge, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDisplayGauge, &num);
		}
	}

	public unsafe State currentState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentState_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(State*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_currentState_Private_set_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77018, RefRangeEnd = 77019, XrefRangeStart = 76975, XrefRangeEnd = 77018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77054, RefRangeEnd = 77055, XrefRangeStart = 77019, XrefRangeEnd = 77054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77055, XrefRangeEnd = 77084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 77087, RefRangeEnd = 77090, XrefRangeStart = 77084, XrefRangeEnd = 77087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySe([DefaultParameterValue(null)] InGameSoundManager.SeType seType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&seType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySe_Private_Void_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77124, RefRangeEnd = 77125, XrefRangeStart = 77090, XrefRangeEnd = 77124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NormalUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NormalUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77157, RefRangeEnd = 77158, XrefRangeStart = 77125, XrefRangeEnd = 77157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SlowUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlowUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void GameOverUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GameOverUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77158, XrefRangeEnd = 77166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnSkillUp([DefaultParameterValue(null)] SkillUpEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnSkillUp_Private_Void_SkillUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void CancelSlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CancelSlow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnTransitionStageEvent([DefaultParameterValue(null)] StartTransitionStageEvent startTransitionStageEvent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(startTransitionStageEvent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTransitionStageEvent_Private_Void_StartTransitionStageEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77166, XrefRangeEnd = 77176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SlowAssistManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SlowAssistManager()
	{
		Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "SlowAssistManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr);
		NativeFieldInfoPtr_SlowScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "SlowScale");
		NativeFieldInfoPtr_RiseTimePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "RiseTimePerSecond");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_remainTimeGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "remainTimeGauge");
		NativeFieldInfoPtr_viewAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "viewAnimator");
		NativeFieldInfoPtr_slowInAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "slowInAudioSource");
		NativeFieldInfoPtr_slowOutAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "slowOutAudioSource");
		NativeFieldInfoPtr_gogogoAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "gogogoAudioSource");
		NativeFieldInfoPtr_currentTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "currentTimeScale");
		NativeFieldInfoPtr_currentGogogoVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "currentGogogoVolume");
		NativeFieldInfoPtr__currentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "<currentState>k__BackingField");
		NativeFieldInfoPtr_maxSlowRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "maxSlowRemainTime");
		NativeFieldInfoPtr_isCancelSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "isCancelSlow");
		NativeFieldInfoPtr_inSlowByAutoSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "inSlowByAutoSkill");
		NativeFieldInfoPtr_inSlowByAutoBaretaSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "inSlowByAutoBaretaSkill");
		NativeFieldInfoPtr_isCancelAutoBaretaSlowSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "isCancelAutoBaretaSlowSkill");
		NativeFieldInfoPtr_disableAutoSlowRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "disableAutoSlowRemainTime");
		NativeFieldInfoPtr_IsDisplayMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "IsDisplayMain");
		NativeFieldInfoPtr_IsDisplayGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, "IsDisplayGauge");
		NativeMethodInfoPtr_get_currentState_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668966);
		NativeMethodInfoPtr_set_currentState_Private_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668967);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668968);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668969);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668970);
		NativeMethodInfoPtr_PlaySe_Private_Void_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668971);
		NativeMethodInfoPtr_NormalUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668972);
		NativeMethodInfoPtr_SlowUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668973);
		NativeMethodInfoPtr_GameOverUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668974);
		NativeMethodInfoPtr_OnSkillUp_Private_Void_SkillUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668975);
		NativeMethodInfoPtr_CancelSlow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668976);
		NativeMethodInfoPtr_OnTransitionStageEvent_Private_Void_StartTransitionStageEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668977);
		NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668978);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlowAssistManager>.NativeClassPtr, 100668979);
	}

	public SlowAssistManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
