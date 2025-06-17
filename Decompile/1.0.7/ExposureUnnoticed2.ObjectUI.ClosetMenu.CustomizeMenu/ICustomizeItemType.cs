using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu;

public class ICustomizeItemType : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_CustomizeItemType_Public_Abstract_Virtual_New_get_CustomizeItemType_0;

	public unsafe virtual CustomizeItemType CustomizeItemType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_get_CustomizeItemType_Public_Abstract_Virtual_New_get_CustomizeItemType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(CustomizeItemType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	static ICustomizeItemType()
	{
		Il2CppClassPointerStore<ICustomizeItemType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu", "ICustomizeItemType");
		NativeMethodInfoPtr_get_CustomizeItemType_Public_Abstract_Virtual_New_get_CustomizeItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomizeItemType>.NativeClassPtr, 100670664);
	}

	public ICustomizeItemType(IntPtr pointer)
		: base(pointer)
	{
	}
}
