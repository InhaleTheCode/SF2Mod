using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.DroneMission;

public class RDroneMission : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly IntPtr NativeFieldInfoPtr_MissionClassName;

	private static readonly IntPtr NativeFieldInfoPtr_DescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_StartConditionDescriptionKey1;

	private static readonly IntPtr NativeFieldInfoPtr_StartConditionDescriptionKey2;

	private static readonly IntPtr NativeFieldInfoPtr_StartConditionDescriptionKey3;

	private static readonly IntPtr NativeFieldInfoPtr_ClearConditionDescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_RewardRp;

	private static readonly IntPtr NativeFieldInfoPtr_ReleaseLevel;

	private static readonly IntPtr NativeFieldInfoPtr_FadePanelSecond;

	private static readonly IntPtr NativeFieldInfoPtr_IsPlayerRandomStart;

	private static readonly IntPtr NativeFieldInfoPtr_IsDisplayDirect;

	private static readonly IntPtr NativeFieldInfoPtr_IsVibe;

	private static readonly IntPtr NativeFieldInfoPtr_IsDropVibeRemocon;

	private static readonly IntPtr NativeFieldInfoPtr_GoalExternalMap;

	private static readonly IntPtr NativeFieldInfoPtr_StartExternalMap;

	private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string NameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string MissionClassName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionClassName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionClassName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string DescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string StartConditionDescriptionKey1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey1);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey1), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string StartConditionDescriptionKey2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey2);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey2), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string StartConditionDescriptionKey3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey3);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartConditionDescriptionKey3), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ClearConditionDescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearConditionDescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearConditionDescriptionKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int RewardRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RewardRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RewardRp)) = num;
		}
	}

	public unsafe int ReleaseLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseLevel)) = num;
		}
	}

	public unsafe float FadePanelSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadePanelSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadePanelSecond)) = num;
		}
	}

	public unsafe bool IsPlayerRandomStart
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayerRandomStart);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayerRandomStart)) = flag;
		}
	}

	public unsafe bool IsDisplayDirect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDisplayDirect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDisplayDirect)) = flag;
		}
	}

	public unsafe bool IsVibe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsVibe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsVibe)) = flag;
		}
	}

	public unsafe bool IsDropVibeRemocon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDropVibeRemocon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDropVibeRemocon)) = flag;
		}
	}

	public unsafe GoalSelectType GoalExternalMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoalExternalMap);
			return *(GoalSelectType*)num;
		}
		set
		{
			*(GoalSelectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoalExternalMap)) = goalSelectType;
		}
	}

	public unsafe GoalSelectType StartExternalMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartExternalMap);
			return *(GoalSelectType*)num;
		}
		set
		{
			*(GoalSelectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartExternalMap)) = goalSelectType;
		}
	}

	public unsafe int _Id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField)) = num;
		}
	}

	public unsafe int Id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68477, XrefRangeEnd = 68478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RDroneMission()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RDroneMission()
	{
		Il2CppClassPointerStore<RDroneMission>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.DroneMission", "RDroneMission");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr);
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_MissionClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "MissionClassName");
		NativeFieldInfoPtr_DescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "DescriptionKey");
		NativeFieldInfoPtr_StartConditionDescriptionKey1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "StartConditionDescriptionKey1");
		NativeFieldInfoPtr_StartConditionDescriptionKey2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "StartConditionDescriptionKey2");
		NativeFieldInfoPtr_StartConditionDescriptionKey3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "StartConditionDescriptionKey3");
		NativeFieldInfoPtr_ClearConditionDescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "ClearConditionDescriptionKey");
		NativeFieldInfoPtr_RewardRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "RewardRp");
		NativeFieldInfoPtr_ReleaseLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "ReleaseLevel");
		NativeFieldInfoPtr_FadePanelSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "FadePanelSecond");
		NativeFieldInfoPtr_IsPlayerRandomStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "IsPlayerRandomStart");
		NativeFieldInfoPtr_IsDisplayDirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "IsDisplayDirect");
		NativeFieldInfoPtr_IsVibe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "IsVibe");
		NativeFieldInfoPtr_IsDropVibeRemocon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "IsDropVibeRemocon");
		NativeFieldInfoPtr_GoalExternalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "GoalExternalMap");
		NativeFieldInfoPtr_StartExternalMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "StartExternalMap");
		NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, "<Id>k__BackingField");
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, 100668056);
		NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, 100668057);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RDroneMission>.NativeClassPtr, 100668058);
	}

	public RDroneMission(IntPtr pointer)
		: base(pointer)
	{
	}
}
