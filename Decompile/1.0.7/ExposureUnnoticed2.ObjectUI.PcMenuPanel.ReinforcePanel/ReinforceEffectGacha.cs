using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.ReinforceEffect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel;

public class ReinforceEffectGacha : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_positiveList;

	private static readonly System.IntPtr NativeFieldInfoPtr_negativeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_tmpList;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChooseEffect_Public_Il2CppReferenceArray_1_RReinforceEffect_Int32_0;

	public unsafe List<RReinforceEffect> positiveList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positiveList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RReinforceEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positiveList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<RReinforceEffect> negativeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_negativeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RReinforceEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_negativeList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<RReinforceEffect> tmpList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RReinforceEffect>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85546, RefRangeEnd = 85547, XrefRangeStart = 85516, XrefRangeEnd = 85546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReinforceEffectGacha()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 85574, RefRangeEnd = 85575, XrefRangeStart = 85547, XrefRangeEnd = 85574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<RReinforceEffect> ChooseEffect([DefaultParameterValue(null)] int rank)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rank);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChooseEffect_Public_Il2CppReferenceArray_1_RReinforceEffect_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RReinforceEffect>>(intPtr) : null;
	}

	static ReinforceEffectGacha()
	{
		Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.PcMenuPanel.ReinforcePanel", "ReinforceEffectGacha");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr);
		NativeFieldInfoPtr_positiveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr, "positiveList");
		NativeFieldInfoPtr_negativeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr, "negativeList");
		NativeFieldInfoPtr_tmpList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr, "tmpList");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr, 100669582);
		NativeMethodInfoPtr_ChooseEffect_Public_Il2CppReferenceArray_1_RReinforceEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReinforceEffectGacha>.NativeClassPtr, 100669583);
	}

	public ReinforceEffectGacha(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
