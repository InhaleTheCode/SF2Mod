using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.RankRelease;

public class MRankRelease : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetByRank_Public_Static_List_1_MRankReleaseRecord_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_MRankReleaseRecord_RankReleaseType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_RankReleaseType_MRankReleaseRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<MRankReleaseRecord> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MRankReleaseRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<RankReleaseType, MRankReleaseRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<RankReleaseType, MRankReleaseRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 67903, RefRangeEnd = 67906, XrefRangeStart = 67886, XrefRangeEnd = 67903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 67927, RefRangeEnd = 67929, XrefRangeStart = 67906, XrefRangeEnd = 67927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<MRankReleaseRecord> GetByRank([DefaultParameterValue(null)] int rank)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&rank);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByRank_Public_Static_List_1_MRankReleaseRecord_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MRankReleaseRecord>>(intPtr) : null;
	}

	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 67935, RefRangeEnd = 67956, XrefRangeStart = 67929, XrefRangeEnd = 67935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MRankReleaseRecord Get([DefaultParameterValue(null)] RankReleaseType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_MRankReleaseRecord_RankReleaseType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MRankReleaseRecord>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67956, XrefRangeEnd = 67959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<RankReleaseType, MRankReleaseRecord> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_RankReleaseType_MRankReleaseRecord_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<RankReleaseType, MRankReleaseRecord>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MRankRelease()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MRankRelease()
	{
		Il2CppClassPointerStore<MRankRelease>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.RankRelease", "MRankRelease");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr);
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, 100667977);
		NativeMethodInfoPtr_GetByRank_Public_Static_List_1_MRankReleaseRecord_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, 100667978);
		NativeMethodInfoPtr_Get_Public_Static_MRankReleaseRecord_RankReleaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, 100667979);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_RankReleaseType_MRankReleaseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, 100667980);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRelease>.NativeClassPtr, 100667981);
	}

	public MRankRelease(IntPtr pointer)
		: base(pointer)
	{
	}
}
