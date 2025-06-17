using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace ES3Internal;

public static class ES3Stream : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStream_Public_Static_Stream_ES3Settings_ES3FileMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateStream_Public_Static_Stream_Stream_ES3Settings_ES3FileMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Stream_Stream_0;

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 31933, RefRangeEnd = 31949, XrefRangeStart = 31866, XrefRangeEnd = 31933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream CreateStream([DefaultParameterValue(null)] ES3Settings settings, [DefaultParameterValue(null)] ES3FileMode fileMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		*(ES3FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStream_Public_Static_Stream_ES3Settings_ES3FileMode_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 31975, RefRangeEnd = 31983, XrefRangeStart = 31949, XrefRangeEnd = 31975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Stream CreateStream([DefaultParameterValue(null)] Stream stream, [DefaultParameterValue(null)] ES3Settings settings, [DefaultParameterValue(null)] ES3FileMode fileMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		*(ES3FileMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fileMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStream_Public_Static_Stream_Stream_ES3Settings_ES3FileMode_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31988, RefRangeEnd = 31990, XrefRangeStart = 31983, XrefRangeEnd = 31988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTo([DefaultParameterValue(null)] Stream source, [DefaultParameterValue(null)] Stream destination)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(destination);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyTo_Public_Static_Void_Stream_Stream_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Stream()
	{
		Il2CppClassPointerStore<ES3Stream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Stream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Stream>.NativeClassPtr);
		NativeMethodInfoPtr_CreateStream_Public_Static_Stream_ES3Settings_ES3FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Stream>.NativeClassPtr, 100665061);
		NativeMethodInfoPtr_CreateStream_Public_Static_Stream_Stream_ES3Settings_ES3FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Stream>.NativeClassPtr, 100665062);
		NativeMethodInfoPtr_CopyTo_Public_Static_Void_Stream_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Stream>.NativeClassPtr, 100665063);
	}

	public ES3Stream(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
