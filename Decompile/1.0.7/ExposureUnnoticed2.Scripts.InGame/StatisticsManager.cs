using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.InGame;

public class StatisticsManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tmpStatisticsTotalPlayTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_tmpStatisticsTotalExposeTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float tmpStatisticsTotalPlayTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpStatisticsTotalPlayTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpStatisticsTotalPlayTime)) = num;
		}
	}

	public unsafe float tmpStatisticsTotalExposeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpStatisticsTotalExposeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tmpStatisticsTotalExposeTime)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77839, XrefRangeEnd = 77852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe StatisticsManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StatisticsManager()
	{
		Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "StatisticsManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr);
		NativeFieldInfoPtr_tmpStatisticsTotalPlayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "tmpStatisticsTotalPlayTime");
		NativeFieldInfoPtr_tmpStatisticsTotalExposeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, "tmpStatisticsTotalExposeTime");
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100669019);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatisticsManager>.NativeClassPtr, 100669020);
	}

	public StatisticsManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
