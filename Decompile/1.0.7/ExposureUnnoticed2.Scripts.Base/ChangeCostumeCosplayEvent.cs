using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class ChangeCostumeCosplayEvent : GameEvent
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe ChangeCostumeCosplayEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeCostumeCosplayEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChangeCostumeCosplayEvent()
	{
		Il2CppClassPointerStore<ChangeCostumeCosplayEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "ChangeCostumeCosplayEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeCostumeCosplayEvent>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeCostumeCosplayEvent>.NativeClassPtr, 100669295);
	}

	public ChangeCostumeCosplayEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
