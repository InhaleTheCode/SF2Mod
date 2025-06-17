using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.Object3D.Portal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class PortalManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Portals_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Portals_Public_get_Il2CppReferenceArray_1_PortalController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Portals_Private_set_Void_Il2CppReferenceArray_1_PortalController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPortalTransform_Public_Transform_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetFirstPortal_Public_PortalController_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNearPortal_Public_PortalController_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<PortalController> _Portals_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Portals_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PortalController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Portals_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<PortalController> Portals
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Portals_Public_get_Il2CppReferenceArray_1_PortalController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PortalController>>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Portals_Private_set_Void_Il2CppReferenceArray_1_PortalController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75779, XrefRangeEnd = 75783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 75794, RefRangeEnd = 75795, XrefRangeStart = 75783, XrefRangeEnd = 75794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetPortalTransform([DefaultParameterValue(null)] StageType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPortalTransform_Public_Transform_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75795, XrefRangeEnd = 75801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetEscapeTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75801, XrefRangeEnd = 75802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetSpawnPoint([DefaultParameterValue(null)] StageType fromStageType, [DefaultParameterValue(null)] int id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&fromStageType);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &id;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe PortalController GetFirstPortal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirstPortal_Public_PortalController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PortalController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75802, XrefRangeEnd = 75810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PortalController GetNearPortal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNearPortal_Public_PortalController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PortalController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PortalManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortalManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PortalManager()
	{
		Il2CppClassPointerStore<PortalManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "PortalManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortalManager>.NativeClassPtr);
		NativeFieldInfoPtr__Portals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, "<Portals>k__BackingField");
		NativeMethodInfoPtr_get_Portals_Public_get_Il2CppReferenceArray_1_PortalController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668876);
		NativeMethodInfoPtr_set_Portals_Private_set_Void_Il2CppReferenceArray_1_PortalController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668877);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668878);
		NativeMethodInfoPtr_GetPortalTransform_Public_Transform_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668879);
		NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668880);
		NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668881);
		NativeMethodInfoPtr_GetFirstPortal_Public_PortalController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668882);
		NativeMethodInfoPtr_GetNearPortal_Public_PortalController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668883);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalManager>.NativeClassPtr, 100668884);
	}

	public PortalManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
