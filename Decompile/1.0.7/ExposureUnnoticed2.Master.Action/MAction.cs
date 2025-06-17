using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.ObjectUI.InGame.RingMenu;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Action;

public class MAction : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_SexActionBias;

	private static readonly IntPtr NativeFieldInfoPtr_actions;

	private static readonly IntPtr NativeFieldInfoPtr_dict;

	private static readonly IntPtr NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_MActionRecord_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUseDildoAction_Public_Static_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsUseDildoRiseEcstasyAction_Public_Static_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsSitAction_Public_Static_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransActionType_Public_Static_ActionType_RingItemType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsPoseSkill_Public_Static_Boolean_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int SexActionBias
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SexActionBias, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SexActionBias, &num);
		}
	}

	public unsafe Il2CppReferenceArray<MActionRecord> actions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MActionRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<ActionType, MActionRecord> dict
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_dict, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ActionType, MActionRecord>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_dict, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 69027, RefRangeEnd = 69028, XrefRangeStart = 69010, XrefRangeEnd = 69027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckInitialize()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 69034, RefRangeEnd = 69042, XrefRangeStart = 69028, XrefRangeEnd = 69034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MActionRecord Get([DefaultParameterValue(null)] ActionType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_Static_MActionRecord_ActionType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MActionRecord>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsUseDildoAction([DefaultParameterValue(null)] ActionType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUseDildoAction_Public_Static_Boolean_ActionType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsUseDildoRiseEcstasyAction([DefaultParameterValue(null)] ActionType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsUseDildoRiseEcstasyAction_Public_Static_Boolean_ActionType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsSitAction([DefaultParameterValue(null)] ActionType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSitAction_Public_Static_Boolean_ActionType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69042, XrefRangeEnd = 69043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ActionType TransActionType([DefaultParameterValue(null)] RingMenuParentView.RingItemType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransActionType_Public_Static_ActionType_RingItemType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool IsPoseSkill([DefaultParameterValue(null)] ActionType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPoseSkill_Public_Static_Boolean_ActionType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MAction>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MAction()
	{
		Il2CppClassPointerStore<MAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Action", "MAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MAction>.NativeClassPtr);
		NativeFieldInfoPtr_SexActionBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAction>.NativeClassPtr, "SexActionBias");
		NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAction>.NativeClassPtr, "actions");
		NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MAction>.NativeClassPtr, "dict");
		NativeMethodInfoPtr_CheckInitialize_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668269);
		NativeMethodInfoPtr_Get_Public_Static_MActionRecord_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668270);
		NativeMethodInfoPtr_IsUseDildoAction_Public_Static_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668271);
		NativeMethodInfoPtr_IsUseDildoRiseEcstasyAction_Public_Static_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668272);
		NativeMethodInfoPtr_IsSitAction_Public_Static_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668273);
		NativeMethodInfoPtr_TransActionType_Public_Static_ActionType_RingItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668274);
		NativeMethodInfoPtr_IsPoseSkill_Public_Static_Boolean_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668275);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MAction>.NativeClassPtr, 100668276);
	}

	public MAction(IntPtr pointer)
		: base(pointer)
	{
	}
}
