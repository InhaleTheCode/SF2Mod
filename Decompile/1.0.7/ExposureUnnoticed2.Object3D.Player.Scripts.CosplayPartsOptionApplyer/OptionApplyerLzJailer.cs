using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.CosplayPartsOptionApplyer;

public class OptionApplyerLzJailer : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_materialTextureTypes;

	private static readonly IntPtr NativeFieldInfoPtr_matcapTexture;

	private static readonly IntPtr NativeFieldInfoPtr_partsId;

	private static readonly IntPtr NativeFieldInfoPtr_targetMaterialIndex;

	private static readonly IntPtr NativeFieldInfoPtr_meshRenderer;

	private static readonly IntPtr NativeFieldInfoPtr_uniqueId;

	private static readonly IntPtr NativeFieldInfoPtr_oldMaterialIndex;

	private static readonly IntPtr NativeFieldInfoPtr_mats;

	private static readonly IntPtr NativeFieldInfoPtr_BaseColor;

	private static readonly IntPtr NativeFieldInfoPtr_FirstShadeColor;

	private static readonly IntPtr NativeFieldInfoPtr_MatCapSampler;

	private static readonly IntPtr NativeFieldInfoPtr_MainTex;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppReferenceArray<Texture> materialTextureTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialTextureTypes);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialTextureTypes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Texture> matcapTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matcapTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_matcapTexture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int partsId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partsId)) = num;
		}
	}

	public unsafe int targetMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetMaterialIndex)) = num;
		}
	}

	public unsafe SkinnedMeshRenderer meshRenderer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_meshRenderer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int uniqueId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId)) = num;
		}
	}

	public unsafe int oldMaterialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldMaterialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldMaterialIndex)) = num;
		}
	}

	public unsafe Il2CppReferenceArray<Material> mats
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mats);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mats), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe static int FirstShadeColor
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FirstShadeColor, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FirstShadeColor, &num);
		}
	}

	public unsafe static int MatCapSampler
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MatCapSampler, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MatCapSampler, &num);
		}
	}

	public unsafe static int MainTex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MainTex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MainTex, &num);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59042, XrefRangeEnd = 59074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59074, XrefRangeEnd = 59086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59086, XrefRangeEnd = 59087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeEvent([DefaultParameterValue(null)] ChangeCosplayPartsOptionEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 59113, RefRangeEnd = 59114, XrefRangeStart = 59087, XrefRangeEnd = 59113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyFromGameState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59114, XrefRangeEnd = 59117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OptionApplyerLzJailer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OptionApplyerLzJailer()
	{
		Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.CosplayPartsOptionApplyer", "OptionApplyerLzJailer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr);
		NativeFieldInfoPtr_materialTextureTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "materialTextureTypes");
		NativeFieldInfoPtr_matcapTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "matcapTexture");
		NativeFieldInfoPtr_partsId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "partsId");
		NativeFieldInfoPtr_targetMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "targetMaterialIndex");
		NativeFieldInfoPtr_meshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "meshRenderer");
		NativeFieldInfoPtr_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "uniqueId");
		NativeFieldInfoPtr_oldMaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "oldMaterialIndex");
		NativeFieldInfoPtr_mats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "mats");
		NativeFieldInfoPtr_BaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "BaseColor");
		NativeFieldInfoPtr_FirstShadeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "FirstShadeColor");
		NativeFieldInfoPtr_MatCapSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "MatCapSampler");
		NativeFieldInfoPtr_MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, "MainTex");
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, 100667199);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, 100667200);
		NativeMethodInfoPtr_OnChangeEvent_Private_Void_ChangeCosplayPartsOptionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, 100667201);
		NativeMethodInfoPtr_ApplyFromGameState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, 100667202);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionApplyerLzJailer>.NativeClassPtr, 100667203);
	}

	public OptionApplyerLzJailer(IntPtr pointer)
		: base(pointer)
	{
	}
}
