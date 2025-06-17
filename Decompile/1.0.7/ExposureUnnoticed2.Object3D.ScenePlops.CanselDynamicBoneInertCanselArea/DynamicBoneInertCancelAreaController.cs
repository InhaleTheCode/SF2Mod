using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.InGame;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ScenePlops.CanselDynamicBoneInertCanselArea;

public class DynamicBoneInertCancelAreaController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_areaChecker;

	private static readonly IntPtr NativeFieldInfoPtr_old;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DynamicBoneInertCancelAreaController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DynamicBoneInertCancelAreaController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsInArea_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static DynamicBoneInertCancelAreaController _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DynamicBoneInertCancelAreaController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerEnterAreaChecker areaChecker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaChecker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerEnterAreaChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_areaChecker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool old
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_old);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_old)) = flag;
		}
	}

	public unsafe static DynamicBoneInertCancelAreaController Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46394, XrefRangeEnd = 46396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DynamicBoneInertCancelAreaController_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DynamicBoneInertCancelAreaController>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46396, XrefRangeEnd = 46399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DynamicBoneInertCancelAreaController_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsInArea
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsInArea_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46399, XrefRangeEnd = 46414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46414, XrefRangeEnd = 46430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46430, XrefRangeEnd = 46438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicBoneInertCancelAreaController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DynamicBoneInertCancelAreaController()
	{
		Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ScenePlops.CanselDynamicBoneInertCanselArea", "DynamicBoneInertCancelAreaController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_areaChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, "areaChecker");
		NativeFieldInfoPtr_old = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, "old");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DynamicBoneInertCancelAreaController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666193);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DynamicBoneInertCancelAreaController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666194);
		NativeMethodInfoPtr_get_IsInArea_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666195);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666196);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666197);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666198);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneInertCancelAreaController>.NativeClassPtr, 100666199);
	}

	public DynamicBoneInertCancelAreaController(IntPtr pointer)
		: base(pointer)
	{
	}
}
