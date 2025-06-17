using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace ES3Internal;

public class EncryptionAlgorithm : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyStream_Protected_Static_Void_Stream_Stream_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	[CallerCount(0)]
	public unsafe virtual Il2CppStructArray<byte> Encrypt([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppStructArray<byte> Decrypt([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void Encrypt([DefaultParameterValue(null)] Stream input, [DefaultParameterValue(null)] Stream output, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(output);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void Decrypt([DefaultParameterValue(null)] Stream input, [DefaultParameterValue(null)] Stream output, [DefaultParameterValue(null)] string password, [DefaultParameterValue(null)] int bufferSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(output);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28991, XrefRangeEnd = 28995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyStream([DefaultParameterValue(null)] Stream input, [DefaultParameterValue(null)] Stream output, [DefaultParameterValue(null)] int bufferSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(output);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufferSize;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyStream_Protected_Static_Void_Stream_Stream_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe EncryptionAlgorithm()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EncryptionAlgorithm()
	{
		Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "EncryptionAlgorithm");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr);
		NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664830);
		NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664831);
		NativeMethodInfoPtr_Encrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664832);
		NativeMethodInfoPtr_Decrypt_Public_Abstract_Virtual_New_Void_Stream_Stream_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664833);
		NativeMethodInfoPtr_CopyStream_Protected_Static_Void_Stream_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664834);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EncryptionAlgorithm>.NativeClassPtr, 100664835);
	}

	public EncryptionAlgorithm(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
