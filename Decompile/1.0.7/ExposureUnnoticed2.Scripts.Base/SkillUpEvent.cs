using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Skill;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class SkillUpEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe SkillType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(SkillType*)num;
		}
		set
		{
			*(SkillType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = skillType;
		}
	}

	[CallerCount(0)]
	public unsafe SkillUpEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkillUpEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SkillUpEvent()
	{
		Il2CppClassPointerStore<SkillUpEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "SkillUpEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkillUpEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkillUpEvent>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkillUpEvent>.NativeClassPtr, 100669286);
	}

	public SkillUpEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
