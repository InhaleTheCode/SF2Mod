using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Scripts.Base;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Scripts.InGame;

public class SaveManager : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AutoSaveMaxNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_ManualSaveMaxNum;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSaveSlot;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveSystem_Private_Static_Void_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSystem_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Void_SaveDataType_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveDataSlotIndex_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadSaveDataIsTrial_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int AutoSaveMaxNum
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AutoSaveMaxNum, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AutoSaveMaxNum, &num);
		}
	}

	public unsafe static int ManualSaveMaxNum
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ManualSaveMaxNum, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ManualSaveMaxNum, &num);
		}
	}

	public unsafe static int CurrentSaveSlot
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CurrentSaveSlot, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CurrentSaveSlot, &num);
		}
	}

	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 76053, RefRangeEnd = 76079, XrefRangeStart = 76035, XrefRangeEnd = 76053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsExistSaveData([DefaultParameterValue(null)] SaveRapper.SaveDataType type, int slot = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 76161, RefRangeEnd = 76163, XrefRangeStart = 76079, XrefRangeEnd = 76161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveSystem([DefaultParameterValue(null)] SaveRapper.SaveDataType type, int slot = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveSystem_Private_Static_Void_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 76250, RefRangeEnd = 76251, XrefRangeStart = 76163, XrefRangeEnd = 76250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LoadSystem()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSystem_Public_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 76317, RefRangeEnd = 76330, XrefRangeStart = 76251, XrefRangeEnd = 76317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Save([DefaultParameterValue(null)] SaveRapper.SaveDataType type, int slot = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Static_Void_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 76549, RefRangeEnd = 76554, XrefRangeStart = 76330, XrefRangeEnd = 76549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Load([DefaultParameterValue(null)] SaveRapper.SaveDataType type, int slot = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &slot;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Void_SaveDataType_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76554, XrefRangeEnd = 76561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LoadSaveDataSlotIndex([DefaultParameterValue(null)] int slot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSaveDataSlotIndex_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76561, XrefRangeEnd = 76579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool LoadSaveDataIsTrial([DefaultParameterValue(null)] int slot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&slot);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadSaveDataIsTrial_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe SaveManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveManager>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SaveManager()
	{
		Il2CppClassPointerStore<SaveManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Scripts.InGame", "SaveManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveManager>.NativeClassPtr);
		NativeFieldInfoPtr_AutoSaveMaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "AutoSaveMaxNum");
		NativeFieldInfoPtr_ManualSaveMaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "ManualSaveMaxNum");
		NativeFieldInfoPtr_CurrentSaveSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, "CurrentSaveSlot");
		NativeMethodInfoPtr_IsExistSaveData_Public_Static_Boolean_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668909);
		NativeMethodInfoPtr_SaveSystem_Private_Static_Void_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668910);
		NativeMethodInfoPtr_LoadSystem_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668911);
		NativeMethodInfoPtr_Save_Public_Static_Void_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668912);
		NativeMethodInfoPtr_Load_Public_Static_Void_SaveDataType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668913);
		NativeMethodInfoPtr_LoadSaveDataSlotIndex_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668914);
		NativeMethodInfoPtr_LoadSaveDataIsTrial_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668915);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveManager>.NativeClassPtr, 100668916);
	}

	public SaveManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
