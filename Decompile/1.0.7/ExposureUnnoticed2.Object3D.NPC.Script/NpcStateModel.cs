using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Object3D.ForeignObject;
using ExposureUnnoticed2.Object3D.NPC.Script.State;
using ExposureUnnoticed2.Object3D.RoutePoint;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcStateModel : Il2CppSystem.Object
{
	public enum State
	{
		Idle,
		FoundStranger,
		TurnAround,
		FadeOut,
		Stagger,
		Interact,
		WaitToken,
		TraceSexPlayer
	}

	public enum FixedType
	{
		None,
		Car,
		Talk,
		SitWork,
		SitTalk,
		SitSleep,
		SitBook,
		SitSumaho,
		StandSumaho,
		Pinpon,
		Conbini
	}

	public enum ForeignObjectLookerType
	{
		Idle,
		InFacial,
		CoolDown
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_BeforeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsComeBackInteractFromFoundStranger;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAlreadyFoundStranger;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsPolice;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSit;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSitInverse;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDestroy;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFemale;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSkipUpdateStrangeness;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnorePlayerNoisyTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_stateInTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeedScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsRiseStrangeFromOnlyDiscomfort;

	private static readonly System.IntPtr NativeFieldInfoPtr_NearNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_RouteData;

	private static readonly System.IntPtr NativeFieldInfoPtr_HasInteractToken;

	private static readonly System.IntPtr NativeFieldInfoPtr_AvatarType;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaggerBeforeState;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHeadSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsGlassees;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFixedType;

	private static readonly System.IntPtr NativeFieldInfoPtr_AvatarSizeScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_StrangeAddScaleSleep;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentRouteInteractType;

	private static readonly System.IntPtr NativeFieldInfoPtr_InSightForeignObjectList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentForeignObjectLookerType;

	private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyLookedForeignObjectSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentChairActionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHidePinponNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSkipRiseStrangenessPinponNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_RegiScanRemainNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniEndShinadashi;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniBringProductNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundCancelAreaScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsJustHitSpermOnSkin;

	private static readonly System.IntPtr NativeFieldInfoPtr_initTalkRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSpermTurn;

	private static readonly System.IntPtr NativeFieldInfoPtr_turnAroundPointInTimeStopSperm;

	private static readonly System.IntPtr NativeFieldInfoPtr_isSumahoWalk;

	private static readonly System.IntPtr NativeFieldInfoPtr_TurnNoisyLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_StrangeLookAt;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveSpermCollider;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerDist;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsJustOnEndInteract;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsJustOnEndChairSitDown;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateReset_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe State CurrentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentState)) = state;
		}
	}

	public unsafe State BeforeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeforeState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BeforeState)) = state;
		}
	}

	public unsafe bool IsComeBackInteractFromFoundStranger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsComeBackInteractFromFoundStranger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsComeBackInteractFromFoundStranger)) = flag;
		}
	}

	public unsafe bool IsAlreadyFoundStranger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAlreadyFoundStranger);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAlreadyFoundStranger)) = flag;
		}
	}

	public unsafe bool IsPolice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPolice);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPolice)) = flag;
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

	public unsafe bool IsSitInverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSitInverse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSitInverse)) = flag;
		}
	}

	public unsafe bool IsDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDestroy)) = flag;
		}
	}

	public unsafe bool isFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFemale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFemale)) = flag;
		}
	}

	public unsafe bool IsSkipUpdateStrangeness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSkipUpdateStrangeness);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSkipUpdateStrangeness)) = flag;
		}
	}

	public unsafe float IgnorePlayerNoisyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnorePlayerNoisyTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnorePlayerNoisyTime)) = num;
		}
	}

	public unsafe float stateInTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateInTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stateInTime)) = num;
		}
	}

	public unsafe float MoveSpeedScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveSpeedScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveSpeedScale)) = num;
		}
	}

	public unsafe bool IsRiseStrangeFromOnlyDiscomfort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsRiseStrangeFromOnlyDiscomfort);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsRiseStrangeFromOnlyDiscomfort)) = flag;
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

	public unsafe RouteData RouteData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RouteData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RouteData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool HasInteractToken
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasInteractToken);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HasInteractToken)) = flag;
		}
	}

	public unsafe NpcAvatarComponent.AvatarType AvatarType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarType);
			return *(NpcAvatarComponent.AvatarType*)num;
		}
		set
		{
			*(NpcAvatarComponent.AvatarType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarType)) = avatarType;
		}
	}

	public unsafe State StaggerBeforeState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaggerBeforeState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StaggerBeforeState)) = state;
		}
	}

	public unsafe bool IsHeadSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHeadSet);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHeadSet)) = flag;
		}
	}

	public unsafe bool IsGlassees
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGlassees);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsGlassees)) = flag;
		}
	}

	public unsafe FixedType CurrentFixedType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentFixedType);
			return *(FixedType*)num;
		}
		set
		{
			*(FixedType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentFixedType)) = fixedType;
		}
	}

	public unsafe float AvatarSizeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarSizeScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarSizeScale)) = num;
		}
	}

	public unsafe float StrangeAddScaleSleep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeAddScaleSleep);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeAddScaleSleep)) = num;
		}
	}

	public unsafe RouteInteractType CurrentRouteInteractType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRouteInteractType);
			return *(RouteInteractType*)num;
		}
		set
		{
			*(RouteInteractType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentRouteInteractType)) = routeInteractType;
		}
	}

	public unsafe List<ForeignObjectController> InSightForeignObjectList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InSightForeignObjectList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ForeignObjectController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InSightForeignObjectList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ForeignObjectLookerType CurrentForeignObjectLookerType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentForeignObjectLookerType);
			return *(ForeignObjectLookerType*)num;
		}
		set
		{
			*(ForeignObjectLookerType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentForeignObjectLookerType)) = foreignObjectLookerType;
		}
	}

	public unsafe HashSet<GameObject> AlreadyLookedForeignObjectSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlreadyLookedForeignObjectSet);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HashSet<GameObject>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlreadyLookedForeignObjectSet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcChairSubState.ChairActionType CurrentChairActionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentChairActionType);
			return *(NpcChairSubState.ChairActionType*)num;
		}
		set
		{
			*(NpcChairSubState.ChairActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentChairActionType)) = chairActionType;
		}
	}

	public unsafe bool IsHidePinponNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHidePinponNpc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHidePinponNpc)) = flag;
		}
	}

	public unsafe bool IsSkipRiseStrangenessPinponNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSkipRiseStrangenessPinponNpc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSkipRiseStrangenessPinponNpc)) = flag;
		}
	}

	public unsafe int RegiScanRemainNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RegiScanRemainNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RegiScanRemainNum)) = num;
		}
	}

	public unsafe bool ConbiniEndShinadashi
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniEndShinadashi);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniEndShinadashi)) = flag;
		}
	}

	public unsafe int ConbiniBringProductNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniBringProductNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniBringProductNum)) = num;
		}
	}

	public unsafe SmoothFloat SoundCancelAreaScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundCancelAreaScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundCancelAreaScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsJustHitSpermOnSkin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustHitSpermOnSkin);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustHitSpermOnSkin)) = flag;
		}
	}

	public unsafe Quaternion initTalkRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTalkRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTalkRotation)) = quaternion;
		}
	}

	public unsafe bool IgnoreSpermTurn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreSpermTurn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IgnoreSpermTurn)) = flag;
		}
	}

	public unsafe Il2CppSystem.Nullable<Vector3> turnAroundPointInTimeStopSperm
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnAroundPointInTimeStopSperm);
			return new Il2CppSystem.Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Vector3>>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_turnAroundPointInTimeStopSperm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Vector3>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool isSumahoWalk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSumahoWalk);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isSumahoWalk)) = flag;
		}
	}

	public unsafe float TurnNoisyLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnNoisyLevel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnNoisyLevel)) = num;
		}
	}

	public unsafe float StrangeLookAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeLookAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeLookAt)) = num;
		}
	}

	public unsafe bool IsActiveSpermCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveSpermCollider);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveSpermCollider)) = flag;
		}
	}

	public unsafe float PlayerDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerDist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerDist)) = num;
		}
	}

	public unsafe Vector3 CurrentPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentPosition)) = vector;
		}
	}

	public unsafe bool IsJustOnEndInteract
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustOnEndInteract);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustOnEndInteract)) = flag;
		}
	}

	public unsafe bool IsJustOnEndChairSitDown
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustOnEndChairSitDown);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsJustOnEndChairSitDown)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe void OnUpdateReset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdateReset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62885, RefRangeEnd = 62886, XrefRangeStart = 62869, XrefRangeEnd = 62885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcStateModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcStateModel()
	{
		Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcStateModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr);
		NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentState");
		NativeFieldInfoPtr_BeforeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "BeforeState");
		NativeFieldInfoPtr_IsComeBackInteractFromFoundStranger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsComeBackInteractFromFoundStranger");
		NativeFieldInfoPtr_IsAlreadyFoundStranger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsAlreadyFoundStranger");
		NativeFieldInfoPtr_IsPolice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsPolice");
		NativeFieldInfoPtr_IsSit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsSit");
		NativeFieldInfoPtr_IsSitInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsSitInverse");
		NativeFieldInfoPtr_IsDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsDestroy");
		NativeFieldInfoPtr_isFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "isFemale");
		NativeFieldInfoPtr_IsSkipUpdateStrangeness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsSkipUpdateStrangeness");
		NativeFieldInfoPtr_IgnorePlayerNoisyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IgnorePlayerNoisyTime");
		NativeFieldInfoPtr_stateInTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "stateInTime");
		NativeFieldInfoPtr_MoveSpeedScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "MoveSpeedScale");
		NativeFieldInfoPtr_IsRiseStrangeFromOnlyDiscomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsRiseStrangeFromOnlyDiscomfort");
		NativeFieldInfoPtr_NearNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "NearNpc");
		NativeFieldInfoPtr_RouteData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "RouteData");
		NativeFieldInfoPtr_HasInteractToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "HasInteractToken");
		NativeFieldInfoPtr_AvatarType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "AvatarType");
		NativeFieldInfoPtr_StaggerBeforeState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "StaggerBeforeState");
		NativeFieldInfoPtr_IsHeadSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsHeadSet");
		NativeFieldInfoPtr_IsGlassees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsGlassees");
		NativeFieldInfoPtr_CurrentFixedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentFixedType");
		NativeFieldInfoPtr_AvatarSizeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "AvatarSizeScale");
		NativeFieldInfoPtr_StrangeAddScaleSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "StrangeAddScaleSleep");
		NativeFieldInfoPtr_CurrentRouteInteractType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentRouteInteractType");
		NativeFieldInfoPtr_InSightForeignObjectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "InSightForeignObjectList");
		NativeFieldInfoPtr_CurrentForeignObjectLookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentForeignObjectLookerType");
		NativeFieldInfoPtr_AlreadyLookedForeignObjectSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "AlreadyLookedForeignObjectSet");
		NativeFieldInfoPtr_CurrentChairActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentChairActionType");
		NativeFieldInfoPtr_IsHidePinponNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsHidePinponNpc");
		NativeFieldInfoPtr_IsSkipRiseStrangenessPinponNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsSkipRiseStrangenessPinponNpc");
		NativeFieldInfoPtr_RegiScanRemainNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "RegiScanRemainNum");
		NativeFieldInfoPtr_ConbiniEndShinadashi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "ConbiniEndShinadashi");
		NativeFieldInfoPtr_ConbiniBringProductNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "ConbiniBringProductNum");
		NativeFieldInfoPtr_SoundCancelAreaScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "SoundCancelAreaScale");
		NativeFieldInfoPtr_IsJustHitSpermOnSkin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsJustHitSpermOnSkin");
		NativeFieldInfoPtr_initTalkRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "initTalkRotation");
		NativeFieldInfoPtr_IgnoreSpermTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IgnoreSpermTurn");
		NativeFieldInfoPtr_turnAroundPointInTimeStopSperm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "turnAroundPointInTimeStopSperm");
		NativeFieldInfoPtr_isSumahoWalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "isSumahoWalk");
		NativeFieldInfoPtr_TurnNoisyLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "TurnNoisyLevel");
		NativeFieldInfoPtr_StrangeLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "StrangeLookAt");
		NativeFieldInfoPtr_IsActiveSpermCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsActiveSpermCollider");
		NativeFieldInfoPtr_PlayerDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "PlayerDist");
		NativeFieldInfoPtr_CurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "CurrentPosition");
		NativeFieldInfoPtr_IsJustOnEndInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsJustOnEndInteract");
		NativeFieldInfoPtr_IsJustOnEndChairSitDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, "IsJustOnEndChairSitDown");
		NativeMethodInfoPtr_OnUpdateReset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, 100667563);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcStateModel>.NativeClassPtr, 100667564);
	}

	public NpcStateModel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
