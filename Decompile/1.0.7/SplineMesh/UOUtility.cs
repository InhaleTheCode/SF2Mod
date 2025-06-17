using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SplineMesh;

public static class UOUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_0;

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 10695, RefRangeEnd = 10705, XrefRangeStart = 10668, XrefRangeEnd = 10695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Create([DefaultParameterValue(null)] string name, [DefaultParameterValue(null)] GameObject parent, Il2CppReferenceArray<Il2CppSystem.Type> components = null)
	{
		if (components == null)
		{
			components = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(components);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 10729, RefRangeEnd = 10730, XrefRangeStart = 10705, XrefRangeEnd = 10729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GameObject Instantiate([DefaultParameterValue(null)] GameObject prefab, [DefaultParameterValue(null)] Transform parent)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parent);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 10743, RefRangeEnd = 10746, XrefRangeStart = 10730, XrefRangeEnd = 10743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy([DefaultParameterValue(null)] GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10746, XrefRangeEnd = 10759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy([DefaultParameterValue(null)] Component comp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Destroy_Public_Static_Void_Component_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 10781, RefRangeEnd = 10784, XrefRangeStart = 10759, XrefRangeEnd = 10781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildren([DefaultParameterValue(null)] GameObject go)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	public static GameObject Create(string name, GameObject parent, params Il2CppSystem.Type[] components)
	{
		return Create(name, parent, new Il2CppReferenceArray<Il2CppSystem.Type>(components));
	}

	static UOUtility()
	{
		Il2CppClassPointerStore<UOUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "UOUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UOUtility>.NativeClassPtr);
		NativeMethodInfoPtr_Create_Public_Static_GameObject_String_GameObject_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UOUtility>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_Instantiate_Public_Static_GameObject_GameObject_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UOUtility>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UOUtility>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_Destroy_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UOUtility>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UOUtility>.NativeClassPtr, 100664262);
	}

	public UOUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
