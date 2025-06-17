using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public static class Extensions : Il2CppSystem.Object
{
	private sealed class MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Component_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyTo_Public_Static_Void_Component_T_0, Il2CppClassPointerStore<Extensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Static_Void_Component_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41019, XrefRangeEnd = 41035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyTo<T>([DefaultParameterValue(null)] this Component comp, [DefaultParameterValue(null)] T target) where T : Component, new()
	{
		//IL_006c->IL0071: Incompatible stack types: I vs Ref
		//IL_005f->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(comp);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = target;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr(val as Il2CppObjectBase) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref target;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyTo_Public_Static_Void_Component_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41035, XrefRangeEnd = 41052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsVisibleFrom([DefaultParameterValue(null)] this Renderer renderer, [DefaultParameterValue(null)] Camera camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(camera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static Extensions()
	{
		Il2CppClassPointerStore<Extensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "Extensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Extensions>.NativeClassPtr);
		NativeMethodInfoPtr_CopyTo_Public_Static_Void_Component_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665586);
		NativeMethodInfoPtr_IsVisibleFrom_Public_Static_Boolean_Renderer_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Extensions>.NativeClassPtr, 100665587);
	}

	public Extensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
