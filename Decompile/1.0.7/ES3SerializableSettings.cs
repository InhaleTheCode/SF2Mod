using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

[Serializable]
public class ES3SerializableSettings : ES3Settings
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Location_0;

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5178, XrefRangeEnd = 5182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3SerializableSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5182, XrefRangeEnd = 5186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3SerializableSettings([DefaultParameterValue(null)] bool applyDefaults)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&applyDefaults);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5186, XrefRangeEnd = 5190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3SerializableSettings([DefaultParameterValue(null)] string path)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 5190, XrefRangeEnd = 5194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3SerializableSettings([DefaultParameterValue(null)] string path, [DefaultParameterValue(null)] ES3.Location location)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		*(ES3.Location**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &location;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Location_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3SerializableSettings()
	{
		Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3SerializableSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr, 100663743);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr, 100663744);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr, 100663745);
		NativeMethodInfoPtr__ctor_Public_Void_String_Location_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3SerializableSettings>.NativeClassPtr, 100663746);
	}

	public ES3SerializableSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
