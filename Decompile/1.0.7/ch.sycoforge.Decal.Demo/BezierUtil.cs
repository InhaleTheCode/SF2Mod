using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Demo;

public static class BezierUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_InterpolatePath_Public_Static_List_1_Vector3_List_1_Vector3_Int32_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBezierApproximation_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetBezierPoint_Public_Static_Vector3_Single_Il2CppStructArray_1_Vector3_Int32_Int32_0;

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7298, RefRangeEnd = 7299, XrefRangeStart = 7293, XrefRangeEnd = 7298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Vector3> InterpolatePath([DefaultParameterValue(null)] List<Vector3> path, [DefaultParameterValue(null)] int segments, [DefaultParameterValue(null)] float radius, [DefaultParameterValue(null)] float angleThreshold)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &segments;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &radius;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &angleThreshold;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InterpolatePath_Public_Static_List_1_Vector3_List_1_Vector3_Int32_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7299, XrefRangeEnd = 7303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<Vector3> GetBezierApproximation([DefaultParameterValue(null)] Il2CppStructArray<Vector3> controlPoints, [DefaultParameterValue(null)] int outputSegmentCount)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputSegmentCount;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBezierApproximation_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 7306, RefRangeEnd = 7310, XrefRangeStart = 7303, XrefRangeEnd = 7306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 GetBezierPoint([DefaultParameterValue(null)] float t, [DefaultParameterValue(null)] Il2CppStructArray<Vector3> controlPoints, [DefaultParameterValue(null)] int index, [DefaultParameterValue(null)] int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBezierPoint_Public_Static_Vector3_Single_Il2CppStructArray_1_Vector3_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static BezierUtil()
	{
		Il2CppClassPointerStore<BezierUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ch.sycoforge.Decal.Demo", "BezierUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BezierUtil>.NativeClassPtr);
		NativeMethodInfoPtr_InterpolatePath_Public_Static_List_1_Vector3_List_1_Vector3_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierUtil>.NativeClassPtr, 100664024);
		NativeMethodInfoPtr_GetBezierApproximation_Public_Static_Il2CppStructArray_1_Vector3_Il2CppStructArray_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierUtil>.NativeClassPtr, 100664025);
		NativeMethodInfoPtr_GetBezierPoint_Public_Static_Vector3_Single_Il2CppStructArray_1_Vector3_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BezierUtil>.NativeClassPtr, 100664026);
	}

	public BezierUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
