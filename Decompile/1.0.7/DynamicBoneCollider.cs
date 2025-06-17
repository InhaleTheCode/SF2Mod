using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

public class DynamicBoneCollider : DynamicBoneColliderBase
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Radius;

	private static readonly IntPtr NativeFieldInfoPtr_m_Height;

	private static readonly IntPtr NativeFieldInfoPtr_m_Radius2;

	private static readonly IntPtr NativeFieldInfoPtr_m_ScaledRadius;

	private static readonly IntPtr NativeFieldInfoPtr_m_ScaledRadius2;

	private static readonly IntPtr NativeFieldInfoPtr_m_C0;

	private static readonly IntPtr NativeFieldInfoPtr_m_C1;

	private static readonly IntPtr NativeFieldInfoPtr_m_C01Distance;

	private static readonly IntPtr NativeFieldInfoPtr_m_CollideType;

	private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Collide_Public_Virtual_Boolean_byref_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OutsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OutsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OutsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_InsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_DrawCapsule_Private_Static_Void_Vector3_Vector3_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float m_Radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius)) = num;
		}
	}

	public unsafe float m_Height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Height);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Height)) = num;
		}
	}

	public unsafe float m_Radius2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius2)) = num;
		}
	}

	public unsafe float m_ScaledRadius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScaledRadius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScaledRadius)) = num;
		}
	}

	public unsafe float m_ScaledRadius2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScaledRadius2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ScaledRadius2)) = num;
		}
	}

	public unsafe Vector3 m_C0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C0);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C0)) = vector;
		}
	}

	public unsafe Vector3 m_C1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C1);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C1)) = vector;
		}
	}

	public unsafe float m_C01Distance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C01Distance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_C01Distance)) = num;
		}
	}

	public unsafe int m_CollideType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollideType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CollideType)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977, XrefRangeEnd = 990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990, XrefRangeEnd = 1004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Collide([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Collide_Public_Virtual_Boolean_byref_Vector3_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1004, XrefRangeEnd = 1007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OutsideSphere([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 sphereCenter, [DefaultParameterValue(null)] float sphereRadius)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sphereCenter;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &sphereRadius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OutsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007, XrefRangeEnd = 1010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InsideSphere([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 sphereCenter, [DefaultParameterValue(null)] float sphereRadius)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &sphereCenter;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &sphereRadius;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1019, RefRangeEnd = 1020, XrefRangeStart = 1010, XrefRangeEnd = 1019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OutsideCapsule([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 capsuleP0, [DefaultParameterValue(null)] Vector3 capsuleP1, [DefaultParameterValue(null)] float capsuleRadius, [DefaultParameterValue(null)] float dirlen)
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP0;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &dirlen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OutsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1029, RefRangeEnd = 1030, XrefRangeStart = 1020, XrefRangeEnd = 1029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InsideCapsule([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 capsuleP0, [DefaultParameterValue(null)] Vector3 capsuleP1, [DefaultParameterValue(null)] float capsuleRadius, [DefaultParameterValue(null)] float dirlen)
	{
		IntPtr* ptr = stackalloc IntPtr[6];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP0;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &dirlen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1040, RefRangeEnd = 1041, XrefRangeStart = 1030, XrefRangeEnd = 1040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool OutsideCapsule2([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 capsuleP0, [DefaultParameterValue(null)] Vector3 capsuleP1, [DefaultParameterValue(null)] float capsuleRadius0, [DefaultParameterValue(null)] float capsuleRadius1, [DefaultParameterValue(null)] float dirlen)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP0;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius0;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius1;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &dirlen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OutsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1051, RefRangeEnd = 1052, XrefRangeStart = 1041, XrefRangeEnd = 1051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool InsideCapsule2([DefaultParameterValue(null)] ref Vector3 particlePosition, [DefaultParameterValue(null)] float particleRadius, [DefaultParameterValue(null)] Vector3 capsuleP0, [DefaultParameterValue(null)] Vector3 capsuleP1, [DefaultParameterValue(null)] float capsuleRadius0, [DefaultParameterValue(null)] float capsuleRadius1, [DefaultParameterValue(null)] float dirlen)
	{
		IntPtr* ptr = stackalloc IntPtr[7];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref particlePosition);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &particleRadius;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP0;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleP1;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius0;
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(IntPtr)))) = &capsuleRadius1;
		*(float**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(IntPtr)))) = &dirlen;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1052, XrefRangeEnd = 1060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1060, XrefRangeEnd = 1066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DrawCapsule([DefaultParameterValue(null)] Vector3 c0, [DefaultParameterValue(null)] Vector3 c1, [DefaultParameterValue(null)] float radius0, [DefaultParameterValue(null)] float radius1)
	{
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&c0);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &c1;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &radius0;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &radius1;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawCapsule_Private_Static_Void_Vector3_Vector3_Single_Single_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1066, XrefRangeEnd = 1067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicBoneCollider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DynamicBoneCollider()
	{
		Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynamicBoneCollider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr);
		NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_Radius");
		NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_Height");
		NativeFieldInfoPtr_m_Radius2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_Radius2");
		NativeFieldInfoPtr_m_ScaledRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_ScaledRadius");
		NativeFieldInfoPtr_m_ScaledRadius2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_ScaledRadius2");
		NativeFieldInfoPtr_m_C0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_C0");
		NativeFieldInfoPtr_m_C1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_C1");
		NativeFieldInfoPtr_m_C01Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_C01Distance");
		NativeFieldInfoPtr_m_CollideType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, "m_CollideType");
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Prepare_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_Collide_Public_Virtual_Boolean_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_OutsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_InsideSphere_Private_Static_Boolean_byref_Vector3_Single_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_OutsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_InsideCapsule_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663367);
		NativeMethodInfoPtr_OutsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663368);
		NativeMethodInfoPtr_InsideCapsule2_Private_Static_Boolean_byref_Vector3_Single_Vector3_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663369);
		NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663370);
		NativeMethodInfoPtr_DrawCapsule_Private_Static_Void_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663371);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBoneCollider>.NativeClassPtr, 100663372);
	}

	public DynamicBoneCollider(IntPtr pointer)
		: base(pointer)
	{
	}
}
