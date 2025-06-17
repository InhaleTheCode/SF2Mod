using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.ForeignObject;

public class ForeignObjectController : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr__MaxDiscomfort_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__ForeignObjectFaceType_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_MaxDiscomfort_Public_get_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_MaxDiscomfort_Private_set_Void_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ForeignObjectFaceType_Public_get_ForeignObjectFaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_ForeignObjectFaceType_Private_set_Void_ForeignObjectFaceType_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float _MaxDiscomfort_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxDiscomfort_k__BackingField);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MaxDiscomfort_k__BackingField)) = num;
		}
	}

	public unsafe ForeignObjectFaceType _ForeignObjectFaceType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ForeignObjectFaceType_k__BackingField);
			return *(ForeignObjectFaceType*)num;
		}
		set
		{
			*(ForeignObjectFaceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ForeignObjectFaceType_k__BackingField)) = foreignObjectFaceType;
		}
	}

	public unsafe float MaxDiscomfort
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxDiscomfort_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(float*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MaxDiscomfort_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe ForeignObjectFaceType ForeignObjectFaceType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForeignObjectFaceType_Public_get_ForeignObjectFaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(ForeignObjectFaceType*)IL2CPP.il2cpp_object_unbox(obj);
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ForeignObjectFaceType_Private_set_Void_ForeignObjectFaceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ForeignObjectController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ForeignObjectController()
	{
		Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.ForeignObject", "ForeignObjectController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr);
		NativeFieldInfoPtr__MaxDiscomfort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, "<MaxDiscomfort>k__BackingField");
		NativeFieldInfoPtr__ForeignObjectFaceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, "<ForeignObjectFaceType>k__BackingField");
		NativeMethodInfoPtr_get_MaxDiscomfort_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, 100667813);
		NativeMethodInfoPtr_set_MaxDiscomfort_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, 100667814);
		NativeMethodInfoPtr_get_ForeignObjectFaceType_Public_get_ForeignObjectFaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, 100667815);
		NativeMethodInfoPtr_set_ForeignObjectFaceType_Private_set_Void_ForeignObjectFaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, 100667816);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignObjectController>.NativeClassPtr, 100667817);
	}

	public ForeignObjectController(IntPtr pointer)
		: base(pointer)
	{
	}
}
