using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Mission;

public class MMissionRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly IntPtr NativeFieldInfoPtr_MissionClassName;

	private static readonly IntPtr NativeFieldInfoPtr_MissionType;

	private static readonly IntPtr NativeFieldInfoPtr_IsOverrideAddSatisfy;

	private static readonly IntPtr NativeFieldInfoPtr_IsHideEyeMask;

	private static readonly IntPtr NativeFieldInfoPtr_IsHideDroneMission;

	private static readonly IntPtr NativeFieldInfoPtr_IsShowInSightVisibleNpc;

	private static readonly IntPtr NativeFieldInfoPtr_IsShowInSightVisibleRiseStrangenessNpc;

	private static readonly IntPtr NativeFieldInfoPtr_ExposedBodyPartsParam;

	private static readonly IntPtr NativeFieldInfoPtr_CategoryType;

	private static readonly IntPtr NativeFieldInfoPtr_IsAfterPerSec;

	private static readonly IntPtr NativeFieldInfoPtr_RpPerSecScale;

	private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string NameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string MissionClassName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionClassName);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionClassName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe MissionType MissionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionType);
			return *(MissionType*)num;
		}
		set
		{
			*(MissionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionType)) = missionType;
		}
	}

	public unsafe bool IsOverrideAddSatisfy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOverrideAddSatisfy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsOverrideAddSatisfy)) = flag;
		}
	}

	public unsafe bool IsHideEyeMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideEyeMask);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideEyeMask)) = flag;
		}
	}

	public unsafe bool IsHideDroneMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideDroneMission);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsHideDroneMission)) = flag;
		}
	}

	public unsafe bool IsShowInSightVisibleNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowInSightVisibleNpc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowInSightVisibleNpc)) = flag;
		}
	}

	public unsafe bool IsShowInSightVisibleRiseStrangenessNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowInSightVisibleRiseStrangenessNpc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsShowInSightVisibleRiseStrangenessNpc)) = flag;
		}
	}

	public unsafe ExposedBodyParts ExposedBodyPartsParam
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedBodyPartsParam);
			return *(ExposedBodyParts*)num;
		}
		set
		{
			*(ExposedBodyParts*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposedBodyPartsParam)) = exposedBodyParts;
		}
	}

	public unsafe MissionCategoryType CategoryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType);
			return *(MissionCategoryType*)num;
		}
		set
		{
			*(MissionCategoryType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType)) = missionCategoryType;
		}
	}

	public unsafe bool IsAfterPerSec
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAfterPerSec);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsAfterPerSec)) = flag;
		}
	}

	public unsafe float RpPerSecScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpPerSecScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpPerSecScale)) = num;
		}
	}

	public unsafe int _Id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField)) = num;
		}
	}

	public unsafe int Id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68134, XrefRangeEnd = 68135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MMissionRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MMissionRecord()
	{
		Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Mission", "MMissionRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr);
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_MissionClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "MissionClassName");
		NativeFieldInfoPtr_MissionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "MissionType");
		NativeFieldInfoPtr_IsOverrideAddSatisfy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsOverrideAddSatisfy");
		NativeFieldInfoPtr_IsHideEyeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsHideEyeMask");
		NativeFieldInfoPtr_IsHideDroneMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsHideDroneMission");
		NativeFieldInfoPtr_IsShowInSightVisibleNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsShowInSightVisibleNpc");
		NativeFieldInfoPtr_IsShowInSightVisibleRiseStrangenessNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsShowInSightVisibleRiseStrangenessNpc");
		NativeFieldInfoPtr_ExposedBodyPartsParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "ExposedBodyPartsParam");
		NativeFieldInfoPtr_CategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "CategoryType");
		NativeFieldInfoPtr_IsAfterPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "IsAfterPerSec");
		NativeFieldInfoPtr_RpPerSecScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "RpPerSecScale");
		NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, "<Id>k__BackingField");
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, 100668007);
		NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, 100668008);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MMissionRecord>.NativeClassPtr, 100668009);
	}

	public MMissionRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
