using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public class SimpleMover : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_MoveOnXMin;

	private static readonly IntPtr NativeFieldInfoPtr_MoveOnXMax;

	private static readonly IntPtr NativeFieldInfoPtr__isGoingLeft;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float MoveOnXMin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveOnXMin);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveOnXMin)) = num;
		}
	}

	public unsafe float MoveOnXMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveOnXMax);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MoveOnXMax)) = num;
		}
	}

	public unsafe bool _isGoingLeft
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isGoingLeft);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isGoingLeft)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SimpleMover()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SimpleMover()
	{
		Il2CppClassPointerStore<SimpleMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "SimpleMover");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr);
		NativeFieldInfoPtr_MoveOnXMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr, "MoveOnXMin");
		NativeFieldInfoPtr_MoveOnXMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr, "MoveOnXMax");
		NativeFieldInfoPtr__isGoingLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr, "_isGoingLeft");
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr, 100665572);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleMover>.NativeClassPtr, 100665573);
	}

	public SimpleMover(IntPtr pointer)
		: base(pointer)
	{
	}
}
