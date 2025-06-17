using System;
using System.Runtime.CompilerServices;
using Common.Scripts.UI;
using ExposureUnnoticed2.Master.Achievement;
using ExposureUnnoticed2.Master.Action;
using ExposureUnnoticed2.Master.AdultGoods;
using ExposureUnnoticed2.Master.BodyPaint;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Common;
using ExposureUnnoticed2.Master.Conversation;
using ExposureUnnoticed2.Master.Cosplay;
using ExposureUnnoticed2.Master.Costume;
using ExposureUnnoticed2.Master.DroneMission;
using ExposureUnnoticed2.Master.FastTravel;
using ExposureUnnoticed2.Master.Hair;
using ExposureUnnoticed2.Master.Item;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Master.Pants;
using ExposureUnnoticed2.Master.Rank;
using ExposureUnnoticed2.Master.RankRelease;
using ExposureUnnoticed2.Master.ReinforceEffect;
using ExposureUnnoticed2.Master.Sex;
using ExposureUnnoticed2.Master.Skill;
using ExposureUnnoticed2.Master.Skill.SkillMaxAccessoryNum;
using ExposureUnnoticed2.Master.Skill.SkillMental;
using ExposureUnnoticed2.Master.Skill.SkillSlow;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.ObjectUI.BarberMenu;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.IngameManager;

