using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Resources.Master.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.Sound;

public class InGameSoundManager : MonoBehaviour
{
	public enum SeType
	{
		NoType,
		FootStepHeel,
		FootStepHeelJog,
		ClothesSound,
		ClothesDrop,
		HeartBeat,
		FootStepHeelCrouch,
		Kuchu,
		Shiofuki,
		DokinHigh,
		DokinLow,
		Ok,
		Close,
		BuyMachine1,
		BuyMachine2,
		Drink,
		PeeNormal,
		Equip,
		SleepBed,
		Failed,
		Picking,
		Unlock,
		AttachHandcuffs,
		RankUp,
		SuburbsDaytime,
		SyburbsNight,
		MyRoom,
		KillTime,
		BaibuLow,
		BaibuHigh,
		Barefoot,
		FootStepSneaker,
		BraAttach,
		BraDetach,
		PantsDetach,
		VibratorSwitch,
		Breath1,
		Breath2,
		SlowIn,
		SlowOut,
		Gogogo,
		Reinforce,
		CommonEquip,
		ShoppingMallBgm,
		Piston,
		PutDildo,
		CollectAll,
		Buy,
		UiSelect,
		UiDecide,
		UiCancel,
		UiSlideOpen,
		UiSlideClose,
		OpenDoor,
		CloseDoor,
		Pinpon,
		CarIdling,
		CarStart,
		CarStop,
		CarPass,
		BgmParkDayTime,
		BgmParkNight,
		FootStepGrass,
		FootStepGravel,
		ToiletDoorOpen,
		ToiletDoorClose,
		ToiletFutaOpen,
		ToiletFutaClose,
		FootStepMetal,
		MentalAlert,
		Drone,
		ShopDoor,
		ShoppingMallNight,
		ElevatorMove,
		ElevatorOpen,
		ElevatorClose,
		ElevatorBell,
		Regi,
		MansionPostReceiveOpen,
		MansionPostReceiveClose,
		ToiletPeeWater,
		ToiletHandWash,
		ToiletLock,
		ToiletUnlock,
		ToiletWater,
		BgmFashionShop,
		CurtainOpen,
		CurtainClose,
		WasherOpen,
		WasherClose,
		WasherStart,
		WasherLoop,
		WasherBeep,
		Syasei,
		TimeStop,
		FootStepSneakerJog,
		Rotor,
		UICompleteMission
	}

	[System.Serializable]
	public sealed class AudioData : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Clip;

		private static readonly System.IntPtr NativeFieldInfoPtr_Volume;

