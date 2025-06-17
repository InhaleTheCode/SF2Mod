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

public class ES3JSONReader : ES3Reader
{
	private static readonly System.IntPtr NativeFieldInfoPtr_endOfStreamChar;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseReader;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Stream_ES3Settings_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPropertyName_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKeyPrefix_Protected_Virtual_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadKeySuffix_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadObject_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadObject_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadDictionary_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadDictionary_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadDictionaryKey_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadDictionaryKey_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadDictionaryValue_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadDictionaryValue_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadCollection_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadCollection_Internal_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartReadCollectionItem_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndReadCollectionItem_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadString_Private_Void_StreamWriter_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadElement_Internal_Virtual_Il2CppStructArray_1_Byte_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadOrSkipChar_Private_Char_StreamWriter_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadNullOrCharIgnoreWhitespace_Private_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadQuotationMarkOrNullIgnoreWhitespace_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipOpeningBraceOfFile_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsWhiteSpace_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsOpeningBrace_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEndOfValue_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsTerminator_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsQuotationMark_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEndOfStream_Private_Static_Boolean_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetValueString_Private_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_string_Internal_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_ref_Internal_Virtual_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_char_Internal_Virtual_Char_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_float_Internal_Virtual_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_int_Internal_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_bool_Internal_Virtual_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_decimal_Internal_Virtual_Decimal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_double_Internal_Virtual_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_long_Internal_Virtual_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_ulong_Internal_Virtual_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_uint_Internal_Virtual_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_byte_Internal_Virtual_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_sbyte_Internal_Virtual_SByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_short_Internal_Virtual_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_ushort_Internal_Virtual_UInt16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_byteArray_Internal_Virtual_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

