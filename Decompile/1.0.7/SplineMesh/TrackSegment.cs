using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SplineMesh;

[System.Serializable]
public class TrackSegment : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_transformedMeshes;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<TransformedMesh> transformedMeshes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformedMeshes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TransformedMesh>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_transformedMeshes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 9159, RefRangeEnd = 9162, XrefRangeStart = 9153, XrefRangeEnd = 9159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrackSegment()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackSegment>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TrackSegment()
	{
		Il2CppClassPointerStore<TrackSegment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "TrackSegment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackSegment>.NativeClassPtr);
		NativeFieldInfoPtr_transformedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackSegment>.NativeClassPtr, "transformedMeshes");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackSegment>.NativeClassPtr, 100664158);
	}

	public TrackSegment(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
