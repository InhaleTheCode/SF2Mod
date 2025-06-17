using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.ReinforceEffect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel;

public class ReinforceEffectRankIconView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_upIcons;

	private static readonly IntPtr NativeFieldInfoPtr_downIcons;

	private static readonly IntPtr NativeFieldInfoPtr_leftIcons;

	private static readonly IntPtr NativeFieldInfoPtr_rightIcons;

	private static readonly IntPtr NativeMethodInfoPtr_AllHide_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetView_Private_Void_Int32_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetView_Public_Void_RReinforceEffect_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<GameObject> upIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upIcons);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_upIcons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> downIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downIcons);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downIcons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> leftIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftIcons);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_leftIcons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> rightIcons
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightIcons);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rightIcons), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 85610, RefRangeEnd = 85616, XrefRangeStart = 85598, XrefRangeEnd = 85610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AllHide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllHide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85616, XrefRangeEnd = 85623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetView([DefaultParameterValue(null)] int rank, [DefaultParameterValue(null)] bool isNegative, [DefaultParameterValue(null)] bool isNeutral)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&rank);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &isNegative;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &isNeutral;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetView_Private_Void_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 85630, RefRangeEnd = 85633, XrefRangeStart = 85623, XrefRangeEnd = 85630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetView([DefaultParameterValue(null)] RReinforceEffect record)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(record);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetView_Public_Void_RReinforceEffect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReinforceEffectRankIconView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ReinforceEffectRankIconView()
	{
		Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel", "ReinforceEffectRankIconView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr);
		NativeFieldInfoPtr_upIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, "upIcons");
		NativeFieldInfoPtr_downIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, "downIcons");
		NativeFieldInfoPtr_leftIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, "leftIcons");
		NativeFieldInfoPtr_rightIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, "rightIcons");
		NativeMethodInfoPtr_AllHide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, 100669586);
		NativeMethodInfoPtr_SetView_Private_Void_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, 100669587);
		NativeMethodInfoPtr_SetView_Public_Void_RReinforceEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, 100669588);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectRankIconView>.NativeClassPtr, 100669589);
	}

	public ReinforceEffectRankIconView(IntPtr pointer)
		: base(pointer)
	{
	}
}
