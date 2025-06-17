using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class ChangeCosplayPartsOptionEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_uniqueId;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int uniqueId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe ChangeCosplayPartsOptionEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeCosplayPartsOptionEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ChangeCosplayPartsOptionEvent()
	{
		Il2CppClassPointerStore<ChangeCosplayPartsOptionEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "ChangeCosplayPartsOptionEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeCosplayPartsOptionEvent>.NativeClassPtr);
		NativeFieldInfoPtr_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeCosplayPartsOptionEvent>.NativeClassPtr, "uniqueId");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeCosplayPartsOptionEvent>.NativeClassPtr, 100669277);
	}

	public ChangeCosplayPartsOptionEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
