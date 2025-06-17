using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Skill;

public class MSkillRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly IntPtr NativeFieldInfoPtr_DescriptionKey;

	private static readonly IntPtr NativeFieldInfoPtr_InitRp;

	private static readonly IntPtr NativeFieldInfoPtr_IncrementRp;

	private static readonly IntPtr NativeFieldInfoPtr_MaxLevel;

	private static readonly IntPtr NativeFieldInfoPtr_ReleaseRank;

	private static readonly IntPtr NativeFieldInfoPtr_IsPassiveToggle;

	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeFieldInfoPtr_CategoryType;

	private static readonly IntPtr NativeFieldInfoPtr_ReleaseOrderTarget;

	private static readonly IntPtr NativeFieldInfoPtr_RpBonus;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string NameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string DescriptionKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DescriptionKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int InitRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InitRp)) = num;
		}
	}

	public unsafe int IncrementRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncrementRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IncrementRp)) = num;
		}
	}

	public unsafe int MaxLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxLevel)) = num;
		}
	}

	public unsafe int ReleaseRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseRank)) = num;
		}
	}

	public unsafe bool IsPassiveToggle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPassiveToggle);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPassiveToggle)) = flag;
		}
	}

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

	public unsafe SkillCategoryType CategoryType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType);
			return *(SkillCategoryType*)num;
		}
		set
		{
			*(SkillCategoryType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CategoryType)) = skillCategoryType;
		}
	}

	public unsafe SkillType ReleaseOrderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseOrderTarget);
			return *(SkillType*)num;
		}
		set
		{
			*(SkillType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReleaseOrderTarget)) = skillType;
		}
	}

	public unsafe int RpBonus
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67666, XrefRangeEnd = 67667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MSkillRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MSkillRecord()
	{
		Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Skill", "MSkillRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr);
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_DescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "DescriptionKey");
		NativeFieldInfoPtr_InitRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "InitRp");
		NativeFieldInfoPtr_IncrementRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "IncrementRp");
		NativeFieldInfoPtr_MaxLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "MaxLevel");
		NativeFieldInfoPtr_ReleaseRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "ReleaseRank");
		NativeFieldInfoPtr_IsPassiveToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "IsPassiveToggle");
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "Type");
		NativeFieldInfoPtr_CategoryType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "CategoryType");
		NativeFieldInfoPtr_ReleaseOrderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "ReleaseOrderTarget");
		NativeFieldInfoPtr_RpBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, "RpBonus");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSkillRecord>.NativeClassPtr, 100667941);
	}

	public MSkillRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
