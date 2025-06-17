using System;
using System.Runtime.CompilerServices;
using ES3Internal;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

public class ES3ReferenceMgr : ES3ReferenceMgrBase
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3877, XrefRangeEnd = 3881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3ReferenceMgr()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3ReferenceMgr>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3ReferenceMgr()
	{
		Il2CppClassPointerStore<ES3ReferenceMgr>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3ReferenceMgr");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3ReferenceMgr>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3ReferenceMgr>.NativeClassPtr, 100663620);
	}

	public ES3ReferenceMgr(IntPtr pointer)
		: base(pointer)
	{
	}
}
