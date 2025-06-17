using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Clothes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerClothesAction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_playerAnimationManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_playerSoundManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OpenClothes_Private_Void_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CloseClothes_Private_Void_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnoughSkillLevel_Private_Boolean_ClothesType_CoatActionType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCompletePickClothes_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PlayerAnimationManager playerAnimationManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAnimationManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerAnimationManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerAnimationManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerSoundManager playerSoundManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSoundManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSoundManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerSoundManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerClassAccessor pca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClassAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52744, XrefRangeEnd = 52746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52763, RefRangeEnd = 52764, XrefRangeStart = 52746, XrefRangeEnd = 52763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate([DefaultParameterValue(null)] InputData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52777, RefRangeEnd = 52778, XrefRangeStart = 52764, XrefRangeEnd = 52777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenClothes([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OpenClothes_Private_Void_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 52785, RefRangeEnd = 52789, XrefRangeStart = 52778, XrefRangeEnd = 52785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseClothes([DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CloseClothes_Private_Void_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52801, RefRangeEnd = 52802, XrefRangeStart = 52789, XrefRangeEnd = 52801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEnoughSkillLevel([DefaultParameterValue(null)] ClothesType clothesType, [DefaultParameterValue(null)] PlayerStateModel.CoatActionType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&clothesType);
		*(PlayerStateModel.CoatActionType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnoughSkillLevel_Private_Boolean_ClothesType_CoatActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52802, XrefRangeEnd = 52806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCompletePickClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnCompletePickClothes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PlayerClothesAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerClothesAction()
	{
		Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerClothesAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr);
		NativeFieldInfoPtr_playerAnimationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, "playerAnimationManager");
		NativeFieldInfoPtr_playerSoundManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, "playerSoundManager");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, "pca");
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666693);
		NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666694);
		NativeMethodInfoPtr_OpenClothes_Private_Void_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666695);
		NativeMethodInfoPtr_CloseClothes_Private_Void_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666696);
		NativeMethodInfoPtr_IsEnoughSkillLevel_Private_Boolean_ClothesType_CoatActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666697);
		NativeMethodInfoPtr_OnCompletePickClothes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666698);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothesAction>.NativeClassPtr, 100666699);
	}

	public PlayerClothesAction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
