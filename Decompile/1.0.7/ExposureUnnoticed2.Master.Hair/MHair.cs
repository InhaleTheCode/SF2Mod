using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Hair;

public class MHair : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_records;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_MHairRecord_HairType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_HairType_MHairRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<MHairRecord> records
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MHairRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<HairType, MHairRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<HairType, MHairRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 68353, RefRangeEnd = 68360, XrefRangeStart = 68336, XrefRangeEnd = 68353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 68366, RefRangeEnd = 68374, XrefRangeStart = 68360, XrefRangeEnd = 68366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MHairRecord Get([DefaultParameterValue(null)] HairType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_MHairRecord_HairType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MHairRecord>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 68377, RefRangeEnd = 68378, XrefRangeStart = 68374, XrefRangeEnd = 68377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<HairType, MHairRecord> GetAll()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_HairType_MHairRecord_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<HairType, MHairRecord>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MHair()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MHair>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MHair()
	{
		Il2CppClassPointerStore<MHair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Hair", "MHair");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MHair>.NativeClassPtr);
		NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MHair>.NativeClassPtr, "records");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MHair>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MHair>.NativeClassPtr, 100668029);
		NativeMethodInfoPtr_Get_Public_Static_MHairRecord_HairType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MHair>.NativeClassPtr, 100668030);
		NativeMethodInfoPtr_GetAll_Public_Static_Dictionary_2_HairType_MHairRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MHair>.NativeClassPtr, 100668031);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MHair>.NativeClassPtr, 100668032);
	}

	public MHair(IntPtr pointer)
		: base(pointer)
	{
	}
}
