using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace ES3Internal;

public class ES3PlayerPrefsStream : MemoryStream
{
	private static readonly IntPtr NativeFieldInfoPtr_path;

	private static readonly IntPtr NativeFieldInfoPtr_append;

	private static readonly IntPtr NativeFieldInfoPtr_isWriteStream;

	private static readonly IntPtr NativeFieldInfoPtr_isDisposed;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetData_Private_Static_Il2CppStructArray_1_Byte_String_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	public unsafe string path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool append
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_append);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_append)) = flag;
		}
	}

	public unsafe bool isWriteStream
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWriteStream);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isWriteStream)) = flag;
		}
	}

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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31757, XrefRangeEnd = 31759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3PlayerPrefsStream([DefaultParameterValue(null)] string path)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31759, XrefRangeEnd = 31760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3PlayerPrefsStream([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] int bufferSize, bool append = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &append;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31786, RefRangeEnd = 31788, XrefRangeStart = 31760, XrefRangeEnd = 31786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> GetData([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] bool isWriteStream)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isWriteStream;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetData_Private_Static_Il2CppStructArray_1_Byte_String_Boolean_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31788, XrefRangeEnd = 31825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose([DefaultParameterValue(null)] bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&disposing);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3PlayerPrefsStream()
	{
		Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3PlayerPrefsStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr);
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, "path");
		NativeFieldInfoPtr_append = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, "append");
		NativeFieldInfoPtr_isWriteStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, "isWriteStream");
		NativeFieldInfoPtr_isDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, "isDisposed");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, 100665053);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, 100665054);
		NativeMethodInfoPtr_GetData_Private_Static_Il2CppStructArray_1_Byte_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, 100665055);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3PlayerPrefsStream>.NativeClassPtr, 100665056);
	}

	public ES3PlayerPrefsStream(IntPtr pointer)
		: base(pointer)
	{
	}
}
