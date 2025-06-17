using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Scripts.UI;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.ObjectUI.ClosetMenu;
using ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu;
using ExposureUnnoticed2.ObjectUI.CommonUI.CommonTab;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.BarberMenu;

public class ClosetMenuView : BasePanelView
{
	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeFieldInfoPtr__IsDisplayCostume_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_itemPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_hairItemParent;

	private static readonly IntPtr NativeFieldInfoPtr_clothesView;

	private static readonly IntPtr NativeFieldInfoPtr_customizeView;

	private static readonly IntPtr NativeFieldInfoPtr_commonTabView;

	private static readonly IntPtr NativeFieldInfoPtr_itemViewList;

	private static readonly IntPtr NativeFieldInfoPtr_isInitDisplayClothes;

	private static readonly IntPtr NativeFieldInfoPtr_isInitDisplayBra;

	private static readonly IntPtr NativeFieldInfoPtr_isInitDisplayPants;

	private static readonly IntPtr NativeFieldInfoPtr_isInitDisplayCostume;

	private static readonly IntPtr NativeFieldInfoPtr_initRotateRemainFlame;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsDisplayCostume_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsDisplayCostume_Private_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshClothesView_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClickItem_Private_Void_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClickNakedItem_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClickCategory_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClickCostumeDisplay_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RefreshEquipment_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnClickBack_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnClickBack_b__24_0_Private_Void_0;

	public unsafe static ClosetMenuView Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ClosetMenuView>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _IsDisplayCostume_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDisplayCostume_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDisplayCostume_k__BackingField)) = flag;
		}
	}

	public unsafe GameObject itemPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform hairItemParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairItemParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairItemParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject clothesView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CustomizeMenuView customizeView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customizeView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CustomizeMenuView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_customizeView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CommonTabView commonTabView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonTabView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CommonTabView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_commonTabView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<ClosetMenuItemView> itemViewList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemViewList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<ClosetMenuItemView>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemViewList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isInitDisplayClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayClothes);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayClothes)) = flag;
		}
	}

	public unsafe bool isInitDisplayBra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayBra);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayBra)) = flag;
		}
	}

	public unsafe bool isInitDisplayPants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayPants);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayPants)) = flag;
		}
	}

	public unsafe bool isInitDisplayCostume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayCostume);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitDisplayCostume)) = flag;
		}
	}

	public unsafe int initRotateRemainFlame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initRotateRemainFlame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initRotateRemainFlame)) = num;
		}
	}

	public unsafe bool IsDisplayCostume
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDisplayCostume_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsDisplayCostume_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98157, RefRangeEnd = 98159, XrefRangeStart = 98059, XrefRangeEnd = 98157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 98170, RefRangeEnd = 98173, XrefRangeStart = 98159, XrefRangeEnd = 98170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshClothesView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshClothesView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98173, XrefRangeEnd = 98205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickItem([DefaultParameterValue(null)] MClothesRecord record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickItem_Private_Void_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98205, XrefRangeEnd = 98219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickNakedItem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickNakedItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98219, XrefRangeEnd = 98260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 98266, RefRangeEnd = 98267, XrefRangeStart = 98260, XrefRangeEnd = 98266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickCategory([DefaultParameterValue(null)] int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98267, XrefRangeEnd = 98268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickCostumeDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickCostumeDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 98283, RefRangeEnd = 98285, XrefRangeStart = 98268, XrefRangeEnd = 98283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshEquipment()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshEquipment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98285, XrefRangeEnd = 98296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickBack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickBack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98296, XrefRangeEnd = 98307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Open()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98307, XrefRangeEnd = 98319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClosetMenuView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98319, XrefRangeEnd = 98349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnClickBack_b__24_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnClickBack_b__24_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ClosetMenuView()
	{
		Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.BarberMenu", "ClosetMenuView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr);
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr__IsDisplayCostume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "<IsDisplayCostume>k__BackingField");
		NativeFieldInfoPtr_itemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "itemPrefab");
		NativeFieldInfoPtr_hairItemParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "hairItemParent");
		NativeFieldInfoPtr_clothesView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "clothesView");
		NativeFieldInfoPtr_customizeView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "customizeView");
		NativeFieldInfoPtr_commonTabView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "commonTabView");
		NativeFieldInfoPtr_itemViewList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "itemViewList");
		NativeFieldInfoPtr_isInitDisplayClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "isInitDisplayClothes");
		NativeFieldInfoPtr_isInitDisplayBra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "isInitDisplayBra");
		NativeFieldInfoPtr_isInitDisplayPants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "isInitDisplayPants");
		NativeFieldInfoPtr_isInitDisplayCostume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "isInitDisplayCostume");
		NativeFieldInfoPtr_initRotateRemainFlame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, "initRotateRemainFlame");
		NativeMethodInfoPtr_get_IsDisplayCostume_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670501);
		NativeMethodInfoPtr_set_IsDisplayCostume_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670502);
		NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670503);
		NativeMethodInfoPtr_RefreshClothesView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670504);
		NativeMethodInfoPtr_OnClickItem_Private_Void_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670505);
		NativeMethodInfoPtr_OnClickNakedItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670506);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670507);
		NativeMethodInfoPtr_OnClickCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670508);
		NativeMethodInfoPtr_OnClickCostumeDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670509);
		NativeMethodInfoPtr_RefreshEquipment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670510);
		NativeMethodInfoPtr_OnClickBack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670511);
		NativeMethodInfoPtr_Open_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670512);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670513);
		NativeMethodInfoPtr__OnClickBack_b__24_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClosetMenuView>.NativeClassPtr, 100670514);
	}

	public ClosetMenuView(IntPtr pointer)
		: base(pointer)
	{
	}
}
