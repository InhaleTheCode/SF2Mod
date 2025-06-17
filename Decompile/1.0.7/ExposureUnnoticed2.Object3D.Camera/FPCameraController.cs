using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Camera;

public class FPCameraController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_JogZOffset;

	private static readonly IntPtr NativeFieldInfoPtr_targetOffset;

	private static readonly IntPtr NativeFieldInfoPtr_neckOffset;

	private static readonly IntPtr NativeFieldInfoPtr_child;

	private static readonly IntPtr NativeFieldInfoPtr__Pitch_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Yaw_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_player;

	private static readonly IntPtr NativeFieldInfoPtr_targetDashOffset;

	private static readonly IntPtr NativeFieldInfoPtr_currentZOffset;

	private static readonly IntPtr NativeFieldInfoPtr_baseCamera;

	private static readonly IntPtr NativeFieldInfoPtr_skipFrameCameraCount;

	private static readonly IntPtr NativeFieldInfoPtr_initLocalPosition;

	private static readonly IntPtr NativeMethodInfoPtr_get_Child_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Pitch_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Pitch_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Yaw_Private_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Yaw_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_BaseCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeFirstPersonView_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float JogZOffset
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_JogZOffset, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_JogZOffset, &num);
		}
	}

	public unsafe Vector3 targetOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetOffset)) = vector;
		}
	}

	public unsafe Vector3 neckOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neckOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_neckOffset)) = vector;
		}
	}

	public unsafe Transform child
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_child);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_child), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe PlayerController player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 targetDashOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDashOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetDashOffset)) = vector;
		}
	}

	public unsafe SmoothFloat currentZOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentZOffset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentZOffset), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseCameraController baseCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseCameraController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int skipFrameCameraCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipFrameCameraCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipFrameCameraCount)) = num;
		}
	}

	public unsafe Vector3 initLocalPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPosition)) = vector;
		}
	}

	public unsafe Transform Child
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Child_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
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
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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

	[CallerCount(0)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerController player, [DefaultParameterValue(null)] BaseCameraController baseCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(baseCamera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_BaseCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 66835, RefRangeEnd = 66837, XrefRangeStart = 66750, XrefRangeEnd = 66835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnChangeFirstPersonView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeFirstPersonView_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66837, XrefRangeEnd = 66844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPCameraController()
	{
		Il2CppClassPointerStore<FPCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Camera", "FPCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_JogZOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "JogZOffset");
		NativeFieldInfoPtr_targetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "targetOffset");
		NativeFieldInfoPtr_neckOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "neckOffset");
		NativeFieldInfoPtr_child = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "child");
		NativeFieldInfoPtr__Pitch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "<Pitch>k__BackingField");
		NativeFieldInfoPtr__Yaw_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "<Yaw>k__BackingField");
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "player");
		NativeFieldInfoPtr_targetDashOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "targetDashOffset");
		NativeFieldInfoPtr_currentZOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "currentZOffset");
		NativeFieldInfoPtr_baseCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "baseCamera");
		NativeFieldInfoPtr_skipFrameCameraCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "skipFrameCameraCount");
		NativeFieldInfoPtr_initLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, "initLocalPosition");
		NativeMethodInfoPtr_get_Child_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667880);
		NativeMethodInfoPtr_get_Pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667881);
		NativeMethodInfoPtr_set_Pitch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667882);
		NativeMethodInfoPtr_get_Yaw_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667883);
		NativeMethodInfoPtr_set_Yaw_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667884);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerController_BaseCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667885);
		NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667886);
		NativeMethodInfoPtr_OnChangeFirstPersonView_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667887);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCameraController>.NativeClassPtr, 100667888);
	}

	public FPCameraController(IntPtr pointer)
		: base(pointer)
	{
	}
}
