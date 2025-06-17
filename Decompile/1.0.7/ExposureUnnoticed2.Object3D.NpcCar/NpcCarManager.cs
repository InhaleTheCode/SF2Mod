using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Scripts.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NpcCar;

public class NpcCarManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_spawnPoints;

	private static readonly IntPtr NativeFieldInfoPtr_carPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_destroyDistance;

	private static readonly IntPtr NativeFieldInfoPtr_speedKmPerHour;

	private static readonly IntPtr NativeFieldInfoPtr_intervalMin;

	private static readonly IntPtr NativeFieldInfoPtr_intervalMax;

	private static readonly IntPtr NativeFieldInfoPtr_MaxCarNum;

	private static readonly IntPtr NativeFieldInfoPtr_intervalMinNight;

	private static readonly IntPtr NativeFieldInfoPtr_intervalMaxNight;

	private static readonly IntPtr NativeFieldInfoPtr_MaxCarNumNight;

	private static readonly IntPtr NativeFieldInfoPtr_CarList;

	private static readonly IntPtr NativeFieldInfoPtr_spawnInterval;

	private static readonly IntPtr NativeFieldInfoPtr_spawnIntervalNight;

	private static readonly IntPtr NativeFieldInfoPtr_currentCarNum;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_NpcCarManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_NpcCarManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_currentMax_Private_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_currentIntervalTime_Private_get_IntervalTime_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__24_0_Private_Void_NpcCarController_0;

	public unsafe static NpcCarManager _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<NpcCarManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Transform> spawnPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject carPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float destroyDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyDistance)) = num;
		}
	}

	public unsafe float speedKmPerHour
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedKmPerHour);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speedKmPerHour)) = num;
		}
	}

	public unsafe float intervalMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMin)) = num;
		}
	}

	public unsafe float intervalMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMax)) = num;
		}
	}

	public unsafe int MaxCarNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarNum)) = num;
		}
	}

	public unsafe float intervalMinNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMinNight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMinNight)) = num;
		}
	}

	public unsafe float intervalMaxNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMaxNight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalMaxNight)) = num;
		}
	}

	public unsafe int MaxCarNumNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarNumNight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxCarNumNight)) = num;
		}
	}

	public unsafe List<NpcCarController> CarList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<NpcCarController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CarList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IntervalTime spawnInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnInterval);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntervalTime>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnInterval), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe IntervalTime spawnIntervalNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnIntervalNight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntervalTime>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spawnIntervalNight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentCarNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCarNum)) = num;
		}
	}

	public unsafe static NpcCarManager Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60247, XrefRangeEnd = 60249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_NpcCarManager_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcCarManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60249, XrefRangeEnd = 60252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_NpcCarManager_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int currentMax
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60252, XrefRangeEnd = 60254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentMax_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe IntervalTime currentIntervalTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60254, XrefRangeEnd = 60256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_currentIntervalTime_Private_get_IntervalTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IntervalTime>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60256, XrefRangeEnd = 60262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60262, XrefRangeEnd = 60263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60307, RefRangeEnd = 60308, XrefRangeStart = 60263, XrefRangeEnd = 60307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60308, XrefRangeEnd = 60317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcCarManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60317, XrefRangeEnd = 60321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnUpdate_b__24_0([DefaultParameterValue(null)] NpcCarController car)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(car);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnUpdate_b__24_0_Private_Void_NpcCarController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcCarManager()
	{
		Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NpcCar", "NpcCarManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_spawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "spawnPoints");
		NativeFieldInfoPtr_carPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "carPrefab");
		NativeFieldInfoPtr_destroyDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "destroyDistance");
		NativeFieldInfoPtr_speedKmPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "speedKmPerHour");
		NativeFieldInfoPtr_intervalMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "intervalMin");
		NativeFieldInfoPtr_intervalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "intervalMax");
		NativeFieldInfoPtr_MaxCarNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "MaxCarNum");
		NativeFieldInfoPtr_intervalMinNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "intervalMinNight");
		NativeFieldInfoPtr_intervalMaxNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "intervalMaxNight");
		NativeFieldInfoPtr_MaxCarNumNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "MaxCarNumNight");
		NativeFieldInfoPtr_CarList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "CarList");
		NativeFieldInfoPtr_spawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "spawnInterval");
		NativeFieldInfoPtr_spawnIntervalNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "spawnIntervalNight");
		NativeFieldInfoPtr_currentCarNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, "currentCarNum");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_NpcCarManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667289);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_NpcCarManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667290);
		NativeMethodInfoPtr_get_currentMax_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667291);
		NativeMethodInfoPtr_get_currentIntervalTime_Private_get_IntervalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667292);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667293);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667294);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667295);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667296);
		NativeMethodInfoPtr__OnUpdate_b__24_0_Private_Void_NpcCarController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcCarManager>.NativeClassPtr, 100667297);
	}

	public NpcCarManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
