using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Costume;
using ExposureUnnoticed2.Master.Hair;
using ExposureUnnoticed2.Master.Item;
using ExposureUnnoticed2.Master.Skill;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu;
using ExposureUnnoticed2.ObjectUI.InventoryPanel;
using ExposureUnnoticed2.ObjectUI.SelectDifficultyPanel;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class GameStateData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentStageType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropDataDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReserveDropList;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlowRemainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_DifficultType;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReleaseFastTravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcSaveDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReleasedInfoRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmedReleasedInfoRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingShortcutModelIndexCommon;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingShortcutModelIndexSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingShortcutModelIndexSkill3;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingShortcutModelIndexSkill4;

	private static readonly System.IntPtr NativeFieldInfoPtr_AchievementReceiveSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_UsingWasherIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionSpeedScaleIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_WalkSpeedScaleIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayPartsOptionDataDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConfirmedReinforceRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDroneNeedCharge;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActiveDroneMissionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActiveDroneProgress;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneManagerDropList;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneMissionAchieveCountDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneMissionAchieveCountPerStageDictDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneMissionMaxRpBonus100PerStageDictDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_RandomMissionClearNumIdDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionAchieveCountDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContinueMissionAchieveCountDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionSatisfyDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_ContinueMissionSatisfyDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionEarnRpDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionMaxRpBonus100Dict;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneMissionEarnRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalPlayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalExposeTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisGameOverCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisEcstasyCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisMaxEarnRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalEarnRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalLostRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalLostExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisTotalUseRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisMissionAchiveCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisMaxRpBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisMaxNudeMoveDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr_StatistisMaxEarnRpByOneDay;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMental;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMoisture;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerAddMoisture;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFear;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRemainBodyPaintTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCurrentClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCurrentHadObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCurrentHoldClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerIsAttachHandcuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerIsAttachMapHandcuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr_AttachedHandcuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerHandcuffTimerRemainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerHandcuffTimerSetTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerVibrationModeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerLife;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerMaxLife;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCurrentClothesAState;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCurrentClothesBState;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerPassiveSkillActiveDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSexualityType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveFutanari;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveInvisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveInvisibleReusable;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveBodyPaintReusable;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExposeExp;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentEarnThisTimeRp;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_MAdultGoodsDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCostumeDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCosplayPartsDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdultGoodsReinforceEffectDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayPartsReinforceEffectDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostumeReinforceEffectDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_HairTypeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadoutDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_LoadoutCustomizeDatas;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFace0Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFace1Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFace2Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFace3Id;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFaceIkuId;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerFaceIkuAfterId;

	private static readonly System.IntPtr NativeFieldInfoPtr_VibeRemoconLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_PistonMachineModeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_DroneLevel;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StageType CurrentStageType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentStageType);
			return *(StageType*)num;
		}
		set
		{
			*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentStageType)) = stageType;
		}
	}

	public unsafe Dictionary<DroppedItemManager.DropItemType, DroppedItemManager.DropData> DropDataDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropDataDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DroppedItemManager.DropItemType, DroppedItemManager.DropData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropDataDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDaytime);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDaytime)) = flag;
		}
	}

	public unsafe List<DroppedItemManager.DropData> ReserveDropList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReserveDropList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DroppedItemManager.DropData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReserveDropList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float SlowRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlowRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlowRemainTime)) = num;
		}
	}

	public unsafe DifficultType DifficultType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DifficultType);
			return *(DifficultType*)num;
		}
		set
		{
			*(DifficultType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DifficultType)) = difficultType;
		}
	}

	public unsafe List<int> ReleaseFastTravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseFastTravel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseFastTravel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<NpcSaveData> NpcSaveDataList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcSaveDataList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NpcSaveData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcSaveDataList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ReleasedInfoRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleasedInfoRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleasedInfoRank)) = num;
		}
	}

	public unsafe int ConfirmedReleasedInfoRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfirmedReleasedInfoRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfirmedReleasedInfoRank)) = num;
		}
	}

	public unsafe int RingShortcutModelIndexCommon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexCommon);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexCommon)) = num;
		}
	}

	public unsafe int RingShortcutModelIndexSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill)) = num;
		}
	}

	public unsafe int RingShortcutModelIndexSkill3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill3);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill3)) = num;
		}
	}

	public unsafe int RingShortcutModelIndexSkill4
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill4);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingShortcutModelIndexSkill4)) = num;
		}
	}

	public unsafe HashSet<int> AchievementReceiveSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementReceiveSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementReceiveSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int UsingWasherIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsingWasherIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UsingWasherIndex)) = num;
		}
	}

	public unsafe int MotionSpeedScaleIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionSpeedScaleIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionSpeedScaleIndex)) = num;
		}
	}

	public unsafe int WalkSpeedScaleIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkSpeedScaleIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WalkSpeedScaleIndex)) = num;
		}
	}

	public unsafe Dictionary<int, CosplayPartsOptionData> CosplayPartsOptionDataDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsOptionDataDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CosplayPartsOptionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsOptionDataDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ConfirmedReinforceRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfirmedReinforceRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConfirmedReinforceRank)) = num;
		}
	}

	public unsafe bool IsDroneNeedCharge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDroneNeedCharge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDroneNeedCharge)) = flag;
		}
	}

	public unsafe int ActiveDroneMissionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDroneMissionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDroneMissionId)) = num;
		}
	}

	public unsafe float ActiveDroneProgress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDroneProgress);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDroneProgress)) = num;
		}
	}

	public unsafe List<DroppedItemManager.DropItemType> DroneManagerDropList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneManagerDropList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DroppedItemManager.DropItemType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneManagerDropList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, int> DroneMissionAchieveCountDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionAchieveCountDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionAchieveCountDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<StageType, Dictionary<int, int>> DroneMissionAchieveCountPerStageDictDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionAchieveCountPerStageDictDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, Dictionary<int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionAchieveCountPerStageDictDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<StageType, Dictionary<int, int>> DroneMissionMaxRpBonus100PerStageDictDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionMaxRpBonus100PerStageDictDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, Dictionary<int, int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionMaxRpBonus100PerStageDictDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<StageType, int> RandomMissionClearNumIdDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomMissionClearNumIdDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RandomMissionClearNumIdDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, int> MissionAchieveCountDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionAchieveCountDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionAchieveCountDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, int> ContinueMissionAchieveCountDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContinueMissionAchieveCountDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContinueMissionAchieveCountDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, float> MissionSatisfyDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionSatisfyDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionSatisfyDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, float> ContinueMissionSatisfyDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContinueMissionSatisfyDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ContinueMissionSatisfyDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, float> MissionEarnRpDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionEarnRpDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, float>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionEarnRpDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, int> MissionMaxRpBonus100Dict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMaxRpBonus100Dict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMaxRpBonus100Dict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float DroneMissionEarnRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionEarnRp);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionEarnRp)) = num;
		}
	}

	public unsafe uint StatistisTotalPlayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalPlayTime);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalPlayTime)) = num;
		}
	}

	public unsafe uint StatistisTotalExposeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalExposeTime);
			return *(uint*)num;
		}
		set
		{
			*(uint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalExposeTime)) = num;
		}
	}

	public unsafe int StatistisGameOverCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisGameOverCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisGameOverCount)) = num;
		}
	}

	public unsafe int StatistisEcstasyCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisEcstasyCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisEcstasyCount)) = num;
		}
	}

	public unsafe int StatistisMaxEarnRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxEarnRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxEarnRp)) = num;
		}
	}

	public unsafe double StatistisTotalEarnRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalEarnRp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalEarnRp)) = num;
		}
	}

	public unsafe double StatistisTotalLostRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalLostRp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalLostRp)) = num;
		}
	}

	public unsafe double StatistisTotalLostExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalLostExp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalLostExp)) = num;
		}
	}

	public unsafe double StatistisTotalUseRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalUseRp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisTotalUseRp)) = num;
		}
	}

	public unsafe int StatistisMissionAchiveCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMissionAchiveCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMissionAchiveCount)) = num;
		}
	}

	public unsafe float StatistisMaxRpBoost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxRpBoost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxRpBoost)) = num;
		}
	}

	public unsafe float StatistisMaxNudeMoveDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxNudeMoveDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxNudeMoveDistance)) = num;
		}
	}

	public unsafe int StatistisMaxEarnRpByOneDay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxEarnRpByOneDay);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StatistisMaxEarnRpByOneDay)) = num;
		}
	}

	public unsafe float PlayerEcstasy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerEcstasy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerEcstasy)) = num;
		}
	}

	public unsafe float PlayerMental
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMental);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMental)) = num;
		}
	}

	public unsafe float PlayerMoisture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMoisture);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMoisture)) = num;
		}
	}

	public unsafe float PlayerAddMoisture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerAddMoisture);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerAddMoisture)) = num;
		}
	}

	public unsafe float PlayerFear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFear);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFear)) = num;
		}
	}

	public unsafe float PlayerRemainBodyPaintTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRemainBodyPaintTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRemainBodyPaintTime)) = num;
		}
	}

	public unsafe Vector3 PlayerPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPosition)) = vector;
		}
	}

	public unsafe Quaternion PlayerRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRotation)) = quaternion;
		}
	}

	public unsafe ClothesType PlayerCurrentClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothes);
			return *(ClothesType*)num;
		}
		set
		{
			*(ClothesType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothes)) = clothesType;
		}
	}

	public unsafe PlayerStateModel.HadObjectType PlayerCurrentHadObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentHadObject);
			return *(PlayerStateModel.HadObjectType*)num;
		}
		set
		{
			*(PlayerStateModel.HadObjectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentHadObject)) = hadObjectType;
		}
	}

	public unsafe ClothesType PlayerCurrentHoldClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentHoldClothes);
			return *(ClothesType*)num;
		}
		set
		{
			*(ClothesType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentHoldClothes)) = clothesType;
		}
	}

	public unsafe bool PlayerIsAttachHandcuffs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerIsAttachHandcuffs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerIsAttachHandcuffs)) = flag;
		}
	}

	public unsafe bool PlayerIsAttachMapHandcuffs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerIsAttachMapHandcuffs);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerIsAttachMapHandcuffs)) = flag;
		}
	}

	public unsafe MAdultGoodsType AttachedHandcuffType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachedHandcuffType);
			return *(MAdultGoodsType*)num;
		}
		set
		{
			*(MAdultGoodsType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachedHandcuffType)) = mAdultGoodsType;
		}
	}

	public unsafe float PlayerHandcuffTimerRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerHandcuffTimerRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerHandcuffTimerRemainTime)) = num;
		}
	}

	public unsafe int PlayerHandcuffTimerSetTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerHandcuffTimerSetTime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerHandcuffTimerSetTime)) = num;
		}
	}

	public unsafe VibrationModeType PlayerVibrationModeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerVibrationModeType);
			return *(VibrationModeType*)num;
		}
		set
		{
			*(VibrationModeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerVibrationModeType)) = vibrationModeType;
		}
	}

	public unsafe int PlayerLife
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLife);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerLife)) = num;
		}
	}

	public unsafe int PlayerMaxLife
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMaxLife);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerMaxLife)) = num;
		}
	}

	public unsafe PlayerStateModel.ClothesState PlayerCurrentClothesAState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothesAState);
			return *(PlayerStateModel.ClothesState*)num;
		}
		set
		{
			*(PlayerStateModel.ClothesState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothesAState)) = clothesState;
		}
	}

	public unsafe PlayerStateModel.ClothesState PlayerCurrentClothesBState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothesBState);
			return *(PlayerStateModel.ClothesState*)num;
		}
		set
		{
			*(PlayerStateModel.ClothesState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCurrentClothesBState)) = clothesState;
		}
	}

	public unsafe Dictionary<SkillType, bool> PlayerPassiveSkillActiveDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPassiveSkillActiveDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SkillType, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerPassiveSkillActiveDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerStateModel.SexualityType CurrentSexualityType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSexualityType);
			return *(PlayerStateModel.SexualityType*)num;
		}
		set
		{
			*(PlayerStateModel.SexualityType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentSexualityType)) = sexualityType;
		}
	}

	public unsafe bool IsActiveFutanari
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveFutanari);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveFutanari)) = flag;
		}
	}

	public unsafe bool IsActiveInvisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInvisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInvisible)) = flag;
		}
	}

	public unsafe bool IsActiveInvisibleReusable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInvisibleReusable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInvisibleReusable)) = flag;
		}
	}

	public unsafe bool IsActiveBodyPaintReusable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveBodyPaintReusable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveBodyPaintReusable)) = flag;
		}
	}

	public unsafe double CurrentRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRp)) = num;
		}
	}

	public unsafe int ExposeExp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeExp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeExp)) = num;
		}
	}

	public unsafe double CurrentEarnThisTimeRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentEarnThisTimeRp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentEarnThisTimeRp)) = num;
		}
	}

	public unsafe Dictionary<SkillType, int> SkillLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillLevel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SkillType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillLevel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<ClothesType, bool> ClothesDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ClothesType, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<MAdultGoodsType, bool> MAdultGoodsDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAdultGoodsDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<MAdultGoodsType, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAdultGoodsDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<CostumeType, bool> PlayerCostumeDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCostumeDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CostumeType, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCostumeDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<ItemType, int> ItemDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ItemType, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, bool> PlayerCosplayPartsDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCosplayPartsDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerCosplayPartsDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<MAdultGoodsType, Il2CppStructArray<int>> AdultGoodsReinforceEffectDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsReinforceEffectDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<MAdultGoodsType, Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsReinforceEffectDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, Il2CppStructArray<int>> CosplayPartsReinforceEffectDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsReinforceEffectDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsReinforceEffectDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<CostumeType, Il2CppStructArray<int>> CostumeReinforceEffectDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeReinforceEffectDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CostumeType, Il2CppStructArray<int>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeReinforceEffectDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<HairType> HairTypeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairTypeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HairType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairTypeList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<LoadoutData> LoadoutDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadoutDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoadoutData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadoutDatas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<LoadoutCustomizeData> LoadoutCustomizeDatas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadoutCustomizeDatas);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoadoutCustomizeData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LoadoutCustomizeDatas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int PlayerFace0Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace0Id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace0Id)) = num;
		}
	}

	public unsafe int PlayerFace1Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace1Id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace1Id)) = num;
		}
	}

	public unsafe int PlayerFace2Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace2Id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace2Id)) = num;
		}
	}

	public unsafe int PlayerFace3Id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace3Id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFace3Id)) = num;
		}
	}

	public unsafe int PlayerFaceIkuId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFaceIkuId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFaceIkuId)) = num;
		}
	}

	public unsafe int PlayerFaceIkuAfterId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFaceIkuAfterId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerFaceIkuAfterId)) = num;
		}
	}

	public unsafe int VibeRemoconLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconLevel)) = num;
		}
	}

	public unsafe int PistonMachineModeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PistonMachineModeType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PistonMachineModeType)) = num;
		}
	}

	public unsafe int DroneLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneLevel)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73497, RefRangeEnd = 73498, XrefRangeStart = 73282, XrefRangeEnd = 73497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameStateData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStateData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameStateData()
	{
		Il2CppClassPointerStore<GameStateData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "GameStateData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStateData>.NativeClassPtr);
		NativeFieldInfoPtr_CurrentStageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CurrentStageType");
		NativeFieldInfoPtr_DropDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DropDataDict");
		NativeFieldInfoPtr_IsDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsDaytime");
		NativeFieldInfoPtr_ReserveDropList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ReserveDropList");
		NativeFieldInfoPtr_SlowRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "SlowRemainTime");
		NativeFieldInfoPtr_DifficultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DifficultType");
		NativeFieldInfoPtr_ReleaseFastTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ReleaseFastTravel");
		NativeFieldInfoPtr_NpcSaveDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "NpcSaveDataList");
		NativeFieldInfoPtr_ReleasedInfoRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ReleasedInfoRank");
		NativeFieldInfoPtr_ConfirmedReleasedInfoRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ConfirmedReleasedInfoRank");
		NativeFieldInfoPtr_RingShortcutModelIndexCommon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "RingShortcutModelIndexCommon");
		NativeFieldInfoPtr_RingShortcutModelIndexSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "RingShortcutModelIndexSkill");
		NativeFieldInfoPtr_RingShortcutModelIndexSkill3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "RingShortcutModelIndexSkill3");
		NativeFieldInfoPtr_RingShortcutModelIndexSkill4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "RingShortcutModelIndexSkill4");
		NativeFieldInfoPtr_AchievementReceiveSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "AchievementReceiveSet");
		NativeFieldInfoPtr_UsingWasherIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "UsingWasherIndex");
		NativeFieldInfoPtr_MotionSpeedScaleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MotionSpeedScaleIndex");
		NativeFieldInfoPtr_WalkSpeedScaleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "WalkSpeedScaleIndex");
		NativeFieldInfoPtr_CosplayPartsOptionDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CosplayPartsOptionDataDict");
		NativeFieldInfoPtr_ConfirmedReinforceRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ConfirmedReinforceRank");
		NativeFieldInfoPtr_IsDroneNeedCharge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsDroneNeedCharge");
		NativeFieldInfoPtr_ActiveDroneMissionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ActiveDroneMissionId");
		NativeFieldInfoPtr_ActiveDroneProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ActiveDroneProgress");
		NativeFieldInfoPtr_DroneManagerDropList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneManagerDropList");
		NativeFieldInfoPtr_DroneMissionAchieveCountDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneMissionAchieveCountDict");
		NativeFieldInfoPtr_DroneMissionAchieveCountPerStageDictDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneMissionAchieveCountPerStageDictDict");
		NativeFieldInfoPtr_DroneMissionMaxRpBonus100PerStageDictDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneMissionMaxRpBonus100PerStageDictDict");
		NativeFieldInfoPtr_RandomMissionClearNumIdDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "RandomMissionClearNumIdDict");
		NativeFieldInfoPtr_MissionAchieveCountDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MissionAchieveCountDict");
		NativeFieldInfoPtr_ContinueMissionAchieveCountDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ContinueMissionAchieveCountDict");
		NativeFieldInfoPtr_MissionSatisfyDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MissionSatisfyDict");
		NativeFieldInfoPtr_ContinueMissionSatisfyDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ContinueMissionSatisfyDict");
		NativeFieldInfoPtr_MissionEarnRpDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MissionEarnRpDict");
		NativeFieldInfoPtr_MissionMaxRpBonus100Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MissionMaxRpBonus100Dict");
		NativeFieldInfoPtr_DroneMissionEarnRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneMissionEarnRp");
		NativeFieldInfoPtr_StatistisTotalPlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalPlayTime");
		NativeFieldInfoPtr_StatistisTotalExposeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalExposeTime");
		NativeFieldInfoPtr_StatistisGameOverCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisGameOverCount");
		NativeFieldInfoPtr_StatistisEcstasyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisEcstasyCount");
		NativeFieldInfoPtr_StatistisMaxEarnRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisMaxEarnRp");
		NativeFieldInfoPtr_StatistisTotalEarnRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalEarnRp");
		NativeFieldInfoPtr_StatistisTotalLostRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalLostRp");
		NativeFieldInfoPtr_StatistisTotalLostExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalLostExp");
		NativeFieldInfoPtr_StatistisTotalUseRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisTotalUseRp");
		NativeFieldInfoPtr_StatistisMissionAchiveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisMissionAchiveCount");
		NativeFieldInfoPtr_StatistisMaxRpBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisMaxRpBoost");
		NativeFieldInfoPtr_StatistisMaxNudeMoveDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisMaxNudeMoveDistance");
		NativeFieldInfoPtr_StatistisMaxEarnRpByOneDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "StatistisMaxEarnRpByOneDay");
		NativeFieldInfoPtr_PlayerEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerEcstasy");
		NativeFieldInfoPtr_PlayerMental = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerMental");
		NativeFieldInfoPtr_PlayerMoisture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerMoisture");
		NativeFieldInfoPtr_PlayerAddMoisture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerAddMoisture");
		NativeFieldInfoPtr_PlayerFear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFear");
		NativeFieldInfoPtr_PlayerRemainBodyPaintTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerRemainBodyPaintTime");
		NativeFieldInfoPtr_PlayerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerPosition");
		NativeFieldInfoPtr_PlayerRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerRotation");
		NativeFieldInfoPtr_PlayerCurrentClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCurrentClothes");
		NativeFieldInfoPtr_PlayerCurrentHadObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCurrentHadObject");
		NativeFieldInfoPtr_PlayerCurrentHoldClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCurrentHoldClothes");
		NativeFieldInfoPtr_PlayerIsAttachHandcuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerIsAttachHandcuffs");
		NativeFieldInfoPtr_PlayerIsAttachMapHandcuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerIsAttachMapHandcuffs");
		NativeFieldInfoPtr_AttachedHandcuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "AttachedHandcuffType");
		NativeFieldInfoPtr_PlayerHandcuffTimerRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerHandcuffTimerRemainTime");
		NativeFieldInfoPtr_PlayerHandcuffTimerSetTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerHandcuffTimerSetTime");
		NativeFieldInfoPtr_PlayerVibrationModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerVibrationModeType");
		NativeFieldInfoPtr_PlayerLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerLife");
		NativeFieldInfoPtr_PlayerMaxLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerMaxLife");
		NativeFieldInfoPtr_PlayerCurrentClothesAState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCurrentClothesAState");
		NativeFieldInfoPtr_PlayerCurrentClothesBState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCurrentClothesBState");
		NativeFieldInfoPtr_PlayerPassiveSkillActiveDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerPassiveSkillActiveDict");
		NativeFieldInfoPtr_CurrentSexualityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CurrentSexualityType");
		NativeFieldInfoPtr_IsActiveFutanari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsActiveFutanari");
		NativeFieldInfoPtr_IsActiveInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsActiveInvisible");
		NativeFieldInfoPtr_IsActiveInvisibleReusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsActiveInvisibleReusable");
		NativeFieldInfoPtr_IsActiveBodyPaintReusable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "IsActiveBodyPaintReusable");
		NativeFieldInfoPtr_CurrentRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CurrentRp");
		NativeFieldInfoPtr_ExposeExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ExposeExp");
		NativeFieldInfoPtr_CurrentEarnThisTimeRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CurrentEarnThisTimeRp");
		NativeFieldInfoPtr_SkillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "SkillLevel");
		NativeFieldInfoPtr_ClothesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ClothesDict");
		NativeFieldInfoPtr_MAdultGoodsDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "MAdultGoodsDict");
		NativeFieldInfoPtr_PlayerCostumeDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCostumeDict");
		NativeFieldInfoPtr_ItemDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "ItemDict");
		NativeFieldInfoPtr_PlayerCosplayPartsDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerCosplayPartsDict");
		NativeFieldInfoPtr_AdultGoodsReinforceEffectDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "AdultGoodsReinforceEffectDict");
		NativeFieldInfoPtr_CosplayPartsReinforceEffectDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CosplayPartsReinforceEffectDict");
		NativeFieldInfoPtr_CostumeReinforceEffectDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "CostumeReinforceEffectDict");
		NativeFieldInfoPtr_HairTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "HairTypeList");
		NativeFieldInfoPtr_LoadoutDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "LoadoutDatas");
		NativeFieldInfoPtr_LoadoutCustomizeDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "LoadoutCustomizeDatas");
		NativeFieldInfoPtr_PlayerFace0Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFace0Id");
		NativeFieldInfoPtr_PlayerFace1Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFace1Id");
		NativeFieldInfoPtr_PlayerFace2Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFace2Id");
		NativeFieldInfoPtr_PlayerFace3Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFace3Id");
		NativeFieldInfoPtr_PlayerFaceIkuId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFaceIkuId");
		NativeFieldInfoPtr_PlayerFaceIkuAfterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PlayerFaceIkuAfterId");
		NativeFieldInfoPtr_VibeRemoconLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "VibeRemoconLevel");
		NativeFieldInfoPtr_PistonMachineModeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "PistonMachineModeType");
		NativeFieldInfoPtr_DroneLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, "DroneLevel");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateData>.NativeClassPtr, 100668681);
	}

	public GameStateData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
