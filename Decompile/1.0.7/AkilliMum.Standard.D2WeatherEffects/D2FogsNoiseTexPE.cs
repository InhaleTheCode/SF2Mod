using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace AkilliMum.Standard.D2WeatherEffects;

public class D2FogsNoiseTexPE : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_CamTransform;

	private static readonly IntPtr NativeFieldInfoPtr__firstPosition;

	private static readonly IntPtr NativeFieldInfoPtr__difference;

	private static readonly IntPtr NativeFieldInfoPtr_CameraSpeedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Color;

	private static readonly IntPtr NativeFieldInfoPtr_Noise;

	private static readonly IntPtr NativeFieldInfoPtr_Size;

	private static readonly IntPtr NativeFieldInfoPtr_HorizontalSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_VerticalSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_Density;

	private static readonly IntPtr NativeFieldInfoPtr_Shader;

	private static readonly IntPtr NativeFieldInfoPtr__material;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform CamTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CamTransform);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CamTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 _firstPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__firstPosition)) = vector;
		}
	}

	public unsafe Vector3 _difference
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__difference);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__difference)) = vector;
		}
	}

	public unsafe float CameraSpeedMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraSpeedMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraSpeedMultiplier)) = num;
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

	public unsafe Texture2D Noise
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Noise);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture2D>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Noise), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe float HorizontalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalSpeed)) = num;
		}
	}

	public unsafe float VerticalSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalSpeed)) = num;
		}
	}

	public unsafe float Density
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Density);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Density)) = num;
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39948, XrefRangeEnd = 39950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39950, XrefRangeEnd = 39952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39952, XrefRangeEnd = 40043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40043, XrefRangeEnd = 40049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe D2FogsNoiseTexPE()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static D2FogsNoiseTexPE()
	{
		Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.D2WeatherEffects", "D2FogsNoiseTexPE");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr);
		NativeFieldInfoPtr_CamTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "CamTransform");
		NativeFieldInfoPtr__firstPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "_firstPosition");
		NativeFieldInfoPtr__difference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "_difference");
		NativeFieldInfoPtr_CameraSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "CameraSpeedMultiplier");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "Noise");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_HorizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "HorizontalSpeed");
		NativeFieldInfoPtr_VerticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "VerticalSpeed");
		NativeFieldInfoPtr_Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "Density");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, "_material");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, 100665513);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, 100665514);
		NativeMethodInfoPtr_OnRenderImage_Private_Void_RenderTexture_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexPE>.NativeClassPtr, 100665516);
	}

	public D2FogsNoiseTexPE(IntPtr pointer)
		: base(pointer)
	{
	}
}
