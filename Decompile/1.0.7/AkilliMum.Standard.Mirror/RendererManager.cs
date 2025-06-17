using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public class RendererManager : ManagerBase
{
	public sealed class RendererSettings : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDebug_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__UpVector_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__CustomShaders_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DrawAlways_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UpVector_Public_get_UpVector_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_UpVector_Public_set_Void_UpVector_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_CustomShaders_Public_get_IList_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_CustomShaders_Public_set_Void_IList_1_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DrawAlways_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DrawAlways_Public_set_Void_Boolean_0;

		public unsafe bool _IsDebug_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDebug_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IsDebug_k__BackingField)) = flag;
			}
		}

		public unsafe UpVector _UpVector_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpVector_k__BackingField);
				return *(UpVector*)num;
			}
			set
			{
				*(UpVector*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UpVector_k__BackingField)) = upVector;
			}
		}

		public unsafe IList<string> _CustomShaders_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CustomShaders_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<string>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CustomShaders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe bool _DrawAlways_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DrawAlways_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DrawAlways_k__BackingField)) = flag;
			}
		}

		public unsafe bool IsDebug
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe UpVector UpVector
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UpVector_Public_get_UpVector_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(UpVector*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UpVector_Public_set_Void_UpVector_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe IList<string> CustomShaders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CustomShaders_Public_get_IList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IList<string>>(intPtr) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41219, RefRangeEnd = 41220, XrefRangeStart = 41219, XrefRangeEnd = 41219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CustomShaders_Public_set_Void_IList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool DrawAlways
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DrawAlways_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DrawAlways_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		static RendererSettings()
		{
			Il2CppClassPointerStore<RendererSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "RendererSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr);
			NativeFieldInfoPtr__IsDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, "<IsDebug>k__BackingField");
			NativeFieldInfoPtr__UpVector_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, "<UpVector>k__BackingField");
			NativeFieldInfoPtr__CustomShaders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, "<CustomShaders>k__BackingField");
			NativeFieldInfoPtr__DrawAlways_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, "<DrawAlways>k__BackingField");
			NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665617);
			NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665618);
			NativeMethodInfoPtr_get_UpVector_Public_get_UpVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665619);
			NativeMethodInfoPtr_set_UpVector_Public_set_Void_UpVector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665620);
			NativeMethodInfoPtr_get_CustomShaders_Public_get_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665621);
			NativeMethodInfoPtr_set_CustomShaders_Public_set_Void_IList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665622);
			NativeMethodInfoPtr_get_DrawAlways_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665623);
			NativeMethodInfoPtr_set_DrawAlways_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, 100665624);
		}

		public RendererSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public RendererSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__first;

	private static readonly System.IntPtr NativeFieldInfoPtr__renderers;

	private static readonly System.IntPtr NativeFieldInfoPtr__materials;

	private static readonly System.IntPtr NativeFieldInfoPtr__settings;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GameObject_RendererSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSettings_Public_Void_RendererSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReflectiveObjects_Public_Void_Il2CppReferenceArray_1_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectVisible_Public_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Public_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFirst_Public_GameObject_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetNormal_Public_Vector3_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMaterials_Public_Void_RenderTextureManager_CameraManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

	public unsafe GameObject _first
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__first);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__first), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Renderer> _renderers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderers);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderers), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Material> _materials
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materials);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Material>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__materials), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RendererSettings _settings
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings);
			return new RendererSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RendererSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41220, XrefRangeEnd = 41221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererManager([DefaultParameterValue(null)] Il2CppReferenceArray<GameObject> reflectiveObjects, [DefaultParameterValue(null)] RendererSettings renderSettings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectiveObjects);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderSettings));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GameObject_RendererSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSettings([DefaultParameterValue(null)] RendererSettings renderSettings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(renderSettings));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSettings_Public_Void_RendererSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41325, RefRangeEnd = 41327, XrefRangeStart = 41221, XrefRangeEnd = 41325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetReflectiveObjects([DefaultParameterValue(null)] Il2CppReferenceArray<GameObject> reflectiveObjects)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectiveObjects);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReflectiveObjects_Public_Void_Il2CppReferenceArray_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41365, RefRangeEnd = 41366, XrefRangeStart = 41327, XrefRangeEnd = 41365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsObjectVisible([DefaultParameterValue(null)] Camera cam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsObjectVisible_Public_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41366, XrefRangeEnd = 41370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe GameObject GetFirst()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFirst_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41389, RefRangeEnd = 41390, XrefRangeStart = 41370, XrefRangeEnd = 41389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetNormal([DefaultParameterValue(null)] bool invert)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&invert);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetNormal_Public_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41508, RefRangeEnd = 41509, XrefRangeStart = 41390, XrefRangeEnd = 41508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateMaterials([DefaultParameterValue(null)] RenderTextureManager renderTextureManager, [DefaultParameterValue(null)] CameraManager cameraManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderTextureManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(cameraManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateMaterials_Public_Void_RenderTextureManager_CameraManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe override void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RendererManager()
	{
		Il2CppClassPointerStore<RendererManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "RendererManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererManager>.NativeClassPtr);
		NativeFieldInfoPtr__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "_first");
		NativeFieldInfoPtr__renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "_renderers");
		NativeFieldInfoPtr__materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "_materials");
		NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, "_settings");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_GameObject_RendererSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665608);
		NativeMethodInfoPtr_SetSettings_Public_Void_RendererSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665609);
		NativeMethodInfoPtr_SetReflectiveObjects_Public_Void_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665610);
		NativeMethodInfoPtr_IsObjectVisible_Public_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665611);
		NativeMethodInfoPtr_GetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665612);
		NativeMethodInfoPtr_GetFirst_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665613);
		NativeMethodInfoPtr_GetNormal_Public_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665614);
		NativeMethodInfoPtr_UpdateMaterials_Public_Void_RenderTextureManager_CameraManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665615);
		NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererManager>.NativeClassPtr, 100665616);
	}

	public RendererManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
