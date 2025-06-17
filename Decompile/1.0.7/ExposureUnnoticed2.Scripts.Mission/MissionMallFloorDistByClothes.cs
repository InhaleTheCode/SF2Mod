using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Mission;

public class MissionMallFloorDistByClothes : MissionBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71303, XrefRangeEnd = 71344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsInCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe MissionMallFloorDistByClothes()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionMallFloorDistByClothes>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionMallFloorDistByClothes()
	{
		Il2CppClassPointerStore<MissionMallFloorDistByClothes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Mission", "MissionMallFloorDistByClothes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionMallFloorDistByClothes>.NativeClassPtr);
		NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionMallFloorDistByClothes>.NativeClassPtr, 100668493);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionMallFloorDistByClothes>.NativeClassPtr, 100668494);
	}

	public MissionMallFloorDistByClothes(IntPtr pointer)
		: base(pointer)
	{
	}
}
