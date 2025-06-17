using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Clothes;
using ExposureUnnoticed2.Object3D.Environment.ChangingRoom;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.InGame;

public class FashionShopManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_Prefix;

	private static readonly IntPtr NativeFieldInfoPtr_DropBasketKey;

	private static readonly IntPtr NativeFieldInfoPtr_BasketKey;

	private static readonly IntPtr NativeFieldInfoPtr_IsSavedKey;

	private static readonly IntPtr NativeFieldInfoPtr_CurrentTryClothesKey;

	private static readonly IntPtr NativeFieldInfoPtr_LastOwnClothesKey;

	private static readonly IntPtr NativeFieldInfoPtr_Instance;

	private static readonly IntPtr NativeFieldInfoPtr_tryOnArea;

	private static readonly IntPtr NativeFieldInfoPtr_curtainController;

	private static readonly IntPtr NativeFieldInfoPtr_clerk;

	private static readonly IntPtr NativeFieldInfoPtr_clerkInteractTransform;

	private static readonly IntPtr NativeFieldInfoPtr__CurrentTryClothes_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__LastOwnClothes_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_basket;

	private static readonly IntPtr NativeFieldInfoPtr_basketPosition;

	private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTryClothes_Public_get_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTryClothes_Public_set_Void_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_LastOwnClothes_Public_get_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_LastOwnClothes_Public_set_Void_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAll_Public_List_1_MClothesRecord_0;

	private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_ScriptableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_ScriptableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_ScriptableObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SaveDropBasket_Public_Static_Void_Vector3_0;

	private static readonly IntPtr NativeMethodInfoPtr_CheckDisplayBasket_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsWearTryClothes_Public_Static_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_IsInTryArea_Public_Static_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetBasketRp_Public_Virtual_Final_New_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnConversationEvent_Private_Void_ConversationEvent_0;

	private static readonly IntPtr NativeMethodInfoPtr_Trans_Private_MClothesRecord_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnConversationEvent_b__32_0_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__OnConversationEvent_b__32_1_Private_Void_0;

	public unsafe static string Prefix
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Prefix, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Prefix, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string DropBasketKey
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_DropBasketKey, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_DropBasketKey, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string BasketKey
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_BasketKey, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_BasketKey, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string IsSavedKey
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsSavedKey, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsSavedKey, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string CurrentTryClothesKey
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentTryClothesKey, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentTryClothesKey, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static string LastOwnClothesKey
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LastOwnClothesKey, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LastOwnClothesKey, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static FashionShopManager Instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<FashionShopManager>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerEnterAreaChecker tryOnArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryOnArea);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerEnterAreaChecker>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_tryOnArea), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ChangingRoomCurtainController curtainController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curtainController);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ChangingRoomCurtainController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_curtainController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Animator clerk
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clerk);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clerk), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform clerkInteractTransform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clerkInteractTransform);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clerkInteractTransform), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MClothesRecord _CurrentTryClothes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentTryClothes_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentTryClothes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe MClothesRecord _LastOwnClothes_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastOwnClothes_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__LastOwnClothes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<MClothesRecord> basket
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basket);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MClothesRecord>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basket), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Vector3 basketPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basketPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_basketPosition)) = vector;
		}
	}

	public unsafe MClothesRecord CurrentTryClothes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentTryClothes_Public_get_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41574, RefRangeEnd = 41582, XrefRangeStart = 41574, XrefRangeEnd = 41582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentTryClothes_Public_set_Void_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe MClothesRecord LastOwnClothes
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LastOwnClothes_Public_get_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
		}
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 29631, RefRangeEnd = 29651, XrefRangeStart = 29631, XrefRangeEnd = 29651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LastOwnClothes_Public_set_Void_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76579, XrefRangeEnd = 76594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76594, XrefRangeEnd = 76609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe List<MClothesRecord> GetAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAll_Public_List_1_MClothesRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<MClothesRecord>>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 76612, RefRangeEnd = 76614, XrefRangeStart = 76609, XrefRangeEnd = 76612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Contains([DefaultParameterValue(null)] ScriptableObject master)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76614, XrefRangeEnd = 76623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Add([DefaultParameterValue(null)] ScriptableObject master)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76623, XrefRangeEnd = 76630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Remove([DefaultParameterValue(null)] ScriptableObject master)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(master);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 76642, RefRangeEnd = 76647, XrefRangeStart = 76630, XrefRangeEnd = 76642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveDropBasket([DefaultParameterValue(null)] Vector3 position)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&position);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveDropBasket_Public_Static_Void_Vector3_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 76652, RefRangeEnd = 76655, XrefRangeStart = 76647, XrefRangeEnd = 76652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDisplayBasket()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDisplayBasket_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 76670, RefRangeEnd = 76672, XrefRangeStart = 76655, XrefRangeEnd = 76670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsWearTryClothes()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsWearTryClothes_Public_Static_Boolean_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76672, XrefRangeEnd = 76684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsInTryArea()
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsInTryArea_Public_Static_Boolean_0, (IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76684, XrefRangeEnd = 76709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int GetBasketRp()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBasketRp_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76709, XrefRangeEnd = 76750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConversationEvent([DefaultParameterValue(null)] ConversationEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnConversationEvent_Private_Void_ConversationEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76750, XrefRangeEnd = 76751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MClothesRecord Trans([DefaultParameterValue(null)] int typeInt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&typeInt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Trans_Private_MClothesRecord_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MClothesRecord>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76751, XrefRangeEnd = 76764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FashionShopManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76764, XrefRangeEnd = 76771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnConversationEvent_b__32_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnConversationEvent_b__32_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76771, XrefRangeEnd = 76778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnConversationEvent_b__32_1()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnConversationEvent_b__32_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static FashionShopManager()
	{
		Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "FashionShopManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr);
		NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "Prefix");
		NativeFieldInfoPtr_DropBasketKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "DropBasketKey");
		NativeFieldInfoPtr_BasketKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "BasketKey");
		NativeFieldInfoPtr_IsSavedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "IsSavedKey");
		NativeFieldInfoPtr_CurrentTryClothesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "CurrentTryClothesKey");
		NativeFieldInfoPtr_LastOwnClothesKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "LastOwnClothesKey");
		NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "Instance");
		NativeFieldInfoPtr_tryOnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "tryOnArea");
		NativeFieldInfoPtr_curtainController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "curtainController");
		NativeFieldInfoPtr_clerk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "clerk");
		NativeFieldInfoPtr_clerkInteractTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "clerkInteractTransform");
		NativeFieldInfoPtr__CurrentTryClothes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "<CurrentTryClothes>k__BackingField");
		NativeFieldInfoPtr__LastOwnClothes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "<LastOwnClothes>k__BackingField");
		NativeFieldInfoPtr_basket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "basket");
		NativeFieldInfoPtr_basketPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, "basketPosition");
		NativeMethodInfoPtr_get_CurrentTryClothes_Public_get_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668917);
		NativeMethodInfoPtr_set_CurrentTryClothes_Public_set_Void_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668918);
		NativeMethodInfoPtr_get_LastOwnClothes_Public_get_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668919);
		NativeMethodInfoPtr_set_LastOwnClothes_Public_set_Void_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668920);
		NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668921);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668922);
		NativeMethodInfoPtr_GetAll_Public_List_1_MClothesRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668923);
		NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668924);
		NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668925);
		NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668926);
		NativeMethodInfoPtr_SaveDropBasket_Public_Static_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668927);
		NativeMethodInfoPtr_CheckDisplayBasket_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668928);
		NativeMethodInfoPtr_IsWearTryClothes_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668929);
		NativeMethodInfoPtr_IsInTryArea_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668930);
		NativeMethodInfoPtr_GetBasketRp_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668931);
		NativeMethodInfoPtr_OnConversationEvent_Private_Void_ConversationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668932);
		NativeMethodInfoPtr_Trans_Private_MClothesRecord_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668933);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668934);
		NativeMethodInfoPtr__OnConversationEvent_b__32_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668935);
		NativeMethodInfoPtr__OnConversationEvent_b__32_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FashionShopManager>.NativeClassPtr, 100668936);
	}

	public FashionShopManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
