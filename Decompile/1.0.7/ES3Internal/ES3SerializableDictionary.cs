using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ES3Internal;

[System.Serializable]
public class ES3SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>
{
	[System.Serializable]
	[ObfuscatedName("ES3Internal.ES3SerializableDictionary`2/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__6_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__6_1;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveNullValues_b__6_0_Internal_Boolean_KeyValuePair_2_TKey_TVal_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RemoveNullValues_b__6_1_Internal_TKey_KeyValuePair_2_TKey_TVal_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<KeyValuePair<TKey, TVal>, bool> __9__6_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__6_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<TKey, TVal>, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__6_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<KeyValuePair<TKey, TVal>, TKey> __9__6_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__6_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<KeyValuePair<TKey, TVal>, TKey>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__6_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe bool _RemoveNullValues_b__6_0([DefaultParameterValue(null)] KeyValuePair<TKey, TVal> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveNullValues_b__6_0_Internal_Boolean_KeyValuePair_2_TKey_TVal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		[CallerCount(0)]
		public unsafe TKey _RemoveNullValues_b__6_1([DefaultParameterValue(null)] KeyValuePair<TKey, TVal> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RemoveNullValues_b__6_1_Internal_TKey_KeyValuePair_2_TKey_TVal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<TKey>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
			{
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TVal>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__6_0");
			NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__6_1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664988);
			NativeMethodInfoPtr__RemoveNullValues_b__6_0_Internal_Boolean_KeyValuePair_2_TKey_TVal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664989);
			NativeMethodInfoPtr__RemoveNullValues_b__6_1_Internal_TKey_KeyValuePair_2_TKey_TVal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664990);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__Keys;

	private static readonly System.IntPtr NativeFieldInfoPtr__Values;

	private static readonly System.IntPtr NativeMethodInfoPtr_KeysAreEqual_Protected_Abstract_Virtual_New_Boolean_TKey_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValuesAreEqual_Protected_Abstract_Virtual_New_Boolean_TVal_TVal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNullValues_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeKey_Public_Boolean_TKey_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public unsafe List<TKey> _Keys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Keys);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TKey>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Keys), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<TVal> _Values
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Values);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TVal>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Values), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	public unsafe virtual bool KeysAreEqual([DefaultParameterValue(null)] TKey a, [DefaultParameterValue(null)] TKey b)
	{
		//IL_005b->IL0060: Incompatible stack types: I vs Ref
		//IL_004e->IL0060: Incompatible stack types: I vs Ref
		//IL_00b1->IL00b6: Incompatible stack types: I vs Ref
		//IL_00a4->IL00b6: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TKey reference;
		if (!typeof(TKey).IsValueType)
		{
			object obj = a;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref a;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TKey reference2;
		if (!typeof(TKey).IsValueType)
		{
			object obj2 = b;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj2 as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref b;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_KeysAreEqual_Protected_Abstract_Virtual_New_Boolean_TKey_TKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj3);
	}

	[CallerCount(0)]
	public unsafe virtual bool ValuesAreEqual([DefaultParameterValue(null)] TVal a, [DefaultParameterValue(null)] TVal b)
	{
		//IL_005b->IL0060: Incompatible stack types: I vs Ref
		//IL_004e->IL0060: Incompatible stack types: I vs Ref
		//IL_00b1->IL00b6: Incompatible stack types: I vs Ref
		//IL_00a4->IL00b6: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TVal reference;
		if (!typeof(TVal).IsValueType)
		{
			object obj = a;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref a;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TVal reference2;
		if (!typeof(TVal).IsValueType)
		{
			object obj2 = b;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj2 as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref b;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ValuesAreEqual_Protected_Abstract_Virtual_New_Boolean_TVal_TVal_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31409, XrefRangeEnd = 31421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31421, XrefRangeEnd = 31429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31429, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int RemoveNullValues()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveNullValues_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31462, XrefRangeEnd = 31465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ChangeKey([DefaultParameterValue(null)] TKey oldKey, [DefaultParameterValue(null)] TKey newKey)
	{
		//IL_005b->IL0060: Incompatible stack types: I vs Ref
		//IL_004e->IL0060: Incompatible stack types: I vs Ref
		//IL_00b1->IL00b6: Incompatible stack types: I vs Ref
		//IL_00a4->IL00b6: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TKey reference;
		if (!typeof(TKey).IsValueType)
		{
			object obj = oldKey;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref oldKey;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TKey reference2;
		if (!typeof(TKey).IsValueType)
		{
			object obj2 = newKey;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj2 as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref newKey;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeKey_Public_Boolean_TKey_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31465, XrefRangeEnd = 31478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3SerializableDictionary()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3SerializableDictionary()
	{
		Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3SerializableDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TVal>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr);
		NativeFieldInfoPtr__Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, "_Keys");
		NativeFieldInfoPtr__Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, "_Values");
		NativeMethodInfoPtr_KeysAreEqual_Protected_Abstract_Virtual_New_Boolean_TKey_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664980);
		NativeMethodInfoPtr_ValuesAreEqual_Protected_Abstract_Virtual_New_Boolean_TVal_TVal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664981);
		NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664982);
		NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664983);
		NativeMethodInfoPtr_RemoveNullValues_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664984);
		NativeMethodInfoPtr_ChangeKey_Public_Boolean_TKey_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664985);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableDictionary<TKey, TVal>>.NativeClassPtr, 100664986);
	}

	public ES3SerializableDictionary(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
