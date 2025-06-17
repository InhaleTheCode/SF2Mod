using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.RoutePoint;

public class RouteBuilderConbini : BaseRouteBuilder
{
	private static readonly IntPtr NativeFieldInfoPtr_conbiniShinadashiParent;

	private static readonly IntPtr NativeFieldInfoPtr_productPickParent;

	private static readonly IntPtr NativeFieldInfoPtr_appearPoint;

	private static readonly IntPtr NativeFieldInfoPtr_regiCustomerPoint;

	private static readonly IntPtr NativeFieldInfoPtr_regiCustomerJizenPoint;

	private static readonly IntPtr NativeFieldInfoPtr_conbiniShinadashiList;

	private static readonly IntPtr NativeFieldInfoPtr_productPickList;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateRoute2_Public_Virtual_RouteData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject conbiniShinadashiParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniShinadashiParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniShinadashiParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject productPickParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productPickParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productPickParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe RoutePoint regiCustomerPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiCustomerPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiCustomerPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RoutePoint regiCustomerJizenPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiCustomerJizenPoint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RoutePoint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_regiCustomerJizenPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> conbiniShinadashiList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniShinadashiList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniShinadashiList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RoutePoint> productPickList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productPickList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RoutePoint>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_productPickList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46814, XrefRangeEnd = 46823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46823, XrefRangeEnd = 46861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46861, XrefRangeEnd = 46879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46879, XrefRangeEnd = 46890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InsertPick([DefaultParameterValue(null)] RouteData rd)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rd);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46890, XrefRangeEnd = 46905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RouteBuilderConbini()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RouteBuilderConbini()
	{
		Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RouteBuilderConbini");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr);
		NativeFieldInfoPtr_conbiniShinadashiParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "conbiniShinadashiParent");
		NativeFieldInfoPtr_productPickParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "productPickParent");
		NativeFieldInfoPtr_appearPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "appearPoint");
		NativeFieldInfoPtr_regiCustomerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "regiCustomerPoint");
		NativeFieldInfoPtr_regiCustomerJizenPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "regiCustomerJizenPoint");
		NativeFieldInfoPtr_conbiniShinadashiList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "conbiniShinadashiList");
		NativeFieldInfoPtr_productPickList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, "productPickList");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666242);
		NativeMethodInfoPtr_CalcPathRight_Private_Void_Il2CppReferenceArray_1_RoutePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666243);
		NativeMethodInfoPtr_CreateRoute_Public_Virtual_RouteData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666244);
		NativeMethodInfoPtr_InsertPick_Private_Void_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666245);
		NativeMethodInfoPtr_CreateRoute2_Public_Virtual_RouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666246);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteBuilderConbini>.NativeClassPtr, 100666247);
	}

	public RouteBuilderConbini(IntPtr pointer)
		: base(pointer)
	{
	}
}
