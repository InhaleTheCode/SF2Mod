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

public class PortalWithShader : EffectBase
{
	[System.Serializable]
	[ObfuscatedName("UB.PortalWithShader/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__21_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__OnWillRenderObject_b__21_0_Internal_Boolean_Material_0;

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

		public unsafe static Il2CppSystem.Func<Material, bool> __9__21_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__21_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<Material, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__21_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39427, XrefRangeEnd = 39436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnWillRenderObject_b__21_0([DefaultParameterValue(null)] Material a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnWillRenderObject_b__21_0_Internal_Boolean_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__21_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665511);
			NativeMethodInfoPtr__OnWillRenderObject_b__21_0_Internal_Boolean_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665512);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_MainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_PortalCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr_Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_Destination;

	private static readonly System.IntPtr NativeFieldInfoPtr_Iterations;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomFloatParam2;

	private static readonly System.IntPtr NativeFieldInfoPtr_Shader;

	private static readonly System.IntPtr NativeFieldInfoPtr__material;

	private static readonly System.IntPtr NativeFieldInfoPtr_DisablePixelLights;

	private static readonly System.IntPtr NativeFieldInfoPtr_TextureSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_ReflectLayers;

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

	private static readonly System.IntPtr NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraModes_Private_Void_Camera_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMirrorObjects_Private_Void_Camera_byref_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Camera MainCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MainCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera PortalCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PortalCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Destination
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Destination);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(obj));
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39436, XrefRangeEnd = 39464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWillRenderObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39625, RefRangeEnd = 39626, XrefRangeStart = 39464, XrefRangeEnd = 39625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderMe([DefaultParameterValue(null)] Il2CppReferenceArray<Material> materials)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(materials);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39626, XrefRangeEnd = 39688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 39755, RefRangeEnd = 39756, XrefRangeStart = 39688, XrefRangeEnd = 39755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 39937, RefRangeEnd = 39938, XrefRangeStart = 39756, XrefRangeEnd = 39937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39938, XrefRangeEnd = 39948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PortalWithShader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static PortalWithShader()
	{
		Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UB", "PortalWithShader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr);
		NativeFieldInfoPtr_MainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "MainCamera");
		NativeFieldInfoPtr_PortalCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "PortalCamera");
		NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "Source");
		NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "Destination");
		NativeFieldInfoPtr_Iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "Iterations");
		NativeFieldInfoPtr_CustomFloatParam2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "CustomFloatParam2");
		NativeFieldInfoPtr_Shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "Shader");
		NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_material");
		NativeFieldInfoPtr_DisablePixelLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "DisablePixelLights");
		NativeFieldInfoPtr_TextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "TextureSize");
		NativeFieldInfoPtr_ReflectLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "ReflectLayers");
		NativeFieldInfoPtr__reflectionCameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_reflectionCameras");
		NativeFieldInfoPtr__reflectionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_reflectionTexture1");
		NativeFieldInfoPtr__reflectionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_reflectionTexture2");
		NativeFieldInfoPtr__reflectionTexture3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_reflectionTexture3");
		NativeFieldInfoPtr__oldReflectionTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "_oldReflectionTextureSize");
		NativeFieldInfoPtr_ZeroV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "ZeroV3");
		NativeFieldInfoPtr_OneV3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, "OneV3");
		NativeMethodInfoPtr_QuaternionFromMatrix_Public_Static_Quaternion_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665500);
		NativeMethodInfoPtr_PosToV4_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665501);
		NativeMethodInfoPtr_ToV3_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665502);
		NativeMethodInfoPtr_OnWillRenderObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665503);
		NativeMethodInfoPtr_RenderMe_Private_Void_Il2CppReferenceArray_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665504);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665505);
		NativeMethodInfoPtr_UpdateCameraModes_Private_Void_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665506);
		NativeMethodInfoPtr_CreateMirrorObjects_Private_Void_Camera_byref_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665507);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalWithShader>.NativeClassPtr, 100665508);
	}

	public PortalWithShader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
