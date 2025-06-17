using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerToeHeelController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_TiptoeStandOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxToeRotateX;

	private static readonly System.IntPtr NativeFieldInfoPtr_DefaultHeelBias;

	private static readonly System.IntPtr NativeFieldInfoPtr__HeelOffset_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_toeRotateX;

	private static readonly System.IntPtr NativeFieldInfoPtr_toeActiveFloat;

	private static readonly System.IntPtr NativeFieldInfoPtr_initToeRotateXL;

	private static readonly System.IntPtr NativeFieldInfoPtr_initToeRotateXR;

	private static readonly System.IntPtr NativeFieldInfoPtr_toeLUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_toeRUp;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_HeelOffset_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_HeelOffset_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float TiptoeStandOffset
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TiptoeStandOffset, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TiptoeStandOffset, &num);
		}
	}

	public unsafe static float MaxToeRotateX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxToeRotateX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxToeRotateX, &num);
		}
	}

	public unsafe static float DefaultHeelBias
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DefaultHeelBias, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DefaultHeelBias, &num);
		}
	}

	public unsafe float _HeelOffset_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelOffset_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HeelOffset_k__BackingField)) = num;
		}
	}

	public unsafe PlayerClassAccessor pca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<PlayerClassAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat toeRotateX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeRotateX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeRotateX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat toeActiveFloat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeActiveFloat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeActiveFloat), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float initToeRotateXL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initToeRotateXL);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initToeRotateXL)) = num;
		}
	}

	public unsafe float initToeRotateXR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initToeRotateXR);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initToeRotateXR)) = num;
		}
	}

	public unsafe Vector3 toeLUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeLUp);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeLUp)) = vector;
		}
	}

	public unsafe Vector3 toeRUp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeRUp);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_toeRUp)) = vector;
		}
	}

	public unsafe float HeelOffset
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HeelOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HeelOffset_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56429, RefRangeEnd = 56430, XrefRangeStart = 56421, XrefRangeEnd = 56429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56498, RefRangeEnd = 56499, XrefRangeStart = 56430, XrefRangeEnd = 56498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56499, XrefRangeEnd = 56506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerToeHeelController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerToeHeelController()
	{
		Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerToeHeelController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr);
		NativeFieldInfoPtr_TiptoeStandOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "TiptoeStandOffset");
		NativeFieldInfoPtr_MaxToeRotateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "MaxToeRotateX");
		NativeFieldInfoPtr_DefaultHeelBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "DefaultHeelBias");
		NativeFieldInfoPtr__HeelOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "<HeelOffset>k__BackingField");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_toeRotateX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "toeRotateX");
		NativeFieldInfoPtr_toeActiveFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "toeActiveFloat");
		NativeFieldInfoPtr_initToeRotateXL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "initToeRotateXL");
		NativeFieldInfoPtr_initToeRotateXR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "initToeRotateXR");
		NativeFieldInfoPtr_toeLUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "toeLUp");
		NativeFieldInfoPtr_toeRUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, "toeRUp");
		NativeMethodInfoPtr_get_HeelOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, 100666944);
		NativeMethodInfoPtr_set_HeelOffset_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, 100666945);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, 100666946);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, 100666947);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerToeHeelController>.NativeClassPtr, 100666948);
	}

	public PlayerToeHeelController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
