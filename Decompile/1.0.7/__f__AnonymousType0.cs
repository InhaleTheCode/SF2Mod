using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

[ObfuscatedName("<>f__AnonymousType0`2")]
public sealed class __f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar> : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__assembly_i__Field;

	private static readonly System.IntPtr NativeFieldInfoPtr__type_i__Field;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_assembly_Public_get__003Cassembly_003Ej__TPar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_type_Public_get__003Ctype_003Ej__TPar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void__003Cassembly_003Ej__TPar__003Ctype_003Ej__TPar_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe _003Cassembly_003Ej__TPar _assembly_i__Field
	{
		get
		{
			nint objectPointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assembly_i__Field);
			return IL2CPP.PointerToValueGeneric<_003Cassembly_003Ej__TPar>(objectPointer, isFieldPointer: true, valueTypeWouldBeBoxed: false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__assembly_i__Field);
			System.Type typeFromHandle = typeof(_003Cassembly_003Ej__TPar);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr obj = intPtr;
						// IL cpblk instruction
						System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.Write((void*)num2, val);
			}
		}
	}

	public unsafe _003Ctype_003Ej__TPar _type_i__Field
	{
		get
		{
			nint objectPointer = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_i__Field);
			return IL2CPP.PointerToValueGeneric<_003Ctype_003Ej__TPar>(objectPointer, isFieldPointer: true, valueTypeWouldBeBoxed: false);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__type_i__Field);
			System.Type typeFromHandle = typeof(_003Ctype_003Ej__TPar);
			if (!typeFromHandle.IsValueType)
			{
				if (!string.Equals(typeFromHandle.FullName, "System.String"))
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase);
					if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
					{
						System.IntPtr obj = intPtr;
						// IL cpblk instruction
						System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(obj), ref *(uint*)null));
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, intPtr);
					}
				}
				else
				{
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, num2, IL2CPP.ManagedStringToIl2Cpp(val as string));
				}
			}
			else
			{
				System.Runtime.CompilerServices.Unsafe.Write((void*)num2, val);
			}
		}
	}

	public unsafe _003Cassembly_003Ej__TPar assembly
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 1, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_assembly_Public_get__003Cassembly_003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<_003Cassembly_003Ej__TPar>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}
	}

	public unsafe _003Ctype_003Ej__TPar type
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_type_Public_get__003Ctype_003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.PointerToValueGeneric<_003Ctype_003Ej__TPar>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
		}
	}

	[CallerCount(48)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 49, XrefRangeStart = 1, XrefRangeEnd = 1, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __f__AnonymousType0([DefaultParameterValue(null)] _003Cassembly_003Ej__TPar assembly, [DefaultParameterValue(null)] _003Ctype_003Ej__TPar type)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr))
	{
		//IL_0064->IL0069: Incompatible stack types: I vs Ref
		//IL_0057->IL0069: Incompatible stack types: I vs Ref
		//IL_00ba->IL00bf: Incompatible stack types: I vs Ref
		//IL_00ad->IL00bf: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref _003Cassembly_003Ej__TPar reference;
		if (!typeof(_003Cassembly_003Ej__TPar).IsValueType)
		{
			object obj = assembly;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref assembly;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref _003Ctype_003Ej__TPar reference2;
		if (!typeof(_003Ctype_003Ej__TPar).IsValueType)
		{
			object obj2 = type;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj2 as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref type;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void__003Cassembly_003Ej__TPar__003Ctype_003Ej__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals([DefaultParameterValue(null)] Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54, XrefRangeEnd = 56, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56, XrefRangeEnd = 68, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static __f__AnonymousType0()
	{
		Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<>f__AnonymousType0`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_003Cassembly_003Ej__TPar>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_003Ctype_003Ej__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr);
		NativeFieldInfoPtr__assembly_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, "<assembly>i__Field");
		NativeFieldInfoPtr__type_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, "<type>i__Field");
		NativeMethodInfoPtr_get_assembly_Public_get__003Cassembly_003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663297);
		NativeMethodInfoPtr_get_type_Public_get__003Ctype_003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663298);
		NativeMethodInfoPtr__ctor_Public_Void__003Cassembly_003Ej__TPar__003Ctype_003Ej__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663299);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663300);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663301);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType0<_003Cassembly_003Ej__TPar, _003Ctype_003Ej__TPar>>.NativeClassPtr, 100663302);
	}

	public __f__AnonymousType0(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
