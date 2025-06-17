using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnitySA.Utility;

namespace UnitySA.Characters.FirstPerson;

public class FPCtrl : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_m_IsWalking;

	private static readonly IntPtr NativeFieldInfoPtr_m_WalkSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_m_RunSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_m_RunstepLenghten;

	private static readonly IntPtr NativeFieldInfoPtr_m_JumpSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_m_StickToGroundForce;

	private static readonly IntPtr NativeFieldInfoPtr_m_GravityMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_m_MouseLook;

	private static readonly IntPtr NativeFieldInfoPtr_m_UseFovKick;

	private static readonly IntPtr NativeFieldInfoPtr_m_FovKick;

	private static readonly IntPtr NativeFieldInfoPtr_m_UseHeadBob;

	private static readonly IntPtr NativeFieldInfoPtr_m_HeadBob;

	private static readonly IntPtr NativeFieldInfoPtr_m_JumpBob;

	private static readonly IntPtr NativeFieldInfoPtr_m_StepInterval;

	private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

	private static readonly IntPtr NativeFieldInfoPtr_m_Jump;

	private static readonly IntPtr NativeFieldInfoPtr_m_YRotation;

	private static readonly IntPtr NativeFieldInfoPtr_m_Input;

	private static readonly IntPtr NativeFieldInfoPtr_m_MoveDir;

	private static readonly IntPtr NativeFieldInfoPtr_m_CharacterController;

	private static readonly IntPtr NativeFieldInfoPtr_m_CollisionFlags;

	private static readonly IntPtr NativeFieldInfoPtr_m_PreviouslyGrounded;

	private static readonly IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

	private static readonly IntPtr NativeFieldInfoPtr_m_StepCycle;

	private static readonly IntPtr NativeFieldInfoPtr_m_NextStep;

	private static readonly IntPtr NativeFieldInfoPtr_m_Jumping;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_RotateView_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool m_IsWalking
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsWalking);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IsWalking)) = flag;
		}
	}

	public unsafe float m_WalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WalkSpeed)) = num;
		}
	}

	public unsafe float m_RunSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunSpeed)) = num;
		}
	}

	public unsafe float m_RunstepLenghten
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunstepLenghten);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RunstepLenghten)) = num;
		}
	}

	public unsafe float m_JumpSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpSpeed)) = num;
		}
	}

	public unsafe float m_StickToGroundForce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickToGroundForce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StickToGroundForce)) = num;
		}
	}

	public unsafe float m_GravityMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GravityMultiplier);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GravityMultiplier)) = num;
		}
	}

	public unsafe MLook m_MouseLook
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLook);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MLook>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MouseLook), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_UseFovKick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFovKick);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseFovKick)) = flag;
		}
	}

	public unsafe FOVZoom m_FovKick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FovKick);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FOVZoom>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FovKick), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_UseHeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseHeadBob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UseHeadBob)) = flag;
		}
	}

	public unsafe CurveCtrlBob m_HeadBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeadBob);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CurveCtrlBob>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeadBob), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LerpCtrlBob m_JumpBob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpBob);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<LerpCtrlBob>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_JumpBob), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_StepInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepInterval)) = num;
		}
	}

	public unsafe Camera m_Camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_Jump
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jump);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jump)) = flag;
		}
	}

	public unsafe float m_YRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_YRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_YRotation)) = num;
		}
	}

	public unsafe Vector2 m_Input
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Input)) = vector;
		}
	}

	public unsafe Vector3 m_MoveDir
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDir);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MoveDir)) = vector;
		}
	}

	public unsafe CharacterController m_CharacterController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CharacterController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CollisionFlags m_CollisionFlags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollisionFlags);
			return *(CollisionFlags*)num;
		}
		set
		{
			*(CollisionFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollisionFlags)) = collisionFlags;
		}
	}

	public unsafe bool m_PreviouslyGrounded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviouslyGrounded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviouslyGrounded)) = flag;
		}
	}

	public unsafe Vector3 m_OriginalCameraPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OriginalCameraPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OriginalCameraPosition)) = vector;
		}
	}

	public unsafe float m_StepCycle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepCycle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StepCycle)) = num;
		}
	}

	public unsafe float m_NextStep
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextStep);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextStep)) = num;
		}
	}

	public unsafe bool m_Jumping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jumping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Jumping)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6811, XrefRangeEnd = 6830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6830, XrefRangeEnd = 6849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6849, XrefRangeEnd = 6898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6906, RefRangeEnd = 6907, XrefRangeStart = 6898, XrefRangeEnd = 6906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProgressStepCycle([DefaultParameterValue(null)] float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6935, RefRangeEnd = 6936, XrefRangeStart = 6907, XrefRangeEnd = 6935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraPosition([DefaultParameterValue(null)] float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 6958, RefRangeEnd = 6959, XrefRangeStart = 6936, XrefRangeEnd = 6958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetInput([DefaultParameterValue(null)] out float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6959, XrefRangeEnd = 6969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RotateView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6969, XrefRangeEnd = 6986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnControllerColliderHit([DefaultParameterValue(null)] ControllerColliderHit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6986, XrefRangeEnd = 7001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FPCtrl()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FPCtrl()
	{
		Il2CppClassPointerStore<FPCtrl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Characters.FirstPerson", "FPCtrl");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr);
		NativeFieldInfoPtr_m_IsWalking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_IsWalking");
		NativeFieldInfoPtr_m_WalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_WalkSpeed");
		NativeFieldInfoPtr_m_RunSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_RunSpeed");
		NativeFieldInfoPtr_m_RunstepLenghten = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_RunstepLenghten");
		NativeFieldInfoPtr_m_JumpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_JumpSpeed");
		NativeFieldInfoPtr_m_StickToGroundForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StickToGroundForce");
		NativeFieldInfoPtr_m_GravityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_GravityMultiplier");
		NativeFieldInfoPtr_m_MouseLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_MouseLook");
		NativeFieldInfoPtr_m_UseFovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_UseFovKick");
		NativeFieldInfoPtr_m_FovKick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_FovKick");
		NativeFieldInfoPtr_m_UseHeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_UseHeadBob");
		NativeFieldInfoPtr_m_HeadBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_HeadBob");
		NativeFieldInfoPtr_m_JumpBob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_JumpBob");
		NativeFieldInfoPtr_m_StepInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StepInterval");
		NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Camera");
		NativeFieldInfoPtr_m_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Jump");
		NativeFieldInfoPtr_m_YRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_YRotation");
		NativeFieldInfoPtr_m_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Input");
		NativeFieldInfoPtr_m_MoveDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_MoveDir");
		NativeFieldInfoPtr_m_CharacterController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_CharacterController");
		NativeFieldInfoPtr_m_CollisionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_CollisionFlags");
		NativeFieldInfoPtr_m_PreviouslyGrounded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_PreviouslyGrounded");
		NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_OriginalCameraPosition");
		NativeFieldInfoPtr_m_StepCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_StepCycle");
		NativeFieldInfoPtr_m_NextStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_NextStep");
		NativeFieldInfoPtr_m_Jumping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, "m_Jumping");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663972);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663973);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663974);
		NativeMethodInfoPtr_ProgressStepCycle_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663975);
		NativeMethodInfoPtr_UpdateCameraPosition_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_GetInput_Private_Void_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_RotateView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_OnControllerColliderHit_Private_Void_ControllerColliderHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FPCtrl>.NativeClassPtr, 100663980);
	}

	public FPCtrl(IntPtr pointer)
		: base(pointer)
	{
	}
}
