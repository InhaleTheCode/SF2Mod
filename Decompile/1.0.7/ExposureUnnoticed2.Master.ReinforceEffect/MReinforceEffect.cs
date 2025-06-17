using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.ObjectUI.BuffPanel;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.ReinforceEffect;

public class MReinforceEffect : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_NoEffectId;

	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeFieldInfoPtr_typeIsNegativeDict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_RReinforceEffect_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPlusNegativeEffect_Public_Static_Int32_ReinforceEffectType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr_ToReinforceEffectType_Public_Static_ReinforceEffectType_BuffType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int NoEffectId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoEffectId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoEffectId, &num);
		}
	}

	public unsafe Il2CppReferenceArray<RReinforceEffect> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RReinforceEffect>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<int, RReinforceEffect> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RReinforceEffect>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<ReinforceEffectType, int> typeIsNegativeDict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeIsNegativeDict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ReinforceEffectType, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeIsNegativeDict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 67859, RefRangeEnd = 67864, XrefRangeStart = 67824, XrefRangeEnd = 67859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 67870, RefRangeEnd = 67874, XrefRangeStart = 67864, XrefRangeEnd = 67870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RReinforceEffect Get([DefaultParameterValue(null)] int id)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_RReinforceEffect_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RReinforceEffect>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67874, XrefRangeEnd = 67881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IsPlusNegativeEffect([DefaultParameterValue(null)] ReinforceEffectType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPlusNegativeEffect_Public_Static_Int32_ReinforceEffectType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67881, XrefRangeEnd = 67884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, RReinforceEffect> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RReinforceEffect_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RReinforceEffect>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static ReinforceEffectType ToReinforceEffectType([DefaultParameterValue(null)] BuffPanelItemView.BuffType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToReinforceEffectType_Public_Static_ReinforceEffectType_BuffType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ReinforceEffectType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MReinforceEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MReinforceEffect()
	{
		Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.ReinforceEffect", "MReinforceEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr);
		NativeFieldInfoPtr_NoEffectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, "NoEffectId");
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, "dict");
		NativeFieldInfoPtr_typeIsNegativeDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, "typeIsNegativeDict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667967);
		NativeMethodInfoPtr_Get_Public_Static_RReinforceEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667968);
		NativeMethodInfoPtr_IsPlusNegativeEffect_Public_Static_Int32_ReinforceEffectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667969);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667970);
		NativeMethodInfoPtr_ToReinforceEffectType_Public_Static_ReinforceEffectType_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667971);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MReinforceEffect>.NativeClassPtr, 100667972);
	}

	public MReinforceEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
