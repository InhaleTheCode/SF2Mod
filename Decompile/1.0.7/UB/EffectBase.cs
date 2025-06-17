using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace UB;

public class EffectBase : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_AlreadyRendered;

	private static readonly IntPtr NativeFieldInfoPtr__insiderendering;

	private static readonly IntPtr NativeMethodInfoPtr_get_InsideRendering_Public_Static_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InsideRendering_Public_Static_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Dictionary<string, RenderTexture> AlreadyRendered
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AlreadyRendered, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, RenderTexture>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AlreadyRendered, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static bool _insiderendering
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__insiderendering, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__insiderendering, &flag);
		}
	}

	public unsafe static bool InsideRendering
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35314, XrefRangeEnd = 35318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InsideRendering_Public_Static_get_Boolean_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35318, XrefRangeEnd = 35322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InsideRendering_Public_Static_set_Void_Boolean_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EffectBase()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EffectBase>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EffectBase()
	{
		Il2CppClassPointerStore<EffectBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "EffectBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectBase>.NativeClassPtr);
		NativeFieldInfoPtr_AlreadyRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, "AlreadyRendered");
		NativeFieldInfoPtr__insiderendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, "_insiderendering");
		NativeMethodInfoPtr_get_InsideRendering_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665382);
		NativeMethodInfoPtr_set_InsideRendering_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665383);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665384);
	}

	public EffectBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
