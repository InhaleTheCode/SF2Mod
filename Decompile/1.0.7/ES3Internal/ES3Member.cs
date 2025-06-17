using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ES3Internal;

public class ES3Member : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_isProperty;

	private static readonly System.IntPtr NativeFieldInfoPtr_reflectedMember;

	private static readonly System.IntPtr NativeFieldInfoPtr_useReflection;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ES3ReflectedMember_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppSystem.Type type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isProperty
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProperty);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isProperty)) = flag;
		}
	}

	public unsafe ES3Reflection.ES3ReflectedMember reflectedMember
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectedMember);
			return new ES3Reflection.ES3ReflectedMember(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ES3Reflection.ES3ReflectedMember>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reflectedMember), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ES3Reflection.ES3ReflectedMember>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool useReflection
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useReflection);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_useReflection)) = flag;
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31990, RefRangeEnd = 31992, XrefRangeStart = 31990, XrefRangeEnd = 31990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Member([DefaultParameterValue(null)] string name, [DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] bool isProperty)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Member>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isProperty;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31994, RefRangeEnd = 31995, XrefRangeStart = 31992, XrefRangeEnd = 31994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Member([DefaultParameterValue(null)] ES3Reflection.ES3ReflectedMember reflectedMember)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Member>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(reflectedMember));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ES3ReflectedMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Member()
	{
		Il2CppClassPointerStore<ES3Member>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Member");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Member>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, "name");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, "type");
		NativeFieldInfoPtr_isProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, "isProperty");
		NativeFieldInfoPtr_reflectedMember = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, "reflectedMember");
		NativeFieldInfoPtr_useReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, "useReflection");
		NativeMethodInfoPtr__ctor_Public_Void_String_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, 100665064);
		NativeMethodInfoPtr__ctor_Public_Void_ES3ReflectedMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Member>.NativeClassPtr, 100665065);
	}

	public ES3Member(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
