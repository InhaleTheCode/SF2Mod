using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Accessory;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Costume;
using ExposureUnnoticed2.Master.Item;
using ExposureUnnoticed2.Master.Rank;
using ExposureUnnoticed2.Object3D.Light;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Object3D.Player.Scripts.Other;
using ExposureUnnoticed2.Object3D.RoutePoint;
using ExposureUnnoticed2.Object3D.ScenePlops.ChairSitController;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.InGame;
using HadakaCoat.Objects3D.Dildo;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerStateModel : Il2CppSystem.Object
{
	public enum ClothesState
	{
		None = -1,
		CloseA = 0,
		OpenA1 = 1,
		OpenA2 = 2,
		OpenA3 = 3,
		DropClothes = 5,
		CloseB = 10,
		OpenB1 = 11
	}

	public enum CoatStateMove
	{
		None = -1,
		CloseBtoOpenB1,
		OpenB1toCloseB
	}

	public enum CoatActionType
	{
		TypeA,
		TypeB
	}

	public enum PlayerState
	{
		Idle,
		Bareta,
		BaretaEscape
	}

	public enum HadObjectType
	{
		None = -1,
		Basket,
		HoldInHandClothes
	}

	public enum SexualityType
	{
		Normal,
		Flasher,
		Raper
	}

	[System.Flags]
	public enum HiddenBodyPartsByCostumeType
	{
		Boobs = 1,
		Hip = 2,
		Genitals = 4,
		SideOrBackUpperBody = 8,
		HipCrouch = 0x10
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsArmAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDash;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsStrafe;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPeeing;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsOffHipDBFromCosplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_NearNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_NearNpcForMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChaseTargetNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquippingAdultGoods;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquippingCostume;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEcstasyMotion;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcstasyRemainAftermathTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dokidoki;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmoothTransformTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_SmoothRotateTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompleteAttachHandcuffsTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_NearNpcDist;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsNearNpcForMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsNearNpcForMissionSecondary;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsLookedHip;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsLookedUpper;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsLookedFlashing;

	private static readonly System.IntPtr NativeFieldInfoPtr_StrangeBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bareyasusa;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaseBareyasusa;

	private static readonly System.IntPtr NativeFieldInfoPtr_BareyasusaFromStreetLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddBareyasusaByCosplay01;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddBareyasusaByAdultGoods;

	private static readonly System.IntPtr NativeFieldInfoPtr_DokidokiBonusByAdultGoods;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReinforceEffectData;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonusInt;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdultGoodsRpBonus100;

	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayRpBonus100;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcstasyRiseByVibratorPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcstasyRiseByPistonMachinePerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonusByVibratorPerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonusByPistonMachinePerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_MiscRpBonus;

	private static readonly System.IntPtr NativeFieldInfoPtr_VibratorRpBonusScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_PistonRpBonusScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentShoesRecord;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsGamanBaibu;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvalidLocomotionTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRank;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_TouchedLightList;

	private static readonly System.IntPtr NativeFieldInfoPtr_BareyasusaByHeel;

	private static readonly System.IntPtr NativeFieldInfoPtr_AdultGoodsBuffList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayBuffList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostumeBuffList;

	private static readonly System.IntPtr NativeFieldInfoPtr_OtherBuffDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_HiddenBodyPartsByCostume;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxLookHiddenPartMaxStrange;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnEndCommonEquip;

	private static readonly System.IntPtr NativeFieldInfoPtr_CommonEquipEndTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastInteractModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastPickupDildoWall;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveV;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastInteractTokenPublisher;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastChairSitController;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAutoChase;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAutoRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHideFutaByCosplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_VibeBikunMotionRemainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHatByCosplay;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFixedPositionRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFixedWarpPositionRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedWarpPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_FixedWarpRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeStopStrangeMaxNpcList;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeStopStrangeMaxNpcListClearRemainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_PoseActionCoolTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentClothesBStateCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastHadObjectType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastDropType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastDropItemType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastPickClothesType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastAttachedHandcuffType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastPickUpItemType;

	private static readonly System.IntPtr NativeFieldInfoPtr_LastUseItemType;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddEcstasyByPiston;

	private static readonly System.IntPtr NativeFieldInfoPtr_TransPick;

	private static readonly System.IntPtr NativeFieldInfoPtr_TransPickClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_TransAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_ForceSkipHandcuffCheckTransAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkipDropClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSit;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropClothesPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_SumFixedPushVThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_EscalatorPushVThisFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDownMoveForwardOneHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_CacheForNpcPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_CacheForNpcForward;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayingAction_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayingSomeNonMoveAction_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetExternalRequest_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MClothesRecord CurrentClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentClothes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentClothes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsArmAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmAction)) = flag;
		}
	}

	public unsafe bool IsDash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDash);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDash)) = flag;
		}
	}

	public unsafe bool IsStrafe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsStrafe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsStrafe)) = flag;
		}
	}

	public unsafe bool IsCrouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCrouch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCrouch)) = flag;
		}
	}

	public unsafe bool IsPeeing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPeeing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPeeing)) = flag;
		}
	}

	public unsafe bool IsOffHipDBFromCosplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOffHipDBFromCosplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOffHipDBFromCosplay)) = flag;
		}
	}

	public unsafe NpcController NearNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcController NearNpcForMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcForMission);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcForMission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcController ChaseTargetNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChaseTargetNpc);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChaseTargetNpc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MAdultGoodsRecord EquippingAdultGoods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquippingAdultGoods);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MAdultGoodsRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquippingAdultGoods), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RCostume EquippingCostume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquippingCostume);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RCostume>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquippingCostume), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MActionRecord CurrentAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentAction);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MActionRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentAction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsEcstasyMotion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEcstasyMotion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEcstasyMotion)) = flag;
		}
	}

	public unsafe float EcstasyRemainAftermathTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRemainAftermathTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRemainAftermathTime)) = num;
		}
	}

	public unsafe float Dokidoki
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dokidoki);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dokidoki)) = num;
		}
	}

	public unsafe PlayerState CurrentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState);
			return *(PlayerState*)num;
		}
		set
		{
			*(PlayerState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState)) = playerState;
		}
	}

	public unsafe Transform SmoothTransformTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothTransformTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothTransformTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Nullable<Quaternion> SmoothRotateTarget
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothRotateTarget);
			return new Il2CppSystem.Nullable<Quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Quaternion>>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmoothRotateTarget), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Quaternion>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe float CompleteAttachHandcuffsTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompleteAttachHandcuffsTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompleteAttachHandcuffsTime)) = num;
		}
	}

	public unsafe float NearNpcDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcDist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcDist)) = num;
		}
	}

	public unsafe bool IsNearNpcForMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNearNpcForMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNearNpcForMission)) = flag;
		}
	}

	public unsafe bool IsNearNpcForMissionSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNearNpcForMissionSecondary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNearNpcForMissionSecondary)) = flag;
		}
	}

	public unsafe bool IsLookedHip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedHip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedHip)) = flag;
		}
	}

	public unsafe bool IsLookedUpper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedUpper);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedUpper)) = flag;
		}
	}

	public unsafe bool IsLookedFlashing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedFlashing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookedFlashing)) = flag;
		}
	}

	public unsafe float StrangeBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeBonus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeBonus)) = num;
		}
	}

	public unsafe float Bareyasusa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bareyasusa);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bareyasusa)) = num;
		}
	}

	public unsafe float BaseBareyasusa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseBareyasusa);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BaseBareyasusa)) = num;
		}
	}

	public unsafe float BareyasusaFromStreetLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BareyasusaFromStreetLight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BareyasusaFromStreetLight)) = num;
		}
	}

	public unsafe float AddBareyasusaByCosplay01
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddBareyasusaByCosplay01);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddBareyasusaByCosplay01)) = num;
		}
	}

	public unsafe float AddBareyasusaByAdultGoods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddBareyasusaByAdultGoods);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddBareyasusaByAdultGoods)) = num;
		}
	}

	public unsafe float DokidokiBonusByAdultGoods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiBonusByAdultGoods);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiBonusByAdultGoods)) = num;
		}
	}

	public unsafe SumReinforceEffectData ReinforceEffectData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforceEffectData);
			return *(SumReinforceEffectData*)num;
		}
		set
		{
			*(SumReinforceEffectData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforceEffectData)) = sumReinforceEffectData;
		}
	}

	public unsafe float RpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus)) = num;
		}
	}

	public unsafe float RpBonusInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusInt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusInt)) = num;
		}
	}

	public unsafe int AdultGoodsRpBonus100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsRpBonus100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsRpBonus100)) = num;
		}
	}

	public unsafe int CosplayRpBonus100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayRpBonus100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayRpBonus100)) = num;
		}
	}

	public unsafe float EcstasyRiseByVibratorPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRiseByVibratorPerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRiseByVibratorPerSecond)) = num;
		}
	}

	public unsafe float EcstasyRiseByPistonMachinePerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRiseByPistonMachinePerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRiseByPistonMachinePerSecond)) = num;
		}
	}

	public unsafe int RpBonusByVibratorPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusByVibratorPerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusByVibratorPerSecond)) = num;
		}
	}

	public unsafe int RpBonusByPistonMachinePerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusByPistonMachinePerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusByPistonMachinePerSecond)) = num;
		}
	}

	public unsafe float MiscRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiscRpBonus);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiscRpBonus)) = num;
		}
	}

	public unsafe float VibratorRpBonusScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibratorRpBonusScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibratorRpBonusScale)) = num;
		}
	}

	public unsafe float PistonRpBonusScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PistonRpBonusScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PistonRpBonusScale)) = num;
		}
	}

	public unsafe IShoesRecord CurrentShoesRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentShoesRecord);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IShoesRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentShoesRecord), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsGamanBaibu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGamanBaibu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGamanBaibu)) = flag;
		}
	}

	public unsafe float InvalidLocomotionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvalidLocomotionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvalidLocomotionTime)) = num;
		}
	}

	public unsafe MRankRecord CurrentRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRank);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MRankRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRank), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float AddEcstasy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddEcstasy);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddEcstasy)) = num;
		}
	}

	public unsafe List<StreetLightController> TouchedLightList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TouchedLightList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<StreetLightController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TouchedLightList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float BareyasusaByHeel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BareyasusaByHeel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BareyasusaByHeel)) = num;
		}
	}

	public unsafe List<BuffModel> AdultGoodsBuffList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsBuffList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuffModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsBuffList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<BuffModel> CosplayBuffList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayBuffList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuffModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayBuffList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<BuffModel> CostumeBuffList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeBuffList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<BuffModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeBuffList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<BuffSourceType, BuffModel> OtherBuffDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherBuffDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BuffSourceType, BuffModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OtherBuffDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe HiddenBodyPartsByCostumeType HiddenBodyPartsByCostume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HiddenBodyPartsByCostume);
			return *(HiddenBodyPartsByCostumeType*)num;
		}
		set
		{
			*(HiddenBodyPartsByCostumeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HiddenBodyPartsByCostume)) = hiddenBodyPartsByCostumeType;
		}
	}

	public unsafe float MaxLookHiddenPartMaxStrange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLookHiddenPartMaxStrange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLookHiddenPartMaxStrange)) = num;
		}
	}

	public unsafe Il2CppSystem.Action OnEndCommonEquip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEndCommonEquip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnEndCommonEquip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float CommonEquipEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommonEquipEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommonEquipEndTime)) = num;
		}
	}

	public unsafe InteractModel LastInteractModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastInteractModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastInteractModel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DildoController LastPickupDildoWall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickupDildoWall);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DildoController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickupDildoWall), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 MoveV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveV);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveV)) = vector;
		}
	}

	public unsafe BaseInteractTokenPublisher LastInteractTokenPublisher
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastInteractTokenPublisher);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseInteractTokenPublisher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastInteractTokenPublisher), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChairSitController LastChairSitController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastChairSitController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChairSitController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastChairSitController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsAutoChase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAutoChase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAutoChase)) = flag;
		}
	}

	public unsafe bool IsAutoRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAutoRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAutoRun)) = flag;
		}
	}

	public unsafe bool IsHideFutaByCosplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideFutaByCosplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideFutaByCosplay)) = flag;
		}
	}

	public unsafe float VibeBikunMotionRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeBikunMotionRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeBikunMotionRemainTime)) = num;
		}
	}

	public unsafe bool IsHatByCosplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHatByCosplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHatByCosplay)) = flag;
		}
	}

	public unsafe bool IsFixedPositionRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixedPositionRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixedPositionRotation)) = flag;
		}
	}

	public unsafe Vector3 FixedPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedPosition)) = vector;
		}
	}

	public unsafe Quaternion FixedRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedRotation)) = quaternion;
		}
	}

	public unsafe bool IsFixedWarpPositionRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixedWarpPositionRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixedWarpPositionRotation)) = flag;
		}
	}

	public unsafe Vector3 FixedWarpPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedWarpPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedWarpPosition)) = vector;
		}
	}

	public unsafe Quaternion FixedWarpRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedWarpRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FixedWarpRotation)) = quaternion;
		}
	}

	public unsafe List<NpcController> timeStopStrangeMaxNpcList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStopStrangeMaxNpcList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<NpcController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeStopStrangeMaxNpcList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float TimeStopStrangeMaxNpcListClearRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeStopStrangeMaxNpcListClearRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeStopStrangeMaxNpcListClearRemainTime)) = num;
		}
	}

	public unsafe float PoseActionCoolTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoseActionCoolTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoseActionCoolTime)) = num;
		}
	}

	public unsafe ClothesState CurrentClothesBStateCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentClothesBStateCache);
			return *(ClothesState*)num;
		}
		set
		{
			*(ClothesState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentClothesBStateCache)) = clothesState;
		}
	}

	public unsafe HadObjectType LastHadObjectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastHadObjectType);
			return *(HadObjectType*)num;
		}
		set
		{
			*(HadObjectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastHadObjectType)) = hadObjectType;
		}
	}

	public unsafe HadObjectType LastDropType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDropType);
			return *(HadObjectType*)num;
		}
		set
		{
			*(HadObjectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDropType)) = hadObjectType;
		}
	}

	public unsafe DroppedItemManager.DropItemType LastDropItemType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDropItemType);
			return *(DroppedItemManager.DropItemType*)num;
		}
		set
		{
			*(DroppedItemManager.DropItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastDropItemType)) = dropItemType;
		}
	}

	public unsafe ClothesType LastPickClothesType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickClothesType);
			return *(ClothesType*)num;
		}
		set
		{
			*(ClothesType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickClothesType)) = clothesType;
		}
	}

	public unsafe MAdultGoodsType LastAttachedHandcuffType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastAttachedHandcuffType);
			return *(MAdultGoodsType*)num;
		}
		set
		{
			*(MAdultGoodsType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastAttachedHandcuffType)) = mAdultGoodsType;
		}
	}

	public unsafe DroppedItemManager.DropItemType LastPickUpItemType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickUpItemType);
			return *(DroppedItemManager.DropItemType*)num;
		}
		set
		{
			*(DroppedItemManager.DropItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastPickUpItemType)) = dropItemType;
		}
	}

	public unsafe ItemType LastUseItemType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUseItemType);
			return *(ItemType*)num;
		}
		set
		{
			*(ItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LastUseItemType)) = itemType;
		}
	}

	public unsafe float AddEcstasyByPiston
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddEcstasyByPiston);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddEcstasyByPiston)) = num;
		}
	}

	public unsafe bool TransPick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransPick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransPick)) = flag;
		}
	}

	public unsafe bool TransPickClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransPickClothes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransPickClothes)) = flag;
		}
	}

	public unsafe ActionType TransAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransAction);
			return *(ActionType*)num;
		}
		set
		{
			*(ActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransAction)) = actionType;
		}
	}

	public unsafe bool ForceSkipHandcuffCheckTransAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceSkipHandcuffCheckTransAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceSkipHandcuffCheckTransAction)) = flag;
		}
	}

	public unsafe bool SkipDropClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkipDropClothes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkipDropClothes)) = flag;
		}
	}

	public unsafe bool IsSit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSit)) = flag;
		}
	}

	public unsafe Transform DropClothesPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropClothesPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DropClothesPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 SumFixedPushVThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SumFixedPushVThisFrame);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SumFixedPushVThisFrame)) = vector;
		}
	}

	public unsafe Vector3 EscalatorPushVThisFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EscalatorPushVThisFrame);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EscalatorPushVThisFrame)) = vector;
		}
	}

	public unsafe bool IsDownMoveForwardOneHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDownMoveForwardOneHand);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDownMoveForwardOneHand)) = flag;
		}
	}

	public unsafe Vector3 CacheForNpcPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheForNpcPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheForNpcPosition)) = vector;
		}
	}

	public unsafe Vector3 CacheForNpcForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheForNpcForward);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CacheForNpcForward)) = vector;
		}
	}

	public unsafe bool IsPlayingAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPlayingAction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool IsPlayingSomeNonMoveAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPlayingSomeNonMoveAction_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 55935, XrefRangeEnd = 55940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetExternalRequest()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetExternalRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void Load()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 55974, RefRangeEnd = 55975, XrefRangeStart = 55940, XrefRangeEnd = 55974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerStateModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerStateModel()
	{
		Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerStateModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr);
		NativeFieldInfoPtr_CurrentClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentClothes");
		NativeFieldInfoPtr_IsArmAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsArmAction");
		NativeFieldInfoPtr_IsDash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsDash");
		NativeFieldInfoPtr_IsStrafe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsStrafe");
		NativeFieldInfoPtr_IsCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsCrouch");
		NativeFieldInfoPtr_IsPeeing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsPeeing");
		NativeFieldInfoPtr_IsOffHipDBFromCosplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsOffHipDBFromCosplay");
		NativeFieldInfoPtr_NearNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "NearNpc");
		NativeFieldInfoPtr_NearNpcForMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "NearNpcForMission");
		NativeFieldInfoPtr_ChaseTargetNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "ChaseTargetNpc");
		NativeFieldInfoPtr_EquippingAdultGoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EquippingAdultGoods");
		NativeFieldInfoPtr_EquippingCostume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EquippingCostume");
		NativeFieldInfoPtr_CurrentAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentAction");
		NativeFieldInfoPtr_IsEcstasyMotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsEcstasyMotion");
		NativeFieldInfoPtr_EcstasyRemainAftermathTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EcstasyRemainAftermathTime");
		NativeFieldInfoPtr_Dokidoki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "Dokidoki");
		NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentState");
		NativeFieldInfoPtr_SmoothTransformTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "SmoothTransformTarget");
		NativeFieldInfoPtr_SmoothRotateTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "SmoothRotateTarget");
		NativeFieldInfoPtr_CompleteAttachHandcuffsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CompleteAttachHandcuffsTime");
		NativeFieldInfoPtr_NearNpcDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "NearNpcDist");
		NativeFieldInfoPtr_IsNearNpcForMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsNearNpcForMission");
		NativeFieldInfoPtr_IsNearNpcForMissionSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsNearNpcForMissionSecondary");
		NativeFieldInfoPtr_IsLookedHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsLookedHip");
		NativeFieldInfoPtr_IsLookedUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsLookedUpper");
		NativeFieldInfoPtr_IsLookedFlashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsLookedFlashing");
		NativeFieldInfoPtr_StrangeBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "StrangeBonus");
		NativeFieldInfoPtr_Bareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "Bareyasusa");
		NativeFieldInfoPtr_BaseBareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "BaseBareyasusa");
		NativeFieldInfoPtr_BareyasusaFromStreetLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "BareyasusaFromStreetLight");
		NativeFieldInfoPtr_AddBareyasusaByCosplay01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AddBareyasusaByCosplay01");
		NativeFieldInfoPtr_AddBareyasusaByAdultGoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AddBareyasusaByAdultGoods");
		NativeFieldInfoPtr_DokidokiBonusByAdultGoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "DokidokiBonusByAdultGoods");
		NativeFieldInfoPtr_ReinforceEffectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "ReinforceEffectData");
		NativeFieldInfoPtr_RpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "RpBonus");
		NativeFieldInfoPtr_RpBonusInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "RpBonusInt");
		NativeFieldInfoPtr_AdultGoodsRpBonus100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AdultGoodsRpBonus100");
		NativeFieldInfoPtr_CosplayRpBonus100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CosplayRpBonus100");
		NativeFieldInfoPtr_EcstasyRiseByVibratorPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EcstasyRiseByVibratorPerSecond");
		NativeFieldInfoPtr_EcstasyRiseByPistonMachinePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EcstasyRiseByPistonMachinePerSecond");
		NativeFieldInfoPtr_RpBonusByVibratorPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "RpBonusByVibratorPerSecond");
		NativeFieldInfoPtr_RpBonusByPistonMachinePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "RpBonusByPistonMachinePerSecond");
		NativeFieldInfoPtr_MiscRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "MiscRpBonus");
		NativeFieldInfoPtr_VibratorRpBonusScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "VibratorRpBonusScale");
		NativeFieldInfoPtr_PistonRpBonusScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "PistonRpBonusScale");
		NativeFieldInfoPtr_CurrentShoesRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentShoesRecord");
		NativeFieldInfoPtr_IsGamanBaibu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsGamanBaibu");
		NativeFieldInfoPtr_InvalidLocomotionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "InvalidLocomotionTime");
		NativeFieldInfoPtr_CurrentRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentRank");
		NativeFieldInfoPtr_AddEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AddEcstasy");
		NativeFieldInfoPtr_TouchedLightList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "TouchedLightList");
		NativeFieldInfoPtr_BareyasusaByHeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "BareyasusaByHeel");
		NativeFieldInfoPtr_AdultGoodsBuffList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AdultGoodsBuffList");
		NativeFieldInfoPtr_CosplayBuffList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CosplayBuffList");
		NativeFieldInfoPtr_CostumeBuffList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CostumeBuffList");
		NativeFieldInfoPtr_OtherBuffDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "OtherBuffDict");
		NativeFieldInfoPtr_HiddenBodyPartsByCostume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "HiddenBodyPartsByCostume");
		NativeFieldInfoPtr_MaxLookHiddenPartMaxStrange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "MaxLookHiddenPartMaxStrange");
		NativeFieldInfoPtr_OnEndCommonEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "OnEndCommonEquip");
		NativeFieldInfoPtr_CommonEquipEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CommonEquipEndTime");
		NativeFieldInfoPtr_LastInteractModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastInteractModel");
		NativeFieldInfoPtr_LastPickupDildoWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastPickupDildoWall");
		NativeFieldInfoPtr_MoveV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "MoveV");
		NativeFieldInfoPtr_LastInteractTokenPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastInteractTokenPublisher");
		NativeFieldInfoPtr_LastChairSitController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastChairSitController");
		NativeFieldInfoPtr_IsAutoChase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsAutoChase");
		NativeFieldInfoPtr_IsAutoRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsAutoRun");
		NativeFieldInfoPtr_IsHideFutaByCosplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsHideFutaByCosplay");
		NativeFieldInfoPtr_VibeBikunMotionRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "VibeBikunMotionRemainTime");
		NativeFieldInfoPtr_IsHatByCosplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsHatByCosplay");
		NativeFieldInfoPtr_IsFixedPositionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsFixedPositionRotation");
		NativeFieldInfoPtr_FixedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "FixedPosition");
		NativeFieldInfoPtr_FixedRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "FixedRotation");
		NativeFieldInfoPtr_IsFixedWarpPositionRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsFixedWarpPositionRotation");
		NativeFieldInfoPtr_FixedWarpPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "FixedWarpPosition");
		NativeFieldInfoPtr_FixedWarpRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "FixedWarpRotation");
		NativeFieldInfoPtr_timeStopStrangeMaxNpcList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "timeStopStrangeMaxNpcList");
		NativeFieldInfoPtr_TimeStopStrangeMaxNpcListClearRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "TimeStopStrangeMaxNpcListClearRemainTime");
		NativeFieldInfoPtr_PoseActionCoolTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "PoseActionCoolTime");
		NativeFieldInfoPtr_CurrentClothesBStateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CurrentClothesBStateCache");
		NativeFieldInfoPtr_LastHadObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastHadObjectType");
		NativeFieldInfoPtr_LastDropType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastDropType");
		NativeFieldInfoPtr_LastDropItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastDropItemType");
		NativeFieldInfoPtr_LastPickClothesType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastPickClothesType");
		NativeFieldInfoPtr_LastAttachedHandcuffType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastAttachedHandcuffType");
		NativeFieldInfoPtr_LastPickUpItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastPickUpItemType");
		NativeFieldInfoPtr_LastUseItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "LastUseItemType");
		NativeFieldInfoPtr_AddEcstasyByPiston = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "AddEcstasyByPiston");
		NativeFieldInfoPtr_TransPick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "TransPick");
		NativeFieldInfoPtr_TransPickClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "TransPickClothes");
		NativeFieldInfoPtr_TransAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "TransAction");
		NativeFieldInfoPtr_ForceSkipHandcuffCheckTransAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "ForceSkipHandcuffCheckTransAction");
		NativeFieldInfoPtr_SkipDropClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "SkipDropClothes");
		NativeFieldInfoPtr_IsSit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsSit");
		NativeFieldInfoPtr_DropClothesPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "DropClothesPoint");
		NativeFieldInfoPtr_SumFixedPushVThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "SumFixedPushVThisFrame");
		NativeFieldInfoPtr_EscalatorPushVThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "EscalatorPushVThisFrame");
		NativeFieldInfoPtr_IsDownMoveForwardOneHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "IsDownMoveForwardOneHand");
		NativeFieldInfoPtr_CacheForNpcPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CacheForNpcPosition");
		NativeFieldInfoPtr_CacheForNpcForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, "CacheForNpcForward");
		NativeMethodInfoPtr_get_IsPlayingAction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666918);
		NativeMethodInfoPtr_get_IsPlayingSomeNonMoveAction_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666919);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666920);
		NativeMethodInfoPtr_ResetExternalRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666921);
		NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666922);
		NativeMethodInfoPtr_Load_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666923);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateModel>.NativeClassPtr, 100666924);
	}

	public PlayerStateModel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
