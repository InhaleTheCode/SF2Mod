using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.Scripts.InGame;

public class ILateUpdater : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Abstract_Virtual_New_Void_0;

	[CallerCount(0)]
	public unsafe virtual void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnLateUpdate_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ILateUpdater()
	{
		Il2CppClassPointerStore<ILateUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "ILateUpdater");
		NativeMethodInfoPtr_OnLateUpdate_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILateUpdater>.NativeClassPtr, 100668764);
	}

	public ILateUpdater(IntPtr pointer)
		: base(pointer)
	{
	}
}
