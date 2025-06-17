using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.Util;

public class MyUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPeak_Public_Static_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddAutoPlusString_Public_Static_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(0)]
	public unsafe static float ConvertPeak([DefaultParameterValue(null)] float input, [DefaultParameterValue(null)] float peak, [DefaultParameterValue(null)] float range)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&input);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &peak;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &range;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertPeak_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 78820, RefRangeEnd = 78824, XrefRangeStart = 78816, XrefRangeEnd = 78820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string AddAutoPlusString([DefaultParameterValue(null)] int val)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&val);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddAutoPlusString_Public_Static_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	public unsafe MyUtil()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyUtil>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MyUtil()
	{
		Il2CppClassPointerStore<MyUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Util", "MyUtil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyUtil>.NativeClassPtr);
		NativeMethodInfoPtr_ConvertPeak_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyUtil>.NativeClassPtr, 100669129);
		NativeMethodInfoPtr_AddAutoPlusString_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyUtil>.NativeClassPtr, 100669130);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyUtil>.NativeClassPtr, 100669131);
	}

	public MyUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
