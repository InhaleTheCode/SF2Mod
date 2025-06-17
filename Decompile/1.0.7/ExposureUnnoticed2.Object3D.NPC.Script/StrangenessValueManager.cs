using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class StrangenessValueManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MaxReduceCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReducePerSecond;

	private static readonly System.IntPtr NativeFieldInfoPtr__CurrentReduceParSecond_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr_val;

	private static readonly System.IntPtr NativeFieldInfoPtr_strangenessReduceCount;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentReduceParSecond_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentReduceParSecond_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int MaxReduceCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MaxReduceCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MaxReduceCount, &num);
		}
	}

	public unsafe static float ReducePerSecond
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ReducePerSecond, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ReducePerSecond, &num);
		}
	}

	public unsafe float _CurrentReduceParSecond_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentReduceParSecond_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CurrentReduceParSecond_k__BackingField)) = num;
		}
	}

	public unsafe float val
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_val);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_val)) = num;
		}
	}

	public unsafe int strangenessReduceCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangenessReduceCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_strangenessReduceCount)) = num;
		}
	}

	public unsafe float Value
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe float CurrentReduceParSecond
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CurrentReduceParSecond_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
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
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CurrentReduceParSecond_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 63817, RefRangeEnd = 63819, XrefRangeStart = 63814, XrefRangeEnd = 63817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate([DefaultParameterValue(null)] bool isSkipReduceCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isSkipReduceCount);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe StrangenessValueManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static StrangenessValueManager()
	{
		Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "StrangenessValueManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr);
		NativeFieldInfoPtr_MaxReduceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, "MaxReduceCount");
		NativeFieldInfoPtr_ReducePerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, "ReducePerSecond");
		NativeFieldInfoPtr__CurrentReduceParSecond_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, "<CurrentReduceParSecond>k__BackingField");
		NativeFieldInfoPtr_val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, "val");
		NativeFieldInfoPtr_strangenessReduceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, "strangenessReduceCount");
		NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667633);
		NativeMethodInfoPtr_set_Value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667634);
		NativeMethodInfoPtr_get_CurrentReduceParSecond_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667635);
		NativeMethodInfoPtr_set_CurrentReduceParSecond_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667636);
		NativeMethodInfoPtr_OnUpdate_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667637);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrangenessValueManager>.NativeClassPtr, 100667638);
	}

	public StrangenessValueManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
