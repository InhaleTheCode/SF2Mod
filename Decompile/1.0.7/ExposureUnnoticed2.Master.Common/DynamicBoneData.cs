using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Master.Common;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct DynamicBoneData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_Elasticity;

	private static readonly System.IntPtr NativeFieldInfoPtr_Stiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_Inert;

	[FieldOffset(0)]
	public float Damping;

	[FieldOffset(4)]
	public float Elasticity;

	[FieldOffset(8)]
	public float Stiffness;

	[FieldOffset(12)]
	public float Inert;

	static DynamicBoneData()
	{
		Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Common", "DynamicBoneData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr);
		NativeFieldInfoPtr_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr, "Damping");
		NativeFieldInfoPtr_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr, "Elasticity");
		NativeFieldInfoPtr_Stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr, "Stiffness");
		NativeFieldInfoPtr_Inert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr, "Inert");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicBoneData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
