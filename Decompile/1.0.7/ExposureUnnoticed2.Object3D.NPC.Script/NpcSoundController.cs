using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcSoundController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeFieldInfoPtr_elevatorOutsideVolumeScale;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat elevatorOutsideVolumeScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorOutsideVolumeScale);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elevatorOutsideVolumeScale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 4155, RefRangeEnd = 4177, XrefRangeStart = 4155, XrefRangeEnd = 4177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62823, RefRangeEnd = 62824, XrefRangeStart = 62772, XrefRangeEnd = 62823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 62843, RefRangeEnd = 62856, XrefRangeStart = 62824, XrefRangeEnd = 62843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaySe([DefaultParameterValue(null)] InGameSoundManager.SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62856, XrefRangeEnd = 62860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcSoundController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcSoundController()
	{
		Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcSoundController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr);
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_elevatorOutsideVolumeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, "elevatorOutsideVolumeScale");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, 100667556);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, 100667557);
		NativeMethodInfoPtr_PlaySe_Public_Void_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, 100667558);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSoundController>.NativeClassPtr, 100667559);
	}

	public NpcSoundController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
