using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Skill.SkillMaxAccessoryNum;

public class RSkillMaxAccessoryNum : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_Level;

	private static readonly IntPtr NativeFieldInfoPtr_MaxNum;

	private static readonly IntPtr NativeFieldInfoPtr_NextLevelUpRp;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level)) = num;
		}
	}

	public unsafe int MaxNum
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxNum);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxNum)) = num;
		}
	}

	public unsafe int NextLevelUpRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextLevelUpRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NextLevelUpRp)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RSkillMaxAccessoryNum()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RSkillMaxAccessoryNum()
	{
		Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Skill.SkillMaxAccessoryNum", "RSkillMaxAccessoryNum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr);
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_MaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr, "MaxNum");
		NativeFieldInfoPtr_NextLevelUpRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr, "NextLevelUpRp");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSkillMaxAccessoryNum>.NativeClassPtr, 100667961);
	}

	public RSkillMaxAccessoryNum(IntPtr pointer)
		: base(pointer)
	{
	}
}
