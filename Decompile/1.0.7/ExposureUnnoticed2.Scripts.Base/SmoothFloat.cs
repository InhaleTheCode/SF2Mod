using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.Base;

public class SmoothFloat : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Current_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_maxDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr_downMaxDelta;

	private static readonly System.IntPtr NativeFieldInfoPtr__Target_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_isLerp;

	private static readonly System.IntPtr NativeFieldInfoPtr_baseValue;

	private static readonly System.IntPtr NativeFieldInfoPtr_second;

	private static readonly System.IntPtr NativeFieldInfoPtr_downSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr_isUnscaled;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Current_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTo_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBaseValue_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSecond_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateToTarget_Public_Void_0;

	public unsafe float _Current_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Current_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Current_k__BackingField)) = num;
		}
	}

	public unsafe float maxDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_maxDelta)) = num;
		}
	}

	public unsafe float downMaxDelta
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downMaxDelta);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downMaxDelta)) = num;
		}
	}

	public unsafe float _Target_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Target_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Target_k__BackingField)) = num;
		}
	}

	public unsafe bool isLerp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLerp);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isLerp)) = flag;
		}
	}

	public unsafe float baseValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseValue);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_baseValue)) = num;
		}
	}

	public unsafe float second
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_second)) = num;
		}
	}

	public unsafe float downSecond
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downSecond);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_downSecond)) = num;
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

	public unsafe float Current
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Current_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float Target
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Target_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Target_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(123)]
	[CachedScanResults(RefRangeStart = 80918, RefRangeEnd = 81041, XrefRangeStart = 80915, XrefRangeEnd = 80918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SmoothFloat([DefaultParameterValue(null)] float second, float baseValue = 1f, float defaultValue = 0f, bool isLerp = false, bool isUnscaled = false, float downSecond = -1f)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&second);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &baseValue;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultValue;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isLerp;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isUnscaled;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &downSecond;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(127)]
	[CachedScanResults(RefRangeStart = 81047, RefRangeEnd = 81174, XrefRangeStart = 81041, XrefRangeEnd = 81047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateTo([DefaultParameterValue(null)] float target)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&target);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateTo_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetBaseValue([DefaultParameterValue(null)] float baseValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&baseValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBaseValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 81177, RefRangeEnd = 81197, XrefRangeStart = 81174, XrefRangeEnd = 81177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSecond([DefaultParameterValue(null)] float second)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&second);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSecond_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81197, XrefRangeEnd = 81198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateToTarget()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateToTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SmoothFloat()
	{
		Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "SmoothFloat");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr);
		NativeFieldInfoPtr__Current_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "<Current>k__BackingField");
		NativeFieldInfoPtr_maxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "maxDelta");
		NativeFieldInfoPtr_downMaxDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "downMaxDelta");
		NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "<Target>k__BackingField");
		NativeFieldInfoPtr_isLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "isLerp");
		NativeFieldInfoPtr_baseValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "baseValue");
		NativeFieldInfoPtr_second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "second");
		NativeFieldInfoPtr_downSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "downSecond");
		NativeFieldInfoPtr_isUnscaled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, "isUnscaled");
		NativeMethodInfoPtr_get_Current_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669245);
		NativeMethodInfoPtr_set_Current_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669246);
		NativeMethodInfoPtr_get_Target_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669247);
		NativeMethodInfoPtr_set_Target_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669248);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669249);
		NativeMethodInfoPtr_UpdateTo_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669250);
		NativeMethodInfoPtr_SetBaseValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669251);
		NativeMethodInfoPtr_SetSecond_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669252);
		NativeMethodInfoPtr_UpdateToTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmoothFloat>.NativeClassPtr, 100669253);
	}

	public SmoothFloat(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
