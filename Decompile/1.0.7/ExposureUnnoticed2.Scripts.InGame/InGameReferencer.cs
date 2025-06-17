using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkilliMum.Standard.Mirror;
using ExposureUnnoticed2.Object3D.Camera;
using ExposureUnnoticed2.Object3D.IngameManager;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using ExposureUnnoticed2.Object3D.UIPlayer;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AI;

namespace ExposureUnnoticed2.Scripts.InGame;

public class InGameReferencer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_inGameManager;

	private static readonly IntPtr NativeFieldInfoPtr__InGameUiManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__BaseCameraController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TpCameraController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__InventoryCameraController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__NpcManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__GlobalVolume_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__GameOverController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ClothesPathSearchAgent_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SlowAssistManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__UiPlayerController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__UiOptionApplyer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__InGameGraphicsOptionApplyer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SelfCameraParent_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__FaceCameraController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__BodyCameraObject_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__MirrorManager_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_InGameUiManager_Public_get_InGameUiManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InGameUiManager_Private_set_Void_InGameUiManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Player_Public_set_Void_PlayerController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BaseCameraController_Public_get_BaseCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BaseCameraController_Private_set_Void_BaseCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TpCameraController_Public_get_TPCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_TpCameraController_Private_set_Void_TPCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InventoryCameraController_Public_get_InventoryCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InventoryCameraController_Private_set_Void_InventoryCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NpcManager_Public_get_NpcManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_NpcManager_Private_set_Void_NpcManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GlobalVolume_Public_get_VolumeController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_GlobalVolume_Private_set_Void_VolumeController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GameOverController_Public_get_GameOverController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_GameOverController_Private_set_Void_GameOverController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ClothesPathSearchAgent_Public_get_NavMeshAgent_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ClothesPathSearchAgent_Private_set_Void_NavMeshAgent_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SlowAssistManager_Public_get_SlowAssistManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SlowAssistManager_Private_set_Void_SlowAssistManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UiPlayerController_Public_get_UiPlayerController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_UiPlayerController_Private_set_Void_UiPlayerController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_UiOptionApplyer_Public_get_UiOptionApplyer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_UiOptionApplyer_Private_set_Void_UiOptionApplyer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InGameGraphicsOptionApplyer_Public_get_InGameGraphicsOptionApplyer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InGameGraphicsOptionApplyer_Private_set_Void_InGameGraphicsOptionApplyer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SelfCameraParent_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SelfCameraParent_Private_set_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FaceCameraController_Public_get_FaceCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FaceCameraController_Private_set_Void_FaceCameraController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BodyCameraObject_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BodyCameraObject_Private_set_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InGameManager_Public_get_InGameManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MirrorManager_Public_get_MirrorManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MirrorManager_Private_set_Void_MirrorManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InGameManager inGameManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameUiManager _InGameUiManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameUiManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameUiManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameUiManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerController _Player_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseCameraController _BaseCameraController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BaseCameraController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseCameraController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BaseCameraController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TPCameraController _TpCameraController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TpCameraController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TPCameraController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TpCameraController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InventoryCameraController _InventoryCameraController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InventoryCameraController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryCameraController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InventoryCameraController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcManager _NpcManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VolumeController _GlobalVolume_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GlobalVolume_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VolumeController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GlobalVolume_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameOverController _GameOverController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameOverController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameOverController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameOverController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NavMeshAgent _ClothesPathSearchAgent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClothesPathSearchAgent_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClothesPathSearchAgent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SlowAssistManager _SlowAssistManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SlowAssistManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SlowAssistManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SlowAssistManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UiPlayerController _UiPlayerController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UiPlayerController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UiPlayerController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UiPlayerController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe UiOptionApplyer _UiOptionApplyer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UiOptionApplyer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UiOptionApplyer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UiOptionApplyer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameGraphicsOptionApplyer _InGameGraphicsOptionApplyer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameGraphicsOptionApplyer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameGraphicsOptionApplyer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameGraphicsOptionApplyer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _SelfCameraParent_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelfCameraParent_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SelfCameraParent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FaceCameraController _FaceCameraController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FaceCameraController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FaceCameraController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FaceCameraController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _BodyCameraObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyCameraObject_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyCameraObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MirrorManager _MirrorManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MirrorManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MirrorManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MirrorManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameUiManager InGameUiManager
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InGameUiManager_Public_get_InGameUiManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameUiManager>(intPtr) : null;
		}
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 32970, RefRangeEnd = 33003, XrefRangeStart = 32970, XrefRangeEnd = 33003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InGameUiManager_Private_set_Void_InGameUiManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe PlayerController Player
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41561, RefRangeEnd = 41569, XrefRangeStart = 41561, XrefRangeEnd = 41569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Player_Public_set_Void_PlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe BaseCameraController BaseCameraController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseCameraController_Public_get_BaseCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseCameraController>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41569, RefRangeEnd = 41574, XrefRangeStart = 41569, XrefRangeEnd = 41574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BaseCameraController_Private_set_Void_BaseCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe TPCameraController TpCameraController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TpCameraController_Public_get_TPCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TPCameraController>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41574, RefRangeEnd = 41582, XrefRangeStart = 41574, XrefRangeEnd = 41582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TpCameraController_Private_set_Void_TPCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe InventoryCameraController InventoryCameraController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InventoryCameraController_Public_get_InventoryCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InventoryCameraController>(intPtr) : null;
		}
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 29631, RefRangeEnd = 29651, XrefRangeStart = 29631, XrefRangeEnd = 29651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InventoryCameraController_Private_set_Void_InventoryCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe NpcManager NpcManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcManager_Public_get_NpcManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcManager>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 41582, RefRangeEnd = 41589, XrefRangeStart = 41582, XrefRangeEnd = 41589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NpcManager_Private_set_Void_NpcManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe VolumeController GlobalVolume
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GlobalVolume_Public_get_VolumeController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VolumeController>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GlobalVolume_Private_set_Void_VolumeController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameOverController GameOverController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameOverController_Public_get_GameOverController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameOverController>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41740, RefRangeEnd = 41741, XrefRangeStart = 41740, XrefRangeEnd = 41741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GameOverController_Private_set_Void_GameOverController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe NavMeshAgent ClothesPathSearchAgent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClothesPathSearchAgent_Public_get_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NavMeshAgent>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClothesPathSearchAgent_Private_set_Void_NavMeshAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe SlowAssistManager SlowAssistManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SlowAssistManager_Public_get_SlowAssistManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SlowAssistManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SlowAssistManager_Private_set_Void_SlowAssistManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe UiPlayerController UiPlayerController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UiPlayerController_Public_get_UiPlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UiPlayerController>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UiPlayerController_Private_set_Void_UiPlayerController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe UiOptionApplyer UiOptionApplyer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UiOptionApplyer_Public_get_UiOptionApplyer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<UiOptionApplyer>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41741, RefRangeEnd = 41743, XrefRangeStart = 41741, XrefRangeEnd = 41743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UiOptionApplyer_Private_set_Void_UiOptionApplyer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe InGameGraphicsOptionApplyer InGameGraphicsOptionApplyer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InGameGraphicsOptionApplyer_Public_get_InGameGraphicsOptionApplyer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameGraphicsOptionApplyer>(intPtr) : null;
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75600, RefRangeEnd = 75602, XrefRangeStart = 75600, XrefRangeEnd = 75600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InGameGraphicsOptionApplyer_Private_set_Void_InGameGraphicsOptionApplyer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameObject SelfCameraParent
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SelfCameraParent_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61272, RefRangeEnd = 61273, XrefRangeStart = 61272, XrefRangeEnd = 61273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SelfCameraParent_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe FaceCameraController FaceCameraController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FaceCameraController_Public_get_FaceCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FaceCameraController>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FaceCameraController_Private_set_Void_FaceCameraController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameObject BodyCameraObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BodyCameraObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BodyCameraObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe InGameManager InGameManager
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InGameManager_Public_get_InGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameManager>(intPtr) : null;
		}
	}

	public unsafe MirrorManager MirrorManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MirrorManager_Public_get_MirrorManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MirrorManager>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 51803, RefRangeEnd = 51804, XrefRangeStart = 51803, XrefRangeEnd = 51804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MirrorManager_Private_set_Void_MirrorManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75602, XrefRangeEnd = 75605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameReferencer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InGameReferencer()
	{
		Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "InGameReferencer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr);
		NativeFieldInfoPtr_inGameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "inGameManager");
		NativeFieldInfoPtr__InGameUiManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<InGameUiManager>k__BackingField");
		NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<Player>k__BackingField");
		NativeFieldInfoPtr__BaseCameraController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<BaseCameraController>k__BackingField");
		NativeFieldInfoPtr__TpCameraController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<TpCameraController>k__BackingField");
		NativeFieldInfoPtr__InventoryCameraController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<InventoryCameraController>k__BackingField");
		NativeFieldInfoPtr__NpcManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<NpcManager>k__BackingField");
		NativeFieldInfoPtr__GlobalVolume_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<GlobalVolume>k__BackingField");
		NativeFieldInfoPtr__GameOverController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<GameOverController>k__BackingField");
		NativeFieldInfoPtr__ClothesPathSearchAgent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<ClothesPathSearchAgent>k__BackingField");
		NativeFieldInfoPtr__SlowAssistManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<SlowAssistManager>k__BackingField");
		NativeFieldInfoPtr__UiPlayerController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<UiPlayerController>k__BackingField");
		NativeFieldInfoPtr__UiOptionApplyer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<UiOptionApplyer>k__BackingField");
		NativeFieldInfoPtr__InGameGraphicsOptionApplyer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<InGameGraphicsOptionApplyer>k__BackingField");
		NativeFieldInfoPtr__SelfCameraParent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<SelfCameraParent>k__BackingField");
		NativeFieldInfoPtr__FaceCameraController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<FaceCameraController>k__BackingField");
		NativeFieldInfoPtr__BodyCameraObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<BodyCameraObject>k__BackingField");
		NativeFieldInfoPtr__MirrorManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, "<MirrorManager>k__BackingField");
		NativeMethodInfoPtr_get_InGameUiManager_Public_get_InGameUiManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668811);
		NativeMethodInfoPtr_set_InGameUiManager_Private_set_Void_InGameUiManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668812);
		NativeMethodInfoPtr_get_Player_Public_get_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668813);
		NativeMethodInfoPtr_set_Player_Public_set_Void_PlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668814);
		NativeMethodInfoPtr_get_BaseCameraController_Public_get_BaseCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668815);
		NativeMethodInfoPtr_set_BaseCameraController_Private_set_Void_BaseCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668816);
		NativeMethodInfoPtr_get_TpCameraController_Public_get_TPCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668817);
		NativeMethodInfoPtr_set_TpCameraController_Private_set_Void_TPCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668818);
		NativeMethodInfoPtr_get_InventoryCameraController_Public_get_InventoryCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668819);
		NativeMethodInfoPtr_set_InventoryCameraController_Private_set_Void_InventoryCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668820);
		NativeMethodInfoPtr_get_NpcManager_Public_get_NpcManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668821);
		NativeMethodInfoPtr_set_NpcManager_Private_set_Void_NpcManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668822);
		NativeMethodInfoPtr_get_GlobalVolume_Public_get_VolumeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668823);
		NativeMethodInfoPtr_set_GlobalVolume_Private_set_Void_VolumeController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668824);
		NativeMethodInfoPtr_get_GameOverController_Public_get_GameOverController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668825);
		NativeMethodInfoPtr_set_GameOverController_Private_set_Void_GameOverController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668826);
		NativeMethodInfoPtr_get_ClothesPathSearchAgent_Public_get_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668827);
		NativeMethodInfoPtr_set_ClothesPathSearchAgent_Private_set_Void_NavMeshAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668828);
		NativeMethodInfoPtr_get_SlowAssistManager_Public_get_SlowAssistManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668829);
		NativeMethodInfoPtr_set_SlowAssistManager_Private_set_Void_SlowAssistManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668830);
		NativeMethodInfoPtr_get_UiPlayerController_Public_get_UiPlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668831);
		NativeMethodInfoPtr_set_UiPlayerController_Private_set_Void_UiPlayerController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668832);
		NativeMethodInfoPtr_get_UiOptionApplyer_Public_get_UiOptionApplyer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668833);
		NativeMethodInfoPtr_set_UiOptionApplyer_Private_set_Void_UiOptionApplyer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668834);
		NativeMethodInfoPtr_get_InGameGraphicsOptionApplyer_Public_get_InGameGraphicsOptionApplyer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668835);
		NativeMethodInfoPtr_set_InGameGraphicsOptionApplyer_Private_set_Void_InGameGraphicsOptionApplyer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668836);
		NativeMethodInfoPtr_get_SelfCameraParent_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668837);
		NativeMethodInfoPtr_set_SelfCameraParent_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668838);
		NativeMethodInfoPtr_get_FaceCameraController_Public_get_FaceCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668839);
		NativeMethodInfoPtr_set_FaceCameraController_Private_set_Void_FaceCameraController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668840);
		NativeMethodInfoPtr_get_BodyCameraObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668841);
		NativeMethodInfoPtr_set_BodyCameraObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668842);
		NativeMethodInfoPtr_get_InGameManager_Public_get_InGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668843);
		NativeMethodInfoPtr_get_MirrorManager_Public_get_MirrorManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668844);
		NativeMethodInfoPtr_set_MirrorManager_Private_set_Void_MirrorManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668845);
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668846);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameReferencer>.NativeClassPtr, 100668847);
	}

	public InGameReferencer(IntPtr pointer)
		: base(pointer)
	{
	}
}
