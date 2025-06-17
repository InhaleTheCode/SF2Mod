using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Evereal.SkyboxCapture;

public static class Utils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimeString_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_String_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Shader_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateTexture_Public_Static_Texture2D_Int32_Int32_Texture2D_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderTexture_Public_Static_RenderTexture_Int32_Int32_Int32_Int32_RenderTexture_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFolder_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BrowseFolder_Public_Static_Void_String_0;

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 33992, RefRangeEnd = 33994, XrefRangeStart = 33982, XrefRangeEnd = 33992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTimeString()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimeString_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33994, XrefRangeEnd = 34007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material CreateMaterial([DefaultParameterValue(null)] string sName, [DefaultParameterValue(null)] Material m2Create)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(m2Create);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_String_Material_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34007, XrefRangeEnd = 34056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Material CreateMaterial([DefaultParameterValue(null)] Shader s, [DefaultParameterValue(null)] Material m2Create)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(m2Create);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Shader_Material_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 34083, RefRangeEnd = 34086, XrefRangeStart = 34056, XrefRangeEnd = 34083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D CreateTexture([DefaultParameterValue(null)] int width, [DefaultParameterValue(null)] int height, [DefaultParameterValue(null)] Texture2D t2Create)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(t2Create);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateTexture_Public_Static_Texture2D_Int32_Int32_Texture2D_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 34119, RefRangeEnd = 34122, XrefRangeStart = 34086, XrefRangeEnd = 34119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RenderTexture CreateRenderTexture([DefaultParameterValue(null)] int width, [DefaultParameterValue(null)] int height, [DefaultParameterValue(null)] int depth, [DefaultParameterValue(null)] int antiAliasing, [DefaultParameterValue(null)] RenderTexture t2Create, bool create = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&width);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &antiAliasing;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(t2Create);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &create;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTexture_Public_Static_RenderTexture_Int32_Int32_Int32_Int32_RenderTexture_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34122, XrefRangeEnd = 34142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CreateFolder([DefaultParameterValue(null)] string f2Create)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(f2Create);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFolder_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34142, XrefRangeEnd = 34168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BrowseFolder([DefaultParameterValue(null)] string folder)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(folder);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BrowseFolder_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Utils()
	{
		Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Evereal.SkyboxCapture", "Utils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
		NativeMethodInfoPtr_GetTimeString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_String_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Shader_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665300);
		NativeMethodInfoPtr_CreateTexture_Public_Static_Texture2D_Int32_Int32_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665301);
		NativeMethodInfoPtr_CreateRenderTexture_Public_Static_RenderTexture_Int32_Int32_Int32_Int32_RenderTexture_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665302);
		NativeMethodInfoPtr_CreateFolder_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665303);
		NativeMethodInfoPtr_BrowseFolder_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100665304);
	}

	public Utils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
