using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts.Costume;
using ExposureUnnoticed2.Object3D.Player.Scripts.Other;
using ExposureUnnoticed2.Scripts.InGame;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AI;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerClassAccessor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Animator_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Transform_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AvatorTransform_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__GameObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CharacterController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Rigidbody_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AudioSource_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAnimationManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Player_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerLocomotion_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAvatarObjectReferencer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerObjectReferencer_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerClothes_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CapsuleCollider_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHairController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHoldInHand_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__DroppedItemManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MoistureManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerSoundManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPeeController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerClothesAction_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Mental_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Stamina_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NavAgent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBaretaState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBaretaEscapeState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHandcuffsController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerReceiveShadowChanger_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAdultGoodsController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerToeHeelController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAnimationParameter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerCostumeController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LookAtController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerFaceController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerEcstasyController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerTitController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerFaceShadowOnlyController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerStrangenessController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerPantsController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerFacade_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerMiscProcess_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAnimationReceiver_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBodyCustomizeAdjuster_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerAvatarOffsetManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerFootStepController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHeartBeat_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerRpBonusCalculator_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerKneeAdjuster_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerShrinkWakiController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBreathController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBodyMaterialController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerCosplayManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerShoesController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerReinforceEffectManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerBoneScaleAdjustManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__FutanariController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerShiofukiController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BodyPaintController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PistonMachineController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerMoveCalculator_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AvatorTransform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioSource_Public_get_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAnimationManager_Public_get_PlayerAnimationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerLocomotion_Public_get_PlayerLocomotion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerState_Public_get_PlayerStateModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAction_Public_get_PlayerAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAvatarObjectReferencer_Public_get_PlayerAvatarObjectReferencer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerObjectReferencer_Public_get_PlayerObjectReferencer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerClothes_Public_get_PlayerClothes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CapsuleCollider_Public_get_CapsuleCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHairController_Public_get_PlayerHairController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHoldInHand_Public_get_PlayerHoldInHand_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MoistureManager_Public_get_PlayerMoistureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MoistureManager_Private_set_Void_PlayerMoistureManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerSoundManager_Public_get_PlayerSoundManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPeeController_Public_get_PlayerPeeController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerClothesAction_Public_get_PlayerClothesAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Mental_Public_get_MentalManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Stamina_Public_get_StaminaManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NavAgent_Public_get_NavMeshAgent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBaretaState_Public_get_PlayerBaretaState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBaretaEscapeState_Public_get_PlayerBaretaEscapeState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandcuffsController_Public_get_PlayerHandcuffsController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerReceiveShadowChanger_Public_get_PlayerReceiveShadowChanger_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAdultGoodsController_Public_get_PlayerAdultGoodsController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerToeHeelController_Public_get_PlayerToeHeelController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAnimationParameter_Public_get_PlayerAnimationParameter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCostumeController_Public_get_PlayerCostumeController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAtController_Public_get_LookAtController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerFaceController_Public_get_PlayerFaceController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerEcstasyController_Public_get_PlayerEcstasyController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerTitController_Public_get_PlayerTitController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerFaceShadowOnlyController_Public_get_PlayerFaceShadowOnlyController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerStrangenessController_Public_get_PlayerStrangenessController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerPantsController_Public_get_PlayerPantsController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerFacade_Public_get_PlayerFacade_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMiscProcess_Public_get_PlayerMiscProcess_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAnimationReceiver_Public_get_PlayerAnimationReceiver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBodyCustomizeAdjuster_Public_get_PlayerBodyCustomizeAdjuster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerAvatarOffsetManager_Public_get_PlayerAvatarOffsetManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerFootStepController_Public_get_PlayerFootStepController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHeartBeat_Public_get_PlayerHeartBeat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerRpBonusCalculator_Public_get_PlayerRpBonusCalculator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerKneeAdjuster_Public_get_PlayerKneeAdjuster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerShrinkWakiController_Public_get_PlayerShrinkWakiController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBreathController_Public_get_PlayerBreathController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBodyMaterialController_Public_get_PlayerBodyMaterialController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerCosplayManager_Public_get_PlayerCosplayManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerShoesController_Public_get_PlayerShoesController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerReinforceEffectManager_Public_get_PlayerReinforceEffectManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerBoneScaleAdjustManager_Public_get_PlayerBoneScaleAdjustManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FutanariController_Public_get_FutanariController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerShiofukiController_Public_get_PlayerShiofukiController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BodyPaintController_Public_get_BodyPaintController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PistonMachineController_Public_get_PistonMachineController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerMoveCalculator_Public_get_PlayerMoveCalculator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PlayerController_DroppedItemManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	public unsafe Animator _Animator_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Animator_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Animator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform _Transform_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Transform_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Transform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform _AvatorTransform_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvatorTransform_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvatorTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _GameObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameObject_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CharacterController _CharacterController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharacterController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CharacterController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Rigidbody _Rigidbody_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rigidbody_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Rigidbody_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioSource _AudioSource_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AudioSource_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AudioSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAnimationManager _PlayerAnimationManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerController _Player_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerLocomotion _PlayerLocomotion_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerLocomotion_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerLocomotion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerLocomotion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerStateModel _PlayerState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStateModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAction _PlayerAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAvatarObjectReferencer _PlayerAvatarObjectReferencer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAvatarObjectReferencer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAvatarObjectReferencer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAvatarObjectReferencer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerObjectReferencer _PlayerObjectReferencer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerObjectReferencer_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerObjectReferencer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerObjectReferencer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerClothes _PlayerClothes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerClothes_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClothes>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerClothes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CapsuleCollider _CapsuleCollider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CapsuleCollider_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CapsuleCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerHairController _PlayerHairController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHairController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHairController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHairController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerHoldInHand _PlayerHoldInHand_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHoldInHand_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHoldInHand>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHoldInHand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DroppedItemManager _DroppedItemManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroppedItemManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroppedItemManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerMoistureManager _MoistureManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MoistureManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMoistureManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MoistureManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerSoundManager _PlayerSoundManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerSoundManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSoundManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerSoundManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerPeeController _PlayerPeeController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerPeeController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPeeController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerPeeController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerClothesAction _PlayerClothesAction_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerClothesAction_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClothesAction>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerClothesAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MentalManager _Mental_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Mental_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MentalManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Mental_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StaminaManager _Stamina_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Stamina_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaminaManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Stamina_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NavMeshAgent _NavAgent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NavAgent_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NavAgent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBaretaState _PlayerBaretaState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBaretaState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBaretaState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBaretaState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBaretaEscapeState _PlayerBaretaEscapeState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBaretaEscapeState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBaretaEscapeState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBaretaEscapeState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerHandcuffsController _PlayerHandcuffsController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHandcuffsController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHandcuffsController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHandcuffsController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerReceiveShadowChanger _PlayerReceiveShadowChanger_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerReceiveShadowChanger_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerReceiveShadowChanger>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerReceiveShadowChanger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAdultGoodsController _PlayerAdultGoodsController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAdultGoodsController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAdultGoodsController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAdultGoodsController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerToeHeelController _PlayerToeHeelController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerToeHeelController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerToeHeelController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerToeHeelController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAnimationParameter _PlayerAnimationParameter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationParameter_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationParameter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationParameter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerCostumeController _PlayerCostumeController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCostumeController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCostumeController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCostumeController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LookAtController _LookAtController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LookAtController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LookAtController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LookAtController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerFaceController _PlayerFaceController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFaceController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFaceController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFaceController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerEcstasyController _PlayerEcstasyController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerEcstasyController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerEcstasyController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerEcstasyController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerTitController _PlayerTitController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerTitController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTitController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerTitController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerFaceShadowOnlyController _PlayerFaceShadowOnlyController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFaceShadowOnlyController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFaceShadowOnlyController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFaceShadowOnlyController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerStrangenessController _PlayerStrangenessController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerStrangenessController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStrangenessController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerStrangenessController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerPantsController _PlayerPantsController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerPantsController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPantsController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerPantsController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerFacade _PlayerFacade_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFacade_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFacade>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFacade_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerMiscProcess _PlayerMiscProcess_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerMiscProcess_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMiscProcess>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerMiscProcess_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAnimationReceiver _PlayerAnimationReceiver_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationReceiver_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationReceiver>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAnimationReceiver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBodyCustomizeAdjuster _PlayerBodyCustomizeAdjuster_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBodyCustomizeAdjuster_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBodyCustomizeAdjuster>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBodyCustomizeAdjuster_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerAvatarOffsetManager _PlayerAvatarOffsetManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAvatarOffsetManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAvatarOffsetManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerAvatarOffsetManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerFootStepController _PlayerFootStepController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFootStepController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFootStepController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerFootStepController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerHeartBeat _PlayerHeartBeat_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHeartBeat_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHeartBeat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerHeartBeat_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerRpBonusCalculator _PlayerRpBonusCalculator_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerRpBonusCalculator_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerRpBonusCalculator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerRpBonusCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerKneeAdjuster _PlayerKneeAdjuster_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerKneeAdjuster_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerKneeAdjuster>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerKneeAdjuster_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerShrinkWakiController _PlayerShrinkWakiController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShrinkWakiController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShrinkWakiController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShrinkWakiController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBreathController _PlayerBreathController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBreathController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBreathController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBreathController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBodyMaterialController _PlayerBodyMaterialController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBodyMaterialController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBodyMaterialController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBodyMaterialController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerCosplayManager _PlayerCosplayManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCosplayManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCosplayManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerCosplayManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerShoesController _PlayerShoesController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShoesController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShoesController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShoesController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerReinforceEffectManager _PlayerReinforceEffectManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerReinforceEffectManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerReinforceEffectManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerReinforceEffectManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerBoneScaleAdjustManager _PlayerBoneScaleAdjustManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBoneScaleAdjustManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBoneScaleAdjustManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerBoneScaleAdjustManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FutanariController _FutanariController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FutanariController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FutanariController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FutanariController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerShiofukiController _PlayerShiofukiController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShiofukiController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShiofukiController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerShiofukiController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BodyPaintController _BodyPaintController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyPaintController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BodyPaintController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyPaintController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PistonMachineController _PistonMachineController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PistonMachineController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PistonMachineController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PistonMachineController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerMoveCalculator _PlayerMoveCalculator_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerMoveCalculator_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMoveCalculator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerMoveCalculator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Animator Animator
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 1, XrefRangeStart = 0, XrefRangeEnd = 1, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Animator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
	}

	public unsafe Transform Transform
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Transform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
	}

	public unsafe Transform AvatorTransform
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AvatorTransform_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
	}

	public unsafe GameObject GameObject
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
	}

	public unsafe CharacterController CharacterController
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
	}

	public unsafe Rigidbody Rigidbody
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr) : null;
		}
	}

	public unsafe AudioSource AudioSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AudioSource_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
	}

	public unsafe PlayerAnimationManager PlayerAnimationManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAnimationManager_Public_get_PlayerAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationManager>(intPtr) : null;
		}
	}

	public unsafe PlayerController Player
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
	}

	public unsafe PlayerLocomotion PlayerLocomotion
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerLocomotion_Public_get_PlayerLocomotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerLocomotion>(intPtr) : null;
		}
	}

	public unsafe PlayerStateModel PlayerState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerState_Public_get_PlayerStateModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStateModel>(intPtr) : null;
		}
	}

	public unsafe PlayerAction PlayerAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAction_Public_get_PlayerAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAction>(intPtr) : null;
		}
	}

	public unsafe PlayerAvatarObjectReferencer PlayerAvatarObjectReferencer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAvatarObjectReferencer_Public_get_PlayerAvatarObjectReferencer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAvatarObjectReferencer>(intPtr) : null;
		}
	}

	public unsafe PlayerObjectReferencer PlayerObjectReferencer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerObjectReferencer_Public_get_PlayerObjectReferencer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerObjectReferencer>(intPtr) : null;
		}
	}

	public unsafe PlayerClothes PlayerClothes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerClothes_Public_get_PlayerClothes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClothes>(intPtr) : null;
		}
	}

	public unsafe CapsuleCollider CapsuleCollider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CapsuleCollider_Public_get_CapsuleCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CapsuleCollider>(intPtr) : null;
		}
	}

	public unsafe PlayerHairController PlayerHairController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerHairController_Public_get_PlayerHairController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHairController>(intPtr) : null;
		}
	}

	public unsafe PlayerHoldInHand PlayerHoldInHand
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerHoldInHand_Public_get_PlayerHoldInHand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHoldInHand>(intPtr) : null;
		}
	}

	public unsafe DroppedItemManager DroppedItemManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr) : null;
		}
	}

	public unsafe PlayerMoistureManager MoistureManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MoistureManager_Public_get_PlayerMoistureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMoistureManager>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51803, RefRangeEnd = 51804, XrefRangeStart = 51803, XrefRangeEnd = 51803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MoistureManager_Private_set_Void_PlayerMoistureManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PlayerSoundManager PlayerSoundManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerSoundManager_Public_get_PlayerSoundManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSoundManager>(intPtr) : null;
		}
	}

	public unsafe PlayerPeeController PlayerPeeController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerPeeController_Public_get_PlayerPeeController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPeeController>(intPtr) : null;
		}
	}

	public unsafe PlayerClothesAction PlayerClothesAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerClothesAction_Public_get_PlayerClothesAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClothesAction>(intPtr) : null;
		}
	}

	public unsafe MentalManager Mental
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mental_Public_get_MentalManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MentalManager>(intPtr) : null;
		}
	}

	public unsafe StaminaManager Stamina
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Stamina_Public_get_StaminaManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StaminaManager>(intPtr) : null;
		}
	}

	public unsafe NavMeshAgent NavAgent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NavAgent_Public_get_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr) : null;
		}
	}

	public unsafe PlayerBaretaState PlayerBaretaState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBaretaState_Public_get_PlayerBaretaState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBaretaState>(intPtr) : null;
		}
	}

	public unsafe PlayerBaretaEscapeState PlayerBaretaEscapeState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBaretaEscapeState_Public_get_PlayerBaretaEscapeState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBaretaEscapeState>(intPtr) : null;
		}
	}

	public unsafe PlayerHandcuffsController PlayerHandcuffsController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerHandcuffsController_Public_get_PlayerHandcuffsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHandcuffsController>(intPtr) : null;
		}
	}

	public unsafe PlayerReceiveShadowChanger PlayerReceiveShadowChanger
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerReceiveShadowChanger_Public_get_PlayerReceiveShadowChanger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerReceiveShadowChanger>(intPtr) : null;
		}
	}

	public unsafe PlayerAdultGoodsController PlayerAdultGoodsController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAdultGoodsController_Public_get_PlayerAdultGoodsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAdultGoodsController>(intPtr) : null;
		}
	}

	public unsafe PlayerToeHeelController PlayerToeHeelController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerToeHeelController_Public_get_PlayerToeHeelController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerToeHeelController>(intPtr) : null;
		}
	}

	public unsafe PlayerAnimationParameter PlayerAnimationParameter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAnimationParameter_Public_get_PlayerAnimationParameter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationParameter>(intPtr) : null;
		}
	}

	public unsafe PlayerCostumeController PlayerCostumeController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerCostumeController_Public_get_PlayerCostumeController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCostumeController>(intPtr) : null;
		}
	}

	public unsafe LookAtController LookAtController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LookAtController_Public_get_LookAtController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LookAtController>(intPtr) : null;
		}
	}

	public unsafe PlayerFaceController PlayerFaceController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerFaceController_Public_get_PlayerFaceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFaceController>(intPtr) : null;
		}
	}

	public unsafe PlayerEcstasyController PlayerEcstasyController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerEcstasyController_Public_get_PlayerEcstasyController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerEcstasyController>(intPtr) : null;
		}
	}

	public unsafe PlayerTitController PlayerTitController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerTitController_Public_get_PlayerTitController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerTitController>(intPtr) : null;
		}
	}

	public unsafe PlayerFaceShadowOnlyController PlayerFaceShadowOnlyController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerFaceShadowOnlyController_Public_get_PlayerFaceShadowOnlyController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFaceShadowOnlyController>(intPtr) : null;
		}
	}

	public unsafe PlayerStrangenessController PlayerStrangenessController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerStrangenessController_Public_get_PlayerStrangenessController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStrangenessController>(intPtr) : null;
		}
	}

	public unsafe PlayerPantsController PlayerPantsController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerPantsController_Public_get_PlayerPantsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerPantsController>(intPtr) : null;
		}
	}

	public unsafe PlayerFacade PlayerFacade
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerFacade_Public_get_PlayerFacade_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFacade>(intPtr) : null;
		}
	}

	public unsafe PlayerMiscProcess PlayerMiscProcess
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerMiscProcess_Public_get_PlayerMiscProcess_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMiscProcess>(intPtr) : null;
		}
	}

	public unsafe PlayerAnimationReceiver PlayerAnimationReceiver
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAnimationReceiver_Public_get_PlayerAnimationReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationReceiver>(intPtr) : null;
		}
	}

	public unsafe PlayerBodyCustomizeAdjuster PlayerBodyCustomizeAdjuster
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBodyCustomizeAdjuster_Public_get_PlayerBodyCustomizeAdjuster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBodyCustomizeAdjuster>(intPtr) : null;
		}
	}

	public unsafe PlayerAvatarOffsetManager PlayerAvatarOffsetManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerAvatarOffsetManager_Public_get_PlayerAvatarOffsetManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAvatarOffsetManager>(intPtr) : null;
		}
	}

	public unsafe PlayerFootStepController PlayerFootStepController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerFootStepController_Public_get_PlayerFootStepController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFootStepController>(intPtr) : null;
		}
	}

	public unsafe PlayerHeartBeat PlayerHeartBeat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerHeartBeat_Public_get_PlayerHeartBeat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerHeartBeat>(intPtr) : null;
		}
	}

	public unsafe PlayerRpBonusCalculator PlayerRpBonusCalculator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerRpBonusCalculator_Public_get_PlayerRpBonusCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerRpBonusCalculator>(intPtr) : null;
		}
	}

	public unsafe PlayerKneeAdjuster PlayerKneeAdjuster
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerKneeAdjuster_Public_get_PlayerKneeAdjuster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerKneeAdjuster>(intPtr) : null;
		}
	}

	public unsafe PlayerShrinkWakiController PlayerShrinkWakiController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerShrinkWakiController_Public_get_PlayerShrinkWakiController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShrinkWakiController>(intPtr) : null;
		}
	}

	public unsafe PlayerBreathController PlayerBreathController
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 51804, RefRangeEnd = 51814, XrefRangeStart = 51804, XrefRangeEnd = 51804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBreathController_Public_get_PlayerBreathController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBreathController>(intPtr) : null;
		}
	}

	public unsafe PlayerBodyMaterialController PlayerBodyMaterialController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBodyMaterialController_Public_get_PlayerBodyMaterialController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBodyMaterialController>(intPtr) : null;
		}
	}

	public unsafe PlayerCosplayManager PlayerCosplayManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerCosplayManager_Public_get_PlayerCosplayManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCosplayManager>(intPtr) : null;
		}
	}

	public unsafe PlayerShoesController PlayerShoesController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerShoesController_Public_get_PlayerShoesController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShoesController>(intPtr) : null;
		}
	}

	public unsafe PlayerReinforceEffectManager PlayerReinforceEffectManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerReinforceEffectManager_Public_get_PlayerReinforceEffectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerReinforceEffectManager>(intPtr) : null;
		}
	}

	public unsafe PlayerBoneScaleAdjustManager PlayerBoneScaleAdjustManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerBoneScaleAdjustManager_Public_get_PlayerBoneScaleAdjustManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerBoneScaleAdjustManager>(intPtr) : null;
		}
	}

	public unsafe FutanariController FutanariController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FutanariController_Public_get_FutanariController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FutanariController>(intPtr) : null;
		}
	}

	public unsafe PlayerShiofukiController PlayerShiofukiController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerShiofukiController_Public_get_PlayerShiofukiController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerShiofukiController>(intPtr) : null;
		}
	}

	public unsafe BodyPaintController BodyPaintController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BodyPaintController_Public_get_BodyPaintController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<BodyPaintController>(intPtr) : null;
		}
	}

	public unsafe PistonMachineController PistonMachineController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PistonMachineController_Public_get_PistonMachineController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PistonMachineController>(intPtr) : null;
		}
	}

	public unsafe PlayerMoveCalculator PlayerMoveCalculator
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerMoveCalculator_Public_get_PlayerMoveCalculator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerMoveCalculator>(intPtr) : null;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52161, RefRangeEnd = 52162, XrefRangeStart = 51814, XrefRangeEnd = 52161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerClassAccessor([DefaultParameterValue(null)] PlayerController player, [DefaultParameterValue(null)] DroppedItemManager droppedItemManager)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(droppedItemManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_PlayerController_DroppedItemManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52282, RefRangeEnd = 52283, XrefRangeStart = 52162, XrefRangeEnd = 52282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52435, RefRangeEnd = 52437, XrefRangeStart = 52283, XrefRangeEnd = 52435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerClassAccessor()
	{
		Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerClassAccessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr);
		NativeFieldInfoPtr__Animator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Animator>k__BackingField");
		NativeFieldInfoPtr__Transform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Transform>k__BackingField");
		NativeFieldInfoPtr__AvatorTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<AvatorTransform>k__BackingField");
		NativeFieldInfoPtr__GameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<GameObject>k__BackingField");
		NativeFieldInfoPtr__CharacterController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<CharacterController>k__BackingField");
		NativeFieldInfoPtr__Rigidbody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Rigidbody>k__BackingField");
		NativeFieldInfoPtr__AudioSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<AudioSource>k__BackingField");
		NativeFieldInfoPtr__PlayerAnimationManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAnimationManager>k__BackingField");
		NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Player>k__BackingField");
		NativeFieldInfoPtr__PlayerLocomotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerLocomotion>k__BackingField");
		NativeFieldInfoPtr__PlayerState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerState>k__BackingField");
		NativeFieldInfoPtr__PlayerAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAction>k__BackingField");
		NativeFieldInfoPtr__PlayerAvatarObjectReferencer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAvatarObjectReferencer>k__BackingField");
		NativeFieldInfoPtr__PlayerObjectReferencer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerObjectReferencer>k__BackingField");
		NativeFieldInfoPtr__PlayerClothes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerClothes>k__BackingField");
		NativeFieldInfoPtr__CapsuleCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<CapsuleCollider>k__BackingField");
		NativeFieldInfoPtr__PlayerHairController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerHairController>k__BackingField");
		NativeFieldInfoPtr__PlayerHoldInHand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerHoldInHand>k__BackingField");
		NativeFieldInfoPtr__DroppedItemManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<DroppedItemManager>k__BackingField");
		NativeFieldInfoPtr__MoistureManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<MoistureManager>k__BackingField");
		NativeFieldInfoPtr__PlayerSoundManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerSoundManager>k__BackingField");
		NativeFieldInfoPtr__PlayerPeeController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerPeeController>k__BackingField");
		NativeFieldInfoPtr__PlayerClothesAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerClothesAction>k__BackingField");
		NativeFieldInfoPtr__Mental_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Mental>k__BackingField");
		NativeFieldInfoPtr__Stamina_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<Stamina>k__BackingField");
		NativeFieldInfoPtr__NavAgent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<NavAgent>k__BackingField");
		NativeFieldInfoPtr__PlayerBaretaState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBaretaState>k__BackingField");
		NativeFieldInfoPtr__PlayerBaretaEscapeState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBaretaEscapeState>k__BackingField");
		NativeFieldInfoPtr__PlayerHandcuffsController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerHandcuffsController>k__BackingField");
		NativeFieldInfoPtr__PlayerReceiveShadowChanger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerReceiveShadowChanger>k__BackingField");
		NativeFieldInfoPtr__PlayerAdultGoodsController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAdultGoodsController>k__BackingField");
		NativeFieldInfoPtr__PlayerToeHeelController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerToeHeelController>k__BackingField");
		NativeFieldInfoPtr__PlayerAnimationParameter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAnimationParameter>k__BackingField");
		NativeFieldInfoPtr__PlayerCostumeController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerCostumeController>k__BackingField");
		NativeFieldInfoPtr__LookAtController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<LookAtController>k__BackingField");
		NativeFieldInfoPtr__PlayerFaceController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerFaceController>k__BackingField");
		NativeFieldInfoPtr__PlayerEcstasyController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerEcstasyController>k__BackingField");
		NativeFieldInfoPtr__PlayerTitController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerTitController>k__BackingField");
		NativeFieldInfoPtr__PlayerFaceShadowOnlyController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerFaceShadowOnlyController>k__BackingField");
		NativeFieldInfoPtr__PlayerStrangenessController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerStrangenessController>k__BackingField");
		NativeFieldInfoPtr__PlayerPantsController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerPantsController>k__BackingField");
		NativeFieldInfoPtr__PlayerFacade_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerFacade>k__BackingField");
		NativeFieldInfoPtr__PlayerMiscProcess_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerMiscProcess>k__BackingField");
		NativeFieldInfoPtr__PlayerAnimationReceiver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAnimationReceiver>k__BackingField");
		NativeFieldInfoPtr__PlayerBodyCustomizeAdjuster_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBodyCustomizeAdjuster>k__BackingField");
		NativeFieldInfoPtr__PlayerAvatarOffsetManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerAvatarOffsetManager>k__BackingField");
		NativeFieldInfoPtr__PlayerFootStepController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerFootStepController>k__BackingField");
		NativeFieldInfoPtr__PlayerHeartBeat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerHeartBeat>k__BackingField");
		NativeFieldInfoPtr__PlayerRpBonusCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerRpBonusCalculator>k__BackingField");
		NativeFieldInfoPtr__PlayerKneeAdjuster_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerKneeAdjuster>k__BackingField");
		NativeFieldInfoPtr__PlayerShrinkWakiController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerShrinkWakiController>k__BackingField");
		NativeFieldInfoPtr__PlayerBreathController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBreathController>k__BackingField");
		NativeFieldInfoPtr__PlayerBodyMaterialController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBodyMaterialController>k__BackingField");
		NativeFieldInfoPtr__PlayerCosplayManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerCosplayManager>k__BackingField");
		NativeFieldInfoPtr__PlayerShoesController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerShoesController>k__BackingField");
		NativeFieldInfoPtr__PlayerReinforceEffectManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerReinforceEffectManager>k__BackingField");
		NativeFieldInfoPtr__PlayerBoneScaleAdjustManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerBoneScaleAdjustManager>k__BackingField");
		NativeFieldInfoPtr__FutanariController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<FutanariController>k__BackingField");
		NativeFieldInfoPtr__PlayerShiofukiController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerShiofukiController>k__BackingField");
		NativeFieldInfoPtr__BodyPaintController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<BodyPaintController>k__BackingField");
		NativeFieldInfoPtr__PistonMachineController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PistonMachineController>k__BackingField");
		NativeFieldInfoPtr__PlayerMoveCalculator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, "<PlayerMoveCalculator>k__BackingField");
		NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666608);
		NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666609);
		NativeMethodInfoPtr_get_AvatorTransform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666610);
		NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666611);
		NativeMethodInfoPtr_get_CharacterController_Public_get_CharacterController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666612);
		NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666613);
		NativeMethodInfoPtr_get_AudioSource_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666614);
		NativeMethodInfoPtr_get_PlayerAnimationManager_Public_get_PlayerAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666615);
		NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666616);
		NativeMethodInfoPtr_get_PlayerLocomotion_Public_get_PlayerLocomotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666617);
		NativeMethodInfoPtr_get_PlayerState_Public_get_PlayerStateModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666618);
		NativeMethodInfoPtr_get_PlayerAction_Public_get_PlayerAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666619);
		NativeMethodInfoPtr_get_PlayerAvatarObjectReferencer_Public_get_PlayerAvatarObjectReferencer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666620);
		NativeMethodInfoPtr_get_PlayerObjectReferencer_Public_get_PlayerObjectReferencer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666621);
		NativeMethodInfoPtr_get_PlayerClothes_Public_get_PlayerClothes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666622);
		NativeMethodInfoPtr_get_CapsuleCollider_Public_get_CapsuleCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666623);
		NativeMethodInfoPtr_get_PlayerHairController_Public_get_PlayerHairController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666624);
		NativeMethodInfoPtr_get_PlayerHoldInHand_Public_get_PlayerHoldInHand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666625);
		NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666626);
		NativeMethodInfoPtr_get_MoistureManager_Public_get_PlayerMoistureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666627);
		NativeMethodInfoPtr_set_MoistureManager_Private_set_Void_PlayerMoistureManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666628);
		NativeMethodInfoPtr_get_PlayerSoundManager_Public_get_PlayerSoundManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666629);
		NativeMethodInfoPtr_get_PlayerPeeController_Public_get_PlayerPeeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666630);
		NativeMethodInfoPtr_get_PlayerClothesAction_Public_get_PlayerClothesAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666631);
		NativeMethodInfoPtr_get_Mental_Public_get_MentalManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666632);
		NativeMethodInfoPtr_get_Stamina_Public_get_StaminaManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666633);
		NativeMethodInfoPtr_get_NavAgent_Public_get_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666634);
		NativeMethodInfoPtr_get_PlayerBaretaState_Public_get_PlayerBaretaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666635);
		NativeMethodInfoPtr_get_PlayerBaretaEscapeState_Public_get_PlayerBaretaEscapeState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666636);
		NativeMethodInfoPtr_get_PlayerHandcuffsController_Public_get_PlayerHandcuffsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666637);
		NativeMethodInfoPtr_get_PlayerReceiveShadowChanger_Public_get_PlayerReceiveShadowChanger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666638);
		NativeMethodInfoPtr_get_PlayerAdultGoodsController_Public_get_PlayerAdultGoodsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666639);
		NativeMethodInfoPtr_get_PlayerToeHeelController_Public_get_PlayerToeHeelController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666640);
		NativeMethodInfoPtr_get_PlayerAnimationParameter_Public_get_PlayerAnimationParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666641);
		NativeMethodInfoPtr_get_PlayerCostumeController_Public_get_PlayerCostumeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666642);
		NativeMethodInfoPtr_get_LookAtController_Public_get_LookAtController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666643);
		NativeMethodInfoPtr_get_PlayerFaceController_Public_get_PlayerFaceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666644);
		NativeMethodInfoPtr_get_PlayerEcstasyController_Public_get_PlayerEcstasyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666645);
		NativeMethodInfoPtr_get_PlayerTitController_Public_get_PlayerTitController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666646);
		NativeMethodInfoPtr_get_PlayerFaceShadowOnlyController_Public_get_PlayerFaceShadowOnlyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666647);
		NativeMethodInfoPtr_get_PlayerStrangenessController_Public_get_PlayerStrangenessController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666648);
		NativeMethodInfoPtr_get_PlayerPantsController_Public_get_PlayerPantsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666649);
		NativeMethodInfoPtr_get_PlayerFacade_Public_get_PlayerFacade_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666650);
		NativeMethodInfoPtr_get_PlayerMiscProcess_Public_get_PlayerMiscProcess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666651);
		NativeMethodInfoPtr_get_PlayerAnimationReceiver_Public_get_PlayerAnimationReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666652);
		NativeMethodInfoPtr_get_PlayerBodyCustomizeAdjuster_Public_get_PlayerBodyCustomizeAdjuster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666653);
		NativeMethodInfoPtr_get_PlayerAvatarOffsetManager_Public_get_PlayerAvatarOffsetManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666654);
		NativeMethodInfoPtr_get_PlayerFootStepController_Public_get_PlayerFootStepController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666655);
		NativeMethodInfoPtr_get_PlayerHeartBeat_Public_get_PlayerHeartBeat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666656);
		NativeMethodInfoPtr_get_PlayerRpBonusCalculator_Public_get_PlayerRpBonusCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666657);
		NativeMethodInfoPtr_get_PlayerKneeAdjuster_Public_get_PlayerKneeAdjuster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666658);
		NativeMethodInfoPtr_get_PlayerShrinkWakiController_Public_get_PlayerShrinkWakiController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666659);
		NativeMethodInfoPtr_get_PlayerBreathController_Public_get_PlayerBreathController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666660);
		NativeMethodInfoPtr_get_PlayerBodyMaterialController_Public_get_PlayerBodyMaterialController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666661);
		NativeMethodInfoPtr_get_PlayerCosplayManager_Public_get_PlayerCosplayManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666662);
		NativeMethodInfoPtr_get_PlayerShoesController_Public_get_PlayerShoesController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666663);
		NativeMethodInfoPtr_get_PlayerReinforceEffectManager_Public_get_PlayerReinforceEffectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666664);
		NativeMethodInfoPtr_get_PlayerBoneScaleAdjustManager_Public_get_PlayerBoneScaleAdjustManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666665);
		NativeMethodInfoPtr_get_FutanariController_Public_get_FutanariController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666666);
		NativeMethodInfoPtr_get_PlayerShiofukiController_Public_get_PlayerShiofukiController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666667);
		NativeMethodInfoPtr_get_BodyPaintController_Public_get_BodyPaintController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666668);
		NativeMethodInfoPtr_get_PistonMachineController_Public_get_PistonMachineController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666669);
		NativeMethodInfoPtr_get_PlayerMoveCalculator_Public_get_PlayerMoveCalculator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666670);
		NativeMethodInfoPtr__ctor_Public_Void_PlayerController_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666671);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666672);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClassAccessor>.NativeClassPtr, 100666673);
	}

	public PlayerClassAccessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
