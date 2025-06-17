using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ch.sycoforge.Decal;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.SpermBullet;

public class SpermDecalController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_decalObject;

	private static readonly IntPtr NativeFieldInfoPtr_decal;

	private static readonly IntPtr NativeFieldInfoPtr_smoothScale;

	private static readonly IntPtr NativeFieldInfoPtr_destroyScale;

	private static readonly IntPtr NativeFieldInfoPtr_dickScale;

	private static readonly IntPtr NativeFieldInfoPtr_initScale;

	private static readonly IntPtr NativeFieldInfoPtr_startedDestroy;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartDestroy_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform decalObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decalObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe EasyDecal decal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EasyDecal>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat smoothScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat destroyScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destroyScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float dickScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dickScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dickScale)) = num;
		}
	}

	public unsafe Vector3 initScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initScale);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initScale)) = vector;
		}
	}

	public unsafe bool startedDestroy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startedDestroy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startedDestroy)) = flag;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 43122, RefRangeEnd = 43123, XrefRangeStart = 43085, XrefRangeEnd = 43122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] bool isOnNpc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isOnNpc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43123, XrefRangeEnd = 43133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void StartDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43133, XrefRangeEnd = 43143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpermDecalController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SpermDecalController()
	{
		Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.SpermBullet", "SpermDecalController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr);
		NativeFieldInfoPtr_decalObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "decalObject");
		NativeFieldInfoPtr_decal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "decal");
		NativeFieldInfoPtr_smoothScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "smoothScale");
		NativeFieldInfoPtr_destroyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "destroyScale");
		NativeFieldInfoPtr_dickScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "dickScale");
		NativeFieldInfoPtr_initScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "initScale");
		NativeFieldInfoPtr_startedDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, "startedDestroy");
		NativeMethodInfoPtr_Initialize_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, 100665844);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, 100665845);
		NativeMethodInfoPtr_StartDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, 100665846);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpermDecalController>.NativeClassPtr, 100665847);
	}

	public SpermDecalController(IntPtr pointer)
		: base(pointer)
	{
	}
}
