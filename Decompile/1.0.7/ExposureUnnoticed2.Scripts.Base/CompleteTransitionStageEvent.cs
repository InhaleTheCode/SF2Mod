using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Scripts.InGame;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class CompleteTransitionStageEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_StageController;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe StageController StageController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<StageController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe CompleteTransitionStageEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompleteTransitionStageEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CompleteTransitionStageEvent()
	{
		Il2CppClassPointerStore<CompleteTransitionStageEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "CompleteTransitionStageEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompleteTransitionStageEvent>.NativeClassPtr);
		NativeFieldInfoPtr_StageController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompleteTransitionStageEvent>.NativeClassPtr, "StageController");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompleteTransitionStageEvent>.NativeClassPtr, 100669281);
	}

	public CompleteTransitionStageEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
