using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UB;

public static class TransformExt : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SaveLocal_Public_Static_StoreTransform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveWorld_Public_Static_StoreTransform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLocal_Public_Static_Void_Transform_StoreTransform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadWorld_Public_Static_Void_Transform_StoreTransform_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35276, XrefRangeEnd = 35288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StoreTransform SaveLocal([DefaultParameterValue(null)] this Transform aTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveLocal_Public_Static_StoreTransform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StoreTransform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35288, XrefRangeEnd = 35300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StoreTransform SaveWorld([DefaultParameterValue(null)] this Transform aTransform)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aTransform);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveWorld_Public_Static_StoreTransform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StoreTransform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35300, XrefRangeEnd = 35307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadLocal([DefaultParameterValue(null)] this Transform aTransform, [DefaultParameterValue(null)] StoreTransform aData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(aData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLocal_Public_Static_Void_Transform_StoreTransform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35307, XrefRangeEnd = 35314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadWorld([DefaultParameterValue(null)] this Transform aTransform, [DefaultParameterValue(null)] StoreTransform aData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(aTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(aData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadWorld_Public_Static_Void_Transform_StoreTransform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TransformExt()
	{
		Il2CppClassPointerStore<TransformExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "TransformExt");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformExt>.NativeClassPtr);
		NativeMethodInfoPtr_SaveLocal_Public_Static_StoreTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExt>.NativeClassPtr, 100665378);
		NativeMethodInfoPtr_SaveWorld_Public_Static_StoreTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExt>.NativeClassPtr, 100665379);
		NativeMethodInfoPtr_LoadLocal_Public_Static_Void_Transform_StoreTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExt>.NativeClassPtr, 100665380);
		NativeMethodInfoPtr_LoadWorld_Public_Static_Void_Transform_StoreTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformExt>.NativeClassPtr, 100665381);
	}

	public TransformExt(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
