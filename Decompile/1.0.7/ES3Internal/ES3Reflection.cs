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

namespace ES3Internal;

public static class ES3Reflection : Il2CppSystem.Object
{
	public sealed class ES3ReflectedMember : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_fieldInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_propertyInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_isProperty;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MemberType_Public_get_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsProtected_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Object_Object_0;

		public unsafe FieldInfo fieldInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fieldInfo), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe PropertyInfo propertyInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyInfo);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_propertyInfo), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		public unsafe bool IsNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30391, XrefRangeEnd = 30393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		public unsafe Il2CppSystem.Type MemberType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30393, XrefRangeEnd = 30394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MemberType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
		}

		public unsafe bool IsPublic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe bool IsProtected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsProtected_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		public unsafe bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 30408, RefRangeEnd = 30420, XrefRangeStart = 30394, XrefRangeEnd = 30408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ES3ReflectedMember([DefaultParameterValue(null)] Il2CppSystem.Object fieldPropertyInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldPropertyInfo);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 30421, RefRangeEnd = 30422, XrefRangeStart = 30420, XrefRangeEnd = 30421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue([DefaultParameterValue(null)] Il2CppSystem.Object obj, [DefaultParameterValue(null)] Il2CppSystem.Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30423, RefRangeEnd = 30425, XrefRangeStart = 30422, XrefRangeEnd = 30423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Object GetValue([DefaultParameterValue(null)] Il2CppSystem.Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetValue_Public_Object_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}

		static ES3ReflectedMember()
		{
			Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "ES3ReflectedMember");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr);
			NativeFieldInfoPtr_fieldInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, "fieldInfo");
			NativeFieldInfoPtr_propertyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, "propertyInfo");
			NativeFieldInfoPtr_isProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, "isProperty");
			NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664959);
			NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664960);
			NativeMethodInfoPtr_get_MemberType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664961);
			NativeMethodInfoPtr_get_IsPublic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664962);
			NativeMethodInfoPtr_get_IsProtected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664963);
			NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664964);
			NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664965);
			NativeMethodInfoPtr_SetValue_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664966);
			NativeMethodInfoPtr_GetValue_Public_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr, 100664967);
		}

		public ES3ReflectedMember(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public ES3ReflectedMember()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReflectedMember>.NativeClassPtr))
		{
		}
	}

	public class ES3ReflectedMethod : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_method;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_BindingFlags_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Object_Object_Il2CppReferenceArray_1_Object_0;

		public unsafe MethodInfo method
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_method), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30425, XrefRangeEnd = 30426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ES3ReflectedMethod([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string methodName, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> genericParameters, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> parameterTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(genericParameters);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parameterTypes);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30426, XrefRangeEnd = 30427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ES3ReflectedMethod([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string methodName, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> genericParameters, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> parameterTypes, [DefaultParameterValue(null)] BindingFlags bindingAttr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[5];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(genericParameters);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parameterTypes);
			*(BindingFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindingAttr;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_BindingFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe Il2CppSystem.Object Invoke([DefaultParameterValue(null)] Il2CppSystem.Object obj, Il2CppReferenceArray<Il2CppSystem.Object> parameters = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Object_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}

		static ES3ReflectedMethod()
		{
			Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "ES3ReflectedMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr);
			NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr, "method");
			NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr, 100664968);
			NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr, 100664969);
			NativeMethodInfoPtr_Invoke_Public_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReflectedMethod>.NativeClassPtr, 100664970);
		}

		public ES3ReflectedMethod(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("ES3Internal.ES3Reflection/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_1;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__27_3;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetDerivedTypes_b__27_0_Internal_IEnumerable_1_Type_Assembly_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetDerivedTypes_b__27_1_Internal___f__AnonymousType0_2_Assembly_Type_Assembly_Type_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetDerivedTypes_b__27_3_Internal_Type___f__AnonymousType0_2_Assembly_Type_0;

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

		public unsafe static Il2CppSystem.Func<Assembly, IEnumerable<Il2CppSystem.Type>> __9__27_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Assembly, IEnumerable<Il2CppSystem.Type>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<Assembly, Il2CppSystem.Type, __f__AnonymousType0<Assembly, Il2CppSystem.Type>> __9__27_1
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_1, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Assembly, Il2CppSystem.Type, __f__AnonymousType0<Assembly, Il2CppSystem.Type>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_1, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<__f__AnonymousType0<Assembly, Il2CppSystem.Type>, Il2CppSystem.Type> __9__27_3
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__27_3, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<__f__AnonymousType0<Assembly, Il2CppSystem.Type>, Il2CppSystem.Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__27_3, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30427, XrefRangeEnd = 30428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Il2CppSystem.Type> _GetDerivedTypes_b__27_0([DefaultParameterValue(null)] Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDerivedTypes_b__27_0_Internal_IEnumerable_1_Type_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppSystem.Type>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30428, XrefRangeEnd = 30432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __f__AnonymousType0<Assembly, Il2CppSystem.Type> _GetDerivedTypes_b__27_1([DefaultParameterValue(null)] Assembly assembly, [DefaultParameterValue(null)] Il2CppSystem.Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(type);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDerivedTypes_b__27_1_Internal___f__AnonymousType0_2_Assembly_Type_Assembly_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__f__AnonymousType0<Assembly, Il2CppSystem.Type>>(intPtr) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30432, XrefRangeEnd = 30433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Type _GetDerivedTypes_b__27_3([DefaultParameterValue(null)] __f__AnonymousType0<Assembly, Il2CppSystem.Type> _003C_003Eh__TransparentIdentifier0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_003C_003Eh__TransparentIdentifier0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDerivedTypes_b__27_3_Internal_Type___f__AnonymousType0_2_Assembly_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_0");
			NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_1");
			NativeFieldInfoPtr___9__27_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__27_3");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664972);
			NativeMethodInfoPtr__GetDerivedTypes_b__27_0_Internal_IEnumerable_1_Type_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664973);
			NativeMethodInfoPtr__GetDerivedTypes_b__27_1_Internal___f__AnonymousType0_2_Assembly_Type_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664974);
			NativeMethodInfoPtr__GetDerivedTypes_b__27_3_Internal_Type___f__AnonymousType0_2_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664975);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("ES3Internal.ES3Reflection/<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_derivedType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetDerivedTypes_b__2_Internal_Boolean___f__AnonymousType0_2_Assembly_Type_0;

		public unsafe Il2CppSystem.Type derivedType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_derivedType);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_derivedType), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass27_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30433, XrefRangeEnd = 30438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetDerivedTypes_b__2([DefaultParameterValue(null)] __f__AnonymousType0<Assembly, Il2CppSystem.Type> _003C_003Eh__TransparentIdentifier0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_003C_003Eh__TransparentIdentifier0);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetDerivedTypes_b__2_Internal_Boolean___f__AnonymousType0_2_Assembly_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr);
			NativeFieldInfoPtr_derivedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, "derivedType");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100664976);
			NativeMethodInfoPtr__GetDerivedTypes_b__2_Internal_Boolean___f__AnonymousType0_2_Assembly_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass27_0>.NativeClassPtr, 100664977);
		}

		public __c__DisplayClass27_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("ES3Internal.ES3Reflection/<>c__DisplayClass46_0")]
	public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_methodName;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetMethods_b__0_Internal_Boolean_MethodInfo_0;

		public unsafe string methodName
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_methodName), IL2CPP.ManagedStringToIl2Cpp(str));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass46_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30438, XrefRangeEnd = 30439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetMethods_b__0([DefaultParameterValue(null)] MethodInfo t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetMethods_b__0_Internal_Boolean_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass46_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "<>c__DisplayClass46_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr);
			NativeFieldInfoPtr_methodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, "methodName");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, 100664978);
			NativeMethodInfoPtr__GetMethods_b__0_Internal_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass46_0>.NativeClassPtr, 100664979);
		}

		public __c__DisplayClass46_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetInstances_Public_Static_IList_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetInstances_Public_Static_IList_1_T_0, Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_memberFieldPrefix;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentTagFieldName;

	private static readonly System.IntPtr NativeFieldInfoPtr_componentNameFieldName;

	private static readonly System.IntPtr NativeFieldInfoPtr_excludedPropertyNames;

	private static readonly System.IntPtr NativeFieldInfoPtr_serializableAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_serializeFieldAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_obsoleteAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_nonSerializedAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_es3SerializableAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_es3NonSerializableAttributeType;

	private static readonly System.IntPtr NativeFieldInfoPtr_EmptyTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr__assemblies;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Assemblies_Private_Static_get_Il2CppReferenceArray_1_Assembly_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementTypes_Public_Static_Il2CppReferenceArray_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializableFields_Public_Static_List_1_FieldInfo_Type_List_1_FieldInfo_Boolean_Il2CppStringArray_BindingFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializableProperties_Public_Static_List_1_PropertyInfo_Type_List_1_PropertyInfo_Boolean_Il2CppStringArray_BindingFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeIsSerializable_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeGenericType_Public_Static_Type_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_ES3ReflectedMember_Type_Boolean_Il2CppStringArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetES3ReflectedProperty_Public_Static_ES3ReflectedMember_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetES3ReflectedMember_Public_Static_ES3ReflectedMember_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetInstances_Public_Static_IList_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDerivedTypes_Public_Static_IList_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetArrayRank_Public_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAssemblyQualifiedName_Public_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethod_Public_Static_ES3ReflectedMethod_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TypeIsArray_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasParameterlessConstructor_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetParameterlessConstructor_Public_Static_ConstructorInfo_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetShortAssemblyQualifiedName_Public_Static_String_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetProperty_Public_Static_PropertyInfo_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetField_Public_Static_FieldInfo_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMethods_Public_Static_Il2CppReferenceArray_1_MethodInfo_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_MemberInfo_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ImplementsInterface_Public_Static_Boolean_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeString_Public_Static_String_Type_0;

	public unsafe static string memberFieldPrefix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_memberFieldPrefix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_memberFieldPrefix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string componentTagFieldName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_componentTagFieldName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_componentTagFieldName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string componentNameFieldName
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_componentNameFieldName, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_componentNameFieldName, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static Il2CppStringArray excludedPropertyNames
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_excludedPropertyNames, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_excludedPropertyNames, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type serializableAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serializableAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serializableAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type serializeFieldAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_serializeFieldAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_serializeFieldAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type obsoleteAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_obsoleteAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_obsoleteAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type nonSerializedAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_nonSerializedAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_nonSerializedAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type es3SerializableAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_es3SerializableAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_es3SerializableAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppSystem.Type es3NonSerializableAttributeType
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_es3NonSerializableAttributeType, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_es3NonSerializableAttributeType, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> EmptyTypes
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_EmptyTypes, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_EmptyTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Assembly> _assemblies
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__assemblies, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__assemblies, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Il2CppReferenceArray<Assembly> Assemblies
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 30475, RefRangeEnd = 30477, XrefRangeStart = 30439, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Assemblies_Private_Static_get_Il2CppReferenceArray_1_Assembly_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Assembly>>(intPtr) : null;
		}
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30486, XrefRangeStart = 30477, XrefRangeEnd = 30481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> GetElementTypes([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetElementTypes_Public_Static_Il2CppReferenceArray_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30566, RefRangeEnd = 30568, XrefRangeStart = 30486, XrefRangeEnd = 30566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<FieldInfo> GetSerializableFields([DefaultParameterValue(null)] Il2CppSystem.Type type, List<FieldInfo> serializableFields = null, bool safe = true, Il2CppStringArray memberNames = null, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(serializableFields);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
		*(BindingFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindings;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSerializableFields_Public_Static_List_1_FieldInfo_Type_List_1_FieldInfo_Boolean_Il2CppStringArray_BindingFlags_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<FieldInfo>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30658, RefRangeEnd = 30660, XrefRangeStart = 30568, XrefRangeEnd = 30658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<PropertyInfo> GetSerializableProperties([DefaultParameterValue(null)] Il2CppSystem.Type type, List<PropertyInfo> serializableProperties = null, bool safe = true, Il2CppStringArray memberNames = null, BindingFlags bindings = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(serializableProperties);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
		*(BindingFlags**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &bindings;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSerializableProperties_Public_Static_List_1_PropertyInfo_Type_List_1_PropertyInfo_Boolean_Il2CppStringArray_BindingFlags_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<PropertyInfo>>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 30699, RefRangeEnd = 30703, XrefRangeStart = 30660, XrefRangeEnd = 30699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TypeIsSerializable([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeIsSerializable_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 30737, RefRangeEnd = 30769, XrefRangeStart = 30703, XrefRangeEnd = 30737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object CreateInstance([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 30790, RefRangeEnd = 30794, XrefRangeStart = 30769, XrefRangeEnd = 30790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Object CreateInstance([DefaultParameterValue(null)] Il2CppSystem.Type type, Il2CppReferenceArray<Il2CppSystem.Object> args = null)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(args);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30800, RefRangeEnd = 30802, XrefRangeStart = 30794, XrefRangeEnd = 30800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Array ArrayCreateInstance([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Array>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30802, XrefRangeEnd = 30803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Array ArrayCreateInstance([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] Il2CppStructArray<int> dimensions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(dimensions);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Array>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30803, XrefRangeEnd = 30811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type MakeGenericType([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] Il2CppSystem.Type genericParam)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(genericParam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeGenericType_Public_Static_Type_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30842, RefRangeEnd = 30843, XrefRangeStart = 30811, XrefRangeEnd = 30842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<ES3ReflectedMember> GetSerializableMembers([DefaultParameterValue(null)] Il2CppSystem.Type type, bool safe = true, Il2CppStringArray memberNames = null)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &safe;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(memberNames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_ES3ReflectedMember_Type_Boolean_Il2CppStringArray_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ES3ReflectedMember>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30843, XrefRangeEnd = 30848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3ReflectedMember GetES3ReflectedProperty([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string propertyName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetES3ReflectedProperty_Public_Static_ES3ReflectedMember_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new ES3ReflectedMember(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30848, XrefRangeEnd = 30853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3ReflectedMember GetES3ReflectedMember([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string fieldName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetES3ReflectedMember_Public_Static_ES3ReflectedMember_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new ES3ReflectedMember(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30879, RefRangeEnd = 30880, XrefRangeStart = 30853, XrefRangeEnd = 30879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<T> GetInstances<T>()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetInstances_Public_Static_IList_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30880, XrefRangeEnd = 30948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IList<Il2CppSystem.Type> GetDerivedTypes([DefaultParameterValue(null)] Il2CppSystem.Type derivedType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(derivedType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDerivedTypes_Public_Static_IList_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30948, XrefRangeEnd = 30949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsAssignableFrom([DefaultParameterValue(null)] Il2CppSystem.Type a, [DefaultParameterValue(null)] Il2CppSystem.Type b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30949, XrefRangeEnd = 30950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetGenericTypeDefinition([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30950, XrefRangeEnd = 30951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<Il2CppSystem.Type> GetGenericArguments([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30951, XrefRangeEnd = 30952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetArrayRank([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetArrayRank_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30952, XrefRangeEnd = 30953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetAssemblyQualifiedName([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAssemblyQualifiedName_Public_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30953, XrefRangeEnd = 30957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ES3ReflectedMethod GetMethod([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string methodName, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> genericParameters, [DefaultParameterValue(null)] Il2CppReferenceArray<Il2CppSystem.Type> parameterTypes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(genericParameters);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(parameterTypes);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethod_Public_Static_ES3ReflectedMethod_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ES3ReflectedMethod>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30957, XrefRangeEnd = 30958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TypeIsArray([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TypeIsArray_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30958, XrefRangeEnd = 30959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetElementType([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsAbstract([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30959, XrefRangeEnd = 30961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInterface([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30961, XrefRangeEnd = 30962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGenericType([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30962, XrefRangeEnd = 30963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValueType([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30963, XrefRangeEnd = 30964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsEnum([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30976, RefRangeEnd = 30978, XrefRangeStart = 30964, XrefRangeEnd = 30976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HasParameterlessConstructor([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasParameterlessConstructor_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30978, XrefRangeEnd = 30979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConstructorInfo GetParameterlessConstructor([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetParameterlessConstructor_Public_Static_ConstructorInfo_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30979, XrefRangeEnd = 30987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetShortAssemblyQualifiedName([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetShortAssemblyQualifiedName_Public_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 30999, RefRangeEnd = 31006, XrefRangeStart = 30987, XrefRangeEnd = 30999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PropertyInfo GetProperty([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string propertyName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetProperty_Public_Static_PropertyInfo_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr) : null;
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 31018, RefRangeEnd = 31024, XrefRangeStart = 31006, XrefRangeEnd = 31018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static FieldInfo GetField([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string fieldName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetField_Public_Static_FieldInfo_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 31041, RefRangeEnd = 31043, XrefRangeStart = 31024, XrefRangeEnd = 31041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<MethodInfo> GetMethods([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] string methodName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMethods_Public_Static_Il2CppReferenceArray_1_MethodInfo_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethodInfo>>(intPtr) : null;
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 31054, RefRangeEnd = 31059, XrefRangeStart = 31043, XrefRangeEnd = 31054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPrimitive([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31059, XrefRangeEnd = 31060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AttributeIsDefined([DefaultParameterValue(null)] MemberInfo info, [DefaultParameterValue(null)] Il2CppSystem.Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_MemberInfo_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31060, XrefRangeEnd = 31061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AttributeIsDefined([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] Il2CppSystem.Type attributeType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31061, XrefRangeEnd = 31064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ImplementsInterface([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] Il2CppSystem.Type interfaceType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(interfaceType);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ImplementsInterface_Public_Static_Boolean_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31064, XrefRangeEnd = 31065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type BaseType([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 31232, RefRangeEnd = 31235, XrefRangeStart = 31065, XrefRangeEnd = 31232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.Type GetType([DefaultParameterValue(null)] string typeString)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(typeString);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetType_Public_Static_Type_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Type>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31408, RefRangeEnd = 31409, XrefRangeStart = 31235, XrefRangeEnd = 31408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetTypeString([DefaultParameterValue(null)] Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeString_Public_Static_String_Type_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	public static Il2CppSystem.Object CreateInstance(Il2CppSystem.Type type, params Il2CppSystem.Object[] args)
	{
		return CreateInstance(type, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
	}

	static ES3Reflection()
	{
		Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Reflection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr);
		NativeFieldInfoPtr_memberFieldPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "memberFieldPrefix");
		NativeFieldInfoPtr_componentTagFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "componentTagFieldName");
		NativeFieldInfoPtr_componentNameFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "componentNameFieldName");
		NativeFieldInfoPtr_excludedPropertyNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "excludedPropertyNames");
		NativeFieldInfoPtr_serializableAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "serializableAttributeType");
		NativeFieldInfoPtr_serializeFieldAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "serializeFieldAttributeType");
		NativeFieldInfoPtr_obsoleteAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "obsoleteAttributeType");
		NativeFieldInfoPtr_nonSerializedAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "nonSerializedAttributeType");
		NativeFieldInfoPtr_es3SerializableAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "es3SerializableAttributeType");
		NativeFieldInfoPtr_es3NonSerializableAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "es3NonSerializableAttributeType");
		NativeFieldInfoPtr_EmptyTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "EmptyTypes");
		NativeFieldInfoPtr__assemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, "_assemblies");
		NativeMethodInfoPtr_get_Assemblies_Private_Static_get_Il2CppReferenceArray_1_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664917);
		NativeMethodInfoPtr_GetElementTypes_Public_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_GetSerializableFields_Public_Static_List_1_FieldInfo_Type_List_1_FieldInfo_Boolean_Il2CppStringArray_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_GetSerializableProperties_Public_Static_List_1_PropertyInfo_Type_List_1_PropertyInfo_Boolean_Il2CppStringArray_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_TypeIsSerializable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664922);
		NativeMethodInfoPtr_CreateInstance_Public_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664923);
		NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664924);
		NativeMethodInfoPtr_ArrayCreateInstance_Public_Static_Array_Type_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664925);
		NativeMethodInfoPtr_MakeGenericType_Public_Static_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664926);
		NativeMethodInfoPtr_GetSerializableMembers_Public_Static_Il2CppReferenceArray_1_ES3ReflectedMember_Type_Boolean_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664927);
		NativeMethodInfoPtr_GetES3ReflectedProperty_Public_Static_ES3ReflectedMember_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664928);
		NativeMethodInfoPtr_GetES3ReflectedMember_Public_Static_ES3ReflectedMember_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664929);
		NativeMethodInfoPtr_GetInstances_Public_Static_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664930);
		NativeMethodInfoPtr_GetDerivedTypes_Public_Static_IList_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664931);
		NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664932);
		NativeMethodInfoPtr_GetGenericTypeDefinition_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664933);
		NativeMethodInfoPtr_GetGenericArguments_Public_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664934);
		NativeMethodInfoPtr_GetArrayRank_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664935);
		NativeMethodInfoPtr_GetAssemblyQualifiedName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664936);
		NativeMethodInfoPtr_GetMethod_Public_Static_ES3ReflectedMethod_Type_String_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664937);
		NativeMethodInfoPtr_TypeIsArray_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664938);
		NativeMethodInfoPtr_GetElementType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664939);
		NativeMethodInfoPtr_IsAbstract_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664940);
		NativeMethodInfoPtr_IsInterface_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664941);
		NativeMethodInfoPtr_IsGenericType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664942);
		NativeMethodInfoPtr_IsValueType_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664943);
		NativeMethodInfoPtr_IsEnum_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664944);
		NativeMethodInfoPtr_HasParameterlessConstructor_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664945);
		NativeMethodInfoPtr_GetParameterlessConstructor_Public_Static_ConstructorInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664946);
		NativeMethodInfoPtr_GetShortAssemblyQualifiedName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664947);
		NativeMethodInfoPtr_GetProperty_Public_Static_PropertyInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664948);
		NativeMethodInfoPtr_GetField_Public_Static_FieldInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664949);
		NativeMethodInfoPtr_GetMethods_Public_Static_Il2CppReferenceArray_1_MethodInfo_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664950);
		NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664951);
		NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_MemberInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664952);
		NativeMethodInfoPtr_AttributeIsDefined_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664953);
		NativeMethodInfoPtr_ImplementsInterface_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664954);
		NativeMethodInfoPtr_BaseType_Public_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664955);
		NativeMethodInfoPtr_GetType_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664956);
		NativeMethodInfoPtr_GetTypeString_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Reflection>.NativeClassPtr, 100664957);
	}

	public ES3Reflection(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
