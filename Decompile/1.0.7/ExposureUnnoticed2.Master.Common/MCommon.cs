using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Common;

public class MCommon : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_a;

	private static readonly IntPtr NativeFieldInfoPtr_b;

	private static readonly IntPtr NativeFieldInfoPtr_c;

	private static readonly IntPtr NativeFieldInfoPtr_d;

	private static readonly IntPtr NativeFieldInfoPtr_baseCameraSensitive;

	private static readonly IntPtr NativeFieldInfoPtr_cameraScrollSensitive;

	private static readonly IntPtr NativeFieldInfoPtr_EyeMaskCameraFarClip;

	private static readonly IntPtr NativeFieldInfoPtr_NormalCameraFarClip;

	private static readonly IntPtr NativeFieldInfoPtr_EyeMaskFogColor;

	private static readonly IntPtr NativeFieldInfoPtr_EyeMaskFogNear;

	private static readonly IntPtr NativeFieldInfoPtr_EyeMaskFogFar;

	private static readonly IntPtr NativeFieldInfoPtr_EyeMaskFogDensity;

	private static readonly IntPtr NativeFieldInfoPtr_playerCrouchSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_playerWalkSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_PlayerGamanWalkSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_playerJogSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_playerMaxStamina;

	private static readonly IntPtr NativeFieldInfoPtr_playerStaminaRegeneration;

	private static readonly IntPtr NativeFieldInfoPtr_playerStaminaRegenerateSecond;

	private static readonly IntPtr NativeFieldInfoPtr_PlayerStaminaDashPerSecond;

	private static readonly IntPtr NativeFieldInfoPtr_pulseMentalReduce;

	private static readonly IntPtr NativeFieldInfoPtr_dotMentalExpose;

	private static readonly IntPtr NativeFieldInfoPtr_dotMentalWatched;

	private static readonly IntPtr NativeFieldInfoPtr_EquipLoadoutMotionTime;

	private static readonly IntPtr NativeFieldInfoPtr_SmallOppai;

	private static readonly IntPtr NativeFieldInfoPtr_FreeOppai;

	private static readonly IntPtr NativeFieldInfoPtr_BigOppai;

	private static readonly IntPtr NativeFieldInfoPtr_BraOppai;

	private static readonly IntPtr NativeFieldInfoPtr_ClothesOppai;

	private static readonly IntPtr NativeFieldInfoPtr_IsControlOppaiByInspector;

	private static readonly IntPtr NativeFieldInfoPtr_DampingBigBreastScale;

	private static readonly IntPtr NativeFieldInfoPtr_ElasBigBreastScale;

	private static readonly IntPtr NativeFieldInfoPtr_BraStiff;

	private static readonly IntPtr NativeFieldInfoPtr_ClothStiff;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeHairPrice;

	private static readonly IntPtr NativeFieldInfoPtr_ChangeHairColorPrice;

	private static readonly IntPtr NativeFieldInfoPtr_WashingPrice;

	private static readonly IntPtr NativeFieldInfoPtr_WaterPrice;

	private static readonly IntPtr NativeFieldInfoPtr_VibeRemoconReinforcePrice;

	private static readonly IntPtr NativeFieldInfoPtr_DroneReinforcePrice;

	private static readonly IntPtr NativeFieldInfoPtr_AttachHandcuffsTime;

	private static readonly IntPtr NativeFieldInfoPtr_HandcuffsSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_HandcuffsProbability;

	private static readonly IntPtr NativeFieldInfoPtr_HandcuffsAddProbabilityByFailure;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiOpenFront;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiOpenUpper;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiDropClothes;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiOpenHip;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiDropBra;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiDropPants;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiLight;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiAdultGoodsUpperLimit;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiPee;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeExposeFront;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeExposeUpperFromFront;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeExposeUpperFromBack;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeExposeHip;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeExposeAll;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeVibratorLow;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeVibratorHigh;

	private static readonly IntPtr NativeFieldInfoPtr_ListenNoisyDist;

	private static readonly IntPtr NativeFieldInfoPtr_MaxFoundDist;

	private static readonly IntPtr NativeFieldInfoPtr_StrangeLookAt;

	private static readonly IntPtr NativeFieldInfoPtr_NoPantsRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_NoBraRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_ClothesDistanceRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_DaytimeRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_NearNpcPerOneRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_LightRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_ExposeFrontRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_ExposeUpperRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_ExposeAllRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_ExposeHipRpBonus;

	private static readonly IntPtr NativeFieldInfoPtr_RpBonusColor;

	private static readonly IntPtr NativeFieldInfoPtr_RpBonusColorSecondary;

	private static readonly IntPtr NativeFieldInfoPtr_WashingSecond;

	private static readonly IntPtr NativeFieldInfoPtr_AddMoistureWater;

	private static readonly IntPtr NativeFieldInfoPtr_TransMoisturePerSecond;

	private static readonly IntPtr NativeFieldInfoPtr_PeeAbleMoistureThreshold;

	private static readonly IntPtr NativeFieldInfoPtr_PeeMotionSecond;

	private static readonly IntPtr NativeFieldInfoPtr_AddMissionSatisfyPerSecond;

	private static readonly IntPtr NativeFieldInfoPtr_ApartAutoDropPosition;

	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_BaseCameraSensitive_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_CameraScrollSensitive_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCrouchSpeed_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerWalkSpeed_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerJogSpeed_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerMaxStamina_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerStaminaRegeneration_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PlayerStaminaRegenerateSecond_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DotMentalWatched_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DotMentalExpose_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_PulseMentalReduce_Public_Static_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MCommon_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float a
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_a)) = num;
		}
	}

	public unsafe float b
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b)) = num;
		}
	}

	public unsafe float c
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_c)) = num;
		}
	}

	public unsafe float d
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_d)) = num;
		}
	}

	public unsafe float baseCameraSensitive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCameraSensitive);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseCameraSensitive)) = num;
		}
	}

	public unsafe float cameraScrollSensitive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScrollSensitive);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraScrollSensitive)) = num;
		}
	}

	public unsafe float EyeMaskCameraFarClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskCameraFarClip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskCameraFarClip)) = num;
		}
	}

	public unsafe float NormalCameraFarClip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCameraFarClip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalCameraFarClip)) = num;
		}
	}

	public unsafe Color EyeMaskFogColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogColor)) = color;
		}
	}

	public unsafe float EyeMaskFogNear
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogNear);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogNear)) = num;
		}
	}

	public unsafe float EyeMaskFogFar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogFar);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogFar)) = num;
		}
	}

	public unsafe float EyeMaskFogDensity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogDensity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeMaskFogDensity)) = num;
		}
	}

	public unsafe float playerCrouchSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCrouchSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerCrouchSpeed)) = num;
		}
	}

	public unsafe float playerWalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerWalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerWalkSpeed)) = num;
		}
	}

	public unsafe float PlayerGamanWalkSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerGamanWalkSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerGamanWalkSpeed)) = num;
		}
	}

	public unsafe float playerJogSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerJogSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerJogSpeed)) = num;
		}
	}

	public unsafe float playerMaxStamina
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMaxStamina);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerMaxStamina)) = num;
		}
	}

	public unsafe float playerStaminaRegeneration
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStaminaRegeneration);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStaminaRegeneration)) = num;
		}
	}

	public unsafe float playerStaminaRegenerateSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStaminaRegenerateSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerStaminaRegenerateSecond)) = num;
		}
	}

	public unsafe float PlayerStaminaDashPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerStaminaDashPerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerStaminaDashPerSecond)) = num;
		}
	}

	public unsafe float pulseMentalReduce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseMentalReduce);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pulseMentalReduce)) = num;
		}
	}

	public unsafe float dotMentalExpose
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotMentalExpose);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotMentalExpose)) = num;
		}
	}

	public unsafe float dotMentalWatched
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotMentalWatched);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dotMentalWatched)) = num;
		}
	}

	public unsafe float EquipLoadoutMotionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquipLoadoutMotionTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EquipLoadoutMotionTime)) = num;
		}
	}

	public unsafe DynamicBoneData SmallOppai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmallOppai);
			return *(DynamicBoneData*)num;
		}
		set
		{
			*(DynamicBoneData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmallOppai)) = dynamicBoneData;
		}
	}

	public unsafe DynamicBoneData FreeOppai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FreeOppai);
			return *(DynamicBoneData*)num;
		}
		set
		{
			*(DynamicBoneData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FreeOppai)) = dynamicBoneData;
		}
	}

	public unsafe DynamicBoneData BigOppai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigOppai);
			return *(DynamicBoneData*)num;
		}
		set
		{
			*(DynamicBoneData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BigOppai)) = dynamicBoneData;
		}
	}

	public unsafe DynamicBoneData BraOppai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BraOppai);
			return *(DynamicBoneData*)num;
		}
		set
		{
			*(DynamicBoneData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BraOppai)) = dynamicBoneData;
		}
	}

	public unsafe DynamicBoneData ClothesOppai
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesOppai);
			return *(DynamicBoneData*)num;
		}
		set
		{
			*(DynamicBoneData*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesOppai)) = dynamicBoneData;
		}
	}

	public unsafe bool IsControlOppaiByInspector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsControlOppaiByInspector);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsControlOppaiByInspector)) = flag;
		}
	}

	public unsafe float DampingBigBreastScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DampingBigBreastScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DampingBigBreastScale)) = num;
		}
	}

	public unsafe float ElasBigBreastScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElasBigBreastScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ElasBigBreastScale)) = num;
		}
	}

	public unsafe float BraStiff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BraStiff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BraStiff)) = num;
		}
	}

	public unsafe float ClothStiff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothStiff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothStiff)) = num;
		}
	}

	public unsafe int ChangeHairPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeHairPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeHairPrice)) = num;
		}
	}

	public unsafe int ChangeHairColorPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeHairColorPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChangeHairColorPrice)) = num;
		}
	}

	public unsafe int WashingPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashingPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashingPrice)) = num;
		}
	}

	public unsafe int WaterPrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaterPrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaterPrice)) = num;
		}
	}

	public unsafe int VibeRemoconReinforcePrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconReinforcePrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconReinforcePrice)) = num;
		}
	}

	public unsafe int DroneReinforcePrice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneReinforcePrice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneReinforcePrice)) = num;
		}
	}

	public unsafe float AttachHandcuffsTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachHandcuffsTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AttachHandcuffsTime)) = num;
		}
	}

	public unsafe float HandcuffsSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsSpeed)) = num;
		}
	}

	public unsafe float HandcuffsProbability
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsProbability);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsProbability)) = num;
		}
	}

	public unsafe float HandcuffsAddProbabilityByFailure
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsAddProbabilityByFailure);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandcuffsAddProbabilityByFailure)) = num;
		}
	}

	public unsafe float DokidokiOpenFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenFront)) = num;
		}
	}

	public unsafe float DokidokiOpenUpper
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenUpper);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenUpper)) = num;
		}
	}

	public unsafe float DokidokiDropClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropClothes);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropClothes)) = num;
		}
	}

	public unsafe float DokidokiOpenHip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenHip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiOpenHip)) = num;
		}
	}

	public unsafe float DokidokiDropBra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropBra);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropBra)) = num;
		}
	}

	public unsafe float DokidokiDropPants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropPants);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiDropPants)) = num;
		}
	}

	public unsafe float DokidokiLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiLight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiLight)) = num;
		}
	}

	public unsafe float DokidokiAdultGoodsUpperLimit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiAdultGoodsUpperLimit);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiAdultGoodsUpperLimit)) = num;
		}
	}

	public unsafe float DokidokiPee
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiPee);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiPee)) = num;
		}
	}

	public unsafe float StrangeExposeFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeFront)) = num;
		}
	}

	public unsafe float StrangeExposeUpperFromFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeUpperFromFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeUpperFromFront)) = num;
		}
	}

	public unsafe float StrangeExposeUpperFromBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeUpperFromBack);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeUpperFromBack)) = num;
		}
	}

	public unsafe float StrangeExposeHip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeHip);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeHip)) = num;
		}
	}

	public unsafe float StrangeExposeAll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeAll);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeExposeAll)) = num;
		}
	}

	public unsafe float StrangeVibratorLow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeVibratorLow);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeVibratorLow)) = num;
		}
	}

	public unsafe float StrangeVibratorHigh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeVibratorHigh);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeVibratorHigh)) = num;
		}
	}

	public unsafe float ListenNoisyDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenNoisyDist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ListenNoisyDist)) = num;
		}
	}

	public unsafe float MaxFoundDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxFoundDist);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxFoundDist)) = num;
		}
	}

	public unsafe float StrangeLookAt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeLookAt);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StrangeLookAt)) = num;
		}
	}

	public unsafe int NoPantsRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoPantsRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoPantsRpBonus)) = num;
		}
	}

	public unsafe int NoBraRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoBraRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NoBraRpBonus)) = num;
		}
	}

	public unsafe int ClothesDistanceRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDistanceRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesDistanceRpBonus)) = num;
		}
	}

	public unsafe int DaytimeRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DaytimeRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DaytimeRpBonus)) = num;
		}
	}

	public unsafe int NearNpcPerOneRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcPerOneRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NearNpcPerOneRpBonus)) = num;
		}
	}

	public unsafe int LightRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LightRpBonus)) = num;
		}
	}

	public unsafe int ExposeFrontRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeFrontRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeFrontRpBonus)) = num;
		}
	}

	public unsafe int ExposeUpperRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeUpperRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeUpperRpBonus)) = num;
		}
	}

	public unsafe int ExposeAllRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeAllRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeAllRpBonus)) = num;
		}
	}

	public unsafe int ExposeHipRpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeHipRpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExposeHipRpBonus)) = num;
		}
	}

	public unsafe Il2CppStructArray<Color> RpBonusColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusColor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Color> RpBonusColorSecondary
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusColorSecondary);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonusColorSecondary), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int WashingSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashingSecond);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WashingSecond)) = num;
		}
	}

	public unsafe float AddMoistureWater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddMoistureWater);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddMoistureWater)) = num;
		}
	}

	public unsafe float TransMoisturePerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransMoisturePerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TransMoisturePerSecond)) = num;
		}
	}

	public unsafe float PeeAbleMoistureThreshold
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeAbleMoistureThreshold);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeAbleMoistureThreshold)) = num;
		}
	}

	public unsafe float PeeMotionSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeMotionSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeMotionSecond)) = num;
		}
	}

	public unsafe float AddMissionSatisfyPerSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddMissionSatisfyPerSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AddMissionSatisfyPerSecond)) = num;
		}
	}

	public unsafe Vector3 ApartAutoDropPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApartAutoDropPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApartAutoDropPosition)) = vector;
		}
	}

	public unsafe static MCommon instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MCommon>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static float BaseCameraSensitive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68666, XrefRangeEnd = 68667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BaseCameraSensitive_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float CameraScrollSensitive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68667, XrefRangeEnd = 68668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CameraScrollSensitive_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerCrouchSpeed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68668, XrefRangeEnd = 68669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerCrouchSpeed_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerWalkSpeed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68669, XrefRangeEnd = 68670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerWalkSpeed_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerJogSpeed
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68670, XrefRangeEnd = 68671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerJogSpeed_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerMaxStamina
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68671, XrefRangeEnd = 68672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerMaxStamina_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerStaminaRegeneration
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68672, XrefRangeEnd = 68673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerStaminaRegeneration_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PlayerStaminaRegenerateSecond
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68673, XrefRangeEnd = 68674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PlayerStaminaRegenerateSecond_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float DotMentalWatched
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68674, XrefRangeEnd = 68675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DotMentalWatched_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float DotMentalExpose
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68675, XrefRangeEnd = 68676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DotMentalExpose_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static float PulseMentalReduce
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68676, XrefRangeEnd = 68677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PulseMentalReduce_Public_Static_get_Single_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe static MCommon Instance
	{
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 68693, RefRangeEnd = 68790, XrefRangeStart = 68677, XrefRangeEnd = 68693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MCommon_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCommon>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68790, XrefRangeEnd = 68791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MCommon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCommon>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MCommon()
	{
		Il2CppClassPointerStore<MCommon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Common", "MCommon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCommon>.NativeClassPtr);
		NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "a");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "b");
		NativeFieldInfoPtr_c = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "c");
		NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "d");
		NativeFieldInfoPtr_baseCameraSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "baseCameraSensitive");
		NativeFieldInfoPtr_cameraScrollSensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "cameraScrollSensitive");
		NativeFieldInfoPtr_EyeMaskCameraFarClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EyeMaskCameraFarClip");
		NativeFieldInfoPtr_NormalCameraFarClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "NormalCameraFarClip");
		NativeFieldInfoPtr_EyeMaskFogColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EyeMaskFogColor");
		NativeFieldInfoPtr_EyeMaskFogNear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EyeMaskFogNear");
		NativeFieldInfoPtr_EyeMaskFogFar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EyeMaskFogFar");
		NativeFieldInfoPtr_EyeMaskFogDensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EyeMaskFogDensity");
		NativeFieldInfoPtr_playerCrouchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerCrouchSpeed");
		NativeFieldInfoPtr_playerWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerWalkSpeed");
		NativeFieldInfoPtr_PlayerGamanWalkSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "PlayerGamanWalkSpeed");
		NativeFieldInfoPtr_playerJogSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerJogSpeed");
		NativeFieldInfoPtr_playerMaxStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerMaxStamina");
		NativeFieldInfoPtr_playerStaminaRegeneration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerStaminaRegeneration");
		NativeFieldInfoPtr_playerStaminaRegenerateSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "playerStaminaRegenerateSecond");
		NativeFieldInfoPtr_PlayerStaminaDashPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "PlayerStaminaDashPerSecond");
		NativeFieldInfoPtr_pulseMentalReduce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "pulseMentalReduce");
		NativeFieldInfoPtr_dotMentalExpose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "dotMentalExpose");
		NativeFieldInfoPtr_dotMentalWatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "dotMentalWatched");
		NativeFieldInfoPtr_EquipLoadoutMotionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "EquipLoadoutMotionTime");
		NativeFieldInfoPtr_SmallOppai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "SmallOppai");
		NativeFieldInfoPtr_FreeOppai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "FreeOppai");
		NativeFieldInfoPtr_BigOppai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "BigOppai");
		NativeFieldInfoPtr_BraOppai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "BraOppai");
		NativeFieldInfoPtr_ClothesOppai = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ClothesOppai");
		NativeFieldInfoPtr_IsControlOppaiByInspector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "IsControlOppaiByInspector");
		NativeFieldInfoPtr_DampingBigBreastScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DampingBigBreastScale");
		NativeFieldInfoPtr_ElasBigBreastScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ElasBigBreastScale");
		NativeFieldInfoPtr_BraStiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "BraStiff");
		NativeFieldInfoPtr_ClothStiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ClothStiff");
		NativeFieldInfoPtr_ChangeHairPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ChangeHairPrice");
		NativeFieldInfoPtr_ChangeHairColorPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ChangeHairColorPrice");
		NativeFieldInfoPtr_WashingPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "WashingPrice");
		NativeFieldInfoPtr_WaterPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "WaterPrice");
		NativeFieldInfoPtr_VibeRemoconReinforcePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "VibeRemoconReinforcePrice");
		NativeFieldInfoPtr_DroneReinforcePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DroneReinforcePrice");
		NativeFieldInfoPtr_AttachHandcuffsTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "AttachHandcuffsTime");
		NativeFieldInfoPtr_HandcuffsSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "HandcuffsSpeed");
		NativeFieldInfoPtr_HandcuffsProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "HandcuffsProbability");
		NativeFieldInfoPtr_HandcuffsAddProbabilityByFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "HandcuffsAddProbabilityByFailure");
		NativeFieldInfoPtr_DokidokiOpenFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiOpenFront");
		NativeFieldInfoPtr_DokidokiOpenUpper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiOpenUpper");
		NativeFieldInfoPtr_DokidokiDropClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiDropClothes");
		NativeFieldInfoPtr_DokidokiOpenHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiOpenHip");
		NativeFieldInfoPtr_DokidokiDropBra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiDropBra");
		NativeFieldInfoPtr_DokidokiDropPants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiDropPants");
		NativeFieldInfoPtr_DokidokiLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiLight");
		NativeFieldInfoPtr_DokidokiAdultGoodsUpperLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiAdultGoodsUpperLimit");
		NativeFieldInfoPtr_DokidokiPee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DokidokiPee");
		NativeFieldInfoPtr_StrangeExposeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeExposeFront");
		NativeFieldInfoPtr_StrangeExposeUpperFromFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeExposeUpperFromFront");
		NativeFieldInfoPtr_StrangeExposeUpperFromBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeExposeUpperFromBack");
		NativeFieldInfoPtr_StrangeExposeHip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeExposeHip");
		NativeFieldInfoPtr_StrangeExposeAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeExposeAll");
		NativeFieldInfoPtr_StrangeVibratorLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeVibratorLow");
		NativeFieldInfoPtr_StrangeVibratorHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeVibratorHigh");
		NativeFieldInfoPtr_ListenNoisyDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ListenNoisyDist");
		NativeFieldInfoPtr_MaxFoundDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "MaxFoundDist");
		NativeFieldInfoPtr_StrangeLookAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "StrangeLookAt");
		NativeFieldInfoPtr_NoPantsRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "NoPantsRpBonus");
		NativeFieldInfoPtr_NoBraRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "NoBraRpBonus");
		NativeFieldInfoPtr_ClothesDistanceRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ClothesDistanceRpBonus");
		NativeFieldInfoPtr_DaytimeRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "DaytimeRpBonus");
		NativeFieldInfoPtr_NearNpcPerOneRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "NearNpcPerOneRpBonus");
		NativeFieldInfoPtr_LightRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "LightRpBonus");
		NativeFieldInfoPtr_ExposeFrontRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ExposeFrontRpBonus");
		NativeFieldInfoPtr_ExposeUpperRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ExposeUpperRpBonus");
		NativeFieldInfoPtr_ExposeAllRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ExposeAllRpBonus");
		NativeFieldInfoPtr_ExposeHipRpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ExposeHipRpBonus");
		NativeFieldInfoPtr_RpBonusColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "RpBonusColor");
		NativeFieldInfoPtr_RpBonusColorSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "RpBonusColorSecondary");
		NativeFieldInfoPtr_WashingSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "WashingSecond");
		NativeFieldInfoPtr_AddMoistureWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "AddMoistureWater");
		NativeFieldInfoPtr_TransMoisturePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "TransMoisturePerSecond");
		NativeFieldInfoPtr_PeeAbleMoistureThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "PeeAbleMoistureThreshold");
		NativeFieldInfoPtr_PeeMotionSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "PeeMotionSecond");
		NativeFieldInfoPtr_AddMissionSatisfyPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "AddMissionSatisfyPerSecond");
		NativeFieldInfoPtr_ApartAutoDropPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "ApartAutoDropPosition");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCommon>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_get_BaseCameraSensitive_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668190);
		NativeMethodInfoPtr_get_CameraScrollSensitive_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668191);
		NativeMethodInfoPtr_get_PlayerCrouchSpeed_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668192);
		NativeMethodInfoPtr_get_PlayerWalkSpeed_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668193);
		NativeMethodInfoPtr_get_PlayerJogSpeed_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668194);
		NativeMethodInfoPtr_get_PlayerMaxStamina_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668195);
		NativeMethodInfoPtr_get_PlayerStaminaRegeneration_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668196);
		NativeMethodInfoPtr_get_PlayerStaminaRegenerateSecond_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668197);
		NativeMethodInfoPtr_get_DotMentalWatched_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668198);
		NativeMethodInfoPtr_get_DotMentalExpose_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668199);
		NativeMethodInfoPtr_get_PulseMentalReduce_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668200);
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MCommon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668201);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCommon>.NativeClassPtr, 100668202);
	}

	public MCommon(IntPtr pointer)
		: base(pointer)
	{
	}
}
