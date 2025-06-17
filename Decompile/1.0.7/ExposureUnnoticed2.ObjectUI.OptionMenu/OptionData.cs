using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.ObjectUI.OptionMenu;

public class OptionData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FutanariDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_PeeDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_SexDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteractEffectInvisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaleRate100;

	private static readonly System.IntPtr NativeFieldInfoPtr_OldPeopleRate100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Language;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsBlackCensor;

	private static readonly System.IntPtr NativeFieldInfoPtr_BlackCensorSize100;

	private static readonly System.IntPtr NativeFieldInfoPtr_VibeStateColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_NpcNumScaleMallDaytime;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsUseHsv;

	private static readonly System.IntPtr NativeFieldInfoPtr_InvisibleRedWall;

	private static readonly System.IntPtr NativeFieldInfoPtr_FutanariFemaleClimaxDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_Message;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingMenuMessage;

	private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_EcstasyGauge;

	private static readonly System.IntPtr NativeFieldInfoPtr_Compass;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_RightDownPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_InteractPanel;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeartBeatEffect;

	private static readonly System.IntPtr NativeFieldInfoPtr_HeartBeatEffectAlpha100;

	private static readonly System.IntPtr NativeFieldInfoPtr_MissionPanelSize100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Manual;

	private static readonly System.IntPtr NativeFieldInfoPtr_GamePadIconType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundMaster100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundSe100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundUi100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundBgm100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundVibe100;

	private static readonly System.IntPtr NativeFieldInfoPtr_SoundHeartBeat100;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseInverseX;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseInverseY;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadInverseX;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadInverseY;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelInverse;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadUpDownInverse;

	private static readonly System.IntPtr NativeFieldInfoPtr_MouseSensitive100;

	private static readonly System.IntPtr NativeFieldInfoPtr_WheelSensitive100;

	private static readonly System.IntPtr NativeFieldInfoPtr_PadSensitive100;

	private static readonly System.IntPtr NativeFieldInfoPtr_LongPressTimeScale10;

	private static readonly System.IntPtr NativeFieldInfoPtr_AspectRatioIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_Quality;

	private static readonly System.IntPtr NativeFieldInfoPtr_Resolusion;

	private static readonly System.IntPtr NativeFieldInfoPtr_WindowMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxFrameRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_Brightness;

	private static readonly System.IntPtr NativeFieldInfoPtr_Contrast;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraAngle1st;

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraAngle3rd;

	private static readonly System.IntPtr NativeFieldInfoPtr_VSync;

	private static readonly System.IntPtr NativeFieldInfoPtr_AntiAliasing;

	private static readonly System.IntPtr NativeFieldInfoPtr_SSAO;

	private static readonly System.IntPtr NativeFieldInfoPtr_SSR;

	private static readonly System.IntPtr NativeFieldInfoPtr_Bloom;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomStrength;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomBiasDark;

	private static readonly System.IntPtr NativeFieldInfoPtr_BloomBiasLight;

	private static readonly System.IntPtr NativeFieldInfoPtr_ColorTemperature;

	private static readonly System.IntPtr NativeFieldInfoPtr_MotionBlur;

	private static readonly System.IntPtr NativeFieldInfoPtr_AnsweredFirstSexOption;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSexMaleTranslucent;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsSexMaleOnlySao;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetGraphics_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFov_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetControl_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetAppearRate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetSound_Public_Void_0;

	public unsafe bool FutanariDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariDisable)) = flag;
		}
	}

	public unsafe bool PeeDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeDisable)) = flag;
		}
	}

	public unsafe bool SexDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SexDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SexDisable)) = flag;
		}
	}

	public unsafe bool InteractEffectInvisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractEffectInvisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractEffectInvisible)) = flag;
		}
	}

	public unsafe int MaleRate100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleRate100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaleRate100)) = num;
		}
	}

	public unsafe int OldPeopleRate100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OldPeopleRate100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OldPeopleRate100)) = num;
		}
	}

	public unsafe Localizer.Language Language
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language);
			return *(Localizer.Language*)num;
		}
		set
		{
			*(Localizer.Language*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Language)) = language;
		}
	}

	public unsafe bool IsBlackCensor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsBlackCensor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsBlackCensor)) = flag;
		}
	}

	public unsafe int BlackCensorSize100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlackCensorSize100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BlackCensorSize100)) = num;
		}
	}

	public unsafe bool VibeStateColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeStateColor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VibeStateColor)) = flag;
		}
	}

	public unsafe int NpcNumScaleMallDaytime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumScaleMallDaytime);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NpcNumScaleMallDaytime)) = num;
		}
	}

	public unsafe bool IsUseHsv
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseHsv);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsUseHsv)) = flag;
		}
	}

	public unsafe bool InvisibleRedWall
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvisibleRedWall);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InvisibleRedWall)) = flag;
		}
	}

	public unsafe bool FutanariFemaleClimaxDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariFemaleClimaxDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FutanariFemaleClimaxDisable)) = flag;
		}
	}

	public unsafe bool FaceCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FaceCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FaceCamera)) = flag;
		}
	}

	public unsafe bool BodyCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyCamera);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyCamera)) = flag;
		}
	}

	public unsafe bool Message
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Message)) = flag;
		}
	}

	public unsafe bool RingMenuMessage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingMenuMessage);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RingMenuMessage)) = flag;
		}
	}

	public unsafe bool PlayerInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerInfo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PlayerInfo)) = flag;
		}
	}

	public unsafe bool EcstasyGauge
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyGauge);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EcstasyGauge)) = flag;
		}
	}

	public unsafe bool Compass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Compass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Compass)) = flag;
		}
	}

	public unsafe bool MissionPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionPanel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionPanel)) = flag;
		}
	}

	public unsafe bool RightDownPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightDownPanel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RightDownPanel)) = flag;
		}
	}

	public unsafe bool InteractPanel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractPanel);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractPanel)) = flag;
		}
	}

	public unsafe bool HeartBeatEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeatEffect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeatEffect)) = flag;
		}
	}

	public unsafe int HeartBeatEffectAlpha100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeatEffectAlpha100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HeartBeatEffectAlpha100)) = num;
		}
	}

	public unsafe int MissionPanelSize100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionPanelSize100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MissionPanelSize100)) = num;
		}
	}

	public unsafe bool Manual
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Manual);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Manual)) = flag;
		}
	}

	public unsafe int GamePadIconType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GamePadIconType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GamePadIconType)) = num;
		}
	}

	public unsafe int SoundMaster100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundMaster100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundMaster100)) = num;
		}
	}

	public unsafe int SoundSe100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSe100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundSe100)) = num;
		}
	}

	public unsafe int SoundUi100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundUi100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundUi100)) = num;
		}
	}

	public unsafe int SoundBgm100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundBgm100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundBgm100)) = num;
		}
	}

	public unsafe int SoundVibe100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundVibe100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundVibe100)) = num;
		}
	}

	public unsafe int SoundHeartBeat100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundHeartBeat100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SoundHeartBeat100)) = num;
		}
	}

	public unsafe bool MouseInverseX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseInverseX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseInverseX)) = flag;
		}
	}

	public unsafe bool MouseInverseY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseInverseY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseInverseY)) = flag;
		}
	}

	public unsafe bool PadInverseX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadInverseX);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadInverseX)) = flag;
		}
	}

	public unsafe bool PadInverseY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadInverseY);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadInverseY)) = flag;
		}
	}

	public unsafe bool WheelInverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelInverse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelInverse)) = flag;
		}
	}

	public unsafe bool PadUpDownInverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadUpDownInverse);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadUpDownInverse)) = flag;
		}
	}

	public unsafe int MouseSensitive100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseSensitive100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MouseSensitive100)) = num;
		}
	}

	public unsafe int WheelSensitive100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelSensitive100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WheelSensitive100)) = num;
		}
	}

	public unsafe int PadSensitive100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadSensitive100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PadSensitive100)) = num;
		}
	}

	public unsafe int LongPressTimeScale10
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongPressTimeScale10);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LongPressTimeScale10)) = num;
		}
	}

	public unsafe int AspectRatioIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AspectRatioIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AspectRatioIndex)) = num;
		}
	}

	public unsafe int Quality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Quality)) = num;
		}
	}

	public unsafe int Resolusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Resolusion);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Resolusion)) = num;
		}
	}

	public unsafe int WindowMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowMode);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WindowMode)) = num;
		}
	}

	public unsafe int MaxFrameRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxFrameRate);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxFrameRate)) = num;
		}
	}

	public unsafe int Brightness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brightness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Brightness)) = num;
		}
	}

	public unsafe int Contrast
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Contrast);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Contrast)) = num;
		}
	}

	public unsafe int CameraAngle1st
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraAngle1st);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraAngle1st)) = num;
		}
	}

	public unsafe int CameraAngle3rd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraAngle3rd);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraAngle3rd)) = num;
		}
	}

	public unsafe bool VSync
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VSync);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_VSync)) = flag;
		}
	}

	public unsafe bool AntiAliasing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AntiAliasing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AntiAliasing)) = flag;
		}
	}

	public unsafe bool SSAO
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SSAO);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SSAO)) = flag;
		}
	}

	public unsafe bool SSR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SSR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SSR)) = flag;
		}
	}

	public unsafe bool Bloom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bloom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Bloom)) = flag;
		}
	}

	public unsafe int BloomStrength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomStrength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomStrength)) = num;
		}
	}

	public unsafe int BloomBiasDark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomBiasDark);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomBiasDark)) = num;
		}
	}

	public unsafe int BloomBiasLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomBiasLight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BloomBiasLight)) = num;
		}
	}

	public unsafe int ColorTemperature
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTemperature);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ColorTemperature)) = num;
		}
	}

	public unsafe bool MotionBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionBlur);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MotionBlur)) = flag;
		}
	}

	public unsafe bool AnsweredFirstSexOption
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnsweredFirstSexOption);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AnsweredFirstSexOption)) = flag;
		}
	}

	public unsafe bool IsSexMaleTranslucent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSexMaleTranslucent);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSexMaleTranslucent)) = flag;
		}
	}

	public unsafe bool IsSexMaleOnlySao
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSexMaleOnlySao);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsSexMaleOnlySao)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe OptionData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetGraphics()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetGraphics_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetFov()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFov_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetControl()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetControl_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetAppearRate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetAppearRate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void ResetSound()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OptionData()
	{
		Il2CppClassPointerStore<OptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.OptionMenu", "OptionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionData>.NativeClassPtr);
		NativeFieldInfoPtr_FutanariDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "FutanariDisable");
		NativeFieldInfoPtr_PeeDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PeeDisable");
		NativeFieldInfoPtr_SexDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SexDisable");
		NativeFieldInfoPtr_InteractEffectInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "InteractEffectInvisible");
		NativeFieldInfoPtr_MaleRate100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MaleRate100");
		NativeFieldInfoPtr_OldPeopleRate100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "OldPeopleRate100");
		NativeFieldInfoPtr_Language = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Language");
		NativeFieldInfoPtr_IsBlackCensor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "IsBlackCensor");
		NativeFieldInfoPtr_BlackCensorSize100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "BlackCensorSize100");
		NativeFieldInfoPtr_VibeStateColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "VibeStateColor");
		NativeFieldInfoPtr_NpcNumScaleMallDaytime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "NpcNumScaleMallDaytime");
		NativeFieldInfoPtr_IsUseHsv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "IsUseHsv");
		NativeFieldInfoPtr_InvisibleRedWall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "InvisibleRedWall");
		NativeFieldInfoPtr_FutanariFemaleClimaxDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "FutanariFemaleClimaxDisable");
		NativeFieldInfoPtr_FaceCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "FaceCamera");
		NativeFieldInfoPtr_BodyCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "BodyCamera");
		NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Message");
		NativeFieldInfoPtr_RingMenuMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "RingMenuMessage");
		NativeFieldInfoPtr_PlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PlayerInfo");
		NativeFieldInfoPtr_EcstasyGauge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "EcstasyGauge");
		NativeFieldInfoPtr_Compass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Compass");
		NativeFieldInfoPtr_MissionPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MissionPanel");
		NativeFieldInfoPtr_RightDownPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "RightDownPanel");
		NativeFieldInfoPtr_InteractPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "InteractPanel");
		NativeFieldInfoPtr_HeartBeatEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "HeartBeatEffect");
		NativeFieldInfoPtr_HeartBeatEffectAlpha100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "HeartBeatEffectAlpha100");
		NativeFieldInfoPtr_MissionPanelSize100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MissionPanelSize100");
		NativeFieldInfoPtr_Manual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Manual");
		NativeFieldInfoPtr_GamePadIconType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "GamePadIconType");
		NativeFieldInfoPtr_SoundMaster100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundMaster100");
		NativeFieldInfoPtr_SoundSe100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundSe100");
		NativeFieldInfoPtr_SoundUi100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundUi100");
		NativeFieldInfoPtr_SoundBgm100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundBgm100");
		NativeFieldInfoPtr_SoundVibe100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundVibe100");
		NativeFieldInfoPtr_SoundHeartBeat100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SoundHeartBeat100");
		NativeFieldInfoPtr_MouseInverseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MouseInverseX");
		NativeFieldInfoPtr_MouseInverseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MouseInverseY");
		NativeFieldInfoPtr_PadInverseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PadInverseX");
		NativeFieldInfoPtr_PadInverseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PadInverseY");
		NativeFieldInfoPtr_WheelInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "WheelInverse");
		NativeFieldInfoPtr_PadUpDownInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PadUpDownInverse");
		NativeFieldInfoPtr_MouseSensitive100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MouseSensitive100");
		NativeFieldInfoPtr_WheelSensitive100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "WheelSensitive100");
		NativeFieldInfoPtr_PadSensitive100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "PadSensitive100");
		NativeFieldInfoPtr_LongPressTimeScale10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "LongPressTimeScale10");
		NativeFieldInfoPtr_AspectRatioIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "AspectRatioIndex");
		NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Quality");
		NativeFieldInfoPtr_Resolusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Resolusion");
		NativeFieldInfoPtr_WindowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "WindowMode");
		NativeFieldInfoPtr_MaxFrameRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MaxFrameRate");
		NativeFieldInfoPtr_Brightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Brightness");
		NativeFieldInfoPtr_Contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Contrast");
		NativeFieldInfoPtr_CameraAngle1st = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "CameraAngle1st");
		NativeFieldInfoPtr_CameraAngle3rd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "CameraAngle3rd");
		NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "VSync");
		NativeFieldInfoPtr_AntiAliasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "AntiAliasing");
		NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SSAO");
		NativeFieldInfoPtr_SSR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "SSR");
		NativeFieldInfoPtr_Bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "Bloom");
		NativeFieldInfoPtr_BloomStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "BloomStrength");
		NativeFieldInfoPtr_BloomBiasDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "BloomBiasDark");
		NativeFieldInfoPtr_BloomBiasLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "BloomBiasLight");
		NativeFieldInfoPtr_ColorTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "ColorTemperature");
		NativeFieldInfoPtr_MotionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "MotionBlur");
		NativeFieldInfoPtr_AnsweredFirstSexOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "AnsweredFirstSexOption");
		NativeFieldInfoPtr_IsSexMaleTranslucent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "IsSexMaleTranslucent");
		NativeFieldInfoPtr_IsSexMaleOnlySao = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionData>.NativeClassPtr, "IsSexMaleOnlySao");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670388);
		NativeMethodInfoPtr_ResetGraphics_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670389);
		NativeMethodInfoPtr_ResetFov_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670390);
		NativeMethodInfoPtr_ResetControl_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670391);
		NativeMethodInfoPtr_ResetAppearRate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670392);
		NativeMethodInfoPtr_ResetSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionData>.NativeClassPtr, 100670393);
	}

	public OptionData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
