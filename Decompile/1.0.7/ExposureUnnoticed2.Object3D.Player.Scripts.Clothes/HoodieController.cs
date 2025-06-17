using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Clothes;

public class HoodieController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_clothesMesh;

	private static readonly IntPtr NativeFieldInfoPtr_pca;

	private static readonly IntPtr NativeFieldInfoPtr_clothesMainBlend;

	private static readonly IntPtr NativeFieldInfoPtr_coatSubBlend;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_PlayerClassAccessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAStateToBlend_Private_Single_ClothesState_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Virtual_Final_New_Void_ClothesState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Public_Virtual_Final_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrevState_Public_Virtual_Final_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Virtual_Final_New_Boolean_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SkinnedMeshRenderer clothesMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesMesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesMesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerClassAccessor pca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerClassAccessor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat clothesMainBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesMainBlend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clothesMainBlend), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat coatSubBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatSubBlend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatSubBlend), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59579, XrefRangeEnd = 59582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59582, XrefRangeEnd = 59624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59624, XrefRangeEnd = 59630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ExposedBodyParts GetExposedBodyParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ExposedBodyParts*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59631, RefRangeEnd = 59633, XrefRangeStart = 59630, XrefRangeEnd = 59631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float TransAStateToBlend([DefaultParameterValue(null)] PlayerStateModel.ClothesState aState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&aState);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransAStateToBlend_Private_Single_ClothesState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59633, XrefRangeEnd = 59640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59640, XrefRangeEnd = 59641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void ForceSetClothesStateBlend([DefaultParameterValue(null)] PlayerStateModel.ClothesState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Virtual_Final_New_Void_ClothesState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59641, XrefRangeEnd = 59643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayerStateModel.ClothesState GetNextState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNextState_Public_Virtual_Final_New_ClothesState_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59643, XrefRangeEnd = 59645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PlayerStateModel.ClothesState GetPrevState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrevState_Public_Virtual_Final_New_ClothesState_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59645, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool IsEnoughSkillLevel([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Virtual_Final_New_Boolean_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59663, XrefRangeEnd = 59673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HoodieController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HoodieController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HoodieController()
	{
		Il2CppClassPointerStore<HoodieController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Clothes", "HoodieController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HoodieController>.NativeClassPtr);
		NativeFieldInfoPtr_clothesMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, "clothesMesh");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_clothesMainBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, "clothesMainBlend");
		NativeFieldInfoPtr_coatSubBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, "coatSubBlend");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667243);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667244);
		NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667245);
		NativeMethodInfoPtr_TransAStateToBlend_Private_Single_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667246);
		NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667247);
		NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Virtual_Final_New_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667248);
		NativeMethodInfoPtr_GetNextState_Public_Virtual_Final_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667249);
		NativeMethodInfoPtr_GetPrevState_Public_Virtual_Final_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667250);
		NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Virtual_Final_New_Boolean_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667251);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HoodieController>.NativeClassPtr, 100667252);
	}

	public HoodieController(IntPtr pointer)
		: base(pointer)
	{
	}
}
