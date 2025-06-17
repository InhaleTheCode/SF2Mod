using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Common.Scripts.Util;

public class CSVReader : MonoBehaviour
{
	private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_List_1_Il2CppStringArray_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 103721, RefRangeEnd = 103722, XrefRangeStart = 103699, XrefRangeEnd = 103721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Il2CppStringArray> Load([DefaultParameterValue(null)] string filename)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filename);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_List_1_Il2CppStringArray_String_0, (IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<Il2CppStringArray>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSVReader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSVReader>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CSVReader()
	{
		Il2CppClassPointerStore<CSVReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.Scripts.Util", "CSVReader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSVReader>.NativeClassPtr);
		NativeMethodInfoPtr_Load_Public_Static_List_1_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, 100670895);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSVReader>.NativeClassPtr, 100670896);
	}

	public CSVReader(IntPtr pointer)
		: base(pointer)
	{
	}
}
