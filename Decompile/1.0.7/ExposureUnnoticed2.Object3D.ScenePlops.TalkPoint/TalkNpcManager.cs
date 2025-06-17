using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ScenePlops.TalkPoint;

public class TalkNpcManager : MonoBehaviour
{
	public class TalkModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_Npc1;

		private static readonly System.IntPtr NativeFieldInfoPtr_Npc2;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastIntervalTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_intervalTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_reverse;

		private static readonly System.IntPtr NativeMethodInfoPtr_SwitchIfInCondition_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe NpcController Npc1
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc1);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc1), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe NpcController Npc2
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc2);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Npc2), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float lastIntervalTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastIntervalTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastIntervalTime)) = num;
			}
		}

		public unsafe float intervalTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_intervalTime)) = num;
			}
		}

		public unsafe bool reverse
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reverse)) = flag;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44227, XrefRangeEnd = 44235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchIfInCondition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchIfInCondition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe TalkModel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TalkModel>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static TalkModel()
		{
			Il2CppClassPointerStore<TalkModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, "TalkModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TalkModel>.NativeClassPtr);
			NativeFieldInfoPtr_Npc1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, "Npc1");
			NativeFieldInfoPtr_Npc2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, "Npc2");
			NativeFieldInfoPtr_lastIntervalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, "lastIntervalTime");
			NativeFieldInfoPtr_intervalTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, "intervalTime");
			NativeFieldInfoPtr_reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, "reverse");
			NativeMethodInfoPtr_SwitchIfInCondition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, 100665972);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkModel>.NativeClassPtr, 100665973);
		}

		public TalkModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_modelList;

	private static readonly System.IntPtr NativeFieldInfoPtr_points;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Spawn_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe List<TalkModel> modelList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<TalkModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<TalkPoint> points
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_points);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TalkPoint>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44235, XrefRangeEnd = 44252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44252, XrefRangeEnd = 44264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 44332, RefRangeEnd = 44335, XrefRangeStart = 44264, XrefRangeEnd = 44332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Spawn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Spawn_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44351, RefRangeEnd = 44352, XrefRangeStart = 44335, XrefRangeEnd = 44351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44352, XrefRangeEnd = 44353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChangeTime([DefaultParameterValue(null)] ChangeTimeEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44353, XrefRangeEnd = 44362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TalkNpcManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TalkNpcManager()
	{
		Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ScenePlops.TalkPoint", "TalkNpcManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr);
		NativeFieldInfoPtr_modelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, "modelList");
		NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, "points");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665967);
		NativeMethodInfoPtr_Spawn_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665968);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665969);
		NativeMethodInfoPtr_OnChangeTime_Private_Void_ChangeTimeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665970);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TalkNpcManager>.NativeClassPtr, 100665971);
	}

	public TalkNpcManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
