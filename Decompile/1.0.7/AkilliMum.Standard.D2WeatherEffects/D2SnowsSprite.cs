using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace AkilliMum.Standard.D2WeatherEffects;

public class D2SnowsSprite : EffectBase
{
	private static readonly IntPtr NativeFieldInfoPtr_CamTransform;

	private static readonly IntPtr NativeFieldInfoPtr__firstPosition;

	private static readonly IntPtr NativeFieldInfoPtr__difference;

	private static readonly IntPtr NativeFieldInfoPtr_CameraSpeedMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Color;

	private static readonly IntPtr NativeFieldInfoPtr_TopFade;

	private static readonly IntPtr NativeFieldInfoPtr_RightFade;

	private static readonly IntPtr NativeFieldInfoPtr_BottomFade;

	private static readonly IntPtr NativeFieldInfoPtr_LeftFade;

	private static readonly IntPtr NativeFieldInfoPtr_FadeMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_ParticleMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_Speed;

	private static readonly IntPtr NativeFieldInfoPtr_Direction;

	private static readonly IntPtr NativeFieldInfoPtr_Luminance;

	private static readonly IntPtr NativeFieldInfoPtr_Zoom;

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

	public unsafe float ParticleMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParticleMultiplier)) = num;
		}
	}

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

	public unsafe float Direction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direction)) = num;
		}
	}

	public unsafe float Luminance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Luminance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Luminance)) = num;
		}
	}

	public unsafe float Zoom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Zoom);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Zoom)) = num;
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40718, XrefRangeEnd = 40796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40796, XrefRangeEnd = 40802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe D2SnowsSprite()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static D2SnowsSprite()
	{
		Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.D2WeatherEffects", "D2SnowsSprite");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr);
		NativeFieldInfoPtr_CamTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "CamTransform");
		NativeFieldInfoPtr__firstPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "_firstPosition");
		NativeFieldInfoPtr__difference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "_difference");
		NativeFieldInfoPtr_CameraSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "CameraSpeedMultiplier");
		NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "Color");
		NativeFieldInfoPtr_TopFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "TopFade");
		NativeFieldInfoPtr_RightFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "RightFade");
		NativeFieldInfoPtr_BottomFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "BottomFade");
		NativeFieldInfoPtr_LeftFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "LeftFade");
		NativeFieldInfoPtr_FadeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "FadeMultiplier");
		NativeFieldInfoPtr_ParticleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "ParticleMultiplier");
		NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "Speed");
		NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "Direction");
		NativeFieldInfoPtr_Luminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "Luminance");
		NativeFieldInfoPtr_Zoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "Zoom");
		NativeFieldInfoPtr_EffectedMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, "EffectedMaterials");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, 100665542);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, 100665543);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<D2SnowsSprite>.NativeClassPtr, 100665544);
	}

	public D2SnowsSprite(IntPtr pointer)
		: base(pointer)
	{
	}
}
