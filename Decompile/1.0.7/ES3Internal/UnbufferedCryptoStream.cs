using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace ES3Internal;

public class UnbufferedCryptoStream : MemoryStream
{
	private static readonly IntPtr NativeFieldInfoPtr_stream;

	private static readonly IntPtr NativeFieldInfoPtr_isReadStream;

	private static readonly IntPtr NativeFieldInfoPtr_password;

	private static readonly IntPtr NativeFieldInfoPtr_bufferSize;

	private static readonly IntPtr NativeFieldInfoPtr_alg;

	private static readonly IntPtr NativeFieldInfoPtr_disposed;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_String_Int32_EncryptionAlgorithm_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	public unsafe Stream stream
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stream);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Stream>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isReadStream
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReadStream);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReadStream)) = flag;
		}
	}

	public unsafe string password
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int bufferSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bufferSize)) = num;
		}
	}

	public unsafe EncryptionAlgorithm alg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alg);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EncryptionAlgorithm>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_alg), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool disposed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disposed)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29092, XrefRangeEnd = 29093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UnbufferedCryptoStream([DefaultParameterValue(null)] Stream stream, [DefaultParameterValue(null)] bool isReadStream, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize, [DefaultParameterValue(null)] EncryptionAlgorithm alg)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isReadStream;
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		*(IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(alg);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_String_Int32_EncryptionAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29093, XrefRangeEnd = 29094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose([DefaultParameterValue(null)] bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&disposing);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UnbufferedCryptoStream()
	{
		Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "UnbufferedCryptoStream");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr);
		NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "stream");
		NativeFieldInfoPtr_isReadStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "isReadStream");
		NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "password");
		NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "bufferSize");
		NativeFieldInfoPtr_alg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "alg");
		NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, "disposed");
		NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_String_Int32_EncryptionAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, 100664841);
		NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnbufferedCryptoStream>.NativeClassPtr, 100664842);
	}

	public UnbufferedCryptoStream(IntPtr pointer)
		: base(pointer)
	{
	}
}
