using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Sound;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.ObjectUI.CommonPopup;

public sealed class CommonButtonData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_Text;

	private static readonly System.IntPtr NativeFieldInfoPtr_OnClick;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SeType_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_0;

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

	public unsafe string Text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Text);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppSystem.Action OnClick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClick);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_OnClick), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe CommonButtonData([DefaultParameterValue(null)] InGameSoundManager.SeType seType, [DefaultParameterValue(null)] Il2CppSystem.Action onClick)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&seType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onClick);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SeType_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe CommonButtonData([DefaultParameterValue(null)] Il2CppSystem.Action onClick)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(onClick);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CommonButtonData()
	{
		Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.CommonPopup", "CommonButtonData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr);
		NativeFieldInfoPtr_SeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr, "SeType");
		NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr, "Text");
		NativeFieldInfoPtr_OnClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr, "OnClick");
		NativeMethodInfoPtr__ctor_Public_Void_SeType_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr, 100670802);
		NativeMethodInfoPtr__ctor_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr, 100670803);
	}

	public CommonButtonData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CommonButtonData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommonButtonData>.NativeClassPtr))
	{
	}
}
