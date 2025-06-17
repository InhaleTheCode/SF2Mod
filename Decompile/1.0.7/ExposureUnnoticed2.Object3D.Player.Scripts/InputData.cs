using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.ObjectUI.InGame.RingMenu;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class InputData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Move;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_Jump;

	private static readonly System.IntPtr NativeFieldInfoPtr_LightAttack;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dash;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustCrouch;

	private static readonly System.IntPtr NativeFieldInfoPtr_MoveForwardOneHand;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustOpenClothesA;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustCloseClothesA;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustOpenClothesB;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustCloseClothesB;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustViewChange;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_Interact;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustInteract;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustDrop;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustDropHandcuffKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustDropVibeRemocon;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustAutoChase;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustAutoRun;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustTimeStop;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustCancel;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustPee;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustBra;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustPants;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustDrinkWater;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustSwitchVibrator;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustSwitchPistonMachine;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustRingDildo;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustRingHandcuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustRingEyeMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_HoldCommonRingMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_HoldSkillRingMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustSystemMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustTabLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustTabRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustSlowSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustPoseSkill;

	private static readonly System.IntPtr NativeFieldInfoPtr_JustOnaniNormal;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearSomePart_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 Move
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Move);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Move)) = vector;
		}
	}

	public unsafe Vector2 CameraMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraMove);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraMove)) = vector;
		}
	}

	public unsafe bool Jump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Jump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Jump)) = flag;
		}
	}

	public unsafe bool LightAttack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightAttack);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightAttack)) = flag;
		}
	}

	public unsafe bool Dash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dash);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dash)) = flag;
		}
	}

	public unsafe bool JustCrouch
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCrouch);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCrouch)) = flag;
		}
	}

	public unsafe bool MoveForwardOneHand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveForwardOneHand);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveForwardOneHand)) = flag;
		}
	}

	public unsafe bool JustOpenClothesA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOpenClothesA);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOpenClothesA)) = flag;
		}
	}

	public unsafe bool JustCloseClothesA
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCloseClothesA);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCloseClothesA)) = flag;
		}
	}

	public unsafe bool JustOpenClothesB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOpenClothesB);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOpenClothesB)) = flag;
		}
	}

	public unsafe bool JustCloseClothesB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCloseClothesB);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCloseClothesB)) = flag;
		}
	}

	public unsafe bool JustViewChange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustViewChange);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustViewChange)) = flag;
		}
	}

	public unsafe bool JustMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustMove)) = flag;
		}
	}

	public unsafe bool Interact
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Interact);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Interact)) = flag;
		}
	}

	public unsafe bool JustInteract
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustInteract);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustInteract)) = flag;
		}
	}

	public unsafe bool JustDrop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDrop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDrop)) = flag;
		}
	}

	public unsafe bool JustDropHandcuffKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDropHandcuffKey);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDropHandcuffKey)) = flag;
		}
	}

	public unsafe bool JustDropVibeRemocon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDropVibeRemocon);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDropVibeRemocon)) = flag;
		}
	}

	public unsafe bool JustAutoChase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustAutoChase);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustAutoChase)) = flag;
		}
	}

	public unsafe bool JustAutoRun
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustAutoRun);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustAutoRun)) = flag;
		}
	}

	public unsafe bool JustTimeStop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTimeStop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTimeStop)) = flag;
		}
	}

	public unsafe bool JustCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCancel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustCancel)) = flag;
		}
	}

	public unsafe bool JustPee
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPee);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPee)) = flag;
		}
	}

	public unsafe bool JustBra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustBra);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustBra)) = flag;
		}
	}

	public unsafe bool JustPants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPants)) = flag;
		}
	}

	public unsafe bool JustSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSelect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSelect)) = flag;
		}
	}

	public unsafe bool JustDrinkWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDrinkWater);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustDrinkWater)) = flag;
		}
	}

	public unsafe bool JustSwitchVibrator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSwitchVibrator);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSwitchVibrator)) = flag;
		}
	}

	public unsafe bool JustSwitchPistonMachine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSwitchPistonMachine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSwitchPistonMachine)) = flag;
		}
	}

	public unsafe bool JustRingDildo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingDildo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingDildo)) = flag;
		}
	}

	public unsafe bool JustRingHandcuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingHandcuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingHandcuff)) = flag;
		}
	}

	public unsafe bool JustRingEyeMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingEyeMask);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustRingEyeMask)) = flag;
		}
	}

	public unsafe bool HoldCommonRingMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldCommonRingMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldCommonRingMenu)) = flag;
		}
	}

	public unsafe bool HoldSkillRingMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldSkillRingMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldSkillRingMenu)) = flag;
		}
	}

	public unsafe bool JustSystemMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSystemMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSystemMenu)) = flag;
		}
	}

	public unsafe bool JustTabLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTabLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTabLeft)) = flag;
		}
	}

	public unsafe bool JustTabRight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTabRight);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustTabRight)) = flag;
		}
	}

	public unsafe bool JustSlowSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSlowSkill);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustSlowSkill)) = flag;
		}
	}

	public unsafe RingMenuParentView.RingItemType JustPoseSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPoseSkill);
			return *(RingMenuParentView.RingItemType*)num;
		}
		set
		{
			*(RingMenuParentView.RingItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustPoseSkill)) = ringItemType;
		}
	}

	public unsafe bool JustOnaniNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOnaniNormal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_JustOnaniNormal)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49021, XrefRangeEnd = 49025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSomePart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearSomePart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe InputData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InputData()
	{
		Il2CppClassPointerStore<InputData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "InputData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputData>.NativeClassPtr);
		NativeFieldInfoPtr_Move = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Move");
		NativeFieldInfoPtr_CameraMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "CameraMove");
		NativeFieldInfoPtr_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Jump");
		NativeFieldInfoPtr_LightAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "LightAttack");
		NativeFieldInfoPtr_Dash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Dash");
		NativeFieldInfoPtr_JustCrouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustCrouch");
		NativeFieldInfoPtr_MoveForwardOneHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "MoveForwardOneHand");
		NativeFieldInfoPtr_JustOpenClothesA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustOpenClothesA");
		NativeFieldInfoPtr_JustCloseClothesA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustCloseClothesA");
		NativeFieldInfoPtr_JustOpenClothesB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustOpenClothesB");
		NativeFieldInfoPtr_JustCloseClothesB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustCloseClothesB");
		NativeFieldInfoPtr_JustViewChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustViewChange");
		NativeFieldInfoPtr_JustMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustMove");
		NativeFieldInfoPtr_Interact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "Interact");
		NativeFieldInfoPtr_JustInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustInteract");
		NativeFieldInfoPtr_JustDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustDrop");
		NativeFieldInfoPtr_JustDropHandcuffKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustDropHandcuffKey");
		NativeFieldInfoPtr_JustDropVibeRemocon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustDropVibeRemocon");
		NativeFieldInfoPtr_JustAutoChase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustAutoChase");
		NativeFieldInfoPtr_JustAutoRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustAutoRun");
		NativeFieldInfoPtr_JustTimeStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustTimeStop");
		NativeFieldInfoPtr_JustCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustCancel");
		NativeFieldInfoPtr_JustPee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustPee");
		NativeFieldInfoPtr_JustBra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustBra");
		NativeFieldInfoPtr_JustPants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustPants");
		NativeFieldInfoPtr_JustSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustSelect");
		NativeFieldInfoPtr_JustDrinkWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustDrinkWater");
		NativeFieldInfoPtr_JustSwitchVibrator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustSwitchVibrator");
		NativeFieldInfoPtr_JustSwitchPistonMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustSwitchPistonMachine");
		NativeFieldInfoPtr_JustRingDildo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustRingDildo");
		NativeFieldInfoPtr_JustRingHandcuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustRingHandcuff");
		NativeFieldInfoPtr_JustRingEyeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustRingEyeMask");
		NativeFieldInfoPtr_HoldCommonRingMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "HoldCommonRingMenu");
		NativeFieldInfoPtr_HoldSkillRingMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "HoldSkillRingMenu");
		NativeFieldInfoPtr_JustSystemMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustSystemMenu");
		NativeFieldInfoPtr_JustTabLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustTabLeft");
		NativeFieldInfoPtr_JustTabRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustTabRight");
		NativeFieldInfoPtr_JustSlowSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustSlowSkill");
		NativeFieldInfoPtr_JustPoseSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustPoseSkill");
		NativeFieldInfoPtr_JustOnaniNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputData>.NativeClassPtr, "JustOnaniNormal");
		NativeMethodInfoPtr_ClearSomePart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputData>.NativeClassPtr, 100666376);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputData>.NativeClassPtr, 100666377);
	}

	public InputData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
