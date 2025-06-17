using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

[StructLayout(LayoutKind.Explicit)]
public struct StrangeData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_StrangerDegree;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddDiscomfort;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxDiscomfort;

	private static readonly System.IntPtr NativeFieldInfoPtr_Noisy;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnlySightScale;

	[FieldOffset(0)]
	public float StrangerDegree;

	[FieldOffset(4)]
	public float AddDiscomfort;

	[FieldOffset(8)]
	public float MaxDiscomfort;

	[FieldOffset(12)]
	public float Noisy;

	[FieldOffset(16)]
	public float OnlySightScale;

	static StrangeData()
	{
		Il2CppClassPointerStore<StrangeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "StrangeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrangeData>.NativeClassPtr);
		NativeFieldInfoPtr_StrangerDegree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, "StrangerDegree");
		NativeFieldInfoPtr_AddDiscomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, "AddDiscomfort");
		NativeFieldInfoPtr_MaxDiscomfort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, "MaxDiscomfort");
		NativeFieldInfoPtr_Noisy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, "Noisy");
		NativeFieldInfoPtr_OnlySightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, "OnlySightScale");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StrangeData>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
	}
}
