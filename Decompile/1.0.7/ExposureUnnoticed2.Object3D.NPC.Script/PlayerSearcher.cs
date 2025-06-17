using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class PlayerSearcher : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_offset;

	private static readonly IntPtr NativeFieldInfoPtr_sitOffset;

	private static readonly IntPtr NativeFieldInfoPtr_sitOffsetInverse;

	private static readonly IntPtr NativeFieldInfoPtr_pinponOffset;

	private static readonly IntPtr NativeFieldInfoPtr_cube;

	private static readonly IntPtr NativeFieldInfoPtr_sphere;

	private static readonly IntPtr NativeFieldInfoPtr_eye;

	private static readonly IntPtr NativeFieldInfoPtr_IsPlayerFound;

	private static readonly IntPtr NativeFieldInfoPtr_player;

	private static readonly IntPtr NativeFieldInfoPtr_layerMask;

	private static readonly IntPtr NativeFieldInfoPtr_traceTarget;

	private static readonly IntPtr NativeFieldInfoPtr_nca;

	private static readonly IntPtr NativeFieldInfoPtr_skipEndTime;

	private static readonly IntPtr NativeFieldInfoPtr_isHideColliderState;

	private static readonly IntPtr NativeFieldInfoPtr_isFoundForeignObject;

	private static readonly IntPtr NativeMethodInfoPtr_RegisterTraceTransform_Public_Void_Transform_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForPlayerUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_ForForeignUpdate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnLateUpdate_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 offset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_offset)) = vector;
		}
	}

	public unsafe Vector3 sitOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitOffset)) = vector;
		}
	}

	public unsafe Vector3 sitOffsetInverse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitOffsetInverse);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sitOffsetInverse)) = vector;
		}
	}

	public unsafe Vector3 pinponOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinponOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pinponOffset)) = vector;
		}
	}

	public unsafe Il2CppReferenceArray<PlayerSearcherChild> cube
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cube);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerSearcherChild>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cube), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe PlayerSearcherChild sphere
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sphere);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerSearcherChild>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_sphere), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform eye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eye);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eye), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsPlayerFound
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayerFound);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsPlayerFound)) = flag;
		}
	}

	public unsafe PlayerController player
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<PlayerController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

	public unsafe Transform traceTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traceTarget);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_traceTarget), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float skipEndTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipEndTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skipEndTime)) = num;
		}
	}

	public unsafe bool isHideColliderState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHideColliderState);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isHideColliderState)) = flag;
		}
	}

	public unsafe bool isFoundForeignObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFoundForeignObject);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isFoundForeignObject)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe void RegisterTraceTransform([DefaultParameterValue(null)] Transform target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegisterTraceTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63072, RefRangeEnd = 63073, XrefRangeStart = 63057, XrefRangeEnd = 63072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63126, RefRangeEnd = 63127, XrefRangeStart = 63073, XrefRangeEnd = 63126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63185, RefRangeEnd = 63186, XrefRangeStart = 63127, XrefRangeEnd = 63185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForPlayerUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForPlayerUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 63269, RefRangeEnd = 63270, XrefRangeStart = 63186, XrefRangeEnd = 63269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ForForeignUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ForForeignUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63285, RefRangeEnd = 63287, XrefRangeStart = 63270, XrefRangeEnd = 63285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 63287, XrefRangeEnd = 63290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayerSearcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PlayerSearcher()
	{
		Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "PlayerSearcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr);
		NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "offset");
		NativeFieldInfoPtr_sitOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "sitOffset");
		NativeFieldInfoPtr_sitOffsetInverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "sitOffsetInverse");
		NativeFieldInfoPtr_pinponOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "pinponOffset");
		NativeFieldInfoPtr_cube = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "cube");
		NativeFieldInfoPtr_sphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "sphere");
		NativeFieldInfoPtr_eye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "eye");
		NativeFieldInfoPtr_IsPlayerFound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "IsPlayerFound");
		NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "player");
		NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "layerMask");
		NativeFieldInfoPtr_traceTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "traceTarget");
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_skipEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "skipEndTime");
		NativeFieldInfoPtr_isHideColliderState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "isHideColliderState");
		NativeFieldInfoPtr_isFoundForeignObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, "isFoundForeignObject");
		NativeMethodInfoPtr_RegisterTraceTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667585);
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667586);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667587);
		NativeMethodInfoPtr_ForPlayerUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667588);
		NativeMethodInfoPtr_ForForeignUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667589);
		NativeMethodInfoPtr_OnLateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667590);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSearcher>.NativeClassPtr, 100667591);
	}

	public PlayerSearcher(IntPtr pointer)
		: base(pointer)
	{
	}
}
