using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.Scripts.InGame;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Mission;

public class MMissionOverrideRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_MEMO;

	private static readonly IntPtr NativeFieldInfoPtr_OriginalRecord;

	private static readonly IntPtr NativeFieldInfoPtr_RewardRankPoint;

	private static readonly IntPtr NativeFieldInfoPtr_ReleaseRank;

	private static readonly IntPtr NativeFieldInfoPtr_AddSatisfyScale;

	private static readonly IntPtr NativeFieldInfoPtr_AddSatisfyScalePassiveContinue;

	private static readonly IntPtr NativeFieldInfoPtr_FloatParam;

	private static readonly IntPtr NativeFieldInfoPtr_AreaType;

	private static readonly IntPtr NativeFieldInfoPtr_AreaType2;

	private static readonly IntPtr NativeFieldInfoPtr_Level;

	private static readonly IntPtr NativeFieldInfoPtr_Trial;

	private static readonly IntPtr NativeFieldInfoPtr_OverrideRpPerSecScale;

	private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__StageType_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StageType_Public_get_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StageType_Public_set_Void_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RpPerSecScale_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetMissionName_Public_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string MEMO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MEMO);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MEMO), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe MMissionRecord OriginalRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRecord);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MMissionRecord>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OriginalRecord), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int RewardRankPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RewardRankPoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RewardRankPoint)) = num;
		}
	}

	public unsafe int ReleaseRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseRank)) = num;
		}
	}

	public unsafe float AddSatisfyScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSatisfyScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSatisfyScale)) = num;
		}
	}

	public unsafe float AddSatisfyScalePassiveContinue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSatisfyScalePassiveContinue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddSatisfyScalePassiveContinue)) = num;
		}
	}

	public unsafe float FloatParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FloatParam);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FloatParam)) = num;
		}
	}

	public unsafe MissionAreaManager.Area AreaType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaType);
			return *(MissionAreaManager.Area*)num;
		}
		set
		{
			*(MissionAreaManager.Area*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaType)) = area;
		}
	}

	public unsafe MissionAreaManager.Area AreaType2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaType2);
			return *(MissionAreaManager.Area*)num;
		}
		set
		{
			*(MissionAreaManager.Area*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AreaType2)) = area;
		}
	}

	public unsafe int Level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level)) = num;
		}
	}

	public unsafe bool Trial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trial);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Trial)) = flag;
		}
	}

	public unsafe float OverrideRpPerSecScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideRpPerSecScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OverrideRpPerSecScale)) = num;
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

	public unsafe StageType _StageType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageType_k__BackingField);
			return *(StageType*)num;
		}
		set
		{
			*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageType_k__BackingField)) = stageType;
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
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
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
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe StageType StageType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StageType_Public_get_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(StageType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StageType_Public_set_Void_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float RpPerSecScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RpPerSecScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 68130, RefRangeEnd = 68133, XrefRangeStart = 68094, XrefRangeEnd = 68130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetMissionName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe void Initialize([DefaultParameterValue(null)] int id, [DefaultParameterValue(null)] StageType stageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&id);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &stageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Int32_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68133, XrefRangeEnd = 68134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MMissionOverrideRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MMissionOverrideRecord()
	{
		Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Mission", "MMissionOverrideRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr);
		NativeFieldInfoPtr_MEMO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "MEMO");
		NativeFieldInfoPtr_OriginalRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "OriginalRecord");
		NativeFieldInfoPtr_RewardRankPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "RewardRankPoint");
		NativeFieldInfoPtr_ReleaseRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "ReleaseRank");
		NativeFieldInfoPtr_AddSatisfyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "AddSatisfyScale");
		NativeFieldInfoPtr_AddSatisfyScalePassiveContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "AddSatisfyScalePassiveContinue");
		NativeFieldInfoPtr_FloatParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "FloatParam");
		NativeFieldInfoPtr_AreaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "AreaType");
		NativeFieldInfoPtr_AreaType2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "AreaType2");
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_Trial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "Trial");
		NativeFieldInfoPtr_OverrideRpPerSecScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "OverrideRpPerSecScale");
		NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "<Id>k__BackingField");
		NativeFieldInfoPtr__StageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, "<StageType>k__BackingField");
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100667999);
		NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668000);
		NativeMethodInfoPtr_get_StageType_Public_get_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668001);
		NativeMethodInfoPtr_set_StageType_Public_set_Void_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668002);
		NativeMethodInfoPtr_get_RpPerSecScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668003);
		NativeMethodInfoPtr_GetMissionName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668004);
		NativeMethodInfoPtr_Initialize_Public_Void_Int32_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668005);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionOverrideRecord>.NativeClassPtr, 100668006);
	}

	public MMissionOverrideRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
