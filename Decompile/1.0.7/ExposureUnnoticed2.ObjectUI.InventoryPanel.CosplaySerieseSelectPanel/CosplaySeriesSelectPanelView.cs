using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Cosplay;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.InventoryPanel.CosplaySerieseSelectPanel;

public class CosplaySeriesSelectPanelView : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_seriesName;

	private static readonly System.IntPtr NativeFieldInfoPtr_chipParent;

	private static readonly System.IntPtr NativeFieldInfoPtr_chipPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr_changeSeries;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSeriesIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSeries;

	private static readonly System.IntPtr NativeFieldInfoPtr_chipList;

	private static readonly System.IntPtr NativeFieldInfoPtr_bringCosplaySeriesList;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshView_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickSeriesChange_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextMeshProUGUI seriesName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesName);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_seriesName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform chipParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipParent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject chipPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppSystem.Action<int> changeSeries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeSeries);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_changeSeries), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int currentSeriesIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSeriesIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSeriesIndex)) = num;
		}
	}

	public unsafe CosplayType currentSeries
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSeries);
			return *(CosplayType*)num;
		}
		set
		{
			*(CosplayType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSeries)) = cosplayType;
		}
	}

	public unsafe List<CosplaySeriesChipView> chipList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CosplaySeriesChipView>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chipList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CosplayType> bringCosplaySeriesList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bringCosplaySeriesList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CosplayType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bringCosplaySeriesList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 90432, RefRangeEnd = 90435, XrefRangeStart = 90371, XrefRangeEnd = 90432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] Il2CppSystem.Action<int> changeSeries)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(changeSeries);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 90452, RefRangeEnd = 90456, XrefRangeStart = 90435, XrefRangeEnd = 90452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90465, RefRangeEnd = 90467, XrefRangeStart = 90456, XrefRangeEnd = 90465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 90469, RefRangeEnd = 90471, XrefRangeStart = 90467, XrefRangeEnd = 90469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickSeriesChange([DefaultParameterValue(null)] int changeAmount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&changeAmount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickSeriesChange_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90471, XrefRangeEnd = 90486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CosplaySeriesSelectPanelView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CosplaySeriesSelectPanelView()
	{
		Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InventoryPanel.CosplaySerieseSelectPanel", "CosplaySeriesSelectPanelView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr);
		NativeFieldInfoPtr_seriesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "seriesName");
		NativeFieldInfoPtr_chipParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "chipParent");
		NativeFieldInfoPtr_chipPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "chipPrefab");
		NativeFieldInfoPtr_changeSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "changeSeries");
		NativeFieldInfoPtr_currentSeriesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "currentSeriesIndex");
		NativeFieldInfoPtr_currentSeries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "currentSeries");
		NativeFieldInfoPtr_chipList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "chipList");
		NativeFieldInfoPtr_bringCosplaySeriesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, "bringCosplaySeriesList");
		NativeMethodInfoPtr_Initialize_Public_Void_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, 100669923);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, 100669924);
		NativeMethodInfoPtr_RefreshView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, 100669925);
		NativeMethodInfoPtr_OnClickSeriesChange_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, 100669926);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplaySeriesSelectPanelView>.NativeClassPtr, 100669927);
	}

	public CosplaySeriesSelectPanelView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
