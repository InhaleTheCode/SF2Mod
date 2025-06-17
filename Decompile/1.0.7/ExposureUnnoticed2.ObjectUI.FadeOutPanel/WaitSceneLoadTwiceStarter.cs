using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace ExposureUnnoticed2.ObjectUI.FadeOutPanel;

public class WaitSceneLoadTwiceStarter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_loadCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsCompletedLoad;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Scene_LoadSceneMode_PDM_0;

	public unsafe int loadCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadCount)) = num;
		}
	}

	public unsafe bool IsCompletedLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCompletedLoad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsCompletedLoad)) = flag;
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94463, RefRangeEnd = 94466, XrefRangeStart = 94453, XrefRangeEnd = 94463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitSceneLoadTwiceStarter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94466, XrefRangeEnd = 94476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Method_Private_Void_Scene_LoadSceneMode_PDM_0([DefaultParameterValue(null)] Scene scene, [DefaultParameterValue(null)] LoadSceneMode mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&scene);
		*(LoadSceneMode**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Method_Private_Void_Scene_LoadSceneMode_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static WaitSceneLoadTwiceStarter()
	{
		Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.FadeOutPanel", "WaitSceneLoadTwiceStarter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr);
		NativeFieldInfoPtr_loadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr, "loadCount");
		NativeFieldInfoPtr_IsCompletedLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr, "IsCompletedLoad");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr, 100670218);
		NativeMethodInfoPtr_Method_Private_Void_Scene_LoadSceneMode_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitSceneLoadTwiceStarter>.NativeClassPtr, 100670220);
	}

	public WaitSceneLoadTwiceStarter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
