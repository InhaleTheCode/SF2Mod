using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.Scripts.Base;

public class Localizer : Il2CppSystem.Object
{
	public enum Language
	{
		Ja,
		En,
		Sc,
		Tc,
		Ko
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_localizeData;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadLocalizeDataIfNot_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trans_Public_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trans_Public_Static_String_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Trans_Public_Static_String_String_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Dictionary<string, Il2CppStringArray> localizeData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_localizeData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_localizeData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 81750, RefRangeEnd = 81751, XrefRangeStart = 81710, XrefRangeEnd = 81750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadLocalizeDataIfNot()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadLocalizeDataIfNot_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(339)]
	[CachedScanResults(RefRangeStart = 81771, RefRangeEnd = 82110, XrefRangeStart = 81751, XrefRangeEnd = 81771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Trans([DefaultParameterValue(null)] string key)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trans_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(70)]
	[CachedScanResults(RefRangeStart = 82116, RefRangeEnd = 82186, XrefRangeStart = 82110, XrefRangeEnd = 82116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Trans([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] string param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(param);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trans_Public_Static_String_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82186, XrefRangeEnd = 82202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Trans([DefaultParameterValue(null)] string key, [DefaultParameterValue(null)] Il2CppStringArray param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(param);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trans_Public_Static_String_String_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe Localizer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Localizer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Localizer()
	{
		Il2CppClassPointerStore<Localizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "Localizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Localizer>.NativeClassPtr);
		NativeFieldInfoPtr_localizeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Localizer>.NativeClassPtr, "localizeData");
		NativeMethodInfoPtr_LoadLocalizeDataIfNot_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localizer>.NativeClassPtr, 100669331);
		NativeMethodInfoPtr_Trans_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localizer>.NativeClassPtr, 100669332);
		NativeMethodInfoPtr_Trans_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localizer>.NativeClassPtr, 100669333);
		NativeMethodInfoPtr_Trans_Public_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localizer>.NativeClassPtr, 100669334);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Localizer>.NativeClassPtr, 100669335);
	}

	public Localizer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
