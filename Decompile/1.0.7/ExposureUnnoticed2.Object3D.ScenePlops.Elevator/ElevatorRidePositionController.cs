using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ScenePlops.Elevator;

public class ElevatorRidePositionController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_WaitExitTime;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float WaitExitTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitExitTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WaitExitTime)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ElevatorRidePositionController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ElevatorRidePositionController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ElevatorRidePositionController()
	{
		Il2CppClassPointerStore<ElevatorRidePositionController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ScenePlops.Elevator", "ElevatorRidePositionController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ElevatorRidePositionController>.NativeClassPtr);
		NativeFieldInfoPtr_WaitExitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ElevatorRidePositionController>.NativeClassPtr, "WaitExitTime");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ElevatorRidePositionController>.NativeClassPtr, 100666102);
	}

	public ElevatorRidePositionController(IntPtr pointer)
		: base(pointer)
	{
	}
}
