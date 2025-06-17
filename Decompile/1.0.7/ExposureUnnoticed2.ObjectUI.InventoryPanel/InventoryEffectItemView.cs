using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.InventoryPanel;

public class InventoryEffectItemView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_name;

	private static readonly IntPtr NativeFieldInfoPtr_amount;

	private static readonly IntPtr NativeFieldInfoPtr_iconView;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public new unsafe TextMeshProUGUI name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI amount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_amount), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ReinforceEffectRankIconView iconView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReinforceEffectRankIconView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_iconView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 88714, RefRangeEnd = 88718, XrefRangeStart = 88712, XrefRangeEnd = 88714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] string name, [DefaultParameterValue(null)] string amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(amount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 88728, RefRangeEnd = 88729, XrefRangeStart = 88718, XrefRangeEnd = 88728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] RReinforceEffect record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InventoryEffectItemView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InventoryEffectItemView()
	{
		Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InventoryPanel", "InventoryEffectItemView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, "name");
		NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, "amount");
		NativeFieldInfoPtr_iconView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, "iconView");
		NativeMethodInfoPtr_Initialize_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, 100669805);
		NativeMethodInfoPtr_Initialize_Public_Void_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, 100669806);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryEffectItemView>.NativeClassPtr, 100669807);
	}

	public InventoryEffectItemView(IntPtr pointer)
		: base(pointer)
	{
	}
}
