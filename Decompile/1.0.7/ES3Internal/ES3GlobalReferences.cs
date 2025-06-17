using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ES3Internal;

public class ES3GlobalReferences : ScriptableObject
{
	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ES3GlobalReferences_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Object_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_Int64_Object_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveInvalidKeys_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ES3GlobalReferences Instance
	{
		[CallerCount(0)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ES3GlobalReferences_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ES3GlobalReferences>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	public unsafe UnityEngine.Object Get([DefaultParameterValue(null)] long id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&id);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Object_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe long GetOrAdd([DefaultParameterValue(null)] UnityEngine.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrAdd_Public_Int64_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(long*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	public unsafe void RemoveInvalidKeys()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveInvalidKeys_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31719, XrefRangeEnd = 31720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3GlobalReferences()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3GlobalReferences()
	{
		Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3GlobalReferences");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ES3GlobalReferences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr, 100665042);
		NativeMethodInfoPtr_Get_Public_Object_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr, 100665043);
		NativeMethodInfoPtr_GetOrAdd_Public_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr, 100665044);
		NativeMethodInfoPtr_RemoveInvalidKeys_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr, 100665045);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3GlobalReferences>.NativeClassPtr, 100665046);
	}

	public ES3GlobalReferences(IntPtr pointer)
		: base(pointer)
	{
	}
}
