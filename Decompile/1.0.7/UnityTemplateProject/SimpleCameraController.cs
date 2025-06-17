using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityTemplateProject;

public class SimpleCameraController : MonoBehaviour
{
	public class CameraState : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_yaw;

		private static readonly System.IntPtr NativeFieldInfoPtr_pitch;

		private static readonly System.IntPtr NativeFieldInfoPtr_roll;

		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_z;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float yaw
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yaw);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_yaw)) = num;
			}
		}

		public unsafe float pitch
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pitch)) = num;
			}
		}

		public unsafe float roll
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roll);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roll)) = num;
			}
		}

		public unsafe float x
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_x)) = num;
			}
		}

		public unsafe float y
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_y)) = num;
			}
		}

		public unsafe float z
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_z)) = num;
			}
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 32640, RefRangeEnd = 32646, XrefRangeStart = 32625, XrefRangeEnd = 32640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFromTransform([DefaultParameterValue(null)] Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 32648, RefRangeEnd = 32651, XrefRangeStart = 32646, XrefRangeEnd = 32648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Translate([DefaultParameterValue(null)] Vector3 translation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&translation);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 32661, RefRangeEnd = 32664, XrefRangeStart = 32651, XrefRangeEnd = 32661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpTowards([DefaultParameterValue(null)] CameraState target, [DefaultParameterValue(null)] float positionLerpPct, [DefaultParameterValue(null)] float rotationLerpPct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &positionLerpPct;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotationLerpPct;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32664, XrefRangeEnd = 32667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTransform([DefaultParameterValue(null)] Transform t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe CameraState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraState>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CameraState()
		{
			Il2CppClassPointerStore<CameraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "CameraState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraState>.NativeClassPtr);
			NativeFieldInfoPtr_yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "yaw");
			NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "pitch");
			NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "roll");
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "y");
			NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraState>.NativeClassPtr, "z");
			NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100665177);
			NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100665178);
			NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100665179);
			NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100665180);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraState>.NativeClassPtr, 100665181);
		}

		public CameraState(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetCameraState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InterpolatingCameraState;

	private static readonly System.IntPtr NativeFieldInfoPtr_boost;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionLerpTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseSensitivityCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationLerpTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_invertY;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CameraState m_TargetCameraState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetCameraState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TargetCameraState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraState m_InterpolatingCameraState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InterpolatingCameraState);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CameraState>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InterpolatingCameraState), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float boost
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boost);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boost)) = num;
		}
	}

	public unsafe float positionLerpTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionLerpTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionLerpTime)) = num;
		}
	}

	public unsafe AnimationCurve mouseSensitivityCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivityCurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseSensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float rotationLerpTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationLerpTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationLerpTime)) = num;
		}
	}

	public unsafe bool invertY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_invertY)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32667, XrefRangeEnd = 32678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 32702, RefRangeEnd = 32705, XrefRangeStart = 32678, XrefRangeEnd = 32702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetInputTranslationDirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32705, XrefRangeEnd = 32754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32754, XrefRangeEnd = 32770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleCameraController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SimpleCameraController()
	{
		Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityTemplateProject", "SimpleCameraController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr);
		NativeFieldInfoPtr_m_TargetCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_TargetCameraState");
		NativeFieldInfoPtr_m_InterpolatingCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_InterpolatingCameraState");
		NativeFieldInfoPtr_boost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "boost");
		NativeFieldInfoPtr_positionLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "positionLerpTime");
		NativeFieldInfoPtr_mouseSensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "mouseSensitivityCurve");
		NativeFieldInfoPtr_rotationLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "rotationLerpTime");
		NativeFieldInfoPtr_invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "invertY");
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100665173);
		NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100665174);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100665175);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100665176);
	}

	public SimpleCameraController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
