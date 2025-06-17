using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.ReinforceEffect;

public class RReinforceEffect : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly IntPtr NativeFieldInfoPtr_ReinforceEffectType;

	private static readonly IntPtr NativeFieldInfoPtr_EffectAmount100;

	private static readonly IntPtr NativeFieldInfoPtr_EffectRank;

	private static readonly IntPtr NativeFieldInfoPtr_IsNegativeEffect;

	private static readonly IntPtr NativeFieldInfoPtr_IsNeutralEffect;

	private static readonly IntPtr NativeFieldInfoPtr__Id_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Suffix_Public_get_String_0;

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

	public unsafe ReinforceEffectType ReinforceEffectType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforceEffectType);
			return *(ReinforceEffectType*)num;
		}
		set
		{
			*(ReinforceEffectType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReinforceEffectType)) = reinforceEffectType;
		}
	}

	public unsafe int EffectAmount100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectAmount100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectAmount100)) = num;
		}
	}

	public unsafe int EffectRank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectRank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EffectRank)) = num;
		}
	}

	public unsafe bool IsNegativeEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNegativeEffect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNegativeEffect)) = flag;
		}
	}

	public unsafe bool IsNeutralEffect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNeutralEffect);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsNeutralEffect)) = flag;
		}
	}

	public unsafe int _Id_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Id_k__BackingField)) = num;
		}
	}

	public unsafe int Id
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe string Suffix
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67884, XrefRangeEnd = 67886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Suffix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RReinforceEffect()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RReinforceEffect()
	{
		Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.ReinforceEffect", "RReinforceEffect");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr);
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_ReinforceEffectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "ReinforceEffectType");
		NativeFieldInfoPtr_EffectAmount100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "EffectAmount100");
		NativeFieldInfoPtr_EffectRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "EffectRank");
		NativeFieldInfoPtr_IsNegativeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "IsNegativeEffect");
		NativeFieldInfoPtr_IsNeutralEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "IsNeutralEffect");
		NativeFieldInfoPtr__Id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, "<Id>k__BackingField");
		NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, 100667973);
		NativeMethodInfoPtr_set_Id_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, 100667974);
		NativeMethodInfoPtr_get_Suffix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, 100667975);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RReinforceEffect>.NativeClassPtr, 100667976);
	}

	public RReinforceEffect(IntPtr pointer)
		: base(pointer)
	{
	}
}
