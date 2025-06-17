using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.CosplayPartsOptionApplyer;

public class OptionApplyerCommonOnlyFarColor : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_cosplayType;

	private static readonly IntPtr NativeFieldInfoPtr_partsId;

	private static readonly IntPtr NativeFieldInfoPtr_targetMaterialIndexs;

	private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_uniqueId;

	private static readonly IntPtr NativeFieldInfoPtr_mats;

	private static readonly IntPtr NativeFieldInfoPtr_BaseColor;

	private static readonly IntPtr NativeFieldInfoPtr_FirstShadeColor;

	private static readonly IntPtr NativeFieldInfoPtr_Color1;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe CosplayType cosplayType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cosplayType);
			return *(CosplayType*)num;
		}
		set
		{
			*(CosplayType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cosplayType)) = cosplayType;
		}
	}

	public unsafe int partsId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsId)) = num;
		}
	}

	public unsafe Il2CppStructArray<int> targetMaterialIndexs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMaterialIndexs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMaterialIndexs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SkinnedMeshRenderer meshRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int uniqueId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Material> mats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mats);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mats), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int BaseColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseColor, &num);
		}
	}

	public unsafe static int FirstShadeColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FirstShadeColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FirstShadeColor, &num);
		}
	}

	public unsafe static int Color1
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Color1, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Color1, &num);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58732, XrefRangeEnd = 58764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58764, XrefRangeEnd = 58776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 58776, XrefRangeEnd = 58777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeEvent([DefaultParameterValue(null)] ChangeCosplayPartsOptionEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 58791, RefRangeEnd = 58792, XrefRangeStart = 58777, XrefRangeEnd = 58791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyFromGameState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OptionApplyerCommonOnlyFarColor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OptionApplyerCommonOnlyFarColor()
	{
		Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.CosplayPartsOptionApplyer", "OptionApplyerCommonOnlyFarColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr);
		NativeFieldInfoPtr_cosplayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "cosplayType");
		NativeFieldInfoPtr_partsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "partsId");
		NativeFieldInfoPtr_targetMaterialIndexs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "targetMaterialIndexs");
		NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "meshRenderer");
		NativeFieldInfoPtr_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "uniqueId");
		NativeFieldInfoPtr_mats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "mats");
		NativeFieldInfoPtr_BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "BaseColor");
		NativeFieldInfoPtr_FirstShadeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "FirstShadeColor");
		NativeFieldInfoPtr_Color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, "Color1");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, 100667174);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, 100667175);
		NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, 100667176);
		NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, 100667177);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerCommonOnlyFarColor>.NativeClassPtr, 100667178);
	}

	public OptionApplyerCommonOnlyFarColor(IntPtr pointer)
		: base(pointer)
	{
	}
}
