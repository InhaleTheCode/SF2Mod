using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace ExposureUnnoticed2.ObjectUI.InGame.RingMenu;

public class RingMenuView : MonoBehaviour
{
	public enum State
	{
		Show,
		Hide
	}

	public enum Direct
	{
		Up,
		Right,
		Down,
		Left,
		None
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_ringDirectRect;

	private static readonly System.IntPtr NativeFieldInfoPtr_content;

	private static readonly System.IntPtr NativeFieldInfoPtr_ringCanvasGroup;

	private static readonly System.IntPtr NativeFieldInfoPtr_aaa;

	private static readonly System.IntPtr NativeFieldInfoPtr_bbb;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentState;

	private static readonly System.IntPtr NativeFieldInfoPtr_animator;

	private static readonly System.IntPtr NativeFieldInfoPtr_itemView;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSelectView;

	private static readonly System.IntPtr NativeFieldInfoPtr_ringShortCutIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_mouseWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_isByLongPress;

	private static readonly System.IntPtr NativeFieldInfoPtr_targetKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsShow;

	private static readonly System.IntPtr NativeFieldInfoPtr_onInvokeCommand;

	private static readonly System.IntPtr NativeFieldInfoPtr_ringIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_parentView;

	private static readonly System.IntPtr NativeFieldInfoPtr_positionX;

