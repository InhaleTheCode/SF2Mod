using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Cosplay;

public class MCosplay : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeFieldInfoPtr_list;

	private static readonly IntPtr NativeMethodInfoPtr_get_CosplayNum_Public_Static_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetParts_Public_Static_RCosplayParts_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_RCosplay_CosplayType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_CosplayType_RCosplay_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Static_RCosplay_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<RCosplay> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RCosplay>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<CosplayType, RCosplay> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CosplayType, RCosplay>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static List<RCosplay> list
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_list, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<RCosplay>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_list, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int CosplayNum
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68524, XrefRangeEnd = 68527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CosplayNum_Public_Static_get_Int32_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 68559, RefRangeEnd = 68571, XrefRangeStart = 68527, XrefRangeEnd = 68559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 68574, RefRangeEnd = 68578, XrefRangeStart = 68571, XrefRangeEnd = 68574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RCosplayParts GetParts([DefaultParameterValue(null)] int uniqueId)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParts_Public_Static_RCosplayParts_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RCosplayParts>(intPtr) : null;
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 68584, RefRangeEnd = 68595, XrefRangeStart = 68578, XrefRangeEnd = 68584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RCosplay Get([DefaultParameterValue(null)] CosplayType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_RCosplay_CosplayType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RCosplay>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68595, XrefRangeEnd = 68598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<CosplayType, RCosplay> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_CosplayType_RCosplay_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<CosplayType, RCosplay>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68598, XrefRangeEnd = 68601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RCosplay GetByIndex([DefaultParameterValue(null)] int index)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByIndex_Public_Static_RCosplay_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RCosplay>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MCosplay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCosplay>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MCosplay()
	{
		Il2CppClassPointerStore<MCosplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Cosplay", "MCosplay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCosplay>.NativeClassPtr);
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, "dict");
		NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, "list");
		NativeMethodInfoPtr_get_CosplayNum_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668098);
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668099);
		NativeMethodInfoPtr_GetParts_Public_Static_RCosplayParts_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668100);
		NativeMethodInfoPtr_Get_Public_Static_RCosplay_CosplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668101);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_CosplayType_RCosplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668102);
		NativeMethodInfoPtr_GetByIndex_Public_Static_RCosplay_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668103);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCosplay>.NativeClassPtr, 100668104);
	}

	public MCosplay(IntPtr pointer)
		: base(pointer)
	{
	}
}
