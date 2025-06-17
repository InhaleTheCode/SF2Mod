using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class FoundStrangerEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_FoundNpc;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NpcController FoundNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoundNpc);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FoundNpc), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe FoundStrangerEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FoundStrangerEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FoundStrangerEvent()
	{
		Il2CppClassPointerStore<FoundStrangerEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "FoundStrangerEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FoundStrangerEvent>.NativeClassPtr);
		NativeFieldInfoPtr_FoundNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FoundStrangerEvent>.NativeClassPtr, "FoundNpc");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FoundStrangerEvent>.NativeClassPtr, 100669285);
	}

	public FoundStrangerEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
