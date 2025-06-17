using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Master.Common;

public class MCustomizeColor : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_SkinPattern;

	private static readonly IntPtr NativeFieldInfoPtr_EyeTextures;

	private static readonly IntPtr NativeFieldInfoPtr_EyeEmitTextures;

	private static readonly IntPtr NativeFieldInfoPtr_NormalSkinTexture;

	private static readonly IntPtr NativeFieldInfoPtr_HinnyuSkinTexture;

	private static readonly IntPtr NativeFieldInfoPtr_instance;

	private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_MCustomizeColor_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<SkinColor> SkinPattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkinPattern);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<SkinColor>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SkinPattern), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Texture> EyeTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeTextures);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeTextures), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Texture> EyeEmitTextures
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeEmitTextures);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Texture>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EyeEmitTextures), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture NormalSkinTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSkinTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NormalSkinTexture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Texture HinnyuSkinTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HinnyuSkinTexture);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Texture>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HinnyuSkinTexture), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static MCustomizeColor instance
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, &intPtr);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MCustomizeColor>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static MCustomizeColor Instance
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 68807, RefRangeEnd = 68817, XrefRangeStart = 68791, XrefRangeEnd = 68807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Instance_Public_Static_get_MCustomizeColor_0, (IntPtr)0, (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<MCustomizeColor>(intPtr) : null;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MCustomizeColor()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MCustomizeColor()
	{
		Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Common", "MCustomizeColor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr);
		NativeFieldInfoPtr_SkinPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "SkinPattern");
		NativeFieldInfoPtr_EyeTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "EyeTextures");
		NativeFieldInfoPtr_EyeEmitTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "EyeEmitTextures");
		NativeFieldInfoPtr_NormalSkinTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "NormalSkinTexture");
		NativeFieldInfoPtr_HinnyuSkinTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "HinnyuSkinTexture");
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, "instance");
		NativeMethodInfoPtr_get_Instance_Public_Static_get_MCustomizeColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, 100668203);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCustomizeColor>.NativeClassPtr, 100668204);
	}

	public MCustomizeColor(IntPtr pointer)
		: base(pointer)
	{
	}
}
