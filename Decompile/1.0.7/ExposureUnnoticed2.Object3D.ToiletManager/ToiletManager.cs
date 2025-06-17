using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Object3D.ScenePlops.Toilet;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ToiletManager;

public class ToiletManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_malePeePoint;

	private static readonly IntPtr NativeFieldInfoPtr_maleWashPoint;

	private static readonly IntPtr NativeFieldInfoPtr_femaleWashPoint;

	private static readonly IntPtr NativeFieldInfoPtr_maleToiletController;

	private static readonly IntPtr NativeFieldInfoPtr_femaleToiletController;

	private static readonly IntPtr NativeFieldInfoPtr_malePeeWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_maleKoshitsuWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_femaleKoshitsuWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_maleWashWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_femaleWashWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_malePeeAudioSource;

	private static readonly IntPtr NativeFieldInfoPtr_peeTokenDict;

	private static readonly IntPtr NativeFieldInfoPtr_washMaleTokenDict;

	private static readonly IntPtr NativeFieldInfoPtr_washFemaleTokenDict;

	private static readonly IntPtr NativeFieldInfoPtr_koshitsuMaleTokenDict;

	private static readonly IntPtr NativeFieldInfoPtr_koshitsuFemaleTokenDict;

	private static readonly IntPtr NativeFieldInfoPtr_koshitsuMaleFoundPlayerInsideDict;

	private static readonly IntPtr NativeFieldInfoPtr_koshitsuFemaleFoundPlayerInsideDict;

	private static readonly IntPtr NativeFieldInfoPtr__IsPlayerInOpenToilet_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_peeIndexArray;

	private static readonly IntPtr NativeFieldInfoPtr_maleKoshitsuIndexArray;

	private static readonly IntPtr NativeFieldInfoPtr_femaleKoshitsuIndexArray;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ToiletManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ToiletManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsPlayerInOpenToilet_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsPlayerInOpenToilet_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPeeWaitPoint_Public_Transform_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWashWaitPoint_Public_Transform_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetKoshitsuWaitPoint_Public_Transform_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryGetTokenWash_Public_Transform_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReturnTokenWash_Public_Void_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryGetTokenPee_Public_Transform_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReturnTokenPee_Public_Void_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReportToiletInPlayer_Public_Void_ToiletController_0;

	private static readonly IntPtr NativeMethodInfoPtr_TryGetTokenKoshitsu_Public_ToiletController_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_ReturnTokenKoshitsu_Public_Void_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ToiletManager _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ToiletManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> malePeePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeePoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeePoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> maleWashPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleWashPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleWashPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> femaleWashPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleWashPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleWashPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ToiletController> maleToiletController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleToiletController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToiletController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleToiletController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ToiletController> femaleToiletController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleToiletController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToiletController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleToiletController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform malePeeWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeeWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeeWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform maleKoshitsuWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleKoshitsuWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleKoshitsuWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform femaleKoshitsuWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleKoshitsuWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleKoshitsuWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform maleWashWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleWashWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleWashWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform femaleWashWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleWashWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleWashWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioSource> malePeeAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeeAudioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSource>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_malePeeAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, NpcController> peeTokenDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeTokenDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeTokenDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, NpcController> washMaleTokenDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washMaleTokenDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washMaleTokenDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, NpcController> washFemaleTokenDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washFemaleTokenDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washFemaleTokenDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, NpcController> koshitsuMaleTokenDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuMaleTokenDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuMaleTokenDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, NpcController> koshitsuFemaleTokenDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuFemaleTokenDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, NpcController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuFemaleTokenDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, bool> koshitsuMaleFoundPlayerInsideDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuMaleFoundPlayerInsideDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuMaleFoundPlayerInsideDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, bool> koshitsuFemaleFoundPlayerInsideDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuFemaleFoundPlayerInsideDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_koshitsuFemaleFoundPlayerInsideDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _IsPlayerInOpenToilet_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsPlayerInOpenToilet_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsPlayerInOpenToilet_k__BackingField)) = flag;
		}
	}

	public unsafe Il2CppStructArray<int> peeIndexArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeIndexArray);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeIndexArray), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> maleKoshitsuIndexArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleKoshitsuIndexArray);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maleKoshitsuIndexArray), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<int> femaleKoshitsuIndexArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleKoshitsuIndexArray);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_femaleKoshitsuIndexArray), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ToiletManager Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42599, XrefRangeEnd = 42601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ToiletManager_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ToiletManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42601, XrefRangeEnd = 42604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ToiletManager_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsPlayerInOpenToilet
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPlayerInOpenToilet_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsPlayerInOpenToilet_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe Transform GetPeeWaitPoint([DefaultParameterValue(null)] bool isFemale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFemale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPeeWaitPoint_Public_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Transform GetWashWaitPoint([DefaultParameterValue(null)] bool isFemale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFemale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWashWaitPoint_Public_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Transform GetKoshitsuWaitPoint([DefaultParameterValue(null)] bool isFemale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFemale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKoshitsuWaitPoint_Public_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42604, XrefRangeEnd = 42616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42616, XrefRangeEnd = 42629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42657, RefRangeEnd = 42658, XrefRangeStart = 42629, XrefRangeEnd = 42657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 42733, RefRangeEnd = 42736, XrefRangeStart = 42658, XrefRangeEnd = 42733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42736, XrefRangeEnd = 42737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeTime([DefaultParameterValue(null)] ChangeTimeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42762, RefRangeEnd = 42763, XrefRangeStart = 42737, XrefRangeEnd = 42762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42763, XrefRangeEnd = 42767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform TryGetTokenWash([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTokenWash_Public_Transform_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42767, XrefRangeEnd = 42771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnTokenWash([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnTokenWash_Public_Void_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42771, XrefRangeEnd = 42781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform TryGetTokenPee([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTokenPee_Public_Transform_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42781, XrefRangeEnd = 42785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnTokenPee([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnTokenPee_Public_Void_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42785, XrefRangeEnd = 42802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReportToiletInPlayer([DefaultParameterValue(null)] ToiletController toiletController)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(toiletController);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReportToiletInPlayer_Public_Void_ToiletController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42818, RefRangeEnd = 42819, XrefRangeStart = 42802, XrefRangeEnd = 42818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToiletController TryGetTokenKoshitsu([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryGetTokenKoshitsu_Public_ToiletController_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ToiletController>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42828, RefRangeEnd = 42829, XrefRangeStart = 42819, XrefRangeEnd = 42828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnTokenKoshitsu([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReturnTokenKoshitsu_Public_Void_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42829, XrefRangeEnd = 42875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ToiletManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ToiletManager()
	{
		Il2CppClassPointerStore<ToiletManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ToiletManager", "ToiletManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_malePeePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "malePeePoint");
		NativeFieldInfoPtr_maleWashPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "maleWashPoint");
		NativeFieldInfoPtr_femaleWashPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "femaleWashPoint");
		NativeFieldInfoPtr_maleToiletController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "maleToiletController");
		NativeFieldInfoPtr_femaleToiletController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "femaleToiletController");
		NativeFieldInfoPtr_malePeeWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "malePeeWaitPoint");
		NativeFieldInfoPtr_maleKoshitsuWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "maleKoshitsuWaitPoint");
		NativeFieldInfoPtr_femaleKoshitsuWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "femaleKoshitsuWaitPoint");
		NativeFieldInfoPtr_maleWashWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "maleWashWaitPoint");
		NativeFieldInfoPtr_femaleWashWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "femaleWashWaitPoint");
		NativeFieldInfoPtr_malePeeAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "malePeeAudioSource");
		NativeFieldInfoPtr_peeTokenDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "peeTokenDict");
		NativeFieldInfoPtr_washMaleTokenDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "washMaleTokenDict");
		NativeFieldInfoPtr_washFemaleTokenDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "washFemaleTokenDict");
		NativeFieldInfoPtr_koshitsuMaleTokenDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "koshitsuMaleTokenDict");
		NativeFieldInfoPtr_koshitsuFemaleTokenDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "koshitsuFemaleTokenDict");
		NativeFieldInfoPtr_koshitsuMaleFoundPlayerInsideDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "koshitsuMaleFoundPlayerInsideDict");
		NativeFieldInfoPtr_koshitsuFemaleFoundPlayerInsideDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "koshitsuFemaleFoundPlayerInsideDict");
		NativeFieldInfoPtr__IsPlayerInOpenToilet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "<IsPlayerInOpenToilet>k__BackingField");
		NativeFieldInfoPtr_peeIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "peeIndexArray");
		NativeFieldInfoPtr_maleKoshitsuIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "maleKoshitsuIndexArray");
		NativeFieldInfoPtr_femaleKoshitsuIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, "femaleKoshitsuIndexArray");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ToiletManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665812);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ToiletManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665813);
		NativeMethodInfoPtr_get_IsPlayerInOpenToilet_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665814);
		NativeMethodInfoPtr_set_IsPlayerInOpenToilet_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665815);
		NativeMethodInfoPtr_GetPeeWaitPoint_Public_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665816);
		NativeMethodInfoPtr_GetWashWaitPoint_Public_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665817);
		NativeMethodInfoPtr_GetKoshitsuWaitPoint_Public_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665818);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665819);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665820);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665821);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665822);
		NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665823);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665824);
		NativeMethodInfoPtr_TryGetTokenWash_Public_Transform_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665825);
		NativeMethodInfoPtr_ReturnTokenWash_Public_Void_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665826);
		NativeMethodInfoPtr_TryGetTokenPee_Public_Transform_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665827);
		NativeMethodInfoPtr_ReturnTokenPee_Public_Void_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665828);
		NativeMethodInfoPtr_ReportToiletInPlayer_Public_Void_ToiletController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665829);
		NativeMethodInfoPtr_TryGetTokenKoshitsu_Public_ToiletController_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665830);
		NativeMethodInfoPtr_ReturnTokenKoshitsu_Public_Void_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665831);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToiletManager>.NativeClassPtr, 100665832);
	}

	public ToiletManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
