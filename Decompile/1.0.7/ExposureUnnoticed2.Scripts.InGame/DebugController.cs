using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Skill;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.InGame;

public class DebugController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IsDebug;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkipGameOverSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionSatisfyScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSkipDeleteInterruptSave;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceCompleteAchievement;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceResetAchievement;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceCreateNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_isAlreadyInit;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsOnlyYoungWomen;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsOnlyNewWomen;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsOnlyPreviousWomen;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHighSpeedMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_Muteki;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsEcstasyRiseHighSpeedVibe;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsManualChangeVibe;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsHandcuffOnePunch;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceReleaseDroneLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceReleaseFastTravel;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceReleaseAllPose;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceSkipTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsForceReleaseTutorial;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsDokodemoFastTravel;

	private static readonly System.IntPtr NativeMethodInfoPtr_FirstInitialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RiseSkill_Private_Static_Void_SkillType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool IsDebug
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDebug, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDebug, &flag);
		}
	}

	public unsafe static bool SkipGameOverSave
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SkipGameOverSave, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SkipGameOverSave, &flag);
		}
	}

	public unsafe static float MissionSatisfyScale
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MissionSatisfyScale, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MissionSatisfyScale, &num);
		}
	}

	public unsafe static bool IsSkipDeleteInterruptSave
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSkipDeleteInterruptSave, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSkipDeleteInterruptSave, &flag);
		}
	}

	public unsafe static bool IsForceCompleteAchievement
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceCompleteAchievement, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceCompleteAchievement, &flag);
		}
	}

	public unsafe static bool IsForceResetAchievement
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceResetAchievement, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceResetAchievement, &flag);
		}
	}

	public unsafe static bool IsForceCreateNpc
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceCreateNpc, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceCreateNpc, &flag);
		}
	}

	public unsafe static bool isAlreadyInit
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isAlreadyInit, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isAlreadyInit, &flag);
		}
	}

	public unsafe static bool IsOnlyYoungWomen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsOnlyYoungWomen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsOnlyYoungWomen, &flag);
		}
	}

	public unsafe static bool IsOnlyNewWomen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsOnlyNewWomen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsOnlyNewWomen, &flag);
		}
	}

	public unsafe static bool IsOnlyPreviousWomen
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsOnlyPreviousWomen, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsOnlyPreviousWomen, &flag);
		}
	}

	public unsafe static bool IsHighSpeedMove
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsHighSpeedMove, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsHighSpeedMove, &flag);
		}
	}

	public unsafe static bool Muteki
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Muteki, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Muteki, &flag);
		}
	}

	public unsafe static bool IsEcstasyRiseHighSpeedVibe
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsEcstasyRiseHighSpeedVibe, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsEcstasyRiseHighSpeedVibe, &flag);
		}
	}

	public unsafe static bool IsManualChangeVibe
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsManualChangeVibe, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsManualChangeVibe, &flag);
		}
	}

	public unsafe static bool IsHandcuffOnePunch
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsHandcuffOnePunch, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsHandcuffOnePunch, &flag);
		}
	}

	public unsafe static bool IsForceReleaseDroneLevel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceReleaseDroneLevel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceReleaseDroneLevel, &flag);
		}
	}

	public unsafe static bool IsForceReleaseFastTravel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceReleaseFastTravel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceReleaseFastTravel, &flag);
		}
	}

	public unsafe static bool IsForceReleaseAllPose
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceReleaseAllPose, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceReleaseAllPose, &flag);
		}
	}

	public unsafe static bool IsForceSkipTutorial
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceSkipTutorial, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceSkipTutorial, &flag);
		}
	}

	public unsafe static bool IsForceReleaseTutorial
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsForceReleaseTutorial, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsForceReleaseTutorial, &flag);
		}
	}

	public unsafe static bool IsDokodemoFastTravel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDokodemoFastTravel, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDokodemoFastTravel, &flag);
		}
	}

	[CallerCount(0)]
	public unsafe static void FirstInitialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FirstInitialize_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 72609, RefRangeEnd = 72610, XrefRangeStart = 72472, XrefRangeEnd = 72609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Initialize()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72610, XrefRangeEnd = 72625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RiseSkill([DefaultParameterValue(null)] SkillType type, [DefaultParameterValue(null)] int rise)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rise;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RiseSkill_Private_Static_Void_SkillType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe DebugController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DebugController()
	{
		Il2CppClassPointerStore<DebugController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "DebugController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugController>.NativeClassPtr);
		NativeFieldInfoPtr_IsDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsDebug");
		NativeFieldInfoPtr_SkipGameOverSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "SkipGameOverSave");
		NativeFieldInfoPtr_MissionSatisfyScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "MissionSatisfyScale");
		NativeFieldInfoPtr_IsSkipDeleteInterruptSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsSkipDeleteInterruptSave");
		NativeFieldInfoPtr_IsForceCompleteAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceCompleteAchievement");
		NativeFieldInfoPtr_IsForceResetAchievement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceResetAchievement");
		NativeFieldInfoPtr_IsForceCreateNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceCreateNpc");
		NativeFieldInfoPtr_isAlreadyInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "isAlreadyInit");
		NativeFieldInfoPtr_IsOnlyYoungWomen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsOnlyYoungWomen");
		NativeFieldInfoPtr_IsOnlyNewWomen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsOnlyNewWomen");
		NativeFieldInfoPtr_IsOnlyPreviousWomen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsOnlyPreviousWomen");
		NativeFieldInfoPtr_IsHighSpeedMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsHighSpeedMove");
		NativeFieldInfoPtr_Muteki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "Muteki");
		NativeFieldInfoPtr_IsEcstasyRiseHighSpeedVibe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsEcstasyRiseHighSpeedVibe");
		NativeFieldInfoPtr_IsManualChangeVibe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsManualChangeVibe");
		NativeFieldInfoPtr_IsHandcuffOnePunch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsHandcuffOnePunch");
		NativeFieldInfoPtr_IsForceReleaseDroneLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceReleaseDroneLevel");
		NativeFieldInfoPtr_IsForceReleaseFastTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceReleaseFastTravel");
		NativeFieldInfoPtr_IsForceReleaseAllPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceReleaseAllPose");
		NativeFieldInfoPtr_IsForceSkipTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceSkipTutorial");
		NativeFieldInfoPtr_IsForceReleaseTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsForceReleaseTutorial");
		NativeFieldInfoPtr_IsDokodemoFastTravel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugController>.NativeClassPtr, "IsDokodemoFastTravel");
		NativeMethodInfoPtr_FirstInitialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugController>.NativeClassPtr, 100668625);
		NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugController>.NativeClassPtr, 100668626);
		NativeMethodInfoPtr_RiseSkill_Private_Static_Void_SkillType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugController>.NativeClassPtr, 100668627);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugController>.NativeClassPtr, 100668628);
	}

	public DebugController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
