using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine;
using UnityEngine.Events;

namespace SplineMesh;

public class Spline : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nodes;

	private static readonly System.IntPtr NativeFieldInfoPtr_curves;

	private static readonly System.IntPtr NativeFieldInfoPtr_Length;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLoop;

	private static readonly System.IntPtr NativeFieldInfoPtr_NodeListChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurveChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_end;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLoop_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsLoop_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_add_NodeListChanged_Public_add_Void_ListChangeHandler_1_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_remove_NodeListChanged_Public_rem_Void_ListChangeHandler_1_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurves_Public_ReadOnlyCollection_1_CubicBezierCurve_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RaiseNodeListChanged_Private_Void_ListChangedEventArgs_1_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAfterCurveChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurve_Public_CubicBezierCurve_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNodeIndexForTime_Private_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshCurves_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleAtDistance_Public_CurveSample_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddNode_Public_Void_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertNode_Public_Void_Int32_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNode_Public_Void_SplineNode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateLoopBinding_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StartNodeChanged_Private_Void_Object_EventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndNodeChanged_Private_Void_Object_EventArgs_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProjectionSample_Public_CurveSample_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<SplineNode> nodes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<SplineNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CubicBezierCurve> curves
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curves);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CubicBezierCurve>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curves), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float Length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Length)) = num;
		}
	}

	public unsafe bool isLoop
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLoop)) = flag;
		}
	}

	public unsafe ListChangeHandler<SplineNode> NodeListChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeListChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ListChangeHandler<SplineNode>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NodeListChanged), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UnityEvent CurveChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurveChanged), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SplineNode start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SplineNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SplineNode end
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SplineNode>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_end), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsLoop
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsLoop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7835, XrefRangeEnd = 7836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsLoop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[SpecialName]
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 7841, RefRangeEnd = 7846, XrefRangeStart = 7836, XrefRangeEnd = 7841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_NodeListChanged([DefaultParameterValue(null)] ListChangeHandler<SplineNode> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_add_NodeListChanged_Public_add_Void_ListChangeHandler_1_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[SpecialName]
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7846, XrefRangeEnd = 7851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_NodeListChanged([DefaultParameterValue(null)] ListChangeHandler<SplineNode> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_remove_NodeListChanged_Public_rem_Void_ListChangeHandler_1_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7851, XrefRangeEnd = 7873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7873, XrefRangeEnd = 7874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 7878, RefRangeEnd = 7884, XrefRangeStart = 7874, XrefRangeEnd = 7878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReadOnlyCollection<CubicBezierCurve> GetCurves()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurves_Public_ReadOnlyCollection_1_CubicBezierCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReadOnlyCollection<CubicBezierCurve>>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe void RaiseNodeListChanged([DefaultParameterValue(null)] ListChangedEventArgs<SplineNode> args)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RaiseNodeListChanged_Private_Void_ListChangedEventArgs_1_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 7893, RefRangeEnd = 7898, XrefRangeStart = 7884, XrefRangeEnd = 7893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateAfterCurveChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateAfterCurveChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7898, XrefRangeEnd = 7901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CurveSample GetSample([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CurveSample(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7901, XrefRangeEnd = 7903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CubicBezierCurve GetCurve([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurve_Public_CubicBezierCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CubicBezierCurve>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7905, RefRangeEnd = 7908, XrefRangeStart = 7903, XrefRangeEnd = 7905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetNodeIndexForTime([DefaultParameterValue(null)] float t)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNodeIndexForTime_Private_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7940, RefRangeEnd = 7941, XrefRangeStart = 7908, XrefRangeEnd = 7940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshCurves()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshCurves_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 7948, RefRangeEnd = 7954, XrefRangeStart = 7941, XrefRangeEnd = 7948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 7993, RefRangeEnd = 7996, XrefRangeStart = 7954, XrefRangeEnd = 7993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNode([DefaultParameterValue(null)] SplineNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddNode_Public_Void_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7996, XrefRangeEnd = 8042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertNode([DefaultParameterValue(null)] int index, [DefaultParameterValue(null)] SplineNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(node);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertNode_Public_Void_Int32_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8089, RefRangeEnd = 8090, XrefRangeStart = 8042, XrefRangeEnd = 8089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNode([DefaultParameterValue(null)] SplineNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveNode_Public_Void_SplineNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 8105, RefRangeEnd = 8109, XrefRangeStart = 8090, XrefRangeEnd = 8105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateLoopBinding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateLoopBinding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8109, XrefRangeEnd = 8127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartNodeChanged([DefaultParameterValue(null)] Il2CppSystem.Object sender, [DefaultParameterValue(null)] Il2CppSystem.EventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartNodeChanged_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8127, XrefRangeEnd = 8145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndNodeChanged([DefaultParameterValue(null)] Il2CppSystem.Object sender, [DefaultParameterValue(null)] Il2CppSystem.EventArgs e)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(e);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndNodeChanged_Private_Void_Object_EventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8145, XrefRangeEnd = 8156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8156, XrefRangeEnd = 8175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Spline()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spline>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Spline()
	{
		Il2CppClassPointerStore<Spline>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "Spline");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spline>.NativeClassPtr);
		NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "nodes");
		NativeFieldInfoPtr_curves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "curves");
		NativeFieldInfoPtr_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "Length");
		NativeFieldInfoPtr_isLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "isLoop");
		NativeFieldInfoPtr_NodeListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "NodeListChanged");
		NativeFieldInfoPtr_CurveChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "CurveChanged");
		NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "start");
		NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spline>.NativeClassPtr, "end");
		NativeMethodInfoPtr_get_IsLoop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664069);
		NativeMethodInfoPtr_set_IsLoop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664070);
		NativeMethodInfoPtr_add_NodeListChanged_Public_add_Void_ListChangeHandler_1_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664071);
		NativeMethodInfoPtr_remove_NodeListChanged_Public_rem_Void_ListChangeHandler_1_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664072);
		NativeMethodInfoPtr_Reset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664073);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664074);
		NativeMethodInfoPtr_GetCurves_Public_ReadOnlyCollection_1_CubicBezierCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664075);
		NativeMethodInfoPtr_RaiseNodeListChanged_Private_Void_ListChangedEventArgs_1_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664076);
		NativeMethodInfoPtr_UpdateAfterCurveChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664077);
		NativeMethodInfoPtr_GetSample_Public_CurveSample_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664078);
		NativeMethodInfoPtr_GetCurve_Public_CubicBezierCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664079);
		NativeMethodInfoPtr_GetNodeIndexForTime_Private_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664080);
		NativeMethodInfoPtr_RefreshCurves_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664081);
		NativeMethodInfoPtr_GetSampleAtDistance_Public_CurveSample_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664082);
		NativeMethodInfoPtr_AddNode_Public_Void_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664083);
		NativeMethodInfoPtr_InsertNode_Public_Void_Int32_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664084);
		NativeMethodInfoPtr_RemoveNode_Public_Void_SplineNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664085);
		NativeMethodInfoPtr_updateLoopBinding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664086);
		NativeMethodInfoPtr_StartNodeChanged_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664087);
		NativeMethodInfoPtr_EndNodeChanged_Private_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664088);
		NativeMethodInfoPtr_GetProjectionSample_Public_CurveSample_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664089);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spline>.NativeClassPtr, 100664090);
	}

	public Spline(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
