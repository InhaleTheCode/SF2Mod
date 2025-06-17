using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Stage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.Scripts.InGame;

public class TemporaryInGameState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsCollectDropItem;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsStopGameStateApplier;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsGameOver;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFirstLoadStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPlayingSomePerformance;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTimeStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeforeStageType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDownRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_LostExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_LostRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionCompleteThisGameSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionMaxRpBonus100ThisGameDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneMissionCompleteThisGame;

	private static readonly System.IntPtr NativeFieldInfoPtr_AchieveMissionCountByStageThisGameDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentEarnThisTimePerSecRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsNoAchieveMissionMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentMotionSpeed;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool IsCollectDropItem
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsCollectDropItem, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsCollectDropItem, &flag);
		}
	}

	public unsafe bool IsStopGameStateApplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsStopGameStateApplier);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsStopGameStateApplier)) = flag;
		}
	}

	public unsafe bool IsGameOver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGameOver);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGameOver)) = flag;
		}
	}

	public unsafe bool IsFirstLoadStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFirstLoadStage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFirstLoadStage)) = flag;
		}
	}

	public unsafe bool IsPlayingSomePerformance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayingSomePerformance);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayingSomePerformance)) = flag;
		}
	}

	public unsafe bool IsTimeStop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTimeStop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsTimeStop)) = flag;
		}
	}

	public unsafe StageType BeforeStageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeforeStageType);
			return *(StageType*)num;
		}
		set
		{
			*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeforeStageType)) = stageType;
		}
	}

	public unsafe bool IsDownRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDownRank);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDownRank)) = flag;
		}
	}

	public unsafe int LostExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostExp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostExp)) = num;
		}
	}

	public unsafe int LostRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostRp)) = num;
		}
	}

	public unsafe HashSet<int> MissionCompleteThisGameSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionCompleteThisGameSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionCompleteThisGameSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, int> MissionMaxRpBonus100ThisGameDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMaxRpBonus100ThisGameDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMaxRpBonus100ThisGameDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool DroneMissionCompleteThisGame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionCompleteThisGame);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionCompleteThisGame)) = flag;
		}
	}

	public unsafe Dictionary<StageType, int> AchieveMissionCountByStageThisGameDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchieveMissionCountByStageThisGameDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchieveMissionCountByStageThisGameDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float CurrentEarnThisTimePerSecRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentEarnThisTimePerSecRp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentEarnThisTimePerSecRp)) = num;
		}
	}

	public unsafe bool IsNoAchieveMissionMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNoAchieveMissionMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNoAchieveMissionMode)) = flag;
		}
	}

	public unsafe float CurrentMotionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMotionSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentMotionSpeed)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77910, RefRangeEnd = 77911, XrefRangeStart = 77893, XrefRangeEnd = 77910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TemporaryInGameState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TemporaryInGameState()
	{
		Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "TemporaryInGameState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr);
		NativeFieldInfoPtr_IsCollectDropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsCollectDropItem");
		NativeFieldInfoPtr_IsStopGameStateApplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsStopGameStateApplier");
		NativeFieldInfoPtr_IsGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsGameOver");
		NativeFieldInfoPtr_IsFirstLoadStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsFirstLoadStage");
		NativeFieldInfoPtr_IsPlayingSomePerformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsPlayingSomePerformance");
		NativeFieldInfoPtr_IsTimeStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsTimeStop");
		NativeFieldInfoPtr_BeforeStageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "BeforeStageType");
		NativeFieldInfoPtr_IsDownRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsDownRank");
		NativeFieldInfoPtr_LostExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "LostExp");
		NativeFieldInfoPtr_LostRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "LostRp");
		NativeFieldInfoPtr_MissionCompleteThisGameSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "MissionCompleteThisGameSet");
		NativeFieldInfoPtr_MissionMaxRpBonus100ThisGameDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "MissionMaxRpBonus100ThisGameDict");
		NativeFieldInfoPtr_DroneMissionCompleteThisGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "DroneMissionCompleteThisGame");
		NativeFieldInfoPtr_AchieveMissionCountByStageThisGameDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "AchieveMissionCountByStageThisGameDict");
		NativeFieldInfoPtr_CurrentEarnThisTimePerSecRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "CurrentEarnThisTimePerSecRp");
		NativeFieldInfoPtr_IsNoAchieveMissionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "IsNoAchieveMissionMode");
		NativeFieldInfoPtr_CurrentMotionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, "CurrentMotionSpeed");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TemporaryInGameState>.NativeClassPtr, 100669029);
	}

	public TemporaryInGameState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
