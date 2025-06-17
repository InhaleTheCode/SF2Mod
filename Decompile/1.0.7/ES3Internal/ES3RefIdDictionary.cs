using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ES3Internal;

[Serializable]
public class ES3RefIdDictionary : ES3SerializableDictionary<UnityEngine.Object, long>
{
	private static readonly IntPtr NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Object_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Int64_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30379, XrefRangeEnd = 30386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool KeysAreEqual([DefaultParameterValue(null)] UnityEngine.Object a, [DefaultParameterValue(null)] UnityEngine.Object b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe override bool ValuesAreEqual([DefaultParameterValue(null)] long a, [DefaultParameterValue(null)] long b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&a);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Int64_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30389, RefRangeEnd = 30391, XrefRangeStart = 30386, XrefRangeEnd = 30389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3RefIdDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3RefIdDictionary()
	{
		Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3RefIdDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr);
		NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr, 100664914);
		NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr, 100664915);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3RefIdDictionary>.NativeClassPtr, 100664916);
	}

	public ES3RefIdDictionary(IntPtr pointer)
		: base(pointer)
	{
	}
}
