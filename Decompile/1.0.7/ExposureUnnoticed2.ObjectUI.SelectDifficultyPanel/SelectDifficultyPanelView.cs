using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Scripts.UI;
using HadakaCoat.ObjectsUi.Common.Button;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.SelectDifficultyPanel;

public class SelectDifficultyPanelView : BasePanelView
{
	private static readonly System.IntPtr NativeFieldInfoPtr_descriptionText;

	private static readonly System.IntPtr NativeFieldInfoPtr_decideButton;

	private static readonly System.IntPtr NativeFieldInfoPtr_buttonGroupManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelect;

	private static readonly System.IntPtr NativeFieldInfoPtr_isFromSystemMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_onCancel;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Action_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToPadModeIfNeed_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RefreshView_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickItem_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickDecide_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnClickCancel_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_Void_Transform_Action_Boolean_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextMeshProUGUI descriptionText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionText);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_descriptionText), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ButtonView decideButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decideButton);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonView>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_decideButton), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ButtonGroupManager buttonGroupManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonGroupManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ButtonGroupManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_buttonGroupManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DifficultType currentSelect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelect);
			return *(DifficultType*)num;
		}
		set
		{
			*(DifficultType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelect)) = difficultType;
		}
	}

	public unsafe bool isFromSystemMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFromSystemMenu);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFromSystemMenu)) = flag;
		}
	}

	public unsafe int currentSelectIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectIndex)) = num;
		}
	}

	public unsafe Il2CppSystem.Action onCancel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onCancel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84036, RefRangeEnd = 84037, XrefRangeStart = 84021, XrefRangeEnd = 84036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] bool isFromSystemMenu, [DefaultParameterValue(null)] Il2CppSystem.Action onClose, [DefaultParameterValue(null)] Il2CppSystem.Action onCancel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&isFromSystemMenu);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onClose);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84045, RefRangeEnd = 84047, XrefRangeStart = 84037, XrefRangeEnd = 84045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToPadModeIfNeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToPadModeIfNeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 84062, RefRangeEnd = 84064, XrefRangeStart = 84047, XrefRangeEnd = 84062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RefreshView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84064, XrefRangeEnd = 84065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickItem([DefaultParameterValue(null)] int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickItem_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 84090, RefRangeEnd = 84091, XrefRangeStart = 84065, XrefRangeEnd = 84090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickDecide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickDecide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84091, XrefRangeEnd = 84131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84131, XrefRangeEnd = 84136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnClickCancel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnClickCancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 84149, RefRangeEnd = 84152, XrefRangeStart = 84136, XrefRangeEnd = 84149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Open([DefaultParameterValue(null)] Transform parent, Il2CppSystem.Action onClose = null, bool isFromSystemMenu = false, Il2CppSystem.Action onCancel = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onClose);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFromSystemMenu;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onCancel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Open_Public_Static_Void_Transform_Action_Boolean_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84152, XrefRangeEnd = 84158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectDifficultyPanelView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SelectDifficultyPanelView()
	{
		Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.SelectDifficultyPanel", "SelectDifficultyPanelView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr);
		NativeFieldInfoPtr_descriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "descriptionText");
		NativeFieldInfoPtr_decideButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "decideButton");
		NativeFieldInfoPtr_buttonGroupManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "buttonGroupManager");
		NativeFieldInfoPtr_currentSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "currentSelect");
		NativeFieldInfoPtr_isFromSystemMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "isFromSystemMenu");
		NativeFieldInfoPtr_currentSelectIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "currentSelectIndex");
		NativeFieldInfoPtr_onCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, "onCancel");
		NativeMethodInfoPtr_Initialize_Private_Void_Boolean_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669477);
		NativeMethodInfoPtr_ToPadModeIfNeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669478);
		NativeMethodInfoPtr_RefreshView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669479);
		NativeMethodInfoPtr_OnClickItem_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669480);
		NativeMethodInfoPtr_OnClickDecide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669481);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669482);
		NativeMethodInfoPtr_OnClickCancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669483);
		NativeMethodInfoPtr_Open_Public_Static_Void_Transform_Action_Boolean_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669484);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectDifficultyPanelView>.NativeClassPtr, 100669485);
	}

	public SelectDifficultyPanelView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
