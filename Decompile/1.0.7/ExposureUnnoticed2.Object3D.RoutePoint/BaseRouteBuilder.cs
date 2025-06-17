using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.RoutePoint;

public class BaseRouteBuilder : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute_Public_Virtual_New_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute2_Public_Virtual_New_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcNearestPointByStep_Protected_RoutePoint_RoutePoint_Il2CppReferenceArray_1_RoutePoint_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcNearPointIndex_Protected_Int32_GameObject_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static BaseRouteBuilder Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BaseRouteBuilder>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46721, XrefRangeEnd = 46724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46727, RefRangeEnd = 46729, XrefRangeStart = 46724, XrefRangeEnd = 46727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual RouteData CreateRoute(bool isFemale = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFemale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CreateRoute_Public_Virtual_New_RouteData_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual RouteData CreateRoute2()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CreateRoute2_Public_Virtual_New_RouteData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RouteData>(intPtr) : null;
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 46737, RefRangeEnd = 46749, XrefRangeStart = 46729, XrefRangeEnd = 46737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutePoint CalcNearestPointByStep([DefaultParameterValue(null)] RoutePoint goalRp, [DefaultParameterValue(null)] Il2CppReferenceArray<RoutePoint> path, [DefaultParameterValue(null)] int startIndex, [DefaultParameterValue(null)] int step)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(goalRp);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(path);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &step;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcNearestPointByStep_Protected_RoutePoint_RoutePoint_Il2CppReferenceArray_1_RoutePoint_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 46755, RefRangeEnd = 46760, XrefRangeStart = 46749, XrefRangeEnd = 46755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalcNearPointIndex([DefaultParameterValue(null)] GameObject start, [DefaultParameterValue(null)] Il2CppReferenceArray<RoutePoint> points)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(points);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcNearPointIndex_Protected_Int32_GameObject_Il2CppReferenceArray_1_RoutePoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BaseRouteBuilder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BaseRouteBuilder()
	{
		Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "BaseRouteBuilder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr);
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, "Instance");
		NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666225);
		NativeMethodInfoPtr_OnDestroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666226);
		NativeMethodInfoPtr_CreateRoute_Public_Virtual_New_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666227);
		NativeMethodInfoPtr_CreateRoute2_Public_Virtual_New_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666228);
		NativeMethodInfoPtr_CalcNearestPointByStep_Protected_RoutePoint_RoutePoint_Il2CppReferenceArray_1_RoutePoint_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666229);
		NativeMethodInfoPtr_CalcNearPointIndex_Protected_Int32_GameObject_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666230);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseRouteBuilder>.NativeClassPtr, 100666231);
	}

	public BaseRouteBuilder(IntPtr pointer)
		: base(pointer)
	{
	}
}
