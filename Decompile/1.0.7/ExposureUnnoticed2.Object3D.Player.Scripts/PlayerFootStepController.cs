using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerFootStepController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_originalBareyasusaByHeel;

	private static readonly System.IntPtr NativeFieldInfoPtr_startBareyasusa;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnFootStep_Public_Void_AnimationEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe PlayerClassAccessor pca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClassAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float originalBareyasusaByHeel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalBareyasusaByHeel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_originalBareyasusaByHeel)) = num;
		}
	}

	public unsafe float startBareyasusa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startBareyasusa);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startBareyasusa)) = num;
		}
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 4155, RefRangeEnd = 4177, XrefRangeStart = 4155, XrefRangeEnd = 4177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54045, XrefRangeEnd = 54048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54066, RefRangeEnd = 54068, XrefRangeStart = 54048, XrefRangeEnd = 54066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFootStep([DefaultParameterValue(null)] AnimationEvent type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnFootStep_Public_Void_AnimationEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PlayerFootStepController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerFootStepController()
	{
		Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerFootStepController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr);
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_originalBareyasusaByHeel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, "originalBareyasusaByHeel");
		NativeFieldInfoPtr_startBareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, "startBareyasusa");
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, 100666810);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, 100666811);
		NativeMethodInfoPtr_OnFootStep_Public_Void_AnimationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, 100666812);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFootStepController>.NativeClassPtr, 100666813);
	}

	public PlayerFootStepController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
