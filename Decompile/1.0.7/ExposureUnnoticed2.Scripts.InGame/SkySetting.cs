using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

[System.Serializable]
public class SkySetting : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SkyboxMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnvironmentLightColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnvironmentLightColorEquator;

	private static readonly System.IntPtr NativeFieldInfoPtr_EnvironmentLightColorGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_FogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_WallFogColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_FogDensity;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Material SkyboxMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyboxMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkyboxMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Color EnvironmentLightColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColor)) = color;
		}
	}

	public unsafe Color EnvironmentLightColorEquator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColorEquator);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColorEquator)) = color;
		}
	}

	public unsafe Color EnvironmentLightColorGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColorGround);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnvironmentLightColorGround)) = color;
		}
	}

	public unsafe Color FogColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FogColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FogColor)) = color;
		}
	}

	public unsafe Color WallFogColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WallFogColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WallFogColor)) = color;
		}
	}

	public unsafe float FogDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FogDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FogDensity)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe SkySetting()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkySetting>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SkySetting()
	{
		Il2CppClassPointerStore<SkySetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "SkySetting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkySetting>.NativeClassPtr);
		NativeFieldInfoPtr_SkyboxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "SkyboxMaterial");
		NativeFieldInfoPtr_EnvironmentLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "EnvironmentLightColor");
		NativeFieldInfoPtr_EnvironmentLightColorEquator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "EnvironmentLightColorEquator");
		NativeFieldInfoPtr_EnvironmentLightColorGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "EnvironmentLightColorGround");
		NativeFieldInfoPtr_FogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "FogColor");
		NativeFieldInfoPtr_WallFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "WallFogColor");
		NativeFieldInfoPtr_FogDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, "FogDensity");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkySetting>.NativeClassPtr, 100668999);
	}

	public SkySetting(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
