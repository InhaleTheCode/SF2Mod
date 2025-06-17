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

public class CoatController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_coatMesh;

	private static readonly IntPtr NativeFieldInfoPtr_pca;

	private static readonly IntPtr NativeFieldInfoPtr_coatMainBlend;

	private static readonly IntPtr NativeFieldInfoPtr_coatSubBlend;

	private static readonly IntPtr NativeFieldInfoPtr_coatBigBreastBlendScale;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_PlayerClassAccessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAStateToBlend_Private_Single_ClothesState_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Virtual_Final_New_Void_ClothesState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Public_Virtual_Final_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrevState_Public_Virtual_Final_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Virtual_Final_New_Boolean_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SkinnedMeshRenderer coatMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe SmoothFloat coatMainBlend
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMainBlend);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatMainBlend), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe SmoothFloat coatBigBreastBlendScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatBigBreastBlendScale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_coatBigBreastBlendScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59451, XrefRangeEnd = 59454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59454, XrefRangeEnd = 59528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 59528, RefRangeEnd = 59530, XrefRangeStart = 59528, XrefRangeEnd = 59528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59530, XrefRangeEnd = 59536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59536, XrefRangeEnd = 59537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59537, XrefRangeEnd = 59543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ExposedBodyParts GetExposedBodyParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ExposedBodyParts*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59543, XrefRangeEnd = 59545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59545, XrefRangeEnd = 59547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59547, XrefRangeEnd = 59566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59566, XrefRangeEnd = 59579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CoatController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoatController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CoatController()
	{
		Il2CppClassPointerStore<CoatController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Clothes", "CoatController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoatController>.NativeClassPtr);
		NativeFieldInfoPtr_coatMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoatController>.NativeClassPtr, "coatMesh");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoatController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_coatMainBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoatController>.NativeClassPtr, "coatMainBlend");
		NativeFieldInfoPtr_coatSubBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoatController>.NativeClassPtr, "coatSubBlend");
		NativeFieldInfoPtr_coatBigBreastBlendScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoatController>.NativeClassPtr, "coatBigBreastBlendScale");
		NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667233);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667234);
		NativeMethodInfoPtr_TransAStateToBlend_Private_Single_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667235);
		NativeMethodInfoPtr_OnPick_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667236);
		NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Virtual_Final_New_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667237);
		NativeMethodInfoPtr_GetExposedBodyParts_Public_Virtual_Final_New_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667238);
		NativeMethodInfoPtr_GetNextState_Public_Virtual_Final_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667239);
		NativeMethodInfoPtr_GetPrevState_Public_Virtual_Final_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667240);
		NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Virtual_Final_New_Boolean_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667241);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoatController>.NativeClassPtr, 100667242);
	}

	public CoatController(IntPtr pointer)
		: base(pointer)
	{
	}
}
