using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.Object3D.Player.Scripts.Other;
using ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.BuffPanel;

public class BuffPanelItemView : MonoBehaviour
{
	public enum BuffType
	{
		RpBonus,
		Strange,
		Dokidoki,
		Stamina,
		EcstasyGauge,
		MissionGauge,
		SlowGauge,
		SkillCoolTime,
		GameOverPenaltyRp,
		GameOverPenaltyRank,
		MentalDecreaseScale,
		DashSpeed,
		StaminaRegenerate,
		RpBonusReinforce,
		ReduceFootStepSound,
		UnlockSpeed
	}

	private static readonly IntPtr NativeFieldInfoPtr_sourceName;

	private static readonly IntPtr NativeFieldInfoPtr_effectAmount;

	private static readonly IntPtr NativeFieldInfoPtr_iconView;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_BuffModel_BuffType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_BuffType_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe TextMeshProUGUI sourceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceName);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sourceName), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TextMeshProUGUI effectAmount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectAmount);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_effectAmount), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 101584, RefRangeEnd = 101587, XrefRangeStart = 101514, XrefRangeEnd = 101584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] BuffModel model, [DefaultParameterValue(null)] BuffType buffType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
		*(BuffType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &buffType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_BuffModel_BuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 101664, RefRangeEnd = 101680, XrefRangeStart = 101587, XrefRangeEnd = 101664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] int amount, [DefaultParameterValue(null)] BuffType buffType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&amount);
		*(BuffType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &buffType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_Int32_BuffType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 101736, RefRangeEnd = 101737, XrefRangeStart = 101680, XrefRangeEnd = 101736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	public unsafe BuffPanelItemView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BuffPanelItemView()
	{
		Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.BuffPanel", "BuffPanelItemView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr);
		NativeFieldInfoPtr_sourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, "sourceName");
		NativeFieldInfoPtr_effectAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, "effectAmount");
		NativeFieldInfoPtr_iconView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, "iconView");
		NativeMethodInfoPtr_Initialize_Public_Void_BuffModel_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, 100670750);
		NativeMethodInfoPtr_Initialize_Public_Void_Int32_BuffType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, 100670751);
		NativeMethodInfoPtr_Initialize_Public_Void_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, 100670752);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffPanelItemView>.NativeClassPtr, 100670753);
	}

	public BuffPanelItemView(IntPtr pointer)
		: base(pointer)
	{
	}
}
