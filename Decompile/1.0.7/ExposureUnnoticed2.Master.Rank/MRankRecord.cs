using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Rank;

public class MRankRecord : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_Rank;

	private static readonly IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly IntPtr NativeFieldInfoPtr_NeedRp;

	private static readonly IntPtr NativeFieldInfoPtr_DokidokiBoostScale;

	private static readonly IntPtr NativeFieldInfoPtr_NeedFearUpRp;

	private static readonly IntPtr NativeFieldInfoPtr_FearLevelBias;

	private static readonly IntPtr NativeFieldInfoPtr_LostRpByGameOver;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int Rank
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rank);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rank)) = num;
		}
	}

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

	public unsafe int NeedRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedRp)) = num;
		}
	}

	public unsafe float DokidokiBoostScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiBoostScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokidokiBoostScale)) = num;
		}
	}

	public unsafe int NeedFearUpRp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedFearUpRp);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NeedFearUpRp)) = num;
		}
	}

	public unsafe int FearLevelBias
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FearLevelBias);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FearLevelBias)) = num;
		}
	}

	public unsafe int LostRpByGameOver
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostRpByGameOver);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LostRpByGameOver)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68038, XrefRangeEnd = 68039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MRankRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MRankRecord()
	{
		Il2CppClassPointerStore<MRankRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Rank", "MRankRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr);
		NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "Rank");
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_NeedRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "NeedRp");
		NativeFieldInfoPtr_DokidokiBoostScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "DokidokiBoostScale");
		NativeFieldInfoPtr_NeedFearUpRp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "NeedFearUpRp");
		NativeFieldInfoPtr_FearLevelBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "FearLevelBias");
		NativeFieldInfoPtr_LostRpByGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, "LostRpByGameOver");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MRankRecord>.NativeClassPtr, 100667988);
	}

	public MRankRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
