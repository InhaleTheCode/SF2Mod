using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Mission;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.AI;

namespace ExposureUnnoticed2.Scripts.Base;

public static class ExternalMethodManager : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_Void_Action_2_T1_T2_T1_T2_0<T1, T2>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_2_T1_T2_T1_T2_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_Void_Action_1_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_1_T_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_T_Func_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_NullSafeInvoke_Public_Static_T_Func_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetComponentsInAllChildren_Public_Static_List_1_T_GameObject_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetComponentsInAllChildren_Public_Static_List_1_T_GameObject_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RecursiveSetActive_Private_Static_Void_GameObject_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RecursiveSetActive_Private_Static_Void_GameObject_List_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetRandom_Public_Static_T_Il2CppArrayBase_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRandom_Public_Static_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetRandomIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetRandomIndex_Public_Static_Int32_List_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_List_1_T_Int32_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetRandom_Public_Static_T_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DeepCopy_Public_Static_Void_List_1_T_List_1_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DeepCopy_Public_Static_Void_List_1_T_List_1_T_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_RemoveInCondition_Public_Static_Void_List_1_T_Func_2_T_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_RemoveInCondition_Public_Static_Void_List_1_T_Func_2_T_Boolean_0, Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrameLogCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_2_T1_T2_T1_T2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_1_T_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NullSafeInvoke_Public_Static_T_Func_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetHeight_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWidth_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetZ_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetY_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetX_Public_Static_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetX_Public_Static_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetY_Public_Static_Vector2_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistSqr_Public_Static_Single_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistSqrt_Public_Static_Single_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistSqr_Public_Static_Single_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Direct_Public_Static_Vector3_GameObject_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetX_Public_Static_Void_RectTransform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWidth_Public_Static_Void_RectTransform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetHeight_Public_Static_Void_RectTransform_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vector2to3_Public_Static_Vector3_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Div_Public_Static_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentsInAllChildren_Public_Static_List_1_T_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RecursiveSetActive_Private_Static_Void_GameObject_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Public_Static_T_Il2CppArrayBase_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_List_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeepCopy_Public_Static_Void_List_1_T_List_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReduceUntil0_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertRotateUnder180_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSetAlpha_Public_Static_Color_Color_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcPathLength_Public_Static_Single_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FrameLog_Public_Static_Void_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInCondition_Public_Static_Void_List_1_T_Func_2_T_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsIncludeLayer_Public_Static_Boolean_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasSomeFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnlyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_HiddenBodyPartsByCostumeType_HiddenBodyPartsByCostumeType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_DiscomfortDirect_DiscomfortDirect_0;

	public unsafe static NavMeshPath path
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_path, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NavMeshPath>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_path, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int FrameLogCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FrameLogCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FrameLogCount, &num);
		}
	}

	[CallerCount(0)]
	public unsafe static void NullSafeInvoke([DefaultParameterValue(null)] this Il2CppSystem.Action action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80138, XrefRangeEnd = 80143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NullSafeInvoke<T1, T2>([DefaultParameterValue(null)] this Il2CppSystem.Action<T1, T2> action, [DefaultParameterValue(null)] T1 arg1, [DefaultParameterValue(null)] T2 arg2)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		//IL_00c2->IL00c7: Incompatible stack types: I vs Ref
		//IL_00b5->IL00c7: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T1 reference;
		if (!typeof(T1).IsValueType)
		{
			object obj = arg1;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg1;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num2 = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T2 reference2;
		if (!typeof(T2).IsValueType)
		{
			object obj2 = arg2;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj2 as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref arg2;
		}
		*(void**)num2 = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_Void_Action_2_T1_T2_T1_T2_0<T1, T2>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80143, XrefRangeEnd = 80146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void NullSafeInvoke<T>([DefaultParameterValue(null)] this Il2CppSystem.Action<T> action, [DefaultParameterValue(null)] T arg)
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = arg;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr(obj as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref arg;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_Void_Action_1_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80146, XrefRangeEnd = 80154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T NullSafeInvoke<T>([DefaultParameterValue(null)] this Il2CppSystem.Func<T> action)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_NullSafeInvoke_Public_Static_T_Func_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetSetHeight([DefaultParameterValue(null)] this Vector3 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetHeight_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 SetWidth([DefaultParameterValue(null)] this Vector3 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWidth_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetSetZ([DefaultParameterValue(null)] this Vector3 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetZ_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetSetY([DefaultParameterValue(null)] this Vector3 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetY_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 GetSetX([DefaultParameterValue(null)] this Vector3 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetX_Public_Static_Vector3_Vector3_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetSetX([DefaultParameterValue(null)] this Vector2 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetX_Public_Static_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector2 GetSetY([DefaultParameterValue(null)] this Vector2 v, [DefaultParameterValue(null)] float a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetY_Public_Static_Vector2_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(51)]
	[CachedScanResults(RefRangeStart = 80163, RefRangeEnd = 80214, XrefRangeStart = 80154, XrefRangeEnd = 80163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistSqrt([DefaultParameterValue(null)] this GameObject self, [DefaultParameterValue(null)] GameObject other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80214, XrefRangeEnd = 80222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistSqr([DefaultParameterValue(null)] this GameObject self, [DefaultParameterValue(null)] GameObject other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistSqr_Public_Static_Single_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 80227, RefRangeEnd = 80247, XrefRangeStart = 80222, XrefRangeEnd = 80227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistSqrt([DefaultParameterValue(null)] this Transform self, [DefaultParameterValue(null)] Transform other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistSqrt_Public_Static_Single_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80247, XrefRangeEnd = 80251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistSqr([DefaultParameterValue(null)] this Transform self, [DefaultParameterValue(null)] Transform other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistSqr_Public_Static_Single_Transform_Transform_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 80256, RefRangeEnd = 80260, XrefRangeStart = 80251, XrefRangeEnd = 80256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float DistSqrt([DefaultParameterValue(null)] this GameObject self, [DefaultParameterValue(null)] Vector3 other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &other;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 80272, RefRangeEnd = 80278, XrefRangeStart = 80260, XrefRangeEnd = 80272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Direct([DefaultParameterValue(null)] this GameObject self, [DefaultParameterValue(null)] GameObject other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(other);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Direct_Public_Static_Vector3_GameObject_GameObject_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 80304, RefRangeEnd = 80357, XrefRangeStart = 80278, XrefRangeEnd = 80304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyChildren([DefaultParameterValue(null)] this Component gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Component_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80357, XrefRangeEnd = 80361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetSetX([DefaultParameterValue(null)] this RectTransform rect, [DefaultParameterValue(null)] float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetX_Public_Static_Void_RectTransform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 80365, RefRangeEnd = 80370, XrefRangeStart = 80361, XrefRangeEnd = 80365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetWidth([DefaultParameterValue(null)] this RectTransform rect, [DefaultParameterValue(null)] float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWidth_Public_Static_Void_RectTransform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 80374, RefRangeEnd = 80382, XrefRangeStart = 80370, XrefRangeEnd = 80374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetHeight([DefaultParameterValue(null)] this RectTransform rect, [DefaultParameterValue(null)] float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHeight_Public_Static_Void_RectTransform_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static Vector3 Vector2to3([DefaultParameterValue(null)] this Vector2 before)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&before);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vector2to3_Public_Static_Vector3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 Div([DefaultParameterValue(null)] this Vector3 a, [DefaultParameterValue(null)] Vector3 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Div_Public_Static_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80382, XrefRangeEnd = 80388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<T> GetComponentsInAllChildren<T>([DefaultParameterValue(null)] this GameObject gameObject)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObject);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetComponentsInAllChildren_Public_Static_List_1_T_GameObject_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80388, XrefRangeEnd = 80423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RecursiveSetActive<T>([DefaultParameterValue(null)] GameObject a_CheckObject, [DefaultParameterValue(null)] List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a_CheckObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(list);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RecursiveSetActive_Private_Static_Void_GameObject_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 80436, RefRangeEnd = 80441, XrefRangeStart = 80423, XrefRangeEnd = 80436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Shuffle<T>([DefaultParameterValue(null)] this IList<T> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Shuffle_Public_Static_Void_IList_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80441, XrefRangeEnd = 80443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetRandom<T>([DefaultParameterValue(null)] this Il2CppArrayBase<T> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRandom_Public_Static_T_Il2CppArrayBase_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80443, XrefRangeEnd = 80445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRandomIndex<T>([DefaultParameterValue(null)] this Il2CppArrayBase<T> array, int ignore = int.MaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRandomIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80445, XrefRangeEnd = 80448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRandomIndex<T>([DefaultParameterValue(null)] this List<T> array, int ignore = int.MaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ignore;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRandomIndex_Public_Static_Int32_List_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 80451, RefRangeEnd = 80463, XrefRangeStart = 80448, XrefRangeEnd = 80451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T GetRandom<T>([DefaultParameterValue(null)] this List<T> list)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetRandom_Public_Static_T_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80474, XrefRangeStart = 80463, XrefRangeEnd = 80471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeepCopy<T>([DefaultParameterValue(null)] this List<T> source, [DefaultParameterValue(null)] List<T> to)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(to);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DeepCopy_Public_Static_Void_List_1_T_List_1_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static float Dot([DefaultParameterValue(null)] this Vector2 a, [DefaultParameterValue(null)] Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float Cross([DefaultParameterValue(null)] this Vector2 a, [DefaultParameterValue(null)] Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static float ReduceUntil0([DefaultParameterValue(null)] float target, [DefaultParameterValue(null)] float sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&target);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReduceUntil0_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80474, XrefRangeEnd = 80475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float ConvertRotateUnder180([DefaultParameterValue(null)] float val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertRotateUnder180_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Color GetSetAlpha([DefaultParameterValue(null)] this Color c, [DefaultParameterValue(null)] float alpha)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alpha;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSetAlpha_Public_Static_Color_Color_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 80486, RefRangeEnd = 80491, XrefRangeStart = 80475, XrefRangeEnd = 80486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcPathLength([DefaultParameterValue(null)] Vector3 start, [DefaultParameterValue(null)] Vector3 end)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&start);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcPathLength_Public_Static_Single_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80491, XrefRangeEnd = 80502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FrameLog([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] int a)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FrameLog_Public_Static_Void_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 80530, RefRangeEnd = 80532, XrefRangeStart = 80502, XrefRangeEnd = 80530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLayerRecursively([DefaultParameterValue(null)] this GameObject self, [DefaultParameterValue(null)] int layer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &layer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80532, XrefRangeEnd = 80537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveInCondition<T>([DefaultParameterValue(null)] this List<T> list, [DefaultParameterValue(null)] Il2CppSystem.Func<T, bool> condition)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(condition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_RemoveInCondition_Public_Static_Void_List_1_T_Func_2_T_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static bool IsIncludeLayer([DefaultParameterValue(null)] int layerMask, [DefaultParameterValue(null)] int targetLayer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&layerMask);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &targetLayer;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsIncludeLayer_Public_Static_Boolean_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool MyHasFlag([DefaultParameterValue(null)] this ExposedBodyParts self, [DefaultParameterValue(null)] ExposedBodyParts sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&self);
		*(ExposedBodyParts**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool HasSomeFlag([DefaultParameterValue(null)] this ExposedBodyParts self, [DefaultParameterValue(null)] ExposedBodyParts sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&self);
		*(ExposedBodyParts**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasSomeFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool OnlyHasFlag([DefaultParameterValue(null)] this ExposedBodyParts self, [DefaultParameterValue(null)] ExposedBodyParts sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&self);
		*(ExposedBodyParts**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnlyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool MyHasFlag([DefaultParameterValue(null)] this PlayerStateModel.HiddenBodyPartsByCostumeType self, [DefaultParameterValue(null)] PlayerStateModel.HiddenBodyPartsByCostumeType sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&self);
		*(PlayerStateModel.HiddenBodyPartsByCostumeType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_HiddenBodyPartsByCostumeType_HiddenBodyPartsByCostumeType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static bool MyHasFlag([DefaultParameterValue(null)] this Constant.DiscomfortDirect self, [DefaultParameterValue(null)] Constant.DiscomfortDirect sub)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&self);
		*(Constant.DiscomfortDirect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sub;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_DiscomfortDirect_DiscomfortDirect_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static ExternalMethodManager()
	{
		Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "ExternalMethodManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr);
		NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, "path");
		NativeFieldInfoPtr_FrameLogCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, "FrameLogCount");
		NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669185);
		NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_2_T1_T2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669186);
		NativeMethodInfoPtr_NullSafeInvoke_Public_Static_Void_Action_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669187);
		NativeMethodInfoPtr_NullSafeInvoke_Public_Static_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669188);
		NativeMethodInfoPtr_GetSetHeight_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669189);
		NativeMethodInfoPtr_SetWidth_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669190);
		NativeMethodInfoPtr_GetSetZ_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669191);
		NativeMethodInfoPtr_GetSetY_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669192);
		NativeMethodInfoPtr_GetSetX_Public_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669193);
		NativeMethodInfoPtr_GetSetX_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669194);
		NativeMethodInfoPtr_GetSetY_Public_Static_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669195);
		NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669196);
		NativeMethodInfoPtr_DistSqr_Public_Static_Single_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669197);
		NativeMethodInfoPtr_DistSqrt_Public_Static_Single_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669198);
		NativeMethodInfoPtr_DistSqr_Public_Static_Single_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669199);
		NativeMethodInfoPtr_DistSqrt_Public_Static_Single_GameObject_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669200);
		NativeMethodInfoPtr_Direct_Public_Static_Vector3_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669201);
		NativeMethodInfoPtr_DestroyChildren_Public_Static_Void_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669202);
		NativeMethodInfoPtr_GetSetX_Public_Static_Void_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669203);
		NativeMethodInfoPtr_SetWidth_Public_Static_Void_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669204);
		NativeMethodInfoPtr_SetHeight_Public_Static_Void_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669205);
		NativeMethodInfoPtr_Vector2to3_Public_Static_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669206);
		NativeMethodInfoPtr_Div_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669207);
		NativeMethodInfoPtr_GetComponentsInAllChildren_Public_Static_List_1_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669208);
		NativeMethodInfoPtr_RecursiveSetActive_Private_Static_Void_GameObject_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669209);
		NativeMethodInfoPtr_Shuffle_Public_Static_Void_IList_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669210);
		NativeMethodInfoPtr_GetRandom_Public_Static_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669211);
		NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669212);
		NativeMethodInfoPtr_GetRandomIndex_Public_Static_Int32_List_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669213);
		NativeMethodInfoPtr_GetRandom_Public_Static_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669214);
		NativeMethodInfoPtr_DeepCopy_Public_Static_Void_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669215);
		NativeMethodInfoPtr_Dot_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669216);
		NativeMethodInfoPtr_Cross_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669217);
		NativeMethodInfoPtr_ReduceUntil0_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669218);
		NativeMethodInfoPtr_ConvertRotateUnder180_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669219);
		NativeMethodInfoPtr_GetSetAlpha_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669220);
		NativeMethodInfoPtr_CalcPathLength_Public_Static_Single_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669221);
		NativeMethodInfoPtr_FrameLog_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669222);
		NativeMethodInfoPtr_SetLayerRecursively_Public_Static_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669223);
		NativeMethodInfoPtr_RemoveInCondition_Public_Static_Void_List_1_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669224);
		NativeMethodInfoPtr_IsIncludeLayer_Public_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669225);
		NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669226);
		NativeMethodInfoPtr_HasSomeFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669227);
		NativeMethodInfoPtr_OnlyHasFlag_Public_Static_Boolean_ExposedBodyParts_ExposedBodyParts_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669228);
		NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_HiddenBodyPartsByCostumeType_HiddenBodyPartsByCostumeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669229);
		NativeMethodInfoPtr_MyHasFlag_Public_Static_Boolean_DiscomfortDirect_DiscomfortDirect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalMethodManager>.NativeClassPtr, 100669230);
	}

	public ExternalMethodManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
