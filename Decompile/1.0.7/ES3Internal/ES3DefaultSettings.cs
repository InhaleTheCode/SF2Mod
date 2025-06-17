using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ES3Internal;

public class ES3DefaultSettings : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_settings;

	private static readonly IntPtr NativeFieldInfoPtr_autoUpdateReferences;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ES3SerializableSettings settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ES3SerializableSettings>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool autoUpdateReferences
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUpdateReferences);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_autoUpdateReferences)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31720, XrefRangeEnd = 31723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3DefaultSettings()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3DefaultSettings()
	{
		Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Internal", "ES3DefaultSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_autoUpdateReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr, "autoUpdateReferences");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3DefaultSettings>.NativeClassPtr, 100665047);
	}

	public ES3DefaultSettings(IntPtr pointer)
		: base(pointer)
	{
	}
}
