using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SplineMesh;

[System.Serializable]
public class CubicBezierCurve : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_STEP_COUNT;

	private static readonly System.IntPtr NativeFieldInfoPtr_T_STEP;

	private static readonly System.IntPtr NativeFieldInfoPtr_samples;

	private static readonly System.IntPtr NativeFieldInfoPtr_n1;

	private static readonly System.IntPtr NativeFieldInfoPtr_n2;

	private static readonly System.IntPtr NativeFieldInfoPtr__Length_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_Changed;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Length_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SplineNode_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectStart_Public_Void_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConnectEnd_Public_Void_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInverseDirection_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLocation_Private_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTangent_Private_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUp_Private_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetScale_Private_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRoll_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeSamples_Private_Void_Object_EventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSample_Private_CurveSample_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleAtDistance_Public_CurveSample_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AssertTimeInBounds_Private_Static_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionSample_Public_CurveSample_Vector3_0;

	public unsafe static int STEP_COUNT
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEP_COUNT, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEP_COUNT, &num);
		}
	}

	public unsafe static float T_STEP
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_T_STEP, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_T_STEP, &num);
		}
	}

	public unsafe List<CurveSample> samples
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samples);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CurveSample>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_samples), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SplineNode n1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SplineNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SplineNode n2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SplineNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_n2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float _Length_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Length_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Length_k__BackingField)) = num;
		}
	}

	public unsafe UnityEvent Changed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Changed);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Changed), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float Length
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Length_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Length_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7613, RefRangeEnd = 7616, XrefRangeStart = 7588, XrefRangeEnd = 7613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubicBezierCurve([DefaultParameterValue(null)] SplineNode n1, [DefaultParameterValue(null)] SplineNode n2)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(n1);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(n2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SplineNode_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7616, XrefRangeEnd = 7630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectStart([DefaultParameterValue(null)] SplineNode n1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(n1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectStart_Public_Void_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7644, RefRangeEnd = 7646, XrefRangeStart = 7630, XrefRangeEnd = 7644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectEnd([DefaultParameterValue(null)] SplineNode n2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(n2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConnectEnd_Public_Void_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Vector3 GetInverseDirection()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInverseDirection_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7646, RefRangeEnd = 7650, XrefRangeStart = 7646, XrefRangeEnd = 7646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetLocation([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLocation_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7654, RefRangeEnd = 7655, XrefRangeStart = 7650, XrefRangeEnd = 7654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetTangent([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTangent_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7655, XrefRangeEnd = 7656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetUp([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUp_Private_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7656, XrefRangeEnd = 7658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 GetScale([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetScale_Private_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float GetRoll([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRoll_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7685, RefRangeEnd = 7688, XrefRangeStart = 7658, XrefRangeEnd = 7685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ComputeSamples([DefaultParameterValue(null)] Il2CppSystem.Object sender, [DefaultParameterValue(null)] Il2CppSystem.EventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeSamples_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7696, RefRangeEnd = 7698, XrefRangeStart = 7688, XrefRangeEnd = 7696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample CreateSample([DefaultParameterValue(null)] float distance, [DefaultParameterValue(null)] float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&distance);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &time;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSample_Private_CurveSample_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 7713, RefRangeEnd = 7715, XrefRangeStart = 7698, XrefRangeEnd = 7713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample GetSample([DefaultParameterValue(null)] float time)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 7730, RefRangeEnd = 7736, XrefRangeStart = 7715, XrefRangeEnd = 7730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample GetSampleAtDistance([DefaultParameterValue(null)] float d)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&d);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSampleAtDistance_Public_CurveSample_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	[CallerCount(0)]
	public unsafe static void AssertTimeInBounds([DefaultParameterValue(null)] float time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&time);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AssertTimeInBounds_Private_Static_Void_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7752, RefRangeEnd = 7753, XrefRangeStart = 7736, XrefRangeEnd = 7752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample GetProjectionSample([DefaultParameterValue(null)] Vector3 pointToProject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pointToProject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProjectionSample_Public_CurveSample_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	static CubicBezierCurve()
	{
		Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "CubicBezierCurve");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr);
		NativeFieldInfoPtr_STEP_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "STEP_COUNT");
		NativeFieldInfoPtr_T_STEP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "T_STEP");
		NativeFieldInfoPtr_samples = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "samples");
		NativeFieldInfoPtr_n1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "n1");
		NativeFieldInfoPtr_n2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "n2");
		NativeFieldInfoPtr__Length_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "<Length>k__BackingField");
		NativeFieldInfoPtr_Changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, "Changed");
		NativeMethodInfoPtr_get_Length_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_set_Length_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr__ctor_Public_Void_SplineNode_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_ConnectStart_Public_Void_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_ConnectEnd_Public_Void_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_GetInverseDirection_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_GetLocation_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_GetTangent_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664051);
		NativeMethodInfoPtr_GetUp_Private_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664052);
		NativeMethodInfoPtr_GetScale_Private_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664053);
		NativeMethodInfoPtr_GetRoll_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664054);
		NativeMethodInfoPtr_ComputeSamples_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664055);
		NativeMethodInfoPtr_CreateSample_Private_CurveSample_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664056);
		NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664057);
		NativeMethodInfoPtr_GetSampleAtDistance_Public_CurveSample_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664058);
		NativeMethodInfoPtr_AssertTimeInBounds_Private_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664059);
		NativeMethodInfoPtr_GetProjectionSample_Public_CurveSample_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CubicBezierCurve>.NativeClassPtr, 100664060);
	}

	public CubicBezierCurve(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
