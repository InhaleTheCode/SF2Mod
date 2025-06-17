using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Ricimi;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.MissionMenuPanel;

public class MissionMenuItemView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_checkMarkObject;

	private static readonly IntPtr NativeFieldInfoPtr_firstTimeTextObject;

	private static readonly IntPtr NativeFieldInfoPtr_missionNameText;

	private static readonly IntPtr NativeFieldInfoPtr_hideMissionName;

	private static readonly IntPtr NativeFieldInfoPtr_rewardText;

	private static readonly IntPtr NativeFieldInfoPtr_achievementsText;

	private static readonly IntPtr NativeFieldInfoPtr_rankConditionMask;

	private static readonly IntPtr NativeFieldInfoPtr_clearMask;

	private static readonly IntPtr NativeFieldInfoPtr_rankConditionText;

	private static readonly IntPtr NativeFieldInfoPtr_maxRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_gradeImage;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MMissionOverrideRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject checkMarkObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkMarkObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_checkMarkObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI firstTimeTextObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTimeTextObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstTimeTextObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI missionNameText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNameText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_missionNameText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject hideMissionName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideMissionName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hideMissionName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI rewardText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rewardText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI achievementsText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievementsText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_achievementsText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject rankConditionMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankConditionMask);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankConditionMask), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject clearMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearMask);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clearMask), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI rankConditionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankConditionText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankConditionText), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Ricimi.Gradient gradeImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradeImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Ricimi.Gradient>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gradeImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 87441, RefRangeEnd = 87442, XrefRangeStart = 87377, XrefRangeEnd = 87441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] MMissionOverrideRecord mission)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mission);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_MMissionOverrideRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MissionMenuItemView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionMenuItemView()
	{
		Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.MissionMenuPanel", "MissionMenuItemView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr);
		NativeFieldInfoPtr_checkMarkObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "checkMarkObject");
		NativeFieldInfoPtr_firstTimeTextObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "firstTimeTextObject");
		NativeFieldInfoPtr_missionNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "missionNameText");
		NativeFieldInfoPtr_hideMissionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "hideMissionName");
		NativeFieldInfoPtr_rewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "rewardText");
		NativeFieldInfoPtr_achievementsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "achievementsText");
		NativeFieldInfoPtr_rankConditionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "rankConditionMask");
		NativeFieldInfoPtr_clearMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "clearMask");
		NativeFieldInfoPtr_rankConditionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "rankConditionText");
		NativeFieldInfoPtr_maxRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "maxRpBonus");
		NativeFieldInfoPtr_gradeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, "gradeImage");
		NativeMethodInfoPtr_Initialize_Public_Void_MMissionOverrideRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, 100669705);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionMenuItemView>.NativeClassPtr, 100669706);
	}

	public MissionMenuItemView(IntPtr pointer)
		: base(pointer)
	{
	}
}
