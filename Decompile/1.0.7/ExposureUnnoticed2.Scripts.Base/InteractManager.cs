using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.InteractArea;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.Scripts.Base;

public class InteractManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_interactList;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentInteractModel;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHead_Public_Static_InteractModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_InteractType_InteractAreaController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Static_Void_InteractType_InteractAreaController_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRegister_Public_Static_Boolean_InteractModel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_InteractEvent_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static List<InteractModel> interactList
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_interactList, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<InteractModel>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_interactList, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static InteractModel CurrentInteractModel
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentInteractModel, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractModel>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentInteractModel, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81392, XrefRangeEnd = 81404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81404, XrefRangeEnd = 81416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 81422, RefRangeEnd = 81428, XrefRangeStart = 81416, XrefRangeEnd = 81422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static InteractModel GetHead()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHead_Public_Static_InteractModel_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<InteractModel>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81428, XrefRangeEnd = 81438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Register([DefaultParameterValue(null)] InteractType type, [DefaultParameterValue(null)] InteractAreaController controller)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Register_Public_Static_Void_InteractType_InteractAreaController_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 81469, RefRangeEnd = 81471, XrefRangeStart = 81438, XrefRangeEnd = 81469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unregister([DefaultParameterValue(null)] InteractType type, [DefaultParameterValue(null)] InteractAreaController controller)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(controller);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unregister_Public_Static_Void_InteractType_InteractAreaController_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81471, XrefRangeEnd = 81476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsRegister([DefaultParameterValue(null)] InteractModel model)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRegister_Public_Static_Boolean_InteractModel_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81476, XrefRangeEnd = 81481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInteract([DefaultParameterValue(null)] InteractEvent evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnInteract_Private_Void_InteractEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe InteractManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static InteractManager()
	{
		Il2CppClassPointerStore<InteractManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.Base", "InteractManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractManager>.NativeClassPtr);
		NativeFieldInfoPtr_interactList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, "interactList");
		NativeFieldInfoPtr_CurrentInteractModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, "CurrentInteractModel");
		NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669306);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669307);
		NativeMethodInfoPtr_GetHead_Public_Static_InteractModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669308);
		NativeMethodInfoPtr_Register_Public_Static_Void_InteractType_InteractAreaController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669309);
		NativeMethodInfoPtr_Unregister_Public_Static_Void_InteractType_InteractAreaController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669310);
		NativeMethodInfoPtr_IsRegister_Public_Static_Boolean_InteractModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669311);
		NativeMethodInfoPtr_OnInteract_Private_Void_InteractEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669312);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractManager>.NativeClassPtr, 100669313);
	}

	public InteractManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
