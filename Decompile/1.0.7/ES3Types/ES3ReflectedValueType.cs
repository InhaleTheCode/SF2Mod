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

public class ES3ReflectedValueType : ES3Type
{
	private sealed class MethodInfoStoreGeneric_Read_Public_Virtual_Object_ES3Reader_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0, Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadInto_Public_Virtual_Void_ES3Reader_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadInto_Public_Virtual_Void_ES3Reader_Object_0, Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_ES3Writer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInto_Public_Virtual_Void_ES3Reader_Object_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3ReflectedValueType([DefaultParameterValue(null)] Il2CppSystem.Type type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14184, XrefRangeEnd = 14552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14552, XrefRangeEnd = 14557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ReadInto<T>([DefaultParameterValue(null)] ES3Reader reader, [DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethodInfoStoreGeneric_ReadInto_Public_Virtual_Void_ES3Reader_Object_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3ReflectedValueType()
	{
		Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", "ES3ReflectedValueType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr, 100664509);
		NativeMethodInfoPtr_Write_Public_Virtual_Void_Object_ES3Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr, 100664510);
		NativeMethodInfoPtr_Read_Public_Virtual_Object_ES3Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr, 100664511);
		NativeMethodInfoPtr_ReadInto_Public_Virtual_Void_ES3Reader_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedValueType>.NativeClassPtr, 100664512);
	}

	public ES3ReflectedValueType(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
