using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.Mission;

public class MissionHandcuffsMoveExpose : MissionBase
{
	private static readonly IntPtr NativeFieldInfoPtr_startPathPosition;

	private static readonly IntPtr NativeFieldInfoPtr_oldResult;

	private static readonly IntPtr NativeFieldInfoPtr_PathSearchCount;

	private static readonly IntPtr NativeFieldInfoPtr_lastMaxPathLength;

	private static readonly IntPtr NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Vector3 startPathPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPathPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startPathPosition)) = vector;
		}
	}

	public unsafe bool oldResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldResult);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_oldResult)) = flag;
		}
	}

	public unsafe int PathSearchCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathSearchCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PathSearchCount)) = num;
		}
	}

	public unsafe float lastMaxPathLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMaxPathLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastMaxPathLength)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71242, XrefRangeEnd = 71254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool IsInCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71254, XrefRangeEnd = 71256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override float GetAddSatisfy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe MissionHandcuffsMoveExpose()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MissionHandcuffsMoveExpose()
	{
		Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Mission", "MissionHandcuffsMoveExpose");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr);
		NativeFieldInfoPtr_startPathPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, "startPathPosition");
		NativeFieldInfoPtr_oldResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, "oldResult");
		NativeFieldInfoPtr_PathSearchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, "PathSearchCount");
		NativeFieldInfoPtr_lastMaxPathLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, "lastMaxPathLength");
		NativeMethodInfoPtr_IsInCondition_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, 100668485);
		NativeMethodInfoPtr_GetAddSatisfy_Protected_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, 100668486);
		NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, 100668487);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionHandcuffsMoveExpose>.NativeClassPtr, 100668488);
	}

	public MissionHandcuffsMoveExpose(IntPtr pointer)
		: base(pointer)
	{
	}
}
