using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.ObjectUI.FadeOutPanel;

public class IFadeInStarter : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_IsStart_Public_Abstract_Virtual_New_Boolean_0;

	[CallerCount(0)]
	public unsafe virtual bool IsStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsStart_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IFadeInStarter()
	{
		Il2CppClassPointerStore<IFadeInStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.FadeOutPanel", "IFadeInStarter");
		NativeMethodInfoPtr_IsStart_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFadeInStarter>.NativeClassPtr, 100670204);
	}

	public IFadeInStarter(IntPtr pointer)
		: base(pointer)
	{
	}
}
