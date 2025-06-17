using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.CommonPopup;

public class CommonPopupButtonView : MonoBehaviour
{
	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeFieldInfoPtr__SeType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__OnClick_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SeType_Public_get_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_SeType_Public_set_Void_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OnClick_Public_get_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OnClick_Public_set_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateView_Public_Void_CommonButtonData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextMeshProUGUI text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameSoundManager.SeType _SeType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SeType_k__BackingField);
			return *(InGameSoundManager.SeType*)num;
		}
		set
		{
			*(InGameSoundManager.SeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SeType_k__BackingField)) = seType;
		}
	}

	public unsafe Il2CppSystem.Action _OnClick_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OnClick_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OnClick_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameSoundManager.SeType SeType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SeType_Public_get_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(InGameSoundManager.SeType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SeType_Public_set_Void_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppSystem.Action OnClick
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OnClick_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41561, RefRangeEnd = 41569, XrefRangeStart = 41561, XrefRangeEnd = 41569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OnClick_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 102787, RefRangeEnd = 102797, XrefRangeStart = 102787, XrefRangeEnd = 102787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateView([DefaultParameterValue(null)] CommonButtonData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateView_Public_Void_CommonButtonData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CommonPopupButtonView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CommonPopupButtonView()
	{
		Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.CommonPopup", "CommonPopupButtonView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr);
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, "text");
		NativeFieldInfoPtr__SeType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, "<SeType>k__BackingField");
		NativeFieldInfoPtr__OnClick_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, "<OnClick>k__BackingField");
		NativeMethodInfoPtr_get_SeType_Public_get_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670804);
		NativeMethodInfoPtr_set_SeType_Public_set_Void_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670805);
		NativeMethodInfoPtr_get_OnClick_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670806);
		NativeMethodInfoPtr_set_OnClick_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670807);
		NativeMethodInfoPtr_UpdateView_Public_Void_CommonButtonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670808);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonPopupButtonView>.NativeClassPtr, 100670809);
	}

	public CommonPopupButtonView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
