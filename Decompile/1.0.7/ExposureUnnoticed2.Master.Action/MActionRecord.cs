using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Action;

public class MActionRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_type;

	private static readonly IntPtr NativeFieldInfoPtr_canMove;

	private static readonly IntPtr NativeFieldInfoPtr_CantCancelDash;

	private static readonly IntPtr NativeFieldInfoPtr_IsMoveOnlyForwardWithStrafe;

	private static readonly IntPtr NativeFieldInfoPtr_IsMoveToCancel;

	private static readonly IntPtr NativeFieldInfoPtr_HandcuffsWeight;

	private static readonly IntPtr NativeFieldInfoPtr_IsIgnoreYOffset;

	private static readonly IntPtr NativeFieldInfoPtr_IsKeepClothesArmLayer;

	private static readonly IntPtr NativeFieldInfoPtr_IsSlidePants;

	private static readonly IntPtr NativeFieldInfoPtr_IsUseAnal;

	private static readonly IntPtr NativeFieldInfoPtr_IsUsePussy;

	private static readonly IntPtr NativeFieldInfoPtr_CanTransEcstasy;

	private static readonly IntPtr NativeFieldInfoPtr_IsEcstasyToIdle;

	private static readonly IntPtr NativeFieldInfoPtr_IsFixBreast;

	private static readonly IntPtr NativeFieldInfoPtr_IsIgnoreClothesArmPulse;

	private static readonly IntPtr NativeFieldInfoPtr_IsIgnoreClothesArmLayerByEcstasy;

	private static readonly IntPtr NativeFieldInfoPtr_CanUnlock;

	private static readonly IntPtr NativeFieldInfoPtr_CanStartPee;

	private static readonly IntPtr NativeFieldInfoPtr_CanCancelByGamanVibe;

	private static readonly IntPtr NativeFieldInfoPtr_AnotherMotionCount;

	private static readonly IntPtr NativeFieldInfoPtr_AddDokidoki100;

	private static readonly IntPtr NativeFieldInfoPtr_DeActiveHandcuffOverrideArm;

	private static readonly IntPtr NativeFieldInfoPtr_Discomfort;

	private static readonly IntPtr NativeFieldInfoPtr_Strange;

	private static readonly IntPtr NativeFieldInfoPtr_IsDisableLookAt;

	private static readonly IntPtr NativeFieldInfoPtr_ExposedBodyParts;

	private static readonly IntPtr NativeFieldInfoPtr_StrangenessScale;

	private static readonly IntPtr NativeFieldInfoPtr_AddEcstasy;

	private static readonly IntPtr NativeFieldInfoPtr_RotateYOffset;

	private static readonly IntPtr NativeFieldInfoPtr_FloatParam;

	private static readonly IntPtr NativeFieldInfoPtr_VectorParam;

	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ActionType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ActionType*)num;
		}
		set
		{
			*(ActionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = actionType;
		}
	}

	public unsafe bool canMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMove);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_canMove)) = flag;
		}
	}

	public unsafe bool CantCancelDash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CantCancelDash);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CantCancelDash)) = flag;
		}
	}

	public unsafe bool IsMoveOnlyForwardWithStrafe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveOnlyForwardWithStrafe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveOnlyForwardWithStrafe)) = flag;
		}
	}

	public unsafe bool IsMoveToCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveToCancel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveToCancel)) = flag;
		}
	}

	public unsafe float HandcuffsWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsWeight)) = num;
		}
	}

	public unsafe bool IsIgnoreYOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreYOffset);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreYOffset)) = flag;
		}
	}

	public unsafe bool IsKeepClothesArmLayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsKeepClothesArmLayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsKeepClothesArmLayer)) = flag;
		}
	}

	public unsafe bool IsSlidePants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSlidePants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSlidePants)) = flag;
		}
	}

	public unsafe bool IsUseAnal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseAnal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseAnal)) = flag;
		}
	}

	public unsafe bool IsUsePussy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUsePussy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUsePussy)) = flag;
		}
	}

	public unsafe bool CanTransEcstasy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanTransEcstasy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanTransEcstasy)) = flag;
		}
	}

	public unsafe bool IsEcstasyToIdle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEcstasyToIdle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEcstasyToIdle)) = flag;
		}
	}

	public unsafe bool IsFixBreast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixBreast);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsFixBreast)) = flag;
		}
	}

	public unsafe bool IsIgnoreClothesArmPulse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreClothesArmPulse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreClothesArmPulse)) = flag;
		}
	}

	public unsafe bool IsIgnoreClothesArmLayerByEcstasy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreClothesArmLayerByEcstasy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsIgnoreClothesArmLayerByEcstasy)) = flag;
		}
	}

	public unsafe bool CanUnlock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanUnlock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanUnlock)) = flag;
		}
	}

	public unsafe bool CanStartPee
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanStartPee);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanStartPee)) = flag;
		}
	}

	public unsafe bool CanCancelByGamanVibe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanCancelByGamanVibe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanCancelByGamanVibe)) = flag;
		}
	}

	public unsafe int AnotherMotionCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnotherMotionCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnotherMotionCount)) = num;
		}
	}

	public unsafe float AddDokidoki100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddDokidoki100);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddDokidoki100)) = num;
		}
	}

	public unsafe bool DeActiveHandcuffOverrideArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeActiveHandcuffOverrideArm);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DeActiveHandcuffOverrideArm)) = flag;
		}
	}

	public unsafe float Discomfort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Discomfort);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Discomfort)) = num;
		}
	}

	public unsafe float Strange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strange)) = num;
		}
	}

	public unsafe bool IsDisableLookAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDisableLookAt);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDisableLookAt)) = flag;
		}
	}

	public unsafe Il2CppStructArray<ExposedBodyParts> ExposedBodyParts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedBodyParts);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ExposedBodyParts>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedBodyParts), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float StrangenessScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangenessScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangenessScale)) = num;
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

	public unsafe float RotateYOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateYOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RotateYOffset)) = num;
		}
	}

	public unsafe float FloatParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FloatParam);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FloatParam)) = num;
		}
	}

	public unsafe Vector3 VectorParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VectorParam);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VectorParam)) = vector;
		}
	}

	public unsafe ActionType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe bool CanMove
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MActionRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MActionRecord()
	{
		Il2CppClassPointerStore<MActionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Action", "MActionRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "type");
		NativeFieldInfoPtr_canMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "canMove");
		NativeFieldInfoPtr_CantCancelDash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "CantCancelDash");
		NativeFieldInfoPtr_IsMoveOnlyForwardWithStrafe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsMoveOnlyForwardWithStrafe");
		NativeFieldInfoPtr_IsMoveToCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsMoveToCancel");
		NativeFieldInfoPtr_HandcuffsWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "HandcuffsWeight");
		NativeFieldInfoPtr_IsIgnoreYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsIgnoreYOffset");
		NativeFieldInfoPtr_IsKeepClothesArmLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsKeepClothesArmLayer");
		NativeFieldInfoPtr_IsSlidePants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsSlidePants");
		NativeFieldInfoPtr_IsUseAnal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsUseAnal");
		NativeFieldInfoPtr_IsUsePussy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsUsePussy");
		NativeFieldInfoPtr_CanTransEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "CanTransEcstasy");
		NativeFieldInfoPtr_IsEcstasyToIdle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsEcstasyToIdle");
		NativeFieldInfoPtr_IsFixBreast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsFixBreast");
		NativeFieldInfoPtr_IsIgnoreClothesArmPulse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsIgnoreClothesArmPulse");
		NativeFieldInfoPtr_IsIgnoreClothesArmLayerByEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsIgnoreClothesArmLayerByEcstasy");
		NativeFieldInfoPtr_CanUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "CanUnlock");
		NativeFieldInfoPtr_CanStartPee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "CanStartPee");
		NativeFieldInfoPtr_CanCancelByGamanVibe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "CanCancelByGamanVibe");
		NativeFieldInfoPtr_AnotherMotionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "AnotherMotionCount");
		NativeFieldInfoPtr_AddDokidoki100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "AddDokidoki100");
		NativeFieldInfoPtr_DeActiveHandcuffOverrideArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "DeActiveHandcuffOverrideArm");
		NativeFieldInfoPtr_Discomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "Discomfort");
		NativeFieldInfoPtr_Strange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "Strange");
		NativeFieldInfoPtr_IsDisableLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "IsDisableLookAt");
		NativeFieldInfoPtr_ExposedBodyParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "ExposedBodyParts");
		NativeFieldInfoPtr_StrangenessScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "StrangenessScale");
		NativeFieldInfoPtr_AddEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "AddEcstasy");
		NativeFieldInfoPtr_RotateYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "RotateYOffset");
		NativeFieldInfoPtr_FloatParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "FloatParam");
		NativeFieldInfoPtr_VectorParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, "VectorParam");
		NativeMethodInfoPtr_get_Type_Public_get_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, 100668277);
		NativeMethodInfoPtr_get_CanMove_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, 100668278);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MActionRecord>.NativeClassPtr, 100668279);
	}

	public MActionRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
