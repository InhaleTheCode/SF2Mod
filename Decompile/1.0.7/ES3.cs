using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ES3Types;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

public class ES3 : Il2CppSystem.Object
{
	public enum Location
	{
		File,
		PlayerPrefs,
		InternalMS,
		Resources,
		Cache
	}

	public enum Directory
	{
		PersistentDataPath,
		DataPath
	}

	public enum EncryptionType
	{
		None,
		AES
	}

	public enum CompressionType
	{
		None,
		Gzip
	}

	public enum Format
	{
		JSON
	}

	public enum ReferenceMode
	{
		ByRef,
		ByValue,
		ByRefAndValue
	}

	public enum ImageType
	{
		JPEG,
		PNG
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_String_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_String_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_String_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_String_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_T_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_String_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T_String_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_String_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_String_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Deserialize_Public_Static_T_Il2CppStructArray_1_Byte_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Deserialize_Public_Static_T_Il2CppStructArray_1_Byte_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DeserializeInto_Public_Static_Void_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_Il2CppStructArray_1_Byte_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DeserializeInto_Public_Static_Void_ES3Type_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_ES3Type_Il2CppStructArray_1_Byte_T_ES3Settings_0, Il2CppClassPointerStore<ES3>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveImageToBytes_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_ImageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawString_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRawString_Public_Static_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Internal_Static_Il2CppStructArray_1_Byte_Object_ES3Type_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_T_Il2CppStructArray_1_Byte_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Internal_Static_Object_ES3Type_Il2CppStructArray_1_Byte_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_Il2CppStructArray_1_Byte_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_ES3Type_Il2CppStructArray_1_Byte_T_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EncryptString_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecryptString_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompressString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecompressString_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFile_Public_Static_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyFile_Public_Static_Void_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameFile_Public_Static_Void_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_ES3Settings_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FileExists_Public_Static_Boolean_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBackup_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateBackup_Public_Static_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheFile_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CacheFile_Public_Static_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1543, XrefRangeEnd = 1550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1550, XrefRangeEnd = 1557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object value, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1557, XrefRangeEnd = 1565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object value, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1565, XrefRangeEnd = 1568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object value, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1568, XrefRangeEnd = 1581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T value)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1581, XrefRangeEnd = 1605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T value, [DefaultParameterValue(null)] string filePath)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1605, XrefRangeEnd = 1613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T value, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_String_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1631, RefRangeEnd = 1634, XrefRangeStart = 1613, XrefRangeEnd = 1631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T value, [DefaultParameterValue(null)] ES3Settings settings)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1634, XrefRangeEnd = 1639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1639, XrefRangeEnd = 1644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1644, XrefRangeEnd = 1650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1663, RefRangeEnd = 1672, XrefRangeStart = 1650, XrefRangeEnd = 1663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1672, XrefRangeEnd = 1678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1678, XrefRangeEnd = 1684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1684, XrefRangeEnd = 1691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1691, XrefRangeEnd = 1693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1693, XrefRangeEnd = 1698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1698, XrefRangeEnd = 1704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1727, RefRangeEnd = 1729, XrefRangeStart = 1704, XrefRangeEnd = 1727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1729, XrefRangeEnd = 1734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1734, XrefRangeEnd = 1739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1739, XrefRangeEnd = 1745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1764, RefRangeEnd = 1767, XrefRangeStart = 1745, XrefRangeEnd = 1764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AppendRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1767, XrefRangeEnd = 1772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] string imagePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1772, XrefRangeEnd = 1778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] string imagePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1778, XrefRangeEnd = 1779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1779, XrefRangeEnd = 1784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] int quality, [DefaultParameterValue(null)] string imagePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1784, XrefRangeEnd = 1790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] int quality, [DefaultParameterValue(null)] string imagePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1824, RefRangeEnd = 1829, XrefRangeStart = 1790, XrefRangeEnd = 1824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveImage([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] int quality, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1829, XrefRangeEnd = 1837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> SaveImageToBytes([DefaultParameterValue(null)] Texture2D texture, [DefaultParameterValue(null)] int quality, [DefaultParameterValue(null)] ImageType imageType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &quality;
		*(ImageType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &imageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveImageToBytes_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_ImageType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1837, XrefRangeEnd = 1844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1844, XrefRangeEnd = 1851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1851, XrefRangeEnd = 1859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1859, XrefRangeEnd = 1862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1862, XrefRangeEnd = 1869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1869, XrefRangeEnd = 1876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] Il2CppSystem.Object defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1876, XrefRangeEnd = 1884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] Il2CppSystem.Object defaultValue, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1884, XrefRangeEnd = 1887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object defaultValue, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1887, XrefRangeEnd = 1894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1894, XrefRangeEnd = 1901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1901, XrefRangeEnd = 1909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_String_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1920, RefRangeEnd = 1924, XrefRangeStart = 1909, XrefRangeEnd = 1920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1924, XrefRangeEnd = 1933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T defaultValue)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1933, XrefRangeEnd = 1951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] T defaultValue)
	{
		//IL_0084->IL0089: Incompatible stack types: I vs Ref
		//IL_0077->IL0089: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_String_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1951, XrefRangeEnd = 1968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] T defaultValue, [DefaultParameterValue(null)] ES3Settings settings)
	{
		//IL_0084->IL0089: Incompatible stack types: I vs Ref
		//IL_0077->IL0089: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_String_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1980, RefRangeEnd = 1984, XrefRangeStart = 1968, XrefRangeEnd = 1980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Load<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T defaultValue, [DefaultParameterValue(null)] ES3Settings settings)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = defaultValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref defaultValue;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T_String_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1984, XrefRangeEnd = 1991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object obj) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_Object_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1991, XrefRangeEnd = 1998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1998, XrefRangeEnd = 2006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2006, XrefRangeEnd = 2009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2009, XrefRangeEnd = 2015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T obj) where T : class
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2015, XrefRangeEnd = 2021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] T obj) where T : class
	{
		//IL_0084->IL0089: Incompatible stack types: I vs Ref
		//IL_0077->IL0089: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_String_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2021, XrefRangeEnd = 2028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] T obj, [DefaultParameterValue(null)] ES3Settings settings) where T : class
	{
		//IL_0084->IL0089: Incompatible stack types: I vs Ref
		//IL_0077->IL0089: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_String_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 2049, RefRangeEnd = 2057, XrefRangeStart = 2028, XrefRangeEnd = 2049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadInto<T>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T obj, [DefaultParameterValue(null)] ES3Settings settings) where T : class
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LoadInto_Public_Static_Void_String_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2057, XrefRangeEnd = 2066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadString([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string defaultValue, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2066, XrefRangeEnd = 2068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadString([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string defaultValue, string filePath = null, ES3Settings settings = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2068, XrefRangeEnd = 2073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> LoadRawBytes()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2073, XrefRangeEnd = 2078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> LoadRawBytes([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2078, XrefRangeEnd = 2084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> LoadRawBytes([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 2120, RefRangeEnd = 2130, XrefRangeStart = 2084, XrefRangeEnd = 2120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> LoadRawBytes([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2130, XrefRangeEnd = 2135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadRawString()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawString_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2135, XrefRangeEnd = 2140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadRawString([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2140, XrefRangeEnd = 2146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadRawString([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2146, XrefRangeEnd = 2147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string LoadRawString([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRawString_Public_Static_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2147, XrefRangeEnd = 2152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadImage([DefaultParameterValue(null)] string imagePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2152, XrefRangeEnd = 2158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadImage([DefaultParameterValue(null)] string imagePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(imagePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2165, RefRangeEnd = 2167, XrefRangeStart = 2158, XrefRangeEnd = 2165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadImage([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2167, XrefRangeEnd = 2173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Texture2D LoadImage([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2173, XrefRangeEnd = 2178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip LoadAudio([DefaultParameterValue(null)] string audioFilePath, [DefaultParameterValue(null)] AudioType audioType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(audioFilePath);
		*(AudioType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &audioType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2249, RefRangeEnd = 2250, XrefRangeStart = 2178, XrefRangeEnd = 2249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioClip LoadAudio([DefaultParameterValue(null)] string audioFilePath, [DefaultParameterValue(null)] AudioType audioType, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(audioFilePath);
		*(AudioType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &audioType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2250, XrefRangeEnd = 2371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Serialize<T>([DefaultParameterValue(null)] T value, ES3Settings settings = null)
	{
		//IL_0054->IL0059: Incompatible stack types: I vs Ref
		//IL_0047->IL0059: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 2396, RefRangeEnd = 2406, XrefRangeStart = 2371, XrefRangeEnd = 2396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> Serialize([DefaultParameterValue(null)] Il2CppSystem.Object value, [DefaultParameterValue(null)] ES3Type type, ES3Settings settings = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Serialize_Internal_Static_Il2CppStructArray_1_Byte_Object_ES3Type_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2406, XrefRangeEnd = 2421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Deserialize<T>([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, ES3Settings settings = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Deserialize_Public_Static_T_Il2CppStructArray_1_Byte_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2452, RefRangeEnd = 2456, XrefRangeStart = 2421, XrefRangeEnd = 2452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object Deserialize([DefaultParameterValue(null)] ES3Type type, [DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, ES3Settings settings = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Deserialize_Internal_Static_Object_ES3Type_Il2CppStructArray_1_Byte_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2456, XrefRangeEnd = 2470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeserializeInto<T>([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] T obj, ES3Settings settings = null) where T : class
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeserializeInto_Public_Static_Void_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2495, RefRangeEnd = 2497, XrefRangeStart = 2470, XrefRangeEnd = 2495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeserializeInto<T>([DefaultParameterValue(null)] ES3Type type, [DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, [DefaultParameterValue(null)] T obj, ES3Settings settings = null) where T : class
	{
		//IL_0084->IL0089: Incompatible stack types: I vs Ref
		//IL_0077->IL0089: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = obj;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref obj;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeserializeInto_Public_Static_Void_ES3Type_Il2CppStructArray_1_Byte_T_ES3Settings_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2497, XrefRangeEnd = 2507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> EncryptBytes([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2507, XrefRangeEnd = 2517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> DecryptBytes([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2517, XrefRangeEnd = 2539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string EncryptString([DefaultParameterValue(null)] string str, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EncryptString_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2539, XrefRangeEnd = 2567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecryptString([DefaultParameterValue(null)] string str, string password = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(password);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecryptString_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2587, RefRangeEnd = 2588, XrefRangeStart = 2567, XrefRangeEnd = 2587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> CompressBytes([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2616, RefRangeEnd = 2617, XrefRangeStart = 2588, XrefRangeEnd = 2616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<byte> DecompressBytes([DefaultParameterValue(null)] Il2CppStructArray<byte> bytes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(bytes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2617, XrefRangeEnd = 2630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string CompressString([DefaultParameterValue(null)] string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompressString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2630, XrefRangeEnd = 2649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string DecompressString([DefaultParameterValue(null)] string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecompressString_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2649, XrefRangeEnd = 2654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFile()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2654, XrefRangeEnd = 2659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFile([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2659, XrefRangeEnd = 2665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFile([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 2675, RefRangeEnd = 2680, XrefRangeStart = 2665, XrefRangeEnd = 2675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteFile([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteFile_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2688, RefRangeEnd = 2692, XrefRangeStart = 2680, XrefRangeEnd = 2688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFile([DefaultParameterValue(null)] string oldFilePath, [DefaultParameterValue(null)] string newFilePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2692, XrefRangeEnd = 2702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFile([DefaultParameterValue(null)] string oldFilePath, [DefaultParameterValue(null)] string newFilePath, [DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2714, RefRangeEnd = 2717, XrefRangeStart = 2702, XrefRangeEnd = 2714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyFile([DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyFile_Public_Static_Void_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2717, XrefRangeEnd = 2725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameFile([DefaultParameterValue(null)] string oldFilePath, [DefaultParameterValue(null)] string newFilePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2725, XrefRangeEnd = 2735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameFile([DefaultParameterValue(null)] string oldFilePath, [DefaultParameterValue(null)] string newFilePath, [DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newFilePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2748, RefRangeEnd = 2751, XrefRangeStart = 2735, XrefRangeEnd = 2748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameFile([DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameFile_Public_Static_Void_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2751, XrefRangeEnd = 2759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyDirectory([DefaultParameterValue(null)] string oldDirectoryPath, [DefaultParameterValue(null)] string newDirectoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newDirectoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2759, XrefRangeEnd = 2769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyDirectory([DefaultParameterValue(null)] string oldDirectoryPath, [DefaultParameterValue(null)] string newDirectoryPath, [DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 2816, RefRangeEnd = 2819, XrefRangeStart = 2769, XrefRangeEnd = 2816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyDirectory([DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2819, XrefRangeEnd = 2827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameDirectory([DefaultParameterValue(null)] string oldDirectoryPath, [DefaultParameterValue(null)] string newDirectoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newDirectoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2827, XrefRangeEnd = 2837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameDirectory([DefaultParameterValue(null)] string oldDirectoryPath, [DefaultParameterValue(null)] string newDirectoryPath, [DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(newDirectoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2854, RefRangeEnd = 2856, XrefRangeStart = 2837, XrefRangeEnd = 2854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RenameDirectory([DefaultParameterValue(null)] ES3Settings oldSettings, [DefaultParameterValue(null)] ES3Settings newSettings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_ES3Settings_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2856, XrefRangeEnd = 2861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteDirectory([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2861, XrefRangeEnd = 2867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteDirectory([DefaultParameterValue(null)] string directoryPath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2877, RefRangeEnd = 2879, XrefRangeStart = 2867, XrefRangeEnd = 2877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteDirectory([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2879, XrefRangeEnd = 2884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteKey([DefaultParameterValue(null)] string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2884, XrefRangeEnd = 2889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteKey([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2889, XrefRangeEnd = 2895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteKey([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2920, RefRangeEnd = 2924, XrefRangeStart = 2895, XrefRangeEnd = 2920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteKey([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2924, XrefRangeEnd = 2929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool KeyExists([DefaultParameterValue(null)] string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2929, XrefRangeEnd = 2934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool KeyExists([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2934, XrefRangeEnd = 2940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool KeyExists([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 2950, RefRangeEnd = 2954, XrefRangeStart = 2940, XrefRangeEnd = 2950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool KeyExists([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2954, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FileExists()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileExists_Public_Static_Boolean_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2959, XrefRangeEnd = 2964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2964, XrefRangeEnd = 2970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FileExists([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 2977, RefRangeEnd = 2991, XrefRangeStart = 2970, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool FileExists([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FileExists_Public_Static_Boolean_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2991, XrefRangeEnd = 2996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DirectoryExists([DefaultParameterValue(null)] string folderPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 2996, XrefRangeEnd = 3002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DirectoryExists([DefaultParameterValue(null)] string folderPath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(folderPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 3007, RefRangeEnd = 3011, XrefRangeStart = 3002, XrefRangeEnd = 3007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DirectoryExists([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3011, XrefRangeEnd = 3016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetKeys()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3016, XrefRangeEnd = 3021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetKeys([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3021, XrefRangeEnd = 3027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetKeys([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3065, RefRangeEnd = 3068, XrefRangeStart = 3027, XrefRangeEnd = 3065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetKeys([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3068, XrefRangeEnd = 3085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3085, XrefRangeEnd = 3090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3090, XrefRangeEnd = 3096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles([DefaultParameterValue(null)] string directoryPath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 3118, RefRangeEnd = 3122, XrefRangeStart = 3096, XrefRangeEnd = 3118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetFiles([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3122, XrefRangeEnd = 3127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDirectories()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3127, XrefRangeEnd = 3132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDirectories([DefaultParameterValue(null)] string directoryPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3132, XrefRangeEnd = 3138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDirectories([DefaultParameterValue(null)] string directoryPath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(directoryPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3151, RefRangeEnd = 3154, XrefRangeStart = 3138, XrefRangeEnd = 3151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetDirectories([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3154, XrefRangeEnd = 3159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBackup()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBackup_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3159, XrefRangeEnd = 3164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBackup([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3164, XrefRangeEnd = 3170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBackup([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 3180, RefRangeEnd = 3183, XrefRangeStart = 3170, XrefRangeEnd = 3180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBackup([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBackup_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3183, XrefRangeEnd = 3188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RestoreBackup([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3188, XrefRangeEnd = 3194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RestoreBackup([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 3204, RefRangeEnd = 3206, XrefRangeStart = 3194, XrefRangeEnd = 3204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RestoreBackup([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3206, XrefRangeEnd = 3211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime GetTimestamp()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3211, XrefRangeEnd = 3216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3216, XrefRangeEnd = 3222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime GetTimestamp([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 3230, RefRangeEnd = 3237, XrefRangeStart = 3222, XrefRangeEnd = 3230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime GetTimestamp([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3237, XrefRangeEnd = 3241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoreCachedFile()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3241, XrefRangeEnd = 3249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoreCachedFile([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3249, XrefRangeEnd = 3258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoreCachedFile([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3262, RefRangeEnd = 3263, XrefRangeStart = 3258, XrefRangeEnd = 3262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StoreCachedFile([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3263, XrefRangeEnd = 3271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CacheFile()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheFile_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3271, XrefRangeEnd = 3279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CacheFile([DefaultParameterValue(null)] string filePath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3279, XrefRangeEnd = 3288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CacheFile([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3292, RefRangeEnd = 3293, XrefRangeStart = 3288, XrefRangeEnd = 3292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CacheFile([DefaultParameterValue(null)] ES3Settings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CacheFile_Public_Static_Void_ES3Settings_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3293, XrefRangeEnd = 3304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe ES3()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3()
	{
		Il2CppClassPointerStore<ES3>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3>.NativeClassPtr);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663425);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663426);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663427);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Object_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663430);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_T_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663431);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663432);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663433);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663434);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_SaveRaw_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_Il2CppStructArray_1_Byte_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_AppendRaw_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663449);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663450);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663451);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663452);
		NativeMethodInfoPtr_SaveImage_Public_Static_Void_Texture2D_Int32_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_SaveImageToBytes_Public_Static_Il2CppStructArray_1_Byte_Texture2D_Int32_ImageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663454);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663455);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663456);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663457);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663458);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663459);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663460);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_String_Object_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663461);
		NativeMethodInfoPtr_Load_Public_Static_Object_String_Object_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663462);
		NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663463);
		NativeMethodInfoPtr_Load_Public_Static_T_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663464);
		NativeMethodInfoPtr_Load_Public_Static_T_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663465);
		NativeMethodInfoPtr_Load_Public_Static_T_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663466);
		NativeMethodInfoPtr_Load_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663467);
		NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663468);
		NativeMethodInfoPtr_Load_Public_Static_T_String_String_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663469);
		NativeMethodInfoPtr_Load_Public_Static_T_String_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663470);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_Object_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_Object_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_String_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_LoadInto_Public_Static_Void_String_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_LoadString_Public_Static_String_String_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_LoadRawBytes_Public_Static_Il2CppStructArray_1_Byte_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_LoadRawString_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663485);
		NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663486);
		NativeMethodInfoPtr_LoadRawString_Public_Static_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663487);
		NativeMethodInfoPtr_LoadRawString_Public_Static_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663488);
		NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663489);
		NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663490);
		NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663491);
		NativeMethodInfoPtr_LoadImage_Public_Static_Texture2D_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663492);
		NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663493);
		NativeMethodInfoPtr_LoadAudio_Public_Static_AudioClip_String_AudioType_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663494);
		NativeMethodInfoPtr_Serialize_Public_Static_Il2CppStructArray_1_Byte_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663495);
		NativeMethodInfoPtr_Serialize_Internal_Static_Il2CppStructArray_1_Byte_Object_ES3Type_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663496);
		NativeMethodInfoPtr_Deserialize_Public_Static_T_Il2CppStructArray_1_Byte_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663497);
		NativeMethodInfoPtr_Deserialize_Internal_Static_Object_ES3Type_Il2CppStructArray_1_Byte_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663498);
		NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_Il2CppStructArray_1_Byte_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663499);
		NativeMethodInfoPtr_DeserializeInto_Public_Static_Void_ES3Type_Il2CppStructArray_1_Byte_T_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663500);
		NativeMethodInfoPtr_EncryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663501);
		NativeMethodInfoPtr_DecryptBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663502);
		NativeMethodInfoPtr_EncryptString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663503);
		NativeMethodInfoPtr_DecryptString_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663504);
		NativeMethodInfoPtr_CompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663505);
		NativeMethodInfoPtr_DecompressBytes_Public_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_CompressString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663507);
		NativeMethodInfoPtr_DecompressString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663508);
		NativeMethodInfoPtr_DeleteFile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663509);
		NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663510);
		NativeMethodInfoPtr_DeleteFile_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663511);
		NativeMethodInfoPtr_DeleteFile_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663512);
		NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663513);
		NativeMethodInfoPtr_CopyFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663514);
		NativeMethodInfoPtr_CopyFile_Public_Static_Void_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663515);
		NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663516);
		NativeMethodInfoPtr_RenameFile_Public_Static_Void_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663517);
		NativeMethodInfoPtr_RenameFile_Public_Static_Void_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663518);
		NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_CopyDirectory_Public_Static_Void_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663521);
		NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663522);
		NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663523);
		NativeMethodInfoPtr_RenameDirectory_Public_Static_Void_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663524);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663525);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663526);
		NativeMethodInfoPtr_DeleteDirectory_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663527);
		NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663528);
		NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663529);
		NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663530);
		NativeMethodInfoPtr_DeleteKey_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663531);
		NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663532);
		NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663533);
		NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663534);
		NativeMethodInfoPtr_KeyExists_Public_Static_Boolean_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663535);
		NativeMethodInfoPtr_FileExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663536);
		NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663537);
		NativeMethodInfoPtr_FileExists_Public_Static_Boolean_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663538);
		NativeMethodInfoPtr_FileExists_Public_Static_Boolean_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663539);
		NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663540);
		NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663541);
		NativeMethodInfoPtr_DirectoryExists_Public_Static_Boolean_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663542);
		NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663543);
		NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663544);
		NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663545);
		NativeMethodInfoPtr_GetKeys_Public_Static_Il2CppStringArray_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663546);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663547);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663548);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663549);
		NativeMethodInfoPtr_GetFiles_Public_Static_Il2CppStringArray_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663550);
		NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663551);
		NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663552);
		NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663553);
		NativeMethodInfoPtr_GetDirectories_Public_Static_Il2CppStringArray_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663554);
		NativeMethodInfoPtr_CreateBackup_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663555);
		NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663556);
		NativeMethodInfoPtr_CreateBackup_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663557);
		NativeMethodInfoPtr_CreateBackup_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663558);
		NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_RestoreBackup_Public_Static_Boolean_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663564);
		NativeMethodInfoPtr_GetTimestamp_Public_Static_DateTime_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663565);
		NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663566);
		NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663567);
		NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663568);
		NativeMethodInfoPtr_StoreCachedFile_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663569);
		NativeMethodInfoPtr_CacheFile_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663570);
		NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663571);
		NativeMethodInfoPtr_CacheFile_Public_Static_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663572);
		NativeMethodInfoPtr_CacheFile_Public_Static_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663573);
		NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663574);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3>.NativeClassPtr, 100663575);
	}

	public ES3(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
