using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.Misc;

public class RpBonusColorSelector : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextColor_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextColorSecondary_Public_Static_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87881, RefRangeEnd = 87885, XrefRangeStart = 87880, XrefRangeEnd = 87881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetTextColor([DefaultParameterValue(null)] float rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextColor_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 87886, RefRangeEnd = 87890, XrefRangeStart = 87885, XrefRangeEnd = 87886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color GetTextColorSecondary([DefaultParameterValue(null)] float rp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextColorSecondary_Public_Static_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe RpBonusColorSelector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RpBonusColorSelector()
	{
		Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.Misc", "RpBonusColorSelector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr);
		NativeMethodInfoPtr_GetTextColor_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr, 100669740);
		NativeMethodInfoPtr_GetTextColorSecondary_Public_Static_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr, 100669741);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RpBonusColorSelector>.NativeClassPtr, 100669742);
	}

	public RpBonusColorSelector(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
