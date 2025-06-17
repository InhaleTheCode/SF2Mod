using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Evereal.SkyboxCapture;

public class SkyboxCapture : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_captureKey;

	private static readonly IntPtr NativeFieldInfoPtr_saveFolder;

	private static readonly IntPtr NativeFieldInfoPtr_saveFolderFullPath;

	private static readonly IntPtr NativeFieldInfoPtr_projectionType;

	private static readonly IntPtr NativeFieldInfoPtr_cubemapSize;

	private static readonly IntPtr NativeFieldInfoPtr_cubemapLayout;

	private static readonly IntPtr NativeFieldInfoPtr_imageFormat;

	private static readonly IntPtr NativeFieldInfoPtr_jpgQuality;

	private static readonly IntPtr NativeFieldInfoPtr_imageSize;

	private static readonly IntPtr NativeFieldInfoPtr_antiAliasing;

	private static readonly IntPtr NativeFieldInfoPtr_equirectMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_cubemapMaterial;

	private static readonly IntPtr NativeFieldInfoPtr_captureCamera;

	private static readonly IntPtr NativeFieldInfoPtr_includeCameraRotation;

	private static readonly IntPtr NativeFieldInfoPtr_faces;

	private static readonly IntPtr NativeFieldInfoPtr_faceAngles;

	private static readonly IntPtr NativeFieldInfoPtr_imageSavePath;

	private static readonly IntPtr NativeFieldInfoPtr_imageData;

	private static readonly IntPtr NativeFieldInfoPtr_LOG_FORMAT;

	private static readonly IntPtr NativeMethodInfoPtr_get_CubemapSize_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ImageWidth_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_ImageHeight_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_AntiAliasing_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_StartCapture_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteTextureImage_Private_Void_RenderTexture_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteTexture2DImage_Private_Void_Texture2D_0;

	private static readonly IntPtr NativeMethodInfoPtr_WriteImageProcess_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe KeyCode captureKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureKey);
			return *(KeyCode*)num;
		}
		set
		{
			*(KeyCode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureKey)) = keyCode;
		}
	}

	public unsafe string saveFolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFolder);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFolder), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe string saveFolderFullPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFolderFullPath);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_saveFolderFullPath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe ProjectionType projectionType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectionType);
			return *(ProjectionType*)num;
		}
		set
		{
			*(ProjectionType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projectionType)) = projectionType;
		}
	}

	public unsafe CubemapSizeType cubemapSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapSize);
			return *(CubemapSizeType*)num;
		}
		set
		{
			*(CubemapSizeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapSize)) = cubemapSizeType;
		}
	}

	public unsafe CubemapLayoutType cubemapLayout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapLayout);
			return *(CubemapLayoutType*)num;
		}
		set
		{
			*(CubemapLayoutType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapLayout)) = cubemapLayoutType;
		}
	}

	public unsafe ImageFormatType imageFormat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFormat);
			return *(ImageFormatType*)num;
		}
		set
		{
			*(ImageFormatType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageFormat)) = imageFormatType;
		}
	}

	public unsafe int jpgQuality
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jpgQuality);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_jpgQuality)) = num;
		}
	}

	public unsafe ImageSizeType imageSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageSize);
			return *(ImageSizeType*)num;
		}
		set
		{
			*(ImageSizeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageSize)) = imageSizeType;
		}
	}

	public unsafe AntiAliasingType antiAliasing
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiAliasing);
			return *(AntiAliasingType*)num;
		}
		set
		{
			*(AntiAliasingType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_antiAliasing)) = antiAliasingType;
		}
	}

	public unsafe Material equirectMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equirectMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_equirectMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material cubemapMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapMaterial);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cubemapMaterial), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Camera captureCamera
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureCamera);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Camera>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_captureCamera), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool includeCameraRotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeCameraRotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_includeCameraRotation)) = flag;
		}
	}

	public unsafe Il2CppStructArray<CubemapFace> faces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faces);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<CubemapFace>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faces), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppStructArray<Vector3> faceAngles
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceAngles);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceAngles), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string imageSavePath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageSavePath);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageSavePath), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe Il2CppStructArray<byte> imageData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageData);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_imageData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe string LOG_FORMAT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LOG_FORMAT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LOG_FORMAT), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe int CubemapSize
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34169, RefRangeEnd = 34171, XrefRangeStart = 34169, XrefRangeEnd = 34169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CubemapSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int ImageWidth
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 34172, RefRangeEnd = 34176, XrefRangeStart = 34171, XrefRangeEnd = 34172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ImageWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int ImageHeight
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 34177, RefRangeEnd = 34181, XrefRangeStart = 34176, XrefRangeEnd = 34177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ImageHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int AntiAliasing
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AntiAliasing_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34445, RefRangeEnd = 34446, XrefRangeStart = 34181, XrefRangeEnd = 34445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartCapture()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StartCapture_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 34470, RefRangeEnd = 34471, XrefRangeStart = 34446, XrefRangeEnd = 34470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteTextureImage([DefaultParameterValue(null)] RenderTexture outputTexture)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(outputTexture);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTextureImage_Private_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 34503, RefRangeEnd = 34506, XrefRangeStart = 34471, XrefRangeEnd = 34503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteTexture2DImage([DefaultParameterValue(null)] Texture2D texture2D)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture2D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteTexture2DImage_Private_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34506, XrefRangeEnd = 34534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WriteImageProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteImageProcess_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34534, XrefRangeEnd = 34537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34537, XrefRangeEnd = 34554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SkyboxCapture()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static SkyboxCapture()
	{
		Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Evereal.SkyboxCapture", "SkyboxCapture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr);
		NativeFieldInfoPtr_captureKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "captureKey");
		NativeFieldInfoPtr_saveFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "saveFolder");
		NativeFieldInfoPtr_saveFolderFullPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "saveFolderFullPath");
		NativeFieldInfoPtr_projectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "projectionType");
		NativeFieldInfoPtr_cubemapSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "cubemapSize");
		NativeFieldInfoPtr_cubemapLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "cubemapLayout");
		NativeFieldInfoPtr_imageFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "imageFormat");
		NativeFieldInfoPtr_jpgQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "jpgQuality");
		NativeFieldInfoPtr_imageSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "imageSize");
		NativeFieldInfoPtr_antiAliasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "antiAliasing");
		NativeFieldInfoPtr_equirectMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "equirectMaterial");
		NativeFieldInfoPtr_cubemapMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "cubemapMaterial");
		NativeFieldInfoPtr_captureCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "captureCamera");
		NativeFieldInfoPtr_includeCameraRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "includeCameraRotation");
		NativeFieldInfoPtr_faces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "faces");
		NativeFieldInfoPtr_faceAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "faceAngles");
		NativeFieldInfoPtr_imageSavePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "imageSavePath");
		NativeFieldInfoPtr_imageData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "imageData");
		NativeFieldInfoPtr_LOG_FORMAT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, "LOG_FORMAT");
		NativeMethodInfoPtr_get_CubemapSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr_get_ImageWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665308);
		NativeMethodInfoPtr_get_ImageHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665309);
		NativeMethodInfoPtr_get_AntiAliasing_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665310);
		NativeMethodInfoPtr_StartCapture_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665311);
		NativeMethodInfoPtr_WriteTextureImage_Private_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665312);
		NativeMethodInfoPtr_WriteTexture2DImage_Private_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665313);
		NativeMethodInfoPtr_WriteImageProcess_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665314);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665315);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkyboxCapture>.NativeClassPtr, 100665316);
	}

	public SkyboxCapture(IntPtr pointer)
		: base(pointer)
	{
	}
}
