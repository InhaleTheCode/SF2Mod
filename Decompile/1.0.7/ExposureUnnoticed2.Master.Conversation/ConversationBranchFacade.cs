using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Conversation;

public class ConversationBranchFacade : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_GetMatchIndex_Public_Static_Int32_ConversationConditionalBranchType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68619, XrefRangeEnd = 68624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetMatchIndex([DefaultParameterValue(null)] ConversationConditionalBranchType type)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatchIndex_Public_Static_Int32_ConversationConditionalBranchType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ConversationBranchFacade()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversationBranchFacade>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ConversationBranchFacade()
	{
		Il2CppClassPointerStore<ConversationBranchFacade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Conversation", "ConversationBranchFacade");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversationBranchFacade>.NativeClassPtr);
		NativeMethodInfoPtr_GetMatchIndex_Public_Static_Int32_ConversationConditionalBranchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationBranchFacade>.NativeClassPtr, 100668181);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversationBranchFacade>.NativeClassPtr, 100668182);
	}

	public ConversationBranchFacade(IntPtr pointer)
		: base(pointer)
	{
	}
}
