using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ES3Internal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace ES3Types;

public class ES3Type : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_Read_Public_Abstract_Virtual_New_Object_ES3Reader_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Object_ES3Reader_0, Il2CppClassPointerStore<ES3Type>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadInto_Public_Virtual_New_Void_ES3Reader_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadInto_Public_Virtual_New_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3Type>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadUsingDerivedType_Protected_Void_ES3Reader_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadUsingDerivedType_Protected_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3Type>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_typeFieldName;

	private static readonly System.IntPtr NativeFieldInfoPtr_members;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPrimitive;

	private static readonly System.IntPtr NativeFieldInfoPtr_isValueType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isCollection;

	private static readonly System.IntPtr NativeFieldInfoPtr_isDictionary;

	private static readonly System.IntPtr NativeFieldInfoPtr_isTuple;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEnum;

	private static readonly System.IntPtr NativeFieldInfoPtr_isES3TypeUnityObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReflectedType;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUnsupported;

	private static readonly System.IntPtr NativeFieldInfoPtr_priority;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Object_ES3Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInto_Public_Virtual_New_Void_ES3Reader_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUsingDerivedType_Protected_Void_ES3Reader_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadPropertyName_Internal_String_ES3Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteProperties_Protected_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadProperties_Protected_Object_ES3Reader_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_Il2CppStringArray_0;

	public unsafe static string typeFieldName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_typeFieldName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_typeFieldName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppReferenceArray<ES3Member> members
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ES3Member>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Type type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isPrimitive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrimitive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrimitive)) = flag;
		}
	}

	public unsafe bool isValueType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValueType);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isValueType)) = flag;
		}
	}

	public unsafe bool isCollection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCollection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCollection)) = flag;
		}
	}

	public unsafe bool isDictionary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDictionary);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isDictionary)) = flag;
		}
	}

	public unsafe bool isTuple
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTuple);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isTuple)) = flag;
		}
	}

	public unsafe bool isEnum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnum);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnum)) = flag;
		}
	}

	public unsafe bool isES3TypeUnityObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isES3TypeUnityObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isES3TypeUnityObject)) = flag;
		}
	}

	public unsafe bool isReflectedType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReflectedType);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isReflectedType)) = flag;
		}
	}

	public unsafe bool isUnsupported
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnsupported);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnsupported)) = flag;
		}
	}

	public unsafe int priority
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_priority)) = num;
		}
	}

	[CallerCount(124)]
	[CachedScanResults(RefRangeStart = 12288, RefRangeEnd = 12412, XrefRangeStart = 12281, XrefRangeEnd = 12288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Type([DefaultParameterValue(null)] Il2CppSystem.Type type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Type>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void Write([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_ES3Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object Read<T>([DefaultParameterValue(null)] ES3Reader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_Read_Public_Abstract_Virtual_New_Object_ES3Reader_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12412, XrefRangeEnd = 12417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ReadInto<T>([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadInto_Public_Virtual_New_Void_ES3Reader_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 12422, RefRangeEnd = 12424, XrefRangeStart = 12417, XrefRangeEnd = 12422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WriteUsingDerivedType([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12424, XrefRangeEnd = 12432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReadUsingDerivedType<T>([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadUsingDerivedType_Protected_Void_ES3Reader_Object_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe string ReadPropertyName([DefaultParameterValue(null)] ES3Reader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadPropertyName_Internal_String_ES3Reader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 12439, RefRangeEnd = 12444, XrefRangeStart = 12432, XrefRangeEnd = 12439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteProperties([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteProperties_Protected_Void_Object_ES3Writer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 12626, RefRangeEnd = 12657, XrefRangeStart = 12444, XrefRangeEnd = 12626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object ReadProperties([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadProperties_Protected_Object_ES3Reader_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12657, XrefRangeEnd = 12658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMembers([DefaultParameterValue(null)] bool safe)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&safe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 12671, RefRangeEnd = 12683, XrefRangeStart = 12658, XrefRangeEnd = 12671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetMembers([DefaultParameterValue(null)] bool safe, [DefaultParameterValue(null)] Il2CppStringArray memberNames)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&safe);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Type()
	{
		Il2CppClassPointerStore<ES3Type>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", "ES3Type");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Type>.NativeClassPtr);
		NativeFieldInfoPtr_typeFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "typeFieldName");
		NativeFieldInfoPtr_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "members");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "type");
		NativeFieldInfoPtr_isPrimitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isPrimitive");
		NativeFieldInfoPtr_isValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isValueType");
		NativeFieldInfoPtr_isCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isCollection");
		NativeFieldInfoPtr_isDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isDictionary");
		NativeFieldInfoPtr_isTuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isTuple");
		NativeFieldInfoPtr_isEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isEnum");
		NativeFieldInfoPtr_isES3TypeUnityObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isES3TypeUnityObject");
		NativeFieldInfoPtr_isReflectedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isReflectedType");
		NativeFieldInfoPtr_isUnsupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "isUnsupported");
		NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, "priority");
		NativeMethodInfoPtr__ctor_Protected_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664381);
		NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664382);
		NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664383);
		NativeMethodInfoPtr_ReadInto_Public_Virtual_New_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664384);
		NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664385);
		NativeMethodInfoPtr_ReadUsingDerivedType_Protected_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664386);
		NativeMethodInfoPtr_ReadPropertyName_Internal_String_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664387);
		NativeMethodInfoPtr_WriteProperties_Protected_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664388);
		NativeMethodInfoPtr_ReadProperties_Protected_Object_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664389);
		NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664390);
		NativeMethodInfoPtr_GetMembers_Protected_Void_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Type>.NativeClassPtr, 100664391);
	}

	public ES3Type(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
