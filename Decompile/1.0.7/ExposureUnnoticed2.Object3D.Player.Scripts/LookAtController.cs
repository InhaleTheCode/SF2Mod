using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class LookAtController : Il2CppSystem.Object
{
	public enum LookAtLayer
	{
		Base,
		NpcTalkTarget,
		NpcForeignObject,
		NpcLookPlayer,
		LookNpc,
		Strafe,
		Closet,
		Bareta,
		FoundStranger
	}

	public class LookAtModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Target;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsForceLook;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsLookTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_Layer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LookAtLayer_0;

		public unsafe Transform Target
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Target);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe bool IsForceLook
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsForceLook);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsForceLook)) = flag;
			}
		}

		public unsafe bool IsLookTarget
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookTarget);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsLookTarget)) = flag;
			}
		}

		public unsafe LookAtLayer Layer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Layer);
				return *(LookAtLayer*)num;
			}
			set
			{
				*(LookAtLayer*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Layer)) = lookAtLayer;
			}
		}

		[CallerCount(0)]
		public unsafe LookAtModel([DefaultParameterValue(null)] LookAtLayer layer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&layer);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LookAtLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static LookAtModel()
		{
			Il2CppClassPointerStore<LookAtModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "LookAtModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr);
			NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr, "Target");
			NativeFieldInfoPtr_IsForceLook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr, "IsForceLook");
			NativeFieldInfoPtr_IsLookTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr, "IsLookTarget");
			NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr, "Layer");
			NativeMethodInfoPtr__ctor_Public_Void_LookAtLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtModel>.NativeClassPtr, 100666396);
		}

		public LookAtModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Head;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentCharacterTransform;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookCameraHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookCameraTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPlayer;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_layerMaskLookNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_lookAtDict;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableLookAt_Public_Void_LookAtLayer_Transform_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableLookAt_Public_Void_LookAtLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisableAll_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEnable_Public_Boolean_LookAtLayer_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeForPlayer_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeForNpc_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeLookAtDict_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateForPlayer_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateForNpc_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetModel_Private_LookAtModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCommon_Private_Void_LookAtModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePlayerLookAt_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SearchHead_Private_Transform_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform Head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Head);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Head), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform parentCharacterTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentCharacterTransform);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentCharacterTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform lookCameraHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookCameraHead);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookCameraHead), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform lookCameraTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookCameraTarget);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookCameraTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isPlayer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayer);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPlayer)) = flag;
		}
	}

	public unsafe int layerMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMask)) = num;
		}
	}

	public unsafe int layerMaskLookNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMaskLookNpc);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_layerMaskLookNpc)) = num;
		}
	}

	public unsafe Dictionary<LookAtLayer, LookAtModel> lookAtDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<LookAtLayer, LookAtModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lookAtDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 49106, RefRangeEnd = 49114, XrefRangeStart = 49103, XrefRangeEnd = 49106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableLookAt([DefaultParameterValue(null)] LookAtLayer layer, [DefaultParameterValue(null)] Transform target, bool isForceTarget = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&layer);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(target);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isForceTarget;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableLookAt_Public_Void_LookAtLayer_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 49117, RefRangeEnd = 49126, XrefRangeStart = 49114, XrefRangeEnd = 49117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableLookAt([DefaultParameterValue(null)] LookAtLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableLookAt_Public_Void_LookAtLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49135, RefRangeEnd = 49136, XrefRangeStart = 49126, XrefRangeEnd = 49135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisableAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisableAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49139, RefRangeEnd = 49141, XrefRangeStart = 49136, XrefRangeEnd = 49139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsEnable([DefaultParameterValue(null)] LookAtLayer layer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&layer);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEnable_Public_Boolean_LookAtLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49203, RefRangeEnd = 49204, XrefRangeStart = 49141, XrefRangeEnd = 49203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeForPlayer([DefaultParameterValue(null)] PlayerClassAccessor pca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeForPlayer_Public_Void_PlayerClassAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49278, RefRangeEnd = 49279, XrefRangeStart = 49204, XrefRangeEnd = 49278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeForNpc([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeForNpc_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49318, RefRangeEnd = 49320, XrefRangeStart = 49279, XrefRangeEnd = 49318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeLookAtDict()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeLookAtDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 49325, RefRangeEnd = 49328, XrefRangeStart = 49320, XrefRangeEnd = 49325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49328, XrefRangeEnd = 49331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateForPlayer()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateForPlayer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 49331, XrefRangeEnd = 49333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateForNpc()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateForNpc_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 49345, RefRangeEnd = 49349, XrefRangeStart = 49333, XrefRangeEnd = 49345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LookAtModel GetTargetModel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTargetModel_Private_LookAtModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<LookAtModel>(intPtr) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 49467, RefRangeEnd = 49471, XrefRangeStart = 49349, XrefRangeEnd = 49467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCommon([DefaultParameterValue(null)] LookAtModel model)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCommon_Private_Void_LookAtModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49476, RefRangeEnd = 49478, XrefRangeStart = 49471, XrefRangeEnd = 49476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePlayerLookAt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdatePlayerLookAt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 49515, RefRangeEnd = 49516, XrefRangeStart = 49478, XrefRangeEnd = 49515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Transform SearchHead([DefaultParameterValue(null)] Transform start)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SearchHead_Private_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 49522, RefRangeEnd = 49524, XrefRangeStart = 49516, XrefRangeEnd = 49522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LookAtController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LookAtController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LookAtController()
	{
		Il2CppClassPointerStore<LookAtController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "LookAtController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LookAtController>.NativeClassPtr);
		NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "Head");
		NativeFieldInfoPtr_parentCharacterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "parentCharacterTransform");
		NativeFieldInfoPtr_lookCameraHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "lookCameraHead");
		NativeFieldInfoPtr_lookCameraTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "lookCameraTarget");
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_isPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "isPlayer");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "layerMask");
		NativeFieldInfoPtr_layerMaskLookNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "layerMaskLookNpc");
		NativeFieldInfoPtr_lookAtDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, "lookAtDict");
		NativeMethodInfoPtr_EnableLookAt_Public_Void_LookAtLayer_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666381);
		NativeMethodInfoPtr_DisableLookAt_Public_Void_LookAtLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666382);
		NativeMethodInfoPtr_DisableAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666383);
		NativeMethodInfoPtr_IsEnable_Public_Boolean_LookAtLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666384);
		NativeMethodInfoPtr_InitializeForPlayer_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666385);
		NativeMethodInfoPtr_InitializeForNpc_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666386);
		NativeMethodInfoPtr_InitializeLookAtDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666387);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666388);
		NativeMethodInfoPtr_UpdateForPlayer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666389);
		NativeMethodInfoPtr_UpdateForNpc_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666390);
		NativeMethodInfoPtr_GetTargetModel_Private_LookAtModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666391);
		NativeMethodInfoPtr_UpdateCommon_Private_Void_LookAtModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666392);
		NativeMethodInfoPtr_UpdatePlayerLookAt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666393);
		NativeMethodInfoPtr_SearchHead_Private_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666394);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LookAtController>.NativeClassPtr, 100666395);
	}

	public LookAtController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
