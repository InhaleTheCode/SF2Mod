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

public class ES3TupleType : ES3Type
{
	private sealed class MethodInfoStoreGeneric_Read_Public_Virtual_Object_ES3Reader_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0, Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_es3Types;

	private static readonly System.IntPtr NativeFieldInfoPtr_types;

	private static readonly System.IntPtr NativeFieldInfoPtr_readMethod;

	private static readonly System.IntPtr NativeFieldInfoPtr_readIntoMethod;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Void_Object_ES3Writer_ReferenceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0;

	public unsafe Il2CppReferenceArray<ES3Type> es3Types
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_es3Types);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ES3Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_es3Types), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Il2CppSystem.Type> types
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ES3Reflection.ES3ReflectedMethod readMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readMethod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Reflection.ES3ReflectedMethod>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readMethod), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ES3Reflection.ES3ReflectedMethod readIntoMethod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readIntoMethod);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Reflection.ES3ReflectedMethod>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_readIntoMethod), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11918, RefRangeEnd = 11919, XrefRangeStart = 11904, XrefRangeEnd = 11918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3TupleType([DefaultParameterValue(null)] Il2CppSystem.Type type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11919, XrefRangeEnd = 11920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Write([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_ES3Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 11938, RefRangeEnd = 11939, XrefRangeStart = 11920, XrefRangeEnd = 11938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Write([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer, [DefaultParameterValue(null)] ES3.ReferenceMode memberReferenceMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		*(ES3.ReferenceMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &memberReferenceMode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Write_Public_Void_Object_ES3Writer_ReferenceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11939, XrefRangeEnd = 11948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object Read<T>([DefaultParameterValue(null)] ES3Reader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_Read_Public_Virtual_Object_ES3Reader_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	static ES3TupleType()
	{
		Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", "ES3TupleType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr);
		NativeFieldInfoPtr_es3Types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, "es3Types");
		NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, "types");
		NativeFieldInfoPtr_readMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, "readMethod");
		NativeFieldInfoPtr_readIntoMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, "readIntoMethod");
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, 100664354);
		NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, 100664355);
		NativeMethodInfoPtr_Write_Public_Void_Object_ES3Writer_ReferenceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, 100664356);
		NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TupleType>.NativeClassPtr, 100664357);
	}

	public ES3TupleType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
