using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Master.Stage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.Scripts.Mission;

public class MissionManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TimeMissionNameSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConditionMissionNameSpace;

	private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionList;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSuccessMission_Public_Boolean_MMissionOverrideRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetMission_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string TimeMissionNameSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeMissionNameSpace, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeMissionNameSpace, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string ConditionMissionNameSpace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConditionMissionNameSpace, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConditionMissionNameSpace, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static MissionManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<MissionBase> MissionList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<MissionBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<StageType, List<MissionBase>> MissionDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, List<MissionBase>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71401, RefRangeEnd = 71402, XrefRangeStart = 71344, XrefRangeEnd = 71401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71421, RefRangeEnd = 71422, XrefRangeStart = 71402, XrefRangeEnd = 71421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSuccessMission([DefaultParameterValue(null)] MMissionOverrideRecord record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSuccessMission_Public_Boolean_MMissionOverrideRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71433, RefRangeEnd = 71434, XrefRangeStart = 71422, XrefRangeEnd = 71433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71443, RefRangeEnd = 71444, XrefRangeStart = 71434, XrefRangeEnd = 71443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 71452, RefRangeEnd = 71457, XrefRangeStart = 71444, XrefRangeEnd = 71452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetMission_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71457, XrefRangeEnd = 71469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionManager()
	{
		Il2CppClassPointerStore<MissionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Mission", "MissionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionManager>.NativeClassPtr);
		NativeFieldInfoPtr_TimeMissionNameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, "TimeMissionNameSpace");
		NativeFieldInfoPtr_ConditionMissionNameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, "ConditionMissionNameSpace");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_MissionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, "MissionList");
		NativeFieldInfoPtr_MissionDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, "MissionDict");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668495);
		NativeMethodInfoPtr_IsSuccessMission_Public_Boolean_MMissionOverrideRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668496);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668497);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668498);
		NativeMethodInfoPtr_ResetMission_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668499);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionManager>.NativeClassPtr, 100668500);
	}

	public MissionManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
