using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SplineMesh;

public class MeshUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetReversedTriangles_Public_Static_Il2CppStructArray_1_Int32_Mesh_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Static_Void_Mesh_Mesh_IEnumerable_1_Int32_IEnumerable_1_Vector3_IEnumerable_1_Vector3_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10552, XrefRangeEnd = 10558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetReversedTriangles([DefaultParameterValue(null)] Mesh mesh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReversedTriangles_Public_Static_Il2CppStructArray_1_Int32_Mesh_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 10664, RefRangeEnd = 10668, XrefRangeStart = 10558, XrefRangeEnd = 10664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Update([DefaultParameterValue(null)] Mesh mesh, [DefaultParameterValue(null)] Mesh source, IEnumerable<int> triangles = null, IEnumerable<Vector3> vertices = null, IEnumerable<Vector3> normals = null, IEnumerable<Vector2> uv = null, IEnumerable<Vector2> uv2 = null, IEnumerable<Vector2> uv3 = null, IEnumerable<Vector2> uv4 = null, IEnumerable<Vector2> uv5 = null, IEnumerable<Vector2> uv6 = null, IEnumerable<Vector2> uv7 = null, IEnumerable<Vector2> uv8 = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[13];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mesh);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(triangles);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(vertices);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(normals);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv2);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv3);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv4);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv5);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv6);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)11u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv7);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)12u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(uv8);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Public_Static_Void_Mesh_Mesh_IEnumerable_1_Int32_IEnumerable_1_Vector3_IEnumerable_1_Vector3_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe MeshUtility()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshUtility>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MeshUtility()
	{
		Il2CppClassPointerStore<MeshUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "MeshUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetReversedTriangles_Public_Static_Il2CppStructArray_1_Int32_Mesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtility>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_Update_Public_Static_Void_Mesh_Mesh_IEnumerable_1_Int32_IEnumerable_1_Vector3_IEnumerable_1_Vector3_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_IEnumerable_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtility>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshUtility>.NativeClassPtr, 100664257);
	}

	public MeshUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
