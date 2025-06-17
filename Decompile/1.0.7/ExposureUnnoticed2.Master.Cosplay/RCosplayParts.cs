using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.Costume;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Cosplay;

public class RCosplayParts : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr__NameKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DescriptionKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsNotSell_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TypeId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HeelSize_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsStocking_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsEyeMaskEffect_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsCorset_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsFlattenTit_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsHideHair_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsHideInmou_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsHideFuta_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsNotHeelToe_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__EquipMotionType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__CostumeCategory_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__EffectType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HiddenPartsType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__LookHiddenPartMaxStrange_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__MinBreastSize_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ShrinkTypes_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_SlideManko;

	private static readonly IntPtr NativeFieldInfoPtr_SlideAnal;

	private static readonly IntPtr NativeFieldInfoPtr__DokidokiBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__StrangeBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RpBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ReleaseRank_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HideCensorPussy_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HideCensorAnal_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__OffHipDynamicBone_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsHat_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_Discomfort;

	private static readonly IntPtr NativeFieldInfoPtr_DiscomfortDirect;

	private static readonly IntPtr NativeFieldInfoPtr_IsShowCustomizeButton;

	private static readonly IntPtr NativeFieldInfoPtr_CanChangeColor;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeMaterialNumText;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeMaterialNum;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeBoolOption1Text;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeBoolOption2Text;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultColorR;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultColorG;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultColorB;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultShadeColor;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultMaterialIndex;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultChangeBoolOption1;

	private static readonly IntPtr NativeFieldInfoPtr_DefaultChangeBoolOption2;

	private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ParentCosplayType_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsNotSell_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsNotSell_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HeelSize_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HeelSize_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsStocking_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsStocking_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsEyeMaskEffect_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsEyeMaskEffect_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsCorset_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsCorset_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsFlattenTit_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsFlattenTit_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsHideHair_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsHideHair_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsHideInmou_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsHideInmou_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsHideFuta_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsHideFuta_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsNotHeelToe_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsNotHeelToe_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HeelToeShapeScale_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HeelToeShapeScale_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EquipMotionType_Public_get_EquipMotionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EquipMotionType_Private_set_Void_EquipMotionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CostumeCategory_Public_get_CostumeCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CostumeCategory_Private_set_Void_CostumeCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EffectType_Public_Virtual_Final_New_get_CostumeEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EffectType_Private_set_Void_CostumeEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HiddenPartsType_Public_get_HiddenBodyPartsByCostumeType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HiddenPartsType_Private_set_Void_HiddenBodyPartsByCostumeType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LookHiddenPartMaxStrange_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_LookHiddenPartMaxStrange_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MinBreastSize_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MinBreastSize_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ShrinkTypes_Public_get_Il2CppStructArray_1_ShrinkType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ShrinkTypes_Private_set_Void_Il2CppStructArray_1_ShrinkType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ReleaseRank_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ReleaseRank_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HideCensorPussy_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HideCensorPussy_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HideCensorAnal_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HideCensorAnal_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_OffHipDynamicBone_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_OffHipDynamicBone_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsHat_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsHat_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ParentCosplayType_Public_get_CosplayType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ParentCosplayType_Public_set_Void_CosplayType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UniqueId_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string _NameKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameKey_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NameKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int _Price_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Price_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Price_k__BackingField)) = num;
		}
	}

	public unsafe string _DescriptionKey_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DescriptionKey_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DescriptionKey_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool _IsNotSell_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNotSell_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNotSell_k__BackingField)) = flag;
		}
	}

	public unsafe int _TypeId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypeId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TypeId_k__BackingField)) = num;
		}
	}

	public unsafe float _HeelSize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelSize_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelSize_k__BackingField)) = num;
		}
	}

	public unsafe bool _IsStocking_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsStocking_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsStocking_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsEyeMaskEffect_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsEyeMaskEffect_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsEyeMaskEffect_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsCorset_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsCorset_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsCorset_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsFlattenTit_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsFlattenTit_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsFlattenTit_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsHideHair_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideHair_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideHair_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsHideInmou_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideInmou_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideInmou_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsHideFuta_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideFuta_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHideFuta_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsNotHeelToe_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNotHeelToe_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsNotHeelToe_k__BackingField)) = flag;
		}
	}

	public unsafe float _HeelToeShapeScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField)) = num;
		}
	}

	public unsafe EquipMotionType _EquipMotionType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EquipMotionType_k__BackingField);
			return *(EquipMotionType*)num;
		}
		set
		{
			*(EquipMotionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EquipMotionType_k__BackingField)) = equipMotionType;
		}
	}

	public unsafe CostumeCategory _CostumeCategory_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CostumeCategory_k__BackingField);
			return *(CostumeCategory*)num;
		}
		set
		{
			*(CostumeCategory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CostumeCategory_k__BackingField)) = costumeCategory;
		}
	}

	public unsafe CostumeEffectType _EffectType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EffectType_k__BackingField);
			return *(CostumeEffectType*)num;
		}
		set
		{
			*(CostumeEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EffectType_k__BackingField)) = costumeEffectType;
		}
	}

	public unsafe PlayerStateModel.HiddenBodyPartsByCostumeType _HiddenPartsType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HiddenPartsType_k__BackingField);
			return *(PlayerStateModel.HiddenBodyPartsByCostumeType*)num;
		}
		set
		{
			*(PlayerStateModel.HiddenBodyPartsByCostumeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HiddenPartsType_k__BackingField)) = hiddenBodyPartsByCostumeType;
		}
	}

	public unsafe float _LookHiddenPartMaxStrange_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LookHiddenPartMaxStrange_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LookHiddenPartMaxStrange_k__BackingField)) = num;
		}
	}

	public unsafe int _MinBreastSize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinBreastSize_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MinBreastSize_k__BackingField)) = num;
		}
	}

	public unsafe Il2CppStructArray<ShrinkType> _ShrinkTypes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShrinkTypes_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShrinkType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ShrinkTypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool SlideManko
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideManko);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideManko)) = flag;
		}
	}

	public unsafe bool SlideAnal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideAnal);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SlideAnal)) = flag;
		}
	}

	public unsafe int _DokidokiBonus_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DokidokiBonus_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DokidokiBonus_k__BackingField)) = num;
		}
	}

	public unsafe int _StrangeBonus_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StrangeBonus_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StrangeBonus_k__BackingField)) = num;
		}
	}

	public unsafe int _RpBonus_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RpBonus_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RpBonus_k__BackingField)) = num;
		}
	}

	public unsafe int _ReleaseRank_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReleaseRank_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReleaseRank_k__BackingField)) = num;
		}
	}

	public unsafe bool _HideCensorPussy_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HideCensorPussy_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HideCensorPussy_k__BackingField)) = flag;
		}
	}

	public unsafe bool _HideCensorAnal_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HideCensorAnal_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HideCensorAnal_k__BackingField)) = flag;
		}
	}

	public unsafe bool _OffHipDynamicBone_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OffHipDynamicBone_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OffHipDynamicBone_k__BackingField)) = flag;
		}
	}

	public unsafe bool _IsHat_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHat_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsHat_k__BackingField)) = flag;
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

	public unsafe Constant.DiscomfortDirect DiscomfortDirect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiscomfortDirect);
			return *(Constant.DiscomfortDirect*)num;
		}
		set
		{
			*(Constant.DiscomfortDirect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DiscomfortDirect)) = discomfortDirect;
		}
	}

	public unsafe bool IsShowCustomizeButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowCustomizeButton);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowCustomizeButton)) = flag;
		}
	}

	public unsafe bool CanChangeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanChangeColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CanChangeColor)) = flag;
		}
	}

	public unsafe string ChangeMaterialNumText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeMaterialNumText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeMaterialNumText), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int ChangeMaterialNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeMaterialNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeMaterialNum)) = num;
		}
	}

	public unsafe string ChangeBoolOption1Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeBoolOption1Text);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeBoolOption1Text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string ChangeBoolOption2Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeBoolOption2Text);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeBoolOption2Text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int DefaultColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorR)) = num;
		}
	}

	public unsafe int DefaultColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorG)) = num;
		}
	}

	public unsafe int DefaultColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultColorB)) = num;
		}
	}

	public unsafe int DefaultShadeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultShadeColor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultShadeColor)) = num;
		}
	}

	public unsafe int DefaultMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultMaterialIndex)) = num;
		}
	}

	public unsafe bool DefaultChangeBoolOption1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultChangeBoolOption1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultChangeBoolOption1)) = flag;
		}
	}

	public unsafe bool DefaultChangeBoolOption2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultChangeBoolOption2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DefaultChangeBoolOption2)) = flag;
		}
	}

	public unsafe int _Id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField)) = num;
		}
	}

	public unsafe CosplayType _ParentCosplayType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentCosplayType_k__BackingField);
			return *(CosplayType*)num;
		}
		set
		{
			*(CosplayType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ParentCosplayType_k__BackingField)) = cosplayType;
		}
	}

	public unsafe virtual string NameKey
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 41524, RefRangeEnd = 41560, XrefRangeStart = 41524, XrefRangeEnd = 41560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int Price
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48521, RefRangeEnd = 48522, XrefRangeStart = 48521, XrefRangeEnd = 48522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual string DescriptionKey
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 32970, RefRangeEnd = 33003, XrefRangeStart = 32970, XrefRangeEnd = 33003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsNotSell
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNotSell_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsNotSell_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int TypeId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe virtual float HeelSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HeelSize_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HeelSize_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsStocking
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsStocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsStocking_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsEyeMaskEffect
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsEyeMaskEffect_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsEyeMaskEffect_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsCorset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsCorset_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsCorset_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsFlattenTit
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsFlattenTit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsFlattenTit_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsHideHair
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHideHair_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsHideHair_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsHideInmou
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHideInmou_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsHideInmou_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsHideFuta
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHideFuta_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsHideFuta_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual bool IsNotHeelToe
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNotHeelToe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsNotHeelToe_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual float HeelToeShapeScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HeelToeShapeScale_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HeelToeShapeScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe EquipMotionType EquipMotionType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EquipMotionType_Public_get_EquipMotionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(EquipMotionType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EquipMotionType_Private_set_Void_EquipMotionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe CostumeCategory CostumeCategory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CostumeCategory_Public_get_CostumeCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(CostumeCategory*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CostumeCategory_Private_set_Void_CostumeCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual CostumeEffectType EffectType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EffectType_Public_Virtual_Final_New_get_CostumeEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(CostumeEffectType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EffectType_Private_set_Void_CostumeEffectType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PlayerStateModel.HiddenBodyPartsByCostumeType HiddenPartsType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HiddenPartsType_Public_get_HiddenBodyPartsByCostumeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(PlayerStateModel.HiddenBodyPartsByCostumeType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HiddenPartsType_Private_set_Void_HiddenBodyPartsByCostumeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float LookHiddenPartMaxStrange
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LookHiddenPartMaxStrange_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LookHiddenPartMaxStrange_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int MinBreastSize
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinBreastSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MinBreastSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppStructArray<ShrinkType> ShrinkTypes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ShrinkTypes_Public_get_Il2CppStructArray_1_ShrinkType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShrinkType>>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41740, RefRangeEnd = 41741, XrefRangeStart = 41740, XrefRangeEnd = 41741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ShrinkTypes_Private_set_Void_Il2CppStructArray_1_ShrinkType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int DokidokiBonus
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int StrangeBonus
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int RpBonus
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int ReleaseRank
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReleaseRank_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ReleaseRank_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool HideCensorPussy
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HideCensorPussy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HideCensorPussy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool HideCensorAnal
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HideCensorAnal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HideCensorAnal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool OffHipDynamicBone
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OffHipDynamicBone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OffHipDynamicBone_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsHat
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsHat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsHat_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual Il2CppStructArray<int> EffectIds
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68611, XrefRangeEnd = 68617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
	}

	public unsafe int Id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe CosplayType ParentCosplayType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ParentCosplayType_Public_get_CosplayType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(CosplayType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ParentCosplayType_Public_set_Void_CosplayType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int UniqueId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UniqueId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68607, XrefRangeEnd = 68611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SwitchVisible(int defaultType = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&defaultType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68617, XrefRangeEnd = 68618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetReinforceEffect([DefaultParameterValue(null)] Il2CppReferenceArray<RReinforceEffect> effects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(effects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual ActionType TransAttachActionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe virtual ActionType TransDetachActionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68618, XrefRangeEnd = 68619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RCosplayParts()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RCosplayParts()
	{
		Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Cosplay", "RCosplayParts");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr);
		NativeFieldInfoPtr__NameKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<NameKey>k__BackingField");
		NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<Price>k__BackingField");
		NativeFieldInfoPtr__DescriptionKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<DescriptionKey>k__BackingField");
		NativeFieldInfoPtr__IsNotSell_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsNotSell>k__BackingField");
		NativeFieldInfoPtr__TypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<TypeId>k__BackingField");
		NativeFieldInfoPtr__HeelSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<HeelSize>k__BackingField");
		NativeFieldInfoPtr__IsStocking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsStocking>k__BackingField");
		NativeFieldInfoPtr__IsEyeMaskEffect_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsEyeMaskEffect>k__BackingField");
		NativeFieldInfoPtr__IsCorset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsCorset>k__BackingField");
		NativeFieldInfoPtr__IsFlattenTit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsFlattenTit>k__BackingField");
		NativeFieldInfoPtr__IsHideHair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsHideHair>k__BackingField");
		NativeFieldInfoPtr__IsHideInmou_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsHideInmou>k__BackingField");
		NativeFieldInfoPtr__IsHideFuta_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsHideFuta>k__BackingField");
		NativeFieldInfoPtr__IsNotHeelToe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsNotHeelToe>k__BackingField");
		NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<HeelToeShapeScale>k__BackingField");
		NativeFieldInfoPtr__EquipMotionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<EquipMotionType>k__BackingField");
		NativeFieldInfoPtr__CostumeCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<CostumeCategory>k__BackingField");
		NativeFieldInfoPtr__EffectType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<EffectType>k__BackingField");
		NativeFieldInfoPtr__HiddenPartsType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<HiddenPartsType>k__BackingField");
		NativeFieldInfoPtr__LookHiddenPartMaxStrange_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<LookHiddenPartMaxStrange>k__BackingField");
		NativeFieldInfoPtr__MinBreastSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<MinBreastSize>k__BackingField");
		NativeFieldInfoPtr__ShrinkTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<ShrinkTypes>k__BackingField");
		NativeFieldInfoPtr_SlideManko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "SlideManko");
		NativeFieldInfoPtr_SlideAnal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "SlideAnal");
		NativeFieldInfoPtr__DokidokiBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<DokidokiBonus>k__BackingField");
		NativeFieldInfoPtr__StrangeBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<StrangeBonus>k__BackingField");
		NativeFieldInfoPtr__RpBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<RpBonus>k__BackingField");
		NativeFieldInfoPtr__ReleaseRank_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<ReleaseRank>k__BackingField");
		NativeFieldInfoPtr__HideCensorPussy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<HideCensorPussy>k__BackingField");
		NativeFieldInfoPtr__HideCensorAnal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<HideCensorAnal>k__BackingField");
		NativeFieldInfoPtr__OffHipDynamicBone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<OffHipDynamicBone>k__BackingField");
		NativeFieldInfoPtr__IsHat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<IsHat>k__BackingField");
		NativeFieldInfoPtr_Discomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "Discomfort");
		NativeFieldInfoPtr_DiscomfortDirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DiscomfortDirect");
		NativeFieldInfoPtr_IsShowCustomizeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "IsShowCustomizeButton");
		NativeFieldInfoPtr_CanChangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "CanChangeColor");
		NativeFieldInfoPtr_ChangeMaterialNumText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "ChangeMaterialNumText");
		NativeFieldInfoPtr_ChangeMaterialNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "ChangeMaterialNum");
		NativeFieldInfoPtr_ChangeBoolOption1Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "ChangeBoolOption1Text");
		NativeFieldInfoPtr_ChangeBoolOption2Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "ChangeBoolOption2Text");
		NativeFieldInfoPtr_DefaultColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultColorR");
		NativeFieldInfoPtr_DefaultColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultColorG");
		NativeFieldInfoPtr_DefaultColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultColorB");
		NativeFieldInfoPtr_DefaultShadeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultShadeColor");
		NativeFieldInfoPtr_DefaultMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultMaterialIndex");
		NativeFieldInfoPtr_DefaultChangeBoolOption1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultChangeBoolOption1");
		NativeFieldInfoPtr_DefaultChangeBoolOption2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "DefaultChangeBoolOption2");
		NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<Id>k__BackingField");
		NativeFieldInfoPtr__ParentCosplayType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, "<ParentCosplayType>k__BackingField");
		NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668109);
		NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668110);
		NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668111);
		NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668112);
		NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668113);
		NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668114);
		NativeMethodInfoPtr_get_IsNotSell_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668115);
		NativeMethodInfoPtr_set_IsNotSell_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668116);
		NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668117);
		NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668118);
		NativeMethodInfoPtr_get_HeelSize_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668119);
		NativeMethodInfoPtr_set_HeelSize_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668120);
		NativeMethodInfoPtr_get_IsStocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668121);
		NativeMethodInfoPtr_set_IsStocking_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668122);
		NativeMethodInfoPtr_get_IsEyeMaskEffect_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668123);
		NativeMethodInfoPtr_set_IsEyeMaskEffect_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668124);
		NativeMethodInfoPtr_get_IsCorset_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668125);
		NativeMethodInfoPtr_set_IsCorset_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668126);
		NativeMethodInfoPtr_get_IsFlattenTit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668127);
		NativeMethodInfoPtr_set_IsFlattenTit_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668128);
		NativeMethodInfoPtr_get_IsHideHair_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668129);
		NativeMethodInfoPtr_set_IsHideHair_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668130);
		NativeMethodInfoPtr_get_IsHideInmou_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668131);
		NativeMethodInfoPtr_set_IsHideInmou_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668132);
		NativeMethodInfoPtr_get_IsHideFuta_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668133);
		NativeMethodInfoPtr_set_IsHideFuta_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668134);
		NativeMethodInfoPtr_get_IsNotHeelToe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668135);
		NativeMethodInfoPtr_set_IsNotHeelToe_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668136);
		NativeMethodInfoPtr_get_HeelToeShapeScale_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668137);
		NativeMethodInfoPtr_set_HeelToeShapeScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668138);
		NativeMethodInfoPtr_get_EquipMotionType_Public_get_EquipMotionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668139);
		NativeMethodInfoPtr_set_EquipMotionType_Private_set_Void_EquipMotionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668140);
		NativeMethodInfoPtr_get_CostumeCategory_Public_get_CostumeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668141);
		NativeMethodInfoPtr_set_CostumeCategory_Private_set_Void_CostumeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668142);
		NativeMethodInfoPtr_get_EffectType_Public_Virtual_Final_New_get_CostumeEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668143);
		NativeMethodInfoPtr_set_EffectType_Private_set_Void_CostumeEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668144);
		NativeMethodInfoPtr_get_HiddenPartsType_Public_get_HiddenBodyPartsByCostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668145);
		NativeMethodInfoPtr_set_HiddenPartsType_Private_set_Void_HiddenBodyPartsByCostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668146);
		NativeMethodInfoPtr_get_LookHiddenPartMaxStrange_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668147);
		NativeMethodInfoPtr_set_LookHiddenPartMaxStrange_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668148);
		NativeMethodInfoPtr_get_MinBreastSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668149);
		NativeMethodInfoPtr_set_MinBreastSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668150);
		NativeMethodInfoPtr_get_ShrinkTypes_Public_get_Il2CppStructArray_1_ShrinkType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668151);
		NativeMethodInfoPtr_set_ShrinkTypes_Private_set_Void_Il2CppStructArray_1_ShrinkType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668152);
		NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668153);
		NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668154);
		NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668155);
		NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668156);
		NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668157);
		NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668158);
		NativeMethodInfoPtr_get_ReleaseRank_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668159);
		NativeMethodInfoPtr_set_ReleaseRank_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668160);
		NativeMethodInfoPtr_get_HideCensorPussy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668161);
		NativeMethodInfoPtr_set_HideCensorPussy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668162);
		NativeMethodInfoPtr_get_HideCensorAnal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668163);
		NativeMethodInfoPtr_set_HideCensorAnal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668164);
		NativeMethodInfoPtr_get_OffHipDynamicBone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668165);
		NativeMethodInfoPtr_set_OffHipDynamicBone_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668166);
		NativeMethodInfoPtr_get_IsHat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668167);
		NativeMethodInfoPtr_set_IsHat_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668168);
		NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668169);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668170);
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668171);
		NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668172);
		NativeMethodInfoPtr_get_ParentCosplayType_Public_get_CosplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668173);
		NativeMethodInfoPtr_set_ParentCosplayType_Public_set_Void_CosplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668174);
		NativeMethodInfoPtr_get_UniqueId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668175);
		NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668176);
		NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668177);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCosplayParts>.NativeClassPtr, 100668178);
	}

	public RCosplayParts(IntPtr pointer)
		: base(pointer)
	{
	}
}
