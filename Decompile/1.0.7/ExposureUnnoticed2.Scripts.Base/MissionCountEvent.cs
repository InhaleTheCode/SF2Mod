using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Mission;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class MissionCountEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MissionCountType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(MissionCountType*)num;
		}
		set
		{
			*(MissionCountType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = missionCountType;
		}
	}

	[CallerCount(0)]
	public unsafe MissionCountEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionCountEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionCountEvent()
	{
		Il2CppClassPointerStore<MissionCountEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "MissionCountEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionCountEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionCountEvent>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionCountEvent>.NativeClassPtr, 100669298);
	}

	public MissionCountEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
