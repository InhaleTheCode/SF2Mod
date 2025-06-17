using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.InGame.HeatBeatPanel;

public class HeartRatePanelView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_UpdateBeatInterval;

	private static readonly IntPtr NativeFieldInfoPtr_vignetteCanvas;

	private static readonly IntPtr NativeFieldInfoPtr_audioVolumeScale;

	private static readonly IntPtr NativeFieldInfoPtr_heartRateText;

	private static readonly IntPtr NativeFieldInfoPtr_lastUpdateTime;

	private static readonly IntPtr NativeFieldInfoPtr_animator;

	private static readonly IntPtr NativeFieldInfoPtr_audioSource;

	private static readonly IntPtr NativeFieldInfoPtr_BeatRate;

	private static readonly IntPtr NativeFieldInfoPtr_BeatRateNijo;

	private static readonly IntPtr NativeFieldInfoPtr_BeatRateSanjo;

	private static readonly IntPtr NativeFieldInfoPtr_randoms;

	private static readonly IntPtr NativeFieldInfoPtr_randomIndex;

	private static readonly IntPtr NativeFieldInfoPtr_playerHeartBeat;

	private static readonly IntPtr NativeFieldInfoPtr_oldAnimatorSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_NoVignette;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerHeartBeat_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateRandom_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomSum_Private_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_PlayHeatBeat_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeOption_Private_Void_OptionChangeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__15_0_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnLateUpdate_b__17_0_Private_Void_0;

	public unsafe static float UpdateBeatInterval
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpdateBeatInterval, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpdateBeatInterval, &num);
		}
	}

	public unsafe CanvasGroup vignetteCanvas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteCanvas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vignetteCanvas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat audioVolumeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioVolumeScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioVolumeScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI heartRateText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heartRateText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_heartRateText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float lastUpdateTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastUpdateTime)) = num;
		}
	}

	public unsafe Animator animator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource audioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int BeatRate
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeatRate, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeatRate, &num);
		}
	}

	public unsafe static int BeatRateNijo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeatRateNijo, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeatRateNijo, &num);
		}
	}

	public unsafe static int BeatRateSanjo
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BeatRateSanjo, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BeatRateSanjo, &num);
		}
	}

	public unsafe Il2CppStructArray<float> randoms
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randoms);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randoms), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int randomIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomIndex)) = num;
		}
	}

	public unsafe PlayerHeartBeat playerHeartBeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeartBeat);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerHeartBeat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerHeartBeat), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float oldAnimatorSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldAnimatorSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldAnimatorSpeed)) = num;
		}
	}

	public unsafe static int NoVignette
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoVignette, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoVignette, &num);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93615, RefRangeEnd = 93616, XrefRangeStart = 93586, XrefRangeEnd = 93615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerHeartBeat playerHeartBeat)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerHeartBeat);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerHeartBeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93616, XrefRangeEnd = 93628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 93664, RefRangeEnd = 93665, XrefRangeStart = 93628, XrefRangeEnd = 93664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93665, XrefRangeEnd = 93667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateRandom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateRandom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93667, XrefRangeEnd = 93668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetRandomSum()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomSum_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93668, XrefRangeEnd = 93673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayHeatBeat([DefaultParameterValue(null)] int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayHeatBeat_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93673, XrefRangeEnd = 93680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeOption([DefaultParameterValue(null)] OptionChangeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeOption_Private_Void_OptionChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93680, XrefRangeEnd = 93690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeartRatePanelView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize_b__15_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__15_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93690, XrefRangeEnd = 93695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnLateUpdate_b__17_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnLateUpdate_b__17_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HeartRatePanelView()
	{
		Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InGame.HeatBeatPanel", "HeartRatePanelView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr);
		NativeFieldInfoPtr_UpdateBeatInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "UpdateBeatInterval");
		NativeFieldInfoPtr_vignetteCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "vignetteCanvas");
		NativeFieldInfoPtr_audioVolumeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "audioVolumeScale");
		NativeFieldInfoPtr_heartRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "heartRateText");
		NativeFieldInfoPtr_lastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "lastUpdateTime");
		NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "animator");
		NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "audioSource");
		NativeFieldInfoPtr_BeatRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "BeatRate");
		NativeFieldInfoPtr_BeatRateNijo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "BeatRateNijo");
		NativeFieldInfoPtr_BeatRateSanjo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "BeatRateSanjo");
		NativeFieldInfoPtr_randoms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "randoms");
		NativeFieldInfoPtr_randomIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "randomIndex");
		NativeFieldInfoPtr_playerHeartBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "playerHeartBeat");
		NativeFieldInfoPtr_oldAnimatorSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "oldAnimatorSpeed");
		NativeFieldInfoPtr_NoVignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, "NoVignette");
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerHeartBeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670153);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670154);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670155);
		NativeMethodInfoPtr_UpdateRandom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670156);
		NativeMethodInfoPtr_GetRandomSum_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670157);
		NativeMethodInfoPtr_PlayHeatBeat_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670158);
		NativeMethodInfoPtr_OnChangeOption_Private_Void_OptionChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670159);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670160);
		NativeMethodInfoPtr__Initialize_b__15_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670162);
		NativeMethodInfoPtr__OnLateUpdate_b__17_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartRatePanelView>.NativeClassPtr, 100670163);
	}

	public HeartRatePanelView(IntPtr pointer)
		: base(pointer)
	{
	}
}
