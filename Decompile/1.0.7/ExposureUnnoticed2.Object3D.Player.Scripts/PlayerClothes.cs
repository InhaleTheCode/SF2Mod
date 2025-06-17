using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Object3D.Player.Scripts.Clothes;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerClothes : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__TargetClothStateBBlend_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesId;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeClothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_clothes;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectAfterPick;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetClothStateBBlend_Public_get_ClothesState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetClothStateBBlend_Public_set_Void_ClothesState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnChangeClothes_Private_Void_ChangeEquipmentEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeTryClothes_Private_Void_ChangeEquipmentEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DropClothes_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickClothes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransMeshReference_Private_GameObject_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Boolean_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransController_Private_IClothesController_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextState_Public_ClothesState_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrevState_Public_ClothesState_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExposedBodyParts_Public_ExposedBodyParts_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Void_ClothesState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__DropClothes_b__14_0_Private_Void_0;

	public unsafe PlayerStateModel.ClothesState _TargetClothStateBBlend_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetClothStateBBlend_k__BackingField);
			return *(PlayerStateModel.ClothesState*)num;
		}
		set
		{
			*(PlayerStateModel.ClothesState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetClothStateBBlend_k__BackingField)) = clothesState;
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

	public unsafe static int ClothesId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ClothesId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ClothesId, &num);
		}
	}

	public unsafe static int ChangeClothes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeClothes, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeClothes, &num);
		}
	}

	public unsafe List<IClothesController> clothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IClothesController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int DirectAfterPick
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DirectAfterPick, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DirectAfterPick, &num);
		}
	}

	public unsafe PlayerStateModel.ClothesState TargetClothStateBBlend
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 3884, RefRangeEnd = 3888, XrefRangeStart = 3884, XrefRangeEnd = 3888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TargetClothStateBBlend_Public_get_ClothesState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TargetClothStateBBlend_Public_set_Void_ClothesState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52512, RefRangeEnd = 52513, XrefRangeStart = 52437, XrefRangeEnd = 52512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52513, XrefRangeEnd = 52525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52525, XrefRangeEnd = 52529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52529, XrefRangeEnd = 52573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeClothes([DefaultParameterValue(null)] ChangeEquipmentEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeClothes_Private_Void_ChangeEquipmentEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52573, XrefRangeEnd = 52596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeTryClothes([DefaultParameterValue(null)] ChangeEquipmentEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeTryClothes_Private_Void_ChangeEquipmentEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52651, RefRangeEnd = 52654, XrefRangeStart = 52596, XrefRangeEnd = 52651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DropClothes(Transform point = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DropClothes_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 52683, RefRangeEnd = 52686, XrefRangeStart = 52654, XrefRangeEnd = 52683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PickClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickClothes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 52687, RefRangeEnd = 52693, XrefRangeStart = 52686, XrefRangeEnd = 52687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject TransMeshReference([DefaultParameterValue(null)] ClothesType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransMeshReference_Private_GameObject_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52693, XrefRangeEnd = 52697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEnoughSkillLevel([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Boolean_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 52698, RefRangeEnd = 52707, XrefRangeStart = 52697, XrefRangeEnd = 52698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IClothesController TransController([DefaultParameterValue(null)] ClothesType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransController_Private_IClothesController_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IClothesController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52707, XrefRangeEnd = 52712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerStateModel.ClothesState GetNextState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextState_Public_ClothesState_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 52717, RefRangeEnd = 52719, XrefRangeStart = 52712, XrefRangeEnd = 52717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerStateModel.ClothesState GetPrevState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrevState_Public_ClothesState_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52727, RefRangeEnd = 52731, XrefRangeStart = 52719, XrefRangeEnd = 52727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExposedBodyParts GetExposedBodyParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedBodyParts_Public_ExposedBodyParts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ExposedBodyParts*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52731, XrefRangeEnd = 52736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52736, XrefRangeEnd = 52742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerClothes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52742, XrefRangeEnd = 52744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _DropClothes_b__14_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__DropClothes_b__14_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerClothes()
	{
		Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerClothes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr);
		NativeFieldInfoPtr__TargetClothStateBBlend_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "<TargetClothStateBBlend>k__BackingField");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_ClothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "ClothesId");
		NativeFieldInfoPtr_ChangeClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "ChangeClothes");
		NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "clothes");
		NativeFieldInfoPtr_DirectAfterPick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, "DirectAfterPick");
		NativeMethodInfoPtr_get_TargetClothStateBBlend_Public_get_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666674);
		NativeMethodInfoPtr_set_TargetClothStateBBlend_Public_set_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666675);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666676);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666677);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666678);
		NativeMethodInfoPtr_OnChangeClothes_Private_Void_ChangeEquipmentEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666679);
		NativeMethodInfoPtr_ChangeTryClothes_Private_Void_ChangeEquipmentEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666680);
		NativeMethodInfoPtr_DropClothes_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666681);
		NativeMethodInfoPtr_PickClothes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666682);
		NativeMethodInfoPtr_TransMeshReference_Private_GameObject_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666683);
		NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Boolean_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666684);
		NativeMethodInfoPtr_TransController_Private_IClothesController_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666685);
		NativeMethodInfoPtr_GetNextState_Public_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666686);
		NativeMethodInfoPtr_GetPrevState_Public_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666687);
		NativeMethodInfoPtr_GetExposedBodyParts_Public_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666688);
		NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666689);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666690);
		NativeMethodInfoPtr__DropClothes_b__14_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothes>.NativeClassPtr, 100666692);
	}

	public PlayerClothes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
