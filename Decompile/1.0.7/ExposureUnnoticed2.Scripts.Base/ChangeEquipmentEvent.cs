using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Clothes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class ChangeEquipmentEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_ClothesRecord;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MClothesRecord ClothesRecord
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesRecord);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesRecord), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe ChangeEquipmentEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeEquipmentEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChangeEquipmentEvent()
	{
		Il2CppClassPointerStore<ChangeEquipmentEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "ChangeEquipmentEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeEquipmentEvent>.NativeClassPtr);
		NativeFieldInfoPtr_ClothesRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeEquipmentEvent>.NativeClassPtr, "ClothesRecord");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeEquipmentEvent>.NativeClassPtr, 100669288);
	}

	public ChangeEquipmentEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
