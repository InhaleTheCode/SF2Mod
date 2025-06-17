using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.ObjectUI.BuyPanel;

public class BasketControllerManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentBasketController_Public_Static_IBasketController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 101510, RefRangeEnd = 101514, XrefRangeStart = 101498, XrefRangeEnd = 101510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IBasketController GetCurrentBasketController()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentBasketController_Public_Static_IBasketController_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IBasketController>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe BasketControllerManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasketControllerManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BasketControllerManager()
	{
		Il2CppClassPointerStore<BasketControllerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.BuyPanel", "BasketControllerManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasketControllerManager>.NativeClassPtr);
		NativeMethodInfoPtr_GetCurrentBasketController_Public_Static_IBasketController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketControllerManager>.NativeClassPtr, 100670746);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasketControllerManager>.NativeClassPtr, 100670747);
	}

	public BasketControllerManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
