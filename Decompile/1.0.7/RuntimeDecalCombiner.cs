using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ch.sycoforge.Decal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

public class RuntimeDecalCombiner : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Public_Static_List_1_GameObject_IList_1_EasyDecal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_List_1_GameObject_Dictionary_2_DecalTextureAtlas_List_1_EasyDecal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_GameObject_IList_1_EasyDecal_DecalTextureAtlas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6436, XrefRangeEnd = 6477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<GameObject> Combine([DefaultParameterValue(null)] IList<EasyDecal> decals)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(decals);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Public_Static_List_1_GameObject_IList_1_EasyDecal_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6525, RefRangeEnd = 6526, XrefRangeStart = 6477, XrefRangeEnd = 6525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<GameObject> Combine([DefaultParameterValue(null)] Dictionary<DecalTextureAtlas, List<EasyDecal>> mappings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mappings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_List_1_GameObject_Dictionary_2_DecalTextureAtlas_List_1_EasyDecal_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6577, RefRangeEnd = 6578, XrefRangeStart = 6526, XrefRangeEnd = 6577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Combine([DefaultParameterValue(null)] IList<EasyDecal> decals, [DefaultParameterValue(null)] DecalTextureAtlas atlas)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(decals);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(atlas);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_GameObject_IList_1_EasyDecal_DecalTextureAtlas_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe RuntimeDecalCombiner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RuntimeDecalCombiner()
	{
		Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RuntimeDecalCombiner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr);
		NativeMethodInfoPtr_Combine_Public_Static_List_1_GameObject_IList_1_EasyDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr_Combine_Private_Static_List_1_GameObject_Dictionary_2_DecalTextureAtlas_List_1_EasyDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr_Combine_Private_Static_GameObject_IList_1_EasyDecal_DecalTextureAtlas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeDecalCombiner>.NativeClassPtr, 100663955);
	}

	public RuntimeDecalCombiner(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
