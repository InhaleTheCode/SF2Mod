using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Object3D.NpcCar;
using ExposureUnnoticed2.Object3D.RoutePoint;
using ExposureUnnoticed2.Object3D.ScenePlops.Conbini;
using ExposureUnnoticed2.Object3D.ScenePlops.Elevator;
using ExposureUnnoticed2.Object3D.ScenePlops.TalkPoint;
using ExposureUnnoticed2.Object3D.ScenePlops.WallFog;
using ExposureUnnoticed2.Object3D.ToiletManager;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.Sound;
using ExposureUnnoticed2.Scripts.Tools;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class StageController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__StageType_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__Terrain_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_baseRouteBuilder;

	private static readonly IntPtr NativeFieldInfoPtr_bgmController;

	private static readonly IntPtr NativeFieldInfoPtr_daytimeSetting;

	private static readonly IntPtr NativeFieldInfoPtr_nightSetting;

	private static readonly IntPtr NativeFieldInfoPtr_daytimeLight;

	private static readonly IntPtr NativeFieldInfoPtr_nightLight;

	private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeManager;

	private static readonly IntPtr NativeFieldInfoPtr_wallFogControllers;

	private static readonly IntPtr NativeFieldInfoPtr_talkNpcManager;

	private static readonly IntPtr NativeFieldInfoPtr_npcCarManager;

	private static readonly IntPtr NativeFieldInfoPtr_sitNpcManager;

	private static readonly IntPtr NativeFieldInfoPtr_standNpcManager;

	private static readonly IntPtr NativeFieldInfoPtr_pinponNpcManager;

	private static readonly IntPtr NativeFieldInfoPtr_conbiniController;

	private static readonly IntPtr NativeFieldInfoPtr_toiletManager;

	private static readonly IntPtr NativeFieldInfoPtr_elevatorController;

	private static readonly IntPtr NativeFieldInfoPtr_lightmapChanger;

	private static readonly IntPtr NativeFieldInfoPtr_mirrors;

	private static readonly IntPtr NativeFieldInfoPtr_ItemRandomPositionManager;

	private static readonly IntPtr NativeFieldInfoPtr_PlayerRandomPositionManager;

	private static readonly IntPtr NativeFieldInfoPtr_PortalManager;

	private static readonly IntPtr NativeFieldInfoPtr_isAlreadyInit;

	private static readonly IntPtr NativeMethodInfoPtr_get_StageType_Public_get_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_StageType_Private_set_Void_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Terrain_Public_get_Terrain_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Terrain_Private_set_Void_Terrain_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Mirrors_Public_get_Il2CppReferenceArray_1_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_CurrentFogColor_Public_Color_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateByDaytimeNight_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateReleaseFastTravel_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_CurrentFogDensity_Public_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__32_0_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__Start_b__32_1_Private_Void_0;

	public unsafe StageType _StageType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageType_k__BackingField);
			return *(StageType*)num;
		}
		set
		{
			*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__StageType_k__BackingField)) = stageType;
		}
	}

	public unsafe Terrain _Terrain_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Terrain_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Terrain>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Terrain_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BaseRouteBuilder baseRouteBuilder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRouteBuilder);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BaseRouteBuilder>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseRouteBuilder), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BgmController bgmController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgmController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BgmController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bgmController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SkySetting daytimeSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeSetting);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkySetting>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeSetting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SkySetting nightSetting
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSetting);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkySetting>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightSetting), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject daytimeLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_daytimeLight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject nightLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nightLight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ReflectionProbeManager reflectionProbeManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ReflectionProbeManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectionProbeManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<WallFogController> wallFogControllers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallFogControllers);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WallFogController>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_wallFogControllers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TalkNpcManager talkNpcManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_talkNpcManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TalkNpcManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_talkNpcManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcCarManager npcCarManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcCarManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcCarManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_npcCarManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SitNpcManager sitNpcManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitNpcManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SitNpcManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitNpcManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StandNpcManager standNpcManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standNpcManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StandNpcManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_standNpcManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PinponNpcManager pinponNpcManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinponNpcManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PinponNpcManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinponNpcManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ConbiniController conbiniController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ConbiniController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conbiniController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ToiletManager toiletManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toiletManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ToiletManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toiletManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ElevatorController elevatorController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElevatorController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Corevale_SwapLightmap lightmapChanger
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapChanger);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Corevale_SwapLightmap>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lightmapChanger), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> mirrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mirrors);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mirrors), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StageRandomPositionManager ItemRandomPositionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemRandomPositionManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageRandomPositionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemRandomPositionManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe StageRandomPositionManager PlayerRandomPositionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRandomPositionManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageRandomPositionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerRandomPositionManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PortalManager PortalManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PortalManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isAlreadyInit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlreadyInit);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isAlreadyInit)) = flag;
		}
	}

	public unsafe StageType StageType
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48521, RefRangeEnd = 48522, XrefRangeStart = 48521, XrefRangeEnd = 48522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_StageType_Public_get_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(StageType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_StageType_Private_set_Void_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Terrain Terrain
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Terrain_Public_get_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Terrain>(intPtr) : null;
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Terrain_Private_set_Void_Terrain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> Mirrors
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Mirrors_Public_get_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77176, XrefRangeEnd = 77205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77205, XrefRangeEnd = 77233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77233, XrefRangeEnd = 77306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77306, XrefRangeEnd = 77318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeTime([DefaultParameterValue(null)] ChangeTimeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77318, XrefRangeEnd = 77320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Color CurrentFogColor()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentFogColor_Public_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 77366, RefRangeEnd = 77368, XrefRangeStart = 77320, XrefRangeEnd = 77366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateByDaytimeNight(bool isInitialize = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isInitialize);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateByDaytimeNight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77390, RefRangeEnd = 77391, XrefRangeStart = 77368, XrefRangeEnd = 77390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateReleaseFastTravel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateReleaseFastTravel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 77394, RefRangeEnd = 77396, XrefRangeStart = 77391, XrefRangeEnd = 77394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetSpawnPoint([DefaultParameterValue(null)] StageType fromStageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&fromStageType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77402, RefRangeEnd = 77403, XrefRangeStart = 77396, XrefRangeEnd = 77402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform GetEscapeTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77403, XrefRangeEnd = 77405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CurrentFogDensity()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CurrentFogDensity_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StageController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StageController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77405, XrefRangeEnd = 77470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__32_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77470, XrefRangeEnd = 77599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__32_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Start_b__32_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StageController()
	{
		Il2CppClassPointerStore<StageController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "StageController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StageController>.NativeClassPtr);
		NativeFieldInfoPtr__StageType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "<StageType>k__BackingField");
		NativeFieldInfoPtr__Terrain_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "<Terrain>k__BackingField");
		NativeFieldInfoPtr_baseRouteBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "baseRouteBuilder");
		NativeFieldInfoPtr_bgmController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "bgmController");
		NativeFieldInfoPtr_daytimeSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "daytimeSetting");
		NativeFieldInfoPtr_nightSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "nightSetting");
		NativeFieldInfoPtr_daytimeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "daytimeLight");
		NativeFieldInfoPtr_nightLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "nightLight");
		NativeFieldInfoPtr_reflectionProbeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "reflectionProbeManager");
		NativeFieldInfoPtr_wallFogControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "wallFogControllers");
		NativeFieldInfoPtr_talkNpcManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "talkNpcManager");
		NativeFieldInfoPtr_npcCarManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "npcCarManager");
		NativeFieldInfoPtr_sitNpcManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "sitNpcManager");
		NativeFieldInfoPtr_standNpcManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "standNpcManager");
		NativeFieldInfoPtr_pinponNpcManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "pinponNpcManager");
		NativeFieldInfoPtr_conbiniController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "conbiniController");
		NativeFieldInfoPtr_toiletManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "toiletManager");
		NativeFieldInfoPtr_elevatorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "elevatorController");
		NativeFieldInfoPtr_lightmapChanger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "lightmapChanger");
		NativeFieldInfoPtr_mirrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "mirrors");
		NativeFieldInfoPtr_ItemRandomPositionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "ItemRandomPositionManager");
		NativeFieldInfoPtr_PlayerRandomPositionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "PlayerRandomPositionManager");
		NativeFieldInfoPtr_PortalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "PortalManager");
		NativeFieldInfoPtr_isAlreadyInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StageController>.NativeClassPtr, "isAlreadyInit");
		NativeMethodInfoPtr_get_StageType_Public_get_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668981);
		NativeMethodInfoPtr_set_StageType_Private_set_Void_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668982);
		NativeMethodInfoPtr_get_Terrain_Public_get_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668983);
		NativeMethodInfoPtr_set_Terrain_Private_set_Void_Terrain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668984);
		NativeMethodInfoPtr_get_Mirrors_Public_get_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668985);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668986);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668987);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668988);
		NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668989);
		NativeMethodInfoPtr_CurrentFogColor_Public_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668990);
		NativeMethodInfoPtr_UpdateByDaytimeNight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668991);
		NativeMethodInfoPtr_UpdateReleaseFastTravel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668992);
		NativeMethodInfoPtr_GetSpawnPoint_Public_Transform_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668993);
		NativeMethodInfoPtr_GetEscapeTarget_Public_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668994);
		NativeMethodInfoPtr_CurrentFogDensity_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668995);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668996);
		NativeMethodInfoPtr__Start_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668997);
		NativeMethodInfoPtr__Start_b__32_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StageController>.NativeClassPtr, 100668998);
	}

	public StageController(IntPtr pointer)
		: base(pointer)
	{
	}
}
