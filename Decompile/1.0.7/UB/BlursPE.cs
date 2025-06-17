using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace UB;

public class BlursPE : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Iterations;

	private static readonly IntPtr NativeFieldInfoPtr_NeighbourPixels;

	private static readonly IntPtr NativeFieldInfoPtr_Shader;

	private static readonly IntPtr NativeFieldInfoPtr__material;

	private static readonly IntPtr NativeFieldInfoPtr__reflectionTexture1;

	private static readonly IntPtr NativeFieldInfoPtr__reflectionTexture2;

	private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRenderTextures_Private_Void_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Iterations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Iterations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Iterations)) = num;
		}
	}

	public unsafe float NeighbourPixels
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeighbourPixels);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeighbourPixels)) = num;
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

	public unsafe RenderTexture _reflectionTexture1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture1);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _reflectionTexture2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35874, XrefRangeEnd = 35943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 36023, RefRangeEnd = 36024, XrefRangeStart = 35943, XrefRangeEnd = 36023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderTextures([DefaultParameterValue(null)] RenderTexture source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTextures_Private_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36024, XrefRangeEnd = 36030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BlursPE()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlursPE>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BlursPE()
	{
		Il2CppClassPointerStore<BlursPE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "BlursPE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlursPE>.NativeClassPtr);
		NativeFieldInfoPtr_Iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "Iterations");
		NativeFieldInfoPtr_NeighbourPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "NeighbourPixels");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "_material");
		NativeFieldInfoPtr__reflectionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "_reflectionTexture1");
		NativeFieldInfoPtr__reflectionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, "_reflectionTexture2");
		NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, 100665398);
		NativeMethodInfoPtr_CreateRenderTextures_Private_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, 100665399);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlursPE>.NativeClassPtr, 100665400);
	}

	public BlursPE(IntPtr pointer)
		: base(pointer)
	{
	}
}
