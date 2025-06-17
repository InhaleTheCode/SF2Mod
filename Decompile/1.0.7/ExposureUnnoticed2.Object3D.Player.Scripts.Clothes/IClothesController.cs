using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Clothes;

public class IClothesController : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_PlayerClassAccessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPick_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Abstract_Virtual_New_Void_ClothesState_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetExposedBodyParts_Public_Abstract_Virtual_New_ExposedBodyParts_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetNextState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetPrevState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Abstract_Virtual_New_Boolean_CoatActionType_0;

	[CallerCount(0)]
	public unsafe virtual void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_PlayerClassAccessor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void OnPick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnPick_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual void ForceSetClothesStateBlend([DefaultParameterValue(null)] PlayerStateModel.ClothesState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&state);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Abstract_Virtual_New_Void_ClothesState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe virtual ExposedBodyParts GetExposedBodyParts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetExposedBodyParts_Public_Abstract_Virtual_New_ExposedBodyParts_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ExposedBodyParts*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe virtual PlayerStateModel.ClothesState GetNextState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetNextState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe virtual PlayerStateModel.ClothesState GetPrevState([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetPrevState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(PlayerStateModel.ClothesState*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe virtual bool IsEnoughSkillLevel([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Abstract_Virtual_New_Boolean_CoatActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IClothesController()
	{
		Il2CppClassPointerStore<IClothesController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Clothes", "IClothesController");
		NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667253);
		NativeMethodInfoPtr_OnUpdate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667254);
		NativeMethodInfoPtr_OnPick_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667255);
		NativeMethodInfoPtr_ForceSetClothesStateBlend_Public_Abstract_Virtual_New_Void_ClothesState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667256);
		NativeMethodInfoPtr_GetExposedBodyParts_Public_Abstract_Virtual_New_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667257);
		NativeMethodInfoPtr_GetNextState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667258);
		NativeMethodInfoPtr_GetPrevState_Public_Abstract_Virtual_New_ClothesState_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667259);
		NativeMethodInfoPtr_IsEnoughSkillLevel_Public_Abstract_Virtual_New_Boolean_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IClothesController>.NativeClassPtr, 100667260);
	}

	public IClothesController(IntPtr pointer)
		: base(pointer)
	{
	}
}
