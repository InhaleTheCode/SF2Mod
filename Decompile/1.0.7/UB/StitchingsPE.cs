using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace UB;

public class StitchingsPE : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Invert;

	private static readonly IntPtr NativeFieldInfoPtr_Size;

	private static readonly IntPtr NativeFieldInfoPtr_Color;

	private static readonly IntPtr NativeFieldInfoPtr_Shader;

	private static readonly IntPtr NativeFieldInfoPtr__material;

	private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool Invert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Invert);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Invert)) = flag;
		}
	}

	public unsafe float Size
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Size)) = num;
		}
	}

	public unsafe Color Color
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color)) = color;
		}
	}

	public unsafe Shader Shader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shader);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__material);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38319, XrefRangeEnd = 38380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRenderImage([DefaultParameterValue(null)] RenderTexture source, [DefaultParameterValue(null)] RenderTexture destination)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(destination);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38380, XrefRangeEnd = 38386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StitchingsPE()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StitchingsPE()
	{
		Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "StitchingsPE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr);
		NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, "Invert");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, "_material");
		NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, 100665467);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StitchingsPE>.NativeClassPtr, 100665468);
	}

	public StitchingsPE(IntPtr pointer)
		: base(pointer)
	{
	}
}
