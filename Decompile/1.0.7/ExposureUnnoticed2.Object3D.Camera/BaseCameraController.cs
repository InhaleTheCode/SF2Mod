using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Camera;

public class BaseCameraController : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TpsAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_FpsAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr__Camera_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IsLockCamera_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_thirdPersonCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstPersonCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_inventoryCameraController;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnChangeFirstPersonView;

	private static readonly System.IntPtr NativeFieldInfoPtr_tpsCameraMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_fpsCameraMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerStateModel;

	private static readonly System.IntPtr NativeFieldInfoPtr_isStrafeCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActiveInventoryCamera;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Camera_Public_get_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLockCamera_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLockCamera_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_PlayerStateModel_TPCameraController_FPCameraController_InventoryCameraController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsStrafe_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDirectCameraFOV_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetTpsCullingMask_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransStrafe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransNotStrafe_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetInventoryCamera_Public_Void_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int TpsAngle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TpsAngle, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TpsAngle, &num);
		}
	}

	public unsafe static int FpsAngle
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FpsAngle, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FpsAngle, &num);
		}
	}

	public unsafe UnityEngine.Camera _Camera_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Camera_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Camera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _IsLockCamera_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsLockCamera_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsLockCamera_k__BackingField)) = flag;
		}
	}

	public unsafe TPCameraController thirdPersonCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdPersonCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TPCameraController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thirdPersonCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FPCameraController firstPersonCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FPCameraController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstPersonCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InventoryCameraController inventoryCameraController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCameraController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InventoryCameraController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inventoryCameraController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action OnChangeFirstPersonView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnChangeFirstPersonView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnChangeFirstPersonView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int tpsCameraMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tpsCameraMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tpsCameraMask)) = num;
		}
	}

	public unsafe int fpsCameraMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsCameraMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fpsCameraMask)) = num;
		}
	}

	public unsafe UnityEngine.Camera camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_camera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerStateModel playerStateModel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStateModel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerStateModel>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStateModel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isStrafeCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStrafeCache);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isStrafeCache)) = flag;
		}
	}

	public unsafe bool IsActiveInventoryCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInventoryCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActiveInventoryCamera)) = flag;
		}
	}

	public unsafe UnityEngine.Camera Camera
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Camera_Public_get_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEngine.Camera>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe bool IsLockCamera
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLockCamera_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsLockCamera_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66495, RefRangeEnd = 66496, XrefRangeStart = 66482, XrefRangeEnd = 66495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerController player, [DefaultParameterValue(null)] PlayerStateModel playerStateModel, [DefaultParameterValue(null)] TPCameraController thirdPersonCamera, [DefaultParameterValue(null)] FPCameraController firstPersonCamera, [DefaultParameterValue(null)] InventoryCameraController inventoryCameraController)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(playerStateModel);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(thirdPersonCamera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(firstPersonCamera);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inventoryCameraController);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_PlayerStateModel_TPCameraController_FPCameraController_InventoryCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 66496, RefRangeEnd = 66500, XrefRangeStart = 66496, XrefRangeEnd = 66496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsStrafe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsStrafe_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66546, RefRangeEnd = 66547, XrefRangeStart = 66500, XrefRangeEnd = 66546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66547, XrefRangeEnd = 66552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDirectCameraFOV([DefaultParameterValue(null)] int fov)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&fov);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDirectCameraFOV_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66552, XrefRangeEnd = 66557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTpsCullingMask()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTpsCullingMask_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 66569, RefRangeEnd = 66571, XrefRangeStart = 66557, XrefRangeEnd = 66569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransStrafe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransStrafe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66571, XrefRangeEnd = 66583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransNotStrafe()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransNotStrafe_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 66590, RefRangeEnd = 66598, XrefRangeStart = 66583, XrefRangeEnd = 66590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetInventoryCamera([DefaultParameterValue(null)] bool isActive, bool isCloset = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&isActive);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isCloset;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetInventoryCamera_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseCameraController()
	{
		Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Camera", "BaseCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_TpsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "TpsAngle");
		NativeFieldInfoPtr_FpsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "FpsAngle");
		NativeFieldInfoPtr__Camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "<Camera>k__BackingField");
		NativeFieldInfoPtr__IsLockCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "<IsLockCamera>k__BackingField");
		NativeFieldInfoPtr_thirdPersonCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "thirdPersonCamera");
		NativeFieldInfoPtr_firstPersonCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "firstPersonCamera");
		NativeFieldInfoPtr_inventoryCameraController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "inventoryCameraController");
		NativeFieldInfoPtr_OnChangeFirstPersonView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "OnChangeFirstPersonView");
		NativeFieldInfoPtr_tpsCameraMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "tpsCameraMask");
		NativeFieldInfoPtr_fpsCameraMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "fpsCameraMask");
		NativeFieldInfoPtr_camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "camera");
		NativeFieldInfoPtr_playerStateModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "playerStateModel");
		NativeFieldInfoPtr_isStrafeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "isStrafeCache");
		NativeFieldInfoPtr_IsActiveInventoryCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, "IsActiveInventoryCamera");
		NativeMethodInfoPtr_get_Camera_Public_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_set_Camera_Private_set_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_get_IsLockCamera_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_set_IsLockCamera_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_PlayerStateModel_TPCameraController_FPCameraController_InventoryCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667860);
		NativeMethodInfoPtr_IsStrafe_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667861);
		NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667862);
		NativeMethodInfoPtr_SetDirectCameraFOV_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667863);
		NativeMethodInfoPtr_SetTpsCullingMask_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667864);
		NativeMethodInfoPtr_TransStrafe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667865);
		NativeMethodInfoPtr_TransNotStrafe_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667866);
		NativeMethodInfoPtr_SetInventoryCamera_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667867);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCameraController>.NativeClassPtr, 100667868);
	}

	public BaseCameraController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
