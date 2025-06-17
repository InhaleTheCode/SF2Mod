using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public class CameraManager : ManagerBase
{
	public sealed class CameraSettings : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDebug_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__WorkingType_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClearBackGround_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClearColor_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Platform_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ForceMultiPass_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__HDR_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__FOV_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__UseClipping_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClipUV_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClipEye_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClippingPercentage_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__TurnOffOcclusion_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__MSAALevel_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__RenderPostProcessing_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__RequiresDepthTexture_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__RequiresOpaqueTexture_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Cull_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__CullDistance_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ReflectLayers_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ClipPlaneOffset_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__EnableDepth_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__EnableDepthBlur_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurShader_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurMaterial_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurCutoff_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurIterations_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurSurfacePower_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurHorizontalMultiplier_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DepthBlurVerticalMultiplier_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__FakeCamera_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_WorkingType_Public_get_WorkingType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_WorkingType_Public_set_Void_WorkingType_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClearBackGround_Public_get_ClearBackGround_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClearBackGround_Public_set_Void_ClearBackGround_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClearColor_Public_get_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClearColor_Public_set_Void_Color_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_Platform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Platform_Public_set_Void_Platform_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ForceMultiPass_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ForceMultiPass_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FOV_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_UseClipping_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_UseClipping_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipUV_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClipUV_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipEye_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClipEye_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClippingPercentage_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClippingPercentage_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_TurnOffOcclusion_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_TurnOffOcclusion_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RenderPostProcessing_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_RenderPostProcessing_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiresDepthTexture_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_RequiresDepthTexture_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_RequiresOpaqueTexture_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_RequiresOpaqueTexture_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Cull_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Cull_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_CullDistance_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_CullDistance_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ReflectLayers_Public_get_LayerMask_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ReflectLayers_Public_set_Void_LayerMask_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ClipPlaneOffset_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ClipPlaneOffset_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableDepth_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableDepth_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_EnableDepthBlur_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_EnableDepthBlur_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurShader_Public_get_Shader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurShader_Public_set_Void_Shader_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurMaterial_Public_get_Material_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurMaterial_Public_set_Void_Material_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurCutoff_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurCutoff_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurIterations_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurIterations_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurSurfacePower_Public_get_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurSurfacePower_Public_set_Void_Single_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurHorizontalMultiplier_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurHorizontalMultiplier_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DepthBlurVerticalMultiplier_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DepthBlurVerticalMultiplier_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FakeCamera_Public_get_GameObject_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_FakeCamera_Public_set_Void_GameObject_0;

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

		public unsafe WorkingType _WorkingType_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WorkingType_k__BackingField);
				return *(WorkingType*)num;
			}
			set
			{
				*(WorkingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__WorkingType_k__BackingField)) = workingType;
			}
		}

		public unsafe ClearBackGround _ClearBackGround_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClearBackGround_k__BackingField);
				return *(ClearBackGround*)num;
			}
			set
			{
				*(ClearBackGround*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClearBackGround_k__BackingField)) = clearBackGround;
			}
		}

		public unsafe Color _ClearColor_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClearColor_k__BackingField);
				return *(Color*)num;
			}
			set
			{
				*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClearColor_k__BackingField)) = color;
			}
		}

		public unsafe Platform _Platform_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Platform_k__BackingField);
				return *(Platform*)num;
			}
			set
			{
				*(Platform*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Platform_k__BackingField)) = platform;
			}
		}

		public unsafe bool _ForceMultiPass_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ForceMultiPass_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ForceMultiPass_k__BackingField)) = flag;
			}
		}

		public unsafe bool _HDR_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HDR_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HDR_k__BackingField)) = flag;
			}
		}

		public unsafe float _FOV_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FOV_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FOV_k__BackingField)) = num;
			}
		}

		public unsafe bool _UseClipping_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UseClipping_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__UseClipping_k__BackingField)) = flag;
			}
		}

		public unsafe int _ClipUV_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipUV_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipUV_k__BackingField)) = num;
			}
		}

		public unsafe int _ClipEye_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipEye_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipEye_k__BackingField)) = num;
			}
		}

		public unsafe int _ClippingPercentage_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClippingPercentage_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClippingPercentage_k__BackingField)) = num;
			}
		}

		public unsafe bool _TurnOffOcclusion_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TurnOffOcclusion_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TurnOffOcclusion_k__BackingField)) = flag;
			}
		}

		public unsafe MSAALevel _MSAALevel_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MSAALevel_k__BackingField);
				return *(MSAALevel*)num;
			}
			set
			{
				*(MSAALevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MSAALevel_k__BackingField)) = mSAALevel;
			}
		}

		public unsafe bool _RenderPostProcessing_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RenderPostProcessing_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RenderPostProcessing_k__BackingField)) = flag;
			}
		}

		public unsafe bool _RequiresDepthTexture_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequiresDepthTexture_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequiresDepthTexture_k__BackingField)) = flag;
			}
		}

		public unsafe bool _RequiresOpaqueTexture_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequiresOpaqueTexture_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RequiresOpaqueTexture_k__BackingField)) = flag;
			}
		}

		public unsafe bool _Cull_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cull_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Cull_k__BackingField)) = flag;
			}
		}

		public unsafe float _CullDistance_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CullDistance_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CullDistance_k__BackingField)) = num;
			}
		}

		public unsafe LayerMask _ReflectLayers_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReflectLayers_k__BackingField);
				return *(LayerMask*)num;
			}
			set
			{
				*(LayerMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReflectLayers_k__BackingField)) = layerMask;
			}
		}

		public unsafe float _ClipPlaneOffset_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipPlaneOffset_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ClipPlaneOffset_k__BackingField)) = num;
			}
		}

		public unsafe bool _EnableDepth_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableDepth_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableDepth_k__BackingField)) = flag;
			}
		}

		public unsafe bool _EnableDepthBlur_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableDepthBlur_k__BackingField);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__EnableDepthBlur_k__BackingField)) = flag;
			}
		}

		public unsafe Shader _DepthBlurShader_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurShader_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurShader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Material _DepthBlurMaterial_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurMaterial_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe float _DepthBlurCutoff_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurCutoff_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurCutoff_k__BackingField)) = num;
			}
		}

		public unsafe int _DepthBlurIterations_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurIterations_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurIterations_k__BackingField)) = num;
			}
		}

		public unsafe float _DepthBlurSurfacePower_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurSurfacePower_k__BackingField);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurSurfacePower_k__BackingField)) = num;
			}
		}

		public unsafe int _DepthBlurHorizontalMultiplier_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurHorizontalMultiplier_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurHorizontalMultiplier_k__BackingField)) = num;
			}
		}

		public unsafe int _DepthBlurVerticalMultiplier_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurVerticalMultiplier_k__BackingField);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DepthBlurVerticalMultiplier_k__BackingField)) = num;
			}
		}

		public unsafe GameObject _FakeCamera_k__BackingField
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FakeCamera_k__BackingField);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FakeCamera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
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

		public unsafe WorkingType WorkingType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_WorkingType_Public_get_WorkingType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(WorkingType*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_WorkingType_Public_set_Void_WorkingType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe ClearBackGround ClearBackGround
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClearBackGround_Public_get_ClearBackGround_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(ClearBackGround*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClearBackGround_Public_set_Void_ClearBackGround_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe Color ClearColor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClearColor_Public_get_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(Color*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClearColor_Public_set_Void_Color_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe Platform Platform
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 41732, RefRangeEnd = 41740, XrefRangeStart = 41732, XrefRangeEnd = 41732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Platform_Public_get_Platform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(Platform*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Platform_Public_set_Void_Platform_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool ForceMultiPass
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ForceMultiPass_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ForceMultiPass_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool HDR
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe float FOV
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FOV_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(float*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool UseClipping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UseClipping_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_UseClipping_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int ClipUV
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClipUV_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClipUV_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int ClipEye
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClipEye_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClipEye_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int ClippingPercentage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClippingPercentage_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClippingPercentage_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool TurnOffOcclusion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TurnOffOcclusion_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_TurnOffOcclusion_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe MSAALevel MSAALevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(MSAALevel*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool RenderPostProcessing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RenderPostProcessing_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RenderPostProcessing_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool RequiresDepthTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiresDepthTexture_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RequiresDepthTexture_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool RequiresOpaqueTexture
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequiresOpaqueTexture_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RequiresOpaqueTexture_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool Cull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Cull_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Cull_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe float CullDistance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CullDistance_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(float*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CullDistance_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe LayerMask ReflectLayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReflectLayers_Public_get_LayerMask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(LayerMask*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ReflectLayers_Public_set_Void_LayerMask_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe float ClipPlaneOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ClipPlaneOffset_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(float*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ClipPlaneOffset_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool EnableDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableDepth_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableDepth_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool EnableDepthBlur
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EnableDepthBlur_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EnableDepthBlur_Public_set_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe Shader DepthBlurShader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurShader_Public_get_Shader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Shader>(intPtr) : null;
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurShader_Public_set_Void_Shader_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe Material DepthBlurMaterial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurMaterial_Public_get_Material_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41740, RefRangeEnd = 41741, XrefRangeStart = 41740, XrefRangeEnd = 41740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurMaterial_Public_set_Void_Material_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe float DepthBlurCutoff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurCutoff_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(float*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurCutoff_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int DepthBlurIterations
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurIterations_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurIterations_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe float DepthBlurSurfacePower
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurSurfacePower_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(float*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurSurfacePower_Public_set_Void_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int DepthBlurHorizontalMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurHorizontalMultiplier_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurHorizontalMultiplier_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int DepthBlurVerticalMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DepthBlurVerticalMultiplier_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DepthBlurVerticalMultiplier_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe GameObject FakeCamera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FakeCamera_Public_get_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 41741, RefRangeEnd = 41743, XrefRangeStart = 41741, XrefRangeEnd = 41741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			[param: DefaultParameterValue(null)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FakeCamera_Public_set_Void_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		static CameraSettings()
		{
			Il2CppClassPointerStore<CameraSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "CameraSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr);
			NativeFieldInfoPtr__IsDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<IsDebug>k__BackingField");
			NativeFieldInfoPtr__WorkingType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<WorkingType>k__BackingField");
			NativeFieldInfoPtr__ClearBackGround_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClearBackGround>k__BackingField");
			NativeFieldInfoPtr__ClearColor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClearColor>k__BackingField");
			NativeFieldInfoPtr__Platform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<Platform>k__BackingField");
			NativeFieldInfoPtr__ForceMultiPass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ForceMultiPass>k__BackingField");
			NativeFieldInfoPtr__HDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<HDR>k__BackingField");
			NativeFieldInfoPtr__FOV_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<FOV>k__BackingField");
			NativeFieldInfoPtr__UseClipping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<UseClipping>k__BackingField");
			NativeFieldInfoPtr__ClipUV_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClipUV>k__BackingField");
			NativeFieldInfoPtr__ClipEye_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClipEye>k__BackingField");
			NativeFieldInfoPtr__ClippingPercentage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClippingPercentage>k__BackingField");
			NativeFieldInfoPtr__TurnOffOcclusion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<TurnOffOcclusion>k__BackingField");
			NativeFieldInfoPtr__MSAALevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<MSAALevel>k__BackingField");
			NativeFieldInfoPtr__RenderPostProcessing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<RenderPostProcessing>k__BackingField");
			NativeFieldInfoPtr__RequiresDepthTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<RequiresDepthTexture>k__BackingField");
			NativeFieldInfoPtr__RequiresOpaqueTexture_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<RequiresOpaqueTexture>k__BackingField");
			NativeFieldInfoPtr__Cull_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<Cull>k__BackingField");
			NativeFieldInfoPtr__CullDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<CullDistance>k__BackingField");
			NativeFieldInfoPtr__ReflectLayers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ReflectLayers>k__BackingField");
			NativeFieldInfoPtr__ClipPlaneOffset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<ClipPlaneOffset>k__BackingField");
			NativeFieldInfoPtr__EnableDepth_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<EnableDepth>k__BackingField");
			NativeFieldInfoPtr__EnableDepthBlur_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<EnableDepthBlur>k__BackingField");
			NativeFieldInfoPtr__DepthBlurShader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurShader>k__BackingField");
			NativeFieldInfoPtr__DepthBlurMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurMaterial>k__BackingField");
			NativeFieldInfoPtr__DepthBlurCutoff_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurCutoff>k__BackingField");
			NativeFieldInfoPtr__DepthBlurIterations_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurIterations>k__BackingField");
			NativeFieldInfoPtr__DepthBlurSurfacePower_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurSurfacePower>k__BackingField");
			NativeFieldInfoPtr__DepthBlurHorizontalMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurHorizontalMultiplier>k__BackingField");
			NativeFieldInfoPtr__DepthBlurVerticalMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<DepthBlurVerticalMultiplier>k__BackingField");
			NativeFieldInfoPtr__FakeCamera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, "<FakeCamera>k__BackingField");
			NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665689);
			NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665690);
			NativeMethodInfoPtr_get_WorkingType_Public_get_WorkingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665691);
			NativeMethodInfoPtr_set_WorkingType_Public_set_Void_WorkingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665692);
			NativeMethodInfoPtr_get_ClearBackGround_Public_get_ClearBackGround_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665693);
			NativeMethodInfoPtr_set_ClearBackGround_Public_set_Void_ClearBackGround_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665694);
			NativeMethodInfoPtr_get_ClearColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665695);
			NativeMethodInfoPtr_set_ClearColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665696);
			NativeMethodInfoPtr_get_Platform_Public_get_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665697);
			NativeMethodInfoPtr_set_Platform_Public_set_Void_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665698);
			NativeMethodInfoPtr_get_ForceMultiPass_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665699);
			NativeMethodInfoPtr_set_ForceMultiPass_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665700);
			NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665701);
			NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665702);
			NativeMethodInfoPtr_get_FOV_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665703);
			NativeMethodInfoPtr_set_FOV_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665704);
			NativeMethodInfoPtr_get_UseClipping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665705);
			NativeMethodInfoPtr_set_UseClipping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665706);
			NativeMethodInfoPtr_get_ClipUV_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665707);
			NativeMethodInfoPtr_set_ClipUV_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665708);
			NativeMethodInfoPtr_get_ClipEye_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665709);
			NativeMethodInfoPtr_set_ClipEye_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665710);
			NativeMethodInfoPtr_get_ClippingPercentage_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665711);
			NativeMethodInfoPtr_set_ClippingPercentage_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665712);
			NativeMethodInfoPtr_get_TurnOffOcclusion_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665713);
			NativeMethodInfoPtr_set_TurnOffOcclusion_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665714);
			NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665715);
			NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665716);
			NativeMethodInfoPtr_get_RenderPostProcessing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665717);
			NativeMethodInfoPtr_set_RenderPostProcessing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665718);
			NativeMethodInfoPtr_get_RequiresDepthTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665719);
			NativeMethodInfoPtr_set_RequiresDepthTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665720);
			NativeMethodInfoPtr_get_RequiresOpaqueTexture_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665721);
			NativeMethodInfoPtr_set_RequiresOpaqueTexture_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665722);
			NativeMethodInfoPtr_get_Cull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665723);
			NativeMethodInfoPtr_set_Cull_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665724);
			NativeMethodInfoPtr_get_CullDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665725);
			NativeMethodInfoPtr_set_CullDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665726);
			NativeMethodInfoPtr_get_ReflectLayers_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665727);
			NativeMethodInfoPtr_set_ReflectLayers_Public_set_Void_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665728);
			NativeMethodInfoPtr_get_ClipPlaneOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665729);
			NativeMethodInfoPtr_set_ClipPlaneOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665730);
			NativeMethodInfoPtr_get_EnableDepth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665731);
			NativeMethodInfoPtr_set_EnableDepth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665732);
			NativeMethodInfoPtr_get_EnableDepthBlur_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665733);
			NativeMethodInfoPtr_set_EnableDepthBlur_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665734);
			NativeMethodInfoPtr_get_DepthBlurShader_Public_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665735);
			NativeMethodInfoPtr_set_DepthBlurShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665736);
			NativeMethodInfoPtr_get_DepthBlurMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665737);
			NativeMethodInfoPtr_set_DepthBlurMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665738);
			NativeMethodInfoPtr_get_DepthBlurCutoff_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665739);
			NativeMethodInfoPtr_set_DepthBlurCutoff_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665740);
			NativeMethodInfoPtr_get_DepthBlurIterations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665741);
			NativeMethodInfoPtr_set_DepthBlurIterations_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665742);
			NativeMethodInfoPtr_get_DepthBlurSurfacePower_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665743);
			NativeMethodInfoPtr_set_DepthBlurSurfacePower_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665744);
			NativeMethodInfoPtr_get_DepthBlurHorizontalMultiplier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665745);
			NativeMethodInfoPtr_set_DepthBlurHorizontalMultiplier_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665746);
			NativeMethodInfoPtr_get_DepthBlurVerticalMultiplier_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665747);
			NativeMethodInfoPtr_set_DepthBlurVerticalMultiplier_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665748);
			NativeMethodInfoPtr_get_FakeCamera_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665749);
			NativeMethodInfoPtr_set_FakeCamera_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, 100665750);
		}

		public CameraSettings(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public CameraSettings()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CameraNameStart;

	private static readonly System.IntPtr NativeFieldInfoPtr__mainCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr__mirrorCameraContainer;

	private static readonly System.IntPtr NativeFieldInfoPtr__mirrorCamera;

	private static readonly System.IntPtr NativeFieldInfoPtr__settings;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewPort;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewEyeMask;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewTransformPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewTransformRotation;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewTransformForward;

	private static readonly System.IntPtr NativeFieldInfoPtr__viewFOV;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CameraSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettings_Public_CameraSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetReferenceCamera_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMirrorCamera_Public_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReferenceCamera_Public_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateMirrorCamera_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCameraModes_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetViewport_Public_Void_RendererManager_StereoTargetEyeMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetViewport_Public_Void_StereoTargetEyeMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScissorRect_Public_Void_Rect_StereoTargetEyeMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFake_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFOV_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetFOV_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateReflectionMatrix_Private_Void_byref_Matrix4x4_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Matrix4x4_Vector3_Vector3_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeProjectionMatrixOblique_Private_Void_byref_Matrix4x4_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_sgn_Private_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Draw_Public_Void_RendererManager_RenderTextureManager_StereoTargetEyeMask_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

	public unsafe static string CameraNameStart
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CameraNameStart, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CameraNameStart, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Camera _mainCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mainCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject _mirrorCameraContainer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mirrorCameraContainer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mirrorCameraContainer), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera _mirrorCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mirrorCamera);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__mirrorCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe CameraSettings _settings
	{
		get
		{
			nint data = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings);
			return new CameraSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, data));
		}
		set
		{
			// IL cpblk instruction
			System.Runtime.CompilerServices.Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(obj)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CameraSettings>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Rect _viewPort
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewPort);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewPort)) = rect;
		}
	}

	public unsafe Quaternion _viewRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewRotation)) = quaternion;
		}
	}

	public unsafe StereoTargetEyeMask _viewEyeMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewEyeMask);
			return *(StereoTargetEyeMask*)num;
		}
		set
		{
			*(StereoTargetEyeMask*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewEyeMask)) = stereoTargetEyeMask;
		}
	}

	public unsafe Vector3 _viewTransformPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformPosition)) = vector;
		}
	}

	public unsafe Quaternion _viewTransformRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformRotation);
			return *(Quaternion*)num;
		}
		set
		{
			*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformRotation)) = quaternion;
		}
	}

	public unsafe Vector3 _viewTransformForward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformForward);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewTransformForward)) = vector;
		}
	}

	public unsafe float _viewFOV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewFOV);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__viewFOV)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe CameraManager([DefaultParameterValue(null)] CameraSettings settings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(settings));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe CameraSettings GetSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSettings_Public_CameraSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return new CameraSettings(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41743, XrefRangeEnd = 41750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetReferenceCamera([DefaultParameterValue(null)] Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetReferenceCamera_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Camera GetMirrorCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMirrorCamera_Public_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(0)]
	public unsafe Camera GetReferenceCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReferenceCamera_Public_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41814, RefRangeEnd = 41815, XrefRangeStart = 41750, XrefRangeEnd = 41814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateMirrorCamera()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateMirrorCamera_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41868, RefRangeEnd = 41869, XrefRangeStart = 41815, XrefRangeEnd = 41868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCameraModes()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateCameraModes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41901, RefRangeEnd = 41902, XrefRangeStart = 41869, XrefRangeEnd = 41901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetViewport([DefaultParameterValue(null)] RendererManager rendererManager, [DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererManager);
		*(StereoTargetEyeMask**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoTargetEyeMask;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetViewport_Public_Void_RendererManager_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41902, XrefRangeEnd = 41915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetViewport([DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stereoTargetEyeMask);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetViewport_Public_Void_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41940, RefRangeEnd = 41941, XrefRangeStart = 41915, XrefRangeEnd = 41940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetScissorRect([DefaultParameterValue(null)] Rect r, [DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&r);
		*(StereoTargetEyeMask**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoTargetEyeMask;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScissorRect_Public_Void_Rect_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41991, RefRangeEnd = 41992, XrefRangeStart = 41941, XrefRangeEnd = 41991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41992, XrefRangeEnd = 42020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetFake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42020, XrefRangeEnd = 42023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFOV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFOV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42023, XrefRangeEnd = 42024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetFOV()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetFOV_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
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

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42028, RefRangeEnd = 42029, XrefRangeStart = 42024, XrefRangeEnd = 42028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector4 CameraSpacePlane([DefaultParameterValue(null)] Matrix4x4 worldToCameraMatrix, [DefaultParameterValue(null)] Vector3 pos, [DefaultParameterValue(null)] Vector3 normal, [DefaultParameterValue(null)] float sideSign)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&worldToCameraMatrix);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &pos;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &normal;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sideSign;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Matrix4x4_Vector3_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42029, XrefRangeEnd = 42032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MakeProjectionMatrixOblique([DefaultParameterValue(null)] ref Matrix4x4 matrix, [DefaultParameterValue(null)] Vector4 clipPlane)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref matrix);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipPlane;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeProjectionMatrixOblique_Private_Void_byref_Matrix4x4_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float sgn([DefaultParameterValue(null)] float a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&a);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_sgn_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42224, RefRangeEnd = 42225, XrefRangeStart = 42032, XrefRangeEnd = 42224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Draw([DefaultParameterValue(null)] RendererManager rendererManager, [DefaultParameterValue(null)] RenderTextureManager renderTextureManager, [DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask, [DefaultParameterValue(null)] bool invert, [DefaultParameterValue(null)] bool renderCam)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererManager);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(renderTextureManager);
		*(StereoTargetEyeMask**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stereoTargetEyeMask;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &invert;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderCam;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Draw_Public_Void_RendererManager_RenderTextureManager_StereoTargetEyeMask_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
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

	static CameraManager()
	{
		Il2CppClassPointerStore<CameraManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "CameraManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraManager>.NativeClassPtr);
		NativeFieldInfoPtr_CameraNameStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "CameraNameStart");
		NativeFieldInfoPtr__mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_mainCamera");
		NativeFieldInfoPtr__mirrorCameraContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_mirrorCameraContainer");
		NativeFieldInfoPtr__mirrorCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_mirrorCamera");
		NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_settings");
		NativeFieldInfoPtr__viewPort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewPort");
		NativeFieldInfoPtr__viewRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewRotation");
		NativeFieldInfoPtr__viewEyeMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewEyeMask");
		NativeFieldInfoPtr__viewTransformPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewTransformPosition");
		NativeFieldInfoPtr__viewTransformRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewTransformRotation");
		NativeFieldInfoPtr__viewTransformForward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewTransformForward");
		NativeFieldInfoPtr__viewFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, "_viewFOV");
		NativeMethodInfoPtr__ctor_Public_Void_CameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665669);
		NativeMethodInfoPtr_GetSettings_Public_CameraSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665670);
		NativeMethodInfoPtr_SetReferenceCamera_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665671);
		NativeMethodInfoPtr_GetMirrorCamera_Public_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665672);
		NativeMethodInfoPtr_GetReferenceCamera_Public_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665673);
		NativeMethodInfoPtr_CreateMirrorCamera_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665674);
		NativeMethodInfoPtr_UpdateCameraModes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665675);
		NativeMethodInfoPtr_SetViewport_Public_Void_RendererManager_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665676);
		NativeMethodInfoPtr_ResetViewport_Public_Void_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665677);
		NativeMethodInfoPtr_SetScissorRect_Public_Void_Rect_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665678);
		NativeMethodInfoPtr_SetFake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665679);
		NativeMethodInfoPtr_ResetFake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665680);
		NativeMethodInfoPtr_SetFOV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665681);
		NativeMethodInfoPtr_ResetFOV_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665682);
		NativeMethodInfoPtr_CalculateReflectionMatrix_Private_Void_byref_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665683);
		NativeMethodInfoPtr_CameraSpacePlane_Private_Vector4_Matrix4x4_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665684);
		NativeMethodInfoPtr_MakeProjectionMatrixOblique_Private_Void_byref_Matrix4x4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665685);
		NativeMethodInfoPtr_sgn_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665686);
		NativeMethodInfoPtr_Draw_Public_Void_RendererManager_RenderTextureManager_StereoTargetEyeMask_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665687);
		NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraManager>.NativeClassPtr, 100665688);
	}

	public CameraManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
