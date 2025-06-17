using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Other;

public class HeadCheckCollider : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HeadCheckCollider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeadCheckCollider>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static HeadCheckCollider()
	{
		Il2CppClassPointerStore<HeadCheckCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Other", "HeadCheckCollider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadCheckCollider>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadCheckCollider>.NativeClassPtr, 100667037);
	}

	public HeadCheckCollider(IntPtr pointer)
		: base(pointer)
	{
	}
}
