using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Ricimi;

public class Gradient : BaseMeshEffect
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Matrix2x3
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m00;

		private static readonly System.IntPtr NativeFieldInfoPtr_m01;

		private static readonly System.IntPtr NativeFieldInfoPtr_m02;

		private static readonly System.IntPtr NativeFieldInfoPtr_m10;

		private static readonly System.IntPtr NativeFieldInfoPtr_m11;

		private static readonly System.IntPtr NativeFieldInfoPtr_m12;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Matrix2x3_Vector2_0;

		[FieldOffset(0)]
		public float m00;

		[FieldOffset(4)]
		public float m01;

		[FieldOffset(8)]
		public float m02;

		[FieldOffset(12)]
		public float m10;

		[FieldOffset(16)]
		public float m11;

		[FieldOffset(20)]
		public float m12;

		[CallerCount(0)]
		public unsafe Matrix2x3([DefaultParameterValue(null)] float m00, [DefaultParameterValue(null)] float m01, [DefaultParameterValue(null)] float m02, [DefaultParameterValue(null)] float m10, [DefaultParameterValue(null)] float m11, [DefaultParameterValue(null)] float m12)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = (nint)(&m00);
			*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &m01;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &m02;
			*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &m10;
			*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &m11;
			*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &m12;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		public unsafe static Vector2 operator *([DefaultParameterValue(null)] Matrix2x3 m, [DefaultParameterValue(null)] Vector2 v)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&m);
			*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &v;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Matrix2x3_Vector2_0, (System.IntPtr)0, (void**)ptr, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static Matrix2x3()
		{
			Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "Matrix2x3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr);
			NativeFieldInfoPtr_m00 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m00");
			NativeFieldInfoPtr_m01 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m01");
			NativeFieldInfoPtr_m02 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m02");
			NativeFieldInfoPtr_m10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m10");
			NativeFieldInfoPtr_m11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m11");
			NativeFieldInfoPtr_m12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, "m12");
			NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, 100665219);
			NativeMethodInfoPtr_op_Multiply_Public_Static_Vector2_Matrix2x3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, 100665220);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Matrix2x3>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_Color1;

	private static readonly System.IntPtr NativeFieldInfoPtr_Color2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Angle;

	private static readonly System.IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LocalPositionMatrix_Private_Matrix2x3_Rect_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotationDir_Private_Vector2_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Color Color1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color1)) = color;
		}
	}

	public unsafe Color Color2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color2);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Color2)) = color;
		}
	}

	public unsafe float Angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Angle)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33101, XrefRangeEnd = 33123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void ModifyMesh([DefaultParameterValue(null)] VertexHelper vh)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe Matrix2x3 LocalPositionMatrix([DefaultParameterValue(null)] Rect rect, [DefaultParameterValue(null)] Vector2 dir)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &dir;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LocalPositionMatrix_Private_Matrix2x3_Rect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Matrix2x3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33123, XrefRangeEnd = 33125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector2 RotationDir([DefaultParameterValue(null)] float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&angle);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotationDir_Private_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33125, XrefRangeEnd = 33128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Gradient()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Gradient>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static Gradient()
	{
		Il2CppClassPointerStore<Gradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ricimi", "Gradient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Gradient>.NativeClassPtr);
		NativeFieldInfoPtr_Color1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "Color1");
		NativeFieldInfoPtr_Color2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "Color2");
		NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Gradient>.NativeClassPtr, "Angle");
		NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665215);
		NativeMethodInfoPtr_LocalPositionMatrix_Private_Matrix2x3_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665216);
		NativeMethodInfoPtr_RotationDir_Private_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665217);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Gradient>.NativeClassPtr, 100665218);
	}

	public Gradient(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
