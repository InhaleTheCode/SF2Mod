using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script.State;
using ExposureUnnoticed2.Object3D.NPC.Script.State.Toilet;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AI;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcComponentAccessor : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Transform_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__GameObject_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcLocomotion_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NavAgent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AudioSource_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__StateModel_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__LookAtController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcComponent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcMiscController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__StrangenessManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__PlayerSearcher_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Player_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcTurnAroundState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CapsuleCollider_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcAnimatorFpsController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Animator_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AnimationEventReceiver_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcAnimationManager_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Rigidbody_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcCollider_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcStaggerState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AvatarComponent_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcCollisionCorrecter_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcInteractState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcSoundController_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcWaitTokenState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcAvatarSelector_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcSleepFixState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcChairSubState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcToiletSubState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcElevatorSubState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcForeignObjectLooker_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcFashionRoomSubState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcLaundrySubState_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__NpcTraceSexPlayerState_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Transform_Public_get_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcLocomotion_Public_get_NpcLocomotion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NavAgent_Public_get_NavMeshAgent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AudioSource_Public_get_AudioSource_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StateModel_Public_get_NpcStateModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LookAtController_Public_get_LookAtController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcComponent_Public_get_NpcComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcMiscController_Public_get_NpcMiscController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_StrangenessManager_Public_get_NpcStrangenessManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerSearcher_Public_get_PlayerSearcher_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcTurnAroundState_Public_get_NpcTurnAroundState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CapsuleCollider_Public_get_CapsuleCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcAnimatorFpsController_Public_get_NpcAnimatorFpsController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Animator_Public_get_Animator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AnimationEventReceiver_Public_get_NpcAnimationEventReceiver_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcAnimationManager_Public_get_NpcAnimationManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcCollider_Public_get_NpcCollider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcStaggerState_Public_get_NpcStaggerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AvatarComponent_Public_get_NpcAvatarComponent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcCollisionCorrecter_Public_get_NpcCollisionCorrecter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcInteractState_Public_get_NpcInteractState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcSoundController_Public_get_NpcSoundController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcWaitTokenState_Public_get_NpcWaitTokenState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcAvatarSelector_Public_get_NpcAvatarSelector_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcSleepFixState_Public_get_NpcSleepFixState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcChairSubState_Public_get_NpcChairSubState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcToiletSubState_Public_get_NpcToiletSubState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcElevatorSubState_Public_get_NpcElevatorSubState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcForeignObjectLooker_Public_get_NpcForeignObjectLooker_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcFashionRoomSubState_Public_get_NpcFashionRoomSubState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcLaundrySubState_Public_get_NpcLaundrySubState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_NpcTraceSexPlayerState_Public_get_NpcTraceSexPlayerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NpcController_NpcComponent_NpcStateModel_PlayerController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

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

	public unsafe NpcLocomotion _NpcLocomotion_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcLocomotion_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcLocomotion>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcLocomotion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcController _NpcController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcStateModel _StateModel_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StateModel_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStateModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StateModel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcComponent _NpcComponent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcComponent_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcComponent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcMiscController _NpcMiscController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcMiscController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcMiscController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcMiscController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcStrangenessManager _StrangenessManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StrangenessManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStrangenessManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StrangenessManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerSearcher _PlayerSearcher_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerSearcher_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSearcher>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PlayerSearcher_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcTurnAroundState _NpcTurnAroundState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcTurnAroundState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTurnAroundState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcTurnAroundState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcAnimatorFpsController _NpcAnimatorFpsController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAnimatorFpsController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimatorFpsController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAnimatorFpsController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

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

	public unsafe NpcAnimationEventReceiver _AnimationEventReceiver_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AnimationEventReceiver_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimationEventReceiver>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AnimationEventReceiver_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcAnimationManager _NpcAnimationManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAnimationManager_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimationManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAnimationManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcCollider _NpcCollider_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcCollider_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcCollider>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcCollider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcStaggerState _NpcStaggerState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcStaggerState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStaggerState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcStaggerState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcAvatarComponent _AvatarComponent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvatarComponent_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAvatarComponent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvatarComponent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcCollisionCorrecter _NpcCollisionCorrecter_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcCollisionCorrecter_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcCollisionCorrecter>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcCollisionCorrecter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcInteractState _NpcInteractState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcInteractState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcInteractState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcInteractState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcSoundController _NpcSoundController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcSoundController_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcSoundController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcSoundController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcWaitTokenState _NpcWaitTokenState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcWaitTokenState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcWaitTokenState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcWaitTokenState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcAvatarSelector _NpcAvatarSelector_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAvatarSelector_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAvatarSelector>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcAvatarSelector_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcSleepFixState _NpcSleepFixState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcSleepFixState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcSleepFixState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcSleepFixState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcChairSubState _NpcChairSubState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcChairSubState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcChairSubState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcChairSubState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcToiletSubState _NpcToiletSubState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcToiletSubState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcToiletSubState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcToiletSubState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcElevatorSubState _NpcElevatorSubState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcElevatorSubState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcElevatorSubState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcElevatorSubState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcForeignObjectLooker _NpcForeignObjectLooker_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcForeignObjectLooker_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcForeignObjectLooker>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcForeignObjectLooker_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcFashionRoomSubState _NpcFashionRoomSubState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcFashionRoomSubState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcFashionRoomSubState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcFashionRoomSubState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcLaundrySubState _NpcLaundrySubState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcLaundrySubState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcLaundrySubState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcLaundrySubState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcTraceSexPlayerState _NpcTraceSexPlayerState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcTraceSexPlayerState_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTraceSexPlayerState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcTraceSexPlayerState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Transform
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 1, XrefRangeStart = 0, XrefRangeEnd = 1, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe GameObject GameObject
	{
		[CallerCount(0)]
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

	public unsafe NpcLocomotion NpcLocomotion
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcLocomotion_Public_get_NpcLocomotion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcLocomotion>(intPtr) : null;
		}
	}

	public unsafe NavMeshAgent NavAgent
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe AudioSource AudioSource
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe NpcController NpcController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
	}

	public unsafe NpcStateModel StateModel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StateModel_Public_get_NpcStateModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStateModel>(intPtr) : null;
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

	public unsafe NpcComponent NpcComponent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcComponent_Public_get_NpcComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponent>(intPtr) : null;
		}
	}

	public unsafe NpcMiscController NpcMiscController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcMiscController_Public_get_NpcMiscController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcMiscController>(intPtr) : null;
		}
	}

	public unsafe NpcStrangenessManager StrangenessManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StrangenessManager_Public_get_NpcStrangenessManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStrangenessManager>(intPtr) : null;
		}
	}

	public unsafe PlayerSearcher PlayerSearcher
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerSearcher_Public_get_PlayerSearcher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSearcher>(intPtr) : null;
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

	public unsafe NpcTurnAroundState NpcTurnAroundState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcTurnAroundState_Public_get_NpcTurnAroundState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTurnAroundState>(intPtr) : null;
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

	public unsafe NpcAnimatorFpsController NpcAnimatorFpsController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcAnimatorFpsController_Public_get_NpcAnimatorFpsController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimatorFpsController>(intPtr) : null;
		}
	}

	public unsafe Animator Animator
	{
		[CallerCount(0)]
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

	public unsafe NpcAnimationEventReceiver AnimationEventReceiver
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AnimationEventReceiver_Public_get_NpcAnimationEventReceiver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimationEventReceiver>(intPtr) : null;
		}
	}

	public unsafe NpcAnimationManager NpcAnimationManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcAnimationManager_Public_get_NpcAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAnimationManager>(intPtr) : null;
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

	public unsafe NpcCollider NpcCollider
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcCollider_Public_get_NpcCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcCollider>(intPtr) : null;
		}
	}

	public unsafe NpcStaggerState NpcStaggerState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcStaggerState_Public_get_NpcStaggerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcStaggerState>(intPtr) : null;
		}
	}

	public unsafe NpcAvatarComponent AvatarComponent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AvatarComponent_Public_get_NpcAvatarComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAvatarComponent>(intPtr) : null;
		}
	}

	public unsafe NpcCollisionCorrecter NpcCollisionCorrecter
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcCollisionCorrecter_Public_get_NpcCollisionCorrecter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcCollisionCorrecter>(intPtr) : null;
		}
	}

	public unsafe NpcInteractState NpcInteractState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcInteractState_Public_get_NpcInteractState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcInteractState>(intPtr) : null;
		}
	}

	public unsafe NpcSoundController NpcSoundController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcSoundController_Public_get_NpcSoundController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcSoundController>(intPtr) : null;
		}
	}

	public unsafe NpcWaitTokenState NpcWaitTokenState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcWaitTokenState_Public_get_NpcWaitTokenState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcWaitTokenState>(intPtr) : null;
		}
	}

	public unsafe NpcAvatarSelector NpcAvatarSelector
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcAvatarSelector_Public_get_NpcAvatarSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcAvatarSelector>(intPtr) : null;
		}
	}

	public unsafe NpcSleepFixState NpcSleepFixState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcSleepFixState_Public_get_NpcSleepFixState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcSleepFixState>(intPtr) : null;
		}
	}

	public unsafe NpcChairSubState NpcChairSubState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcChairSubState_Public_get_NpcChairSubState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcChairSubState>(intPtr) : null;
		}
	}

	public unsafe NpcToiletSubState NpcToiletSubState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcToiletSubState_Public_get_NpcToiletSubState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcToiletSubState>(intPtr) : null;
		}
	}

	public unsafe NpcElevatorSubState NpcElevatorSubState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcElevatorSubState_Public_get_NpcElevatorSubState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcElevatorSubState>(intPtr) : null;
		}
	}

	public unsafe NpcForeignObjectLooker NpcForeignObjectLooker
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcForeignObjectLooker_Public_get_NpcForeignObjectLooker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcForeignObjectLooker>(intPtr) : null;
		}
	}

	public unsafe NpcFashionRoomSubState NpcFashionRoomSubState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcFashionRoomSubState_Public_get_NpcFashionRoomSubState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcFashionRoomSubState>(intPtr) : null;
		}
	}

	public unsafe NpcLaundrySubState NpcLaundrySubState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcLaundrySubState_Public_get_NpcLaundrySubState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcLaundrySubState>(intPtr) : null;
		}
	}

	public unsafe NpcTraceSexPlayerState NpcTraceSexPlayerState
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcTraceSexPlayerState_Public_get_NpcTraceSexPlayerState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcTraceSexPlayerState>(intPtr) : null;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61405, RefRangeEnd = 61406, XrefRangeStart = 61277, XrefRangeEnd = 61405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcComponentAccessor([DefaultParameterValue(null)] NpcController npcController, [DefaultParameterValue(null)] NpcComponent nc, [DefaultParameterValue(null)] NpcStateModel stateModel, [DefaultParameterValue(null)] PlayerController player)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcController);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(nc);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(stateModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_NpcController_NpcComponent_NpcStateModel_PlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61425, RefRangeEnd = 61426, XrefRangeStart = 61406, XrefRangeEnd = 61425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61452, RefRangeEnd = 61453, XrefRangeStart = 61426, XrefRangeEnd = 61452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcComponentAccessor()
	{
		Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcComponentAccessor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr);
		NativeFieldInfoPtr__Transform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<Transform>k__BackingField");
		NativeFieldInfoPtr__GameObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<GameObject>k__BackingField");
		NativeFieldInfoPtr__NpcLocomotion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcLocomotion>k__BackingField");
		NativeFieldInfoPtr__NavAgent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NavAgent>k__BackingField");
		NativeFieldInfoPtr__AudioSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<AudioSource>k__BackingField");
		NativeFieldInfoPtr__NpcController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcController>k__BackingField");
		NativeFieldInfoPtr__StateModel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<StateModel>k__BackingField");
		NativeFieldInfoPtr__LookAtController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<LookAtController>k__BackingField");
		NativeFieldInfoPtr__NpcComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcComponent>k__BackingField");
		NativeFieldInfoPtr__NpcMiscController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcMiscController>k__BackingField");
		NativeFieldInfoPtr__StrangenessManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<StrangenessManager>k__BackingField");
		NativeFieldInfoPtr__PlayerSearcher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<PlayerSearcher>k__BackingField");
		NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<Player>k__BackingField");
		NativeFieldInfoPtr__NpcTurnAroundState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcTurnAroundState>k__BackingField");
		NativeFieldInfoPtr__CapsuleCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<CapsuleCollider>k__BackingField");
		NativeFieldInfoPtr__NpcAnimatorFpsController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcAnimatorFpsController>k__BackingField");
		NativeFieldInfoPtr__Animator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<Animator>k__BackingField");
		NativeFieldInfoPtr__AnimationEventReceiver_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<AnimationEventReceiver>k__BackingField");
		NativeFieldInfoPtr__NpcAnimationManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcAnimationManager>k__BackingField");
		NativeFieldInfoPtr__Rigidbody_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<Rigidbody>k__BackingField");
		NativeFieldInfoPtr__NpcCollider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcCollider>k__BackingField");
		NativeFieldInfoPtr__NpcStaggerState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcStaggerState>k__BackingField");
		NativeFieldInfoPtr__AvatarComponent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<AvatarComponent>k__BackingField");
		NativeFieldInfoPtr__NpcCollisionCorrecter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcCollisionCorrecter>k__BackingField");
		NativeFieldInfoPtr__NpcInteractState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcInteractState>k__BackingField");
		NativeFieldInfoPtr__NpcSoundController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcSoundController>k__BackingField");
		NativeFieldInfoPtr__NpcWaitTokenState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcWaitTokenState>k__BackingField");
		NativeFieldInfoPtr__NpcAvatarSelector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcAvatarSelector>k__BackingField");
		NativeFieldInfoPtr__NpcSleepFixState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcSleepFixState>k__BackingField");
		NativeFieldInfoPtr__NpcChairSubState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcChairSubState>k__BackingField");
		NativeFieldInfoPtr__NpcToiletSubState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcToiletSubState>k__BackingField");
		NativeFieldInfoPtr__NpcElevatorSubState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcElevatorSubState>k__BackingField");
		NativeFieldInfoPtr__NpcForeignObjectLooker_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcForeignObjectLooker>k__BackingField");
		NativeFieldInfoPtr__NpcFashionRoomSubState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcFashionRoomSubState>k__BackingField");
		NativeFieldInfoPtr__NpcLaundrySubState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcLaundrySubState>k__BackingField");
		NativeFieldInfoPtr__NpcTraceSexPlayerState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, "<NpcTraceSexPlayerState>k__BackingField");
		NativeMethodInfoPtr_get_Transform_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667399);
		NativeMethodInfoPtr_get_GameObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667400);
		NativeMethodInfoPtr_get_NpcLocomotion_Public_get_NpcLocomotion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667401);
		NativeMethodInfoPtr_get_NavAgent_Public_get_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667402);
		NativeMethodInfoPtr_get_AudioSource_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667403);
		NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667404);
		NativeMethodInfoPtr_get_StateModel_Public_get_NpcStateModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667405);
		NativeMethodInfoPtr_get_LookAtController_Public_get_LookAtController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667406);
		NativeMethodInfoPtr_get_NpcComponent_Public_get_NpcComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667407);
		NativeMethodInfoPtr_get_NpcMiscController_Public_get_NpcMiscController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667408);
		NativeMethodInfoPtr_get_StrangenessManager_Public_get_NpcStrangenessManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667409);
		NativeMethodInfoPtr_get_PlayerSearcher_Public_get_PlayerSearcher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667410);
		NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667411);
		NativeMethodInfoPtr_get_NpcTurnAroundState_Public_get_NpcTurnAroundState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667412);
		NativeMethodInfoPtr_get_CapsuleCollider_Public_get_CapsuleCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667413);
		NativeMethodInfoPtr_get_NpcAnimatorFpsController_Public_get_NpcAnimatorFpsController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667414);
		NativeMethodInfoPtr_get_Animator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667415);
		NativeMethodInfoPtr_get_AnimationEventReceiver_Public_get_NpcAnimationEventReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667416);
		NativeMethodInfoPtr_get_NpcAnimationManager_Public_get_NpcAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667417);
		NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667418);
		NativeMethodInfoPtr_get_NpcCollider_Public_get_NpcCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667419);
		NativeMethodInfoPtr_get_NpcStaggerState_Public_get_NpcStaggerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667420);
		NativeMethodInfoPtr_get_AvatarComponent_Public_get_NpcAvatarComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667421);
		NativeMethodInfoPtr_get_NpcCollisionCorrecter_Public_get_NpcCollisionCorrecter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667422);
		NativeMethodInfoPtr_get_NpcInteractState_Public_get_NpcInteractState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667423);
		NativeMethodInfoPtr_get_NpcSoundController_Public_get_NpcSoundController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667424);
		NativeMethodInfoPtr_get_NpcWaitTokenState_Public_get_NpcWaitTokenState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667425);
		NativeMethodInfoPtr_get_NpcAvatarSelector_Public_get_NpcAvatarSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667426);
		NativeMethodInfoPtr_get_NpcSleepFixState_Public_get_NpcSleepFixState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667427);
		NativeMethodInfoPtr_get_NpcChairSubState_Public_get_NpcChairSubState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667428);
		NativeMethodInfoPtr_get_NpcToiletSubState_Public_get_NpcToiletSubState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667429);
		NativeMethodInfoPtr_get_NpcElevatorSubState_Public_get_NpcElevatorSubState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667430);
		NativeMethodInfoPtr_get_NpcForeignObjectLooker_Public_get_NpcForeignObjectLooker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667431);
		NativeMethodInfoPtr_get_NpcFashionRoomSubState_Public_get_NpcFashionRoomSubState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667432);
		NativeMethodInfoPtr_get_NpcLaundrySubState_Public_get_NpcLaundrySubState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667433);
		NativeMethodInfoPtr_get_NpcTraceSexPlayerState_Public_get_NpcTraceSexPlayerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667434);
		NativeMethodInfoPtr__ctor_Public_Void_NpcController_NpcComponent_NpcStateModel_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667435);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667436);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponentAccessor>.NativeClassPtr, 100667437);
	}

	public NpcComponentAccessor(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
