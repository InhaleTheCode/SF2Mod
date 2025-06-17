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

public class RouteBuilderStationFront : BaseRouteBuilder
{
	public enum RoutePattern
	{
		DoorMidDoor,
		ExDoor,
		DoorEx,
		EndEnum
	}

	private static readonly IntPtr NativeFieldInfoPtr_stationSideToExternalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_stationSideMiddleGoalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_stationSideDoorPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideToExternalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideMiddleGoalPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideDoorPointParent;

	private static readonly IntPtr NativeFieldInfoPtr_stationSidePathParent;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideSilentPathParent;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideShopPathParent;

	private static readonly IntPtr NativeFieldInfoPtr_bridgePointStationSide;

	private static readonly IntPtr NativeFieldInfoPtr_bridgePointShopSide;

	private static readonly IntPtr NativeFieldInfoPtr_laundryPoint;

	private static readonly IntPtr NativeFieldInfoPtr_bridgePathParent;

	private static readonly IntPtr NativeFieldInfoPtr_stationSideToExternalList;

	private static readonly IntPtr NativeFieldInfoPtr_stationSideMiddleGoalList;

	private static readonly IntPtr NativeFieldInfoPtr_stationSideDoorList;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideToExternalList;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideMiddleGoalList;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideDoorList;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideShopPathList;

	private static readonly IntPtr NativeFieldInfoPtr_shopSideSilentPathList;

	private static readonly IntPtr NativeFieldInfoPtr_doorFloorDict;

	private static readonly IntPtr NativeFieldInfoPtr_middleFloorDict;

	private static readonly IntPtr NativeFieldInfoPtr_middlePathDict;

	private static readonly IntPtr NativeFieldInfoPtr_stationSidePath;

