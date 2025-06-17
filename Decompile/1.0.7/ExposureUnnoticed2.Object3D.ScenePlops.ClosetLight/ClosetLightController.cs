using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ScenePlops.ClosetLight;

public class ClosetLightController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_closetLightObject;

	private static readonly IntPtr NativeFieldInfoPtr_noClosetLightObject;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ClosetLightController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ClosetLightController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetClosetLight_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ClosetLightController _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ClosetLightController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject closetLightObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closetLightObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_closetLightObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject noClosetLightObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noClosetLightObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_noClosetLightObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ClosetLightController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46171, XrefRangeEnd = 46173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_ClosetLightController_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ClosetLightController>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46173, XrefRangeEnd = 46176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ClosetLightController_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46176, XrefRangeEnd = 46177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46177, XrefRangeEnd = 46178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 46187, RefRangeEnd = 46200, XrefRangeStart = 46178, XrefRangeEnd = 46187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetClosetLight([DefaultParameterValue(null)] bool isActive)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isActive);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetClosetLight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClosetLightController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ClosetLightController()
	{
		Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ScenePlops.ClosetLight", "ClosetLightController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_closetLightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, "closetLightObject");
		NativeFieldInfoPtr_noClosetLightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, "noClosetLightObject");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_ClosetLightController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666162);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_ClosetLightController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666163);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666164);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666165);
		NativeMethodInfoPtr_SetClosetLight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666166);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetLightController>.NativeClassPtr, 100666167);
	}

	public ClosetLightController(IntPtr pointer)
		: base(pointer)
	{
	}
}
