using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.Base;

public static class Events : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_StartTransitionStageEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompleteTransitionStageEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_CursorVisibleEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExitInGameEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameOverEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_FoundStrangerEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillUpEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteractEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeEquipmentEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ConversationEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_BgmControlEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeVibratorLeaderEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeBodyEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeTimeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeShoesEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeCostumeCosplayEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeAdultGoodsEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeSomeEquipEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerSoundEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionCountEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_TimeStopEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeCosplayPartsOptionEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_CostumeFutaShapeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpdateBodyShrinkEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_DynamicBoneInertCancelEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_GraphicsOptionChangeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptionChangeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeWindowModeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_keyOptionChangeEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_ChangeLanguageEvent;

	public unsafe static StartTransitionStageEvent StartTransitionStageEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_StartTransitionStageEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StartTransitionStageEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_StartTransitionStageEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static CompleteTransitionStageEvent CompleteTransitionStageEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CompleteTransitionStageEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CompleteTransitionStageEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CompleteTransitionStageEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static CursorVisibleEvent CursorVisibleEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CursorVisibleEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CursorVisibleEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CursorVisibleEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ExitInGameEvent ExitInGameEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ExitInGameEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExitInGameEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ExitInGameEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GameOverEvent GameOverEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameOverEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameOverEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameOverEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static FoundStrangerEvent FoundStrangerEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FoundStrangerEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<FoundStrangerEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FoundStrangerEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static SkillUpEvent SkillUpEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkillUpEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SkillUpEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkillUpEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static InteractEvent InteractEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InteractEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InteractEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeEquipmentEvent ChangeEquipmentEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeEquipmentEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeEquipmentEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeEquipmentEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ConversationEvent ConversationEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ConversationEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConversationEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ConversationEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static BgmControlEvent BgmControlEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BgmControlEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BgmControlEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BgmControlEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeVibratorLeaderEvent ChangeVibratorLeaderEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeVibratorLeaderEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeVibratorLeaderEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeVibratorLeaderEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeBodyEvent ChangeBodyEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeBodyEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeBodyEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeBodyEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeTimeEvent ChangeTimeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeTimeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeTimeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeTimeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeShoesEvent ChangeShoesEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeShoesEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeShoesEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeShoesEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeCostumeCosplayEvent ChangeCostumeCosplayEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeCostumeCosplayEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeCostumeCosplayEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeCostumeCosplayEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeAdultGoodsEvent ChangeAdultGoodsEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeAdultGoodsEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeAdultGoodsEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeAdultGoodsEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeSomeEquipEvent ChangeSomeEquipEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeSomeEquipEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeSomeEquipEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeSomeEquipEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static PlayerSoundEvent PlayerSoundEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerSoundEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerSoundEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerSoundEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static MissionCountEvent MissionCountEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionCountEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MissionCountEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionCountEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static TimeStopEvent TimeStopEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TimeStopEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TimeStopEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TimeStopEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeCosplayPartsOptionEvent ChangeCosplayPartsOptionEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeCosplayPartsOptionEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeCosplayPartsOptionEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeCosplayPartsOptionEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static CostumeFutaShapeEvent CostumeFutaShapeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CostumeFutaShapeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CostumeFutaShapeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CostumeFutaShapeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static UpdateBodyShrinkEvent UpdateBodyShrinkEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_UpdateBodyShrinkEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<UpdateBodyShrinkEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_UpdateBodyShrinkEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static DynamicBoneInertCancelEvent DynamicBoneInertCancelEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DynamicBoneInertCancelEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicBoneInertCancelEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DynamicBoneInertCancelEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GraphicsOptionChangeEvent GraphicsOptionChangeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GraphicsOptionChangeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GraphicsOptionChangeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GraphicsOptionChangeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static OptionChangeEvent OptionChangeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptionChangeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptionChangeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptionChangeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeWindowModeEvent ChangeWindowModeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeWindowModeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeWindowModeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeWindowModeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static KeyOptionChangeEvent keyOptionChangeEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_keyOptionChangeEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<KeyOptionChangeEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_keyOptionChangeEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static ChangeLanguageEvent ChangeLanguageEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ChangeLanguageEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ChangeLanguageEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ChangeLanguageEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	static Events()
	{
		Il2CppClassPointerStore<Events>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "Events");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events>.NativeClassPtr);
		NativeFieldInfoPtr_StartTransitionStageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "StartTransitionStageEvent");
		NativeFieldInfoPtr_CompleteTransitionStageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "CompleteTransitionStageEvent");
		NativeFieldInfoPtr_CursorVisibleEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "CursorVisibleEvent");
		NativeFieldInfoPtr_ExitInGameEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ExitInGameEvent");
		NativeFieldInfoPtr_GameOverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "GameOverEvent");
		NativeFieldInfoPtr_FoundStrangerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "FoundStrangerEvent");
		NativeFieldInfoPtr_SkillUpEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "SkillUpEvent");
		NativeFieldInfoPtr_InteractEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "InteractEvent");
		NativeFieldInfoPtr_ChangeEquipmentEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeEquipmentEvent");
		NativeFieldInfoPtr_ConversationEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ConversationEvent");
		NativeFieldInfoPtr_BgmControlEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "BgmControlEvent");
		NativeFieldInfoPtr_ChangeVibratorLeaderEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeVibratorLeaderEvent");
		NativeFieldInfoPtr_ChangeBodyEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeBodyEvent");
		NativeFieldInfoPtr_ChangeTimeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeTimeEvent");
		NativeFieldInfoPtr_ChangeShoesEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeShoesEvent");
		NativeFieldInfoPtr_ChangeCostumeCosplayEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeCostumeCosplayEvent");
		NativeFieldInfoPtr_ChangeAdultGoodsEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeAdultGoodsEvent");
		NativeFieldInfoPtr_ChangeSomeEquipEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeSomeEquipEvent");
		NativeFieldInfoPtr_PlayerSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "PlayerSoundEvent");
		NativeFieldInfoPtr_MissionCountEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "MissionCountEvent");
		NativeFieldInfoPtr_TimeStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "TimeStopEvent");
		NativeFieldInfoPtr_ChangeCosplayPartsOptionEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeCosplayPartsOptionEvent");
		NativeFieldInfoPtr_CostumeFutaShapeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "CostumeFutaShapeEvent");
		NativeFieldInfoPtr_UpdateBodyShrinkEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "UpdateBodyShrinkEvent");
		NativeFieldInfoPtr_DynamicBoneInertCancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "DynamicBoneInertCancelEvent");
		NativeFieldInfoPtr_GraphicsOptionChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "GraphicsOptionChangeEvent");
		NativeFieldInfoPtr_OptionChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OptionChangeEvent");
		NativeFieldInfoPtr_ChangeWindowModeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeWindowModeEvent");
		NativeFieldInfoPtr_keyOptionChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "keyOptionChangeEvent");
		NativeFieldInfoPtr_ChangeLanguageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "ChangeLanguageEvent");
	}

	public Events(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
