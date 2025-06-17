using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Costume;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.ObjectUI.InventoryPanel;

public class LoadoutData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayPartsList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostumeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CosplayPartsOptionDataDict;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<int> CosplayPartsList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<CostumeType> CostumeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<CostumeType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CostumeList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<int, CosplayPartsOptionData> CosplayPartsOptionDataDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsOptionDataDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, CosplayPartsOptionData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CosplayPartsOptionDataDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 89537, RefRangeEnd = 89540, XrefRangeStart = 89519, XrefRangeEnd = 89537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadoutData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LoadoutData()
	{
		Il2CppClassPointerStore<LoadoutData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InventoryPanel", "LoadoutData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr);
		NativeFieldInfoPtr_CosplayPartsList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr, "CosplayPartsList");
		NativeFieldInfoPtr_CostumeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr, "CostumeList");
		NativeFieldInfoPtr_CosplayPartsOptionDataDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr, "CosplayPartsOptionDataDict");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutData>.NativeClassPtr, 100669866);
	}

	public LoadoutData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
