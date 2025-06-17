using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.IO;

namespace ES3Internal;

public class ES3FileStream : FileStream
{
	private static readonly IntPtr NativeFieldInfoPtr_isDisposed;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ES3FileMode_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPath_Protected_Static_String_String_ES3FileMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFileMode_Protected_Static_FileMode_ES3FileMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFileAccess_Protected_Static_FileAccess_ES3FileMode_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	public unsafe bool isDisposed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisposed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDisposed)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31742, RefRangeEnd = 31743, XrefRangeStart = 31723, XrefRangeEnd = 31742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3FileStream([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] ES3FileMode fileMode, [DefaultParameterValue(null)] int bufferSize, [DefaultParameterValue(null)] bool useAsync)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(ES3FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &fileMode;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &useAsync;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_ES3FileMode_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31743, XrefRangeEnd = 31756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetPath([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] ES3FileMode fileMode)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(ES3FileMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &fileMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPath_Protected_Static_String_String_ES3FileMode_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe static FileMode GetFileMode([DefaultParameterValue(null)] ES3FileMode fileMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&fileMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileMode_Protected_Static_FileMode_ES3FileMode_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(FileMode*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static FileAccess GetFileAccess([DefaultParameterValue(null)] ES3FileMode fileMode)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&fileMode);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFileAccess_Protected_Static_FileAccess_ES3FileMode_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(FileAccess*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31756, XrefRangeEnd = 31757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose([DefaultParameterValue(null)] bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&disposing);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3FileStream()
	{
		Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3FileStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr);
		NativeFieldInfoPtr_isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, "isDisposed");
		NativeMethodInfoPtr__ctor_Public_Void_String_ES3FileMode_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, 100665048);
		NativeMethodInfoPtr_GetPath_Protected_Static_String_String_ES3FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, 100665049);
		NativeMethodInfoPtr_GetFileMode_Protected_Static_FileMode_ES3FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, 100665050);
		NativeMethodInfoPtr_GetFileAccess_Protected_Static_FileAccess_ES3FileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, 100665051);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3FileStream>.NativeClassPtr, 100665052);
	}

	public ES3FileStream(IntPtr pointer)
		: base(pointer)
	{
	}
}
