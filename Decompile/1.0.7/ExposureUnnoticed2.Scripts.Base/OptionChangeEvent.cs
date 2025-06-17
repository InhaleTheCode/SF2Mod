using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class OptionChangeEvent : GameEvent
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe OptionChangeEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionChangeEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OptionChangeEvent()
	{
		Il2CppClassPointerStore<OptionChangeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "OptionChangeEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionChangeEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionChangeEvent>.NativeClassPtr, 100669273);
	}

	public OptionChangeEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
