using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.ObjectUI.FadeOutPanel;

public class TimeWaitStarter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isEnd;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr___ctor_b__1_0_Private_Void_0;

	public unsafe bool isEnd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnd);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isEnd)) = flag;
		}
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 94393, RefRangeEnd = 94399, XrefRangeStart = 94386, XrefRangeEnd = 94393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TimeWaitStarter([DefaultParameterValue(null)] float waitTime)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&waitTime);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void __ctor_b__1_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___ctor_b__1_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static TimeWaitStarter()
	{
		Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.FadeOutPanel", "TimeWaitStarter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr);
		NativeFieldInfoPtr_isEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr, "isEnd");
		NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr, 100670207);
		NativeMethodInfoPtr___ctor_b__1_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeWaitStarter>.NativeClassPtr, 100670209);
	}

	public TimeWaitStarter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
