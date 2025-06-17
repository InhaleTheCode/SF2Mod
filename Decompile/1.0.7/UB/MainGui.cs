using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace UB;

public class MainGui : ExecuteOnMainThread
{
	private static readonly IntPtr NativeFieldInfoPtr_Light;

	private static readonly IntPtr NativeFieldInfoPtr_Day;

	private static readonly IntPtr NativeFieldInfoPtr_Night;

	private static readonly IntPtr NativeFieldInfoPtr__day;

	private static readonly IntPtr NativeFieldInfoPtr_ShaderName;

	private static readonly IntPtr NativeFieldInfoPtr_NormalFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorBlurFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorBlurTexFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorRefFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorRefTexFloor;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorTexFloorSurf;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorBlurTexFloorSurf;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorRefTexFloorSurf;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorAlphaTexFloorSurf;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorTransparent;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorAlphaReflect;

	private static readonly IntPtr NativeFieldInfoPtr_Refraction;

	private static readonly IntPtr NativeFieldInfoPtr_Blur;

	private static readonly IntPtr NativeFieldInfoPtr_Mosaic;

	private static readonly IntPtr NativeFieldInfoPtr_PostEffect;

	private static readonly IntPtr NativeFieldInfoPtr_Portal;

	private static readonly IntPtr NativeFieldInfoPtr_Ghost;

	private static readonly IntPtr NativeFieldInfoPtr_Car;

	private static readonly IntPtr NativeFieldInfoPtr_Heli;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Off_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateShadows_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateDefault_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchSpinning_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SwitchDayNight_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateMirror_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateRefraction_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateBlur_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateDistortion_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateMosaic_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivatePostEffect_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivatePortal_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ActivateGhost_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadShaderScene_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LoadEffectsScene_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Light Light
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Light);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Light>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material Day
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Day);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Day), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material Night
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Night);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Night), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _day
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__day);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__day)) = flag;
		}
	}

	public unsafe Text ShaderName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Text>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ShaderName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject NormalFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorBlurFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorBlurTexFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurTexFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurTexFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorRefFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorRefTexFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefTexFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefTexFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorTexFloorSurf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorTexFloorSurf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorTexFloorSurf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorBlurTexFloorSurf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurTexFloorSurf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorBlurTexFloorSurf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorRefTexFloorSurf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefTexFloorSurf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorRefTexFloorSurf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorAlphaTexFloorSurf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorAlphaTexFloorSurf);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorAlphaTexFloorSurf), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorTransparent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorTransparent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorTransparent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MirrorAlphaReflect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorAlphaReflect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorAlphaReflect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Refraction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refraction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Refraction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Blur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Blur);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Blur), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Mosaic
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mosaic);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Mosaic), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PostEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PostEffect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PostEffect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Portal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Portal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Portal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Ghost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ghost);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Ghost), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Car
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Car);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Car), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Heli
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Heli);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Heli), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34829, XrefRangeEnd = 34837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 34918, RefRangeEnd = 34931, XrefRangeStart = 34837, XrefRangeEnd = 34918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Off()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Off_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34931, XrefRangeEnd = 34944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateShadows()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateShadows_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 34952, RefRangeEnd = 34959, XrefRangeStart = 34944, XrefRangeEnd = 34952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateDefault()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34959, XrefRangeEnd = 34970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchSpinning()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchSpinning_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34970, XrefRangeEnd = 34980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchDayNight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchDayNight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34980, XrefRangeEnd = 35052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateMirror()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateMirror_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35052, XrefRangeEnd = 35060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateRefraction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateRefraction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35060, XrefRangeEnd = 35068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateBlur()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateBlur_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35068, XrefRangeEnd = 35080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateDistortion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateDistortion_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35080, XrefRangeEnd = 35088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateMosaic()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateMosaic_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35088, XrefRangeEnd = 35096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivatePostEffect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivatePostEffect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35096, XrefRangeEnd = 35102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivatePortal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivatePortal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35102, XrefRangeEnd = 35114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActivateGhost()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActivateGhost_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35114, XrefRangeEnd = 35123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadShaderScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadShaderScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35123, XrefRangeEnd = 35132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadEffectsScene()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadEffectsScene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35132, XrefRangeEnd = 35136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MainGui()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainGui>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MainGui()
	{
		Il2CppClassPointerStore<MainGui>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "MainGui");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainGui>.NativeClassPtr);
		NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Light");
		NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Day");
		NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Night");
		NativeFieldInfoPtr__day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "_day");
		NativeFieldInfoPtr_ShaderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "ShaderName");
		NativeFieldInfoPtr_NormalFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "NormalFloor");
		NativeFieldInfoPtr_MirrorFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorFloor");
		NativeFieldInfoPtr_MirrorBlurFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorBlurFloor");
		NativeFieldInfoPtr_MirrorBlurTexFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorBlurTexFloor");
		NativeFieldInfoPtr_MirrorRefFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorRefFloor");
		NativeFieldInfoPtr_MirrorRefTexFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorRefTexFloor");
		NativeFieldInfoPtr_MirrorTexFloorSurf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorTexFloorSurf");
		NativeFieldInfoPtr_MirrorBlurTexFloorSurf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorBlurTexFloorSurf");
		NativeFieldInfoPtr_MirrorRefTexFloorSurf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorRefTexFloorSurf");
		NativeFieldInfoPtr_MirrorAlphaTexFloorSurf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorAlphaTexFloorSurf");
		NativeFieldInfoPtr_MirrorTransparent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorTransparent");
		NativeFieldInfoPtr_MirrorAlphaReflect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "MirrorAlphaReflect");
		NativeFieldInfoPtr_Refraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Refraction");
		NativeFieldInfoPtr_Blur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Blur");
		NativeFieldInfoPtr_Mosaic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Mosaic");
		NativeFieldInfoPtr_PostEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "PostEffect");
		NativeFieldInfoPtr_Portal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Portal");
		NativeFieldInfoPtr_Ghost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Ghost");
		NativeFieldInfoPtr_Car = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Car");
		NativeFieldInfoPtr_Heli = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainGui>.NativeClassPtr, "Heli");
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665352);
		NativeMethodInfoPtr_Off_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665353);
		NativeMethodInfoPtr_ActivateShadows_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665354);
		NativeMethodInfoPtr_ActivateDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665355);
		NativeMethodInfoPtr_SwitchSpinning_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665356);
		NativeMethodInfoPtr_SwitchDayNight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665357);
		NativeMethodInfoPtr_ActivateMirror_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665358);
		NativeMethodInfoPtr_ActivateRefraction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665359);
		NativeMethodInfoPtr_ActivateBlur_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665360);
		NativeMethodInfoPtr_ActivateDistortion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665361);
		NativeMethodInfoPtr_ActivateMosaic_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665362);
		NativeMethodInfoPtr_ActivatePostEffect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665363);
		NativeMethodInfoPtr_ActivatePortal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665364);
		NativeMethodInfoPtr_ActivateGhost_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665365);
		NativeMethodInfoPtr_LoadShaderScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665366);
		NativeMethodInfoPtr_LoadEffectsScene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665367);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainGui>.NativeClassPtr, 100665368);
	}

	public MainGui(IntPtr pointer)
		: base(pointer)
	{
	}
}
