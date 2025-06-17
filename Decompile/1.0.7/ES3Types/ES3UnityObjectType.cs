using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace ES3Types;

public class ES3UnityObjectType : ES3ObjectType
{
	private sealed class MethodInfoStoreGeneric_ReadUnityObject_Protected_Abstract_Virtual_New_Void_ES3Reader_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadUnityObject_Protected_Abstract_Virtual_New_Object_ES3Reader_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Object_ES3Reader_0, Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Object_ES3Reader_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0, Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteUnityObject_Protected_Abstract_Virtual_New_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Void_ES3Reader_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Object_ES3Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteObject_Public_Virtual_New_Void_Object_ES3Writer_ReferenceMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_ReferenceMode_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3UnityObjectType([DefaultParameterValue(null)] Il2CppSystem.Type type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void WriteUnityObject([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_WriteUnityObject_Protected_Abstract_Virtual_New_Void_Object_ES3Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void ReadUnityObject<T>([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadUnityObject_Protected_Abstract_Virtual_New_Void_ES3Reader_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual Il2CppSystem.Object ReadUnityObject<T>([DefaultParameterValue(null)] ES3Reader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadUnityObject_Protected_Abstract_Virtual_New_Object_ES3Reader_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe override void WriteObject([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12683, XrefRangeEnd = 12697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void WriteObject([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer, [DefaultParameterValue(null)] ES3.ReferenceMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		*(ES3.ReferenceMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_WriteObject_Public_Virtual_New_Void_Object_ES3Writer_ReferenceMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12697, XrefRangeEnd = 12738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadObject<T>([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12738, XrefRangeEnd = 12805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Il2CppSystem.Object ReadObject<T>([DefaultParameterValue(null)] ES3Reader reader)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadObject_Protected_Virtual_Object_ES3Reader_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12805, XrefRangeEnd = 12811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool WriteUsingDerivedType([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] ES3Writer writer, [DefaultParameterValue(null)] ES3.ReferenceMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(writer);
		*(ES3.ReferenceMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_ReferenceMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	static ES3UnityObjectType()
	{
		Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", "ES3UnityObjectType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664393);
		NativeMethodInfoPtr_WriteUnityObject_Protected_Abstract_Virtual_New_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664394);
		NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664395);
		NativeMethodInfoPtr_ReadUnityObject_Protected_Abstract_Virtual_New_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664396);
		NativeMethodInfoPtr_WriteObject_Protected_Virtual_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664397);
		NativeMethodInfoPtr_WriteObject_Public_Virtual_New_Void_Object_ES3Writer_ReferenceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664398);
		NativeMethodInfoPtr_ReadObject_Protected_Virtual_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664399);
		NativeMethodInfoPtr_ReadObject_Protected_Virtual_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664400);
		NativeMethodInfoPtr_WriteUsingDerivedType_Protected_Boolean_Object_ES3Writer_ReferenceMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3UnityObjectType>.NativeClassPtr, 100664401);
	}

	public ES3UnityObjectType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
