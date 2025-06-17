using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnitySA.Characters.FirstPerson;

[System.Serializable]
public class MLook : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_XSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_YSensitivity;

	private static readonly System.IntPtr NativeFieldInfoPtr_clampVerticalRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_MinimumX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaximumX;

	private static readonly System.IntPtr NativeFieldInfoPtr_smooth;

	private static readonly System.IntPtr NativeFieldInfoPtr_smoothTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_lockCursor;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CharacterTargetRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraTargetRot;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_cursorIsLocked;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float XSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XSensitivity)) = num;
		}
	}

	public unsafe float YSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_YSensitivity)) = num;
		}
	}

	public unsafe bool clampVerticalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampVerticalRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clampVerticalRotation)) = flag;
		}
	}

	public unsafe float MinimumX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MinimumX)) = num;
		}
	}

	public unsafe float MaximumX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaximumX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaximumX)) = num;
		}
	}

	public unsafe bool smooth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smooth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smooth)) = flag;
		}
	}

	public unsafe float smoothTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smoothTime)) = num;
		}
	}

	public unsafe bool lockCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lockCursor)) = flag;
		}
	}

	public unsafe Quaternion m_CharacterTargetRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTargetRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CharacterTargetRot)) = quaternion;
		}
	}

	public unsafe Quaternion m_CameraTargetRot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTargetRot);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CameraTargetRot)) = quaternion;
		}
	}

	public unsafe bool m_cursorIsLocked
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cursorIsLocked);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_cursorIsLocked)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7001, XrefRangeEnd = 7005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init([DefaultParameterValue(null)] Transform character, [DefaultParameterValue(null)] Transform camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(camera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7042, RefRangeEnd = 7044, XrefRangeStart = 7005, XrefRangeEnd = 7042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LookRotation([DefaultParameterValue(null)] Transform character, [DefaultParameterValue(null)] Transform camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(camera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7044, XrefRangeEnd = 7048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCursorLock([DefaultParameterValue(null)] bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7048, XrefRangeEnd = 7049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCursorLock()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7058, RefRangeEnd = 7061, XrefRangeStart = 7049, XrefRangeEnd = 7058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InternalLockUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7061, XrefRangeEnd = 7064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion ClampRotationAroundXAxis([DefaultParameterValue(null)] Quaternion q)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&q);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe MLook()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MLook>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MLook()
	{
		Il2CppClassPointerStore<MLook>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Characters.FirstPerson", "MLook");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MLook>.NativeClassPtr);
		NativeFieldInfoPtr_XSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "XSensitivity");
		NativeFieldInfoPtr_YSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "YSensitivity");
		NativeFieldInfoPtr_clampVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "clampVerticalRotation");
		NativeFieldInfoPtr_MinimumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "MinimumX");
		NativeFieldInfoPtr_MaximumX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "MaximumX");
		NativeFieldInfoPtr_smooth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "smooth");
		NativeFieldInfoPtr_smoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "smoothTime");
		NativeFieldInfoPtr_lockCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "lockCursor");
		NativeFieldInfoPtr_m_CharacterTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_CharacterTargetRot");
		NativeFieldInfoPtr_m_CameraTargetRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_CameraTargetRot");
		NativeFieldInfoPtr_m_cursorIsLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MLook>.NativeClassPtr, "m_cursorIsLocked");
		NativeMethodInfoPtr_Init_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_LookRotation_Public_Void_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_SetCursorLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_UpdateCursorLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_InternalLockUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_ClampRotationAroundXAxis_Private_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MLook>.NativeClassPtr, 100663987);
	}

	public MLook(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
