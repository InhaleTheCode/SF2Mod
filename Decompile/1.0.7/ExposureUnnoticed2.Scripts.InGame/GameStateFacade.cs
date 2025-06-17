using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Accessory;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.BodyPaint;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Costume;
using ExposureUnnoticed2.Master.DroneMission;
using ExposureUnnoticed2.Master.Hair;
using ExposureUnnoticed2.Master.Item;
using ExposureUnnoticed2.Master.RankRelease;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.Master.Skill;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu;
using ExposureUnnoticed2.ObjectUI.InventoryPanel;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class GameStateFacade : MonoBehaviour
{
	[System.Serializable]
	[ObfuscatedName("ExposureUnnoticed2.Scripts.InGame.GameStateFacade/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetReinforceEffect_b__6_0_Internal_Int32_RReinforceEffect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetReinforceEffect_b__7_0_Internal_Int32_RReinforceEffect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetReinforceEffect_b__8_0_Internal_Int32_RReinforceEffect_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<RReinforceEffect, int> __9__6_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__6_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RReinforceEffect, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__6_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<RReinforceEffect, int> __9__7_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__7_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RReinforceEffect, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__7_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<RReinforceEffect, int> __9__8_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__8_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<RReinforceEffect, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__8_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73541, XrefRangeEnd = 73550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SetReinforceEffect_b__6_0([DefaultParameterValue(null)] RReinforceEffect s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetReinforceEffect_b__6_0_Internal_Int32_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73550, XrefRangeEnd = 73559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SetReinforceEffect_b__7_0([DefaultParameterValue(null)] RReinforceEffect s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetReinforceEffect_b__7_0_Internal_Int32_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73559, XrefRangeEnd = 73568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _SetReinforceEffect_b__8_0([DefaultParameterValue(null)] RReinforceEffect s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetReinforceEffect_b__8_0_Internal_Int32_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__6_0");
			NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__7_0");
			NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__8_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668760);
			NativeMethodInfoPtr__SetReinforceEffect_b__6_0_Internal_Int32_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668761);
			NativeMethodInfoPtr__SetReinforceEffect_b__7_0_Internal_Int32_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668762);
			NativeMethodInfoPtr__SetReinforceEffect_b__8_0_Internal_Int32_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100668763);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_IsActivePassiveSkill_Public_Static_Boolean_SkillType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeActivePassiveSkill_Public_Static_Void_SkillType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraMoveX_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCameraMoveY_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSkillLevel_Public_Static_Int32_SkillType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RiseSkillLevel_Public_Static_Void_SkillType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_MAdultGoodsType_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_CostumeType_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_Int32_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnoughRp_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConsumeRp_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RiseEarnRp_Public_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RiseRp_Public_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RiseRpDirectly_Public_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddClothes_Public_Static_Void_MClothesRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddClothes_Public_Static_Void_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAdultGoods_Public_Static_Void_MAdultGoodsType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringBodyPaint_Public_Static_Boolean_BodyPaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipBodyPaint_Public_Static_Boolean_BodyPaintType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveBodyPaint_Public_Static_Void_BodyPaintType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringClothes_Public_Static_Boolean_MClothesRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipAdultGoods_Public_Static_Boolean_MAdultGoodsType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAdultGoodsState_Public_Static_Void_MAdultGoodsType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipCostume_Public_Static_Boolean_RCostume_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCostumeState_Public_Static_Void_RCostume_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringCostume_Public_Static_Boolean_CostumeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCostume_Public_Static_Void_CostumeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultSkillDict_Public_Static_Dictionary_2_SkillType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultDropDataDict_Public_Static_Dictionary_2_DropItemType_DropData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultHairCustomDataDict_Public_Static_Dictionary_2_HairType_HairCustomizeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultClothesDict_Public_Static_Dictionary_2_ClothesType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultCostumeDict_Public_Static_Dictionary_2_CostumeType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultCosplayPartsDict_Public_Static_Dictionary_2_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCosplayPartsOptionData_Public_Static_CosplayPartsOptionData_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipCosplayParts_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringCosplayParts_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCosplayParts_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveCosplayParts_Public_Static_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_StageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDroneMissionMaxRpBonus_Public_Static_Int32_RDroneMission_StageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddOneDroneMissionAchieveCount_Public_Static_Void_RDroneMission_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeItemNum_Public_Static_Void_ItemType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBringItem_Public_Static_Boolean_ItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPossessionClothes_Public_Static_List_1_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEquipped_Public_Static_Boolean_IEquipableMaster_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionMouseXScale_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionMouseYScale_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionWheelScale_Public_Static_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionAchieveCount_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AchieveMission_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AchieveContinueMission_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionSatisfy_Public_Static_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMissionEarnRp_Public_Static_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAttachSomeHandcuffs_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_RankReleaseType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultCustomBody_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDefaultCustomFace_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultReinforceEffectAdultGoods_Public_Static_Dictionary_2_MAdultGoodsType_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultReinforceEffectCosplayParts_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultReinforceEffectCostume_Public_Static_Dictionary_2_CostumeType_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultLoadoutData_Public_Static_List_1_LoadoutData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDefaultLoadoutCustomizeData_Public_Static_List_1_LoadoutCustomizeData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransHairType_Public_Static_List_1_HairType_List_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransInt_Public_Static_List_1_Int32_List_1_HairType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRankNameAutoHide_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 73571, RefRangeEnd = 73599, XrefRangeStart = 73568, XrefRangeEnd = 73571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsActivePassiveSkill([DefaultParameterValue(null)] SkillType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsActivePassiveSkill_Public_Static_Boolean_SkillType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73629, RefRangeEnd = 73631, XrefRangeStart = 73599, XrefRangeEnd = 73629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeActivePassiveSkill([DefaultParameterValue(null)] SkillType type, [DefaultParameterValue(null)] bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeActivePassiveSkill_Public_Static_Void_SkillType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 73644, RefRangeEnd = 73648, XrefRangeStart = 73631, XrefRangeEnd = 73644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCameraMoveX()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraMoveX_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 73662, RefRangeEnd = 73665, XrefRangeStart = 73648, XrefRangeEnd = 73662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCameraMoveY()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraMoveY_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 73671, RefRangeEnd = 73697, XrefRangeStart = 73665, XrefRangeEnd = 73671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetSkillLevel([DefaultParameterValue(null)] SkillType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSkillLevel_Public_Static_Int32_SkillType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 73711, RefRangeEnd = 73714, XrefRangeStart = 73697, XrefRangeEnd = 73711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RiseSkillLevel([DefaultParameterValue(null)] SkillType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RiseSkillLevel_Public_Static_Void_SkillType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73741, RefRangeEnd = 73742, XrefRangeStart = 73714, XrefRangeEnd = 73741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReinforceEffect([DefaultParameterValue(null)] MAdultGoodsType type, [DefaultParameterValue(null)] Il2CppReferenceArray<RReinforceEffect> effects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(effects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_MAdultGoodsType_Il2CppReferenceArray_1_RReinforceEffect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73769, RefRangeEnd = 73770, XrefRangeStart = 73742, XrefRangeEnd = 73769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReinforceEffect([DefaultParameterValue(null)] CostumeType type, [DefaultParameterValue(null)] Il2CppReferenceArray<RReinforceEffect> effects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(effects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_CostumeType_Il2CppReferenceArray_1_RReinforceEffect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73797, RefRangeEnd = 73798, XrefRangeStart = 73770, XrefRangeEnd = 73797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetReinforceEffect([DefaultParameterValue(null)] int uniqueId, [DefaultParameterValue(null)] Il2CppReferenceArray<RReinforceEffect> effects)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uniqueId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(effects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_Int32_Il2CppReferenceArray_1_RReinforceEffect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73800, RefRangeEnd = 73802, XrefRangeStart = 73798, XrefRangeEnd = 73800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEnoughRp([DefaultParameterValue(null)] int necessaryRp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&necessaryRp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnoughRp_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 73805, RefRangeEnd = 73813, XrefRangeStart = 73802, XrefRangeEnd = 73805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConsumeRp([DefaultParameterValue(null)] int rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConsumeRp_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73816, RefRangeEnd = 73818, XrefRangeStart = 73813, XrefRangeEnd = 73816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RiseEarnRp([DefaultParameterValue(null)] float rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RiseEarnRp_Public_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73825, RefRangeEnd = 73826, XrefRangeStart = 73818, XrefRangeEnd = 73825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RiseRp([DefaultParameterValue(null)] float rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RiseRp_Public_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73826, XrefRangeEnd = 73829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RiseRpDirectly([DefaultParameterValue(null)] float rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RiseRpDirectly_Public_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73834, RefRangeEnd = 73835, XrefRangeStart = 73829, XrefRangeEnd = 73834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddClothes([DefaultParameterValue(null)] MClothesRecord record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddClothes_Public_Static_Void_MClothesRecord_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73835, XrefRangeEnd = 73840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddClothes([DefaultParameterValue(null)] ClothesType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddClothes_Public_Static_Void_ClothesType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73845, RefRangeEnd = 73847, XrefRangeStart = 73840, XrefRangeEnd = 73845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddAdultGoods([DefaultParameterValue(null)] MAdultGoodsType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAdultGoods_Public_Static_Void_MAdultGoodsType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73852, RefRangeEnd = 73854, XrefRangeStart = 73847, XrefRangeEnd = 73852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringBodyPaint([DefaultParameterValue(null)] BodyPaintType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringBodyPaint_Public_Static_Boolean_BodyPaintType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 73860, RefRangeEnd = 73865, XrefRangeStart = 73854, XrefRangeEnd = 73860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEquipBodyPaint([DefaultParameterValue(null)] BodyPaintType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipBodyPaint_Public_Static_Boolean_BodyPaintType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73870, RefRangeEnd = 73872, XrefRangeStart = 73865, XrefRangeEnd = 73870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveBodyPaint([DefaultParameterValue(null)] BodyPaintType type, [DefaultParameterValue(null)] bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveBodyPaint_Public_Static_Void_BodyPaintType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73877, RefRangeEnd = 73878, XrefRangeStart = 73872, XrefRangeEnd = 73877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringClothes([DefaultParameterValue(null)] MClothesRecord record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringClothes_Public_Static_Boolean_MClothesRecord_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73878, XrefRangeEnd = 73883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringAdultGoods([DefaultParameterValue(null)] MAdultGoodsRecord record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsRecord_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 73888, RefRangeEnd = 73903, XrefRangeStart = 73883, XrefRangeEnd = 73888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringAdultGoods([DefaultParameterValue(null)] MAdultGoodsType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 73909, RefRangeEnd = 73919, XrefRangeStart = 73903, XrefRangeEnd = 73909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEquipAdultGoods([DefaultParameterValue(null)] MAdultGoodsType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipAdultGoods_Public_Static_Boolean_MAdultGoodsType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 73924, RefRangeEnd = 73927, XrefRangeStart = 73919, XrefRangeEnd = 73924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateAdultGoodsState([DefaultParameterValue(null)] MAdultGoodsType type, [DefaultParameterValue(null)] bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAdultGoodsState_Public_Static_Void_MAdultGoodsType_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 73933, RefRangeEnd = 73938, XrefRangeStart = 73927, XrefRangeEnd = 73933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEquipCostume([DefaultParameterValue(null)] RCostume record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipCostume_Public_Static_Boolean_RCostume_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73938, XrefRangeEnd = 73943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UpdateCostumeState([DefaultParameterValue(null)] RCostume record, [DefaultParameterValue(null)] bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCostumeState_Public_Static_Void_RCostume_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73943, XrefRangeEnd = 73948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringCostume([DefaultParameterValue(null)] CostumeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringCostume_Public_Static_Boolean_CostumeType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73948, XrefRangeEnd = 73953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCostume([DefaultParameterValue(null)] CostumeType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCostume_Public_Static_Void_CostumeType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73996, RefRangeEnd = 73997, XrefRangeStart = 73953, XrefRangeEnd = 73996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<SkillType, int> GetDefaultSkillDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultSkillDict_Public_Static_Dictionary_2_SkillType_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SkillType, int>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74046, RefRangeEnd = 74047, XrefRangeStart = 73997, XrefRangeEnd = 74046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<DroppedItemManager.DropItemType, DroppedItemManager.DropData> GetDefaultDropDataDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultDropDataDict_Public_Static_Dictionary_2_DropItemType_DropData_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DroppedItemManager.DropItemType, DroppedItemManager.DropData>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74088, RefRangeEnd = 74090, XrefRangeStart = 74047, XrefRangeEnd = 74088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<HairType, MHairRecord.HairCustomizeData> GetDefaultHairCustomDataDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultHairCustomDataDict_Public_Static_Dictionary_2_HairType_HairCustomizeData_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<HairType, MHairRecord.HairCustomizeData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74090, XrefRangeEnd = 74099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<ClothesType, bool> GetDefaultClothesDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultClothesDict_Public_Static_Dictionary_2_ClothesType_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ClothesType, bool>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74099, XrefRangeEnd = 74105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<CostumeType, bool> GetDefaultCostumeDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDefaultCostumeDict_Public_Static_Dictionary_2_CostumeType_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CostumeType, bool>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74105, XrefRangeEnd = 74113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, bool> CreateDefaultCosplayPartsDict()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultCosplayPartsDict_Public_Static_Dictionary_2_Int32_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, bool>>(intPtr) : null;
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 74132, RefRangeEnd = 74161, XrefRangeStart = 74113, XrefRangeEnd = 74132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CosplayPartsOptionData GetCosplayPartsOptionData([DefaultParameterValue(null)] int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCosplayPartsOptionData_Public_Static_CosplayPartsOptionData_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CosplayPartsOptionData>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 74167, RefRangeEnd = 74176, XrefRangeStart = 74161, XrefRangeEnd = 74167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEquipCosplayParts([DefaultParameterValue(null)] int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipCosplayParts_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 74181, RefRangeEnd = 74186, XrefRangeStart = 74176, XrefRangeEnd = 74181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringCosplayParts([DefaultParameterValue(null)] int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringCosplayParts_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74186, XrefRangeEnd = 74191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddCosplayParts([DefaultParameterValue(null)] int uniqueId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCosplayParts_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74196, RefRangeEnd = 74197, XrefRangeStart = 74191, XrefRangeEnd = 74196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetActiveCosplayParts([DefaultParameterValue(null)] int uniqueId, [DefaultParameterValue(null)] bool isActive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uniqueId);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isActive;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetActiveCosplayParts_Public_Static_Void_Int32_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 74210, RefRangeEnd = 74216, XrefRangeStart = 74197, XrefRangeEnd = 74210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDroneMissionAchieveCount([DefaultParameterValue(null)] RDroneMission record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74216, XrefRangeEnd = 74230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDroneMissionAchieveCount([DefaultParameterValue(null)] RDroneMission record, [DefaultParameterValue(null)] StageType stageType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_StageType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74230, XrefRangeEnd = 74244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetDroneMissionMaxRpBonus([DefaultParameterValue(null)] RDroneMission record, [DefaultParameterValue(null)] StageType stageType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDroneMissionMaxRpBonus_Public_Static_Int32_RDroneMission_StageType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74303, RefRangeEnd = 74305, XrefRangeStart = 74244, XrefRangeEnd = 74303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddOneDroneMissionAchieveCount([DefaultParameterValue(null)] RDroneMission record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddOneDroneMissionAchieveCount_Public_Static_Void_RDroneMission_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 74328, RefRangeEnd = 74356, XrefRangeStart = 74305, XrefRangeEnd = 74328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ChangeItemNum([DefaultParameterValue(null)] ItemType type, [DefaultParameterValue(null)] int changeAmount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changeAmount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeItemNum_Public_Static_Void_ItemType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 74362, RefRangeEnd = 74379, XrefRangeStart = 74356, XrefRangeEnd = 74362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBringItem([DefaultParameterValue(null)] ItemType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBringItem_Public_Static_Boolean_ItemType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74400, RefRangeEnd = 74401, XrefRangeStart = 74379, XrefRangeEnd = 74400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ClothesType> GetPossessionClothes()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPossessionClothes_Public_Static_List_1_ClothesType_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ClothesType>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 74410, RefRangeEnd = 74413, XrefRangeStart = 74401, XrefRangeEnd = 74410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEquipped([DefaultParameterValue(null)] IEquipableMaster record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEquipped_Public_Static_Boolean_IEquipableMaster_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74415, RefRangeEnd = 74417, XrefRangeStart = 74413, XrefRangeEnd = 74415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetOptionMouseXScale()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOptionMouseXScale_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74417, XrefRangeEnd = 74419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetOptionMouseYScale()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOptionMouseYScale_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74421, RefRangeEnd = 74423, XrefRangeStart = 74419, XrefRangeEnd = 74421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetOptionWheelScale()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOptionWheelScale_Public_Static_Single_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 74431, RefRangeEnd = 74440, XrefRangeStart = 74423, XrefRangeEnd = 74431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMissionAchieveCount([DefaultParameterValue(null)] int UniqueMissionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UniqueMissionId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionAchieveCount_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74455, RefRangeEnd = 74456, XrefRangeStart = 74440, XrefRangeEnd = 74455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AchieveMission([DefaultParameterValue(null)] int UniqueMissionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UniqueMissionId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AchieveMission_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74456, XrefRangeEnd = 74471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AchieveContinueMission([DefaultParameterValue(null)] int UniqueMissionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UniqueMissionId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AchieveContinueMission_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74484, RefRangeEnd = 74486, XrefRangeStart = 74471, XrefRangeEnd = 74484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetMissionSatisfy([DefaultParameterValue(null)] int UniqueMissionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UniqueMissionId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionSatisfy_Public_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74486, XrefRangeEnd = 74499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetMissionEarnRp([DefaultParameterValue(null)] int UniqueMissionId)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&UniqueMissionId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMissionEarnRp_Public_Static_Single_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 74501, RefRangeEnd = 74534, XrefRangeStart = 74499, XrefRangeEnd = 74501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAttachSomeHandcuffs()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAttachSomeHandcuffs_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 74538, RefRangeEnd = 74555, XrefRangeStart = 74534, XrefRangeEnd = 74538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRelease([DefaultParameterValue(null)] RankReleaseType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_RankReleaseType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74593, RefRangeEnd = 74595, XrefRangeStart = 74555, XrefRangeEnd = 74593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultCustomBody()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultCustomBody_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 74620, RefRangeEnd = 74622, XrefRangeStart = 74595, XrefRangeEnd = 74620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDefaultCustomFace()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDefaultCustomFace_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74668, RefRangeEnd = 74669, XrefRangeStart = 74622, XrefRangeEnd = 74668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<MAdultGoodsType, Il2CppStructArray<int>> CreateDefaultReinforceEffectAdultGoods()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultReinforceEffectAdultGoods_Public_Static_Dictionary_2_MAdultGoodsType_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<MAdultGoodsType, Il2CppStructArray<int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74693, RefRangeEnd = 74694, XrefRangeStart = 74669, XrefRangeEnd = 74693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, Il2CppStructArray<int>> CreateDefaultReinforceEffectCosplayParts()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultReinforceEffectCosplayParts_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppStructArray<int>>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74740, RefRangeEnd = 74741, XrefRangeStart = 74694, XrefRangeEnd = 74740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<CostumeType, Il2CppStructArray<int>> CreateDefaultReinforceEffectCostume()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultReinforceEffectCostume_Public_Static_Dictionary_2_CostumeType_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CostumeType, Il2CppStructArray<int>>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74741, XrefRangeEnd = 74756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<LoadoutData> CreateDefaultLoadoutData()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultLoadoutData_Public_Static_List_1_LoadoutData_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoadoutData>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74756, XrefRangeEnd = 74771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<LoadoutCustomizeData> CreateDefaultLoadoutCustomizeData()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDefaultLoadoutCustomizeData_Public_Static_List_1_LoadoutCustomizeData_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<LoadoutCustomizeData>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 74789, RefRangeEnd = 74790, XrefRangeStart = 74771, XrefRangeEnd = 74789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<HairType> TransHairType([DefaultParameterValue(null)] List<int> before)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransHairType_Public_Static_List_1_HairType_List_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<HairType>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74790, XrefRangeEnd = 74808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<int> TransInt([DefaultParameterValue(null)] List<HairType> before)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(before);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransInt_Public_Static_List_1_Int32_List_1_HairType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 74814, RefRangeEnd = 74821, XrefRangeStart = 74808, XrefRangeEnd = 74814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetRankNameAutoHide([DefaultParameterValue(null)] int rank)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rank);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRankNameAutoHide_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameStateFacade()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameStateFacade()
	{
		Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "GameStateFacade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr);
		NativeMethodInfoPtr_IsActivePassiveSkill_Public_Static_Boolean_SkillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668690);
		NativeMethodInfoPtr_ChangeActivePassiveSkill_Public_Static_Void_SkillType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668691);
		NativeMethodInfoPtr_GetCameraMoveX_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668692);
		NativeMethodInfoPtr_GetCameraMoveY_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668693);
		NativeMethodInfoPtr_GetSkillLevel_Public_Static_Int32_SkillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668694);
		NativeMethodInfoPtr_RiseSkillLevel_Public_Static_Void_SkillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668695);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_MAdultGoodsType_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668696);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_CostumeType_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668697);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Static_Void_Int32_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668698);
		NativeMethodInfoPtr_IsEnoughRp_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668699);
		NativeMethodInfoPtr_ConsumeRp_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668700);
		NativeMethodInfoPtr_RiseEarnRp_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668701);
		NativeMethodInfoPtr_RiseRp_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668702);
		NativeMethodInfoPtr_RiseRpDirectly_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668703);
		NativeMethodInfoPtr_AddClothes_Public_Static_Void_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668704);
		NativeMethodInfoPtr_AddClothes_Public_Static_Void_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668705);
		NativeMethodInfoPtr_AddAdultGoods_Public_Static_Void_MAdultGoodsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668706);
		NativeMethodInfoPtr_IsBringBodyPaint_Public_Static_Boolean_BodyPaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668707);
		NativeMethodInfoPtr_IsEquipBodyPaint_Public_Static_Boolean_BodyPaintType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668708);
		NativeMethodInfoPtr_SetActiveBodyPaint_Public_Static_Void_BodyPaintType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668709);
		NativeMethodInfoPtr_IsBringClothes_Public_Static_Boolean_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668710);
		NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668711);
		NativeMethodInfoPtr_IsBringAdultGoods_Public_Static_Boolean_MAdultGoodsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668712);
		NativeMethodInfoPtr_IsEquipAdultGoods_Public_Static_Boolean_MAdultGoodsType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668713);
		NativeMethodInfoPtr_UpdateAdultGoodsState_Public_Static_Void_MAdultGoodsType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668714);
		NativeMethodInfoPtr_IsEquipCostume_Public_Static_Boolean_RCostume_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668715);
		NativeMethodInfoPtr_UpdateCostumeState_Public_Static_Void_RCostume_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668716);
		NativeMethodInfoPtr_IsBringCostume_Public_Static_Boolean_CostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668717);
		NativeMethodInfoPtr_AddCostume_Public_Static_Void_CostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668718);
		NativeMethodInfoPtr_GetDefaultSkillDict_Public_Static_Dictionary_2_SkillType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668719);
		NativeMethodInfoPtr_GetDefaultDropDataDict_Public_Static_Dictionary_2_DropItemType_DropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668720);
		NativeMethodInfoPtr_GetDefaultHairCustomDataDict_Public_Static_Dictionary_2_HairType_HairCustomizeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668721);
		NativeMethodInfoPtr_GetDefaultClothesDict_Public_Static_Dictionary_2_ClothesType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668722);
		NativeMethodInfoPtr_GetDefaultCostumeDict_Public_Static_Dictionary_2_CostumeType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668723);
		NativeMethodInfoPtr_CreateDefaultCosplayPartsDict_Public_Static_Dictionary_2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668724);
		NativeMethodInfoPtr_GetCosplayPartsOptionData_Public_Static_CosplayPartsOptionData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668725);
		NativeMethodInfoPtr_IsEquipCosplayParts_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668726);
		NativeMethodInfoPtr_IsBringCosplayParts_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668727);
		NativeMethodInfoPtr_AddCosplayParts_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668728);
		NativeMethodInfoPtr_SetActiveCosplayParts_Public_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668729);
		NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668730);
		NativeMethodInfoPtr_GetDroneMissionAchieveCount_Public_Static_Int32_RDroneMission_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668731);
		NativeMethodInfoPtr_GetDroneMissionMaxRpBonus_Public_Static_Int32_RDroneMission_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668732);
		NativeMethodInfoPtr_AddOneDroneMissionAchieveCount_Public_Static_Void_RDroneMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668733);
		NativeMethodInfoPtr_ChangeItemNum_Public_Static_Void_ItemType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668734);
		NativeMethodInfoPtr_IsBringItem_Public_Static_Boolean_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668735);
		NativeMethodInfoPtr_GetPossessionClothes_Public_Static_List_1_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668736);
		NativeMethodInfoPtr_IsEquipped_Public_Static_Boolean_IEquipableMaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668737);
		NativeMethodInfoPtr_GetOptionMouseXScale_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668738);
		NativeMethodInfoPtr_GetOptionMouseYScale_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668739);
		NativeMethodInfoPtr_GetOptionWheelScale_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668740);
		NativeMethodInfoPtr_GetMissionAchieveCount_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668741);
		NativeMethodInfoPtr_AchieveMission_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668742);
		NativeMethodInfoPtr_AchieveContinueMission_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668743);
		NativeMethodInfoPtr_GetMissionSatisfy_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668744);
		NativeMethodInfoPtr_GetMissionEarnRp_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668745);
		NativeMethodInfoPtr_IsAttachSomeHandcuffs_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668746);
		NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_RankReleaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668747);
		NativeMethodInfoPtr_SetDefaultCustomBody_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668748);
		NativeMethodInfoPtr_SetDefaultCustomFace_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668749);
		NativeMethodInfoPtr_CreateDefaultReinforceEffectAdultGoods_Public_Static_Dictionary_2_MAdultGoodsType_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668750);
		NativeMethodInfoPtr_CreateDefaultReinforceEffectCosplayParts_Public_Static_Dictionary_2_Int32_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668751);
		NativeMethodInfoPtr_CreateDefaultReinforceEffectCostume_Public_Static_Dictionary_2_CostumeType_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668752);
		NativeMethodInfoPtr_CreateDefaultLoadoutData_Public_Static_List_1_LoadoutData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668753);
		NativeMethodInfoPtr_CreateDefaultLoadoutCustomizeData_Public_Static_List_1_LoadoutCustomizeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668754);
		NativeMethodInfoPtr_TransHairType_Public_Static_List_1_HairType_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668755);
		NativeMethodInfoPtr_TransInt_Public_Static_List_1_Int32_List_1_HairType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668756);
		NativeMethodInfoPtr_GetRankNameAutoHide_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668757);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateFacade>.NativeClassPtr, 100668758);
	}

	public GameStateFacade(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
