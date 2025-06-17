using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.Base;

public class Constant : Il2CppSystem.Object
{
	public enum Direct
	{
		Forward,
		Back,
		Left,
		Right,
		ForwardLeft,
		ForwardRight,
		BackLeft,
		BackRight
	}

	[System.Flags]
	public enum DiscomfortDirect
	{
		Forward = 1,
		Back = 2,
		Left = 4,
		Right = 8
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_NoDataVector3;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Vector3 NoDataVector3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NoDataVector3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NoDataVector3, &vector);
		}
	}

	[CallerCount(0)]
	public unsafe Constant()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constant>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Constant()
	{
		Il2CppClassPointerStore<Constant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "Constant");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constant>.NativeClassPtr);
		NativeFieldInfoPtr_NoDataVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constant>.NativeClassPtr, "NoDataVector3");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constant>.NativeClassPtr, 100669258);
	}

	public Constant(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
