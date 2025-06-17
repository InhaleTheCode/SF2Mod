using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Scripts.Base;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.ScriptableObject;

public class MFootAnimationEventRecord : UnityEngine.ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_SeType;

	private static readonly IntPtr NativeFieldInfoPtr_Direct;

	private static readonly IntPtr NativeFieldInfoPtr_IsMoveAction;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe InGameSoundManager.SeType SeType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeType);
			return *(InGameSoundManager.SeType*)num;
		}
		set
		{
			*(InGameSoundManager.SeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SeType)) = seType;
		}
	}

	public unsafe Constant.Direct Direct
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direct);
			return *(Constant.Direct*)num;
		}
		set
		{
			*(Constant.Direct*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Direct)) = direct;
		}
	}

	public unsafe bool IsMoveAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveAction);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMoveAction)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MFootAnimationEventRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MFootAnimationEventRecord()
	{
		Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.ScriptableObject", "MFootAnimationEventRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr);
		NativeFieldInfoPtr_SeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr, "SeType");
		NativeFieldInfoPtr_Direct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr, "Direct");
		NativeFieldInfoPtr_IsMoveAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr, "IsMoveAction");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MFootAnimationEventRecord>.NativeClassPtr, 100667261);
	}

	public MFootAnimationEventRecord(IntPtr pointer)
		: base(pointer)
	{
	}
}
