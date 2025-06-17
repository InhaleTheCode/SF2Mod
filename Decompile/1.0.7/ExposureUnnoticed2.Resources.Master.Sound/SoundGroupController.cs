using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Resources.Master.Sound;

public class SoundGroupController : Il2CppSystem.Object
{
	public new enum GetType
	{
		Order,
		Random
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_clips;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_orderIndexDict;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomLastIndexDict;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AudioClip_GetType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_AudioClip_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSoundAndUpdate_Private_AudioClip_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Private_AudioClip_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

	public unsafe Il2CppReferenceArray<AudioClip> clips
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clips);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clips), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GetType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(GetType*)num;
		}
		set
		{
			*(GetType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = getType;
		}
	}

	public unsafe Dictionary<GameObject, int> orderIndexDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderIndexDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameObject, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_orderIndexDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<GameObject, int> randomLastIndexDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomLastIndexDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<GameObject, int>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomLastIndexDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 42286, RefRangeEnd = 42297, XrefRangeStart = 42276, XrefRangeEnd = 42286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SoundGroupController([DefaultParameterValue(null)] Il2CppReferenceArray<AudioClip> clips, [DefaultParameterValue(null)] GetType type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(clips);
		*(GetType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AudioClip_GetType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 42309, RefRangeEnd = 42320, XrefRangeStart = 42297, XrefRangeEnd = 42309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip Get([DefaultParameterValue(null)] GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Get_Public_AudioClip_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42320, XrefRangeEnd = 42332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetSoundAndUpdate([DefaultParameterValue(null)] GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSoundAndUpdate_Private_AudioClip_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42332, XrefRangeEnd = 42347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioClip GetRandom([DefaultParameterValue(null)] GameObject target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRandom_Private_AudioClip_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AudioClip>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42347, XrefRangeEnd = 42353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SoundGroupController()
	{
		Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Resources.Master.Sound", "SoundGroupController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr);
		NativeFieldInfoPtr_clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, "clips");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, "type");
		NativeFieldInfoPtr_orderIndexDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, "orderIndexDict");
		NativeFieldInfoPtr_randomLastIndexDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, "randomLastIndexDict");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_AudioClip_GetType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_Get_Public_AudioClip_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_GetSoundAndUpdate_Private_AudioClip_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_GetRandom_Private_AudioClip_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoundGroupController>.NativeClassPtr, 100665773);
	}

	public SoundGroupController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
