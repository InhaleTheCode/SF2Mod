using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Conversation;

public class MConversationItem : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_TalkerNameKey;

	private static readonly IntPtr NativeFieldInfoPtr_MessageKey;

	private static readonly IntPtr NativeFieldInfoPtr_ParamKeyTypes;

	private static readonly IntPtr NativeFieldInfoPtr_eventType;

	private static readonly IntPtr NativeFieldInfoPtr_Next;

	private static readonly IntPtr NativeFieldInfoPtr_DialogItem;

	private static readonly IntPtr NativeFieldInfoPtr_BranchType;

	private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_get_ConversationItemType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string TalkerNameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TalkerNameKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TalkerNameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string MessageKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MessageKey);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MessageKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppStructArray<ConversationParamKeyType> ParamKeyTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParamKeyTypes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ConversationParamKeyType>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ParamKeyTypes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ConversationEventType eventType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType);
			return *(ConversationEventType*)num;
		}
		set
		{
			*(ConversationEventType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eventType)) = conversationEventType;
		}
	}

	public unsafe Il2CppReferenceArray<MConversationItem> Next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MConversationItem>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<ConversationDialogButtonModel> DialogItem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DialogItem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ConversationDialogButtonModel>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DialogItem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ConversationConditionalBranchType BranchType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchType);
			return *(ConversationConditionalBranchType*)num;
		}
		set
		{
			*(ConversationConditionalBranchType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BranchType)) = conversationConditionalBranchType;
		}
	}

	public unsafe ConversationItemType ItemType
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68666, XrefRangeStart = 68650, XrefRangeEnd = 68659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ItemType_Public_get_ConversationItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ConversationItemType*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MConversationItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MConversationItem()
	{
		Il2CppClassPointerStore<MConversationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Conversation", "MConversationItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr);
		NativeFieldInfoPtr_TalkerNameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "TalkerNameKey");
		NativeFieldInfoPtr_MessageKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "MessageKey");
		NativeFieldInfoPtr_ParamKeyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "ParamKeyTypes");
		NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "eventType");
		NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "Next");
		NativeFieldInfoPtr_DialogItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "DialogItem");
		NativeFieldInfoPtr_BranchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, "BranchType");
		NativeMethodInfoPtr_get_ItemType_Public_get_ConversationItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, 100668186);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MConversationItem>.NativeClassPtr, 100668187);
	}

	public MConversationItem(IntPtr pointer)
		: base(pointer)
	{
	}
}
