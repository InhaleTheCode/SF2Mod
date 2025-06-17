using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace ExposureUnnoticed2.Scripts.Mission;

public class MissionStopElevatorNaked : MissionBase
{
	private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__IsJustOpenElevatorEntranceFloor_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_additionalDisplayTime;

	private static readonly IntPtr NativeFieldInfoPtr_achievedCount;

	private static readonly IntPtr NativeFieldInfoPtr_isArrivedFloor;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MissionStopElevatorNaked_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MissionStopElevatorNaked_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsJustOpenElevatorEntranceFloor_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsJustOpenElevatorEntranceFloor_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_MMissionOverrideRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static MissionStopElevatorNaked _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MissionStopElevatorNaked>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _IsJustOpenElevatorEntranceFloor_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsJustOpenElevatorEntranceFloor_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsJustOpenElevatorEntranceFloor_k__BackingField)) = num;
		}
	}

	public unsafe float additionalDisplayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalDisplayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_additionalDisplayTime)) = num;
		}
	}

	public unsafe int achievedCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievedCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievedCount)) = num;
		}
	}

	public unsafe Il2CppStructArray<bool> isArrivedFloor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isArrivedFloor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isArrivedFloor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static MissionStopElevatorNaked Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71685, XrefRangeEnd = 71687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MissionStopElevatorNaked_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MissionStopElevatorNaked>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71687, XrefRangeEnd = 71690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MissionStopElevatorNaked_0, (IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe int IsJustOpenElevatorEntranceFloor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsJustOpenElevatorEntranceFloor_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsJustOpenElevatorEntranceFloor_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71690, XrefRangeEnd = 71697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Initialize([DefaultParameterValue(null)] MMissionOverrideRecord record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Virtual_Void_MMissionOverrideRecord_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71697, XrefRangeEnd = 71700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71700, XrefRangeEnd = 71754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsInCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71754, XrefRangeEnd = 71761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float GetAddSatisfy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71761, XrefRangeEnd = 71763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe MissionStopElevatorNaked()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionStopElevatorNaked()
	{
		Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Mission", "MissionStopElevatorNaked");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr);
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr__IsJustOpenElevatorEntranceFloor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, "<IsJustOpenElevatorEntranceFloor>k__BackingField");
		NativeFieldInfoPtr_additionalDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, "additionalDisplayTime");
		NativeFieldInfoPtr_achievedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, "achievedCount");
		NativeFieldInfoPtr_isArrivedFloor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, "isArrivedFloor");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MissionStopElevatorNaked_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668525);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_MissionStopElevatorNaked_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668526);
		NativeMethodInfoPtr_get_IsJustOpenElevatorEntranceFloor_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668527);
		NativeMethodInfoPtr_set_IsJustOpenElevatorEntranceFloor_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668528);
		NativeMethodInfoPtr_Initialize_Public_Virtual_Void_MMissionOverrideRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668529);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668530);
		NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668531);
		NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668532);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668533);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionStopElevatorNaked>.NativeClassPtr, 100668534);
	}

	public MissionStopElevatorNaked(IntPtr pointer)
		: base(pointer)
	{
	}
}
