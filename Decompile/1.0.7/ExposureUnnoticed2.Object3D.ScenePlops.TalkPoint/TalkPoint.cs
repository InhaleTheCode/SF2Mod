using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ScenePlops.TalkPoint;

public class TalkPoint : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Talk1Point;

	private static readonly IntPtr NativeFieldInfoPtr_Talk2Point;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform Talk1Point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Talk1Point);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Talk1Point), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Talk2Point
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Talk2Point);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Talk2Point), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TalkPoint()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TalkPoint>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TalkPoint()
	{
		Il2CppClassPointerStore<TalkPoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ScenePlops.TalkPoint", "TalkPoint");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TalkPoint>.NativeClassPtr);
		NativeFieldInfoPtr_Talk1Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkPoint>.NativeClassPtr, "Talk1Point");
		NativeFieldInfoPtr_Talk2Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkPoint>.NativeClassPtr, "Talk2Point");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkPoint>.NativeClassPtr, 100665974);
	}

	public TalkPoint(IntPtr pointer)
		: base(pointer)
	{
	}
}
