using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class PlayerSoundEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_SeType;

	private static readonly IntPtr NativeFieldInfoPtr_IsPistonMachine;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InGameSoundManager.SeType SeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeType);
			return *(InGameSoundManager.SeType*)num;
		}
		set
		{
			*(InGameSoundManager.SeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeType)) = seType;
		}
	}

	public unsafe bool IsPistonMachine
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPistonMachine);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPistonMachine)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe PlayerSoundEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerSoundEvent()
	{
		Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "PlayerSoundEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr);
		NativeFieldInfoPtr_SeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr, "SeType");
		NativeFieldInfoPtr_IsPistonMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr, "IsPistonMachine");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSoundEvent>.NativeClassPtr, 100669278);
	}

	public PlayerSoundEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
