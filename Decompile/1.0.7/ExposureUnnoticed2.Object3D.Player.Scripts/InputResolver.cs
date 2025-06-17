using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.ObjectUI.InGame.RingMenu;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class InputResolver : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_oldMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_RingShortcutInput;

	private static readonly System.IntPtr NativeFieldInfoPtr_inputData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_InputData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPoseSkillInput_Public_Static_Boolean_RingItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 oldMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldMove);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldMove)) = vector;
		}
	}

	public unsafe static RingMenuParentView.RingItemType RingShortcutInput
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out RingMenuParentView.RingItemType result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_RingShortcutInput, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_RingShortcutInput, &ringItemType);
		}
	}

	public unsafe InputData inputData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inputData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49099, RefRangeEnd = 49100, XrefRangeStart = 49025, XrefRangeEnd = 49099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputData Resolve()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_InputData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InputData>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsPoseSkillInput([DefaultParameterValue(null)] RingMenuParentView.RingItemType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPoseSkillInput_Public_Static_Boolean_RingItemType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49100, XrefRangeEnd = 49103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InputResolver()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputResolver>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InputResolver()
	{
		Il2CppClassPointerStore<InputResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "InputResolver");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputResolver>.NativeClassPtr);
		NativeFieldInfoPtr_oldMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, "oldMove");
		NativeFieldInfoPtr_RingShortcutInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, "RingShortcutInput");
		NativeFieldInfoPtr_inputData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, "inputData");
		NativeMethodInfoPtr_Resolve_Public_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, 100666378);
		NativeMethodInfoPtr_IsPoseSkillInput_Public_Static_Boolean_RingItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, 100666379);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputResolver>.NativeClassPtr, 100666380);
	}

	public InputResolver(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
