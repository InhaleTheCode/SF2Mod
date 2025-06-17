using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Common.CommonUI.CommonGauge;

public class GaugeView : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_GaugeFront;

	private static readonly IntPtr NativeFieldInfoPtr_GaugeFrame;

	private static readonly IntPtr NativeFieldInfoPtr_GaugeFrontImage;

	private static readonly IntPtr NativeFieldInfoPtr_initLength;

	private static readonly IntPtr NativeFieldInfoPtr_length;

	private static readonly IntPtr NativeFieldInfoPtr_lengthScale;

	private static readonly IntPtr NativeFieldInfoPtr_reciprocalMax;

	private static readonly IntPtr NativeFieldInfoPtr_max;

	private static readonly IntPtr NativeFieldInfoPtr_isUseAlpha;

	private static readonly IntPtr NativeMethodInfoPtr_get_FrontLength_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_UseAlphaInitialize_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLengthScale_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetMax_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe RectTransform GaugeFront
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFront);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFront), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RectTransform GaugeFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFrame);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RectTransform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFrame), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Image GaugeFrontImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFrontImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_GaugeFrontImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float initLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initLength)) = num;
		}
	}

	public unsafe float length
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_length)) = num;
		}
	}

	public unsafe float lengthScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lengthScale)) = num;
		}
	}

	public unsafe float reciprocalMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reciprocalMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_reciprocalMax)) = num;
		}
	}

	public unsafe float max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_max)) = num;
		}
	}

	public unsafe bool isUseAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseAlpha);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUseAlpha)) = flag;
		}
	}

	public unsafe float FrontLength
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104377, XrefRangeEnd = 104379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FrontLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 104381, RefRangeEnd = 104389, XrefRangeStart = 104379, XrefRangeEnd = 104381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UseAlphaInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseAlphaInitialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetLengthScale([DefaultParameterValue(null)] float scale)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&scale);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLengthScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 104398, RefRangeEnd = 104404, XrefRangeStart = 104389, XrefRangeEnd = 104398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMax([DefaultParameterValue(null)] float max)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&max);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMax_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 104410, RefRangeEnd = 104416, XrefRangeStart = 104404, XrefRangeEnd = 104410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Set([DefaultParameterValue(null)] float val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Set_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104416, XrefRangeEnd = 104419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GaugeView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GaugeView>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static GaugeView()
	{
		Il2CppClassPointerStore<GaugeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CommonUI.CommonGauge", "GaugeView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GaugeView>.NativeClassPtr);
		NativeFieldInfoPtr_GaugeFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "GaugeFront");
		NativeFieldInfoPtr_GaugeFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "GaugeFrame");
		NativeFieldInfoPtr_GaugeFrontImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "GaugeFrontImage");
		NativeFieldInfoPtr_initLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "initLength");
		NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "length");
		NativeFieldInfoPtr_lengthScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "lengthScale");
		NativeFieldInfoPtr_reciprocalMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "reciprocalMax");
		NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "max");
		NativeFieldInfoPtr_isUseAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, "isUseAlpha");
		NativeMethodInfoPtr_get_FrontLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670955);
		NativeMethodInfoPtr_UseAlphaInitialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670956);
		NativeMethodInfoPtr_SetLengthScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670957);
		NativeMethodInfoPtr_SetMax_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670958);
		NativeMethodInfoPtr_Set_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670959);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GaugeView>.NativeClassPtr, 100670960);
	}

	public GaugeView(IntPtr pointer)
		: base(pointer)
	{
	}
}
