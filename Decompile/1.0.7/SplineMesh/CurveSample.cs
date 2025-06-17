using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SplineMesh;

public sealed class CurveSample : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_location;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangent;

	private static readonly System.IntPtr NativeFieldInfoPtr_up;

	private static readonly System.IntPtr NativeFieldInfoPtr_scale;

	private static readonly System.IntPtr NativeFieldInfoPtr_roll;

	private static readonly System.IntPtr NativeFieldInfoPtr_distanceInCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeInCurve;

	private static readonly System.IntPtr NativeFieldInfoPtr_curve;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotation;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector2_Single_Single_Single_CubicBezierCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CurveSample_CurveSample_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CurveSample_CurveSample_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_CurveSample_CurveSample_CurveSample_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBent_Public_MeshVertex_MeshVertex_0;

	public unsafe Vector3 location
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_location)) = vector;
		}
	}

	public unsafe Vector3 tangent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangent);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tangent)) = vector;
		}
	}

	public unsafe Vector3 up
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_up)) = vector;
		}
	}

	public unsafe Vector2 scale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_scale)) = vector;
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

	public unsafe float distanceInCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceInCurve);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_distanceInCurve)) = num;
		}
	}

	public unsafe float timeInCurve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeInCurve);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeInCurve)) = num;
		}
	}

	public unsafe CubicBezierCurve curve
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CubicBezierCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curve), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Quaternion rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotation)) = quaternion;
		}
	}

	public unsafe Quaternion Rotation
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 7765, RefRangeEnd = 7768, XrefRangeStart = 7753, XrefRangeEnd = 7765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7768, XrefRangeEnd = 7770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample([DefaultParameterValue(null)] Vector3 location, [DefaultParameterValue(null)] Vector3 tangent, [DefaultParameterValue(null)] Vector3 up, [DefaultParameterValue(null)] Vector2 scale, [DefaultParameterValue(null)] float roll, [DefaultParameterValue(null)] float distanceInCurve, [DefaultParameterValue(null)] float timeInCurve, [DefaultParameterValue(null)] CubicBezierCurve curve)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveSample>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&location);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tangent;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &up;
		*(Vector2**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &roll;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &distanceInCurve;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeInCurve;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(curve);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector2_Single_Single_Single_CubicBezierCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7780, RefRangeEnd = 7784, XrefRangeStart = 7770, XrefRangeEnd = 7780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals([DefaultParameterValue(null)] Il2CppSystem.Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7784, XrefRangeEnd = 7788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7788, XrefRangeEnd = 7792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==([DefaultParameterValue(null)] CurveSample cs1, [DefaultParameterValue(null)] CurveSample cs2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cs1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cs2));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CurveSample_CurveSample_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7792, XrefRangeEnd = 7796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=([DefaultParameterValue(null)] CurveSample cs1, [DefaultParameterValue(null)] CurveSample cs2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cs1));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cs2));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CurveSample_CurveSample_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7814, RefRangeEnd = 7817, XrefRangeStart = 7796, XrefRangeEnd = 7814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CurveSample Lerp([DefaultParameterValue(null)] CurveSample a, [DefaultParameterValue(null)] CurveSample b, [DefaultParameterValue(null)] float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Public_Static_CurveSample_CurveSample_CurveSample_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7831, RefRangeEnd = 7835, XrefRangeStart = 7817, XrefRangeEnd = 7831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MeshVertex GetBent([DefaultParameterValue(null)] MeshVertex vert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vert);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBent_Public_MeshVertex_MeshVertex_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshVertex>(intPtr) : null;
	}

	static CurveSample()
	{
		Il2CppClassPointerStore<CurveSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "CurveSample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurveSample>.NativeClassPtr);
		NativeFieldInfoPtr_location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "location");
		NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "tangent");
		NativeFieldInfoPtr_up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "up");
		NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "scale");
		NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "roll");
		NativeFieldInfoPtr_distanceInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "distanceInCurve");
		NativeFieldInfoPtr_timeInCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "timeInCurve");
		NativeFieldInfoPtr_curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "curve");
		NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, "rotation");
		NativeMethodInfoPtr_get_Rotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664061);
		NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Vector3_Vector2_Single_Single_Single_CubicBezierCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664062);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664063);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664064);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CurveSample_CurveSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664065);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_CurveSample_CurveSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664066);
		NativeMethodInfoPtr_Lerp_Public_Static_CurveSample_CurveSample_CurveSample_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664067);
		NativeMethodInfoPtr_GetBent_Public_MeshVertex_MeshVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurveSample>.NativeClassPtr, 100664068);
	}

	public CurveSample(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CurveSample()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurveSample>.NativeClassPtr))
	{
	}
}
