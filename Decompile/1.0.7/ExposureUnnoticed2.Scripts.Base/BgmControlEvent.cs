using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class BgmControlEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_IsPlay;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool IsPlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlay)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe BgmControlEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BgmControlEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BgmControlEvent()
	{
		Il2CppClassPointerStore<BgmControlEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "BgmControlEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BgmControlEvent>.NativeClassPtr);
		NativeFieldInfoPtr_IsPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BgmControlEvent>.NativeClassPtr, "IsPlay");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BgmControlEvent>.NativeClassPtr, 100669290);
	}

	public BgmControlEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
