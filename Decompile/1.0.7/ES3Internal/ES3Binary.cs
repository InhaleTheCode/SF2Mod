using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ES3Internal;

public static class ES3Binary : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ObjectTerminator;

	private static readonly System.IntPtr NativeFieldInfoPtr_IdToType;

	private static readonly System.IntPtr NativeFieldInfoPtr_TypeToId;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeToByte_Internal_Static_ES3SpecialByte_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ByteToType_Internal_Static_Type_ES3SpecialByte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ByteToType_Internal_Static_Type_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_ES3SpecialByte_0;

	public unsafe static string ObjectTerminator
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ObjectTerminator, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ObjectTerminator, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static Dictionary<ES3SpecialByte, Il2CppSystem.Type> IdToType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IdToType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ES3SpecialByte, Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IdToType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Type, ES3SpecialByte> TypeToId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TypeToId, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, ES3SpecialByte>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TypeToId, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32393, XrefRangeEnd = 32400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3SpecialByte TypeToByte([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeToByte_Internal_Static_ES3SpecialByte_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ES3SpecialByte*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32400, XrefRangeEnd = 32416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type ByteToType([DefaultParameterValue(null)] ES3SpecialByte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByteToType_Internal_Static_Type_ES3SpecialByte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32416, XrefRangeEnd = 32429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type ByteToType([DefaultParameterValue(null)] byte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ByteToType_Internal_Static_Type_Byte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsPrimitive([DefaultParameterValue(null)] ES3SpecialByte b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_ES3SpecialByte_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static ES3Binary()
	{
		Il2CppClassPointerStore<ES3Binary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Binary");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr);
		NativeFieldInfoPtr_ObjectTerminator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, "ObjectTerminator");
		NativeFieldInfoPtr_IdToType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, "IdToType");
		NativeFieldInfoPtr_TypeToId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, "TypeToId");
		NativeMethodInfoPtr_TypeToByte_Internal_Static_ES3SpecialByte_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, 100665089);
		NativeMethodInfoPtr_ByteToType_Internal_Static_Type_ES3SpecialByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, 100665090);
		NativeMethodInfoPtr_ByteToType_Internal_Static_Type_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, 100665091);
		NativeMethodInfoPtr_IsPrimitive_Internal_Static_Boolean_ES3SpecialByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Binary>.NativeClassPtr, 100665092);
	}

	public ES3Binary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
