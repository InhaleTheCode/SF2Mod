using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Common.Scripts.Util;

public class IntervalTime : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isUnscale;

	private static readonly System.IntPtr NativeFieldInfoPtr_interval;

	private static readonly System.IntPtr NativeFieldInfoPtr_lastTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomMin;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomMax;

	private static readonly System.IntPtr NativeFieldInfoPtr_isRandom;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Private_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ProceedIfInCondition_Public_Boolean_0;

	public unsafe bool isUnscale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnscale);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isUnscale)) = flag;
		}
	}

	public unsafe float interval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_interval)) = num;
		}
	}

	public unsafe float lastTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_lastTime)) = num;
		}
	}

	public unsafe float randomMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomMin)) = num;
		}
	}

	public unsafe float randomMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_randomMax)) = num;
		}
	}

	public unsafe bool isRandom
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandom);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isRandom)) = flag;
		}
	}

	public unsafe float time
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 103730, RefRangeEnd = 103733, XrefRangeStart = 103722, XrefRangeEnd = 103730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	public unsafe IntervalTime([DefaultParameterValue(null)] float interval, bool isUnscale = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&interval);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnscale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe IntervalTime([DefaultParameterValue(null)] float randomMin, [DefaultParameterValue(null)] float randomMax, bool isUnscale = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&randomMin);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &randomMax;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnscale;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103733, XrefRangeEnd = 103734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ProceedIfInCondition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ProceedIfInCondition_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IntervalTime()
	{
		Il2CppClassPointerStore<IntervalTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.Scripts.Util", "IntervalTime");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr);
		NativeFieldInfoPtr_isUnscale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "isUnscale");
		NativeFieldInfoPtr_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "interval");
		NativeFieldInfoPtr_lastTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "lastTime");
		NativeFieldInfoPtr_randomMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "randomMin");
		NativeFieldInfoPtr_randomMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "randomMax");
		NativeFieldInfoPtr_isRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, "isRandom");
		NativeMethodInfoPtr_get_time_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, 100670897);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, 100670898);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, 100670899);
		NativeMethodInfoPtr_ProceedIfInCondition_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntervalTime>.NativeClassPtr, 100670900);
	}

	public IntervalTime(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