	private static readonly IntPtr NativeFieldInfoPtr_bridgePath;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRandomManyShop_Private_RoutePoint_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateBridgeData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateShopSideDoorExData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateShopSideExDoorData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateShopSideBothMidBothData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateStationSideDoorExData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateStationSideExDoorData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateStationSideBothMidBothData_Private_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_SelectMiddlePoint_Private_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertBridgePath_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetWeightRandomFloor_Private_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject stationSideToExternalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideToExternalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideToExternalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stationSideMiddleGoalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideMiddleGoalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideMiddleGoalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stationSideDoorPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideDoorPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideDoorPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject shopSideToExternalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideToExternalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideToExternalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject shopSideMiddleGoalPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideMiddleGoalPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideMiddleGoalPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject shopSideDoorPointParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideDoorPointParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideDoorPointParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject stationSidePathParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSidePathParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSidePathParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> shopSideSilentPathParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideSilentPathParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideSilentPathParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> shopSideShopPathParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideShopPathParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideShopPathParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint bridgePointStationSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePointStationSide);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePointStationSide), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint bridgePointShopSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePointShopSide);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePointShopSide), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint laundryPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_laundryPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_laundryPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject bridgePathParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePathParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bridgePathParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stationSideToExternalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideToExternalList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideToExternalList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stationSideMiddleGoalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideMiddleGoalList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideMiddleGoalList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> stationSideDoorList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideDoorList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stationSideDoorList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> shopSideToExternalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideToExternalList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideToExternalList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> shopSideMiddleGoalList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideMiddleGoalList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideMiddleGoalList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> shopSideDoorList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideDoorList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideDoorList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppReferenceArray<RoutePoint>> shopSideShopPathList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideShopPathList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideShopPathList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppReferenceArray<RoutePoint>> shopSideSilentPathList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideSilentPathList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shopSideSilentPathList), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Dictionary<int, List<RoutePoint>> middleFloorDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleFloorDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleFloorDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, List<Il2CppReferenceArray<RoutePoint>>> middlePathDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middlePathDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, List<Il2CppReferenceArray<RoutePoint>>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middlePathDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48022, XrefRangeEnd = 48127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 48165, RefRangeEnd = 48169, XrefRangeStart = 48127, XrefRangeEnd = 48165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48169, XrefRangeEnd = 48202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48202, XrefRangeEnd = 48207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutePoint GetRandomManyShop([DefaultParameterValue(null)] Il2CppReferenceArray<RoutePoint> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandomManyShop_Private_RoutePoint_Il2CppReferenceArray_1_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48234, RefRangeEnd = 48235, XrefRangeStart = 48207, XrefRangeEnd = 48234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateBridgeData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateBridgeData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48249, RefRangeEnd = 48250, XrefRangeStart = 48235, XrefRangeEnd = 48249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateShopSideDoorExData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShopSideDoorExData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48250, XrefRangeEnd = 48264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateShopSideExDoorData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShopSideExDoorData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48292, RefRangeEnd = 48293, XrefRangeStart = 48264, XrefRangeEnd = 48292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateShopSideBothMidBothData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateShopSideBothMidBothData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48293, XrefRangeEnd = 48303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateStationSideDoorExData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStationSideDoorExData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48303, XrefRangeEnd = 48313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateStationSideExDoorData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStationSideExDoorData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 48330, RefRangeEnd = 48331, XrefRangeStart = 48313, XrefRangeEnd = 48330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteData CreateStationSideBothMidBothData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateStationSideBothMidBothData_Private_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48331, XrefRangeEnd = 48349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutePoint SelectMiddlePoint()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SelectMiddlePoint_Private_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 48406, RefRangeEnd = 48415, XrefRangeStart = 48349, XrefRangeEnd = 48406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertMiddlePath([DefaultParameterValue(null)] RouteData rd, [DefaultParameterValue(null)] bool isStationSide)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isStationSide;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48415, XrefRangeEnd = 48422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertBridgePath([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertBridgePath_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47811, RefRangeEnd = 47812, XrefRangeStart = 47811, XrefRangeEnd = 47812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48422, XrefRangeEnd = 48451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteBuilderStationFront()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RouteBuilderStationFront()
	{
		Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RouteBuilderStationFront");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr);
		NativeFieldInfoPtr_stationSideToExternalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideToExternalPointParent");
		NativeFieldInfoPtr_stationSideMiddleGoalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideMiddleGoalPointParent");
		NativeFieldInfoPtr_stationSideDoorPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideDoorPointParent");
		NativeFieldInfoPtr_shopSideToExternalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideToExternalPointParent");
		NativeFieldInfoPtr_shopSideMiddleGoalPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideMiddleGoalPointParent");
		NativeFieldInfoPtr_shopSideDoorPointParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideDoorPointParent");
		NativeFieldInfoPtr_stationSidePathParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSidePathParent");
		NativeFieldInfoPtr_shopSideSilentPathParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideSilentPathParent");
		NativeFieldInfoPtr_shopSideShopPathParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideShopPathParent");
		NativeFieldInfoPtr_bridgePointStationSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "bridgePointStationSide");
		NativeFieldInfoPtr_bridgePointShopSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "bridgePointShopSide");
		NativeFieldInfoPtr_laundryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "laundryPoint");
		NativeFieldInfoPtr_bridgePathParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "bridgePathParent");
		NativeFieldInfoPtr_stationSideToExternalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideToExternalList");
		NativeFieldInfoPtr_stationSideMiddleGoalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideMiddleGoalList");
		NativeFieldInfoPtr_stationSideDoorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSideDoorList");
		NativeFieldInfoPtr_shopSideToExternalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideToExternalList");
		NativeFieldInfoPtr_shopSideMiddleGoalList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideMiddleGoalList");
		NativeFieldInfoPtr_shopSideDoorList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideDoorList");
		NativeFieldInfoPtr_shopSideShopPathList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideShopPathList");
		NativeFieldInfoPtr_shopSideSilentPathList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "shopSideSilentPathList");
		NativeFieldInfoPtr_doorFloorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "doorFloorDict");
		NativeFieldInfoPtr_middleFloorDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "middleFloorDict");
		NativeFieldInfoPtr_middlePathDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "middlePathDict");
		NativeFieldInfoPtr_stationSidePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "stationSidePath");
		NativeFieldInfoPtr_bridgePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, "bridgePath");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666305);
		NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666306);
		NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666307);
		NativeMethodInfoPtr_GetRandomManyShop_Private_RoutePoint_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666308);
		NativeMethodInfoPtr_CreateBridgeData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666309);
		NativeMethodInfoPtr_CreateShopSideDoorExData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666310);
		NativeMethodInfoPtr_CreateShopSideExDoorData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666311);
		NativeMethodInfoPtr_CreateShopSideBothMidBothData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666312);
		NativeMethodInfoPtr_CreateStationSideDoorExData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666313);
		NativeMethodInfoPtr_CreateStationSideExDoorData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666314);
		NativeMethodInfoPtr_CreateStationSideBothMidBothData_Private_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666315);
		NativeMethodInfoPtr_SelectMiddlePoint_Private_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666316);
		NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666317);
		NativeMethodInfoPtr_InsertBridgePath_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666318);
		NativeMethodInfoPtr_GetWeightRandomFloor_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666319);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderStationFront>.NativeClassPtr, 100666320);
	}

	public RouteBuilderStationFront(IntPtr pointer)
		: base(pointer)
	{
	}
}
