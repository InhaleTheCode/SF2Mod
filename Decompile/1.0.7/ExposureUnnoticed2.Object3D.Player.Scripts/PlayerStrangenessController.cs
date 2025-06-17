using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerStrangenessController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NightBareyasusa;

	private static readonly System.IntPtr NativeFieldInfoPtr_DaytimeBareyasusa;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxBareyasusa;

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxBareyasusaIncludeBoost;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_isBlockByCostume;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheIsBlockByCostumeFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheIsBlockByCostumeFrontBoob;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheIsBlockByCostumeFrontFuta;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheMaxDiscomfortFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheMaxDiscomfortSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheMaxDiscomfortBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheStrangeFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheStrangeFrontBoob;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheStrangeFrontFuta;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheStrangeSide;

	private static readonly System.IntPtr NativeFieldInfoPtr_cacheStrangeBack;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcActionStrangeScale_Private_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcNoisy_Private_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcSightScale_Private_Single_Transform_Transform_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcMaxDiscomfort_Private_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcCacheMaxDiscomfort_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsInDirect_Private_Boolean_DiscomfortDirect_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcExposeStrange_Private_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static float NightBareyasusa
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NightBareyasusa, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NightBareyasusa, &num);
		}
	}

	public unsafe static float DaytimeBareyasusa
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DaytimeBareyasusa, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DaytimeBareyasusa, &num);
		}
	}

	public unsafe static float MaxBareyasusa
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxBareyasusa, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxBareyasusa, &num);
		}
	}

	public unsafe static float MaxBareyasusaIncludeBoost
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxBareyasusaIncludeBoost, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxBareyasusaIncludeBoost, &num);
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

	public unsafe bool isBlockByCostume
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBlockByCostume);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isBlockByCostume)) = flag;
		}
	}

	public unsafe bool cacheIsBlockByCostumeFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFront);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFront)) = flag;
		}
	}

	public unsafe bool cacheIsBlockByCostumeFrontBoob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFrontBoob);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFrontBoob)) = flag;
		}
	}

	public unsafe bool cacheIsBlockByCostumeFrontFuta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFrontFuta);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheIsBlockByCostumeFrontFuta)) = flag;
		}
	}

	public unsafe float cacheMaxDiscomfortFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortFront)) = num;
		}
	}

	public unsafe float cacheMaxDiscomfortSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortSide);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortSide)) = num;
		}
	}

	public unsafe float cacheMaxDiscomfortBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortBack);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheMaxDiscomfortBack)) = num;
		}
	}

	public unsafe float cacheStrangeFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFront);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFront)) = num;
		}
	}

	public unsafe float cacheStrangeFrontBoob
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFrontBoob);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFrontBoob)) = num;
		}
	}

	public unsafe float cacheStrangeFrontFuta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFrontFuta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeFrontFuta)) = num;
		}
	}

	public unsafe float cacheStrangeSide
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeSide);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeSide)) = num;
		}
	}

	public unsafe float cacheStrangeBack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeBack);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cacheStrangeBack)) = num;
		}
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 4155, RefRangeEnd = 4177, XrefRangeStart = 4155, XrefRangeEnd = 4177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 55993, RefRangeEnd = 55994, XrefRangeStart = 55975, XrefRangeEnd = 55993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 56008, RefRangeEnd = 56010, XrefRangeStart = 55994, XrefRangeEnd = 56008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StrangeData CalcStrangerDegreeFrom([DefaultParameterValue(null)] Transform npcTransform, [DefaultParameterValue(null)] Transform head, [DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(head);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(StrangeData*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe float CalcActionStrangeScale()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcActionStrangeScale_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56038, RefRangeEnd = 56039, XrefRangeStart = 56010, XrefRangeEnd = 56038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcNoisy([DefaultParameterValue(null)] Vector3 npcPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcNoisy_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56066, RefRangeEnd = 56067, XrefRangeStart = 56039, XrefRangeEnd = 56066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcSightScale([DefaultParameterValue(null)] Transform npcTransform, [DefaultParameterValue(null)] Transform head, [DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcTransform);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(head);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcSightScale_Private_Single_Transform_Transform_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56075, RefRangeEnd = 56076, XrefRangeStart = 56067, XrefRangeEnd = 56075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcMaxDiscomfort([DefaultParameterValue(null)] Vector3 npcPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&npcPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcMaxDiscomfort_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56152, RefRangeEnd = 56153, XrefRangeStart = 56076, XrefRangeEnd = 56152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalcCacheMaxDiscomfort()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcCacheMaxDiscomfort_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 56153, XrefRangeEnd = 56158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsInDirect([DefaultParameterValue(null)] Constant.DiscomfortDirect direct, [DefaultParameterValue(null)] bool isFromFront, [DefaultParameterValue(null)] bool isFromBack, [DefaultParameterValue(null)] bool isFromSide)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&direct);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFromFront;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFromBack;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFromSide;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInDirect_Private_Boolean_DiscomfortDirect_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56243, RefRangeEnd = 56244, XrefRangeStart = 56158, XrefRangeEnd = 56243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float CalcExposeStrange([DefaultParameterValue(null)] Vector3 targetPosition)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&targetPosition);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcExposeStrange_Private_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe PlayerStrangenessController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerStrangenessController()
	{
		Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerStrangenessController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr);
		NativeFieldInfoPtr_NightBareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "NightBareyasusa");
		NativeFieldInfoPtr_DaytimeBareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "DaytimeBareyasusa");
		NativeFieldInfoPtr_MaxBareyasusa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "MaxBareyasusa");
		NativeFieldInfoPtr_MaxBareyasusaIncludeBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "MaxBareyasusaIncludeBoost");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_isBlockByCostume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "isBlockByCostume");
		NativeFieldInfoPtr_cacheIsBlockByCostumeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheIsBlockByCostumeFront");
		NativeFieldInfoPtr_cacheIsBlockByCostumeFrontBoob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheIsBlockByCostumeFrontBoob");
		NativeFieldInfoPtr_cacheIsBlockByCostumeFrontFuta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheIsBlockByCostumeFrontFuta");
		NativeFieldInfoPtr_cacheMaxDiscomfortFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheMaxDiscomfortFront");
		NativeFieldInfoPtr_cacheMaxDiscomfortSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheMaxDiscomfortSide");
		NativeFieldInfoPtr_cacheMaxDiscomfortBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheMaxDiscomfortBack");
		NativeFieldInfoPtr_cacheStrangeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheStrangeFront");
		NativeFieldInfoPtr_cacheStrangeFrontBoob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheStrangeFrontBoob");
		NativeFieldInfoPtr_cacheStrangeFrontFuta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheStrangeFrontFuta");
		NativeFieldInfoPtr_cacheStrangeSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheStrangeSide");
		NativeFieldInfoPtr_cacheStrangeBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, "cacheStrangeBack");
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666925);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666926);
		NativeMethodInfoPtr_CalcStrangerDegreeFrom_Public_StrangeData_Transform_Transform_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666927);
		NativeMethodInfoPtr_CalcActionStrangeScale_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666928);
		NativeMethodInfoPtr_CalcNoisy_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666929);
		NativeMethodInfoPtr_CalcSightScale_Private_Single_Transform_Transform_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666930);
		NativeMethodInfoPtr_CalcMaxDiscomfort_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666931);
		NativeMethodInfoPtr_CalcCacheMaxDiscomfort_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666932);
		NativeMethodInfoPtr_IsInDirect_Private_Boolean_DiscomfortDirect_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666933);
		NativeMethodInfoPtr_CalcExposeStrange_Private_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666934);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStrangenessController>.NativeClassPtr, 100666935);
	}

	public PlayerStrangenessController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
