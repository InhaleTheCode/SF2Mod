using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

[StructLayout(LayoutKind.Explicit)]
public struct SumReinforceEffectData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonus100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bareyasusa100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dokidoki100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Stamina100;

	private static readonly System.IntPtr NativeFieldInfoPtr_MentalDecreaseScale100;

	private static readonly System.IntPtr NativeFieldInfoPtr_DashSpeed100;

	private static readonly System.IntPtr NativeFieldInfoPtr_StaminaRegenerate100;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcstasyGauge100;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionGauge100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SlowGauge100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SkillCoolTime100;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameOverPenaltyRp100;

	private static readonly System.IntPtr NativeFieldInfoPtr_GameOverPenaltyRank100;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReduceFootStepSound100;

	private static readonly System.IntPtr NativeFieldInfoPtr_UnlockSpeed100;

	[FieldOffset(0)]
	public int RpBonus100;

	[FieldOffset(4)]
	public int Bareyasusa100;

	[FieldOffset(8)]
	public int Dokidoki100;

	[FieldOffset(12)]
	public int Stamina100;

	[FieldOffset(16)]
	public int MentalDecreaseScale100;

	[FieldOffset(20)]
	public int DashSpeed100;

	[FieldOffset(24)]
	public int StaminaRegenerate100;

	[FieldOffset(28)]
	public int EcstasyGauge100;

	[FieldOffset(32)]
	public int MissionGauge100;

	[FieldOffset(36)]
	public int SlowGauge100;

	[FieldOffset(40)]
	public int SkillCoolTime100;

	[FieldOffset(44)]
	public int GameOverPenaltyRp100;

	[FieldOffset(48)]
	public int GameOverPenaltyRank100;

	[FieldOffset(52)]
	public int ReduceFootStepSound100;

	[FieldOffset(56)]
	public int UnlockSpeed100;

	static SumReinforceEffectData()
	{
		Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "SumReinforceEffectData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr);
		NativeFieldInfoPtr_RpBonus100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "RpBonus100");
		NativeFieldInfoPtr_Bareyasusa100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "Bareyasusa100");
		NativeFieldInfoPtr_Dokidoki100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "Dokidoki100");
		NativeFieldInfoPtr_Stamina100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "Stamina100");
		NativeFieldInfoPtr_MentalDecreaseScale100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "MentalDecreaseScale100");
		NativeFieldInfoPtr_DashSpeed100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "DashSpeed100");
		NativeFieldInfoPtr_StaminaRegenerate100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "StaminaRegenerate100");
		NativeFieldInfoPtr_EcstasyGauge100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "EcstasyGauge100");
		NativeFieldInfoPtr_MissionGauge100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "MissionGauge100");
		NativeFieldInfoPtr_SlowGauge100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "SlowGauge100");
		NativeFieldInfoPtr_SkillCoolTime100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "SkillCoolTime100");
		NativeFieldInfoPtr_GameOverPenaltyRp100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "GameOverPenaltyRp100");
		NativeFieldInfoPtr_GameOverPenaltyRank100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "GameOverPenaltyRank100");
		NativeFieldInfoPtr_ReduceFootStepSound100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "ReduceFootStepSound100");
		NativeFieldInfoPtr_UnlockSpeed100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, "UnlockSpeed100");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SumReinforceEffectData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
