using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Item;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Achievement;

public class MAchievement : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_RAchievement_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RAchievement_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_CosplayType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_ItemType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<RAchievement> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RAchievement>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<int, RAchievement> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RAchievement>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 69060, RefRangeEnd = 69067, XrefRangeStart = 69043, XrefRangeEnd = 69060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69067, XrefRangeEnd = 69073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RAchievement Get([DefaultParameterValue(null)] int id)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_RAchievement_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RAchievement>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69073, XrefRangeEnd = 69076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, RAchievement> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RAchievement_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RAchievement>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69091, RefRangeEnd = 69092, XrefRangeStart = 69076, XrefRangeEnd = 69091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRelease([DefaultParameterValue(null)] CosplayType cosplayType)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&cosplayType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_CosplayType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69107, RefRangeEnd = 69108, XrefRangeStart = 69092, XrefRangeEnd = 69107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRelease([DefaultParameterValue(null)] ItemType itemType)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&itemType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_ItemType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MAchievement()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MAchievement>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MAchievement()
	{
		Il2CppClassPointerStore<MAchievement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Achievement", "MAchievement");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MAchievement>.NativeClassPtr);
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668280);
		NativeMethodInfoPtr_Get_Public_Static_RAchievement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668281);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668282);
		NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_CosplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668283);
		NativeMethodInfoPtr_IsRelease_Public_Static_Boolean_ItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668284);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAchievement>.NativeClassPtr, 100668285);
	}

	public MAchievement(IntPtr pointer)
		: base(pointer)
	{
	}
}