	private static readonly System.IntPtr NativeFieldInfoPtr_ringAlpha;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_RingMenuParentView_Il2CppReferenceArray_1_RingMenuItemModel_Action_1_RingMenuItemModel_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ChangeState_Private_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnLongPressActionSlot_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetShow_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ShowUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HideUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalcAngle_Public_Static_Single_Vector2_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Vector2ToAngle_Public_Static_Single_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleToVector2_Public_Static_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RectTransform ringDirectRect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringDirectRect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringDirectRect), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CanvasGroup ringCanvasGroup
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringCanvasGroup);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int aaa
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaa);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_aaa)) = num;
		}
	}

	public unsafe float bbb
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbb);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bbb)) = num;
		}
	}

	public unsafe State currentState
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState);
			return *(State*)num;
		}
		set
		{
			*(State*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentState)) = state;
		}
	}

	public unsafe Animator animator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Animator>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<RingItemView> itemView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RingItemView>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_itemView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RingItemView currentSelectView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RingItemView>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSelectView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ringShortCutIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringShortCutIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringShortCutIndex)) = num;
		}
	}

	public unsafe Vector2 mouseWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseWeight);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_mouseWeight)) = vector;
		}
	}

	public unsafe float currentAngle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAngle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentAngle)) = num;
		}
	}

	public unsafe bool isByLongPress
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isByLongPress);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isByLongPress)) = flag;
		}
	}

	public unsafe InputManager.InputType targetKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetKey);
			return *(InputManager.InputType*)num;
		}
		set
		{
			*(InputManager.InputType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_targetKey)) = inputType;
		}
	}

	public unsafe static int IsShow
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsShow, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsShow, &num);
		}
	}

	public unsafe Il2CppSystem.Action<RingMenuItemModel> onInvokeCommand
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onInvokeCommand);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<RingMenuItemModel>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onInvokeCommand), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ringIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringIndex)) = num;
		}
	}

	public unsafe RingMenuParentView parentView
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentView);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RingMenuParentView>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_parentView), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat positionX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_positionX), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe SmoothFloat ringAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringAlpha);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SmoothFloat>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ringAlpha), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsOpen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92506, RefRangeEnd = 92507, XrefRangeStart = 92464, XrefRangeEnd = 92506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] RingMenuParentView parentView, [DefaultParameterValue(null)] Il2CppReferenceArray<RingMenuItemModel> itemModels, [DefaultParameterValue(null)] Il2CppSystem.Action<RingMenuItemModel> onInvokeCommand, int ringIndex = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentView);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(itemModels);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(onInvokeCommand);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &ringIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_RingMenuParentView_Il2CppReferenceArray_1_RingMenuItemModel_Action_1_RingMenuItemModel_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92507, XrefRangeEnd = 92530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 92537, RefRangeEnd = 92540, XrefRangeStart = 92530, XrefRangeEnd = 92537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeState([DefaultParameterValue(null)] State nextState)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nextState);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeState_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92540, XrefRangeEnd = 92541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLongPressActionSlot([DefaultParameterValue(null)] int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&index);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnLongPressActionSlot_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92541, XrefRangeEnd = 92543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetShow([DefaultParameterValue(null)] bool isShow)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isShow);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetShow_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92582, RefRangeEnd = 92583, XrefRangeStart = 92543, XrefRangeEnd = 92582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ShowUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92606, RefRangeEnd = 92607, XrefRangeStart = 92583, XrefRangeEnd = 92606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AngleUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void HideUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HideUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92607, XrefRangeEnd = 92618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CalcAngle([DefaultParameterValue(null)] Vector2 a, [DefaultParameterValue(null)] Vector2 b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcAngle_Public_Static_Single_Vector2_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92618, XrefRangeEnd = 92619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Vector2ToAngle([DefaultParameterValue(null)] Vector2 vector)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&vector);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Vector2ToAngle_Public_Static_Single_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92619, XrefRangeEnd = 92621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 AngleToVector2([DefaultParameterValue(null)] float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleToVector2_Public_Static_Vector2_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92621, XrefRangeEnd = 92631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RingMenuView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RingMenuView()
	{
		Il2CppClassPointerStore<RingMenuView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InGame.RingMenu", "RingMenuView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr);
		NativeFieldInfoPtr_ringDirectRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "ringDirectRect");
		NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "content");
		NativeFieldInfoPtr_ringCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "ringCanvasGroup");
		NativeFieldInfoPtr_aaa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "aaa");
		NativeFieldInfoPtr_bbb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "bbb");
		NativeFieldInfoPtr_currentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "currentState");
		NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "animator");
		NativeFieldInfoPtr_itemView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "itemView");
		NativeFieldInfoPtr_currentSelectView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "currentSelectView");
		NativeFieldInfoPtr_ringShortCutIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "ringShortCutIndex");
		NativeFieldInfoPtr_mouseWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "mouseWeight");
		NativeFieldInfoPtr_currentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "currentAngle");
		NativeFieldInfoPtr_isByLongPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "isByLongPress");
		NativeFieldInfoPtr_targetKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "targetKey");
		NativeFieldInfoPtr_IsShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "IsShow");
		NativeFieldInfoPtr_onInvokeCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "onInvokeCommand");
		NativeFieldInfoPtr_ringIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "ringIndex");
		NativeFieldInfoPtr_parentView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "parentView");
		NativeFieldInfoPtr_positionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "positionX");
		NativeFieldInfoPtr_ringAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, "ringAlpha");
		NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670074);
		NativeMethodInfoPtr_Initialize_Public_Void_RingMenuParentView_Il2CppReferenceArray_1_RingMenuItemModel_Action_1_RingMenuItemModel_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670075);
		NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670076);
		NativeMethodInfoPtr_ChangeState_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670077);
		NativeMethodInfoPtr_OnLongPressActionSlot_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670078);
		NativeMethodInfoPtr_SetShow_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670079);
		NativeMethodInfoPtr_ShowUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670080);
		NativeMethodInfoPtr_AngleUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670081);
		NativeMethodInfoPtr_HideUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670082);
		NativeMethodInfoPtr_CalcAngle_Public_Static_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670083);
		NativeMethodInfoPtr_Vector2ToAngle_Public_Static_Single_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670084);
		NativeMethodInfoPtr_AngleToVector2_Public_Static_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670085);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RingMenuView>.NativeClassPtr, 100670086);
	}

	public RingMenuView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
