using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Stage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.FastTravel;

public class MFastTravel : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_RFastTravel_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateListByStage_Public_Static_List_1_RFastTravel_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RFastTravel_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<RFastTravel> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RFastTravel>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<int, RFastTravel> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RFastTravel>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 68405, RefRangeEnd = 68409, XrefRangeStart = 68388, XrefRangeEnd = 68405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68409, XrefRangeEnd = 68415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RFastTravel Get([DefaultParameterValue(null)] int id)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_RFastTravel_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RFastTravel>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 68437, RefRangeEnd = 68439, XrefRangeStart = 68415, XrefRangeEnd = 68437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<RFastTravel> CreateListByStage([DefaultParameterValue(null)] StageType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateListByStage_Public_Static_List_1_RFastTravel_StageType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<RFastTravel>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 68442, RefRangeEnd = 68443, XrefRangeStart = 68439, XrefRangeEnd = 68442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, RFastTravel> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RFastTravel_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, RFastTravel>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MFastTravel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MFastTravel()
	{
		Il2CppClassPointerStore<MFastTravel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.FastTravel", "MFastTravel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr);
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, 100668044);
		NativeMethodInfoPtr_Get_Public_Static_RFastTravel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, 100668045);
		NativeMethodInfoPtr_CreateListByStage_Public_Static_List_1_RFastTravel_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, 100668046);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_RFastTravel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, 100668047);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFastTravel>.NativeClassPtr, 100668048);
	}

	public MFastTravel(IntPtr pointer)
		: base(pointer)
	{
	}
}
