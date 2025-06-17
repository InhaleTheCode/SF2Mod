using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.RoutePoint;

public class RouteBuilderMansion : BaseRouteBuilder
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_stationSidePath;

	private static readonly IntPtr NativeFieldInfoPtr_bridgePath;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorExitPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_stairDownGoalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_stairUpGoalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_doorPointParentByFloor;

	private static readonly IntPtr NativeFieldInfoPtr_toExternalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_mansionPaths;

	private static readonly IntPtr NativeFieldInfoPtr_outsidePaths;

	private static readonly IntPtr NativeFieldInfoPtr_postReceiveParent;

	private static readonly IntPtr NativeFieldInfoPtr__ElevatorPoints_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_toExternalList;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorExitPoints;

	private static readonly IntPtr NativeFieldInfoPtr_stairDownGoalPoints;

	private static readonly IntPtr NativeFieldInfoPtr_stairUpGoalPoints;

	private static readonly IntPtr NativeFieldInfoPtr_postReceivePoints;

	private static readonly IntPtr NativeFieldInfoPtr_doorFloorDict;

	private static readonly IntPtr NativeFieldInfoPtr_mansionPathDict;

	private static readonly IntPtr NativeFieldInfoPtr_outsidePathDict;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_RouteBuilderMansion_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_RouteBuilderMansion_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ElevatorPoints_Public_get_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ElevatorPoints_Private_set_Void_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_DoorToEx_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_ExToDoor_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertElevator_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertStair_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertFloor1Middle_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWeightRandomFloor_Private_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static RouteBuilderMansion _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RouteBuilderMansion>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stationSidePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSidePath);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSidePath), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> bridgePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePath);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePath), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject elevatorPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject elevatorExitPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorExitPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorExitPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stairDownGoalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairDownGoalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairDownGoalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stairUpGoalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairUpGoalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairUpGoalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> doorPointParentByFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPointParentByFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorPointParentByFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject toExternalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toExternalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toExternalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> mansionPaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mansionPaths);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mansionPaths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> outsidePaths
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsidePaths);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsidePaths), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject postReceiveParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postReceiveParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postReceiveParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> _ElevatorPoints_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElevatorPoints_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ElevatorPoints_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> toExternalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toExternalList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toExternalList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> elevatorExitPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorExitPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorExitPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stairDownGoalPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairDownGoalPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairDownGoalPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stairUpGoalPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairUpGoalPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stairUpGoalPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> postReceivePoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postReceivePoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_postReceivePoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, List<RoutePoint>> doorFloorDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorFloorDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_doorFloorDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, Il2CppReferenceArray<RoutePoint>> mansionPathDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mansionPathDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mansionPathDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, Il2CppReferenceArray<RoutePoint>> outsidePathDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsidePathDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppReferenceArray<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outsidePathDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public new unsafe static RouteBuilderMansion Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47532, XrefRangeEnd = 47534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_RouteBuilderMansion_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteBuilderMansion>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47534, XrefRangeEnd = 47537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_RouteBuilderMansion_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> ElevatorPoints
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ElevatorPoints_Public_get_Il2CppReferenceArray_1_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ElevatorPoints_Private_set_Void_Il2CppReferenceArray_1_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47537, XrefRangeEnd = 47549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47549, XrefRangeEnd = 47566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47566, XrefRangeEnd = 47617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47655, RefRangeEnd = 47657, XrefRangeStart = 47617, XrefRangeEnd = 47655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalcPathRight([DefaultParameterValue(null)] Il2CppReferenceArray<RoutePoint> path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47657, XrefRangeEnd = 47663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RouteData CreateRoute(bool isFemale = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFemale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47689, RefRangeEnd = 47690, XrefRangeStart = 47663, XrefRangeEnd = 47689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData DoorToEx()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoorToEx_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47721, RefRangeEnd = 47722, XrefRangeStart = 47690, XrefRangeEnd = 47721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData ExToDoor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExToDoor_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47730, RefRangeEnd = 47732, XrefRangeStart = 47722, XrefRangeEnd = 47730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertElevator([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertElevator_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47738, RefRangeEnd = 47740, XrefRangeStart = 47732, XrefRangeEnd = 47738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertStair([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertStair_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47746, RefRangeEnd = 47748, XrefRangeStart = 47740, XrefRangeEnd = 47746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertFloor1Middle([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertFloor1Middle_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 47807, RefRangeEnd = 47809, XrefRangeStart = 47748, XrefRangeEnd = 47807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertMiddlePath([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47811, RefRangeEnd = 47812, XrefRangeStart = 47809, XrefRangeEnd = 47811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetWeightRandomFloor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeightRandomFloor_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47812, XrefRangeEnd = 47831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteBuilderMansion()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RouteBuilderMansion()
	{
		Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RouteBuilderMansion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_stationSidePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "stationSidePath");
		NativeFieldInfoPtr_bridgePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "bridgePath");
		NativeFieldInfoPtr_elevatorPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "elevatorPointParent");
		NativeFieldInfoPtr_elevatorExitPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "elevatorExitPointParent");
		NativeFieldInfoPtr_stairDownGoalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "stairDownGoalPointParent");
		NativeFieldInfoPtr_stairUpGoalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "stairUpGoalPointParent");
		NativeFieldInfoPtr_doorPointParentByFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "doorPointParentByFloor");
		NativeFieldInfoPtr_toExternalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "toExternalPointParent");
		NativeFieldInfoPtr_mansionPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "mansionPaths");
		NativeFieldInfoPtr_outsidePaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "outsidePaths");
		NativeFieldInfoPtr_postReceiveParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "postReceiveParent");
		NativeFieldInfoPtr__ElevatorPoints_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "<ElevatorPoints>k__BackingField");
		NativeFieldInfoPtr_toExternalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "toExternalList");
		NativeFieldInfoPtr_elevatorExitPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "elevatorExitPoints");
		NativeFieldInfoPtr_stairDownGoalPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "stairDownGoalPoints");
		NativeFieldInfoPtr_stairUpGoalPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "stairUpGoalPoints");
		NativeFieldInfoPtr_postReceivePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "postReceivePoints");
		NativeFieldInfoPtr_doorFloorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "doorFloorDict");
		NativeFieldInfoPtr_mansionPathDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "mansionPathDict");
		NativeFieldInfoPtr_outsidePathDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, "outsidePathDict");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_RouteBuilderMansion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666281);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_RouteBuilderMansion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666282);
		NativeMethodInfoPtr_get_ElevatorPoints_Public_get_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666283);
		NativeMethodInfoPtr_set_ElevatorPoints_Private_set_Void_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666284);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666285);
		NativeMethodInfoPtr_OnDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666286);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666287);
		NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666288);
		NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666289);
		NativeMethodInfoPtr_DoorToEx_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666290);
		NativeMethodInfoPtr_ExToDoor_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666291);
		NativeMethodInfoPtr_InsertElevator_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666292);
		NativeMethodInfoPtr_InsertStair_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666293);
		NativeMethodInfoPtr_InsertFloor1Middle_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666294);
		NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666295);
		NativeMethodInfoPtr_GetWeightRandomFloor_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666296);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderMansion>.NativeClassPtr, 100666297);
	}

	public RouteBuilderMansion(IntPtr pointer)
		: base(pointer)
	{
	}
}
