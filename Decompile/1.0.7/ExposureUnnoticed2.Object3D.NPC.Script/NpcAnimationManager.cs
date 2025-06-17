using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Sex;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcAnimationManager : Il2CppSystem.Object
{
	public enum Layer
	{
		Locomotion,
		Action,
		OverrideAction,
		Face,
		FoundStranger
	}

	public enum FacialLayer
	{
		ForeignObject,
		AlreadyFound
	}

	[ObfuscatedName("ExposureUnnoticed2.Object3D.NPC.Script.NpcAnimationManager/<>c__DisplayClass51_0")]
	public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_nca;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0;

		public unsafe NpcComponentAccessor nca
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass51_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60344, XrefRangeEnd = 60355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass51_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "<>c__DisplayClass51_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr);
			NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, "nca");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100667350);
			NativeMethodInfoPtr__Initialize_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass51_0>.NativeClassPtr, 100667351);
		}

		public __c__DisplayClass51_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeFieldInfoPtr_animator;

	private static readonly System.IntPtr NativeFieldInfoPtr_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_overrideActionLayerWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastSetSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_faceContemptLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_Speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Stagger;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaggerX;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaggerY;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuyMachine;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFemale;

	private static readonly System.IntPtr NativeFieldInfoPtr_Wait;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcTalk1;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcTalk2;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFoundStranger;

	private static readonly System.IntPtr NativeFieldInfoPtr_SitSleep;

	private static readonly System.IntPtr NativeFieldInfoPtr_SitBook;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAwake;

	private static readonly System.IntPtr NativeFieldInfoPtr_SitSumaho;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSit;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChairSitDown;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChairStandUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_StandSmartphone;

	private static readonly System.IntPtr NativeFieldInfoPtr_NoAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFaceContempt;

	private static readonly System.IntPtr NativeFieldInfoPtr_Pinpon;

	private static readonly System.IntPtr NativeFieldInfoPtr_PinponClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsMirror;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniStand;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniShinadashi;

	private static readonly System.IntPtr NativeFieldInfoPtr_RegiScan;

	private static readonly System.IntPtr NativeFieldInfoPtr_UsePost;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsWorry;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConbiniTakeGoods;

	private static readonly System.IntPtr NativeFieldInfoPtr_HandOver;

	private static readonly System.IntPtr NativeFieldInfoPtr_MalePeeing;

	private static readonly System.IntPtr NativeFieldInfoPtr_HandWash;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenToiletDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CloseToiletDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenOutsideToiletDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_OpenInsideToiletDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseWasher;

	private static readonly System.IntPtr NativeFieldInfoPtr_OverrideIdle;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExitActionState;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSumahoWalk;

	private static readonly System.IntPtr NativeFieldInfoPtr_SexId;

	private static readonly System.IntPtr NativeFieldInfoPtr_Sex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransSex_Public_Void_RSex_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStagger_Public_Void_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceExitActionState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBuyMachine_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUsePost_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetUseWasher_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHandOver_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMalePeeing_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHandWash_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetStandSmartphone_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConbiniTakeGoods_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNoAction_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWait_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOverrideIdle_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsWorry_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentMoveSpeed_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNpcTalk_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFoundStranger_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSitSleep_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSleepAwake_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSitBook_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSitSumaho_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetIsSit_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChairSitDown_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetChairStandUp_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPinpon_Public_Void_Boolean_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceContempt_Public_Void_Boolean_FacialLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConbiniCrouch_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConbiniStand_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConbiniShinadashi_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetConbiniRegiScan_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOpenToiletDoorFromOutside_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetOpenToiletDoorFromInside_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCloseToiletDoor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ForceExitActionState_b__55_0_Private_Void_0;

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe SmoothFloat speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_speed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat overrideActionLayerWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideActionLayerWeight);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overrideActionLayerWeight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float lastSetSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSetSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastSetSpeed)) = num;
		}
	}

	public unsafe Dictionary<FacialLayer, bool> faceContemptLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceContemptLayers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<FacialLayer, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceContemptLayers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int Speed
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Speed, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Speed, &num);
		}
	}

	public unsafe static int Stagger
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Stagger, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Stagger, &num);
		}
	}

	public unsafe static int StaggerX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StaggerX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StaggerX, &num);
		}
	}

	public unsafe static int StaggerY
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StaggerY, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StaggerY, &num);
		}
	}

	public unsafe static int BuyMachine
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BuyMachine, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BuyMachine, &num);
		}
	}

	public unsafe static int IsFemale
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsFemale, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsFemale, &num);
		}
	}

	public unsafe static int Wait
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Wait, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Wait, &num);
		}
	}

	public unsafe static int NpcTalk1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcTalk1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcTalk1, &num);
		}
	}

	public unsafe static int NpcTalk2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NpcTalk2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NpcTalk2, &num);
		}
	}

	public unsafe static int IsFoundStranger
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsFoundStranger, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsFoundStranger, &num);
		}
	}

	public unsafe static int SitSleep
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SitSleep, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SitSleep, &num);
		}
	}

	public unsafe static int SitBook
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SitBook, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SitBook, &num);
		}
	}

	public unsafe static int IsAwake
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsAwake, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsAwake, &num);
		}
	}

	public unsafe static int SitSumaho
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SitSumaho, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SitSumaho, &num);
		}
	}

	public unsafe static int IsSit
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSit, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSit, &num);
		}
	}

	public unsafe static int ChairSitDown
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChairSitDown, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChairSitDown, &num);
		}
	}

	public unsafe static int ChairStandUp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChairStandUp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChairStandUp, &num);
		}
	}

	public unsafe static int StandSmartphone
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StandSmartphone, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StandSmartphone, &num);
		}
	}

	public unsafe static int NoAction
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoAction, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoAction, &num);
		}
	}

	public unsafe static int IsFaceContempt
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsFaceContempt, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsFaceContempt, &num);
		}
	}

	public unsafe static int Pinpon
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Pinpon, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Pinpon, &num);
		}
	}

	public unsafe static int PinponClose
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PinponClose, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PinponClose, &num);
		}
	}

	public unsafe static int IsMirror
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsMirror, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsMirror, &num);
		}
	}

	public unsafe static int ConbiniCrouch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConbiniCrouch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConbiniCrouch, &num);
		}
	}

	public unsafe static int ConbiniStand
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConbiniStand, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConbiniStand, &num);
		}
	}

	public unsafe static int ConbiniShinadashi
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConbiniShinadashi, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConbiniShinadashi, &num);
		}
	}

	public unsafe static int RegiScan
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RegiScan, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RegiScan, &num);
		}
	}

	public unsafe static int UsePost
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UsePost, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UsePost, &num);
		}
	}

	public unsafe static int IsWorry
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsWorry, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsWorry, &num);
		}
	}

	public unsafe static int ConbiniTakeGoods
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConbiniTakeGoods, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConbiniTakeGoods, &num);
		}
	}

	public unsafe static int HandOver
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HandOver, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HandOver, &num);
		}
	}

	public unsafe static int MalePeeing
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MalePeeing, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MalePeeing, &num);
		}
	}

	public unsafe static int HandWash
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HandWash, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HandWash, &num);
		}
	}

	public unsafe static int OpenToiletDoor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenToiletDoor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenToiletDoor, &num);
		}
	}

	public unsafe static int CloseToiletDoor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CloseToiletDoor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CloseToiletDoor, &num);
		}
	}

	public unsafe static int OpenOutsideToiletDoor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenOutsideToiletDoor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenOutsideToiletDoor, &num);
		}
	}

	public unsafe static int OpenInsideToiletDoor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OpenInsideToiletDoor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OpenInsideToiletDoor, &num);
		}
	}

	public unsafe static int UseWasher
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UseWasher, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UseWasher, &num);
		}
	}

	public unsafe static int OverrideIdle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OverrideIdle, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OverrideIdle, &num);
		}
	}

	public unsafe static int ExitActionState
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExitActionState, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExitActionState, &num);
		}
	}

	public unsafe static int IsSumahoWalk
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSumahoWalk, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSumahoWalk, &num);
		}
	}

	public unsafe static int SexId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SexId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SexId, &num);
		}
	}

	public unsafe static int Sex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Sex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Sex, &num);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60404, RefRangeEnd = 60405, XrefRangeStart = 60355, XrefRangeEnd = 60404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60436, RefRangeEnd = 60437, XrefRangeStart = 60405, XrefRangeEnd = 60436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60437, XrefRangeEnd = 60451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransSex([DefaultParameterValue(null)] RSex rSex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rSex);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransSex_Public_Void_RSex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60451, XrefRangeEnd = 60470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStagger([DefaultParameterValue(null)] Vector3 direct)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&direct);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStagger_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60470, XrefRangeEnd = 60486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceExitActionState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceExitActionState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSpeed([DefaultParameterValue(null)] float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60495, RefRangeEnd = 60497, XrefRangeStart = 60486, XrefRangeEnd = 60495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetBuyMachine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBuyMachine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60497, XrefRangeEnd = 60506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUsePost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUsePost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60515, RefRangeEnd = 60517, XrefRangeStart = 60506, XrefRangeEnd = 60515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetUseWasher()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetUseWasher_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60517, XrefRangeEnd = 60526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHandOver()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHandOver_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60532, RefRangeEnd = 60534, XrefRangeStart = 60526, XrefRangeEnd = 60532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMalePeeing([DefaultParameterValue(null)] bool isPee)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isPee);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMalePeeing_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60540, RefRangeEnd = 60542, XrefRangeStart = 60534, XrefRangeEnd = 60540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHandWash([DefaultParameterValue(null)] bool isWash)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isWash);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHandWash_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60542, XrefRangeEnd = 60551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStandSmartphone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetStandSmartphone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60551, XrefRangeEnd = 60560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConbiniTakeGoods()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConbiniTakeGoods_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60560, XrefRangeEnd = 60569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNoAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNoAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60569, XrefRangeEnd = 60575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWait([DefaultParameterValue(null)] bool isWait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isWait);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWait_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60581, RefRangeEnd = 60584, XrefRangeStart = 60575, XrefRangeEnd = 60581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOverrideIdle([DefaultParameterValue(null)] bool isWait)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isWait);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOverrideIdle_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60590, RefRangeEnd = 60593, XrefRangeStart = 60584, XrefRangeEnd = 60590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsWorry([DefaultParameterValue(null)] bool isWorry)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isWorry);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsWorry_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetCurrentMoveSpeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentMoveSpeed_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 60605, RefRangeEnd = 60609, XrefRangeStart = 60593, XrefRangeEnd = 60605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetNpcTalk([DefaultParameterValue(null)] int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetNpcTalk_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60615, RefRangeEnd = 60618, XrefRangeStart = 60609, XrefRangeEnd = 60615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFoundStranger([DefaultParameterValue(null)] bool isFound)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isFound);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFoundStranger_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60627, RefRangeEnd = 60628, XrefRangeStart = 60618, XrefRangeEnd = 60627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSitSleep()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSitSleep_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60634, RefRangeEnd = 60635, XrefRangeStart = 60628, XrefRangeEnd = 60634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSleepAwake([DefaultParameterValue(null)] bool isAwake)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isAwake);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSleepAwake_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60644, RefRangeEnd = 60646, XrefRangeStart = 60635, XrefRangeEnd = 60644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSitBook()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSitBook_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60655, RefRangeEnd = 60658, XrefRangeStart = 60646, XrefRangeEnd = 60655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSitSumaho()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSitSumaho_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 60664, RefRangeEnd = 60673, XrefRangeStart = 60658, XrefRangeEnd = 60664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsSit([DefaultParameterValue(null)] bool isSIt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSIt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetIsSit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60682, RefRangeEnd = 60685, XrefRangeStart = 60673, XrefRangeEnd = 60682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChairSitDown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChairSitDown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60694, RefRangeEnd = 60697, XrefRangeStart = 60685, XrefRangeEnd = 60694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetChairStandUp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetChairStandUp_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60697, XrefRangeEnd = 60712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPinpon([DefaultParameterValue(null)] bool isOpen, [DefaultParameterValue(null)] float animSpeed, [DefaultParameterValue(null)] bool isMirror)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isOpen);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &animSpeed;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isMirror;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPinpon_Public_Void_Boolean_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60715, RefRangeEnd = 60718, XrefRangeStart = 60712, XrefRangeEnd = 60715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFaceContempt([DefaultParameterValue(null)] bool isActive, [DefaultParameterValue(null)] FacialLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isActive);
		*(FacialLayer**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaceContempt_Public_Void_Boolean_FacialLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60718, XrefRangeEnd = 60727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConbiniCrouch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConbiniCrouch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60727, XrefRangeEnd = 60736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConbiniStand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConbiniStand_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60736, XrefRangeEnd = 60745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConbiniShinadashi()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConbiniShinadashi_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 60751, RefRangeEnd = 60753, XrefRangeStart = 60745, XrefRangeEnd = 60751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetConbiniRegiScan([DefaultParameterValue(null)] bool isScan)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isScan);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetConbiniRegiScan_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetOpenToiletDoorFromOutside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOpenToiletDoorFromOutside_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetOpenToiletDoorFromInside()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOpenToiletDoorFromInside_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetCloseToiletDoor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCloseToiletDoor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60766, RefRangeEnd = 60767, XrefRangeStart = 60753, XrefRangeEnd = 60766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcAnimationManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60767, XrefRangeEnd = 60776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ForceExitActionState_b__55_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ForceExitActionState_b__55_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcAnimationManager()
	{
		Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcAnimationManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr);
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "animator");
		NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "speed");
		NativeFieldInfoPtr_overrideActionLayerWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "overrideActionLayerWeight");
		NativeFieldInfoPtr_lastSetSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "lastSetSpeed");
		NativeFieldInfoPtr_faceContemptLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "faceContemptLayers");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_Stagger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "Stagger");
		NativeFieldInfoPtr_StaggerX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "StaggerX");
		NativeFieldInfoPtr_StaggerY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "StaggerY");
		NativeFieldInfoPtr_BuyMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "BuyMachine");
		NativeFieldInfoPtr_IsFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsFemale");
		NativeFieldInfoPtr_Wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "Wait");
		NativeFieldInfoPtr_NpcTalk1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "NpcTalk1");
		NativeFieldInfoPtr_NpcTalk2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "NpcTalk2");
		NativeFieldInfoPtr_IsFoundStranger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsFoundStranger");
		NativeFieldInfoPtr_SitSleep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "SitSleep");
		NativeFieldInfoPtr_SitBook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "SitBook");
		NativeFieldInfoPtr_IsAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsAwake");
		NativeFieldInfoPtr_SitSumaho = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "SitSumaho");
		NativeFieldInfoPtr_IsSit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsSit");
		NativeFieldInfoPtr_ChairSitDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ChairSitDown");
		NativeFieldInfoPtr_ChairStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ChairStandUp");
		NativeFieldInfoPtr_StandSmartphone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "StandSmartphone");
		NativeFieldInfoPtr_NoAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "NoAction");
		NativeFieldInfoPtr_IsFaceContempt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsFaceContempt");
		NativeFieldInfoPtr_Pinpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "Pinpon");
		NativeFieldInfoPtr_PinponClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "PinponClose");
		NativeFieldInfoPtr_IsMirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsMirror");
		NativeFieldInfoPtr_ConbiniCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ConbiniCrouch");
		NativeFieldInfoPtr_ConbiniStand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ConbiniStand");
		NativeFieldInfoPtr_ConbiniShinadashi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ConbiniShinadashi");
		NativeFieldInfoPtr_RegiScan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "RegiScan");
		NativeFieldInfoPtr_UsePost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "UsePost");
		NativeFieldInfoPtr_IsWorry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsWorry");
		NativeFieldInfoPtr_ConbiniTakeGoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ConbiniTakeGoods");
		NativeFieldInfoPtr_HandOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "HandOver");
		NativeFieldInfoPtr_MalePeeing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "MalePeeing");
		NativeFieldInfoPtr_HandWash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "HandWash");
		NativeFieldInfoPtr_OpenToiletDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "OpenToiletDoor");
		NativeFieldInfoPtr_CloseToiletDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "CloseToiletDoor");
		NativeFieldInfoPtr_OpenOutsideToiletDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "OpenOutsideToiletDoor");
		NativeFieldInfoPtr_OpenInsideToiletDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "OpenInsideToiletDoor");
		NativeFieldInfoPtr_UseWasher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "UseWasher");
		NativeFieldInfoPtr_OverrideIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "OverrideIdle");
		NativeFieldInfoPtr_ExitActionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "ExitActionState");
		NativeFieldInfoPtr_IsSumahoWalk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "IsSumahoWalk");
		NativeFieldInfoPtr_SexId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "SexId");
		NativeFieldInfoPtr_Sex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, "Sex");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667310);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667311);
		NativeMethodInfoPtr_TransSex_Public_Void_RSex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667312);
		NativeMethodInfoPtr_SetStagger_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667313);
		NativeMethodInfoPtr_ForceExitActionState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667314);
		NativeMethodInfoPtr_SetSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667315);
		NativeMethodInfoPtr_SetBuyMachine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667316);
		NativeMethodInfoPtr_SetUsePost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667317);
		NativeMethodInfoPtr_SetUseWasher_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667318);
		NativeMethodInfoPtr_SetHandOver_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667319);
		NativeMethodInfoPtr_SetMalePeeing_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667320);
		NativeMethodInfoPtr_SetHandWash_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667321);
		NativeMethodInfoPtr_SetStandSmartphone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667322);
		NativeMethodInfoPtr_SetConbiniTakeGoods_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667323);
		NativeMethodInfoPtr_SetNoAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667324);
		NativeMethodInfoPtr_SetWait_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667325);
		NativeMethodInfoPtr_SetOverrideIdle_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667326);
		NativeMethodInfoPtr_SetIsWorry_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667327);
		NativeMethodInfoPtr_GetCurrentMoveSpeed_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667328);
		NativeMethodInfoPtr_SetNpcTalk_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667329);
		NativeMethodInfoPtr_SetFoundStranger_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667330);
		NativeMethodInfoPtr_SetSitSleep_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667331);
		NativeMethodInfoPtr_SetSleepAwake_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667332);
		NativeMethodInfoPtr_SetSitBook_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667333);
		NativeMethodInfoPtr_SetSitSumaho_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667334);
		NativeMethodInfoPtr_SetIsSit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667335);
		NativeMethodInfoPtr_SetChairSitDown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667336);
		NativeMethodInfoPtr_SetChairStandUp_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667337);
		NativeMethodInfoPtr_SetPinpon_Public_Void_Boolean_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667338);
		NativeMethodInfoPtr_SetFaceContempt_Public_Void_Boolean_FacialLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667339);
		NativeMethodInfoPtr_SetConbiniCrouch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667340);
		NativeMethodInfoPtr_SetConbiniStand_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667341);
		NativeMethodInfoPtr_SetConbiniShinadashi_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667342);
		NativeMethodInfoPtr_SetConbiniRegiScan_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667343);
		NativeMethodInfoPtr_SetOpenToiletDoorFromOutside_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667344);
		NativeMethodInfoPtr_SetOpenToiletDoorFromInside_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667345);
		NativeMethodInfoPtr_SetCloseToiletDoor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667346);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667347);
		NativeMethodInfoPtr__ForceExitActionState_b__55_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimationManager>.NativeClassPtr, 100667349);
	}

	public NpcAnimationManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
