using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Other;

public class PantsSlideAdjuster : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_slideMankoIndex;

	private static readonly IntPtr NativeFieldInfoPtr_slideAnalIndex;

	private static readonly IntPtr NativeFieldInfoPtr_mesh;

	private static readonly IntPtr NativeFieldInfoPtr_oldSlideManko;

	private static readonly IntPtr NativeFieldInfoPtr_oldSlideAnal;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int slideMankoIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slideMankoIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slideMankoIndex)) = num;
		}
	}

	public unsafe int slideAnalIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slideAnalIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slideAnalIndex)) = num;
		}
	}

	public unsafe SkinnedMeshRenderer mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float oldSlideManko
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldSlideManko);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldSlideManko)) = num;
		}
	}

	public unsafe float oldSlideAnal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldSlideAnal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldSlideAnal)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57572, XrefRangeEnd = 57575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57575, XrefRangeEnd = 57589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57589, XrefRangeEnd = 57592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PantsSlideAdjuster()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PantsSlideAdjuster()
	{
		Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Other", "PantsSlideAdjuster");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr);
		NativeFieldInfoPtr_slideMankoIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, "slideMankoIndex");
		NativeFieldInfoPtr_slideAnalIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, "slideAnalIndex");
		NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, "mesh");
		NativeFieldInfoPtr_oldSlideManko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, "oldSlideManko");
		NativeFieldInfoPtr_oldSlideAnal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, "oldSlideAnal");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, 100667057);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, 100667058);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PantsSlideAdjuster>.NativeClassPtr, 100667059);
	}

	public PantsSlideAdjuster(IntPtr pointer)
		: base(pointer)
	{
	}
}