		public unsafe AudioClip Clip
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clip);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float Volume
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Volume);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Volume)) = num;
			}
		}

		static AudioData()
		{
			Il2CppClassPointerStore<AudioData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "AudioData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioData>.NativeClassPtr);
			NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "Clip");
			NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioData>.NativeClassPtr, "Volume");
		}

		public AudioData(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public AudioData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioData>.NativeClassPtr))
		{
		}
	}

	[ObfuscatedName("ExposureUnnoticed2.Scripts.Sound.InGameSoundManager/<>c__DisplayClass115_0")]
	public sealed class __c__DisplayClass115_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_audioSource;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__PlayOneShotAudioData_b__0_Internal_Void_0;

		public unsafe AudioSource audioSource
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_audioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass115_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70251, XrefRangeEnd = 70256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _PlayOneShotAudioData_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__PlayOneShotAudioData_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass115_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "<>c__DisplayClass115_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr);
			NativeFieldInfoPtr_audioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr, "audioSource");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr, 100668381);
			NativeMethodInfoPtr__PlayOneShotAudioData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass115_0>.NativeClassPtr, 100668382);
		}

		public __c__DisplayClass115_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepHeel;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepHeelJog;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepHeelCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepBarefootCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepSneaker;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepSneakerJog;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepGrass;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepGravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepMetal;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesSound;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesDrop;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeartBeat;

	private static readonly System.IntPtr NativeFieldInfoPtr_kuchu;

	private static readonly System.IntPtr NativeFieldInfoPtr_piston;

	private static readonly System.IntPtr NativeFieldInfoPtr_shiofuki;

	private static readonly System.IntPtr NativeFieldInfoPtr_dokinHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_dokinLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyMachine1;

	private static readonly System.IntPtr NativeFieldInfoPtr_buyMachine2;

	private static readonly System.IntPtr NativeFieldInfoPtr_drink;

	private static readonly System.IntPtr NativeFieldInfoPtr_peeNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_Equip;

	private static readonly System.IntPtr NativeFieldInfoPtr_EquipAd;

	private static readonly System.IntPtr NativeFieldInfoPtr_picking;

	private static readonly System.IntPtr NativeFieldInfoPtr_attackHandcuffs;

	private static readonly System.IntPtr NativeFieldInfoPtr_unlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_braAttach;

	private static readonly System.IntPtr NativeFieldInfoPtr_braDetach;

	private static readonly System.IntPtr NativeFieldInfoPtr_pantsDetach;

	private static readonly System.IntPtr NativeFieldInfoPtr_vibratorSwitch;

	private static readonly System.IntPtr NativeFieldInfoPtr_breath1;

	private static readonly System.IntPtr NativeFieldInfoPtr_breath2;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowIn;

	private static readonly System.IntPtr NativeFieldInfoPtr_slowOut;

	private static readonly System.IntPtr NativeFieldInfoPtr_gogogo;

	private static readonly System.IntPtr NativeFieldInfoPtr_reinforce;

	private static readonly System.IntPtr NativeFieldInfoPtr_commonEquip;

	private static readonly System.IntPtr NativeFieldInfoPtr_putDildo;

	private static readonly System.IntPtr NativeFieldInfoPtr_openDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_closeDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_pinpon;

	private static readonly System.IntPtr NativeFieldInfoPtr_carIdling;

	private static readonly System.IntPtr NativeFieldInfoPtr_carStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_carStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_carPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_mentalAlert;

	private static readonly System.IntPtr NativeFieldInfoPtr_Drone;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShopDoor;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevatorMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevatorOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevatorClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevatorBell;

	private static readonly System.IntPtr NativeFieldInfoPtr_regi;

	private static readonly System.IntPtr NativeFieldInfoPtr_MansionPostReceiveOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_MansionPostReceiveClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasherOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasherClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasherStart;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasherLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_WasherBeep;

	private static readonly System.IntPtr NativeFieldInfoPtr_Syasei;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_baibuLow;

	private static readonly System.IntPtr NativeFieldInfoPtr_baibuHigh;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotor;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletDoorOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletDoorClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletFutaOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletFutaClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletPeeWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletHandWash;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletUnlock;

	private static readonly System.IntPtr NativeFieldInfoPtr_ToiletWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurtainOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurtainClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_sleepBed;

	private static readonly System.IntPtr NativeFieldInfoPtr_Failed;

	private static readonly System.IntPtr NativeFieldInfoPtr_RankUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_KillTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_collectAll;

	private static readonly System.IntPtr NativeFieldInfoPtr_suburbsDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_suburbsNight;

	private static readonly System.IntPtr NativeFieldInfoPtr_parkDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_parkNight;

	private static readonly System.IntPtr NativeFieldInfoPtr_myRoom;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoppingMallBgm;

	private static readonly System.IntPtr NativeFieldInfoPtr_shoppingMallBgmNight;

	private static readonly System.IntPtr NativeFieldInfoPtr_bgmFashionShop;

	private static readonly System.IntPtr NativeFieldInfoPtr_Select;

	private static readonly System.IntPtr NativeFieldInfoPtr_Decide;

	private static readonly System.IntPtr NativeFieldInfoPtr_Cancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_Buy;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlideOpen;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlideClose;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompleteMission;

	private static readonly System.IntPtr NativeFieldInfoPtr_FootSes;

	private static readonly System.IntPtr NativeFieldInfoPtr_GroupSes;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepHeelJogGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepHeelCrouchGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepBarefootCrouchGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepSneakerGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepSneakerJogGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepGrassGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepGravelGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_footStepMetalGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_kuchuGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_pistonGroup;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGroupSe_Public_Boolean_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsFootSe_Public_Boolean_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAudioData_Public_AudioData_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlayOneShotAudioData_Public_Void_AudioSource_SeType_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static InGameSoundManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InGameSoundManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepHeel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepHeelJog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelJog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelJog), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepHeelCrouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelCrouch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelCrouch), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepBarefootCrouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepBarefootCrouch);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepBarefootCrouch), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepSneaker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneaker);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneaker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepSneakerJog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerJog);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerJog), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepGrass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGrass);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGrass), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepGravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGravel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGravel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> footStepMetal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepMetal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepMetal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip ClothesSound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesSound);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesSound), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip ClothesDrop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDrop);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDrop), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> HeartBeat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeat), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> kuchu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kuchu);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kuchu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<AudioClip> piston
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piston);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_piston), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip shiofuki
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiofuki);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shiofuki), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip dokinHigh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokinHigh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokinHigh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip dokinLow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokinLow);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dokinLow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip buyMachine1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyMachine1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyMachine1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip buyMachine2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyMachine2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buyMachine2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip drink
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drink);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_drink), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip peeNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_peeNormal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioClip Equip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Equip);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Equip), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioData EquipAd
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquipAd);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquipAd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData picking
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_picking);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_picking), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData attackHandcuffs
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackHandcuffs);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_attackHandcuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData unlock
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlock);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_unlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData braAttach
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braAttach);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braAttach), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData braDetach
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braDetach);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_braDetach), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData pantsDetach
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pantsDetach);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pantsDetach), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData vibratorSwitch
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibratorSwitch);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vibratorSwitch), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData breath1
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath1);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData breath2
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath2);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_breath2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData slowIn
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowIn);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowIn), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData slowOut
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowOut);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowOut), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData gogogo
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gogogo);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gogogo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData reinforce
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reinforce);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reinforce), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData commonEquip
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonEquip);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonEquip), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData putDildo
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDildo);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_putDildo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData openDoor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoor);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_openDoor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData closeDoor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoor);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closeDoor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData pinpon
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinpon);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinpon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData carIdling
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carIdling);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carIdling), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData carStart
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carStart);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData carStop
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carStop);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carStop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData carPass
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPass);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_carPass), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData mentalAlert
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mentalAlert);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mentalAlert), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Drone
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Drone);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Drone), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ShopDoor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopDoor);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShopDoor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData elevatorMove
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorMove);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorMove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData elevatorOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData elevatorClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData elevatorBell
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorBell);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorBell), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData regi
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regi);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regi), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData MansionPostReceiveOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MansionPostReceiveOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MansionPostReceiveOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData MansionPostReceiveClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MansionPostReceiveClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MansionPostReceiveClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData WasherOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData WasherClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData WasherStart
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherStart);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherStart), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData WasherLoop
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherLoop);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherLoop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData WasherBeep
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherBeep);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WasherBeep), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Syasei
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Syasei);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Syasei), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData TimeStop
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeStop);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TimeStop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData baibuLow
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baibuLow);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baibuLow), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData baibuHigh
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baibuHigh);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baibuHigh), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData rotor
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotor);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletDoorOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletDoorOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletDoorOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletDoorClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletDoorClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletDoorClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletFutaOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletFutaOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletFutaOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletFutaClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletFutaClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletFutaClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletPeeWater
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletPeeWater);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletPeeWater), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletHandWash
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletHandWash);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletHandWash), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletLock
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletLock);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletLock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletUnlock
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletUnlock);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletUnlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData ToiletWater
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletWater);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToiletWater), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData CurtainOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurtainOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurtainOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData CurtainClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurtainClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurtainClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioClip sleepBed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepBed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sleepBed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe AudioData Failed
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Failed);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Failed), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData RankUp
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankUp);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankUp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData KillTime
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KillTime);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KillTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData collectAll
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectAll);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectAll), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData suburbsDaytime
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suburbsDaytime);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suburbsDaytime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData suburbsNight
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suburbsNight);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_suburbsNight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData parkDaytime
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkDaytime);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkDaytime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData parkNight
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkNight);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parkNight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData myRoom
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myRoom);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_myRoom), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData shoppingMallBgm
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoppingMallBgm);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoppingMallBgm), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData shoppingMallBgmNight
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoppingMallBgmNight);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shoppingMallBgmNight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData bgmFashionShop
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgmFashionShop);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgmFashionShop), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Select
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Select);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Select), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Decide
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Decide);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Decide), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Cancel
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cancel);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cancel), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData Buy
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buy);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Buy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData SlideOpen
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideOpen);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideOpen), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData SlideClose
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideClose);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideClose), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe AudioData CompleteMission
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompleteMission);
			return new AudioData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioData>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CompleteMission), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AudioData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppStructArray<SeType> FootSes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootSes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<SeType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FootSes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<SeType> GroupSes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupSes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<SeType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GroupSes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepHeelJogGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelJogGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelJogGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepHeelCrouchGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelCrouchGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepHeelCrouchGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepBarefootCrouchGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepBarefootCrouchGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepBarefootCrouchGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepSneakerGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepSneakerJogGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerJogGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepSneakerJogGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepGrassGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGrassGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGrassGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepGravelGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGravelGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepGravelGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController footStepMetalGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepMetalGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_footStepMetalGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController kuchuGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kuchuGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kuchuGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SoundGroupController pistonGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pistonGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SoundGroupController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pistonGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70259, RefRangeEnd = 70261, XrefRangeStart = 70256, XrefRangeEnd = 70259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsGroupSe([DefaultParameterValue(null)] SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGroupSe_Public_Boolean_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70264, RefRangeEnd = 70266, XrefRangeStart = 70261, XrefRangeEnd = 70264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsFootSe([DefaultParameterValue(null)] SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsFootSe_Public_Boolean_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 70279, RefRangeEnd = 70284, XrefRangeStart = 70266, XrefRangeEnd = 70279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioData GetAudioData([DefaultParameterValue(null)] SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAudioData_Public_AudioData_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new AudioData(pointer);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 70355, RefRangeEnd = 70382, XrefRangeStart = 70284, XrefRangeEnd = 70355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayOneShotAudioData([DefaultParameterValue(null)] AudioSource audioSource, [DefaultParameterValue(null)] SeType type, float time = -1f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioSource);
		*(SeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlayOneShotAudioData_Public_Void_AudioSource_SeType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 70382, RefRangeEnd = 70385, XrefRangeStart = 70382, XrefRangeEnd = 70382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetSound([DefaultParameterValue(null)] SeType seTypeType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seTypeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70396, RefRangeEnd = 70398, XrefRangeStart = 70385, XrefRangeEnd = 70396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetSound([DefaultParameterValue(null)] SeType seTypeType, [DefaultParameterValue(null)] GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seTypeType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe AudioClip GetSound([DefaultParameterValue(null)] SeType seTypeType, [DefaultParameterValue(null)] int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seTypeType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70398, XrefRangeEnd = 70448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70448, XrefRangeEnd = 70454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70454, XrefRangeEnd = 70465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameSoundManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InGameSoundManager()
	{
		Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Sound", "InGameSoundManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr);
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_footStepHeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepHeel");
		NativeFieldInfoPtr_footStepHeelJog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepHeelJog");
		NativeFieldInfoPtr_footStepHeelCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepHeelCrouch");
		NativeFieldInfoPtr_footStepBarefootCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepBarefootCrouch");
		NativeFieldInfoPtr_footStepSneaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepSneaker");
		NativeFieldInfoPtr_footStepSneakerJog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepSneakerJog");
		NativeFieldInfoPtr_footStepGrass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepGrass");
		NativeFieldInfoPtr_footStepGravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepGravel");
		NativeFieldInfoPtr_footStepMetal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepMetal");
		NativeFieldInfoPtr_ClothesSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ClothesSound");
		NativeFieldInfoPtr_ClothesDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ClothesDrop");
		NativeFieldInfoPtr_HeartBeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "HeartBeat");
		NativeFieldInfoPtr_kuchu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "kuchu");
		NativeFieldInfoPtr_piston = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "piston");
		NativeFieldInfoPtr_shiofuki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "shiofuki");
		NativeFieldInfoPtr_dokinHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "dokinHigh");
		NativeFieldInfoPtr_dokinLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "dokinLow");
		NativeFieldInfoPtr_buyMachine1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "buyMachine1");
		NativeFieldInfoPtr_buyMachine2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "buyMachine2");
		NativeFieldInfoPtr_drink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "drink");
		NativeFieldInfoPtr_peeNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "peeNormal");
		NativeFieldInfoPtr_Equip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Equip");
		NativeFieldInfoPtr_EquipAd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "EquipAd");
		NativeFieldInfoPtr_picking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "picking");
		NativeFieldInfoPtr_attackHandcuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "attackHandcuffs");
		NativeFieldInfoPtr_unlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "unlock");
		NativeFieldInfoPtr_braAttach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "braAttach");
		NativeFieldInfoPtr_braDetach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "braDetach");
		NativeFieldInfoPtr_pantsDetach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "pantsDetach");
		NativeFieldInfoPtr_vibratorSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "vibratorSwitch");
		NativeFieldInfoPtr_breath1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "breath1");
		NativeFieldInfoPtr_breath2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "breath2");
		NativeFieldInfoPtr_slowIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "slowIn");
		NativeFieldInfoPtr_slowOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "slowOut");
		NativeFieldInfoPtr_gogogo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "gogogo");
		NativeFieldInfoPtr_reinforce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "reinforce");
		NativeFieldInfoPtr_commonEquip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "commonEquip");
		NativeFieldInfoPtr_putDildo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "putDildo");
		NativeFieldInfoPtr_openDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "openDoor");
		NativeFieldInfoPtr_closeDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "closeDoor");
		NativeFieldInfoPtr_pinpon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "pinpon");
		NativeFieldInfoPtr_carIdling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "carIdling");
		NativeFieldInfoPtr_carStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "carStart");
		NativeFieldInfoPtr_carStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "carStop");
		NativeFieldInfoPtr_carPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "carPass");
		NativeFieldInfoPtr_mentalAlert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "mentalAlert");
		NativeFieldInfoPtr_Drone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Drone");
		NativeFieldInfoPtr_ShopDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ShopDoor");
		NativeFieldInfoPtr_elevatorMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "elevatorMove");
		NativeFieldInfoPtr_elevatorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "elevatorOpen");
		NativeFieldInfoPtr_elevatorClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "elevatorClose");
		NativeFieldInfoPtr_elevatorBell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "elevatorBell");
		NativeFieldInfoPtr_regi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "regi");
		NativeFieldInfoPtr_MansionPostReceiveOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "MansionPostReceiveOpen");
		NativeFieldInfoPtr_MansionPostReceiveClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "MansionPostReceiveClose");
		NativeFieldInfoPtr_WasherOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "WasherOpen");
		NativeFieldInfoPtr_WasherClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "WasherClose");
		NativeFieldInfoPtr_WasherStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "WasherStart");
		NativeFieldInfoPtr_WasherLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "WasherLoop");
		NativeFieldInfoPtr_WasherBeep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "WasherBeep");
		NativeFieldInfoPtr_Syasei = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Syasei");
		NativeFieldInfoPtr_TimeStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "TimeStop");
		NativeFieldInfoPtr_baibuLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "baibuLow");
		NativeFieldInfoPtr_baibuHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "baibuHigh");
		NativeFieldInfoPtr_rotor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "rotor");
		NativeFieldInfoPtr_ToiletDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletDoorOpen");
		NativeFieldInfoPtr_ToiletDoorClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletDoorClose");
		NativeFieldInfoPtr_ToiletFutaOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletFutaOpen");
		NativeFieldInfoPtr_ToiletFutaClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletFutaClose");
		NativeFieldInfoPtr_ToiletPeeWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletPeeWater");
		NativeFieldInfoPtr_ToiletHandWash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletHandWash");
		NativeFieldInfoPtr_ToiletLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletLock");
		NativeFieldInfoPtr_ToiletUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletUnlock");
		NativeFieldInfoPtr_ToiletWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "ToiletWater");
		NativeFieldInfoPtr_CurtainOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "CurtainOpen");
		NativeFieldInfoPtr_CurtainClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "CurtainClose");
		NativeFieldInfoPtr_sleepBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "sleepBed");
		NativeFieldInfoPtr_Failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Failed");
		NativeFieldInfoPtr_RankUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "RankUp");
		NativeFieldInfoPtr_KillTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "KillTime");
		NativeFieldInfoPtr_collectAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "collectAll");
		NativeFieldInfoPtr_suburbsDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "suburbsDaytime");
		NativeFieldInfoPtr_suburbsNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "suburbsNight");
		NativeFieldInfoPtr_parkDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "parkDaytime");
		NativeFieldInfoPtr_parkNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "parkNight");
		NativeFieldInfoPtr_myRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "myRoom");
		NativeFieldInfoPtr_shoppingMallBgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "shoppingMallBgm");
		NativeFieldInfoPtr_shoppingMallBgmNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "shoppingMallBgmNight");
		NativeFieldInfoPtr_bgmFashionShop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "bgmFashionShop");
		NativeFieldInfoPtr_Select = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Select");
		NativeFieldInfoPtr_Decide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Decide");
		NativeFieldInfoPtr_Cancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Cancel");
		NativeFieldInfoPtr_Buy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "Buy");
		NativeFieldInfoPtr_SlideOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "SlideOpen");
		NativeFieldInfoPtr_SlideClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "SlideClose");
		NativeFieldInfoPtr_CompleteMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "CompleteMission");
		NativeFieldInfoPtr_FootSes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "FootSes");
		NativeFieldInfoPtr_GroupSes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "GroupSes");
		NativeFieldInfoPtr_footStepGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepGroup");
		NativeFieldInfoPtr_footStepHeelJogGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepHeelJogGroup");
		NativeFieldInfoPtr_footStepHeelCrouchGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepHeelCrouchGroup");
		NativeFieldInfoPtr_footStepBarefootCrouchGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepBarefootCrouchGroup");
		NativeFieldInfoPtr_footStepSneakerGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepSneakerGroup");
		NativeFieldInfoPtr_footStepSneakerJogGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepSneakerJogGroup");
		NativeFieldInfoPtr_footStepGrassGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepGrassGroup");
		NativeFieldInfoPtr_footStepGravelGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepGravelGroup");
		NativeFieldInfoPtr_footStepMetalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "footStepMetalGroup");
		NativeFieldInfoPtr_kuchuGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "kuchuGroup");
		NativeFieldInfoPtr_pistonGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, "pistonGroup");
		NativeMethodInfoPtr_IsGroupSe_Public_Boolean_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668371);
		NativeMethodInfoPtr_IsFootSe_Public_Boolean_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668372);
		NativeMethodInfoPtr_GetAudioData_Public_AudioData_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668373);
		NativeMethodInfoPtr_PlayOneShotAudioData_Public_Void_AudioSource_SeType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668374);
		NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668375);
		NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668376);
		NativeMethodInfoPtr_GetSound_Public_AudioClip_SeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668377);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668378);
		NativeMethodInfoPtr_RefreshState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668379);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameSoundManager>.NativeClassPtr, 100668380);
	}

	public InGameSoundManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
