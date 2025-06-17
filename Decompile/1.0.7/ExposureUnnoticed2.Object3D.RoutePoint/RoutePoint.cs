using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.RoutePoint;

public class RoutePoint : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RouteInteractType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__LinkTokenPublisher_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Floor_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__EscalatorTarget_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__MaxPathRightScale_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Param_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__PathRight_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_RoutePointType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Type_Private_set_Void_RoutePointType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RouteInteractType_Public_get_RouteInteractType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RouteInteractType_Private_set_Void_RouteInteractType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LinkTokenPublisher_Public_get_BaseInteractTokenPublisher_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_LinkTokenPublisher_Private_set_Void_BaseInteractTokenPublisher_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Floor_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Floor_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_EscalatorTarget_Public_get_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EscalatorTarget_Private_set_Void_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MaxPathRightScale_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MaxPathRightScale_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Param_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Param_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PathRight_Public_get_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_PathRight_Public_set_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RoutePointType _Type_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField);
			return *(RoutePointType*)num;
		}
		set
		{
			*(RoutePointType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Type_k__BackingField)) = routePointType;
		}
	}

	public unsafe RouteInteractType _RouteInteractType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RouteInteractType_k__BackingField);
			return *(RouteInteractType*)num;
		}
		set
		{
			*(RouteInteractType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RouteInteractType_k__BackingField)) = routeInteractType;
		}
	}

	public unsafe BaseInteractTokenPublisher _LinkTokenPublisher_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LinkTokenPublisher_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseInteractTokenPublisher>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LinkTokenPublisher_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _Floor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Floor_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Floor_k__BackingField)) = num;
		}
	}

	public unsafe Transform _EscalatorTarget_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EscalatorTarget_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EscalatorTarget_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float _MaxPathRightScale_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxPathRightScale_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxPathRightScale_k__BackingField)) = num;
		}
	}

	public unsafe int _Param_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Param_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Param_k__BackingField)) = num;
		}
	}

	public unsafe Vector3 _PathRight_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PathRight_k__BackingField);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__PathRight_k__BackingField)) = vector;
		}
	}

	public unsafe RoutePointType Type
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48521, RefRangeEnd = 48522, XrefRangeStart = 48521, XrefRangeEnd = 48521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Type_Public_get_RoutePointType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(RoutePointType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Type_Private_set_Void_RoutePointType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RouteInteractType RouteInteractType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RouteInteractType_Public_get_RouteInteractType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(RouteInteractType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RouteInteractType_Private_set_Void_RouteInteractType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe BaseInteractTokenPublisher LinkTokenPublisher
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LinkTokenPublisher_Public_get_BaseInteractTokenPublisher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseInteractTokenPublisher>(intPtr) : null;
		}
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 32970, RefRangeEnd = 33003, XrefRangeStart = 32970, XrefRangeEnd = 33003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LinkTokenPublisher_Private_set_Void_BaseInteractTokenPublisher_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int Floor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Floor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Floor_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Transform EscalatorTarget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EscalatorTarget_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41569, RefRangeEnd = 41574, XrefRangeStart = 41569, XrefRangeEnd = 41574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EscalatorTarget_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float MaxPathRightScale
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxPathRightScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxPathRightScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int Param
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Param_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Param_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Vector3 Position
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 48526, RefRangeEnd = 48529, XrefRangeStart = 48522, XrefRangeEnd = 48526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Vector3 PathRight
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PathRight_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_PathRight_Public_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48529, XrefRangeEnd = 48532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RoutePoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RoutePoint()
	{
		Il2CppClassPointerStore<RoutePoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.RoutePoint", "RoutePoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr);
		NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<Type>k__BackingField");
		NativeFieldInfoPtr__RouteInteractType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<RouteInteractType>k__BackingField");
		NativeFieldInfoPtr__LinkTokenPublisher_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<LinkTokenPublisher>k__BackingField");
		NativeFieldInfoPtr__Floor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<Floor>k__BackingField");
		NativeFieldInfoPtr__EscalatorTarget_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<EscalatorTarget>k__BackingField");
		NativeFieldInfoPtr__MaxPathRightScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<MaxPathRightScale>k__BackingField");
		NativeFieldInfoPtr__Param_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<Param>k__BackingField");
		NativeFieldInfoPtr__PathRight_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, "<PathRight>k__BackingField");
		NativeMethodInfoPtr_get_Type_Public_get_RoutePointType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666329);
		NativeMethodInfoPtr_set_Type_Private_set_Void_RoutePointType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666330);
		NativeMethodInfoPtr_get_RouteInteractType_Public_get_RouteInteractType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666331);
		NativeMethodInfoPtr_set_RouteInteractType_Private_set_Void_RouteInteractType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666332);
		NativeMethodInfoPtr_get_LinkTokenPublisher_Public_get_BaseInteractTokenPublisher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666333);
		NativeMethodInfoPtr_set_LinkTokenPublisher_Private_set_Void_BaseInteractTokenPublisher_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666334);
		NativeMethodInfoPtr_get_Floor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666335);
		NativeMethodInfoPtr_set_Floor_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666336);
		NativeMethodInfoPtr_get_EscalatorTarget_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666337);
		NativeMethodInfoPtr_set_EscalatorTarget_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666338);
		NativeMethodInfoPtr_get_MaxPathRightScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666339);
		NativeMethodInfoPtr_set_MaxPathRightScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666340);
		NativeMethodInfoPtr_get_Param_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666341);
		NativeMethodInfoPtr_set_Param_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666342);
		NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666343);
		NativeMethodInfoPtr_get_PathRight_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666344);
		NativeMethodInfoPtr_set_PathRight_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666345);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoutePoint>.NativeClassPtr, 100666346);
	}

	public RoutePoint(IntPtr pointer)
		: base(pointer)
	{
	}
}
