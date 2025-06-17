using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

public class ES3XMLReader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe ES3XMLReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3XMLReader>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3XMLReader()
	{
		Il2CppClassPointerStore<ES3XMLReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3XMLReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3XMLReader>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3XMLReader>.NativeClassPtr, 100663725);
	}

	public ES3XMLReader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
