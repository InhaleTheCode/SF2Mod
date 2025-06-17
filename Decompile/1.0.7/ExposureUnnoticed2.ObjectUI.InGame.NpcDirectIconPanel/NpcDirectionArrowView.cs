using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.NPC.Script;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace ExposureUnnoticed2.ObjectUI.InGame.NpcDirectIconPanel;

public class NpcDirectionArrowView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_IsDoneCommonProcessThisFrame;

	private static readonly IntPtr NativeFieldInfoPtr_hideSkill;

	private static readonly IntPtr NativeFieldInfoPtr_hideFog;

	private static readonly IntPtr NativeFieldInfoPtr_onTimeStop;

	private static readonly IntPtr NativeFieldInfoPtr_arrowImage;

	private static readonly IntPtr NativeFieldInfoPtr_target;

	private static readonly IntPtr NativeFieldInfoPtr_isActive;

	private static readonly IntPtr NativeFieldInfoPtr_lastCheckStrangeTime;

	private static readonly IntPtr NativeFieldInfoPtr_isLastSkip;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CommonProcessIfNeed_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool IsDoneCommonProcessThisFrame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsDoneCommonProcessThisFrame, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsDoneCommonProcessThisFrame, &flag);
		}
	}

	public unsafe static bool hideSkill
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hideSkill, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hideSkill, &flag);
		}
	}

	public unsafe static bool hideFog
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_hideFog, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_hideFog, &flag);
		}
	}

	public unsafe static bool onTimeStop
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onTimeStop, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onTimeStop, &flag);
		}
	}

	public unsafe Image arrowImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_arrowImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcController target
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool isActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
		}
	}

	public unsafe float lastCheckStrangeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCheckStrangeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastCheckStrangeTime)) = num;
		}
	}

	public unsafe bool isLastSkip
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLastSkip);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLastSkip)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92719, XrefRangeEnd = 92728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcController npc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92728, XrefRangeEnd = 92775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 92797, RefRangeEnd = 92798, XrefRangeStart = 92775, XrefRangeEnd = 92797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CommonProcessIfNeed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CommonProcessIfNeed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcDirectionArrowView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcDirectionArrowView()
	{
		Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InGame.NpcDirectIconPanel", "NpcDirectionArrowView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr);
		NativeFieldInfoPtr_IsDoneCommonProcessThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "IsDoneCommonProcessThisFrame");
		NativeFieldInfoPtr_hideSkill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "hideSkill");
		NativeFieldInfoPtr_hideFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "hideFog");
		NativeFieldInfoPtr_onTimeStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "onTimeStop");
		NativeFieldInfoPtr_arrowImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "arrowImage");
		NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "target");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "isActive");
		NativeFieldInfoPtr_lastCheckStrangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "lastCheckStrangeTime");
		NativeFieldInfoPtr_isLastSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, "isLastSkip");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, 100670095);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, 100670096);
		NativeMethodInfoPtr_CommonProcessIfNeed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, 100670097);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcDirectionArrowView>.NativeClassPtr, 100670098);
	}

	public NpcDirectionArrowView(IntPtr pointer)
		: base(pointer)
	{
	}
}
