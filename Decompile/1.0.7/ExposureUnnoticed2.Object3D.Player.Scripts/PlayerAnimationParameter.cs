using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerAnimationParameter : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_ToeDegree;

	private static readonly IntPtr NativeFieldInfoPtr_KneeSlide;

	private static readonly IntPtr NativeFieldInfoPtr_FellaMouse;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float ToeDegree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToeDegree);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ToeDegree)) = num;
		}
	}

	public unsafe float KneeSlide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KneeSlide);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_KneeSlide)) = num;
		}
	}

	public unsafe float FellaMouse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FellaMouse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FellaMouse)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerAnimationParameter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerAnimationParameter()
	{
		Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerAnimationParameter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr);
		NativeFieldInfoPtr_ToeDegree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr, "ToeDegree");
		NativeFieldInfoPtr_KneeSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr, "KneeSlide");
		NativeFieldInfoPtr_FellaMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr, "FellaMouse");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerAnimationParameter>.NativeClassPtr, 100666511);
	}

	public PlayerAnimationParameter(IntPtr pointer)
		: base(pointer)
	{
	}
}
