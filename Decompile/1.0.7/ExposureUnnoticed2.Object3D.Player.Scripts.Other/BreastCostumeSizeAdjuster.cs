using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Other;

public class BreastCostumeSizeAdjuster : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_bigIndex;

	private static readonly IntPtr NativeFieldInfoPtr_smallIndex;

	private static readonly IntPtr NativeFieldInfoPtr_integrateIndex;

	private static readonly IntPtr NativeFieldInfoPtr_overBigIndex;

	private static readonly IntPtr NativeFieldInfoPtr_chikubiIndex;

	private static readonly IntPtr NativeFieldInfoPtr_moreBigFixIndex;

	private static readonly IntPtr NativeFieldInfoPtr_addChikubiSizeBlendScale;

	private static readonly IntPtr NativeFieldInfoPtr_maxBigOffset;

	private static readonly IntPtr NativeFieldInfoPtr_maxSmallOffset;

	private static readonly IntPtr NativeFieldInfoPtr_moreBigFixMax;

	private static readonly IntPtr NativeFieldInfoPtr_bigMax;

	private static readonly IntPtr NativeFieldInfoPtr_mesh;

	private static readonly IntPtr NativeFieldInfoPtr__IsForceFlattenTit_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsForceFlattenTit_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_IsForceFlattenTit_Public_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnEnable_b__18_0_Private_Void_0;

	public unsafe int bigIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigIndex)) = num;
		}
	}

	public unsafe int smallIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_smallIndex)) = num;
		}
	}

	public unsafe int integrateIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrateIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_integrateIndex)) = num;
		}
	}

	public unsafe int overBigIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overBigIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_overBigIndex)) = num;
		}
	}

	public unsafe int chikubiIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chikubiIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_chikubiIndex)) = num;
		}
	}

	public unsafe int moreBigFixIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreBigFixIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreBigFixIndex)) = num;
		}
	}

	public unsafe int addChikubiSizeBlendScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addChikubiSizeBlendScale);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addChikubiSizeBlendScale)) = num;
		}
	}

	public unsafe int maxBigOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBigOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxBigOffset)) = num;
		}
	}

	public unsafe int maxSmallOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSmallOffset);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSmallOffset)) = num;
		}
	}

	public unsafe int moreBigFixMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreBigFixMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_moreBigFixMax)) = num;
		}
	}

	public unsafe int bigMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bigMax)) = num;
		}
	}

	public unsafe SkinnedMeshRenderer mesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mesh), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool _IsForceFlattenTit_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsForceFlattenTit_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsForceFlattenTit_k__BackingField)) = flag;
		}
	}

	public unsafe bool IsForceFlattenTit
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsForceFlattenTit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsForceFlattenTit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56698, XrefRangeEnd = 56713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56713, XrefRangeEnd = 56725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56725, XrefRangeEnd = 56732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56732, XrefRangeEnd = 56738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56749, RefRangeEnd = 56750, XrefRangeStart = 56738, XrefRangeEnd = 56749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56750, XrefRangeEnd = 56753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BreastCostumeSizeAdjuster()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56753, XrefRangeEnd = 56754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnEnable_b__18_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnEnable_b__18_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BreastCostumeSizeAdjuster()
	{
		Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Other", "BreastCostumeSizeAdjuster");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr);
		NativeFieldInfoPtr_bigIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "bigIndex");
		NativeFieldInfoPtr_smallIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "smallIndex");
		NativeFieldInfoPtr_integrateIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "integrateIndex");
		NativeFieldInfoPtr_overBigIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "overBigIndex");
		NativeFieldInfoPtr_chikubiIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "chikubiIndex");
		NativeFieldInfoPtr_moreBigFixIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "moreBigFixIndex");
		NativeFieldInfoPtr_addChikubiSizeBlendScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "addChikubiSizeBlendScale");
		NativeFieldInfoPtr_maxBigOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "maxBigOffset");
		NativeFieldInfoPtr_maxSmallOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "maxSmallOffset");
		NativeFieldInfoPtr_moreBigFixMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "moreBigFixMax");
		NativeFieldInfoPtr_bigMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "bigMax");
		NativeFieldInfoPtr_mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "mesh");
		NativeFieldInfoPtr__IsForceFlattenTit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, "<IsForceFlattenTit>k__BackingField");
		NativeMethodInfoPtr_get_IsForceFlattenTit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666973);
		NativeMethodInfoPtr_set_IsForceFlattenTit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666974);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666975);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666976);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666977);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666978);
		NativeMethodInfoPtr_OnChangeBody_Private_Void_ChangeBodyEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666979);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666980);
		NativeMethodInfoPtr__OnEnable_b__18_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BreastCostumeSizeAdjuster>.NativeClassPtr, 100666981);
	}

	public BreastCostumeSizeAdjuster(IntPtr pointer)
		: base(pointer)
	{
	}
}
