using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace AkilliMum.Standard.D2WeatherEffects;

public class D2FogsNoiseTexSprite : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_CamTransform;

	private static readonly IntPtr NativeFieldInfoPtr__firstPosition;

	private static readonly IntPtr NativeFieldInfoPtr__difference;

	private static readonly IntPtr NativeFieldInfoPtr_CameraSpeedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Color;

	private static readonly IntPtr NativeFieldInfoPtr_Noise;

	private static readonly IntPtr NativeFieldInfoPtr_TopFade;

	private static readonly IntPtr NativeFieldInfoPtr_RightFade;

	private static readonly IntPtr NativeFieldInfoPtr_BottomFade;

	private static readonly IntPtr NativeFieldInfoPtr_LeftFade;

	private static readonly IntPtr NativeFieldInfoPtr_FadeMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Size;

	private static readonly IntPtr NativeFieldInfoPtr_HorizontalSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_VerticalSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_Density;

	private static readonly IntPtr NativeFieldInfoPtr_EffectedMaterials;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

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

	public unsafe bool TopFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TopFade)) = flag;
		}
	}

	public unsafe bool RightFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightFade)) = flag;
		}
	}

	public unsafe bool BottomFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BottomFade)) = flag;
		}
	}

	public unsafe bool LeftFade
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFade);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LeftFade)) = flag;
		}
	}

	public unsafe float FadeMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadeMultiplier)) = num;
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

	public unsafe Il2CppReferenceArray<Material> EffectedMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectedMaterials);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectedMaterials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40049, XrefRangeEnd = 40126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40126, XrefRangeEnd = 40132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe D2FogsNoiseTexSprite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static D2FogsNoiseTexSprite()
	{
		Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.D2WeatherEffects", "D2FogsNoiseTexSprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr);
		NativeFieldInfoPtr_CamTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "CamTransform");
		NativeFieldInfoPtr__firstPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "_firstPosition");
		NativeFieldInfoPtr__difference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "_difference");
		NativeFieldInfoPtr_CameraSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "CameraSpeedMultiplier");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_Noise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "Noise");
		NativeFieldInfoPtr_TopFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "TopFade");
		NativeFieldInfoPtr_RightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "RightFade");
		NativeFieldInfoPtr_BottomFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "BottomFade");
		NativeFieldInfoPtr_LeftFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "LeftFade");
		NativeFieldInfoPtr_FadeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "FadeMultiplier");
		NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "Size");
		NativeFieldInfoPtr_HorizontalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "HorizontalSpeed");
		NativeFieldInfoPtr_VerticalSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "VerticalSpeed");
		NativeFieldInfoPtr_Density = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "Density");
		NativeFieldInfoPtr_EffectedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, "EffectedMaterials");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, 100665518);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2FogsNoiseTexSprite>.NativeClassPtr, 100665519);
	}

	public D2FogsNoiseTexSprite(IntPtr pointer)
		: base(pointer)
	{
	}
}
