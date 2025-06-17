using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace ch.sycoforge.Decal.Wrapper;

public class EasyDecal : ch.sycoforge.Decal.EasyDecal
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7584, XrefRangeEnd = 7588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EasyDecal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EasyDecal>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static EasyDecal()
	{
		Il2CppClassPointerStore<EasyDecal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ch.sycoforge.Decal.Wrapper", "EasyDecal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EasyDecal>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EasyDecal>.NativeClassPtr, 100664043);
	}

	public EasyDecal(IntPtr pointer)
		: base(pointer)
	{
	}
}
