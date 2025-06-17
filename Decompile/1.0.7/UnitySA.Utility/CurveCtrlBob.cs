using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnitySA.Utility;

[System.Serializable]
public class CurveCtrlBob : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalBobRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticalBobRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bobcurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_VerticaltoHorizontalRatio;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CyclePositionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CyclePositionY;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BobBaseInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OriginalCameraPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float HorizontalBobRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalBobRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HorizontalBobRange)) = num;
		}
	}

	public unsafe float VerticalBobRange
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalBobRange);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticalBobRange)) = num;
		}
	}

	public unsafe AnimationCurve Bobcurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bobcurve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bobcurve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float VerticaltoHorizontalRatio
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticaltoHorizontalRatio);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VerticaltoHorizontalRatio)) = num;
		}
	}

	public unsafe float m_CyclePositionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CyclePositionX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CyclePositionX)) = num;
		}
	}

	public unsafe float m_CyclePositionY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CyclePositionY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CyclePositionY)) = num;
		}
	}

	public unsafe float m_BobBaseInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BobBaseInterval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BobBaseInterval)) = num;
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

	public unsafe float m_Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time)) = num;
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7072, RefRangeEnd = 7073, XrefRangeStart = 7064, XrefRangeEnd = 7072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Setup([DefaultParameterValue(null)] Camera camera, [DefaultParameterValue(null)] float bobBaseInterval)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &bobBaseInterval;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7081, RefRangeEnd = 7082, XrefRangeStart = 7073, XrefRangeEnd = 7081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 DoHeadBob([DefaultParameterValue(null)] float speed)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&speed);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7090, RefRangeEnd = 7091, XrefRangeStart = 7082, XrefRangeEnd = 7090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveCtrlBob()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CurveCtrlBob()
	{
		Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnitySA.Utility", "CurveCtrlBob");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr);
		NativeFieldInfoPtr_HorizontalBobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "HorizontalBobRange");
		NativeFieldInfoPtr_VerticalBobRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "VerticalBobRange");
		NativeFieldInfoPtr_Bobcurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "Bobcurve");
		NativeFieldInfoPtr_VerticaltoHorizontalRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "VerticaltoHorizontalRatio");
		NativeFieldInfoPtr_m_CyclePositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_CyclePositionX");
		NativeFieldInfoPtr_m_CyclePositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_CyclePositionY");
		NativeFieldInfoPtr_m_BobBaseInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_BobBaseInterval");
		NativeFieldInfoPtr_m_OriginalCameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_OriginalCameraPosition");
		NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, "m_Time");
		NativeMethodInfoPtr_Setup_Public_Void_Camera_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_DoHeadBob_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveCtrlBob>.NativeClassPtr, 100663990);
	}

	public CurveCtrlBob(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
