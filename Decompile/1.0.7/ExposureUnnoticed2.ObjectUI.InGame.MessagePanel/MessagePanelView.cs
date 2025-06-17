using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ExposureUnnoticed2.ObjectUI.InGame.MessagePanel;

public class MessagePanelView : MonoBehaviour
{
	public enum MessageType
	{
		Caution,
		Log,
		RankUp,
		DroneMissionComplete
	}

	private static readonly IntPtr NativeFieldInfoPtr_MaxItemNum;

	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeFieldInfoPtr_dummyMessagePrefab;

	private static readonly IntPtr NativeFieldInfoPtr_messageItemPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_logItemPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_rankUpItemPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_droneMissionCompleteItemPrefab;

	private static readonly IntPtr NativeFieldInfoPtr_itemParent;

	private static readonly IntPtr NativeFieldInfoPtr_itemList;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetItemPrefab_Private_GameObject_MessageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddMessageInstance_Private_Void_String_MessageType_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddMessage_Public_Static_Void_String_MessageType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__AddMessageInstance_b__12_0_Private_Void_MessageItemView_0;

	public unsafe static int MaxItemNum
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxItemNum, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxItemNum, &num);
		}
	}

	public unsafe static MessagePanelView Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MessagePanelView>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject dummyMessagePrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummyMessagePrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummyMessagePrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject messageItemPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageItemPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_messageItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject logItemPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logItemPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject rankUpItemPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankUpItemPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rankUpItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject droneMissionCompleteItemPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droneMissionCompleteItemPrefab);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_droneMissionCompleteItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe VerticalLayoutGroup itemParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<MessageItemView> itemList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MessageItemView>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93409, XrefRangeEnd = 93418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe GameObject GetItemPrefab([DefaultParameterValue(null)] MessageType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetItemPrefab_Private_GameObject_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 93454, RefRangeEnd = 93457, XrefRangeStart = 93418, XrefRangeEnd = 93454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddMessageInstance([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] MessageType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(MessageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessageInstance_Private_Void_String_MessageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(49)]
	[CachedScanResults(RefRangeStart = 93465, RefRangeEnd = 93514, XrefRangeStart = 93457, XrefRangeEnd = 93465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddMessage([DefaultParameterValue(null)] string str, MessageType type = MessageType.Caution)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(MessageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddMessage_Public_Static_Void_String_MessageType_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93514, XrefRangeEnd = 93523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MessagePanelView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93523, XrefRangeEnd = 93527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _AddMessageInstance_b__12_0([DefaultParameterValue(null)] MessageItemView item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddMessageInstance_b__12_0_Private_Void_MessageItemView_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MessagePanelView()
	{
		Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InGame.MessagePanel", "MessagePanelView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr);
		NativeFieldInfoPtr_MaxItemNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "MaxItemNum");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_dummyMessagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "dummyMessagePrefab");
		NativeFieldInfoPtr_messageItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "messageItemPrefab");
		NativeFieldInfoPtr_logItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "logItemPrefab");
		NativeFieldInfoPtr_rankUpItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "rankUpItemPrefab");
		NativeFieldInfoPtr_droneMissionCompleteItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "droneMissionCompleteItemPrefab");
		NativeFieldInfoPtr_itemParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "itemParent");
		NativeFieldInfoPtr_itemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, "itemList");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670141);
		NativeMethodInfoPtr_GetItemPrefab_Private_GameObject_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670142);
		NativeMethodInfoPtr_AddMessageInstance_Private_Void_String_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670143);
		NativeMethodInfoPtr_AddMessage_Public_Static_Void_String_MessageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670144);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670145);
		NativeMethodInfoPtr__AddMessageInstance_b__12_0_Private_Void_MessageItemView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessagePanelView>.NativeClassPtr, 100670146);
	}

	public MessagePanelView(IntPtr pointer)
		: base(pointer)
	{
	}
}
