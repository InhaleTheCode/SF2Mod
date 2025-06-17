using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Demo;

public static class LineUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_Single_Material_List_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawLine_Private_Static_Void_Single_Vector3_Vector3_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7394, XrefRangeEnd = 7410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawPath([DefaultParameterValue(null)] float thickness, [DefaultParameterValue(null)] Material material, [DefaultParameterValue(null)] List<Vector3> path)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&thickness);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(material);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawPath_Public_Static_Void_Single_Material_List_1_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 7430, RefRangeEnd = 7431, XrefRangeStart = 7410, XrefRangeEnd = 7430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawLine([DefaultParameterValue(null)] float thickness, [DefaultParameterValue(null)] Vector3 start, [DefaultParameterValue(null)] Vector3 end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&thickness);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawLine_Private_Static_Void_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LineUtil()
	{
		Il2CppClassPointerStore<LineUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ch.sycoforge.Decal.Demo", "LineUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineUtil>.NativeClassPtr);
		NativeMethodInfoPtr_DrawPath_Public_Static_Void_Single_Material_List_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineUtil>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_DrawLine_Private_Static_Void_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineUtil>.NativeClassPtr, 100664031);
	}

	public LineUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
