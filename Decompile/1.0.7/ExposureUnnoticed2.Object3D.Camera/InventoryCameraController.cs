using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Camera;

public class InventoryCameraController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_CameraMaxDistance;

	private static readonly IntPtr NativeFieldInfoPtr__Yaw_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Pitch_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_cameraTarget;

	private static readonly IntPtr NativeFieldInfoPtr_layerMask;

	private static readonly IntPtr NativeFieldInfoPtr_isClosetMode;

	private static readonly IntPtr NativeFieldInfoPtr_currentVerticalValue;

	private static readonly IntPtr NativeFieldInfoPtr_currentFarValue;

	private static readonly IntPtr NativeFieldInfoPtr_currentCameraDistance;

	private static readonly IntPtr NativeFieldInfoPtr_isFirstUpdate;

	private static readonly IntPtr NativeMethodInfoPtr_get_Yaw_Private_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Yaw_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Private_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTransform_Public_Void_TPCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetClosetMode_Public_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnActiveCamera_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcCameraDistance_Private_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float CameraMaxDistance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CameraMaxDistance, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CameraMaxDistance, &num);
		}
	}

	public unsafe float _Yaw_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Yaw_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Yaw_k__BackingField)) = num;
		}
	}

	public unsafe float _Pitch_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Pitch_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Pitch_k__BackingField)) = num;
		}
	}

	public unsafe Transform cameraTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int layerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask)) = num;
		}
	}

	public unsafe bool isClosetMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosetMode);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isClosetMode)) = flag;
		}
	}

	public unsafe float currentVerticalValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVerticalValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentVerticalValue)) = num;
		}
	}

	public unsafe float currentFarValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFarValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentFarValue)) = num;
		}
	}

	public unsafe float currentCameraDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCameraDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentCameraDistance)) = num;
		}
	}

	public unsafe int isFirstUpdate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFirstUpdate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFirstUpdate)) = num;
		}
	}

	public unsafe float Yaw
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Yaw_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Yaw_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Pitch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Pitch_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Pitch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66860, RefRangeEnd = 66861, XrefRangeStart = 66844, XrefRangeEnd = 66860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerController player)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66948, RefRangeEnd = 66949, XrefRangeStart = 66861, XrefRangeEnd = 66948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetTransform([DefaultParameterValue(null)] TPCameraController tpCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(tpCamera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTransform_Public_Void_TPCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetClosetMode([DefaultParameterValue(null)] float pitch, [DefaultParameterValue(null)] float yaw)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&pitch);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &yaw;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetClosetMode_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnActiveCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnActiveCamera_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66969, XrefRangeStart = 66949, XrefRangeEnd = 66968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcCameraDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCameraDistance_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InventoryCameraController()
	{
		Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Camera", "InventoryCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_CameraMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "CameraMaxDistance");
		NativeFieldInfoPtr__Yaw_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "<Yaw>k__BackingField");
		NativeFieldInfoPtr__Pitch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "<Pitch>k__BackingField");
		NativeFieldInfoPtr_cameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "cameraTarget");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "layerMask");
		NativeFieldInfoPtr_isClosetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "isClosetMode");
		NativeFieldInfoPtr_currentVerticalValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "currentVerticalValue");
		NativeFieldInfoPtr_currentFarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "currentFarValue");
		NativeFieldInfoPtr_currentCameraDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "currentCameraDistance");
		NativeFieldInfoPtr_isFirstUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, "isFirstUpdate");
		NativeMethodInfoPtr_get_Yaw_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667889);
		NativeMethodInfoPtr_set_Yaw_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667890);
		NativeMethodInfoPtr_get_Pitch_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667891);
		NativeMethodInfoPtr_set_Pitch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667892);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667893);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667894);
		NativeMethodInfoPtr_SetTransform_Public_Void_TPCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667895);
		NativeMethodInfoPtr_SetClosetMode_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667896);
		NativeMethodInfoPtr_OnActiveCamera_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667897);
		NativeMethodInfoPtr_CalcCameraDistance_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667898);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryCameraController>.NativeClassPtr, 100667899);
	}

	public InventoryCameraController(IntPtr pointer)
		: base(pointer)
	{
	}
}
