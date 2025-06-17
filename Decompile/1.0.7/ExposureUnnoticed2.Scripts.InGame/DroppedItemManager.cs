using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Master.Item;
using ExposureUnnoticed2.Master.Stage;
using ExposureUnnoticed2.Object3D.DropedCoat;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class DroppedItemManager : Il2CppSystem.Object
{
	public enum DropItemType
	{
		None = -1,
		Coat = 0,
		Hoodie = 1,
		Basket = 2,
		Pants = 3,
		Bra = 4,
		HandcuffKey = 5,
		VibeRemocon = 6,
		DildoFloor = 10000,
		DildoWall = 10100
	}

	public class DropData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_IsDropped;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsReserve;

		private static readonly System.IntPtr NativeFieldInfoPtr_IsViewCompassInDroneMission;

		private static readonly System.IntPtr NativeFieldInfoPtr_Position;

		private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_StageType;

		private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DropItemType_0;

		public unsafe bool IsDropped
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDropped);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDropped)) = flag;
			}
		}

		public unsafe bool IsReserve
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReserve);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsReserve)) = flag;
			}
		}

		public unsafe bool IsViewCompassInDroneMission
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsViewCompassInDroneMission);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsViewCompassInDroneMission)) = flag;
			}
		}

		public unsafe Vector3 Position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Position)) = vector;
			}
		}

		public unsafe Quaternion Rotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rotation)) = quaternion;
			}
		}

		public unsafe StageType StageType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageType);
				return *(StageType*)num;
			}
			set
			{
				*(StageType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_StageType)) = stageType;
			}
		}

		public unsafe DropItemType ItemType
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemType);
				return *(DropItemType*)num;
			}
			set
			{
				*(DropItemType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemType)) = dropItemType;
			}
		}

		[CallerCount(0)]
		public unsafe DropData([DefaultParameterValue(null)] DropItemType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&type);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static DropData()
		{
			Il2CppClassPointerStore<DropData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, "DropData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropData>.NativeClassPtr);
			NativeFieldInfoPtr_IsDropped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "IsDropped");
			NativeFieldInfoPtr_IsReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "IsReserve");
			NativeFieldInfoPtr_IsViewCompassInDroneMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "IsViewCompassInDroneMission");
			NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "Position");
			NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "Rotation");
			NativeFieldInfoPtr_StageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "StageType");
			NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropData>.NativeClassPtr, "ItemType");
			NativeMethodInfoPtr__ctor_Public_Void_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropData>.NativeClassPtr, 100668673);
		}

		public DropData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MaxSamePutNum;

	private static readonly System.IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_cache;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClothesTypes;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_DroppedItemManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DroppedItemManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsClothes_Public_Boolean_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCache_Public_DroppedItemController_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyReserveDropIfNeed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Drop_Public_DropData_Vector3_Quaternion_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDropClothesType_Public_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransNonUseItemId_Public_DropItemType_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReserveDrop_Public_DropData_DropItemType_StageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SendToHome_Public_Void_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Private_Void_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushInElevator_Public_Void_Bounds_Vector3_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WarpElevatorHeight_Public_Void_Single_Bounds_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Collect_Public_Void_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideAllUnderwear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectAll_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsPutSomeDildoAtOutsideHome_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DisposeAllPutDildo_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CollectAllClothes_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDropClothesInSameArea_Public_DropData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ActiveDroppedItemIfNeed_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDildo_Private_Boolean_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDropItemType_Public_Static_DropItemType_ClothesType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToClothesType_Public_Static_ClothesType_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToItemType_Public_Static_ItemType_DropItemType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ApplyReserveDropIfNeed_b__12_0_Private_Boolean_DropData_0;

	public unsafe static int MaxSamePutNum
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxSamePutNum, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxSamePutNum, &num);
		}
	}

	public unsafe static DroppedItemManager _Instance_k__BackingField
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Instance_k__BackingField, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Instance_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<DropItemType, DroppedItemController> cache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<DropItemType, DroppedItemController>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<DropItemType> ClothesTypes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesTypes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<DropItemType>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClothesTypes), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static DroppedItemManager Instance
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72790, XrefRangeEnd = 72792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_DroppedItemManager_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemManager>(intPtr) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72792, XrefRangeEnd = 72795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DroppedItemManager_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72795, XrefRangeEnd = 72808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DroppedItemManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72808, XrefRangeEnd = 72809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72809, XrefRangeEnd = 72810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsClothes([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsClothes_Public_Boolean_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 72855, RefRangeEnd = 72863, XrefRangeStart = 72810, XrefRangeEnd = 72855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DroppedItemController GetCache([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCache_Public_DroppedItemController_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DroppedItemController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72863, XrefRangeEnd = 72881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyReserveDropIfNeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyReserveDropIfNeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 72929, RefRangeEnd = 72937, XrefRangeStart = 72881, XrefRangeEnd = 72929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropData Drop([DefaultParameterValue(null)] Vector3 position, [DefaultParameterValue(null)] Quaternion rotation, [DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&position);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		*(DropItemType**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Drop_Public_DropData_Vector3_Quaternion_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DropData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72937, XrefRangeEnd = 72943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropItemType GetDropClothesType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDropClothesType_Public_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DropItemType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 72948, RefRangeEnd = 72951, XrefRangeStart = 72943, XrefRangeEnd = 72948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropItemType TransNonUseItemId([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransNonUseItemId_Public_DropItemType_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DropItemType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72951, XrefRangeEnd = 72959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropData ReserveDrop([DefaultParameterValue(null)] DropItemType itemType, [DefaultParameterValue(null)] StageType stageType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&itemType);
		*(StageType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stageType;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReserveDrop_Public_DropData_DropItemType_StageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DropData>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72959, XrefRangeEnd = 72972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendToHome([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SendToHome_Public_Void_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 72982, RefRangeEnd = 72988, XrefRangeStart = 72972, XrefRangeEnd = 72982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Hide_Private_Void_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73017, RefRangeEnd = 73018, XrefRangeStart = 72988, XrefRangeEnd = 73017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushInElevator([DefaultParameterValue(null)] Bounds pushBounds, [DefaultParameterValue(null)] Vector3 pushV, bool isFixed = false, bool isConstant = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&pushBounds);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pushV;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isFixed;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isConstant;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushInElevator_Public_Void_Bounds_Vector3_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 73042, RefRangeEnd = 73043, XrefRangeStart = 73018, XrefRangeEnd = 73042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WarpElevatorHeight([DefaultParameterValue(null)] float y, [DefaultParameterValue(null)] Bounds pushBounds)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(Bounds**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pushBounds;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WarpElevatorHeight_Public_Void_Single_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 73050, RefRangeEnd = 73067, XrefRangeStart = 73043, XrefRangeEnd = 73050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Collect([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Collect_Public_Void_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73067, XrefRangeEnd = 73069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAllUnderwear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideAllUnderwear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73085, RefRangeEnd = 73087, XrefRangeStart = 73069, XrefRangeEnd = 73085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CollectAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectAll_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73097, RefRangeEnd = 73099, XrefRangeStart = 73087, XrefRangeEnd = 73097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPutSomeDildoAtOutsideHome()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsPutSomeDildoAtOutsideHome_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 73112, RefRangeEnd = 73114, XrefRangeStart = 73099, XrefRangeEnd = 73112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DisposeAllPutDildo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DisposeAllPutDildo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73114, XrefRangeEnd = 73121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CollectAllClothes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CollectAllClothes_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 73133, RefRangeEnd = 73146, XrefRangeStart = 73121, XrefRangeEnd = 73133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DropData GetDropClothesInSameArea()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDropClothesInSameArea_Public_DropData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DropData>(intPtr) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 73161, RefRangeEnd = 73164, XrefRangeStart = 73146, XrefRangeEnd = 73161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActiveDroppedItemIfNeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ActiveDroppedItemIfNeed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsDildo([DefaultParameterValue(null)] DropItemType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDildo_Private_Boolean_DropItemType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static DropItemType ToDropItemType([DefaultParameterValue(null)] ClothesType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDropItemType_Public_Static_DropItemType_ClothesType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(DropItemType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static ClothesType ToClothesType([DefaultParameterValue(null)] DropItemType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToClothesType_Public_Static_ClothesType_DropItemType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ClothesType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static ItemType ToItemType([DefaultParameterValue(null)] DropItemType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToItemType_Public_Static_ItemType_DropItemType_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ItemType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73164, XrefRangeEnd = 73181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _ApplyReserveDropIfNeed_b__12_0([DefaultParameterValue(null)] DropData reserveData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reserveData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ApplyReserveDropIfNeed_b__12_0_Private_Boolean_DropData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static DroppedItemManager()
	{
		Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "DroppedItemManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr);
		NativeFieldInfoPtr_MaxSamePutNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, "MaxSamePutNum");
		NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, "<Instance>k__BackingField");
		NativeFieldInfoPtr_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, "cache");
		NativeFieldInfoPtr_ClothesTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, "ClothesTypes");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668645);
		NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_DroppedItemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668646);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668647);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668648);
		NativeMethodInfoPtr_IsClothes_Public_Boolean_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668649);
		NativeMethodInfoPtr_GetCache_Public_DroppedItemController_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668650);
		NativeMethodInfoPtr_ApplyReserveDropIfNeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668651);
		NativeMethodInfoPtr_Drop_Public_DropData_Vector3_Quaternion_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668652);
		NativeMethodInfoPtr_GetDropClothesType_Public_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668653);
		NativeMethodInfoPtr_TransNonUseItemId_Public_DropItemType_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668654);
		NativeMethodInfoPtr_ReserveDrop_Public_DropData_DropItemType_StageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668655);
		NativeMethodInfoPtr_SendToHome_Public_Void_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668656);
		NativeMethodInfoPtr_Hide_Private_Void_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668657);
		NativeMethodInfoPtr_PushInElevator_Public_Void_Bounds_Vector3_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668658);
		NativeMethodInfoPtr_WarpElevatorHeight_Public_Void_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668659);
		NativeMethodInfoPtr_Collect_Public_Void_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668660);
		NativeMethodInfoPtr_HideAllUnderwear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668661);
		NativeMethodInfoPtr_CollectAll_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668662);
		NativeMethodInfoPtr_IsPutSomeDildoAtOutsideHome_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668663);
		NativeMethodInfoPtr_DisposeAllPutDildo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668664);
		NativeMethodInfoPtr_CollectAllClothes_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668665);
		NativeMethodInfoPtr_GetDropClothesInSameArea_Public_DropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668666);
		NativeMethodInfoPtr_ActiveDroppedItemIfNeed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668667);
		NativeMethodInfoPtr_IsDildo_Private_Boolean_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668668);
		NativeMethodInfoPtr_ToDropItemType_Public_Static_DropItemType_ClothesType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668669);
		NativeMethodInfoPtr_ToClothesType_Public_Static_ClothesType_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668670);
		NativeMethodInfoPtr_ToItemType_Public_Static_ItemType_DropItemType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668671);
		NativeMethodInfoPtr__ApplyReserveDropIfNeed_b__12_0_Private_Boolean_DropData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DroppedItemManager>.NativeClassPtr, 100668672);
	}

	public DroppedItemManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