public class AssetReferencer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_MStage;

	private static readonly IntPtr NativeFieldInfoPtr_MCommon;

	private static readonly IntPtr NativeFieldInfoPtr_MCustomizeColor;

	private static readonly IntPtr NativeFieldInfoPtr_MClothes;

	private static readonly IntPtr NativeFieldInfoPtr_MSkill;

	private static readonly IntPtr NativeFieldInfoPtr_MSex;

	private static readonly IntPtr NativeFieldInfoPtr_MAction;

	private static readonly IntPtr NativeFieldInfoPtr_MConversation;

	private static readonly IntPtr NativeFieldInfoPtr_mAdultGoods;

	private static readonly IntPtr NativeFieldInfoPtr_MHair;

	private static readonly IntPtr NativeFieldInfoPtr_MItem;

	private static readonly IntPtr NativeFieldInfoPtr_MMission;

	private static readonly IntPtr NativeFieldInfoPtr_MRank;

	private static readonly IntPtr NativeFieldInfoPtr_MRankRelease;

	private static readonly IntPtr NativeFieldInfoPtr_MCostume;

	private static readonly IntPtr NativeFieldInfoPtr_MDroneMission;

	private static readonly IntPtr NativeFieldInfoPtr_MSkillSlow;

	private static readonly IntPtr NativeFieldInfoPtr_MSkillStamina;

	private static readonly IntPtr NativeFieldInfoPtr_MSkillMental;

	private static readonly IntPtr NativeFieldInfoPtr_MCosplay;

	private static readonly IntPtr NativeFieldInfoPtr_MReinforceEffect;

	private static readonly IntPtr NativeFieldInfoPtr_MFastTravel;

	private static readonly IntPtr NativeFieldInfoPtr_MSkillMaxAccessoryNum;

	private static readonly IntPtr NativeFieldInfoPtr_MPants;

	private static readonly IntPtr NativeFieldInfoPtr_MBra;

	private static readonly IntPtr NativeFieldInfoPtr_MAchievement;

	private static readonly IntPtr NativeFieldInfoPtr_MBodyPaint;

	private static readonly IntPtr NativeFieldInfoPtr_FadePanel;

	private static readonly IntPtr NativeFieldInfoPtr_StageNamePanelView;

	private static readonly IntPtr NativeFieldInfoPtr_InGameSystemMenuView;

	private static readonly IntPtr NativeFieldInfoPtr_NpcUiView;

	private static readonly IntPtr NativeFieldInfoPtr_MissionFailedPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SaveDataSelectPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SkillPanel;

	private static readonly IntPtr NativeFieldInfoPtr_BuyPanel;

	private static readonly IntPtr NativeFieldInfoPtr_InteractMenuPanel;

	private static readonly IntPtr NativeFieldInfoPtr_TryClothesPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ConversationPanel;

	private static readonly IntPtr NativeFieldInfoPtr_InventoryPanel;

	private static readonly IntPtr NativeFieldInfoPtr_BarberMenu;

	private static readonly IntPtr NativeFieldInfoPtr_CommonPopup;

	private static readonly IntPtr NativeFieldInfoPtr_ClosetMenu;

	private static readonly IntPtr NativeFieldInfoPtr_SleepBlackPanel;

	private static readonly IntPtr NativeFieldInfoPtr_MissionMenuPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ChooseHandcuffsPanel;

	private static readonly IntPtr NativeFieldInfoPtr_RankConfirmPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SleepSelectPanel;

	private static readonly IntPtr NativeFieldInfoPtr_PcMenuPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ManualSavePanel;

	private static readonly IntPtr NativeFieldInfoPtr_SystemMenu;

	private static readonly IntPtr NativeFieldInfoPtr_OptionMenu;

	private static readonly IntPtr NativeFieldInfoPtr_GraphicsPanel;

	private static readonly IntPtr NativeFieldInfoPtr_InGameMenu;

	private static readonly IntPtr NativeFieldInfoPtr_DroneMissionPanel;

	private static readonly IntPtr NativeFieldInfoPtr_VibeRemoconReinforcePanel;

	private static readonly IntPtr NativeFieldInfoPtr_DroneReinforcePanel;

	private static readonly IntPtr NativeFieldInfoPtr_BuffPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SelectSexualityTypePanel;

	private static readonly IntPtr NativeFieldInfoPtr_SkillSwitchPanel;

	private static readonly IntPtr NativeFieldInfoPtr_OnlineShopPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ReinforcePanel;

	private static readonly IntPtr NativeFieldInfoPtr_FastTravelPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SelectDifficultyPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SelectSexOptionPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ChooseDildoPanel;

	private static readonly IntPtr NativeFieldInfoPtr_KillTimeWaitPanel;

	private static readonly IntPtr NativeFieldInfoPtr_WaitPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ResultPanel;

	private static readonly IntPtr NativeFieldInfoPtr_AchievementPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ChooseHandcuffsTimerPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ApplyGraphicsCountDownPopup;

	private static readonly IntPtr NativeFieldInfoPtr_TutorialPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ColorSettingPanel;

	private static readonly IntPtr NativeFieldInfoPtr_ChooseLanguagePanel;

	private static readonly IntPtr NativeFieldInfoPtr_SexMenuPanel;

	private static readonly IntPtr NativeFieldInfoPtr_SweatBody;

	private static readonly IntPtr NativeFieldInfoPtr_Inmon;

	private static readonly IntPtr NativeFieldInfoPtr_Rakugaki;

	private static readonly IntPtr NativeFieldInfoPtr_ClothesPaint;

	private static readonly IntPtr NativeFieldInfoPtr_TattooDark;

	private static readonly IntPtr NativeFieldInfoPtr_TattooFlower1;

	private static readonly IntPtr NativeFieldInfoPtr_TattooFlower2;

	private static readonly IntPtr NativeFieldInfoPtr_TattooLotus;

	private static readonly IntPtr NativeFieldInfoPtr_TattooSatanism;

	private static readonly IntPtr NativeFieldInfoPtr_TattooSlave;

	private static readonly IntPtr NativeFieldInfoPtr_RubberSuit;

	private static readonly IntPtr NativeFieldInfoPtr_FutanariPaint;

	private static readonly IntPtr NativeFieldInfoPtr_NightSpermDecal;

	private static readonly IntPtr NativeFieldInfoPtr_FutanariMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_FutanariRubberMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_Fresnel;

	private static readonly IntPtr NativeFieldInfoPtr_RubberSuitBlack;

	private static readonly IntPtr NativeFieldInfoPtr_RubberSuitWhite;

	private static readonly IntPtr NativeFieldInfoPtr_DroppedPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_MultipleDroppedPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_HoldInHandClothesPrefabs;

	private static readonly IntPtr NativeFieldInfoPtr_SpermBullet;

	private static readonly IntPtr NativeFieldInfoPtr_SpermDecal;

	private static readonly IntPtr NativeFieldInfoPtr_Player;

	private static readonly IntPtr NativeFieldInfoPtr_UiPlayer;

	private static readonly IntPtr NativeFieldInfoPtr_fontKr;

	private static readonly IntPtr NativeFieldInfoPtr_fontSc;

	private static readonly IntPtr NativeFieldInfoPtr_fontTc;

	private static readonly IntPtr NativeFieldInfoPtr_defaultFont;

	private static readonly IntPtr NativeFieldInfoPtr_fontMaterials;

	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MStage MStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MStage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MStage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MStage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MCommon MCommon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCommon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCommon>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCommon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MCustomizeColor MCustomizeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCustomizeColor);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCustomizeColor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCustomizeColor), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MClothes MClothes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MClothes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothes>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MClothes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSkill MSkill
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkill);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSkill>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkill), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSex MSex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSex);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSex>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSex), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MAction MAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAction);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MAction>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAction), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MConversation MConversation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MConversation);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MConversation>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MConversation), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MAdultGoods mAdultGoods
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAdultGoods);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MAdultGoods>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mAdultGoods), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MHair MHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MHair);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MHair>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MHair), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MItem MItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MItem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MMission MMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MMission);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MMission>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MMission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MRank MRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MRank);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MRank>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MRank), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MRankRelease MRankRelease
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MRankRelease);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MRankRelease>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MRankRelease), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MCostume MCostume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCostume);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCostume>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCostume), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MDroneMission MDroneMission
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDroneMission);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MDroneMission>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MDroneMission), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSkillSlow MSkillSlow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillSlow);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSkillSlow>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillSlow), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSkillStamina MSkillStamina
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillStamina);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSkillStamina>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillStamina), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSkillMental MSkillMental
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillMental);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSkillMental>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillMental), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MCosplay MCosplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCosplay);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCosplay>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MCosplay), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MReinforceEffect MReinforceEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MReinforceEffect);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MReinforceEffect>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MReinforceEffect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MFastTravel MFastTravel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MFastTravel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MFastTravel>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MFastTravel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MSkillMaxAccessoryNum MSkillMaxAccessoryNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillMaxAccessoryNum);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MSkillMaxAccessoryNum>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSkillMaxAccessoryNum), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MPants MPants
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MPants);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MPants>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MPants), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MBra MBra
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MBra);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MBra>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MBra), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MAchievement MAchievement
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAchievement);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MAchievement>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MAchievement), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MBodyPaint MBodyPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MBodyPaint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MBodyPaint>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MBodyPaint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject FadePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FadePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject StageNamePanelView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageNamePanelView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageNamePanelView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject InGameSystemMenuView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InGameSystemMenuView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InGameSystemMenuView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject NpcUiView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcUiView);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcUiView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MissionFailedPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionFailedPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionFailedPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SaveDataSelectPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveDataSelectPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SaveDataSelectPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SkillPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView BuyPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuyPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuyPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView InteractMenuPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractMenuPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractMenuPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView TryClothesPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TryClothesPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TryClothesPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject ConversationPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConversationPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConversationPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView InventoryPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InventoryPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InventoryPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BarberMenuView BarberMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BarberMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BarberMenuView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BarberMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView CommonPopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommonPopup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CommonPopup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ClosetMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosetMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClosetMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SleepBlackPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SleepBlackPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SleepBlackPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView MissionMenuPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMenuPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionMenuPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ChooseHandcuffsPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseHandcuffsPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseHandcuffsPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView RankConfirmPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankConfirmPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RankConfirmPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SleepSelectPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SleepSelectPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SleepSelectPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView PcMenuPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PcMenuPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PcMenuPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ManualSavePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualSavePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualSavePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SystemMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SystemMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView OptionMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptionMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OptionMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView GraphicsPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphicsPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GraphicsPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView InGameMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InGameMenu);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InGameMenu), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView DroneMissionPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneMissionPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView VibeRemoconReinforcePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconReinforcePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeRemoconReinforcePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView DroneReinforcePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneReinforcePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroneReinforcePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView BuffPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuffPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuffPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SelectSexualityTypePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSexualityTypePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSexualityTypePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SkillSwitchPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillSwitchPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkillSwitchPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView OnlineShopPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlineShopPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnlineShopPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ReinforcePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforcePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforcePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView FastTravelPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FastTravelPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FastTravelPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SelectDifficultyPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectDifficultyPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectDifficultyPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SelectSexOptionPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSexOptionPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SelectSexOptionPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ChooseDildoPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseDildoPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseDildoPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView KillTimeWaitPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KillTimeWaitPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KillTimeWaitPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView WaitPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ResultPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResultPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ResultPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView AchievementPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AchievementPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ChooseHandcuffsTimerPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseHandcuffsTimerPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseHandcuffsTimerPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ApplyGraphicsCountDownPopup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApplyGraphicsCountDownPopup);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ApplyGraphicsCountDownPopup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView TutorialPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TutorialPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TutorialPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ColorSettingPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorSettingPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorSettingPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView ChooseLanguagePanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseLanguagePanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ChooseLanguagePanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe BasePanelView SexMenuPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SexMenuPanel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<BasePanelView>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SexMenuPanel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material SweatBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SweatBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SweatBody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material Inmon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inmon);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Inmon), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material Rakugaki
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rakugaki);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rakugaki), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material ClothesPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesPaint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesPaint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooDark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooDark);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooDark), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooFlower1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooFlower1);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooFlower1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooFlower2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooFlower2);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooFlower2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooLotus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooLotus);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooLotus), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooSatanism
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooSatanism);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooSatanism), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material TattooSlave
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooSlave);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TattooSlave), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material RubberSuit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuit);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuit), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material FutanariPaint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariPaint);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariPaint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material NightSpermDecal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NightSpermDecal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NightSpermDecal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material FutanariMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material FutanariRubberMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariRubberMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariRubberMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material Fresnel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fresnel);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Fresnel), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture RubberSuitBlack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuitBlack);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuitBlack), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture RubberSuitWhite
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuitWhite);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RubberSuitWhite), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> DroppedPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroppedPrefabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DroppedPrefabs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> MultipleDroppedPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MultipleDroppedPrefabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MultipleDroppedPrefabs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> HoldInHandClothesPrefabs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldInHandClothesPrefabs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HoldInHandClothesPrefabs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject SpermBullet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermBullet);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermBullet), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject SpermDecal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermDecal);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermDecal), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Player);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject UiPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UiPlayer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UiPlayer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TMP_FontAsset fontKr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontKr);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontKr), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TMP_FontAsset fontSc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSc);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontSc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TMP_FontAsset fontTc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontTc);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontTc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TMP_FontAsset defaultFont
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFont);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TMP_FontAsset>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultFont), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Material> fontMaterials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontMaterials);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fontMaterials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static AssetReferencer Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<AssetReferencer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 65567, XrefRangeEnd = 65585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssetReferencer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static AssetReferencer()
	{
		Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.IngameManager", "AssetReferencer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr);
		NativeFieldInfoPtr_MStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MStage");
		NativeFieldInfoPtr_MCommon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MCommon");
		NativeFieldInfoPtr_MCustomizeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MCustomizeColor");
		NativeFieldInfoPtr_MClothes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MClothes");
		NativeFieldInfoPtr_MSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSkill");
		NativeFieldInfoPtr_MSex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSex");
		NativeFieldInfoPtr_MAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MAction");
		NativeFieldInfoPtr_MConversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MConversation");
		NativeFieldInfoPtr_mAdultGoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "mAdultGoods");
		NativeFieldInfoPtr_MHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MHair");
		NativeFieldInfoPtr_MItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MItem");
		NativeFieldInfoPtr_MMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MMission");
		NativeFieldInfoPtr_MRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MRank");
		NativeFieldInfoPtr_MRankRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MRankRelease");
		NativeFieldInfoPtr_MCostume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MCostume");
		NativeFieldInfoPtr_MDroneMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MDroneMission");
		NativeFieldInfoPtr_MSkillSlow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSkillSlow");
		NativeFieldInfoPtr_MSkillStamina = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSkillStamina");
		NativeFieldInfoPtr_MSkillMental = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSkillMental");
		NativeFieldInfoPtr_MCosplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MCosplay");
		NativeFieldInfoPtr_MReinforceEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MReinforceEffect");
		NativeFieldInfoPtr_MFastTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MFastTravel");
		NativeFieldInfoPtr_MSkillMaxAccessoryNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MSkillMaxAccessoryNum");
		NativeFieldInfoPtr_MPants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MPants");
		NativeFieldInfoPtr_MBra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MBra");
		NativeFieldInfoPtr_MAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MAchievement");
		NativeFieldInfoPtr_MBodyPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MBodyPaint");
		NativeFieldInfoPtr_FadePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "FadePanel");
		NativeFieldInfoPtr_StageNamePanelView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "StageNamePanelView");
		NativeFieldInfoPtr_InGameSystemMenuView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "InGameSystemMenuView");
		NativeFieldInfoPtr_NpcUiView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "NpcUiView");
		NativeFieldInfoPtr_MissionFailedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MissionFailedPanel");
		NativeFieldInfoPtr_SaveDataSelectPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SaveDataSelectPanel");
		NativeFieldInfoPtr_SkillPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SkillPanel");
		NativeFieldInfoPtr_BuyPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "BuyPanel");
		NativeFieldInfoPtr_InteractMenuPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "InteractMenuPanel");
		NativeFieldInfoPtr_TryClothesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TryClothesPanel");
		NativeFieldInfoPtr_ConversationPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ConversationPanel");
		NativeFieldInfoPtr_InventoryPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "InventoryPanel");
		NativeFieldInfoPtr_BarberMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "BarberMenu");
		NativeFieldInfoPtr_CommonPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "CommonPopup");
		NativeFieldInfoPtr_ClosetMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ClosetMenu");
		NativeFieldInfoPtr_SleepBlackPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SleepBlackPanel");
		NativeFieldInfoPtr_MissionMenuPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MissionMenuPanel");
		NativeFieldInfoPtr_ChooseHandcuffsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ChooseHandcuffsPanel");
		NativeFieldInfoPtr_RankConfirmPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "RankConfirmPanel");
		NativeFieldInfoPtr_SleepSelectPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SleepSelectPanel");
		NativeFieldInfoPtr_PcMenuPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "PcMenuPanel");
		NativeFieldInfoPtr_ManualSavePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ManualSavePanel");
		NativeFieldInfoPtr_SystemMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SystemMenu");
		NativeFieldInfoPtr_OptionMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "OptionMenu");
		NativeFieldInfoPtr_GraphicsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "GraphicsPanel");
		NativeFieldInfoPtr_InGameMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "InGameMenu");
		NativeFieldInfoPtr_DroneMissionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "DroneMissionPanel");
		NativeFieldInfoPtr_VibeRemoconReinforcePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "VibeRemoconReinforcePanel");
		NativeFieldInfoPtr_DroneReinforcePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "DroneReinforcePanel");
		NativeFieldInfoPtr_BuffPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "BuffPanel");
		NativeFieldInfoPtr_SelectSexualityTypePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SelectSexualityTypePanel");
		NativeFieldInfoPtr_SkillSwitchPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SkillSwitchPanel");
		NativeFieldInfoPtr_OnlineShopPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "OnlineShopPanel");
		NativeFieldInfoPtr_ReinforcePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ReinforcePanel");
		NativeFieldInfoPtr_FastTravelPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "FastTravelPanel");
		NativeFieldInfoPtr_SelectDifficultyPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SelectDifficultyPanel");
		NativeFieldInfoPtr_SelectSexOptionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SelectSexOptionPanel");
		NativeFieldInfoPtr_ChooseDildoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ChooseDildoPanel");
		NativeFieldInfoPtr_KillTimeWaitPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "KillTimeWaitPanel");
		NativeFieldInfoPtr_WaitPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "WaitPanel");
		NativeFieldInfoPtr_ResultPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ResultPanel");
		NativeFieldInfoPtr_AchievementPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "AchievementPanel");
		NativeFieldInfoPtr_ChooseHandcuffsTimerPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ChooseHandcuffsTimerPanel");
		NativeFieldInfoPtr_ApplyGraphicsCountDownPopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ApplyGraphicsCountDownPopup");
		NativeFieldInfoPtr_TutorialPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TutorialPanel");
		NativeFieldInfoPtr_ColorSettingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ColorSettingPanel");
		NativeFieldInfoPtr_ChooseLanguagePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ChooseLanguagePanel");
		NativeFieldInfoPtr_SexMenuPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SexMenuPanel");
		NativeFieldInfoPtr_SweatBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SweatBody");
		NativeFieldInfoPtr_Inmon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "Inmon");
		NativeFieldInfoPtr_Rakugaki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "Rakugaki");
		NativeFieldInfoPtr_ClothesPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "ClothesPaint");
		NativeFieldInfoPtr_TattooDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooDark");
		NativeFieldInfoPtr_TattooFlower1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooFlower1");
		NativeFieldInfoPtr_TattooFlower2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooFlower2");
		NativeFieldInfoPtr_TattooLotus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooLotus");
		NativeFieldInfoPtr_TattooSatanism = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooSatanism");
		NativeFieldInfoPtr_TattooSlave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "TattooSlave");
		NativeFieldInfoPtr_RubberSuit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "RubberSuit");
		NativeFieldInfoPtr_FutanariPaint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "FutanariPaint");
		NativeFieldInfoPtr_NightSpermDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "NightSpermDecal");
		NativeFieldInfoPtr_FutanariMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "FutanariMaterial");
		NativeFieldInfoPtr_FutanariRubberMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "FutanariRubberMaterial");
		NativeFieldInfoPtr_Fresnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "Fresnel");
		NativeFieldInfoPtr_RubberSuitBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "RubberSuitBlack");
		NativeFieldInfoPtr_RubberSuitWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "RubberSuitWhite");
		NativeFieldInfoPtr_DroppedPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "DroppedPrefabs");
		NativeFieldInfoPtr_MultipleDroppedPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "MultipleDroppedPrefabs");
		NativeFieldInfoPtr_HoldInHandClothesPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "HoldInHandClothesPrefabs");
		NativeFieldInfoPtr_SpermBullet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SpermBullet");
		NativeFieldInfoPtr_SpermDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "SpermDecal");
		NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "Player");
		NativeFieldInfoPtr_UiPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "UiPlayer");
		NativeFieldInfoPtr_fontKr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "fontKr");
		NativeFieldInfoPtr_fontSc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "fontSc");
		NativeFieldInfoPtr_fontTc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "fontTc");
		NativeFieldInfoPtr_defaultFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "defaultFont");
		NativeFieldInfoPtr_fontMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "fontMaterials");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, "Instance");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, 100667772);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferencer>.NativeClassPtr, 100667773);
	}

	public AssetReferencer(IntPtr pointer)
		: base(pointer)
	{
	}
}
