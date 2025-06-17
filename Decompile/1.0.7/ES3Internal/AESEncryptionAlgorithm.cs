using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;

namespace ES3Internal;

public class AESEncryptionAlgorithm : EncryptionAlgorithm
{
	private static readonly IntPtr NativeFieldInfoPtr_ivSize;

	private static readonly IntPtr NativeFieldInfoPtr_keySize;

	private static readonly IntPtr NativeFieldInfoPtr_pwIterations;

	private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int ivSize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ivSize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ivSize, &num);
		}
	}

	public unsafe static int keySize
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keySize, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keySize, &num);
		}
	}

	public unsafe static int pwIterations
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_pwIterations, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_pwIterations, &num);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28995, XrefRangeEnd = 29012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<byte> Encrypt([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Encrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29012, XrefRangeEnd = 29029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<byte> Decrypt([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Decrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29029, XrefRangeEnd = 29059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Encrypt([DefaultParameterValue(null)] Stream input, [DefaultParameterValue(null)] Stream output, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(output);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Encrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29059, XrefRangeEnd = 29092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Decrypt([DefaultParameterValue(null)] Stream input, [DefaultParameterValue(null)] Stream output, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(output);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Decrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe AESEncryptionAlgorithm()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AESEncryptionAlgorithm()
	{
		Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "AESEncryptionAlgorithm");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr);
		NativeFieldInfoPtr_ivSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, "ivSize");
		NativeFieldInfoPtr_keySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, "keySize");
		NativeFieldInfoPtr_pwIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, "pwIterations");
		NativeMethodInfoPtr_Encrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, 100664836);
		NativeMethodInfoPtr_Decrypt_Public_Virtual_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, 100664837);
		NativeMethodInfoPtr_Encrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, 100664838);
		NativeMethodInfoPtr_Decrypt_Public_Virtual_Void_Stream_Stream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, 100664839);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AESEncryptionAlgorithm>.NativeClassPtr, 100664840);
	}

	public AESEncryptionAlgorithm(IntPtr pointer)
		: base(pointer)
	{
	}
}
