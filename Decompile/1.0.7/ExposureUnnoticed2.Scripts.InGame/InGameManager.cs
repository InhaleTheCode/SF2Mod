using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.SpermBullet;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class InGameManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeFieldInfoPtr__DroppedItemManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__InGameReferencer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__TempInGameState_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__MissionManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__CurrentStageController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__VisibilityFogController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__DroneManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__RandomMissionManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__StageTransController_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__GameStateApplier_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__SexManager_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_isExist;

	private static readonly IntPtr NativeFieldInfoPtr_eventMethodManager;

	private static readonly IntPtr NativeFieldInfoPtr_gameStateChecker;

	private static readonly IntPtr NativeFieldInfoPtr_inGameEventListener;

	private static readonly IntPtr NativeFieldInfoPtr_interactManager;

	private static readonly IntPtr NativeFieldInfoPtr_spermDecalManager;

	private static readonly IntPtr NativeFieldInfoPtr_statisticsManager;

	private static readonly IntPtr NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DroppedItemManager_Private_set_Void_DroppedItemManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_InGameReferencer_Public_get_InGameReferencer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_InGameReferencer_Private_set_Void_InGameReferencer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_TempInGameState_Public_get_TemporaryInGameState_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_TempInGameState_Private_set_Void_TemporaryInGameState_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_MissionManager_Public_get_MissionManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MissionManager_Private_set_Void_MissionManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStageController_Public_get_StageController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStageController_Public_set_Void_StageController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_VisibilityFogController_Public_get_VisibilityFogController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_VisibilityFogController_Private_set_Void_VisibilityFogController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DroneManager_Public_get_DroneManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_DroneManager_Private_set_Void_DroneManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_RandomMissionManager_Public_get_RandomMissionManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_RandomMissionManager_Private_set_Void_RandomMissionManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_StageTransController_Public_get_StageTransController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StageTransController_Private_set_Void_StageTransController_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_GameStateApplier_Public_get_GameStateApplier_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_GameStateApplier_Private_set_Void_GameStateApplier_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_SexManager_Public_get_SexManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_SexManager_Private_set_Void_SexManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnExitInGameEvent_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__52_0_Private_Void_0;

	public unsafe static InGameManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<InGameManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DroppedItemManager _DroppedItemManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroppedItemManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroppedItemManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameReferencer _InGameReferencer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameReferencer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameReferencer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__InGameReferencer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TemporaryInGameState _TempInGameState_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TempInGameState_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemporaryInGameState>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TempInGameState_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MissionManager _MissionManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MissionManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MissionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MissionManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StageController _CurrentStageController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentStageController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentStageController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VisibilityFogController _VisibilityFogController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__VisibilityFogController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VisibilityFogController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__VisibilityFogController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DroneManager _DroneManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroneManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DroneManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DroneManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RandomMissionManager _RandomMissionManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RandomMissionManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RandomMissionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RandomMissionManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StageTransController _StageTransController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageTransController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageTransController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageTransController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameStateApplier _GameStateApplier_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameStateApplier_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameStateApplier>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__GameStateApplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SexManager _SexManager_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SexManager_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SexManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__SexManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static bool isExist
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isExist, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isExist, &flag);
		}
	}

	public unsafe EventMethodManager eventMethodManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventMethodManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<EventMethodManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventMethodManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameStateChecker gameStateChecker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameStateChecker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameStateChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gameStateChecker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameEventListener inGameEventListener
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameEventListener);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameEventListener>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameEventListener), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteractManager interactManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SpermDecalManager spermDecalManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spermDecalManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SpermDecalManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spermDecalManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StatisticsManager statisticsManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticsManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StatisticsManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_statisticsManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DroppedItemManager DroppedItemManager
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DroppedItemManager_Private_set_Void_DroppedItemManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe InGameReferencer InGameReferencer
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_InGameReferencer_Public_get_InGameReferencer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InGameReferencer>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_InGameReferencer_Private_set_Void_InGameReferencer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe TemporaryInGameState TempInGameState
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TempInGameState_Public_get_TemporaryInGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TemporaryInGameState>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TempInGameState_Private_set_Void_TemporaryInGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe MissionManager MissionManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MissionManager_Public_get_MissionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MissionManager>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MissionManager_Private_set_Void_MissionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe StageController CurrentStageController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentStageController_Public_get_StageController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageController>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentStageController_Public_set_Void_StageController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe VisibilityFogController VisibilityFogController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VisibilityFogController_Public_get_VisibilityFogController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VisibilityFogController>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_VisibilityFogController_Private_set_Void_VisibilityFogController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe DroneManager DroneManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DroneManager_Public_get_DroneManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DroneManager>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DroneManager_Private_set_Void_DroneManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RandomMissionManager RandomMissionManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RandomMissionManager_Public_get_RandomMissionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RandomMissionManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RandomMissionManager_Private_set_Void_RandomMissionManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe StageTransController StageTransController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StageTransController_Public_get_StageTransController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageTransController>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StageTransController_Private_set_Void_StageTransController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe GameStateApplier GameStateApplier
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_GameStateApplier_Public_get_GameStateApplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameStateApplier>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_GameStateApplier_Private_set_Void_GameStateApplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe SexManager SexManager
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SexManager_Public_get_SexManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SexManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_SexManager_Private_set_Void_SexManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75119, XrefRangeEnd = 75417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75417, XrefRangeEnd = 75532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75532, XrefRangeEnd = 75561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75561, XrefRangeEnd = 75565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75565, XrefRangeEnd = 75576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnExitInGameEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnExitInGameEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75576, XrefRangeEnd = 75582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InGameManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InGameManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75582, XrefRangeEnd = 75600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__52_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__52_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InGameManager()
	{
		Il2CppClassPointerStore<InGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "InGameManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InGameManager>.NativeClassPtr);
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr__DroppedItemManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<DroppedItemManager>k__BackingField");
		NativeFieldInfoPtr__InGameReferencer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<InGameReferencer>k__BackingField");
		NativeFieldInfoPtr__TempInGameState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<TempInGameState>k__BackingField");
		NativeFieldInfoPtr__MissionManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<MissionManager>k__BackingField");
		NativeFieldInfoPtr__CurrentStageController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<CurrentStageController>k__BackingField");
		NativeFieldInfoPtr__VisibilityFogController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<VisibilityFogController>k__BackingField");
		NativeFieldInfoPtr__DroneManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<DroneManager>k__BackingField");
		NativeFieldInfoPtr__RandomMissionManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<RandomMissionManager>k__BackingField");
		NativeFieldInfoPtr__StageTransController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<StageTransController>k__BackingField");
		NativeFieldInfoPtr__GameStateApplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<GameStateApplier>k__BackingField");
		NativeFieldInfoPtr__SexManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "<SexManager>k__BackingField");
		NativeFieldInfoPtr_isExist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "isExist");
		NativeFieldInfoPtr_eventMethodManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "eventMethodManager");
		NativeFieldInfoPtr_gameStateChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "gameStateChecker");
		NativeFieldInfoPtr_inGameEventListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "inGameEventListener");
		NativeFieldInfoPtr_interactManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "interactManager");
		NativeFieldInfoPtr_spermDecalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "spermDecalManager");
		NativeFieldInfoPtr_statisticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, "statisticsManager");
		NativeMethodInfoPtr_get_DroppedItemManager_Public_get_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668782);
		NativeMethodInfoPtr_set_DroppedItemManager_Private_set_Void_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668783);
		NativeMethodInfoPtr_get_InGameReferencer_Public_get_InGameReferencer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668784);
		NativeMethodInfoPtr_set_InGameReferencer_Private_set_Void_InGameReferencer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668785);
		NativeMethodInfoPtr_get_TempInGameState_Public_get_TemporaryInGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668786);
		NativeMethodInfoPtr_set_TempInGameState_Private_set_Void_TemporaryInGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668787);
		NativeMethodInfoPtr_get_MissionManager_Public_get_MissionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668788);
		NativeMethodInfoPtr_set_MissionManager_Private_set_Void_MissionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668789);
		NativeMethodInfoPtr_get_CurrentStageController_Public_get_StageController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668790);
		NativeMethodInfoPtr_set_CurrentStageController_Public_set_Void_StageController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668791);
		NativeMethodInfoPtr_get_VisibilityFogController_Public_get_VisibilityFogController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668792);
		NativeMethodInfoPtr_set_VisibilityFogController_Private_set_Void_VisibilityFogController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668793);
		NativeMethodInfoPtr_get_DroneManager_Public_get_DroneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668794);
		NativeMethodInfoPtr_set_DroneManager_Private_set_Void_DroneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668795);
		NativeMethodInfoPtr_get_RandomMissionManager_Public_get_RandomMissionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668796);
		NativeMethodInfoPtr_set_RandomMissionManager_Private_set_Void_RandomMissionManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668797);
		NativeMethodInfoPtr_get_StageTransController_Public_get_StageTransController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668798);
		NativeMethodInfoPtr_set_StageTransController_Private_set_Void_StageTransController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668799);
		NativeMethodInfoPtr_get_GameStateApplier_Public_get_GameStateApplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668800);
		NativeMethodInfoPtr_set_GameStateApplier_Private_set_Void_GameStateApplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668801);
		NativeMethodInfoPtr_get_SexManager_Public_get_SexManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668802);
		NativeMethodInfoPtr_set_SexManager_Private_set_Void_SexManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668803);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668804);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668805);
		NativeMethodInfoPtr_OnUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668806);
		NativeMethodInfoPtr_OnLateUpdate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668807);
		NativeMethodInfoPtr_OnExitInGameEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668808);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668809);
		NativeMethodInfoPtr__Start_b__52_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InGameManager>.NativeClassPtr, 100668810);
	}

	public InGameManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
