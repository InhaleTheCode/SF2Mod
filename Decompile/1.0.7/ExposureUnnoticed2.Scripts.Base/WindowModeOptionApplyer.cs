using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.Scripts.Base;

public class WindowModeOptionApplyer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_initialized;

	private static readonly System.IntPtr NativeFieldInfoPtr_ResolutionDataList;

	private static readonly System.IntPtr NativeFieldInfoPtr_WideResolutionDataList;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeIfNeed_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetResolutionList_Public_Static_List_1_ResolutionData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Apply_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool initialized
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_initialized, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_initialized, &flag);
		}
	}

	public unsafe static List<ResolutionData> ResolutionDataList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ResolutionDataList, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResolutionData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ResolutionDataList, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static List<ResolutionData> WideResolutionDataList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_WideResolutionDataList, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResolutionData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_WideResolutionDataList, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82695, RefRangeEnd = 82698, XrefRangeStart = 82647, XrefRangeEnd = 82695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeIfNeed()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeIfNeed_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82698, XrefRangeEnd = 82704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ResolutionData> GetTargetResolutionList()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTargetResolutionList_Public_Static_List_1_ResolutionData_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ResolutionData>>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 82726, RefRangeEnd = 82729, XrefRangeStart = 82704, XrefRangeEnd = 82726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Apply()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe WindowModeOptionApplyer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WindowModeOptionApplyer()
	{
		Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "WindowModeOptionApplyer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr);
		NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, "initialized");
		NativeFieldInfoPtr_ResolutionDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, "ResolutionDataList");
		NativeFieldInfoPtr_WideResolutionDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, "WideResolutionDataList");
		NativeMethodInfoPtr_InitializeIfNeed_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, 100669376);
		NativeMethodInfoPtr_GetTargetResolutionList_Public_Static_List_1_ResolutionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, 100669377);
		NativeMethodInfoPtr_Apply_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, 100669378);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowModeOptionApplyer>.NativeClassPtr, 100669379);
	}

	public WindowModeOptionApplyer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
