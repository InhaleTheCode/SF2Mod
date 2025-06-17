using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Rank;

public class MRank : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_MaxRank;

	private static readonly IntPtr NativeFieldInfoPtr_MaxFearBias;

	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcCurrentRank_Public_Static_MRankRecord_Double_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetByRank_Public_Static_MRankRecord_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_MRankRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MaxRank
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxRank, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxRank, &num);
		}
	}

	public unsafe static int MaxFearBias
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxFearBias, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxFearBias, &num);
		}
	}

	public unsafe Il2CppReferenceArray<MRankRecord> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MRankRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<int, MRankRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, MRankRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 67979, RefRangeEnd = 67983, XrefRangeStart = 67959, XrefRangeEnd = 67979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 67997, RefRangeEnd = 68006, XrefRangeStart = 67983, XrefRangeEnd = 67997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MRankRecord CalcCurrentRank([DefaultParameterValue(null)] double totalRp)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&totalRp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCurrentRank_Public_Static_MRankRecord_Double_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MRankRecord>(intPtr) : null;
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 68012, RefRangeEnd = 68035, XrefRangeStart = 68006, XrefRangeEnd = 68012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MRankRecord GetByRank([DefaultParameterValue(null)] int rank)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&rank);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByRank_Public_Static_MRankRecord_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MRankRecord>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68035, XrefRangeEnd = 68038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<int, MRankRecord> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_MRankRecord_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, MRankRecord>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MRank()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MRank>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MRank()
	{
		Il2CppClassPointerStore<MRank>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Rank", "MRank");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MRank>.NativeClassPtr);
		NativeFieldInfoPtr_MaxRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRank>.NativeClassPtr, "MaxRank");
		NativeFieldInfoPtr_MaxFearBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRank>.NativeClassPtr, "MaxFearBias");
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRank>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRank>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRank>.NativeClassPtr, 100667983);
		NativeMethodInfoPtr_CalcCurrentRank_Public_Static_MRankRecord_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRank>.NativeClassPtr, 100667984);
		NativeMethodInfoPtr_GetByRank_Public_Static_MRankRecord_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRank>.NativeClassPtr, 100667985);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_Int32_MRankRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRank>.NativeClassPtr, 100667986);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRank>.NativeClassPtr, 100667987);
	}

	public MRank(IntPtr pointer)
		: base(pointer)
	{
	}
}
