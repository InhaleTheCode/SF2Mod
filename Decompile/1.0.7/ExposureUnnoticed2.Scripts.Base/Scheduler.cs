using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Scripts.Base;

public class Scheduler : MonoBehaviour
{
	public class DelayFrameModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr_delayFrame;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_CountdownAndInvokeIfNeed_Public_Boolean_0;

		public unsafe Il2CppSystem.Action action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int delayFrame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFrame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayFrame)) = num;
			}
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80537, RefRangeEnd = 80538, XrefRangeStart = 80537, XrefRangeEnd = 80537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayFrameModel([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] int delayFrame)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayFrame;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80538, RefRangeEnd = 80539, XrefRangeStart = 80538, XrefRangeEnd = 80538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CountdownAndInvokeIfNeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CountdownAndInvokeIfNeed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static DelayFrameModel()
		{
			Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "DelayFrameModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr, "action");
			NativeFieldInfoPtr_delayFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr, "delayFrame");
			NativeMethodInfoPtr__ctor_Public_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr, 100669239);
			NativeMethodInfoPtr_CountdownAndInvokeIfNeed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayFrameModel>.NativeClassPtr, 100669240);
		}

		public DelayFrameModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DelayTimeModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr_delayTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_remainTime;

		private static readonly System.IntPtr NativeFieldInfoPtr_isUnscaled;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Single_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0;

		public unsafe Il2CppSystem.Action action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float delayTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_delayTime)) = num;
			}
		}

		public unsafe float startTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)) = num;
			}
		}

		public unsafe float remainTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_remainTime)) = num;
			}
		}

		public unsafe bool isUnscaled
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnscaled);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnscaled)) = flag;
			}
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80541, RefRangeEnd = 80543, XrefRangeStart = 80539, XrefRangeEnd = 80541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayTimeModel([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] float delayTime, bool isUnscaled = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
			*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnscaled;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80550, RefRangeEnd = 80551, XrefRangeStart = 80543, XrefRangeEnd = 80550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeIfNeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static DelayTimeModel()
		{
			Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "DelayTimeModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, "action");
			NativeFieldInfoPtr_delayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, "delayTime");
			NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, "startTime");
			NativeFieldInfoPtr_remainTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, "remainTime");
			NativeFieldInfoPtr_isUnscaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, "isUnscaled");
			NativeMethodInfoPtr__ctor_Public_Void_Action_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, 100669241);
			NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayTimeModel>.NativeClassPtr, 100669242);
		}

		public DelayTimeModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class DelayConditionModel : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_action;

		private static readonly System.IntPtr NativeFieldInfoPtr_condition;

		private static readonly System.IntPtr NativeFieldInfoPtr_maxSecond;

		private static readonly System.IntPtr NativeFieldInfoPtr_startTime;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_Func_1_Boolean_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0;

		public unsafe Il2CppSystem.Action action
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Il2CppSystem.Func<bool> condition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_condition), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float maxSecond
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSecond);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxSecond)) = num;
			}
		}

		public unsafe float startTime
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_startTime)) = num;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80551, XrefRangeEnd = 80553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DelayConditionModel([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] Il2CppSystem.Func<bool> condition, [DefaultParameterValue(null)] float maxSecond)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(condition);
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSecond;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Action_Func_1_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80555, RefRangeEnd = 80556, XrefRangeStart = 80553, XrefRangeEnd = 80555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InvokeIfNeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static DelayConditionModel()
		{
			Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "DelayConditionModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr);
			NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, "action");
			NativeFieldInfoPtr_condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, "condition");
			NativeFieldInfoPtr_maxSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, "maxSecond");
			NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, "startTime");
			NativeMethodInfoPtr__ctor_Public_Void_Action_Func_1_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, 100669243);
			NativeMethodInfoPtr_InvokeIfNeed_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayConditionModel>.NativeClassPtr, 100669244);
		}

		public DelayConditionModel(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_modelList;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeList;

	private static readonly System.IntPtr NativeFieldInfoPtr_modelListClone;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeModelList;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeRemoveList;

	private static readonly System.IntPtr NativeFieldInfoPtr_timeModelListClone;

	private static readonly System.IntPtr NativeFieldInfoPtr_conditionModelList;

	private static readonly System.IntPtr NativeFieldInfoPtr_conditionRemoveList;

	private static readonly System.IntPtr NativeFieldInfoPtr_conditionModelListClone;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Private_Static_get_Scheduler_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelayFlame_Public_Static_Void_Action_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelayUnscaledTime_Public_Static_Void_Action_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelayScaledTime_Public_Static_Void_Action_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DelayCondition_Public_Static_Void_Action_Func_1_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static Scheduler instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scheduler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayFrameModel> modelList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayFrameModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayFrameModel> removeList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayFrameModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayFrameModel> modelListClone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelListClone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayFrameModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_modelListClone), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayTimeModel> timeModelList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeModelList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayTimeModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeModelList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayTimeModel> timeRemoveList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRemoveList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayTimeModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeRemoveList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayTimeModel> timeModelListClone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeModelListClone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayTimeModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_timeModelListClone), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayConditionModel> conditionModelList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionModelList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayConditionModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionModelList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayConditionModel> conditionRemoveList
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionRemoveList);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayConditionModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionRemoveList), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<DelayConditionModel> conditionModelListClone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionModelListClone);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DelayConditionModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_conditionModelListClone), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static Scheduler Instance
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 80583, RefRangeEnd = 80587, XrefRangeStart = 80556, XrefRangeEnd = 80583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Private_Static_get_Scheduler_0, (System.IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Scheduler>(intPtr) : null;
		}
	}

	[CallerCount(147)]
	[CachedScanResults(RefRangeStart = 80594, RefRangeEnd = 80741, XrefRangeStart = 80587, XrefRangeEnd = 80594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DelayFlame([DefaultParameterValue(null)] Il2CppSystem.Action action, int delayFrame = 1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayFrame;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelayFlame_Public_Static_Void_Action_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 80749, RefRangeEnd = 80763, XrefRangeStart = 80741, XrefRangeEnd = 80749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DelayUnscaledTime([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] float delayTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelayUnscaledTime_Public_Static_Void_Action_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 80771, RefRangeEnd = 80779, XrefRangeStart = 80763, XrefRangeEnd = 80771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DelayScaledTime([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] float delayTime)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &delayTime;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelayScaledTime_Public_Static_Void_Action_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 80790, RefRangeEnd = 80794, XrefRangeStart = 80779, XrefRangeEnd = 80790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DelayCondition([DefaultParameterValue(null)] Il2CppSystem.Action action, [DefaultParameterValue(null)] Il2CppSystem.Func<bool> condition, float maxSecond = 10f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(condition);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSecond;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DelayCondition_Public_Static_Void_Action_Func_1_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80794, XrefRangeEnd = 80870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80870, XrefRangeEnd = 80915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Scheduler()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Scheduler>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Scheduler()
	{
		Il2CppClassPointerStore<Scheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "Scheduler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scheduler>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_modelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "modelList");
		NativeFieldInfoPtr_removeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "removeList");
		NativeFieldInfoPtr_modelListClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "modelListClone");
		NativeFieldInfoPtr_timeModelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "timeModelList");
		NativeFieldInfoPtr_timeRemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "timeRemoveList");
		NativeFieldInfoPtr_timeModelListClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "timeModelListClone");
		NativeFieldInfoPtr_conditionModelList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "conditionModelList");
		NativeFieldInfoPtr_conditionRemoveList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "conditionRemoveList");
		NativeFieldInfoPtr_conditionModelListClone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, "conditionModelListClone");
		NativeMethodInfoPtr_get_Instance_Private_Static_get_Scheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669232);
		NativeMethodInfoPtr_DelayFlame_Public_Static_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669233);
		NativeMethodInfoPtr_DelayUnscaledTime_Public_Static_Void_Action_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669234);
		NativeMethodInfoPtr_DelayScaledTime_Public_Static_Void_Action_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669235);
		NativeMethodInfoPtr_DelayCondition_Public_Static_Void_Action_Func_1_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669236);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669237);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scheduler>.NativeClassPtr, 100669238);
	}

	public Scheduler(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
