using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ES3Internal;

public static class ES3Hash : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_SHA1Hash_Public_Static_String_String_0;

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 28982, RefRangeEnd = 28991, XrefRangeStart = 28969, XrefRangeEnd = 28982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string SHA1Hash([DefaultParameterValue(null)] string input)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SHA1Hash_Public_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	static ES3Hash()
	{
		Il2CppClassPointerStore<ES3Hash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3Hash");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Hash>.NativeClassPtr);
		NativeMethodInfoPtr_SHA1Hash_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Hash>.NativeClassPtr, 100664829);
	}

	public ES3Hash(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
