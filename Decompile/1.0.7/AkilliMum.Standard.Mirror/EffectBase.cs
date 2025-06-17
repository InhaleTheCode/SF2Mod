using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public class EffectBase : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_AlreadyRendered;

	private static readonly IntPtr NativeFieldInfoPtr__insiderendering;

	private static readonly IntPtr NativeMethodInfoPtr_get_InsideRendering_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InsideRendering_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Dictionary<string, RenderTexture> AlreadyRendered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlreadyRendered);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<string, RenderTexture>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AlreadyRendered), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _insiderendering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__insiderendering);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__insiderendering)) = flag;
		}
	}

	public unsafe bool InsideRendering
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InsideRendering_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InsideRendering_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41010, XrefRangeEnd = 41019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		Il2CppClassPointerStore<EffectBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "EffectBase");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EffectBase>.NativeClassPtr);
		NativeFieldInfoPtr_AlreadyRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, "AlreadyRendered");
		NativeFieldInfoPtr__insiderendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, "_insiderendering");
		NativeMethodInfoPtr_get_InsideRendering_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665583);
		NativeMethodInfoPtr_set_InsideRendering_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665584);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EffectBase>.NativeClassPtr, 100665585);
	}

	public EffectBase(IntPtr pointer)
		: base(pointer)
	{
	}
}
