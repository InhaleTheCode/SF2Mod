using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ExposureUnnoticed2.Object3D.InteractArea;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcComponent : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_DokinAudioSource;

	private static readonly IntPtr NativeFieldInfoPtr_CeilingPlayerBlocker;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabFemale;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabMale;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabPreviousFemale;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabPreviousMale;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabOjis;

	private static readonly IntPtr NativeFieldInfoPtr_PrefabObas;

	private static readonly IntPtr NativeFieldInfoPtr_Smartphone;

	private static readonly IntPtr NativeFieldInfoPtr_SmartphoneLight;

	private static readonly IntPtr NativeFieldInfoPtr_Book;

	private static readonly IntPtr NativeFieldInfoPtr_AvatarParent;

	private static readonly IntPtr NativeFieldInfoPtr_InteractArea;

	private static readonly IntPtr NativeFieldInfoPtr_id;

	private static readonly IntPtr NativeFieldInfoPtr__AvaterObject_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__NpcController_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_get_AvaterObject_Public_get_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_AvaterObject_Public_set_Void_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_NpcController_Private_set_Void_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr_CreateController_Public_NpcController_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AudioSource DokinAudioSource
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokinAudioSource);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<AudioSource>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DokinAudioSource), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject CeilingPlayerBlocker
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CeilingPlayerBlocker);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CeilingPlayerBlocker), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PrefabFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabFemale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabFemale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PrefabMale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabMale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabMale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PrefabPreviousFemale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabPreviousFemale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabPreviousFemale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject PrefabPreviousMale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabPreviousMale);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabPreviousMale), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> PrefabOjis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabOjis);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabOjis), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> PrefabObas
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabObas);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PrefabObas), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Smartphone
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Smartphone);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Smartphone), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform SmartphoneLight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmartphoneLight);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SmartphoneLight), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Book
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Book);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Book), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform AvatarParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_AvatarParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe InteractAreaController InteractArea
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractArea);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<InteractAreaController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_InteractArea), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_id)) = num;
		}
	}

	public unsafe GameObject _AvaterObject_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvaterObject_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AvaterObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcController _NpcController_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcController_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__NpcController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject AvaterObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AvaterObject_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 61272, RefRangeEnd = 61273, XrefRangeStart = 61272, XrefRangeEnd = 61272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AvaterObject_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe NpcController NpcController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_NpcController_Private_set_Void_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61273, XrefRangeEnd = 61277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcController CreateController()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateController_Public_NpcController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcController>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcComponent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcComponent()
	{
		Il2CppClassPointerStore<NpcComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr);
		NativeFieldInfoPtr_DokinAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "DokinAudioSource");
		NativeFieldInfoPtr_CeilingPlayerBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "CeilingPlayerBlocker");
		NativeFieldInfoPtr_PrefabFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabFemale");
		NativeFieldInfoPtr_PrefabMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabMale");
		NativeFieldInfoPtr_PrefabPreviousFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabPreviousFemale");
		NativeFieldInfoPtr_PrefabPreviousMale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabPreviousMale");
		NativeFieldInfoPtr_PrefabOjis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabOjis");
		NativeFieldInfoPtr_PrefabObas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "PrefabObas");
		NativeFieldInfoPtr_Smartphone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "Smartphone");
		NativeFieldInfoPtr_SmartphoneLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "SmartphoneLight");
		NativeFieldInfoPtr_Book = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "Book");
		NativeFieldInfoPtr_AvatarParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "AvatarParent");
		NativeFieldInfoPtr_InteractArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "InteractArea");
		NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "id");
		NativeFieldInfoPtr__AvaterObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "<AvaterObject>k__BackingField");
		NativeFieldInfoPtr__NpcController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, "<NpcController>k__BackingField");
		NativeMethodInfoPtr_get_AvaterObject_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667393);
		NativeMethodInfoPtr_set_AvaterObject_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667394);
		NativeMethodInfoPtr_get_NpcController_Public_get_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667395);
		NativeMethodInfoPtr_set_NpcController_Private_set_Void_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667396);
		NativeMethodInfoPtr_CreateController_Public_NpcController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667397);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcComponent>.NativeClassPtr, 100667398);
	}

	public NpcComponent(IntPtr pointer)
		: base(pointer)
	{
	}
}
