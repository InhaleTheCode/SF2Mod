using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.ObjectUI.OptionMenu;

public class IOptionItemType : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_OptionItemType_Public_Abstract_Virtual_New_get_OptionItemType_0;

	public unsafe virtual OptionItemType OptionItemType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_get_OptionItemType_Public_Abstract_Virtual_New_get_OptionItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(OptionItemType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	static IOptionItemType()
	{
		Il2CppClassPointerStore<IOptionItemType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.OptionMenu", "IOptionItemType");
		NativeMethodInfoPtr_get_OptionItemType_Public_Abstract_Virtual_New_get_OptionItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IOptionItemType>.NativeClassPtr, 100670331);
	}

	public IOptionItemType(IntPtr pointer)
		: base(pointer)
	{
	}
}
