using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Accessory;

public class MAdultGoodsRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeFieldInfoPtr_MotionType;

	private static readonly IntPtr NativeFieldInfoPtr__Price_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DescriptionKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TypeId_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__NameKey_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DokidokiBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__StrangeBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RpBonus_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_EcstasyRisePerSecond;

	private static readonly IntPtr NativeFieldInfoPtr_AdultGoodsEffectType;

	private static readonly IntPtr NativeFieldInfoPtr_Discomfort;

	private static readonly IntPtr NativeFieldInfoPtr_DiscomfortDirect;

	private static readonly IntPtr NativeFieldInfoPtr_SlideManko;

	private static readonly IntPtr NativeFieldInfoPtr_SlideAnal;

	private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MAdultGoodsType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(MAdultGoodsType*)num;
		}
		set
		{
			*(MAdultGoodsType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = mAdultGoodsType;
		}
	}

	public unsafe EquipMotionType MotionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionType);
			return *(EquipMotionType*)num;
		}
		set
		{
			*(EquipMotionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionType)) = equipMotionType;
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

	public unsafe int EcstasyRisePerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRisePerSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyRisePerSecond)) = num;
		}
	}

	public unsafe AdultGoodsEffectType AdultGoodsEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsEffectType);
			return *(AdultGoodsEffectType*)num;
		}
		set
		{
			*(AdultGoodsEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AdultGoodsEffectType)) = adultGoodsEffectType;
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

	public unsafe virtual Il2CppStructArray<int> EffectIds
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68956, XrefRangeEnd = 68962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68962, XrefRangeEnd = 68963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68963, XrefRangeEnd = 68964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68964, XrefRangeEnd = 68965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MAdultGoodsRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MAdultGoodsRecord()
	{
		Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Accessory", "MAdultGoodsRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_MotionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "MotionType");
		NativeFieldInfoPtr__Price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<Price>k__BackingField");
		NativeFieldInfoPtr__DescriptionKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<DescriptionKey>k__BackingField");
		NativeFieldInfoPtr__TypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<TypeId>k__BackingField");
		NativeFieldInfoPtr__NameKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<NameKey>k__BackingField");
		NativeFieldInfoPtr__DokidokiBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<DokidokiBonus>k__BackingField");
		NativeFieldInfoPtr__StrangeBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<StrangeBonus>k__BackingField");
		NativeFieldInfoPtr__RpBonus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "<RpBonus>k__BackingField");
		NativeFieldInfoPtr_EcstasyRisePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "EcstasyRisePerSecond");
		NativeFieldInfoPtr_AdultGoodsEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "AdultGoodsEffectType");
		NativeFieldInfoPtr_Discomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "Discomfort");
		NativeFieldInfoPtr_DiscomfortDirect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "DiscomfortDirect");
		NativeFieldInfoPtr_SlideManko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "SlideManko");
		NativeFieldInfoPtr_SlideAnal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, "SlideAnal");
		NativeMethodInfoPtr_get_Price_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668245);
		NativeMethodInfoPtr_set_Price_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668246);
		NativeMethodInfoPtr_get_DescriptionKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668247);
		NativeMethodInfoPtr_set_DescriptionKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668248);
		NativeMethodInfoPtr_get_TypeId_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668249);
		NativeMethodInfoPtr_SwitchVisible_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668250);
		NativeMethodInfoPtr_get_NameKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668251);
		NativeMethodInfoPtr_set_NameKey_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668252);
		NativeMethodInfoPtr_get_DokidokiBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668253);
		NativeMethodInfoPtr_set_DokidokiBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668254);
		NativeMethodInfoPtr_get_StrangeBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668255);
		NativeMethodInfoPtr_set_StrangeBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668256);
		NativeMethodInfoPtr_get_RpBonus_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668257);
		NativeMethodInfoPtr_set_RpBonus_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668258);
		NativeMethodInfoPtr_get_EffectIds_Public_Virtual_Final_New_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668259);
		NativeMethodInfoPtr_SetReinforceEffect_Public_Virtual_Final_New_Void_Il2CppReferenceArray_1_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668260);
		NativeMethodInfoPtr_TransAttachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668261);
		NativeMethodInfoPtr_TransDetachActionType_Public_Virtual_Final_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668262);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAdultGoodsRecord>.NativeClassPtr, 100668263);
	}

	public MAdultGoodsRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
