using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Master.Conversation;

[System.Serializable]
public class ConversationDialogButtonModel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_ButtonNameKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_Next;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string ButtonNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonNameKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ButtonNameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe MConversationItem Next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MConversationItem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe ConversationDialogButtonModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ConversationDialogButtonModel()
	{
		Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Conversation", "ConversationDialogButtonModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr);
		NativeFieldInfoPtr_ButtonNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr, "ButtonNameKey");
		NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr, "Next");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationDialogButtonModel>.NativeClassPtr, 100668188);
	}

	public ConversationDialogButtonModel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
