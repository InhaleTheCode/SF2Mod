using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Object3D.ScenePlops.Toilet;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class StrangeAreaController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_strangenessValue;

	private static readonly IntPtr NativeFieldInfoPtr_playerChecker;

	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentStrange_Public_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float strangenessValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangenessValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangenessValue)) = num;
		}
	}

	public unsafe InSidePlayerChecker playerChecker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerChecker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InSidePlayerChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_playerChecker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe float GetCurrentStrange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentStrange_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StrangeAreaController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StrangeAreaController()
	{
		Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "StrangeAreaController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr);
		NativeFieldInfoPtr_strangenessValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr, "strangenessValue");
		NativeFieldInfoPtr_playerChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr, "playerChecker");
		NativeMethodInfoPtr_GetCurrentStrange_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr, 100669021);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangeAreaController>.NativeClassPtr, 100669022);
	}

	public StrangeAreaController(IntPtr pointer)
		: base(pointer)
	{
	}
}
