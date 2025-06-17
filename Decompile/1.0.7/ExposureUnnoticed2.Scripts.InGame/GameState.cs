using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.ObjectUI.OptionMenu;
using ExposureUnnoticed2.ObjectUI.SelectDifficultyPanel;
using ExposureUnnoticed2.ObjectUI.TutorialPanel;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.InGame;

public class GameState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_ManualSaveTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_InterruptSaveTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_HomeSaveTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_DifficultData;

	private static readonly System.IntPtr NativeFieldInfoPtr_RankData;

	private static readonly System.IntPtr NativeFieldInfoPtr_TotalPlayTimeData;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptionData;

	private static readonly System.IntPtr NativeFieldInfoPtr_TutorialData;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameStateData;

	private static readonly System.IntPtr NativeFieldInfoPtr_SaveDataSlotIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsTrial;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptionFaceRankBias;

	private static readonly System.IntPtr NativeFieldInfoPtr_OptionFaceRange;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerCustomData;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Il2CppStructArray<Il2CppSystem.DateTime> AutoSaveTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoSaveTime, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.DateTime>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoSaveTime, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<Il2CppSystem.DateTime> ManualSaveTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ManualSaveTime, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.DateTime>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ManualSaveTime, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.DateTime InterruptSaveTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppSystem.DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_InterruptSaveTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_InterruptSaveTime, &dateTime);
		}
	}

	public unsafe static Il2CppSystem.DateTime HomeSaveTime
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Il2CppSystem.DateTime result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_HomeSaveTime, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_HomeSaveTime, &dateTime);
		}
	}

	public unsafe static Il2CppStructArray<DifficultType> DifficultData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DifficultData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<DifficultType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DifficultData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<int> RankData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RankData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RankData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppStructArray<uint> TotalPlayTimeData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TotalPlayTimeData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TotalPlayTimeData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static OptionData OptionData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptionData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<OptionData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptionData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static TutorialData TutorialData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TutorialData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<TutorialData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TutorialData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static GameStateData GameStateData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_GameStateData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameStateData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_GameStateData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int SaveDataSlotIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SaveDataSlotIndex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SaveDataSlotIndex, &num);
		}
	}

	public unsafe static bool IsTrial
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsTrial, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsTrial, &flag);
		}
	}

	public unsafe static int OptionFaceRankBias
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptionFaceRankBias, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptionFaceRankBias, &num);
		}
	}

	public unsafe static bool OptionFaceRange
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptionFaceRange, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptionFaceRange, &flag);
		}
	}

	public unsafe static PlayerCustomData PlayerCustomData
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_PlayerCustomData, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerCustomData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_PlayerCustomData, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe GameState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameState>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameState()
	{
		Il2CppClassPointerStore<GameState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "GameState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameState>.NativeClassPtr);
		NativeFieldInfoPtr_AutoSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "AutoSaveTime");
		NativeFieldInfoPtr_ManualSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "ManualSaveTime");
		NativeFieldInfoPtr_InterruptSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "InterruptSaveTime");
		NativeFieldInfoPtr_HomeSaveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "HomeSaveTime");
		NativeFieldInfoPtr_DifficultData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "DifficultData");
		NativeFieldInfoPtr_RankData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "RankData");
		NativeFieldInfoPtr_TotalPlayTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "TotalPlayTimeData");
		NativeFieldInfoPtr_OptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "OptionData");
		NativeFieldInfoPtr_TutorialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "TutorialData");
		NativeFieldInfoPtr_GameStateData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "GameStateData");
		NativeFieldInfoPtr_SaveDataSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "SaveDataSlotIndex");
		NativeFieldInfoPtr_IsTrial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "IsTrial");
		NativeFieldInfoPtr_OptionFaceRankBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "OptionFaceRankBias");
		NativeFieldInfoPtr_OptionFaceRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "OptionFaceRange");
		NativeFieldInfoPtr_PlayerCustomData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameState>.NativeClassPtr, "PlayerCustomData");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameState>.NativeClassPtr, 100668680);
	}

	public GameState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
