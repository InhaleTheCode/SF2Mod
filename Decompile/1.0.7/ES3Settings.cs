using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

public class ES3Settings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__defaults;

	private static readonly System.IntPtr NativeFieldInfoPtr__defaultSettingsScriptableObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultSettingsPath;

	private static readonly System.IntPtr NativeFieldInfoPtr__unencryptedUncompressedSettings;

	private static readonly System.IntPtr NativeFieldInfoPtr_resourcesExtensions;

	private static readonly System.IntPtr NativeFieldInfoPtr__location;

	private static readonly System.IntPtr NativeFieldInfoPtr_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_encryptionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_compressionType;

	private static readonly System.IntPtr NativeFieldInfoPtr_encryptionPassword;

	private static readonly System.IntPtr NativeFieldInfoPtr_directory;

	private static readonly System.IntPtr NativeFieldInfoPtr_format;

	private static readonly System.IntPtr NativeFieldInfoPtr_prettyPrint;

	private static readonly System.IntPtr NativeFieldInfoPtr_bufferSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_encoding;

	private static readonly System.IntPtr NativeFieldInfoPtr_saveChildren;

	private static readonly System.IntPtr NativeFieldInfoPtr_postprocessRawCachedData;

	private static readonly System.IntPtr NativeFieldInfoPtr_typeChecking;

	private static readonly System.IntPtr NativeFieldInfoPtr_safeReflection;

	private static readonly System.IntPtr NativeFieldInfoPtr_memberReferenceMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_referenceMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_serializationDepthLimit;

	private static readonly System.IntPtr NativeFieldInfoPtr_assemblyNames;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSettingsScriptableObject_Public_Static_get_ES3Defaults_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_unencryptedUncompressedSettings_Internal_Static_get_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_location_Public_get_Location_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_location_Public_set_Void_Location_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_FullPath_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Enum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Enum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EncryptionType_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EncryptionType_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAbsolute_Private_Static_Boolean_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyInto_Private_Void_ES3Settings_0;

	public unsafe static ES3Settings _defaults
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaults, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaults, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ES3Defaults _defaultSettingsScriptableObject
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__defaultSettingsScriptableObject, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Defaults>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__defaultSettingsScriptableObject, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static string defaultSettingsPath
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultSettingsPath, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultSettingsPath, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static ES3Settings _unencryptedUncompressedSettings
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__unencryptedUncompressedSettings, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__unencryptedUncompressedSettings, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStringArray resourcesExtensions
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_resourcesExtensions, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_resourcesExtensions, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ES3.Location _location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__location);
			return *(ES3.Location*)num;
		}
		set
		{
			*(ES3.Location*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__location)) = location;
		}
	}

	public unsafe string path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe ES3.EncryptionType encryptionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encryptionType);
			return *(ES3.EncryptionType*)num;
		}
		set
		{
			*(ES3.EncryptionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encryptionType)) = encryptionType;
		}
	}

	public unsafe ES3.CompressionType compressionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionType);
			return *(ES3.CompressionType*)num;
		}
		set
		{
			*(ES3.CompressionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_compressionType)) = compressionType;
		}
	}

	public unsafe string encryptionPassword
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encryptionPassword);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encryptionPassword), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe ES3.Directory directory
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory);
			return *(ES3.Directory*)num;
		}
		set
		{
			*(ES3.Directory*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_directory)) = directory;
		}
	}

	public unsafe ES3.Format format
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format);
			return *(ES3.Format*)num;
		}
		set
		{
			*(ES3.Format*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format)) = format;
		}
	}

	public unsafe bool prettyPrint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prettyPrint);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prettyPrint)) = flag;
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

	public unsafe Encoding encoding
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoding);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Encoding>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool saveChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveChildren);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveChildren)) = flag;
		}
	}

	public unsafe bool postprocessRawCachedData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postprocessRawCachedData);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postprocessRawCachedData)) = flag;
		}
	}

	public unsafe bool typeChecking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeChecking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_typeChecking)) = flag;
		}
	}

	public unsafe bool safeReflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeReflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_safeReflection)) = flag;
		}
	}

	public unsafe ES3.ReferenceMode memberReferenceMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberReferenceMode);
			return *(ES3.ReferenceMode*)num;
		}
		set
		{
			*(ES3.ReferenceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_memberReferenceMode)) = referenceMode;
		}
	}

	public unsafe ES3.ReferenceMode referenceMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceMode);
			return *(ES3.ReferenceMode*)num;
		}
		set
		{
			*(ES3.ReferenceMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceMode)) = referenceMode;
		}
	}

	public unsafe int serializationDepthLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializationDepthLimit);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serializationDepthLimit)) = num;
		}
	}

	public unsafe Il2CppStringArray assemblyNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_assemblyNames), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ES3Defaults defaultSettingsScriptableObject
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 4611, RefRangeEnd = 4616, XrefRangeStart = 4586, XrefRangeEnd = 4611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSettingsScriptableObject_Public_Static_get_ES3Defaults_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Defaults>(intPtr) : null;
		}
	}

	public unsafe static ES3Settings defaultSettings
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 4639, RefRangeEnd = 4657, XrefRangeStart = 4616, XrefRangeEnd = 4639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ES3Settings_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr) : null;
		}
	}

	public unsafe static ES3Settings unencryptedUncompressedSettings
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4657, XrefRangeEnd = 4689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_unencryptedUncompressedSettings_Internal_Static_get_ES3Settings_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr) : null;
		}
	}

	public unsafe ES3.Location location
	{
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 4698, RefRangeEnd = 4772, XrefRangeStart = 4689, XrefRangeEnd = 4698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_location_Public_get_Location_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ES3.Location*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_location_Public_set_Void_Location_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe string FullPath
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 4780, RefRangeEnd = 4800, XrefRangeStart = 4772, XrefRangeEnd = 4780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FullPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4800, XrefRangeEnd = 4802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings(string path = null, ES3Settings settings = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4802, XrefRangeEnd = 4803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings([DefaultParameterValue(null)] string path, Il2CppReferenceArray<Il2CppSystem.Enum> enums = null)
	{
		if (enums == null)
		{
			enums = (Il2CppReferenceArray<Il2CppSystem.Enum>)(object)new Il2CppStructArray<Il2CppSystem.Enum>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(enums);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 4827, RefRangeEnd = 4830, XrefRangeStart = 4803, XrefRangeEnd = 4827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings(Il2CppReferenceArray<Il2CppSystem.Enum> enums = null)
	{
		if (enums == null)
		{
			enums = (Il2CppReferenceArray<Il2CppSystem.Enum>)(object)new Il2CppStructArray<Il2CppSystem.Enum>(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(enums);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4830, XrefRangeEnd = 4831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings([DefaultParameterValue(null)] ES3.EncryptionType encryptionType, [DefaultParameterValue(null)] string encryptionPassword)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&encryptionType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encryptionPassword);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_EncryptionType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4831, XrefRangeEnd = 4833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] ES3.EncryptionType encryptionType, [DefaultParameterValue(null)] string encryptionPassword, ES3Settings settings = null)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(ES3.EncryptionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &encryptionType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(encryptionPassword);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_EncryptionType_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(227)]
	[CachedScanResults(RefRangeStart = 4855, RefRangeEnd = 5082, XrefRangeStart = 4833, XrefRangeEnd = 4855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Settings([DefaultParameterValue(null)] bool applyDefaults)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&applyDefaults);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static bool IsAbsolute([DefaultParameterValue(null)] string path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAbsolute_Private_Static_Boolean_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 5087, RefRangeEnd = 5099, XrefRangeStart = 5082, XrefRangeEnd = 5087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppSystem.Object Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(79)]
	[CachedScanResults(RefRangeStart = 5099, RefRangeEnd = 5178, XrefRangeStart = 5099, XrefRangeEnd = 5099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CopyInto([DefaultParameterValue(null)] ES3Settings newSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CopyInto_Private_Void_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	public ES3Settings(string path, params Il2CppSystem.Enum[] enums)
		: this(path, new Il2CppReferenceArray<Il2CppSystem.Enum>(enums))
	{
	}

	public ES3Settings(params Il2CppSystem.Enum[] enums)
		: this(new Il2CppReferenceArray<Il2CppSystem.Enum>(enums))
	{
	}

	static ES3Settings()
	{
		Il2CppClassPointerStore<ES3Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3Settings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr);
		NativeFieldInfoPtr__defaults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "_defaults");
		NativeFieldInfoPtr__defaultSettingsScriptableObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "_defaultSettingsScriptableObject");
		NativeFieldInfoPtr_defaultSettingsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "defaultSettingsPath");
		NativeFieldInfoPtr__unencryptedUncompressedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "_unencryptedUncompressedSettings");
		NativeFieldInfoPtr_resourcesExtensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "resourcesExtensions");
		NativeFieldInfoPtr__location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "_location");
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "path");
		NativeFieldInfoPtr_encryptionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "encryptionType");
		NativeFieldInfoPtr_compressionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "compressionType");
		NativeFieldInfoPtr_encryptionPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "encryptionPassword");
		NativeFieldInfoPtr_directory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "directory");
		NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "format");
		NativeFieldInfoPtr_prettyPrint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "prettyPrint");
		NativeFieldInfoPtr_bufferSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "bufferSize");
		NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "encoding");
		NativeFieldInfoPtr_saveChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "saveChildren");
		NativeFieldInfoPtr_postprocessRawCachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "postprocessRawCachedData");
		NativeFieldInfoPtr_typeChecking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "typeChecking");
		NativeFieldInfoPtr_safeReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "safeReflection");
		NativeFieldInfoPtr_memberReferenceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "memberReferenceMode");
		NativeFieldInfoPtr_referenceMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "referenceMode");
		NativeFieldInfoPtr_serializationDepthLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "serializationDepthLimit");
		NativeFieldInfoPtr_assemblyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, "assemblyNames");
		NativeMethodInfoPtr_get_defaultSettingsScriptableObject_Public_Static_get_ES3Defaults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663727);
		NativeMethodInfoPtr_get_defaultSettings_Public_Static_get_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663728);
		NativeMethodInfoPtr_get_unencryptedUncompressedSettings_Internal_Static_get_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663729);
		NativeMethodInfoPtr_get_location_Public_get_Location_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663730);
		NativeMethodInfoPtr_set_location_Public_set_Void_Location_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663731);
		NativeMethodInfoPtr_get_FullPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663732);
		NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663733);
		NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663734);
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663735);
		NativeMethodInfoPtr__ctor_Public_Void_EncryptionType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663736);
		NativeMethodInfoPtr__ctor_Public_Void_String_EncryptionType_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663737);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663738);
		NativeMethodInfoPtr_IsAbsolute_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663739);
		NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663740);
		NativeMethodInfoPtr_CopyInto_Private_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Settings>.NativeClassPtr, 100663741);
	}

	public ES3Settings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
