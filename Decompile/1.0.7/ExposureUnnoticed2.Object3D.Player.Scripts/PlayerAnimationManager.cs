using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerAnimationManager : Il2CppSystem.Object
{
	public enum Layer
	{
		Locomotion,
		Action,
		OverrideArmHand,
		ClothesActionArm,
		OverrideClothArmLayer,
		Upper,
		OverrideHandArm,
		OverrideRightArmHand
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_LocomotionLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActionLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesActionArmLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideClothArmLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_Upper;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideArmForHandcuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideLeftArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceLayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_CoatState;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeadHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsStrafe;

	private static readonly System.IntPtr NativeFieldInfoPtr_StrafeX;

	private static readonly System.IntPtr NativeFieldInfoPtr_StrafeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_ActionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Action;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetMoveSpeed_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetClothesStateABlend_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetCoatStateBBlend_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetArmLayerWeight_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsForceHeadLayerWeight_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseMoveSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_pulseTargetArmLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_isGamanBaibu;

	private static readonly System.IntPtr NativeFieldInfoPtr_animator;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerStateModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_coatStateA;

	private static readonly System.IntPtr NativeFieldInfoPtr_coatStateB;

	private static readonly System.IntPtr NativeFieldInfoPtr_headLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_armLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideArmForHandcuffLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideRightArmHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideArmLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_strafeX;

	private static readonly System.IntPtr NativeFieldInfoPtr_strafeY;

	private static readonly System.IntPtr NativeFieldInfoPtr_dokidoki;

	private static readonly System.IntPtr NativeFieldInfoPtr_moveSpeedBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_handcaffsWeightBlend;

	private static readonly System.IntPtr NativeFieldInfoPtr_anotherMotionIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_locomotionMotionSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Ecstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsBareta;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dokidoki;

	private static readonly System.IntPtr NativeFieldInfoPtr_HadBasket;

	private static readonly System.IntPtr NativeFieldInfoPtr_DownHip;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenHip;

	private static readonly System.IntPtr NativeFieldInfoPtr_CoatStateB;

	private static readonly System.IntPtr NativeFieldInfoPtr_HoldInHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaretaEscape;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHandcuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsGamanBaibu;

	private static readonly System.IntPtr NativeFieldInfoPtr_HandcuffsWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_DropClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoHip;

	private static readonly System.IntPtr NativeFieldInfoPtr_BaretaFace;

	private static readonly System.IntPtr NativeFieldInfoPtr_LocomotionMotionSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_OldActionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_oldActionId;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionSpeedScaleWhenSlow;

	private static readonly System.IntPtr NativeFieldInfoPtr_BreastSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnotherMotionIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_FutanariSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionSpeedScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreviewNakedArmPose;

	private static readonly System.IntPtr NativeFieldInfoPtr_WalkSpeedScale;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetMoveSpeed_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetMoveSpeed_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetClothesStateABlend_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetClothesStateABlend_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetCoatStateBBlend_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetCoatStateBBlend_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetArmLayerWeight_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetArmLayerWeight_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsForceHeadLayerWeight_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsForceHeadLayerWeight_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMoveSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHandcuffsWeight_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectDropClothes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectNoHip_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Void_ClothesState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeadHeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMotionSpeedScale_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFutanariSize_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStrafe_Public_Void_Boolean_Boolean_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransBaretaEscape_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransEcstasy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetEcstasy_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreviewNakedArmPose_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetArmPulse_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBareta_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBaretaFace_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHoldInHand_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHandcuffs_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetGamanBaibu_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHip_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceLayerWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateAnotherMotionIndex_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NearStrafeDirect_Public_Direct_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int LocomotionLayer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LocomotionLayer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LocomotionLayer, &num);
		}
	}

	public unsafe static int ActionLayer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActionLayer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActionLayer, &num);
		}
	}

	public unsafe static int ClothesActionArmLayer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClothesActionArmLayer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClothesActionArmLayer, &num);
		}
	}

	public unsafe static int OverrideClothArmLayer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OverrideClothArmLayer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OverrideClothArmLayer, &num);
		}
	}

	public unsafe static int Upper
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Upper, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Upper, &num);
		}
	}

	public unsafe static int OverrideArmForHandcuff
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OverrideArmForHandcuff, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OverrideArmForHandcuff, &num);
		}
	}

	public unsafe static int OverrideLeftArm
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OverrideLeftArm, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OverrideLeftArm, &num);
		}
	}

	public unsafe static int FaceLayer
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FaceLayer, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FaceLayer, &num);
		}
	}

	public unsafe static int MoveSpeed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MoveSpeed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MoveSpeed, &num);
		}
	}

	public unsafe static int CoatState
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CoatState, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CoatState, &num);
		}
	}

	public unsafe static int HeadHeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HeadHeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HeadHeight, &num);
		}
	}

	public unsafe static int IsStrafe
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsStrafe, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsStrafe, &num);
		}
	}

	public unsafe static int StrafeX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StrafeX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StrafeX, &num);
		}
	}

	public unsafe static int StrafeY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StrafeY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StrafeY, &num);
		}
	}

	public unsafe static int IsCrouch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsCrouch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsCrouch, &num);
		}
	}

	public unsafe static int ActionId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ActionId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ActionId, &num);
		}
	}

	public unsafe static int Action
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Action, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Action, &num);
		}
	}

	public unsafe float _TargetMoveSpeed_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetMoveSpeed_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetMoveSpeed_k__BackingField)) = num;
		}
	}

	public unsafe float _TargetClothesStateABlend_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetClothesStateABlend_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetClothesStateABlend_k__BackingField)) = num;
		}
	}

	public unsafe float _TargetCoatStateBBlend_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetCoatStateBBlend_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetCoatStateBBlend_k__BackingField)) = num;
		}
	}

	public unsafe float _TargetArmLayerWeight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetArmLayerWeight_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetArmLayerWeight_k__BackingField)) = num;
		}
	}

	public unsafe bool _IsForceHeadLayerWeight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsForceHeadLayerWeight_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsForceHeadLayerWeight_k__BackingField)) = flag;
		}
	}

	public unsafe float baseMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseMoveSpeed)) = num;
		}
	}

	public unsafe float pulseTargetArmLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseTargetArmLayerWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseTargetArmLayerWeight)) = num;
		}
	}

	public unsafe bool isGamanBaibu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamanBaibu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isGamanBaibu)) = flag;
		}
	}

	public unsafe Animator animator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerStateModel playerStateModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStateModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStateModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStateModel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerClassAccessor pca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClassAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat coatStateA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatStateA);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatStateA), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat coatStateB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatStateB);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatStateB), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat headLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_headLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat faceLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat armLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_armLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat overrideArmForHandcuffLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideArmForHandcuffLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideArmForHandcuffLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat overrideRightArmHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRightArmHand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideRightArmHand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat overrideArmLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideArmLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideArmLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat strafeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strafeX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strafeX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat strafeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strafeY);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strafeY), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat dokidoki
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokidoki);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokidoki), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat moveSpeedBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveSpeedBlend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moveSpeedBlend), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat handcaffsWeightBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handcaffsWeightBlend);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_handcaffsWeightBlend), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat anotherMotionIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anotherMotionIndex);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anotherMotionIndex), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat locomotionMotionSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locomotionMotionSpeed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_locomotionMotionSpeed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int Ecstasy
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Ecstasy, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Ecstasy, &num);
		}
	}

	public unsafe static int IsBareta
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsBareta, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsBareta, &num);
		}
	}

	public unsafe static int Dokidoki
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Dokidoki, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Dokidoki, &num);
		}
	}

	public unsafe static int HadBasket
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HadBasket, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HadBasket, &num);
		}
	}

	public unsafe static int DownHip
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DownHip, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DownHip, &num);
		}
	}

	public unsafe static int OpenHip
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenHip, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenHip, &num);
		}
	}

	public unsafe static int CoatStateB
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CoatStateB, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CoatStateB, &num);
		}
	}

	public unsafe static int HoldInHand
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HoldInHand, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HoldInHand, &num);
		}
	}

	public unsafe static int BaretaEscape
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaretaEscape, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaretaEscape, &num);
		}
	}

	public unsafe static int IsHandcuffs
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsHandcuffs, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsHandcuffs, &num);
		}
	}

	public unsafe static int IsGamanBaibu
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsGamanBaibu, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsGamanBaibu, &num);
		}
	}

	public unsafe static int HandcuffsWeight
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HandcuffsWeight, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HandcuffsWeight, &num);
		}
	}

	public unsafe static int DropClothes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DropClothes, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DropClothes, &num);
		}
	}

	public unsafe static int NoHip
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoHip, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoHip, &num);
		}
	}

	public unsafe static int BaretaFace
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaretaFace, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaretaFace, &num);
		}
	}

	public unsafe static int LocomotionMotionSpeed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LocomotionMotionSpeed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LocomotionMotionSpeed, &num);
		}
	}

	public unsafe static int PlayerEcstasy
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerEcstasy, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerEcstasy, &num);
		}
	}

	public unsafe static int OldActionId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OldActionId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OldActionId, &num);
		}
	}

	public unsafe int oldActionId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldActionId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldActionId)) = num;
		}
	}

	public unsafe static int MotionSpeedScaleWhenSlow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MotionSpeedScaleWhenSlow, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MotionSpeedScaleWhenSlow, &num);
		}
	}

	public unsafe static int BreastSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BreastSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BreastSize, &num);
		}
	}

	public unsafe static int AnotherMotionIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AnotherMotionIndex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AnotherMotionIndex, &num);
		}
	}

	public unsafe static int IsEcstasy
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsEcstasy, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsEcstasy, &num);
		}
	}

	public unsafe static int FutanariSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FutanariSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FutanariSize, &num);
		}
	}

	public unsafe static int MotionSpeedScale
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MotionSpeedScale, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MotionSpeedScale, &num);
		}
	}

	public unsafe static int PreviewNakedArmPose
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PreviewNakedArmPose, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PreviewNakedArmPose, &num);
		}
	}

	public unsafe static int WalkSpeedScale
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WalkSpeedScale, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WalkSpeedScale, &num);
		}
	}

	public unsafe float TargetMoveSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetMoveSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetMoveSpeed_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float TargetClothesStateABlend
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetClothesStateABlend_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetClothesStateABlend_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float TargetCoatStateBBlend
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetCoatStateBBlend_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetCoatStateBBlend_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float TargetArmLayerWeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetArmLayerWeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetArmLayerWeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsForceHeadLayerWeight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsForceHeadLayerWeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsForceHeadLayerWeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50327, RefRangeEnd = 50328, XrefRangeStart = 50200, XrefRangeEnd = 50327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate([DefaultParameterValue(null)] InputData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetMoveSpeed([DefaultParameterValue(null)] float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMoveSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50328, XrefRangeEnd = 50338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateHandcuffsWeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateHandcuffsWeight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50338, XrefRangeEnd = 50352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DirectDropClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectDropClothes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50352, XrefRangeEnd = 50361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DirectNoHip()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectNoHip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 50370, RefRangeEnd = 50374, XrefRangeStart = 50361, XrefRangeEnd = 50370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceSetClothesStateBlend([DefaultParameterValue(null)] PlayerStateModel.ClothesState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Void_ClothesState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50374, XrefRangeEnd = 50383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHeadHeight([DefaultParameterValue(null)] float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&height);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeadHeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50383, XrefRangeEnd = 50392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMotionSpeedScale([DefaultParameterValue(null)] float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&scale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMotionSpeedScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50392, XrefRangeEnd = 50401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFutanariSize([DefaultParameterValue(null)] float size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFutanariSize_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50406, RefRangeEnd = 50408, XrefRangeStart = 50401, XrefRangeEnd = 50406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStrafe([DefaultParameterValue(null)] bool isStrafe, [DefaultParameterValue(null)] bool isDash, [DefaultParameterValue(null)] float strafeX, [DefaultParameterValue(null)] float strafeY)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&isStrafe);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isDash;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &strafeX;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &strafeY;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStrafe_Public_Void_Boolean_Boolean_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50420, RefRangeEnd = 50422, XrefRangeStart = 50408, XrefRangeEnd = 50420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransAction([DefaultParameterValue(null)] ActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50422, XrefRangeEnd = 50431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransBaretaEscape()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransBaretaEscape_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50431, XrefRangeEnd = 50440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransEcstasy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransEcstasy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50446, RefRangeEnd = 50448, XrefRangeStart = 50440, XrefRangeEnd = 50446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEcstasy([DefaultParameterValue(null)] bool isEcstasy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isEcstasy);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetEcstasy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 50454, RefRangeEnd = 50458, XrefRangeStart = 50448, XrefRangeEnd = 50454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreviewNakedArmPose([DefaultParameterValue(null)] bool isNaked)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isNaked);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreviewNakedArmPose_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetArmPulse()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetArmPulse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 50464, RefRangeEnd = 50467, XrefRangeStart = 50458, XrefRangeEnd = 50464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBareta([DefaultParameterValue(null)] bool isBareta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isBareta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBareta_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 50473, RefRangeEnd = 50476, XrefRangeStart = 50467, XrefRangeEnd = 50473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBaretaFace([DefaultParameterValue(null)] bool isBareta)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isBareta);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBaretaFace_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50482, RefRangeEnd = 50484, XrefRangeStart = 50476, XrefRangeEnd = 50482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHadBasket([DefaultParameterValue(null)] bool hadBasket)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hadBasket);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 50490, RefRangeEnd = 50494, XrefRangeStart = 50484, XrefRangeEnd = 50490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHoldInHand([DefaultParameterValue(null)] bool holdInHand)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&holdInHand);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHoldInHand_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50500, RefRangeEnd = 50502, XrefRangeStart = 50494, XrefRangeEnd = 50500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHandcuffs([DefaultParameterValue(null)] bool isHandcuffs)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isHandcuffs);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHandcuffs_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 50507, RefRangeEnd = 50509, XrefRangeStart = 50502, XrefRangeEnd = 50507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetGamanBaibu([DefaultParameterValue(null)] bool isGamanBaibu)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isGamanBaibu);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetGamanBaibu_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50509, XrefRangeEnd = 50525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHip([DefaultParameterValue(null)] bool isOpenAction)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isOpenAction);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHip_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetFaceLayerWeight([DefaultParameterValue(null)] float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaceLayerWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50525, XrefRangeEnd = 50526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateAnotherMotionIndex(bool isReset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isReset);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateAnotherMotionIndex_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 50526, XrefRangeEnd = 50527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Constant.Direct NearStrafeDirect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NearStrafeDirect_Public_Direct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Constant.Direct*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 50576, RefRangeEnd = 50577, XrefRangeStart = 50527, XrefRangeEnd = 50576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerAnimationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerAnimationManager()
	{
		Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerAnimationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr);
		NativeFieldInfoPtr_LocomotionLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "LocomotionLayer");
		NativeFieldInfoPtr_ActionLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "ActionLayer");
		NativeFieldInfoPtr_ClothesActionArmLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "ClothesActionArmLayer");
		NativeFieldInfoPtr_OverrideClothArmLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "OverrideClothArmLayer");
		NativeFieldInfoPtr_Upper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "Upper");
		NativeFieldInfoPtr_OverrideArmForHandcuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "OverrideArmForHandcuff");
		NativeFieldInfoPtr_OverrideLeftArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "OverrideLeftArm");
		NativeFieldInfoPtr_FaceLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "FaceLayer");
		NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "MoveSpeed");
		NativeFieldInfoPtr_CoatState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "CoatState");
		NativeFieldInfoPtr_HeadHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "HeadHeight");
		NativeFieldInfoPtr_IsStrafe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsStrafe");
		NativeFieldInfoPtr_StrafeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "StrafeX");
		NativeFieldInfoPtr_StrafeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "StrafeY");
		NativeFieldInfoPtr_IsCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsCrouch");
		NativeFieldInfoPtr_ActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "ActionId");
		NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "Action");
		NativeFieldInfoPtr__TargetMoveSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "<TargetMoveSpeed>k__BackingField");
		NativeFieldInfoPtr__TargetClothesStateABlend_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "<TargetClothesStateABlend>k__BackingField");
		NativeFieldInfoPtr__TargetCoatStateBBlend_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "<TargetCoatStateBBlend>k__BackingField");
		NativeFieldInfoPtr__TargetArmLayerWeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "<TargetArmLayerWeight>k__BackingField");
		NativeFieldInfoPtr__IsForceHeadLayerWeight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "<IsForceHeadLayerWeight>k__BackingField");
		NativeFieldInfoPtr_baseMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "baseMoveSpeed");
		NativeFieldInfoPtr_pulseTargetArmLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "pulseTargetArmLayerWeight");
		NativeFieldInfoPtr_isGamanBaibu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "isGamanBaibu");
		NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "animator");
		NativeFieldInfoPtr_playerStateModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "playerStateModel");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_coatStateA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "coatStateA");
		NativeFieldInfoPtr_coatStateB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "coatStateB");
		NativeFieldInfoPtr_headLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "headLayerWeight");
		NativeFieldInfoPtr_faceLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "faceLayerWeight");
		NativeFieldInfoPtr_armLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "armLayerWeight");
		NativeFieldInfoPtr_overrideArmForHandcuffLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "overrideArmForHandcuffLayerWeight");
		NativeFieldInfoPtr_overrideRightArmHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "overrideRightArmHand");
		NativeFieldInfoPtr_overrideArmLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "overrideArmLayerWeight");
		NativeFieldInfoPtr_strafeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "strafeX");
		NativeFieldInfoPtr_strafeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "strafeY");
		NativeFieldInfoPtr_dokidoki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "dokidoki");
		NativeFieldInfoPtr_moveSpeedBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "moveSpeedBlend");
		NativeFieldInfoPtr_handcaffsWeightBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "handcaffsWeightBlend");
		NativeFieldInfoPtr_anotherMotionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "anotherMotionIndex");
		NativeFieldInfoPtr_locomotionMotionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "locomotionMotionSpeed");
		NativeFieldInfoPtr_Ecstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "Ecstasy");
		NativeFieldInfoPtr_IsBareta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsBareta");
		NativeFieldInfoPtr_Dokidoki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "Dokidoki");
		NativeFieldInfoPtr_HadBasket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "HadBasket");
		NativeFieldInfoPtr_DownHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "DownHip");
		NativeFieldInfoPtr_OpenHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "OpenHip");
		NativeFieldInfoPtr_CoatStateB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "CoatStateB");
		NativeFieldInfoPtr_HoldInHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "HoldInHand");
		NativeFieldInfoPtr_BaretaEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "BaretaEscape");
		NativeFieldInfoPtr_IsHandcuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsHandcuffs");
		NativeFieldInfoPtr_IsGamanBaibu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsGamanBaibu");
		NativeFieldInfoPtr_HandcuffsWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "HandcuffsWeight");
		NativeFieldInfoPtr_DropClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "DropClothes");
		NativeFieldInfoPtr_NoHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "NoHip");
		NativeFieldInfoPtr_BaretaFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "BaretaFace");
		NativeFieldInfoPtr_LocomotionMotionSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "LocomotionMotionSpeed");
		NativeFieldInfoPtr_PlayerEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "PlayerEcstasy");
		NativeFieldInfoPtr_OldActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "OldActionId");
		NativeFieldInfoPtr_oldActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "oldActionId");
		NativeFieldInfoPtr_MotionSpeedScaleWhenSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "MotionSpeedScaleWhenSlow");
		NativeFieldInfoPtr_BreastSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "BreastSize");
		NativeFieldInfoPtr_AnotherMotionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "AnotherMotionIndex");
		NativeFieldInfoPtr_IsEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "IsEcstasy");
		NativeFieldInfoPtr_FutanariSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "FutanariSize");
		NativeFieldInfoPtr_MotionSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "MotionSpeedScale");
		NativeFieldInfoPtr_PreviewNakedArmPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "PreviewNakedArmPose");
		NativeFieldInfoPtr_WalkSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, "WalkSpeedScale");
		NativeMethodInfoPtr_get_TargetMoveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666472);
		NativeMethodInfoPtr_set_TargetMoveSpeed_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666473);
		NativeMethodInfoPtr_get_TargetClothesStateABlend_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666474);
		NativeMethodInfoPtr_set_TargetClothesStateABlend_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666475);
		NativeMethodInfoPtr_get_TargetCoatStateBBlend_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666476);
		NativeMethodInfoPtr_set_TargetCoatStateBBlend_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666477);
		NativeMethodInfoPtr_get_TargetArmLayerWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666478);
		NativeMethodInfoPtr_set_TargetArmLayerWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666479);
		NativeMethodInfoPtr_get_IsForceHeadLayerWeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666480);
		NativeMethodInfoPtr_set_IsForceHeadLayerWeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666481);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666482);
		NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666483);
		NativeMethodInfoPtr_SetMoveSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666484);
		NativeMethodInfoPtr_UpdateHandcuffsWeight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666485);
		NativeMethodInfoPtr_DirectDropClothes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666486);
		NativeMethodInfoPtr_DirectNoHip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666487);
		NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666488);
		NativeMethodInfoPtr_SetHeadHeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666489);
		NativeMethodInfoPtr_SetMotionSpeedScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666490);
		NativeMethodInfoPtr_SetFutanariSize_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666491);
		NativeMethodInfoPtr_SetStrafe_Public_Void_Boolean_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666492);
		NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666493);
		NativeMethodInfoPtr_TransBaretaEscape_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666494);
		NativeMethodInfoPtr_TransEcstasy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666495);
		NativeMethodInfoPtr_SetEcstasy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666496);
		NativeMethodInfoPtr_SetPreviewNakedArmPose_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666497);
		NativeMethodInfoPtr_SetArmPulse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666498);
		NativeMethodInfoPtr_SetBareta_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666499);
		NativeMethodInfoPtr_SetBaretaFace_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666500);
		NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666501);
		NativeMethodInfoPtr_SetHoldInHand_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666502);
		NativeMethodInfoPtr_SetHandcuffs_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666503);
		NativeMethodInfoPtr_SetGamanBaibu_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666504);
		NativeMethodInfoPtr_SetHip_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666505);
		NativeMethodInfoPtr_SetFaceLayerWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666506);
		NativeMethodInfoPtr_RotateAnotherMotionIndex_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666507);
		NativeMethodInfoPtr_NearStrafeDirect_Public_Direct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666508);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationManager>.NativeClassPtr, 100666509);
	}

	public PlayerAnimationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
