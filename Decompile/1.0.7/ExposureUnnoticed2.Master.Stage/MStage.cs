using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Stage;

public class MStage : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_stages;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeFieldInfoPtr_list;

	private static readonly IntPtr NativeFieldInfoPtr_sortTypeDict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_MStageRecord_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_StageType_MStageRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetByIndex_Public_Static_MStageRecord_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomType_Public_Static_StageType_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_NextStageTypeOnPath_Public_Static_StageType_StageType_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<MStageRecord> stages
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stages);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MStageRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stages), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<StageType, MStageRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, MStageRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static List<MStageRecord> list
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_list, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<MStageRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_list, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static SortedDictionary<float, StageType> sortTypeDict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sortTypeDict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SortedDictionary<float, StageType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sortTypeDict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 67494, RefRangeEnd = 67501, XrefRangeStart = 67457, XrefRangeEnd = 67494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(38)]
	[CachedScanResults(RefRangeStart = 67509, RefRangeEnd = 67547, XrefRangeStart = 67501, XrefRangeEnd = 67509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MStageRecord Get([DefaultParameterValue(null)] StageType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_MStageRecord_StageType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MStageRecord>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67547, XrefRangeEnd = 67552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<StageType, MStageRecord> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_StageType_MStageRecord_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<StageType, MStageRecord>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 67557, RefRangeEnd = 67559, XrefRangeStart = 67552, XrefRangeEnd = 67557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MStageRecord GetByIndex([DefaultParameterValue(null)] int index)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetByIndex_Public_Static_MStageRecord_Int32_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MStageRecord>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 67595, RefRangeEnd = 67598, XrefRangeStart = 67559, XrefRangeEnd = 67595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StageType GetRandomType(StageType excludeType = StageType.None)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&excludeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomType_Public_Static_StageType_StageType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(StageType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 67602, RefRangeEnd = 67603, XrefRangeStart = 67598, XrefRangeEnd = 67602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StageType NextStageTypeOnPath([DefaultParameterValue(null)] StageType start, [DefaultParameterValue(null)] StageType goal)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&start);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &goal;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NextStageTypeOnPath_Public_Static_StageType_StageType_StageType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(StageType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MStage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MStage>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MStage()
	{
		Il2CppClassPointerStore<MStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Stage", "MStage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MStage>.NativeClassPtr);
		NativeFieldInfoPtr_stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStage>.NativeClassPtr, "stages");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStage>.NativeClassPtr, "dict");
		NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStage>.NativeClassPtr, "list");
		NativeFieldInfoPtr_sortTypeDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MStage>.NativeClassPtr, "sortTypeDict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667927);
		NativeMethodInfoPtr_Get_Public_Static_MStageRecord_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667928);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_StageType_MStageRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667929);
		NativeMethodInfoPtr_GetByIndex_Public_Static_MStageRecord_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667930);
		NativeMethodInfoPtr_GetRandomType_Public_Static_StageType_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667931);
		NativeMethodInfoPtr_NextStageTypeOnPath_Public_Static_StageType_StageType_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667932);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MStage>.NativeClassPtr, 100667933);
	}

	public MStage(IntPtr pointer)
		: base(pointer)
	{
	}
}
