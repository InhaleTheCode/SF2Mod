using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.DroneMission;
using ExposureUnnoticed2.Master.Stage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.DroneMissionPanel;

public class DroneMissionRecordItemView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_stageName;

	private static readonly IntPtr NativeFieldInfoPtr_achieveCount;

	private static readonly IntPtr NativeFieldInfoPtr_maxRpBonus;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RDroneMission_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextMeshProUGUI stageName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stageName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stageName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI achieveCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achieveCount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achieveCount), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI maxRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpBonus);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxRpBonus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 95096, RefRangeEnd = 95097, XrefRangeStart = 95048, XrefRangeEnd = 95096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] RDroneMission mission, [DefaultParameterValue(null)] StageType stageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mission);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &stageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_RDroneMission_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DroneMissionRecordItemView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DroneMissionRecordItemView()
	{
		Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.DroneMissionPanel", "DroneMissionRecordItemView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr);
		NativeFieldInfoPtr_stageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr, "stageName");
		NativeFieldInfoPtr_achieveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr, "achieveCount");
		NativeFieldInfoPtr_maxRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr, "maxRpBonus");
		NativeMethodInfoPtr_Initialize_Public_Void_RDroneMission_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr, 100670253);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroneMissionRecordItemView>.NativeClassPtr, 100670254);
	}

	public DroneMissionRecordItemView(IntPtr pointer)
		: base(pointer)
	{
	}
}
