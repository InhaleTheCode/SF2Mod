using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.ObjectUI.FadeOutPanel;

public class NoWaitStarter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe NoWaitStarter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoWaitStarter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NoWaitStarter()
	{
		Il2CppClassPointerStore<NoWaitStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.FadeOutPanel", "NoWaitStarter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoWaitStarter>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoWaitStarter>.NativeClassPtr, 100670206);
	}

	public NoWaitStarter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
