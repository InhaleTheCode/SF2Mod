using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Master.Stage;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcSpawnInterval : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_rCurrentStage;

	private static readonly System.IntPtr NativeFieldInfoPtr_nextSpawnRemainTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_isOldMaxNpc;

	private static readonly System.IntPtr NativeFieldInfoPtr_isJustNpcReduceFromMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_firstSpawn;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLoadStage_Public_Void_MStageRecord_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsSpawn_Public_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe MStageRecord rCurrentStage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rCurrentStage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MStageRecord>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rCurrentStage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float nextSpawnRemainTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextSpawnRemainTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nextSpawnRemainTime)) = num;
		}
	}

	public unsafe bool isOldMaxNpc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOldMaxNpc);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isOldMaxNpc)) = flag;
		}
	}

	public unsafe bool isJustNpcReduceFromMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJustNpcReduceFromMax);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isJustNpcReduceFromMax)) = flag;
		}
	}

	public unsafe bool firstSpawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpawn);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_firstSpawn)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe void OnLoadStage([DefaultParameterValue(null)] MStageRecord rCurrentStage)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rCurrentStage);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLoadStage_Public_Void_MStageRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62868, RefRangeEnd = 62869, XrefRangeStart = 62860, XrefRangeEnd = 62868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSpawn([DefaultParameterValue(null)] int currentNpcNum)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&currentNpcNum);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsSpawn_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe NpcSpawnInterval()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcSpawnInterval()
	{
		Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcSpawnInterval");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr);
		NativeFieldInfoPtr_rCurrentStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, "rCurrentStage");
		NativeFieldInfoPtr_nextSpawnRemainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, "nextSpawnRemainTime");
		NativeFieldInfoPtr_isOldMaxNpc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, "isOldMaxNpc");
		NativeFieldInfoPtr_isJustNpcReduceFromMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, "isJustNpcReduceFromMax");
		NativeFieldInfoPtr_firstSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, "firstSpawn");
		NativeMethodInfoPtr_OnLoadStage_Public_Void_MStageRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, 100667560);
		NativeMethodInfoPtr_IsSpawn_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, 100667561);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcSpawnInterval>.NativeClassPtr, 100667562);
	}

	public NpcSpawnInterval(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
