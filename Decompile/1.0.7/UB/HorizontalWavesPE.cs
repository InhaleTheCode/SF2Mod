using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace UB;

public class HorizontalWavesPE : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_Speed;

	private static readonly IntPtr NativeFieldInfoPtr_SizeX;

	private static readonly IntPtr NativeFieldInfoPtr_SizeY;

	private static readonly IntPtr NativeFieldInfoPtr_Shader;

	private static readonly IntPtr NativeFieldInfoPtr__material;

	private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float Speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Speed)) = num;
		}
	}

	public unsafe float SizeX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeX)) = num;
		}
	}

	public unsafe float SizeY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SizeY)) = num;
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37405, XrefRangeEnd = 37466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37466, XrefRangeEnd = 37472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HorizontalWavesPE()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HorizontalWavesPE()
	{
		Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "HorizontalWavesPE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr);
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_SizeX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, "SizeX");
		NativeFieldInfoPtr_SizeY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, "SizeY");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, "_material");
		NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, 100665439);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HorizontalWavesPE>.NativeClassPtr, 100665440);
	}

	public HorizontalWavesPE(IntPtr pointer)
		: base(pointer)
	{
	}
}
