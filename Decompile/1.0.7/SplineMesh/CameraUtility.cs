using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace SplineMesh;

public static class CameraUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_IsOnScreen_Public_Static_Boolean_Vector3_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10548, XrefRangeEnd = 10552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOnScreen([DefaultParameterValue(null)] Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&position);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsOnScreen_Public_Static_Boolean_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static CameraUtility()
	{
		Il2CppClassPointerStore<CameraUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "CameraUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraUtility>.NativeClassPtr);
		NativeMethodInfoPtr_IsOnScreen_Public_Static_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraUtility>.NativeClassPtr, 100664254);
	}

	public CameraUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
