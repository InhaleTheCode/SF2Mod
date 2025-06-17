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

public class RouteBuilderFashionShop : BaseRouteBuilder
{
	private static readonly IntPtr NativeFieldInfoPtr_regiClerkPoint;

	private static readonly IntPtr NativeFieldInfoPtr_appearPoint;

	private static readonly IntPtr NativeFieldInfoPtr_roomWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_regiWaitPoint;

	private static readonly IntPtr NativeFieldInfoPtr_middleGoalTakeGoodsParent;

	private static readonly IntPtr NativeFieldInfoPtr_pathListParent;

	private static readonly IntPtr NativeFieldInfoPtr_middleGoalTakeGoodsPoints;

	private static readonly IntPtr NativeFieldInfoPtr_pathList;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcRight_Private_Void_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute2_Public_Virtual_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RoutePoint regiClerkPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiClerkPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiClerkPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint appearPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appearPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint roomWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_roomWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint regiWaitPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiWaitPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiWaitPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject middleGoalTakeGoodsParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleGoalTakeGoodsParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleGoalTakeGoodsParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform pathListParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathListParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathListParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> middleGoalTakeGoodsPoints
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleGoalTakeGoodsPoints);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_middleGoalTakeGoodsPoints), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Il2CppReferenceArray<RoutePoint>> pathList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<RoutePoint>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pathList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46917, XrefRangeEnd = 46954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46954, XrefRangeEnd = 46957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalcRight([DefaultParameterValue(null)] RoutePoint rp)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcRight_Private_Void_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46995, RefRangeEnd = 46996, XrefRangeStart = 46957, XrefRangeEnd = 46995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46996, XrefRangeEnd = 47013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47013, XrefRangeEnd = 47016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override RouteData CreateRoute2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CreateRoute2_Public_Virtual_RouteData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47016, XrefRangeEnd = 47027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertPick([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 47083, RefRangeEnd = 47084, XrefRangeStart = 47027, XrefRangeEnd = 47083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertMiddlePath([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47084, XrefRangeEnd = 47093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteBuilderFashionShop()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RouteBuilderFashionShop()
	{
		Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RouteBuilderFashionShop");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr);
		NativeFieldInfoPtr_regiClerkPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "regiClerkPoint");
		NativeFieldInfoPtr_appearPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "appearPoint");
		NativeFieldInfoPtr_roomWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "roomWaitPoint");
		NativeFieldInfoPtr_regiWaitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "regiWaitPoint");
		NativeFieldInfoPtr_middleGoalTakeGoodsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "middleGoalTakeGoodsParent");
		NativeFieldInfoPtr_pathListParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "pathListParent");
		NativeFieldInfoPtr_middleGoalTakeGoodsPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "middleGoalTakeGoodsPoints");
		NativeFieldInfoPtr_pathList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, "pathList");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666253);
		NativeMethodInfoPtr_CalcRight_Private_Void_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666254);
		NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666255);
		NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666256);
		NativeMethodInfoPtr_CreateRoute2_Public_Virtual_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666257);
		NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666258);
		NativeMethodInfoPtr_InsertMiddlePath_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666259);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderFashionShop>.NativeClassPtr, 100666260);
	}

	public RouteBuilderFashionShop(IntPtr pointer)
		: base(pointer)
	{
	}
}
