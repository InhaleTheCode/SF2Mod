using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Common;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct SkinColor
{
	private static readonly System.IntPtr NativeFieldInfoPtr_BodyPrimary;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodySecondary;

	[FieldOffset(0)]
	public Color BodyPrimary;

	[FieldOffset(16)]
	public Color BodySecondary;

	static SkinColor()
	{
		Il2CppClassPointerStore<SkinColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Common", "SkinColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkinColor>.NativeClassPtr);
		NativeFieldInfoPtr_BodyPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinColor>.NativeClassPtr, "BodyPrimary");
		NativeFieldInfoPtr_BodySecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkinColor>.NativeClassPtr, "BodySecondary");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SkinColor>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
