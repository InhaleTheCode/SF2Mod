using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public class ES3NonSerializable : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe ES3NonSerializable()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3NonSerializable>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3NonSerializable()
	{
		Il2CppClassPointerStore<ES3NonSerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3NonSerializable");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3NonSerializable>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3NonSerializable>.NativeClassPtr, 100663398);
	}

	public ES3NonSerializable(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
