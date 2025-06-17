using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Stage;

public class MStageRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_StageType;

	private static readonly IntPtr NativeFieldInfoPtr_SceneName;

	private static readonly IntPtr NativeFieldInfoPtr_StageNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_IsGoalTarget;

	private static readonly IntPtr NativeFieldInfoPtr_NpcNum;

	private static readonly IntPtr NativeFieldInfoPtr_NpcNumNight;

	private static readonly IntPtr NativeFieldInfoPtr_NpcNumRandom;

	private static readonly IntPtr NativeFieldInfoPtr_NpcNumRandomInitExist;

	private static readonly IntPtr NativeFieldInfoPtr_FearLevelPenalty;

	private static readonly IntPtr NativeFieldInfoPtr_StageRpBonus100;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultLightBareyasusaScale100;

	private static readonly IntPtr NativeFieldInfoPtr_StartSightScaleReduceDist;

	private static readonly IntPtr NativeFieldInfoPtr_IsProhibitedWaitArea;

	private static readonly IntPtr NativeFieldInfoPtr_EnterRankLimit;

	private static readonly IntPtr NativeFieldInfoPtr_IsUseDrone;

	private static readonly IntPtr NativeFieldInfoPtr_DroneMissionRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_IsNoRandomStartDroneMission;

	private static readonly IntPtr NativeFieldInfoPtr_IsNightSpermDecal;

	private static readonly IntPtr NativeFieldInfoPtr_NpcTalkNumDaytime;

	private static readonly IntPtr NativeFieldInfoPtr_NpcTalkNumNight;

	private static readonly IntPtr NativeFieldInfoPtr_NpcFixSitNumDaytime;

	private static readonly IntPtr NativeFieldInfoPtr_NpcFixSitNumNight;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StageType StageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageType);
			return *(StageType*)num;
		}
		set
		{
			*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageType)) = stageType;
		}
	}

	public unsafe string SceneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SceneName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string StageNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageNameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsGoalTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGoalTarget);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGoalTarget)) = flag;
		}
	}

	public unsafe int NpcNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNum)) = num;
		}
	}

	public unsafe int NpcNumNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumNight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumNight)) = num;
		}
	}

	public unsafe bool NpcNumRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumRandom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumRandom)) = flag;
		}
	}

	public unsafe bool NpcNumRandomInitExist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumRandomInitExist);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumRandomInitExist)) = flag;
		}
	}

	public unsafe int FearLevelPenalty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FearLevelPenalty);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FearLevelPenalty)) = num;
		}
	}

	public unsafe int StageRpBonus100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageRpBonus100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageRpBonus100)) = num;
		}
	}

	public unsafe int DefaultLightBareyasusaScale100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultLightBareyasusaScale100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultLightBareyasusaScale100)) = num;
		}
	}

	public unsafe float StartSightScaleReduceDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSightScaleReduceDist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StartSightScaleReduceDist)) = num;
		}
	}

	public unsafe bool IsProhibitedWaitArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsProhibitedWaitArea);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsProhibitedWaitArea)) = flag;
		}
	}

	public unsafe int EnterRankLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterRankLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnterRankLimit)) = num;
		}
	}

	public unsafe bool IsUseDrone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseDrone);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseDrone)) = flag;
		}
	}

	public unsafe float DroneMissionRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionRpBonus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionRpBonus)) = num;
		}
	}

	public unsafe bool IsNoRandomStartDroneMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNoRandomStartDroneMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNoRandomStartDroneMission)) = flag;
		}
	}

	public unsafe bool IsNightSpermDecal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNightSpermDecal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNightSpermDecal)) = flag;
		}
	}

	public unsafe int NpcTalkNumDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTalkNumDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTalkNumDaytime)) = num;
		}
	}

	public unsafe int NpcTalkNumNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTalkNumNight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcTalkNumNight)) = num;
		}
	}

	public unsafe int NpcFixSitNumDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcFixSitNumDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcFixSitNumDaytime)) = num;
		}
	}

	public unsafe int NpcFixSitNumNight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcFixSitNumNight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcFixSitNumNight)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67603, XrefRangeEnd = 67604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MStageRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MStageRecord()
	{
		Il2CppClassPointerStore<MStageRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Stage", "MStageRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr);
		NativeFieldInfoPtr_StageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "StageType");
		NativeFieldInfoPtr_SceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "SceneName");
		NativeFieldInfoPtr_StageNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "StageNameKey");
		NativeFieldInfoPtr_IsGoalTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "IsGoalTarget");
		NativeFieldInfoPtr_NpcNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcNum");
		NativeFieldInfoPtr_NpcNumNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcNumNight");
		NativeFieldInfoPtr_NpcNumRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcNumRandom");
		NativeFieldInfoPtr_NpcNumRandomInitExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcNumRandomInitExist");
		NativeFieldInfoPtr_FearLevelPenalty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "FearLevelPenalty");
		NativeFieldInfoPtr_StageRpBonus100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "StageRpBonus100");
		NativeFieldInfoPtr_DefaultLightBareyasusaScale100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "DefaultLightBareyasusaScale100");
		NativeFieldInfoPtr_StartSightScaleReduceDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "StartSightScaleReduceDist");
		NativeFieldInfoPtr_IsProhibitedWaitArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "IsProhibitedWaitArea");
		NativeFieldInfoPtr_EnterRankLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "EnterRankLimit");
		NativeFieldInfoPtr_IsUseDrone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "IsUseDrone");
		NativeFieldInfoPtr_DroneMissionRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "DroneMissionRpBonus");
		NativeFieldInfoPtr_IsNoRandomStartDroneMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "IsNoRandomStartDroneMission");
		NativeFieldInfoPtr_IsNightSpermDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "IsNightSpermDecal");
		NativeFieldInfoPtr_NpcTalkNumDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcTalkNumDaytime");
		NativeFieldInfoPtr_NpcTalkNumNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcTalkNumNight");
		NativeFieldInfoPtr_NpcFixSitNumDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcFixSitNumDaytime");
		NativeFieldInfoPtr_NpcFixSitNumNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, "NpcFixSitNumNight");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStageRecord>.NativeClassPtr, 100667935);
	}

	public MStageRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
