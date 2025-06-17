using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ES3Internal;

public class ES3Prefab : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_prefabId;

	private static readonly IntPtr NativeFieldInfoPtr_localRefs;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Int64_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Int64_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetReferences_Public_Dictionary_2_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyReferences_Public_Void_Dictionary_2_Int64_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNewRefID_Public_Static_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe long prefabId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabId);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prefabId)) = num;
		}
	}

	public unsafe ES3RefIdDictionary localRefs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRefs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ES3RefIdDictionary>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_localRefs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29348, XrefRangeEnd = 29380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29380, XrefRangeEnd = 29383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long Get([DefaultParameterValue(null)] UnityEngine.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29383, XrefRangeEnd = 29388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe long Add([DefaultParameterValue(null)] UnityEngine.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29435, RefRangeEnd = 29436, XrefRangeStart = 29388, XrefRangeEnd = 29435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Dictionary<string, string> GetReferences()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReferences_Public_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29466, RefRangeEnd = 29467, XrefRangeStart = 29436, XrefRangeEnd = 29466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyReferences([DefaultParameterValue(null)] Dictionary<long, long> localToGlobal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(localToGlobal);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyReferences_Public_Void_Dictionary_2_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29467, XrefRangeEnd = 29471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static long GetNewRefID()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNewRefID_Public_Static_Int64_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29471, XrefRangeEnd = 29482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Prefab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Prefab()
	{
		Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Prefab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr);
		NativeFieldInfoPtr_prefabId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, "prefabId");
		NativeFieldInfoPtr_localRefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, "localRefs");
		NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664864);
		NativeMethodInfoPtr_Get_Public_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664865);
		NativeMethodInfoPtr_Add_Public_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664866);
		NativeMethodInfoPtr_GetReferences_Public_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664867);
		NativeMethodInfoPtr_ApplyReferences_Public_Void_Dictionary_2_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664868);
		NativeMethodInfoPtr_GetNewRefID_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664869);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Prefab>.NativeClassPtr, 100664870);
	}

	public ES3Prefab(IntPtr pointer)
		: base(pointer)
	{
	}
}
