using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ES3Internal;

public static class ES3IO : Il2CppSystem.Object
{
	public enum ES3FileMode
	{
		Read,
		Write,
		Append
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_persistentDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_backupFileSuffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_temporaryFileSuffix;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveFile_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveDirectory_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UsesForwardSlash_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombinePathAndFilename_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CommitBackup_Public_Static_Void_ES3Settings_0;

	public unsafe static string persistentDataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_persistentDataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_persistentDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string dataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string backupFileSuffix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_backupFileSuffix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_backupFileSuffix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string temporaryFileSuffix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_temporaryFileSuffix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_temporaryFileSuffix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29171, XrefRangeEnd = 29192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime GetTimestamp([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29192, XrefRangeEnd = 29196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetExtension([DefaultParameterValue(null)] string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29196, XrefRangeEnd = 29201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFile([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29201, XrefRangeEnd = 29202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FileExists([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29202, XrefRangeEnd = 29203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveFile([DefaultParameterValue(null)] string sourcePath, [DefaultParameterValue(null)] string destPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveFile_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29203, XrefRangeEnd = 29204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFile([DefaultParameterValue(null)] string sourcePath, [DefaultParameterValue(null)] string destPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29204, XrefRangeEnd = 29205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveDirectory([DefaultParameterValue(null)] string sourcePath, [DefaultParameterValue(null)] string destPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(sourcePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(destPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveDirectory_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29205, XrefRangeEnd = 29206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateDirectory([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29206, XrefRangeEnd = 29207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DirectoryExists([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29218, RefRangeEnd = 29221, XrefRangeStart = 29207, XrefRangeEnd = 29218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetDirectoryPath([DefaultParameterValue(null)] string path, char seperator = '/')
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(char**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &seperator;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29221, XrefRangeEnd = 29224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UsesForwardSlash([DefaultParameterValue(null)] string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UsesForwardSlash_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29224, XrefRangeEnd = 29230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CombinePathAndFilename([DefaultParameterValue(null)] string directoryPath, [DefaultParameterValue(null)] string fileOrDirectoryName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fileOrDirectoryName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombinePathAndFilename_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29257, XrefRangeStart = 29230, XrefRangeEnd = 29255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDirectories([DefaultParameterValue(null)] string path, bool getFullPaths = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getFullPaths;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 29272, RefRangeEnd = 29274, XrefRangeStart = 29257, XrefRangeEnd = 29272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteDirectory([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 29297, RefRangeEnd = 29298, XrefRangeStart = 29274, XrefRangeEnd = 29297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles([DefaultParameterValue(null)] string path, bool getFullPaths = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &getFullPaths;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29298, XrefRangeEnd = 29299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> ReadAllBytes([DefaultParameterValue(null)] string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29299, XrefRangeEnd = 29320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteAllBytes([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 29345, RefRangeEnd = 29348, XrefRangeStart = 29320, XrefRangeEnd = 29345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CommitBackup([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CommitBackup_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3IO()
	{
		Il2CppClassPointerStore<ES3IO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3IO");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3IO>.NativeClassPtr);
		NativeFieldInfoPtr_persistentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, "persistentDataPath");
		NativeFieldInfoPtr_dataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, "dataPath");
		NativeFieldInfoPtr_backupFileSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, "backupFileSuffix");
		NativeFieldInfoPtr_temporaryFileSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, "temporaryFileSuffix");
		NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664845);
		NativeMethodInfoPtr_GetExtension_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664846);
		NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664847);
		NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664848);
		NativeMethodInfoPtr_MoveFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664849);
		NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664850);
		NativeMethodInfoPtr_MoveDirectory_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664851);
		NativeMethodInfoPtr_CreateDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664852);
		NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664853);
		NativeMethodInfoPtr_GetDirectoryPath_Public_Static_String_String_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664854);
		NativeMethodInfoPtr_UsesForwardSlash_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664855);
		NativeMethodInfoPtr_CombinePathAndFilename_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664856);
		NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664857);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664858);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664859);
		NativeMethodInfoPtr_ReadAllBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664860);
		NativeMethodInfoPtr_WriteAllBytes_Public_Static_Void_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664861);
		NativeMethodInfoPtr_CommitBackup_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IO>.NativeClassPtr, 100664862);
	}

	public ES3IO(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
