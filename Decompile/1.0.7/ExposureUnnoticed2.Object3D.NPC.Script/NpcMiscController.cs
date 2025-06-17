using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcMiscController : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 4155, RefRangeEnd = 4177, XrefRangeStart = 4155, XrefRangeEnd = 4177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 62771, RefRangeEnd = 62772, XrefRangeStart = 62699, XrefRangeEnd = 62771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe NpcMiscController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcMiscController()
	{
		Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcMiscController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr);
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr, "nca");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr, 100667553);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr, 100667554);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcMiscController>.NativeClassPtr, 100667555);
	}

	public NpcMiscController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
