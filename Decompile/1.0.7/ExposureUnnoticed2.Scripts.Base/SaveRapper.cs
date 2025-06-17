using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.Base;

public class SaveRapper : Il2CppSystem.Object
{
	public enum SaveDataType
	{
		Interrupt,
		AutoSave,
		HomeSave,
		ManualSlot,
		System,
		NewGame
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_Dictionary_2_T1_T2_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_Dictionary_2_T1_T2_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_List_1_T1_0<T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_List_1_T1_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Save_Public_Static_Void_String_T1_0<T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Save_Public_Static_Void_String_T1_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_Dictionary_2_T1_T2_String_Dictionary_2_T1_T2_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_Dictionary_2_T1_T2_String_Dictionary_2_T1_T2_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_List_1_T1_String_List_1_T1_0<T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_List_1_T1_String_List_1_T1_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Load_Public_Static_T1_String_T1_0<T1>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Load_Public_Static_T1_String_T1_0, Il2CppClassPointerStore<SaveRapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SlotName;

	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveSuffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_DirectoryPathPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_Suffix;

	private static readonly System.IntPtr NativeFieldInfoPtr_SystemDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_InterruptDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_HomeSaveDataPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSystemData;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsInterrupt;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsAutoSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHomeSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSlot;

	private static readonly System.IntPtr NativeFieldInfoPtr_sb;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentDataPath;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSaveDataPath_Public_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSpecifiedSaveDataPath_Public_Static_String_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreProcess_Public_Static_Void_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExistFile_Public_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_Dictionary_2_T1_T2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_List_1_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_String_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Int32_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Double_String_Double_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Boolean_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Vector3_String_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Quaternion_String_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Dictionary_2_T1_T2_String_Dictionary_2_T1_T2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_List_1_T1_String_List_1_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T1_String_T1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string SlotName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SlotName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SlotName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string AutoSaveSuffix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoSaveSuffix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoSaveSuffix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DirectoryPathPrefix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DirectoryPathPrefix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DirectoryPathPrefix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string Suffix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Suffix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Suffix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string SystemDataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SystemDataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SystemDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string InterruptDataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InterruptDataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InterruptDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string HomeSaveDataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HomeSaveDataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HomeSaveDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static bool IsSystemData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSystemData, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSystemData, &flag);
		}
	}

	public unsafe static bool IsInterrupt
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsInterrupt, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsInterrupt, &flag);
		}
	}

	public unsafe static bool IsAutoSave
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsAutoSave, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsAutoSave, &flag);
		}
	}

	public unsafe static bool IsHomeSave
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsHomeSave, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsHomeSave, &flag);
		}
	}

	public unsafe static int CurrentSlot
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentSlot, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentSlot, &num);
		}
	}

	public unsafe static StringBuilder sb
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_sb, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_sb, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static string currentDataPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_currentDataPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_currentDataPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82236, RefRangeEnd = 82238, XrefRangeStart = 82202, XrefRangeEnd = 82236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSaveDataPath()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSaveDataPath_Public_Static_String_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 82262, RefRangeEnd = 82268, XrefRangeStart = 82238, XrefRangeEnd = 82262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetSpecifiedSaveDataPath([DefaultParameterValue(null)] SaveDataType type, int slotNum = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slotNum;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpecifiedSaveDataPath_Public_Static_String_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82268, XrefRangeEnd = 82283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsExistSaveData([DefaultParameterValue(null)] SaveDataType type, int slot = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 82291, RefRangeEnd = 82299, XrefRangeStart = 82283, XrefRangeEnd = 82291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PreProcess([DefaultParameterValue(null)] bool isSystem, [DefaultParameterValue(null)] int slot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isSystem);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreProcess_Public_Static_Void_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82299, XrefRangeEnd = 82300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy([DefaultParameterValue(null)] string from, [DefaultParameterValue(null)] string to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(from);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsExistFile([DefaultParameterValue(null)] string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExistFile_Public_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82300, XrefRangeEnd = 82312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82312, XrefRangeEnd = 82319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82319, XrefRangeEnd = 82331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] double value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Double_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82331, XrefRangeEnd = 82343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82343, XrefRangeEnd = 82355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Vector3 value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82355, XrefRangeEnd = 82367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Quaternion value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_String_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82367, XrefRangeEnd = 82372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T1, T2>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Dictionary<T1, T2> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_Dictionary_2_T1_T2_0<T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T1>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] List<T1> value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_List_1_T1_0<T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82372, XrefRangeEnd = 82396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save<T1>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T1 value)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T1 reference;
		if (!typeof(T1).IsValueType)
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
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Save_Public_Static_Void_String_T1_0<T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 82408, RefRangeEnd = 82410, XrefRangeStart = 82396, XrefRangeEnd = 82408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] int defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Int32_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82410, XrefRangeEnd = 82422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static double Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] double defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(double**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Double_String_Double_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(double*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82422, XrefRangeEnd = 82429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82429, XrefRangeEnd = 82441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] bool defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Boolean_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82441, XrefRangeEnd = 82453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Vector3 defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Vector3_String_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82453, XrefRangeEnd = 82465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Load([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Quaternion defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Quaternion_String_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82465, XrefRangeEnd = 82470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Dictionary<T1, T2> Load<T1, T2>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Dictionary<T1, T2> defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_Dictionary_2_T1_T2_String_Dictionary_2_T1_T2_0<T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T1> Load<T1>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] List<T1> defaultValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_List_1_T1_String_List_1_T1_0<T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T1>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82470, XrefRangeEnd = 82496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T1 Load<T1>([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] T1 defaultValue)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T1 reference;
		if (!typeof(T1).IsValueType)
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
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Load_Public_Static_T1_String_T1_0<T1>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T1>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe SaveRapper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SaveRapper()
	{
		Il2CppClassPointerStore<SaveRapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "SaveRapper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr);
		NativeFieldInfoPtr_SlotName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "SlotName");
		NativeFieldInfoPtr_AutoSaveSuffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "AutoSaveSuffix");
		NativeFieldInfoPtr_DirectoryPathPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "DirectoryPathPrefix");
		NativeFieldInfoPtr_Suffix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "Suffix");
		NativeFieldInfoPtr_SystemDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "SystemDataPath");
		NativeFieldInfoPtr_InterruptDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "InterruptDataPath");
		NativeFieldInfoPtr_HomeSaveDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "HomeSaveDataPath");
		NativeFieldInfoPtr_IsSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "IsSystemData");
		NativeFieldInfoPtr_IsInterrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "IsInterrupt");
		NativeFieldInfoPtr_IsAutoSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "IsAutoSave");
		NativeFieldInfoPtr_IsHomeSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "IsHomeSave");
		NativeFieldInfoPtr_CurrentSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "CurrentSlot");
		NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "sb");
		NativeFieldInfoPtr_currentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, "currentDataPath");
		NativeMethodInfoPtr_GetSaveDataPath_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669337);
		NativeMethodInfoPtr_GetSpecifiedSaveDataPath_Public_Static_String_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669338);
		NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669339);
		NativeMethodInfoPtr_PreProcess_Public_Static_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669340);
		NativeMethodInfoPtr_Copy_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669341);
		NativeMethodInfoPtr_IsExistFile_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669342);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669343);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669344);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669345);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669346);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669347);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669348);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_Dictionary_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669349);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_List_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669350);
		NativeMethodInfoPtr_Save_Public_Static_Void_String_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669351);
		NativeMethodInfoPtr_Load_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669352);
		NativeMethodInfoPtr_Load_Public_Static_Double_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669353);
		NativeMethodInfoPtr_Load_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669354);
		NativeMethodInfoPtr_Load_Public_Static_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669355);
		NativeMethodInfoPtr_Load_Public_Static_Vector3_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669356);
		NativeMethodInfoPtr_Load_Public_Static_Quaternion_String_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669357);
		NativeMethodInfoPtr_Load_Public_Static_Dictionary_2_T1_T2_String_Dictionary_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669358);
		NativeMethodInfoPtr_Load_Public_Static_List_1_T1_String_List_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669359);
		NativeMethodInfoPtr_Load_Public_Static_T1_String_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669360);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRapper>.NativeClassPtr, 100669361);
	}

	public SaveRapper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
