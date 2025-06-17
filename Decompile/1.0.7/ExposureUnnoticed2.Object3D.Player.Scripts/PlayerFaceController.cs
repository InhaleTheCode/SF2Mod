using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerFaceController : Il2CppSystem.Object
{
	public enum State
	{
		Idle,
		Iku,
		IkuAfter
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeEyeBig;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeEyeSmall;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeEyeUp;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeEyeYori;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouseA;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouseO;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouthSmile;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouseTangA;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouseTangA2;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeMouseTangLong;

	private static readonly System.IntPtr NativeFieldInfoPtr_ShapeToothTopX;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_tang;

	private static readonly System.IntPtr NativeFieldInfoPtr_blink;

	private static readonly System.IntPtr NativeFieldInfoPtr_fellaMouth01;

	private static readonly System.IntPtr NativeFieldInfoPtr__OverrideFaceId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceDokidoki;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_randCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_blinkTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetFaceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_FaceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_AddEcstasy;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsNoFaceFear;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_ikuAfterRemainTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideFaceId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideFaceId_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBlink_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnTransEcstasy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEndEcstasy_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int ShapeEyeBig
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeEyeBig, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeEyeBig, &num);
		}
	}

	public unsafe static int ShapeEyeSmall
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeEyeSmall, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeEyeSmall, &num);
		}
	}

	public unsafe static int ShapeEyeUp
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeEyeUp, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeEyeUp, &num);
		}
	}

	public unsafe static int ShapeEyeYori
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeEyeYori, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeEyeYori, &num);
		}
	}

	public unsafe static int ShapeMouseA
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouseA, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouseA, &num);
		}
	}

	public unsafe static int ShapeMouseO
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouseO, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouseO, &num);
		}
	}

	public unsafe static int ShapeMouthSmile
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouthSmile, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouthSmile, &num);
		}
	}

	public unsafe static int ShapeMouseTangA
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouseTangA, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouseTangA, &num);
		}
	}

	public unsafe static int ShapeMouseTangA2
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouseTangA2, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouseTangA2, &num);
		}
	}

	public unsafe static int ShapeMouseTangLong
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeMouseTangLong, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeMouseTangLong, &num);
		}
	}

	public unsafe static int ShapeToothTopX
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ShapeToothTopX, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ShapeToothTopX, &num);
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

	public unsafe SmoothFloat tang
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tang);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tang), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat blink
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blink);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blink), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat fellaMouth01
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fellaMouth01);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fellaMouth01), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _OverrideFaceId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OverrideFaceId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__OverrideFaceId_k__BackingField)) = num;
		}
	}

	public unsafe static int FaceDokidoki
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FaceDokidoki, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FaceDokidoki, &num);
		}
	}

	public unsafe static int FaceEcstasy
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FaceEcstasy, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FaceEcstasy, &num);
		}
	}

	public unsafe int randCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randCount)) = num;
		}
	}

	public unsafe float blinkTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_blinkTime)) = num;
		}
	}

	public unsafe bool isEcstasy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEcstasy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEcstasy)) = flag;
		}
	}

	public unsafe int targetFaceId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetFaceId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetFaceId)) = num;
		}
	}

	public unsafe static int FaceId
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FaceId, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FaceId, &num);
		}
	}

	public unsafe static int AddEcstasy
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AddEcstasy, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AddEcstasy, &num);
		}
	}

	public unsafe static int IsNoFaceFear
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsNoFaceFear, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsNoFaceFear, &num);
		}
	}

	public unsafe State currentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState)) = state;
		}
	}

	public unsafe float ikuAfterRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ikuAfterRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ikuAfterRemainTime)) = num;
		}
	}

	public unsafe int OverrideFaceId
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OverrideFaceId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OverrideFaceId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53501, XrefRangeEnd = 53513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53513, XrefRangeEnd = 53525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53564, RefRangeEnd = 53565, XrefRangeStart = 53525, XrefRangeEnd = 53564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53585, RefRangeEnd = 53586, XrefRangeStart = 53565, XrefRangeEnd = 53585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateBlink()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateBlink_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnTransEcstasy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnTransEcstasy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void OnEndEcstasy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEndEcstasy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53717, RefRangeEnd = 53718, XrefRangeStart = 53586, XrefRangeEnd = 53717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53718, XrefRangeEnd = 53938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeBody([DefaultParameterValue(null)] ChangeBodyEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53948, RefRangeEnd = 53949, XrefRangeStart = 53938, XrefRangeEnd = 53948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerFaceController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerFaceController()
	{
		Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerFaceController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr);
		NativeFieldInfoPtr_ShapeEyeBig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeEyeBig");
		NativeFieldInfoPtr_ShapeEyeSmall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeEyeSmall");
		NativeFieldInfoPtr_ShapeEyeUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeEyeUp");
		NativeFieldInfoPtr_ShapeEyeYori = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeEyeYori");
		NativeFieldInfoPtr_ShapeMouseA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouseA");
		NativeFieldInfoPtr_ShapeMouseO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouseO");
		NativeFieldInfoPtr_ShapeMouthSmile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouthSmile");
		NativeFieldInfoPtr_ShapeMouseTangA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouseTangA");
		NativeFieldInfoPtr_ShapeMouseTangA2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouseTangA2");
		NativeFieldInfoPtr_ShapeMouseTangLong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeMouseTangLong");
		NativeFieldInfoPtr_ShapeToothTopX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ShapeToothTopX");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_tang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "tang");
		NativeFieldInfoPtr_blink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "blink");
		NativeFieldInfoPtr_fellaMouth01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "fellaMouth01");
		NativeFieldInfoPtr__OverrideFaceId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "<OverrideFaceId>k__BackingField");
		NativeFieldInfoPtr_FaceDokidoki = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "FaceDokidoki");
		NativeFieldInfoPtr_FaceEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "FaceEcstasy");
		NativeFieldInfoPtr_randCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "randCount");
		NativeFieldInfoPtr_blinkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "blinkTime");
		NativeFieldInfoPtr_isEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "isEcstasy");
		NativeFieldInfoPtr_targetFaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "targetFaceId");
		NativeFieldInfoPtr_FaceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "FaceId");
		NativeFieldInfoPtr_AddEcstasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "AddEcstasy");
		NativeFieldInfoPtr_IsNoFaceFear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "IsNoFaceFear");
		NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "currentState");
		NativeFieldInfoPtr_ikuAfterRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, "ikuAfterRemainTime");
		NativeMethodInfoPtr_get_OverrideFaceId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666794);
		NativeMethodInfoPtr_set_OverrideFaceId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666795);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666796);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666797);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666798);
		NativeMethodInfoPtr_UpdateBlink_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666799);
		NativeMethodInfoPtr_OnTransEcstasy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666800);
		NativeMethodInfoPtr_OnEndEcstasy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666801);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666802);
		NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666803);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerFaceController>.NativeClassPtr, 100666804);
	}

	public PlayerFaceController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
