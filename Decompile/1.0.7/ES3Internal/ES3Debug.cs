using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ES3Internal;

public static class ES3Debug : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_disableInfoMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableWarningMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_disableErrorMsg;

	private static readonly System.IntPtr NativeFieldInfoPtr_indentChar;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_String_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_Object_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Indent_Private_Static_String_Int32_0;

	public unsafe static string disableInfoMsg
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disableInfoMsg, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disableInfoMsg, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string disableWarningMsg
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disableWarningMsg, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disableWarningMsg, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string disableErrorMsg
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_disableErrorMsg, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_disableErrorMsg, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static char indentChar
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_indentChar, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_indentChar, &c);
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 28896, RefRangeEnd = 28901, XrefRangeStart = 28869, XrefRangeEnd = 28896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log([DefaultParameterValue(null)] string msg, UnityEngine.Object context = null, int indent = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_String_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 28928, RefRangeEnd = 28935, XrefRangeStart = 28901, XrefRangeEnd = 28928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogWarning([DefaultParameterValue(null)] string msg, UnityEngine.Object context = null, int indent = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 28962, RefRangeEnd = 28966, XrefRangeStart = 28935, XrefRangeEnd = 28962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LogError([DefaultParameterValue(null)] string msg, UnityEngine.Object context = null, int indent = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(context);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &indent;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LogError_Public_Static_Void_String_Object_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28966, XrefRangeEnd = 28969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Indent([DefaultParameterValue(null)] int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&size);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Indent_Private_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ES3Debug()
	{
		Il2CppClassPointerStore<ES3Debug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Debug");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr);
		NativeFieldInfoPtr_disableInfoMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, "disableInfoMsg");
		NativeFieldInfoPtr_disableWarningMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, "disableWarningMsg");
		NativeFieldInfoPtr_disableErrorMsg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, "disableErrorMsg");
		NativeFieldInfoPtr_indentChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, "indentChar");
		NativeMethodInfoPtr_Log_Public_Static_Void_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, 100664825);
		NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, 100664826);
		NativeMethodInfoPtr_LogError_Public_Static_Void_String_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, 100664827);
		NativeMethodInfoPtr_Indent_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Debug>.NativeClassPtr, 100664828);
	}

	public ES3Debug(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
