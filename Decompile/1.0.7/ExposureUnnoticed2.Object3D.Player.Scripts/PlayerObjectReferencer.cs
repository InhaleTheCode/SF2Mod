using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Object3D.Player.Scripts.Other;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerObjectReferencer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_BreathVoiceSource;

	private static readonly IntPtr NativeFieldInfoPtr_DownhillChecker;

	private static readonly IntPtr NativeFieldInfoPtr_OnGroundedChecker;

	private static readonly IntPtr NativeFieldInfoPtr_TerrainCheckCollider;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AudioSource BreathVoiceSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BreathVoiceSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BreathVoiceSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DownhillChecker DownhillChecker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DownhillChecker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DownhillChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DownhillChecker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe DownhillChecker OnGroundedChecker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGroundedChecker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<DownhillChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnGroundedChecker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe TerrainCheckCollider TerrainCheckCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TerrainCheckCollider);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<TerrainCheckCollider>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TerrainCheckCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerObjectReferencer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerObjectReferencer()
	{
		Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerObjectReferencer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr);
		NativeFieldInfoPtr_BreathVoiceSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr, "BreathVoiceSource");
		NativeFieldInfoPtr_DownhillChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr, "DownhillChecker");
		NativeFieldInfoPtr_OnGroundedChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr, "OnGroundedChecker");
		NativeFieldInfoPtr_TerrainCheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr, "TerrainCheckCollider");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerObjectReferencer>.NativeClassPtr, 100666872);
	}

	public PlayerObjectReferencer(IntPtr pointer)
		: base(pointer)
	{
	}
}
