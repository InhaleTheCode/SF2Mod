using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ES3Types;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ES3Internal;

public static class ES3TypeMgr : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__lock;

	private static readonly System.IntPtr NativeFieldInfoPtr_types;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastAccessedType;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateES3Type_Public_Static_ES3Type_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetES3Type_Public_Static_ES3Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Internal_Static_Void_Type_ES3Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateES3Type_Internal_Static_ES3Type_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Static_Void_0;

	public unsafe static Il2CppSystem.Object _lock
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__lock, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__lock, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, ES3Type> types
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_types, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, ES3Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_types, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ES3Type lastAccessedType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_lastAccessedType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_lastAccessedType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(55)]
	[CachedScanResults(RefRangeStart = 32026, RefRangeEnd = 32081, XrefRangeStart = 31995, XrefRangeEnd = 32026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3Type GetOrCreateES3Type([DefaultParameterValue(null)] Il2CppSystem.Type type, bool throwException = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwException;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateES3Type_Public_Static_ES3Type_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Type>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32093, RefRangeEnd = 32094, XrefRangeStart = 32081, XrefRangeEnd = 32093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3Type GetES3Type([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetES3Type_Public_Static_ES3Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Type>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32116, RefRangeEnd = 32118, XrefRangeStart = 32094, XrefRangeEnd = 32116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Add([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] ES3Type es3Type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(es3Type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Internal_Static_Void_Type_ES3Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32118, XrefRangeEnd = 32279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3Type CreateES3Type([DefaultParameterValue(null)] Il2CppSystem.Type type, bool throwException = true)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwException;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateES3Type_Internal_Static_ES3Type_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3Type>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 32307, RefRangeEnd = 32311, XrefRangeStart = 32279, XrefRangeEnd = 32307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3TypeMgr()
	{
		Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3TypeMgr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr);
		NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, "_lock");
		NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, "types");
		NativeFieldInfoPtr_lastAccessedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, "lastAccessedType");
		NativeMethodInfoPtr_GetOrCreateES3Type_Public_Static_ES3Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, 100665066);
		NativeMethodInfoPtr_GetES3Type_Public_Static_ES3Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, 100665067);
		NativeMethodInfoPtr_Add_Internal_Static_Void_Type_ES3Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, 100665068);
		NativeMethodInfoPtr_CreateES3Type_Internal_Static_ES3Type_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, 100665069);
		NativeMethodInfoPtr_Init_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3TypeMgr>.NativeClassPtr, 100665070);
	}

	public ES3TypeMgr(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
