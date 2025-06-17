using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.UIPlayer;

public class UiPlayerAbsorbAnimationEvent : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__FutanariObject_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_FutanariObject_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FutanariObject_Private_set_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_FootR_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_FootL_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPlaySe_Private_Void_SeType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject _FutanariObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FutanariObject_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FutanariObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject FutanariObject
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FutanariObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FutanariObject_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe void FootR()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FootR_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void FootL()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FootL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnPlaySe([DefaultParameterValue(null)] InGameSoundManager.SeType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPlaySe_Private_Void_SeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UiPlayerAbsorbAnimationEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static UiPlayerAbsorbAnimationEvent()
	{
		Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.UIPlayer", "UiPlayerAbsorbAnimationEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr);
		NativeFieldInfoPtr__FutanariObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, "<FutanariObject>k__BackingField");
		NativeMethodInfoPtr_get_FutanariObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665797);
		NativeMethodInfoPtr_set_FutanariObject_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665798);
		NativeMethodInfoPtr_FootR_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665799);
		NativeMethodInfoPtr_FootL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665800);
		NativeMethodInfoPtr_OnPlaySe_Private_Void_SeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665801);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UiPlayerAbsorbAnimationEvent>.NativeClassPtr, 100665802);
	}

	public UiPlayerAbsorbAnimationEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
