using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Skill.SkillSlow;

public class RSkillSlow : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_Level;

	private static readonly IntPtr NativeFieldInfoPtr_MaxTimeTank;

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

	public unsafe float MaxTimeTank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxTimeTank);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxTimeTank)) = num;
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
	public unsafe RSkillSlow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RSkillSlow()
	{
		Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Skill.SkillSlow", "RSkillSlow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr);
		NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr, "Level");
		NativeFieldInfoPtr_MaxTimeTank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr, "MaxTimeTank");
		NativeFieldInfoPtr_NextLevelUpRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr, "NextLevelUpRp");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RSkillSlow>.NativeClassPtr, 100667946);
	}

	public RSkillSlow(IntPtr pointer)
		: base(pointer)
	{
	}
}
