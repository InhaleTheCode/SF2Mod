using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.RoutePoint;

public class RouteData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AppearPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_MiddleGoalPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_MiddleGoalPoint2;

	private static readonly System.IntPtr NativeFieldInfoPtr_GoalPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_routeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_PathRightScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextPoint_Public_Virtual_New_RoutePoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNextNextPoint_Public_RoutePoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IncrementIndex_Public_Virtual_New_RoutePoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcApplyPathRightPosition_Public_Vector3_RoutePoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProceedRandom_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetNextPoint_Public_Virtual_New_Void_RoutePoint_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RoutePoint AppearPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppearPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AppearPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint MiddleGoalPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddleGoalPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddleGoalPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint MiddleGoalPoint2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddleGoalPoint2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MiddleGoalPoint2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint GoalPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoalPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GoalPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<RoutePoint> routeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RoutePoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_routeList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float PathRightScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathRightScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathRightScale)) = num;
		}
	}

	public unsafe int currentIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentIndex)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46760, XrefRangeEnd = 46790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Setup()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46790, XrefRangeEnd = 46792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RoutePoint GetNextPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetNextPoint_Public_Virtual_New_RoutePoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 46793, RefRangeEnd = 46802, XrefRangeStart = 46792, XrefRangeEnd = 46793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutePoint GetNextNextPoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextNextPoint_Public_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual RoutePoint IncrementIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IncrementIndex_Public_Virtual_New_RoutePoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46802, XrefRangeEnd = 46803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 CalcApplyPathRightPosition([DefaultParameterValue(null)] RoutePoint rp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcApplyPathRightPosition_Public_Vector3_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46813, RefRangeEnd = 46814, XrefRangeStart = 46803, XrefRangeEnd = 46813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ProceedRandom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProceedRandom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void SetNextPoint([DefaultParameterValue(null)] RoutePoint point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(point);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_SetNextPoint_Public_Virtual_New_Void_RoutePoint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe RouteData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RouteData()
	{
		Il2CppClassPointerStore<RouteData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RouteData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteData>.NativeClassPtr);
		NativeFieldInfoPtr_AppearPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "AppearPoint");
		NativeFieldInfoPtr_MiddleGoalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "MiddleGoalPoint");
		NativeFieldInfoPtr_MiddleGoalPoint2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "MiddleGoalPoint2");
		NativeFieldInfoPtr_GoalPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "GoalPoint");
		NativeFieldInfoPtr_routeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "routeList");
		NativeFieldInfoPtr_PathRightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "PathRightScale");
		NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteData>.NativeClassPtr, "currentIndex");
		NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666232);
		NativeMethodInfoPtr_GetNextPoint_Public_Virtual_New_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666233);
		NativeMethodInfoPtr_GetNextNextPoint_Public_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666234);
		NativeMethodInfoPtr_IncrementIndex_Public_Virtual_New_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666235);
		NativeMethodInfoPtr_CalcApplyPathRightPosition_Public_Vector3_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666236);
		NativeMethodInfoPtr_ProceedRandom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666237);
		NativeMethodInfoPtr_SetNextPoint_Public_Virtual_New_Void_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666238);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteData>.NativeClassPtr, 100666239);
	}

	public RouteData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
