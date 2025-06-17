using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerHipAttachmentTracer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_XRotation;

	private static readonly IntPtr NativeFieldInfoPtr_NormalRotation;

	private static readonly IntPtr NativeFieldInfoPtr_MaxRotation;

	private static readonly IntPtr NativeFieldInfoPtr_rotateTarget;

	private static readonly IntPtr NativeFieldInfoPtr_kaikyakuPositionScale;

	private static readonly IntPtr NativeFieldInfoPtr_initZ;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float XRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_XRotation)) = num;
		}
	}

	public unsafe float NormalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalRotation)) = num;
		}
	}

	public unsafe float MaxRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxRotation);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MaxRotation)) = num;
		}
	}

	public unsafe Transform rotateTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotateTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float kaikyakuPositionScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kaikyakuPositionScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_kaikyakuPositionScale)) = num;
		}
	}

	public unsafe float initZ
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initZ);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initZ)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54158, XrefRangeEnd = 54160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54160, XrefRangeEnd = 54192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54192, XrefRangeEnd = 54195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerHipAttachmentTracer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerHipAttachmentTracer()
	{
		Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerHipAttachmentTracer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr);
		NativeFieldInfoPtr_XRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "XRotation");
		NativeFieldInfoPtr_NormalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "NormalRotation");
		NativeFieldInfoPtr_MaxRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "MaxRotation");
		NativeFieldInfoPtr_rotateTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "rotateTarget");
		NativeFieldInfoPtr_kaikyakuPositionScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "kaikyakuPositionScale");
		NativeFieldInfoPtr_initZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, "initZ");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, 100666835);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, 100666836);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHipAttachmentTracer>.NativeClassPtr, 100666837);
	}

	public PlayerHipAttachmentTracer(IntPtr pointer)
		: base(pointer)
	{
	}
}