	public unsafe static char endOfStreamChar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_endOfStreamChar, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_endOfStreamChar, &c);
		}
	}

	public unsafe StreamReader baseReader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseReader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<StreamReader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseReader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 31484, RefRangeEnd = 31488, XrefRangeStart = 31478, XrefRangeEnd = 31484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3JSONReader([DefaultParameterValue(null)] Stream stream, [DefaultParameterValue(null)] ES3Settings settings, bool readHeaderAndFooter = true)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &readHeaderAndFooter;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Stream_ES3Settings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31488, XrefRangeEnd = 31498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ReadPropertyName()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadPropertyName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31498, XrefRangeEnd = 31508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Type ReadKeyPrefix(bool ignoreType = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ignoreType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadKeyPrefix_Protected_Virtual_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe override void ReadKeySuffix()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadKeySuffix_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31508, XrefRangeEnd = 31509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool StartReadObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadObject_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31509, XrefRangeEnd = 31510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EndReadObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadObject_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe override bool StartReadDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadDictionary_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe override void EndReadDictionary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadDictionary_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31510, XrefRangeEnd = 31511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool StartReadDictionaryKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadDictionaryKey_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31511, XrefRangeEnd = 31512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void EndReadDictionaryKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadDictionaryKey_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe override void StartReadDictionaryValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadDictionaryValue_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31512, XrefRangeEnd = 31513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool EndReadDictionaryValue()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadDictionaryValue_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31513, XrefRangeEnd = 31514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool StartReadCollection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadCollection_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe override void EndReadCollection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadCollection_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31514, XrefRangeEnd = 31515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool StartReadCollectionItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_StartReadCollectionItem_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31515, XrefRangeEnd = 31516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool EndReadCollectionItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_EndReadCollectionItem_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31518, RefRangeEnd = 31519, XrefRangeStart = 31516, XrefRangeEnd = 31518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadString([DefaultParameterValue(null)] StreamWriter writer, bool skip = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadString_Private_Void_StreamWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31519, XrefRangeEnd = 31552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<byte> ReadElement(bool skip = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&skip);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ReadElement_Internal_Virtual_Il2CppStructArray_1_Byte_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31552, RefRangeEnd = 31554, XrefRangeStart = 31552, XrefRangeEnd = 31552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char ReadOrSkipChar([DefaultParameterValue(null)] StreamWriter writer, [DefaultParameterValue(null)] bool skip)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &skip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadOrSkipChar_Private_Char_StreamWriter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 31555, RefRangeEnd = 31562, XrefRangeStart = 31554, XrefRangeEnd = 31555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char ReadCharIgnoreWhitespace(bool ignoreTrailingWhitespace = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ignoreTrailingWhitespace);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31566, RefRangeEnd = 31568, XrefRangeStart = 31562, XrefRangeEnd = 31566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadNullOrCharIgnoreWhitespace([DefaultParameterValue(null)] char expectedChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expectedChar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadNullOrCharIgnoreWhitespace_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 31570, RefRangeEnd = 31573, XrefRangeStart = 31568, XrefRangeEnd = 31570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char ReadCharIgnoreWhitespace([DefaultParameterValue(null)] char expectedChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expectedChar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31577, RefRangeEnd = 31578, XrefRangeStart = 31573, XrefRangeEnd = 31577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadQuotationMarkOrNullIgnoreWhitespace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadQuotationMarkOrNullIgnoreWhitespace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31578, XrefRangeEnd = 31580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char PeekCharIgnoreWhitespace([DefaultParameterValue(null)] char expectedChar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expectedChar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 31581, RefRangeEnd = 31586, XrefRangeStart = 31580, XrefRangeEnd = 31581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe char PeekCharIgnoreWhitespace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31586, XrefRangeEnd = 31587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipWhiteSpace()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31587, XrefRangeEnd = 31588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipOpeningBraceOfFile()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipOpeningBraceOfFile_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static bool IsWhiteSpace([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWhiteSpace_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsOpeningBrace([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOpeningBrace_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsEndOfValue([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEndOfValue_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsTerminator([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsTerminator_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsQuotationMark([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsQuotationMark_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsEndOfStream([DefaultParameterValue(null)] char c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEndOfStream_Private_Static_Boolean_Char_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 31596, RefRangeEnd = 31608, XrefRangeStart = 31588, XrefRangeEnd = 31596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetValueString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValueString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31608, XrefRangeEnd = 31619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string Read_string()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_string_Internal_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31619, XrefRangeEnd = 31640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override long Read_ref()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_ref_Internal_Virtual_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31640, XrefRangeEnd = 31643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override char Read_char()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_char_Internal_Virtual_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(char*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31643, XrefRangeEnd = 31652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float Read_float()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_float_Internal_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31652, XrefRangeEnd = 31654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int Read_int()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_int_Internal_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31654, XrefRangeEnd = 31659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Read_bool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_bool_Internal_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31659, XrefRangeEnd = 31676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Decimal Read_decimal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_decimal_Internal_Virtual_Decimal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Il2CppSystem.Decimal*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31676, XrefRangeEnd = 31685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override double Read_double()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_double_Internal_Virtual_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(double*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31685, XrefRangeEnd = 31687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override long Read_long()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_long_Internal_Virtual_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31687, XrefRangeEnd = 31694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ulong Read_ulong()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_ulong_Internal_Virtual_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ulong*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31694, XrefRangeEnd = 31701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override uint Read_uint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_uint_Internal_Virtual_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(uint*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override byte Read_byte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_byte_Internal_Virtual_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(byte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override sbyte Read_sbyte()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_sbyte_Internal_Virtual_SByte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(sbyte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override short Read_short()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_short_Internal_Virtual_Int16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(short*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override ushort Read_ushort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_ushort_Internal_Virtual_UInt16_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ushort*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31701, XrefRangeEnd = 31714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppStructArray<byte> Read_byteArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Read_byteArray_Internal_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31714, XrefRangeEnd = 31719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3JSONReader()
	{
		Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3JSONReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr);
		NativeFieldInfoPtr_endOfStreamChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, "endOfStreamChar");
		NativeFieldInfoPtr_baseReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, "baseReader");
		NativeMethodInfoPtr__ctor_Internal_Void_Stream_ES3Settings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664991);
		NativeMethodInfoPtr_ReadPropertyName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664992);
		NativeMethodInfoPtr_ReadKeyPrefix_Protected_Virtual_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664993);
		NativeMethodInfoPtr_ReadKeySuffix_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664994);
		NativeMethodInfoPtr_StartReadObject_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664995);
		NativeMethodInfoPtr_EndReadObject_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664996);
		NativeMethodInfoPtr_StartReadDictionary_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664997);
		NativeMethodInfoPtr_EndReadDictionary_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664998);
		NativeMethodInfoPtr_StartReadDictionaryKey_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100664999);
		NativeMethodInfoPtr_EndReadDictionaryKey_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665000);
		NativeMethodInfoPtr_StartReadDictionaryValue_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665001);
		NativeMethodInfoPtr_EndReadDictionaryValue_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665002);
		NativeMethodInfoPtr_StartReadCollection_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665003);
		NativeMethodInfoPtr_EndReadCollection_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665004);
		NativeMethodInfoPtr_StartReadCollectionItem_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665005);
		NativeMethodInfoPtr_EndReadCollectionItem_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665006);
		NativeMethodInfoPtr_ReadString_Private_Void_StreamWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665007);
		NativeMethodInfoPtr_ReadElement_Internal_Virtual_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665008);
		NativeMethodInfoPtr_ReadOrSkipChar_Private_Char_StreamWriter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665009);
		NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665010);
		NativeMethodInfoPtr_ReadNullOrCharIgnoreWhitespace_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665011);
		NativeMethodInfoPtr_ReadCharIgnoreWhitespace_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665012);
		NativeMethodInfoPtr_ReadQuotationMarkOrNullIgnoreWhitespace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665013);
		NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665014);
		NativeMethodInfoPtr_PeekCharIgnoreWhitespace_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665015);
		NativeMethodInfoPtr_SkipWhiteSpace_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665016);
		NativeMethodInfoPtr_SkipOpeningBraceOfFile_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665017);
		NativeMethodInfoPtr_IsWhiteSpace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665018);
		NativeMethodInfoPtr_IsOpeningBrace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665019);
		NativeMethodInfoPtr_IsEndOfValue_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665020);
		NativeMethodInfoPtr_IsTerminator_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665021);
		NativeMethodInfoPtr_IsQuotationMark_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665022);
		NativeMethodInfoPtr_IsEndOfStream_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665023);
		NativeMethodInfoPtr_GetValueString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665024);
		NativeMethodInfoPtr_Read_string_Internal_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665025);
		NativeMethodInfoPtr_Read_ref_Internal_Virtual_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665026);
		NativeMethodInfoPtr_Read_char_Internal_Virtual_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665027);
		NativeMethodInfoPtr_Read_float_Internal_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665028);
		NativeMethodInfoPtr_Read_int_Internal_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665029);
		NativeMethodInfoPtr_Read_bool_Internal_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665030);
		NativeMethodInfoPtr_Read_decimal_Internal_Virtual_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665031);
		NativeMethodInfoPtr_Read_double_Internal_Virtual_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665032);
		NativeMethodInfoPtr_Read_long_Internal_Virtual_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665033);
		NativeMethodInfoPtr_Read_ulong_Internal_Virtual_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665034);
		NativeMethodInfoPtr_Read_uint_Internal_Virtual_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665035);
		NativeMethodInfoPtr_Read_byte_Internal_Virtual_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665036);
		NativeMethodInfoPtr_Read_sbyte_Internal_Virtual_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665037);
		NativeMethodInfoPtr_Read_short_Internal_Virtual_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665038);
		NativeMethodInfoPtr_Read_ushort_Internal_Virtual_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665039);
		NativeMethodInfoPtr_Read_byteArray_Internal_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665040);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3JSONReader>.NativeClassPtr, 100665041);
	}

	public ES3JSONReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
