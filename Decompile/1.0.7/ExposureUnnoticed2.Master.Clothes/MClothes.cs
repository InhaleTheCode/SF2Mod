using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Clothes;

public class MClothes : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_clothes;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_MClothesRecord_ClothesType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_ClothesType_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<MClothesRecord> clothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MClothesRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<ClothesType, MClothesRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ClothesType, MClothesRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 68834, RefRangeEnd = 68837, XrefRangeStart = 68817, XrefRangeEnd = 68834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 68843, RefRangeEnd = 68852, XrefRangeStart = 68837, XrefRangeEnd = 68843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MClothesRecord Get([DefaultParameterValue(null)] ClothesType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_MClothesRecord_ClothesType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 68855, RefRangeEnd = 68856, XrefRangeStart = 68852, XrefRangeEnd = 68855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<ClothesType, MClothesRecord> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_ClothesType_MClothesRecord_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ClothesType, MClothesRecord>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MClothes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MClothes>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MClothes()
	{
		Il2CppClassPointerStore<MClothes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Clothes", "MClothes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MClothes>.NativeClassPtr);
		NativeFieldInfoPtr_clothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothes>.NativeClassPtr, "clothes");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothes>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MClothes>.NativeClassPtr, 100668205);
		NativeMethodInfoPtr_Get_Public_Static_MClothesRecord_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MClothes>.NativeClassPtr, 100668206);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_ClothesType_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MClothes>.NativeClassPtr, 100668207);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MClothes>.NativeClassPtr, 100668208);
	}

	public MClothes(IntPtr pointer)
		: base(pointer)
	{
	}
}
