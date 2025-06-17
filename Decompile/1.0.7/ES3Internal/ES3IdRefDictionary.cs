using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ES3Internal;

[Serializable]
public class ES3IdRefDictionary : ES3SerializableDictionary<long, UnityEngine.Object>
{
	private static readonly IntPtr NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Int64_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Object_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe override bool KeysAreEqual([DefaultParameterValue(null)] long a, [DefaultParameterValue(null)] long b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&a);
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Int64_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30369, XrefRangeEnd = 30376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool ValuesAreEqual([DefaultParameterValue(null)] UnityEngine.Object a, [DefaultParameterValue(null)] UnityEngine.Object b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30376, XrefRangeEnd = 30379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3IdRefDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3IdRefDictionary()
	{
		Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3IdRefDictionary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr);
		NativeMethodInfoPtr_KeysAreEqual_Protected_Virtual_Boolean_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr, 100664911);
		NativeMethodInfoPtr_ValuesAreEqual_Protected_Virtual_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr, 100664912);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3IdRefDictionary>.NativeClassPtr, 100664913);
	}

	public ES3IdRefDictionary(IntPtr pointer)
		: base(pointer)
	{
	}
}
