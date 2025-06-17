using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.InGame;

public class GameStateApplier : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_inGameReferencer;

	private static readonly System.IntPtr NativeFieldInfoPtr_inGameManager;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastApplyTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InGameReferencer_InGameManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateIgnoreWaitTime_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InGameReferencer inGameReferencer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameReferencer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InGameReferencer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameReferencer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InGameManager inGameManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameManager);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InGameManager>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inGameManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float lastApplyTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastApplyTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastApplyTime)) = num;
		}
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 49, XrefRangeStart = 1, XrefRangeEnd = 49, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] InGameReferencer inGameReferencer, [DefaultParameterValue(null)] InGameManager inGameManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inGameReferencer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(inGameManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_InGameReferencer_InGameManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 73523, RefRangeEnd = 73528, XrefRangeStart = 73505, XrefRangeEnd = 73523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate(bool isIgnoreWaitTime = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isIgnoreWaitTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73528, XrefRangeEnd = 73529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateIgnoreWaitTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateIgnoreWaitTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe GameStateApplier()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GameStateApplier()
	{
		Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "GameStateApplier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr);
		NativeFieldInfoPtr_inGameReferencer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, "inGameReferencer");
		NativeFieldInfoPtr_inGameManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, "inGameManager");
		NativeFieldInfoPtr_lastApplyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, "lastApplyTime");
		NativeMethodInfoPtr_Initialize_Public_Void_InGameReferencer_InGameManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, 100668683);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, 100668684);
		NativeMethodInfoPtr_UpdateIgnoreWaitTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, 100668685);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameStateApplier>.NativeClassPtr, 100668686);
	}

	public GameStateApplier(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
