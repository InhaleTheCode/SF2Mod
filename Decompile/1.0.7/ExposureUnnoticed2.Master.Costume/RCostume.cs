using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.ReinforceEffect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Costume;

public class RCostume : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DescriptionKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsNotHeelToe_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TypeId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__NameKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__EquipMotionType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__CostumeCategory_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__EffectType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RpBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__StrangeBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DokidokiBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HeelSize_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__BraChikubiType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_SlideManko;

	private static readonly IntPtr NativeFieldInfoPtr_SlideAnal;

	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_CostumeType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_CostumeType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsNotHeelToe_Public_Virtual_Final_New_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsNotHeelToe_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HeelToeShapeScale_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HeelToeShapeScale_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EquipMotionType_Public_get_EquipMotionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EquipMotionType_Private_set_Void_EquipMotionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CostumeCategory_Public_get_CostumeCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CostumeCategory_Private_set_Void_CostumeCategory_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EffectType_Public_Virtual_Final_New_get_CostumeEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EffectType_Private_set_Void_CostumeEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HeelSize_Public_Virtual_Final_New_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HeelSize_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BraChikubiType_Public_get_BraChikubiType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BraChikubiType_Private_set_Void_BraChikubiType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CostumeType _Type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField);
			return *(CostumeType*)num;
		}
		set
		{
			*(CostumeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField)) = costumeType;
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

	public unsafe BraChikubiType _BraChikubiType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BraChikubiType_k__BackingField);
			return *(BraChikubiType*)num;
		}
		set
		{
			*(BraChikubiType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BraChikubiType_k__BackingField)) = braChikubiType;
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

	public unsafe CostumeType Type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_CostumeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(CostumeType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Type_Private_set_Void_CostumeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe virtual int Price
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41732, RefRangeEnd = 41740, XrefRangeStart = 41732, XrefRangeEnd = 41740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41569, RefRangeEnd = 41574, XrefRangeStart = 41569, XrefRangeEnd = 41574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe virtual Il2CppStructArray<int> EffectIds
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68519, RefRangeEnd = 68520, XrefRangeStart = 68513, XrefRangeEnd = 68519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	public unsafe BraChikubiType BraChikubiType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BraChikubiType_Public_get_BraChikubiType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(BraChikubiType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BraChikubiType_Private_set_Void_BraChikubiType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68510, XrefRangeEnd = 68513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68520, XrefRangeEnd = 68521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68521, XrefRangeEnd = 68522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68522, XrefRangeEnd = 68523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68523, XrefRangeEnd = 68524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RCostume()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RCostume>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RCostume()
	{
		Il2CppClassPointerStore<RCostume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Costume", "RCostume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RCostume>.NativeClassPtr);
		NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<Type>k__BackingField");
		NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<Price>k__BackingField");
		NativeFieldInfoPtr__DescriptionKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<DescriptionKey>k__BackingField");
		NativeFieldInfoPtr__IsNotHeelToe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<IsNotHeelToe>k__BackingField");
		NativeFieldInfoPtr__HeelToeShapeScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<HeelToeShapeScale>k__BackingField");
		NativeFieldInfoPtr__TypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<TypeId>k__BackingField");
		NativeFieldInfoPtr__NameKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<NameKey>k__BackingField");
		NativeFieldInfoPtr__EquipMotionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<EquipMotionType>k__BackingField");
		NativeFieldInfoPtr__CostumeCategory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<CostumeCategory>k__BackingField");
		NativeFieldInfoPtr__EffectType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<EffectType>k__BackingField");
		NativeFieldInfoPtr__RpBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<RpBonus>k__BackingField");
		NativeFieldInfoPtr__StrangeBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<StrangeBonus>k__BackingField");
		NativeFieldInfoPtr__DokidokiBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<DokidokiBonus>k__BackingField");
		NativeFieldInfoPtr__HeelSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<HeelSize>k__BackingField");
		NativeFieldInfoPtr__BraChikubiType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "<BraChikubiType>k__BackingField");
		NativeFieldInfoPtr_SlideManko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "SlideManko");
		NativeFieldInfoPtr_SlideAnal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RCostume>.NativeClassPtr, "SlideAnal");
		NativeMethodInfoPtr_get_Type_Public_get_CostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668063);
		NativeMethodInfoPtr_set_Type_Private_set_Void_CostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668064);
		NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668065);
		NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668066);
		NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668067);
		NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668068);
		NativeMethodInfoPtr_get_IsNotHeelToe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668069);
		NativeMethodInfoPtr_set_IsNotHeelToe_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668070);
		NativeMethodInfoPtr_get_HeelToeShapeScale_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668071);
		NativeMethodInfoPtr_set_HeelToeShapeScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668072);
		NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668073);
		NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668074);
		NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668075);
		NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668076);
		NativeMethodInfoPtr_get_EquipMotionType_Public_get_EquipMotionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668077);
		NativeMethodInfoPtr_set_EquipMotionType_Private_set_Void_EquipMotionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668078);
		NativeMethodInfoPtr_get_CostumeCategory_Public_get_CostumeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668079);
		NativeMethodInfoPtr_set_CostumeCategory_Private_set_Void_CostumeCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668080);
		NativeMethodInfoPtr_get_EffectType_Public_Virtual_Final_New_get_CostumeEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668081);
		NativeMethodInfoPtr_set_EffectType_Private_set_Void_CostumeEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668082);
		NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668083);
		NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668084);
		NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668085);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668086);
		NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668087);
		NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668088);
		NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668089);
		NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668090);
		NativeMethodInfoPtr_get_HeelSize_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668091);
		NativeMethodInfoPtr_set_HeelSize_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668092);
		NativeMethodInfoPtr_get_BraChikubiType_Public_get_BraChikubiType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668093);
		NativeMethodInfoPtr_set_BraChikubiType_Private_set_Void_BraChikubiType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668094);
		NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668095);
		NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668096);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RCostume>.NativeClassPtr, 100668097);
	}

	public RCostume(IntPtr pointer)
		: base(pointer)
	{
	}
}
