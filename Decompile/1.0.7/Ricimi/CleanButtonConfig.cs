using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Ricimi;

public class CleanButtonConfig : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

	private static readonly IntPtr NativeFieldInfoPtr_onHoverAlpha;

	private static readonly IntPtr NativeFieldInfoPtr_onClickAlpha;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float fadeTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fadeTime)) = num;
		}
	}

	public unsafe float onHoverAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onHoverAlpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onHoverAlpha)) = num;
		}
	}

	public unsafe float onClickAlpha
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onClickAlpha);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_onClickAlpha)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 33098, XrefRangeEnd = 33101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CleanButtonConfig()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CleanButtonConfig()
	{
		Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ricimi", "CleanButtonConfig");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr);
		NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr, "fadeTime");
		NativeFieldInfoPtr_onHoverAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr, "onHoverAlpha");
		NativeFieldInfoPtr_onClickAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr, "onClickAlpha");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanButtonConfig>.NativeClassPtr, 100665214);
	}

	public CleanButtonConfig(IntPtr pointer)
		: base(pointer)
	{
	}
}
