using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

public class ES3Defaults : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_settings;

	private static readonly IntPtr NativeFieldInfoPtr_addMgrToSceneAutomatically;

	private static readonly IntPtr NativeFieldInfoPtr_autoUpdateReferences;

	private static readonly IntPtr NativeFieldInfoPtr_addAllPrefabsToManager;

	private static readonly IntPtr NativeFieldInfoPtr_collectDependenciesDepth;

	private static readonly IntPtr NativeFieldInfoPtr_collectDependenciesTimeout;

	private static readonly IntPtr NativeFieldInfoPtr_updateReferencesWhenSceneChanges;

	private static readonly IntPtr NativeFieldInfoPtr_updateReferencesWhenSceneIsSaved;

	private static readonly IntPtr NativeFieldInfoPtr_updateReferencesWhenSceneIsOpened;

	private static readonly IntPtr NativeFieldInfoPtr_referenceFolders;

	private static readonly IntPtr NativeFieldInfoPtr_logDebugInfo;

	private static readonly IntPtr NativeFieldInfoPtr_logWarnings;

	private static readonly IntPtr NativeFieldInfoPtr_logErrors;

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

	public unsafe bool addMgrToSceneAutomatically
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addMgrToSceneAutomatically);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addMgrToSceneAutomatically)) = flag;
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

	public unsafe bool addAllPrefabsToManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addAllPrefabsToManager);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_addAllPrefabsToManager)) = flag;
		}
	}

	public unsafe int collectDependenciesDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDependenciesDepth);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDependenciesDepth)) = num;
		}
	}

	public unsafe int collectDependenciesTimeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDependenciesTimeout);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_collectDependenciesTimeout)) = num;
		}
	}

	public unsafe bool updateReferencesWhenSceneChanges
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneChanges);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneChanges)) = flag;
		}
	}

	public unsafe bool updateReferencesWhenSceneIsSaved
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneIsSaved);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneIsSaved)) = flag;
		}
	}

	public unsafe bool updateReferencesWhenSceneIsOpened
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneIsOpened);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_updateReferencesWhenSceneIsOpened)) = flag;
		}
	}

	public unsafe Il2CppStringArray referenceFolders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceFolders);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_referenceFolders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool logDebugInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logDebugInfo);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logDebugInfo)) = flag;
		}
	}

	public unsafe bool logWarnings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logWarnings);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logWarnings)) = flag;
		}
	}

	public unsafe bool logErrors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logErrors);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_logErrors)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4575, XrefRangeEnd = 4586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Defaults()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Defaults()
	{
		Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3Defaults");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr);
		NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "settings");
		NativeFieldInfoPtr_addMgrToSceneAutomatically = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "addMgrToSceneAutomatically");
		NativeFieldInfoPtr_autoUpdateReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "autoUpdateReferences");
		NativeFieldInfoPtr_addAllPrefabsToManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "addAllPrefabsToManager");
		NativeFieldInfoPtr_collectDependenciesDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "collectDependenciesDepth");
		NativeFieldInfoPtr_collectDependenciesTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "collectDependenciesTimeout");
		NativeFieldInfoPtr_updateReferencesWhenSceneChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "updateReferencesWhenSceneChanges");
		NativeFieldInfoPtr_updateReferencesWhenSceneIsSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "updateReferencesWhenSceneIsSaved");
		NativeFieldInfoPtr_updateReferencesWhenSceneIsOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "updateReferencesWhenSceneIsOpened");
		NativeFieldInfoPtr_referenceFolders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "referenceFolders");
		NativeFieldInfoPtr_logDebugInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "logDebugInfo");
		NativeFieldInfoPtr_logWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "logWarnings");
		NativeFieldInfoPtr_logErrors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, "logErrors");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Defaults>.NativeClassPtr, 100663726);
	}

	public ES3Defaults(IntPtr pointer)
		: base(pointer)
	{
	}
}
