using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class InmouController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_inmouObjects;

	private static readonly IntPtr NativeFieldInfoPtr_pantsObject;

	private static readonly IntPtr NativeFieldInfoPtr_aaa;

	private static readonly IntPtr NativeFieldInfoPtr_bbb;

	private static readonly IntPtr NativeFieldInfoPtr_materialList;

	private static readonly IntPtr NativeFieldInfoPtr_TweakTransparency;

	private static readonly IntPtr NativeFieldInfoPtr_BaseColor;

	private static readonly IntPtr NativeFieldInfoPtr_isHideFromCosplay;

	private static readonly IntPtr NativeFieldInfoPtr_initLocalPosition;

	private static readonly IntPtr NativeFieldInfoPtr_initLocalRotation;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Apply_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetHide_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<GameObject> inmouObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inmouObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inmouObjects), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject pantsObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pantsObject);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pantsObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 aaa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaa);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaa)) = vector;
		}
	}

	public unsafe float bbb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbb);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbb)) = num;
		}
	}

	public unsafe List<Material> materialList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialList);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int TweakTransparency
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TweakTransparency, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TweakTransparency, &num);
		}
	}

	public unsafe static int BaseColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BaseColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BaseColor, &num);
		}
	}

	public unsafe bool isHideFromCosplay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHideFromCosplay);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHideFromCosplay)) = flag;
		}
	}

	public unsafe Vector3 initLocalPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalPosition)) = vector;
		}
	}

	public unsafe Quaternion initLocalRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLocalRotation)) = quaternion;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48881, XrefRangeEnd = 48945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48945, XrefRangeEnd = 48957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 48987, RefRangeEnd = 48990, XrefRangeStart = 48957, XrefRangeEnd = 48987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Apply()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Apply_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48990, XrefRangeEnd = 49011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeBody([DefaultParameterValue(null)] ChangeBodyEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49011, XrefRangeEnd = 49012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetHide([DefaultParameterValue(null)] bool isHide)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isHide);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHide_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49012, XrefRangeEnd = 49021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InmouController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InmouController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InmouController()
	{
		Il2CppClassPointerStore<InmouController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "InmouController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InmouController>.NativeClassPtr);
		NativeFieldInfoPtr_inmouObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "inmouObjects");
		NativeFieldInfoPtr_pantsObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "pantsObject");
		NativeFieldInfoPtr_aaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "aaa");
		NativeFieldInfoPtr_bbb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "bbb");
		NativeFieldInfoPtr_materialList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "materialList");
		NativeFieldInfoPtr_TweakTransparency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "TweakTransparency");
		NativeFieldInfoPtr_BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "BaseColor");
		NativeFieldInfoPtr_isHideFromCosplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "isHideFromCosplay");
		NativeFieldInfoPtr_initLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "initLocalPosition");
		NativeFieldInfoPtr_initLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InmouController>.NativeClassPtr, "initLocalRotation");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666369);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666370);
		NativeMethodInfoPtr_Apply_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666371);
		NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666372);
		NativeMethodInfoPtr_SetHide_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666373);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InmouController>.NativeClassPtr, 100666374);
	}

	public InmouController(IntPtr pointer)
		: base(pointer)
	{
	}
}
