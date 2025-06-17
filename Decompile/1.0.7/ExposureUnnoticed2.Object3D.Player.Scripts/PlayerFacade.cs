using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Hair;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Object3D.Light;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.ObjectUI.InventoryPanel;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerFacade : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIgnoreBaretaState_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHoldClothes_Public_Void_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransPick_Public_Void_HadObjectType_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransPickClothes_Public_Void_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransActionIfNewNext_Public_Boolean_ActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAndRemoveHoldInHandClothes_Public_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothMoveTo_Public_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SmoothRotateY_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeAccessoryIfAble_Public_Void_IEquipableMaster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ForceChangeAdultGoods_Public_Void_MAdultGoodsType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeHair_Public_Void_MHairRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHoldInHandClothes_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayingAction_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAddMoisture_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeClothes_Public_Void_MClothesRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsHideSomePartsByCosplay_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExposedBodyPartsByClothesAndCostume_Public_ExposedBodyParts_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatorSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimationMoveSpeed_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFaceLayerWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveUnderwear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanPutHandcuffsToMap_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CanUseHand_Public_Boolean_Boolean_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTouchLight_Public_Void_StreetLightController_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCosplayActive_Public_Void_CosplayType_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Void_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static PlayerFacade Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerFacade>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53277, XrefRangeEnd = 53280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53280, XrefRangeEnd = 53283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53283, XrefRangeEnd = 53284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsIgnoreBaretaState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIgnoreBaretaState_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 53289, RefRangeEnd = 53295, XrefRangeStart = 53284, XrefRangeEnd = 53289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHadBasket([DefaultParameterValue(null)] bool hadBasket)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hadBasket);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53298, RefRangeEnd = 53299, XrefRangeStart = 53295, XrefRangeEnd = 53298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHoldClothes([DefaultParameterValue(null)] ClothesType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHoldClothes_Public_Void_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void TransPick([DefaultParameterValue(null)] PlayerStateModel.HadObjectType dropType, ClothesType type = ClothesType.None)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dropType);
		*(ClothesType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransPick_Public_Void_HadObjectType_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void TransPickClothes([DefaultParameterValue(null)] ClothesType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransPickClothes_Public_Void_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void TransAction([DefaultParameterValue(null)] ActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 53299, RefRangeEnd = 53304, XrefRangeStart = 53299, XrefRangeEnd = 53299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TransActionIfNewNext([DefaultParameterValue(null)] ActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransActionIfNewNext_Public_Boolean_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53304, XrefRangeEnd = 53311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClothesType GetAndRemoveHoldInHandClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAndRemoveHoldInHandClothes_Public_ClothesType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ClothesType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 53311, RefRangeEnd = 53319, XrefRangeStart = 53311, XrefRangeEnd = 53311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothMoveTo([DefaultParameterValue(null)] Transform transform)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothMoveTo_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53319, XrefRangeEnd = 53330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SmoothRotateY([DefaultParameterValue(null)] float y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&y);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SmoothRotateY_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53353, RefRangeEnd = 53354, XrefRangeStart = 53330, XrefRangeEnd = 53353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeAccessoryIfAble([DefaultParameterValue(null)] IEquipableMaster record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeAccessoryIfAble_Public_Void_IEquipableMaster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53354, XrefRangeEnd = 53356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForceChangeAdultGoods([DefaultParameterValue(null)] MAdultGoodsType type, [DefaultParameterValue(null)] bool isActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceChangeAdultGoods_Public_Void_MAdultGoodsType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53356, XrefRangeEnd = 53358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeHair([DefaultParameterValue(null)] MHairRecord record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeHair_Public_Void_MHairRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53358, XrefRangeEnd = 53360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsHoldInHandClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHoldInHandClothes_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe bool IsPlayingAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlayingAction_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53360, XrefRangeEnd = 53362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAddMoisture([DefaultParameterValue(null)] float add)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&add);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAddMoisture_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53372, RefRangeEnd = 53375, XrefRangeStart = 53362, XrefRangeEnd = 53372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeClothes([DefaultParameterValue(null)] MClothesRecord record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeClothes_Public_Void_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsHideSomePartsByCosplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsHideSomePartsByCosplay_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 53410, RefRangeEnd = 53458, XrefRangeStart = 53375, XrefRangeEnd = 53410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExposedBodyParts GetExposedBodyPartsByClothesAndCostume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedBodyPartsByClothesAndCostume_Public_ExposedBodyParts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ExposedBodyParts*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53458, XrefRangeEnd = 53463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimatorSpeed([DefaultParameterValue(null)] float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimatorSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetAnimationMoveSpeed([DefaultParameterValue(null)] float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAnimationMoveSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53463, XrefRangeEnd = 53472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActiveUnderwear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveUnderwear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53472, XrefRangeEnd = 53474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPutHandcuffsToMap()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanPutHandcuffsToMap_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe Transform GetTransform()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransform_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53474, XrefRangeEnd = 53481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanUseHand([DefaultParameterValue(null)] bool isSendMessage, bool isSkipHandcuff = false, bool isSkipBasket = false, bool isSkipPlayingAction = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&isSendMessage);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSkipHandcuff;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSkipBasket;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isSkipPlayingAction;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CanUseHand_Public_Boolean_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53481, XrefRangeEnd = 53482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StrangeData CalcStrangerDegreeFrom([DefaultParameterValue(null)] Transform npcTransform, [DefaultParameterValue(null)] Transform head, [DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(head);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(StrangeData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53490, RefRangeEnd = 53492, XrefRangeStart = 53482, XrefRangeEnd = 53490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTouchLight([DefaultParameterValue(null)] StreetLightController light, [DefaultParameterValue(null)] bool isTouch)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(light);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isTouch;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTouchLight_Public_Void_StreetLightController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53492, XrefRangeEnd = 53493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCosplayActive([DefaultParameterValue(null)] CosplayType type, [DefaultParameterValue(null)] int id, [DefaultParameterValue(null)] bool isActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &id;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCosplayActive_Public_Void_CosplayType_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53493, XrefRangeEnd = 53495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySe([DefaultParameterValue(null)] InGameSoundManager.SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53499, RefRangeEnd = 53501, XrefRangeStart = 53495, XrefRangeEnd = 53499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Push([DefaultParameterValue(null)] Vector3 pushV, bool isFixed = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&pushV);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFixed;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PlayerFacade()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerFacade()
	{
		Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerFacade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr);
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, "pca");
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666760);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666761);
		NativeMethodInfoPtr_IsIgnoreBaretaState_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666762);
		NativeMethodInfoPtr_SetHadBasket_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666763);
		NativeMethodInfoPtr_SetHoldClothes_Public_Void_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666764);
		NativeMethodInfoPtr_TransPick_Public_Void_HadObjectType_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666765);
		NativeMethodInfoPtr_TransPickClothes_Public_Void_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666766);
		NativeMethodInfoPtr_TransAction_Public_Void_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666767);
		NativeMethodInfoPtr_TransActionIfNewNext_Public_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666768);
		NativeMethodInfoPtr_GetAndRemoveHoldInHandClothes_Public_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666769);
		NativeMethodInfoPtr_SmoothMoveTo_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666770);
		NativeMethodInfoPtr_SmoothRotateY_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666771);
		NativeMethodInfoPtr_ChangeAccessoryIfAble_Public_Void_IEquipableMaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666772);
		NativeMethodInfoPtr_ForceChangeAdultGoods_Public_Void_MAdultGoodsType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666773);
		NativeMethodInfoPtr_ChangeHair_Public_Void_MHairRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666774);
		NativeMethodInfoPtr_IsHoldInHandClothes_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666775);
		NativeMethodInfoPtr_IsPlayingAction_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666776);
		NativeMethodInfoPtr_AddAddMoisture_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666777);
		NativeMethodInfoPtr_ChangeClothes_Public_Void_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666778);
		NativeMethodInfoPtr_IsHideSomePartsByCosplay_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666779);
		NativeMethodInfoPtr_GetExposedBodyPartsByClothesAndCostume_Public_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666780);
		NativeMethodInfoPtr_SetAnimatorSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666781);
		NativeMethodInfoPtr_SetAnimationMoveSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666782);
		NativeMethodInfoPtr_SetFaceLayerWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666783);
		NativeMethodInfoPtr_ActiveUnderwear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666784);
		NativeMethodInfoPtr_CanPutHandcuffsToMap_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666785);
		NativeMethodInfoPtr_GetTransform_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666786);
		NativeMethodInfoPtr_CanUseHand_Public_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666787);
		NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666788);
		NativeMethodInfoPtr_UpdateTouchLight_Public_Void_StreetLightController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666789);
		NativeMethodInfoPtr_SetCosplayActive_Public_Void_CosplayType_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666790);
		NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666791);
		NativeMethodInfoPtr_Push_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666792);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFacade>.NativeClassPtr, 100666793);
	}

	public PlayerFacade(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
