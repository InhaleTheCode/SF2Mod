using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.SceneManagement;

namespace ExposureUnnoticed2.ObjectUI.FadeOutPanel;

public class WaitSceneLoadStarter : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isCompletedLoad;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_Scene_LoadSceneMode_PDM_0;

	public unsafe bool isCompletedLoad
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompletedLoad);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isCompletedLoad)) = flag;
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 94409, RefRangeEnd = 94412, XrefRangeStart = 94399, XrefRangeEnd = 94409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitSceneLoadStarter()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94412, XrefRangeEnd = 94422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static WaitSceneLoadStarter()
	{
		Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.FadeOutPanel", "WaitSceneLoadStarter");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr);
		NativeFieldInfoPtr_isCompletedLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr, "isCompletedLoad");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr, 100670210);
		NativeMethodInfoPtr_Method_Private_Void_Scene_LoadSceneMode_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitSceneLoadStarter>.NativeClassPtr, 100670212);
	}

	public WaitSceneLoadStarter(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
