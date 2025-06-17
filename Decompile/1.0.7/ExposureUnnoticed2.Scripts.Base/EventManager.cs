using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace ExposureUnnoticed2.Scripts.Base;

public static class EventManager : Il2CppSystem.Object
{
	[ObfuscatedName("ExposureUnnoticed2.Scripts.Base.EventManager/<>c__DisplayClass2_0`1")]
	public sealed class __c__DisplayClass2_0<T> : Il2CppSystem.Object where T : GameEvent
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_evt;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__AddListener_b__0_Internal_Void_GameEvent_0;

		public unsafe Il2CppSystem.Action<T> evt
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evt);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<T>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass2_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79645, XrefRangeEnd = 79650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddListener_b__0([DefaultParameterValue(null)] GameEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__AddListener_b__0_Internal_Void_GameEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c__DisplayClass2_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventManager>.NativeClassPtr, "<>c__DisplayClass2_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr, "evt");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr, 100669183);
			NativeMethodInfoPtr__AddListener_b__0_Internal_Void_GameEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass2_0<T>>.NativeClassPtr, 100669184);
		}

		public __c__DisplayClass2_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_AddListener_Public_Static_Void_Action_1_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddListener_Public_Static_Void_Action_1_T_Boolean_0, Il2CppClassPointerStore<EventManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Action_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Action_1_T_0, Il2CppClassPointerStore<EventManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Events;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EventLookups;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Static_Void_Action_1_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Action_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Broadcast_Public_Static_Void_GameEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_0;

	public unsafe static Dictionary<Il2CppSystem.Type, Il2CppSystem.Action<GameEvent>> s_Events
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Events, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Il2CppSystem.Action<GameEvent>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Events, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Dictionary<Il2CppSystem.Delegate, Il2CppSystem.Action<GameEvent>> s_EventLookups
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EventLookups, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Delegate, Il2CppSystem.Action<GameEvent>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EventLookups, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(145)]
	[CachedScanResults(RefRangeStart = 79687, RefRangeEnd = 79832, XrefRangeStart = 79650, XrefRangeEnd = 79687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddListener<T>([DefaultParameterValue(null)] Il2CppSystem.Action<T> evt, bool isHead = false) where T : GameEvent
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isHead;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddListener_Public_Static_Void_Action_1_T_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(152)]
	[CachedScanResults(RefRangeStart = 79873, RefRangeEnd = 80025, XrefRangeStart = 79832, XrefRangeEnd = 79873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveListener<T>([DefaultParameterValue(null)] Il2CppSystem.Action<T> evt) where T : GameEvent
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RemoveListener_Public_Static_Void_Action_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 80033, RefRangeEnd = 80109, XrefRangeStart = 80025, XrefRangeEnd = 80033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Broadcast([DefaultParameterValue(null)] GameEvent evt)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Broadcast_Public_Static_Void_GameEvent_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80109, XrefRangeEnd = 80138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EventManager()
	{
		Il2CppClassPointerStore<EventManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "EventManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventManager>.NativeClassPtr);
		NativeFieldInfoPtr_s_Events = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventManager>.NativeClassPtr, "s_Events");
		NativeFieldInfoPtr_s_EventLookups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventManager>.NativeClassPtr, "s_EventLookups");
		NativeMethodInfoPtr_AddListener_Public_Static_Void_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100669178);
		NativeMethodInfoPtr_RemoveListener_Public_Static_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100669179);
		NativeMethodInfoPtr_Broadcast_Public_Static_Void_GameEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100669180);
		NativeMethodInfoPtr_Clear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventManager>.NativeClassPtr, 100669181);
	}

	public EventManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
