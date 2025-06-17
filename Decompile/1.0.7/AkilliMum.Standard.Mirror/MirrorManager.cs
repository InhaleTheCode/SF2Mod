using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AkilliMum.Standard.Mirror;

public class MirrorManager : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_IsDebug;

	private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

	private static readonly IntPtr NativeFieldInfoPtr_Name;

	private static readonly IntPtr NativeFieldInfoPtr_IsMirrorInMirror;

	private static readonly IntPtr NativeFieldInfoPtr_MirrorInMirrorId;

	private static readonly IntPtr NativeFieldInfoPtr_TurnOffOcclusion;

	private static readonly IntPtr NativeFieldInfoPtr_Platform;

	private static readonly IntPtr NativeFieldInfoPtr_ForceMultiPass;

	private static readonly IntPtr NativeFieldInfoPtr_WorkingType;

	private static readonly IntPtr NativeFieldInfoPtr_ClearBackGround;

	private static readonly IntPtr NativeFieldInfoPtr_ClearColor;

	private static readonly IntPtr NativeFieldInfoPtr_UpVector;

	private static readonly IntPtr NativeFieldInfoPtr_CameraLODLevel;

	private static readonly IntPtr NativeFieldInfoPtr_UseClipping;

	private static readonly IntPtr NativeFieldInfoPtr_ClippingPercentage;

	private static readonly IntPtr NativeFieldInfoPtr_ClipUV;

	private static readonly IntPtr NativeFieldInfoPtr_ClipEye;

	private static readonly IntPtr NativeFieldInfoPtr_HDR;

	private static readonly IntPtr NativeFieldInfoPtr_FOV;

	private static readonly IntPtr NativeFieldInfoPtr_MSAALevel;

	private static readonly IntPtr NativeFieldInfoPtr_RenderPostProcessing;

	private static readonly IntPtr NativeFieldInfoPtr_RequiresDepthTexture;

	private static readonly IntPtr NativeFieldInfoPtr_RequiresOpaqueTexture;

	private static readonly IntPtr NativeFieldInfoPtr_FilterMode;

	private static readonly IntPtr NativeFieldInfoPtr_MipMapping;

	private static readonly IntPtr NativeFieldInfoPtr_DisablePixelLights;

	private static readonly IntPtr NativeFieldInfoPtr_Shadow;

	private static readonly IntPtr NativeFieldInfoPtr_Cull;

	private static readonly IntPtr NativeFieldInfoPtr_CullDistance;

	private static readonly IntPtr NativeFieldInfoPtr_RenderTextureSize;

	private static readonly IntPtr NativeFieldInfoPtr_ManualSize;

	private static readonly IntPtr NativeFieldInfoPtr_ClipPlaneOffset;

	private static readonly IntPtr NativeFieldInfoPtr_ReflectLayers;

	private static readonly IntPtr NativeFieldInfoPtr_ReflectiveObjects;

	private static readonly IntPtr NativeFieldInfoPtr_DrawAlways;

	private static readonly IntPtr NativeFieldInfoPtr_FakeCamera;

	private static readonly IntPtr NativeFieldInfoPtr_EnableDepth;

	private static readonly IntPtr NativeFieldInfoPtr_EnableDepthBlur;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurShader;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurCutoff;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurIterations;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurSurfacePower;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurHorizontalMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_DepthBlurVerticalMultiplier;

	private static readonly IntPtr NativeFieldInfoPtr_CustomShaders;

	private static readonly IntPtr NativeFieldInfoPtr_UIImage;

	private static readonly IntPtr NativeFieldInfoPtr_UIImageDepth;

	private static readonly IntPtr NativeFieldInfoPtr__camera;

	private static readonly IntPtr NativeFieldInfoPtr__cameraAttached;

	private static readonly IntPtr NativeFieldInfoPtr__cameraManager;

	private static readonly IntPtr NativeFieldInfoPtr__rendererManager;

	private static readonly IntPtr NativeFieldInfoPtr__renderTextureManager;

	private static readonly IntPtr NativeFieldInfoPtr__optionManager;

	private static readonly IntPtr NativeFieldInfoPtr__frameDrawn;

	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeMirror_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRenderTextureSettings_Private_RenderTextureSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetRendererSettings_Private_RendererSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCameraSettings_Private_CameraSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetOptionSettings_Private_OptionSettings_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnPreRender_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RenderReflective_Public_Virtual_New_IList_1_Camera_Camera_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCamera_Private_Camera_Camera_0;

	private static readonly IntPtr NativeMethodInfoPtr_CommonRender_Public_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RenderMe_Private_Camera_StereoTargetEyeMask_Camera_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool IsDebug
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDebug);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsDebug)) = flag;
		}
	}

	public unsafe bool IsEnabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEnabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsEnabled)) = flag;
		}
	}

	public unsafe string Name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool IsMirrorInMirror
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMirrorInMirror);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsMirrorInMirror)) = flag;
		}
	}

	public unsafe string MirrorInMirrorId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorInMirrorId);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MirrorInMirrorId), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe bool TurnOffOcclusion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnOffOcclusion);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TurnOffOcclusion)) = flag;
		}
	}

	public unsafe Platform Platform
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Platform);
			return *(Platform*)num;
		}
		set
		{
			*(Platform*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Platform)) = platform;
		}
	}

	public unsafe bool ForceMultiPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceMultiPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ForceMultiPass)) = flag;
		}
	}

	public unsafe WorkingType WorkingType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorkingType);
			return *(WorkingType*)num;
		}
		set
		{
			*(WorkingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_WorkingType)) = workingType;
		}
	}

	public unsafe ClearBackGround ClearBackGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearBackGround);
			return *(ClearBackGround*)num;
		}
		set
		{
			*(ClearBackGround*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearBackGround)) = clearBackGround;
		}
	}

	public unsafe Color ClearColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearColor);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClearColor)) = color;
		}
	}

	public unsafe UpVector UpVector
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpVector);
			return *(UpVector*)num;
		}
		set
		{
			*(UpVector*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UpVector)) = upVector;
		}
	}

	public unsafe int CameraLODLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraLODLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CameraLODLevel)) = num;
		}
	}

	public unsafe bool UseClipping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseClipping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UseClipping)) = flag;
		}
	}

	public unsafe int ClippingPercentage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClippingPercentage);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClippingPercentage)) = num;
		}
	}

	public unsafe ClipUV ClipUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipUV);
			return *(ClipUV*)num;
		}
		set
		{
			*(ClipUV*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipUV)) = clipUV;
		}
	}

	public unsafe ClipEye ClipEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipEye);
			return *(ClipEye*)num;
		}
		set
		{
			*(ClipEye*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ClipEye)) = clipEye;
		}
	}

	public unsafe bool HDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HDR);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HDR)) = flag;
		}
	}

	public unsafe float FOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FOV)) = num;
		}
	}

	public unsafe MSAALevel MSAALevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSAALevel);
			return *(MSAALevel*)num;
		}
		set
		{
			*(MSAALevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MSAALevel)) = mSAALevel;
		}
	}

	public unsafe bool RenderPostProcessing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderPostProcessing);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderPostProcessing)) = flag;
		}
	}

	public unsafe bool RequiresDepthTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiresDepthTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiresDepthTexture)) = flag;
		}
	}

	public unsafe bool RequiresOpaqueTexture
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiresOpaqueTexture);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RequiresOpaqueTexture)) = flag;
		}
	}

	public unsafe FilterMode FilterMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FilterMode);
			return *(FilterMode*)num;
		}
		set
		{
			*(FilterMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FilterMode)) = filterMode;
		}
	}

	public unsafe bool MipMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MipMapping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MipMapping)) = flag;
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

	public unsafe bool Shadow
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shadow);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Shadow)) = flag;
		}
	}

	public unsafe bool Cull
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cull);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Cull)) = flag;
		}
	}

	public unsafe float CullDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CullDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CullDistance)) = num;
		}
	}

	public unsafe RenderTextureSize RenderTextureSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderTextureSize);
			return *(RenderTextureSize*)num;
		}
		set
		{
			*(RenderTextureSize*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RenderTextureSize)) = renderTextureSize;
		}
	}

	public unsafe double ManualSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualSize);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ManualSize)) = num;
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

	public unsafe Il2CppReferenceArray<GameObject> ReflectiveObjects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectiveObjects);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ReflectiveObjects), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool DrawAlways
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawAlways);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DrawAlways)) = flag;
		}
	}

	public unsafe GameObject FakeCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FakeCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FakeCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool EnableDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDepth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDepth)) = flag;
		}
	}

	public unsafe bool EnableDepthBlur
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDepthBlur);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EnableDepthBlur)) = flag;
		}
	}

	public unsafe Shader DepthBlurShader
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurShader);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurShader), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material DepthBlurMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float DepthBlurCutoff
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurCutoff);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurCutoff)) = num;
		}
	}

	public unsafe int DepthBlurIterations
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurIterations);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurIterations)) = num;
		}
	}

	public unsafe float DepthBlurSurfacePower
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurSurfacePower);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurSurfacePower)) = num;
		}
	}

	public unsafe int DepthBlurHorizontalMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurHorizontalMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurHorizontalMultiplier)) = num;
		}
	}

	public unsafe int DepthBlurVerticalMultiplier
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurVerticalMultiplier);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_DepthBlurVerticalMultiplier)) = num;
		}
	}

	public unsafe Il2CppStringArray CustomShaders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomShaders);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomShaders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RawImage UIImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIImage), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RawImage UIImageDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIImageDepth);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RawImage>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_UIImageDepth), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera _camera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__camera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera _cameraAttached
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraAttached);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraAttached), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraManager _cameraManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<CameraManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cameraManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RendererManager _rendererManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RendererManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rendererManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTextureManager _renderTextureManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTextureManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<RenderTextureManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__renderTextureManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe OptionManager _optionManager
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__optionManager);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<OptionManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__optionManager), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FrameDrawn _frameDrawn
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__frameDrawn);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<FrameDrawn>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__frameDrawn), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41052, XrefRangeEnd = 41053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41073, RefRangeEnd = 41075, XrefRangeStart = 41053, XrefRangeEnd = 41073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeMirror()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeMirror_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe RenderTextureManager.RenderTextureSettings GetRenderTextureSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderTextureSettings_Private_RenderTextureSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(RenderTextureManager.RenderTextureSettings*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41075, XrefRangeEnd = 41082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RendererManager.RendererSettings GetRendererSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRendererSettings_Private_RendererSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new RendererManager.RendererSettings(pointer);
	}

	[CallerCount(0)]
	public unsafe CameraManager.CameraSettings GetCameraSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCameraSettings_Private_CameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CameraManager.CameraSettings(pointer);
	}

	[CallerCount(0)]
	public unsafe OptionManager.OptionSettings GetOptionSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOptionSettings_Private_OptionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(OptionManager.OptionSettings*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41082, XrefRangeEnd = 41114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPreRender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnPreRender_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41114, XrefRangeEnd = 41133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IList<Camera> RenderReflective(Camera sentCamera = null, bool invert = true, bool renderCam = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sentCamera);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &invert;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &renderCam;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_RenderReflective_Public_Virtual_New_IList_1_Camera_Camera_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<IList<Camera>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41133, XrefRangeEnd = 41150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera GetCamera([DefaultParameterValue(null)] Camera sentCamera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(sentCamera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCamera_Private_Camera_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void CommonRender()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_CommonRender_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 41210, RefRangeEnd = 41213, XrefRangeStart = 41150, XrefRangeEnd = 41210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera RenderMe([DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask, [DefaultParameterValue(null)] Camera sentCamera, bool invert = true, bool renderCam = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = (nint)(&stereoTargetEyeMask);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(sentCamera);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &invert;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &renderCam;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderMe_Private_Camera_StereoTargetEyeMask_Camera_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe virtual void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41213, XrefRangeEnd = 41219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MirrorManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MirrorManager()
	{
		Il2CppClassPointerStore<MirrorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "MirrorManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr);
		NativeFieldInfoPtr_IsDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "IsDebug");
		NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "IsEnabled");
		NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "Name");
		NativeFieldInfoPtr_IsMirrorInMirror = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "IsMirrorInMirror");
		NativeFieldInfoPtr_MirrorInMirrorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "MirrorInMirrorId");
		NativeFieldInfoPtr_TurnOffOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "TurnOffOcclusion");
		NativeFieldInfoPtr_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "Platform");
		NativeFieldInfoPtr_ForceMultiPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ForceMultiPass");
		NativeFieldInfoPtr_WorkingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "WorkingType");
		NativeFieldInfoPtr_ClearBackGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClearBackGround");
		NativeFieldInfoPtr_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClearColor");
		NativeFieldInfoPtr_UpVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "UpVector");
		NativeFieldInfoPtr_CameraLODLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "CameraLODLevel");
		NativeFieldInfoPtr_UseClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "UseClipping");
		NativeFieldInfoPtr_ClippingPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClippingPercentage");
		NativeFieldInfoPtr_ClipUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClipUV");
		NativeFieldInfoPtr_ClipEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClipEye");
		NativeFieldInfoPtr_HDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "HDR");
		NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "FOV");
		NativeFieldInfoPtr_MSAALevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "MSAALevel");
		NativeFieldInfoPtr_RenderPostProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "RenderPostProcessing");
		NativeFieldInfoPtr_RequiresDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "RequiresDepthTexture");
		NativeFieldInfoPtr_RequiresOpaqueTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "RequiresOpaqueTexture");
		NativeFieldInfoPtr_FilterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "FilterMode");
		NativeFieldInfoPtr_MipMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "MipMapping");
		NativeFieldInfoPtr_DisablePixelLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DisablePixelLights");
		NativeFieldInfoPtr_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "Shadow");
		NativeFieldInfoPtr_Cull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "Cull");
		NativeFieldInfoPtr_CullDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "CullDistance");
		NativeFieldInfoPtr_RenderTextureSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "RenderTextureSize");
		NativeFieldInfoPtr_ManualSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ManualSize");
		NativeFieldInfoPtr_ClipPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ClipPlaneOffset");
		NativeFieldInfoPtr_ReflectLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ReflectLayers");
		NativeFieldInfoPtr_ReflectiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "ReflectiveObjects");
		NativeFieldInfoPtr_DrawAlways = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DrawAlways");
		NativeFieldInfoPtr_FakeCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "FakeCamera");
		NativeFieldInfoPtr_EnableDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "EnableDepth");
		NativeFieldInfoPtr_EnableDepthBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "EnableDepthBlur");
		NativeFieldInfoPtr_DepthBlurShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurShader");
		NativeFieldInfoPtr_DepthBlurMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurMaterial");
		NativeFieldInfoPtr_DepthBlurCutoff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurCutoff");
		NativeFieldInfoPtr_DepthBlurIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurIterations");
		NativeFieldInfoPtr_DepthBlurSurfacePower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurSurfacePower");
		NativeFieldInfoPtr_DepthBlurHorizontalMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurHorizontalMultiplier");
		NativeFieldInfoPtr_DepthBlurVerticalMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "DepthBlurVerticalMultiplier");
		NativeFieldInfoPtr_CustomShaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "CustomShaders");
		NativeFieldInfoPtr_UIImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "UIImage");
		NativeFieldInfoPtr_UIImageDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "UIImageDepth");
		NativeFieldInfoPtr__camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_camera");
		NativeFieldInfoPtr__cameraAttached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_cameraAttached");
		NativeFieldInfoPtr__cameraManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_cameraManager");
		NativeFieldInfoPtr__rendererManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_rendererManager");
		NativeFieldInfoPtr__renderTextureManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_renderTextureManager");
		NativeFieldInfoPtr__optionManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_optionManager");
		NativeFieldInfoPtr__frameDrawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, "_frameDrawn");
		NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665588);
		NativeMethodInfoPtr_InitializeMirror_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665589);
		NativeMethodInfoPtr_GetRenderTextureSettings_Private_RenderTextureSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665590);
		NativeMethodInfoPtr_GetRendererSettings_Private_RendererSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665591);
		NativeMethodInfoPtr_GetCameraSettings_Private_CameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665592);
		NativeMethodInfoPtr_GetOptionSettings_Private_OptionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665593);
		NativeMethodInfoPtr_OnPreRender_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665594);
		NativeMethodInfoPtr_RenderReflective_Public_Virtual_New_IList_1_Camera_Camera_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665595);
		NativeMethodInfoPtr_GetCamera_Private_Camera_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665596);
		NativeMethodInfoPtr_CommonRender_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665597);
		NativeMethodInfoPtr_RenderMe_Private_Camera_StereoTargetEyeMask_Camera_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665598);
		NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665599);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MirrorManager>.NativeClassPtr, 100665600);
	}

	public MirrorManager(IntPtr pointer)
		: base(pointer)
	{
	}
}
