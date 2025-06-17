using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.ToiletManager;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script.State.Toilet;

public class NpcToiletHandWashState : Il2CppSystem.Object
{
	public enum State
	{
		Wait,
		Move,
		Washing
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_currentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeFieldInfoPtr_toiletManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_washPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_washEndRemainTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWait_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMove_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateWash_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe State currentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState)) = state;
		}
	}

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

	public unsafe ExposureUnnoticed2.Object3D.ToiletManager.ToiletManager toiletManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toiletManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExposureUnnoticed2.Object3D.ToiletManager.ToiletManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toiletManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform washPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washPoint);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washPoint), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float washEndRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washEndRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_washEndRemainTime)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64784, XrefRangeEnd = 64786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64786, XrefRangeEnd = 64789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 64806, RefRangeEnd = 64807, XrefRangeStart = 64789, XrefRangeEnd = 64806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWait()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWait_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 64816, RefRangeEnd = 64817, XrefRangeStart = 64807, XrefRangeEnd = 64816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 64848, RefRangeEnd = 64850, XrefRangeStart = 64817, XrefRangeEnd = 64848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateWash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateWash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe NpcToiletHandWashState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcToiletHandWashState()
	{
		Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script.State.Toilet", "NpcToiletHandWashState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr);
		NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, "currentState");
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_toiletManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, "toiletManager");
		NativeFieldInfoPtr_washPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, "washPoint");
		NativeFieldInfoPtr_washEndRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, "washEndRemainTime");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667700);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667701);
		NativeMethodInfoPtr_UpdateWait_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667702);
		NativeMethodInfoPtr_UpdateMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667703);
		NativeMethodInfoPtr_UpdateWash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667704);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcToiletHandWashState>.NativeClassPtr, 100667705);
	}

	public NpcToiletHandWashState(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
