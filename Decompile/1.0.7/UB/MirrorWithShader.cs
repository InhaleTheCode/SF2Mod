using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace UB;

public class MirrorWithShader : EffectBase
{
	[System.Serializable]
	[ObfuscatedName("UB.MirrorWithShader/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__28_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnWillRenderObject_b__28_0_Internal_Boolean_Material_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Func<Material, bool> __9__28_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__28_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Material, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__28_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38830, XrefRangeEnd = 38839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnWillRenderObject_b__28_0([DefaultParameterValue(null)] Material a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnWillRenderObject_b__28_0_Internal_Boolean_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__28_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665498);
			NativeMethodInfoPtr__OnWillRenderObject_b__28_0_Internal_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665499);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_UniqueName;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpdateOnEditor;

	private static readonly System.IntPtr NativeFieldInfoPtr_WorkType;

	private static readonly System.IntPtr NativeFieldInfoPtr_UseCameraClipPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_UpVector;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisablePixelLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_ClipPlaneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_Camera;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectLayers;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionCameraPrefab;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionCameraPrefabInstance;

	private static readonly System.IntPtr NativeFieldInfoPtr_Shader;

	private static readonly System.IntPtr NativeFieldInfoPtr_Lod;

	private static readonly System.IntPtr NativeFieldInfoPtr_Iterations;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomFloatParam2;

	private static readonly System.IntPtr NativeFieldInfoPtr__material;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionCameras;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionTexture1;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionTexture2;

	private static readonly System.IntPtr NativeFieldInfoPtr__reflectionTexture3;

	private static readonly System.IntPtr NativeFieldInfoPtr__oldReflectionTextureSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_ZeroV3;

	private static readonly System.IntPtr NativeFieldInfoPtr_OneV3;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PosToV4_Public_Static_Vector4_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMaterial_Private_Void_Material_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraModes_Private_Void_Camera_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMirrorObjects_Private_Void_Camera_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateReflectionMatrix_Private_Void_byref_Matrix4x4_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string UniqueName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniqueName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UniqueName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool UpdateOnEditor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnEditor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpdateOnEditor)) = flag;
		}
	}

	public unsafe WorkType WorkType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorkType);
			return *(WorkType*)num;
		}
		set
		{
			*(WorkType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorkType)) = workType;
		}
	}

	public unsafe bool UseCameraClipPlane
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCameraClipPlane);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseCameraClipPlane)) = flag;
		}
	}

	public unsafe FollowVector UpVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpVector);
			return *(FollowVector*)num;
		}
		set
		{
			*(FollowVector*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpVector)) = followVector;
		}
	}

	public unsafe bool DisablePixelLights
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePixelLights);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DisablePixelLights)) = flag;
		}
	}

	public unsafe int TextureSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TextureSize)) = num;
		}
	}

	public unsafe float ClipPlaneOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipPlaneOffset);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipPlaneOffset)) = num;
		}
	}

	public unsafe Camera Camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Camera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Camera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe LayerMask ReflectLayers
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectLayers);
			return *(LayerMask*)num;
		}
		set
		{
			*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectLayers)) = layerMask;
		}
	}

	public unsafe GameObject ReflectionCameraPrefab
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectionCameraPrefab);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectionCameraPrefab), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _reflectionCameraPrefabInstance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionCameraPrefabInstance);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionCameraPrefabInstance), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Shader Shader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shader);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int Lod
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lod);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Lod)) = num;
		}
	}

	public unsafe int Iterations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Iterations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Iterations)) = num;
		}
	}

	public unsafe float CustomFloatParam2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomFloatParam2);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomFloatParam2)) = num;
		}
	}

	public unsafe Material _material
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__material);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Hashtable _reflectionCameras
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionCameras);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Hashtable>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionCameras), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _reflectionTexture1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _reflectionTexture2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _reflectionTexture3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__reflectionTexture3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int _oldReflectionTextureSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oldReflectionTextureSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__oldReflectionTextureSize)) = num;
		}
	}

	public unsafe static Vector3 ZeroV3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ZeroV3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ZeroV3, &vector);
		}
	}

	public unsafe static Vector3 OneV3
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Vector3 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OneV3, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OneV3, &vector);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38839, XrefRangeEnd = 38841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion QuaternionFromMatrix([DefaultParameterValue(null)] Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector4 PosToV4([DefaultParameterValue(null)] Vector3 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PosToV4_Public_Static_Vector4_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe static Vector3 ToV3([DefaultParameterValue(null)] Vector4 v)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&v);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector4_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38841, XrefRangeEnd = 38845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38845, XrefRangeEnd = 38873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWillRenderObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39096, RefRangeEnd = 39097, XrefRangeStart = 38873, XrefRangeEnd = 39096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderMe([DefaultParameterValue(null)] Il2CppReferenceArray<Material> materials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 39108, RefRangeEnd = 39111, XrefRangeStart = 39097, XrefRangeEnd = 39108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMaterial([DefaultParameterValue(null)] Material mat, [DefaultParameterValue(null)] string properyName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(properyName);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMaterial_Private_Void_Material_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39111, XrefRangeEnd = 39173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39261, RefRangeEnd = 39262, XrefRangeStart = 39173, XrefRangeEnd = 39261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraModes([DefaultParameterValue(null)] Camera src, [DefaultParameterValue(null)] Camera dest)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(dest);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraModes_Private_Void_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39406, RefRangeEnd = 39407, XrefRangeStart = 39262, XrefRangeEnd = 39406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMirrorObjects([DefaultParameterValue(null)] Camera currentCamera, [DefaultParameterValue(null)] out Camera reflectionCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentCamera);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMirrorObjects_Private_Void_Camera_byref_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		nint num3 = num2;
		reflectionCamera = ((num3 == 0) ? null : new Camera(num3));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39413, RefRangeEnd = 39415, XrefRangeStart = 39407, XrefRangeEnd = 39413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 CameraSpacePlane([DefaultParameterValue(null)] Camera cam, [DefaultParameterValue(null)] Vector3 pos, [DefaultParameterValue(null)] Vector3 normal, [DefaultParameterValue(null)] float sideSign)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sideSign;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe void CalculateReflectionMatrix([DefaultParameterValue(null)] ref Matrix4x4 reflectionMat, [DefaultParameterValue(null)] Vector4 plane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reflectionMat);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &plane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateReflectionMatrix_Private_Void_byref_Matrix4x4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39415, XrefRangeEnd = 39427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MirrorWithShader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MirrorWithShader()
	{
		Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "MirrorWithShader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr);
		NativeFieldInfoPtr_UniqueName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "UniqueName");
		NativeFieldInfoPtr_UpdateOnEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "UpdateOnEditor");
		NativeFieldInfoPtr_WorkType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "WorkType");
		NativeFieldInfoPtr_UseCameraClipPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "UseCameraClipPlane");
		NativeFieldInfoPtr_UpVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "UpVector");
		NativeFieldInfoPtr_DisablePixelLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "DisablePixelLights");
		NativeFieldInfoPtr_TextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "TextureSize");
		NativeFieldInfoPtr_ClipPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "ClipPlaneOffset");
		NativeFieldInfoPtr_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "Camera");
		NativeFieldInfoPtr_ReflectLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "ReflectLayers");
		NativeFieldInfoPtr_ReflectionCameraPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "ReflectionCameraPrefab");
		NativeFieldInfoPtr__reflectionCameraPrefabInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_reflectionCameraPrefabInstance");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr_Lod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "Lod");
		NativeFieldInfoPtr_Iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "Iterations");
		NativeFieldInfoPtr_CustomFloatParam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "CustomFloatParam2");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_material");
		NativeFieldInfoPtr__reflectionCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_reflectionCameras");
		NativeFieldInfoPtr__reflectionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_reflectionTexture1");
		NativeFieldInfoPtr__reflectionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_reflectionTexture2");
		NativeFieldInfoPtr__reflectionTexture3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_reflectionTexture3");
		NativeFieldInfoPtr__oldReflectionTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "_oldReflectionTextureSize");
		NativeFieldInfoPtr_ZeroV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "ZeroV3");
		NativeFieldInfoPtr_OneV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, "OneV3");
		NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665483);
		NativeMethodInfoPtr_PosToV4_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665484);
		NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665485);
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665486);
		NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665487);
		NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665488);
		NativeMethodInfoPtr_SetMaterial_Private_Void_Material_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665489);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665490);
		NativeMethodInfoPtr_UpdateCameraModes_Private_Void_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665491);
		NativeMethodInfoPtr_CreateMirrorObjects_Private_Void_Camera_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665492);
		NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Camera_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665493);
		NativeMethodInfoPtr_CalculateReflectionMatrix_Private_Void_byref_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665494);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorWithShader>.NativeClassPtr, 100665495);
	}

	public MirrorWithShader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
