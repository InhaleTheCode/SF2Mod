using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ES3Types;

public class ES3PropertiesAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_members;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

	public unsafe Il2CppStringArray members
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_members), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 4155, RefRangeEnd = 4177, XrefRangeStart = 4155, XrefRangeEnd = 4177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3PropertiesAttribute(Il2CppStringArray members = null)
	{
		if (members == null)
		{
			members = new Il2CppStringArray(0L);
		}
		this._002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3PropertiesAttribute>.NativeClassPtr));
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	public ES3PropertiesAttribute(params string[] members)
		: this(new Il2CppStringArray(members))
	{
	}

	static ES3PropertiesAttribute()
	{
		Il2CppClassPointerStore<ES3PropertiesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ES3Types", "ES3PropertiesAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3PropertiesAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_members = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3PropertiesAttribute>.NativeClassPtr, "members");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3PropertiesAttribute>.NativeClassPtr, 100664392);
	}

	public ES3PropertiesAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
