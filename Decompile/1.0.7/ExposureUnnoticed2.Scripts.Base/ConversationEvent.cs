using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Conversation;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ExposureUnnoticed2.Scripts.Base;

public class ConversationEvent : GameEvent
{
	private static readonly IntPtr NativeFieldInfoPtr_Type;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ConversationEventType Type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type);
			return *(ConversationEventType*)num;
		}
		set
		{
			*(ConversationEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Type)) = conversationEventType;
		}
	}

	[CallerCount(0)]
	public unsafe ConversationEvent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationEvent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ConversationEvent()
	{
		Il2CppClassPointerStore<ConversationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "ConversationEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationEvent>.NativeClassPtr);
		NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversationEvent>.NativeClassPtr, "Type");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationEvent>.NativeClassPtr, 100669289);
	}

	public ConversationEvent(IntPtr pointer)
		: base(pointer)
	{
	}
}
