using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.Player.Scripts;

public class PlayerHandcuffsController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_pca;

	private static readonly System.IntPtr NativeFieldInfoPtr__UnlockProgress_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__UnlockProgress2_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_interactButtonLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentProbably;

	private static readonly System.IntPtr NativeFieldInfoPtr_Progress2Goal;

	private static readonly System.IntPtr NativeFieldInfoPtr_initHandcuff;

	private static readonly System.IntPtr NativeFieldInfoPtr_initHandcuffMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_forceUnlockPhase;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockProgress_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockProgress_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UnlockProgress2_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_UnlockProgress2_Private_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsConditionMission_Public_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEmergencyEscape_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnAttachProcess_Private_Void_InputData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransToUnlockAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TransFromUnlockAction_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnNoAttachProcess_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

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

	public unsafe float _UnlockProgress_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnlockProgress_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnlockProgress_k__BackingField)) = num;
		}
	}

	public unsafe float _UnlockProgress2_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnlockProgress2_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UnlockProgress2_k__BackingField)) = num;
		}
	}

	public unsafe bool interactButtonLock
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactButtonLock);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interactButtonLock)) = flag;
		}
	}

	public unsafe float currentProbably
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProbably);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentProbably)) = num;
		}
	}

	public unsafe float Progress2Goal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progress2Goal);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Progress2Goal)) = num;
		}
	}

	public unsafe bool initHandcuff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initHandcuff);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initHandcuff)) = flag;
		}
	}

	public unsafe bool initHandcuffMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initHandcuffMap);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initHandcuffMap)) = flag;
		}
	}

	public unsafe int forceUnlockPhase
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceUnlockPhase);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_forceUnlockPhase)) = num;
		}
	}

	public unsafe float UnlockProgress
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnlockProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UnlockProgress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float UnlockProgress2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UnlockProgress2_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UnlockProgress2_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 54097, RefRangeEnd = 54101, XrefRangeStart = 54094, XrefRangeEnd = 54097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsConditionMission()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsConditionMission_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54101, XrefRangeEnd = 54106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54106, XrefRangeEnd = 54114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate([DefaultParameterValue(null)] InputData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54114, XrefRangeEnd = 54115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEmergencyEscape()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEmergencyEscape_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54135, RefRangeEnd = 54137, XrefRangeStart = 54115, XrefRangeEnd = 54135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAttachProcess([DefaultParameterValue(null)] InputData inputData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAttachProcess_Private_Void_InputData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54137, XrefRangeEnd = 54140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransToUnlockAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransToUnlockAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 54140, XrefRangeEnd = 54143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void TransFromUnlockAction()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TransFromUnlockAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 54149, RefRangeEnd = 54151, XrefRangeStart = 54143, XrefRangeEnd = 54149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNoAttachProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnNoAttachProcess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe PlayerHandcuffsController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerHandcuffsController()
	{
		Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts", "PlayerHandcuffsController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr);
		NativeFieldInfoPtr_pca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "pca");
		NativeFieldInfoPtr__UnlockProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "<UnlockProgress>k__BackingField");
		NativeFieldInfoPtr__UnlockProgress2_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "<UnlockProgress2>k__BackingField");
		NativeFieldInfoPtr_interactButtonLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "interactButtonLock");
		NativeFieldInfoPtr_currentProbably = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "currentProbably");
		NativeFieldInfoPtr_Progress2Goal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "Progress2Goal");
		NativeFieldInfoPtr_initHandcuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "initHandcuff");
		NativeFieldInfoPtr_initHandcuffMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "initHandcuffMap");
		NativeFieldInfoPtr_forceUnlockPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, "forceUnlockPhase");
		NativeMethodInfoPtr_get_UnlockProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666817);
		NativeMethodInfoPtr_set_UnlockProgress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666818);
		NativeMethodInfoPtr_get_UnlockProgress2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666819);
		NativeMethodInfoPtr_set_UnlockProgress2_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666820);
		NativeMethodInfoPtr_IsConditionMission_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666821);
		NativeMethodInfoPtr_Initialize_Public_Void_PlayerClassAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666822);
		NativeMethodInfoPtr_OnUpdate_Public_Void_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666823);
		NativeMethodInfoPtr_OnEmergencyEscape_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666824);
		NativeMethodInfoPtr_OnAttachProcess_Private_Void_InputData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666825);
		NativeMethodInfoPtr_TransToUnlockAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666826);
		NativeMethodInfoPtr_TransFromUnlockAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666827);
		NativeMethodInfoPtr_OnNoAttachProcess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666828);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerHandcuffsController>.NativeClassPtr, 100666829);
	}

	public PlayerHandcuffsController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
