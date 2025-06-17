using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace AkilliMum.Standard.Mirror;

public class RenderTextureManager : ManagerBase
{
	[StructLayout(LayoutKind.Explicit)]
	public struct RenderTextureSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDebug_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__HDR_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Size_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__ManualSize_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__MSAALevel_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__FilterMode_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__MipMapping_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_RenderTextureSize_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Size_Public_set_Void_RenderTextureSize_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_ManualSize_Public_get_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_ManualSize_Public_set_Void_Double_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_FilterMode_Public_get_FilterMode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_FilterMode_Public_set_Void_FilterMode_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_MipMapping_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_MipMapping_Public_set_Void_Boolean_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _IsDebug_k__BackingField;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _HDR_k__BackingField;

		[FieldOffset(4)]
		public RenderTextureSize _Size_k__BackingField;

		[FieldOffset(8)]
		public double _ManualSize_k__BackingField;

		[FieldOffset(16)]
		public MSAALevel _MSAALevel_k__BackingField;

		[FieldOffset(20)]
		public FilterMode _FilterMode_k__BackingField;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _MipMapping_k__BackingField;

		public unsafe bool IsDebug
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool HDR
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe RenderTextureSize Size
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Size_Public_get_RenderTextureSize_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(RenderTextureSize*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Size_Public_set_Void_RenderTextureSize_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe double ManualSize
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ManualSize_Public_get_Double_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(double*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_ManualSize_Public_set_Void_Double_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe MSAALevel MSAALevel
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 3884, RefRangeEnd = 3888, XrefRangeStart = 3884, XrefRangeEnd = 3888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(MSAALevel*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe FilterMode FilterMode
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FilterMode_Public_get_FilterMode_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(FilterMode*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FilterMode_Public_set_Void_FilterMode_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool MipMapping
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MipMapping_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MipMapping_Public_set_Void_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		static RenderTextureSettings()
		{
			Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "RenderTextureSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr);
			NativeFieldInfoPtr__IsDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<IsDebug>k__BackingField");
			NativeFieldInfoPtr__HDR_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<HDR>k__BackingField");
			NativeFieldInfoPtr__Size_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<Size>k__BackingField");
			NativeFieldInfoPtr__ManualSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<ManualSize>k__BackingField");
			NativeFieldInfoPtr__MSAALevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<MSAALevel>k__BackingField");
			NativeFieldInfoPtr__FilterMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<FilterMode>k__BackingField");
			NativeFieldInfoPtr__MipMapping_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, "<MipMapping>k__BackingField");
			NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665655);
			NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665656);
			NativeMethodInfoPtr_get_HDR_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665657);
			NativeMethodInfoPtr_set_HDR_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665658);
			NativeMethodInfoPtr_get_Size_Public_get_RenderTextureSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665659);
			NativeMethodInfoPtr_set_Size_Public_set_Void_RenderTextureSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665660);
			NativeMethodInfoPtr_get_ManualSize_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665661);
			NativeMethodInfoPtr_set_ManualSize_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665662);
			NativeMethodInfoPtr_get_MSAALevel_Public_get_MSAALevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665663);
			NativeMethodInfoPtr_set_MSAALevel_Public_set_Void_MSAALevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665664);
			NativeMethodInfoPtr_get_FilterMode_Public_get_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665665);
			NativeMethodInfoPtr_set_FilterMode_Public_set_Void_FilterMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665666);
			NativeMethodInfoPtr_get_MipMapping_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665667);
			NativeMethodInfoPtr_set_MipMapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, 100665668);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTextureSettings>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__leftOrCenterRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr__leftOrCenterRT2;

	private static readonly System.IntPtr NativeFieldInfoPtr__leftOrCenterRT3;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightRT2;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightRT3;

	private static readonly System.IntPtr NativeFieldInfoPtr__leftOrCenterDepthRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightDepthRT1;

	private static readonly System.IntPtr NativeFieldInfoPtr__settings;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftOrCenterRT1_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeftOrCenterRT1_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftOrCenterRT2_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeftOrCenterRT2_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftOrCenterRT3_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeftOrCenterRT3_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightRT1_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RightRT1_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightRT2_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RightRT2_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightRT3_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RightRT3_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftOrCenterDepthRT1_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_LeftOrCenterDepthRT1_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RightDepthRT1_Public_get_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RightDepthRT1_Public_set_Void_RenderTexture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTextureSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSettings_Public_Void_RenderTextureSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSettings_Public_RenderTextureSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GenerateMipMaps_Public_Void_StereoTargetEyeMask_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateRenderTextures_Public_Void_CameraManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_RenderTexture_String_Int32_Int32_Int32_RenderTextureFormat_RenderTextureFormat_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDepth_Private_RenderTexture_String_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureSizes_Private_Il2CppStructArray_1_Int32_CameraManager_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

	public unsafe RenderTexture _leftOrCenterRT1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _leftOrCenterRT2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _leftOrCenterRT3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterRT3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _rightRT1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _rightRT2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT2);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT2), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _rightRT3
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT3);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightRT3), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _leftOrCenterDepthRT1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterDepthRT1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__leftOrCenterDepthRT1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTexture _rightDepthRT1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightDepthRT1);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__rightDepthRT1), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe RenderTextureSettings _settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings);
			return *(RenderTextureSettings*)num;
		}
		set
		{
			*(RenderTextureSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings)) = renderTextureSettings;
		}
	}

	public unsafe RenderTexture LeftOrCenterRT1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeftOrCenterRT1_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 41524, RefRangeEnd = 41560, XrefRangeStart = 41524, XrefRangeEnd = 41524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeftOrCenterRT1_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture LeftOrCenterRT2
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 34712, RefRangeEnd = 34717, XrefRangeStart = 34712, XrefRangeEnd = 34717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeftOrCenterRT2_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 34717, RefRangeEnd = 34749, XrefRangeStart = 34717, XrefRangeEnd = 34749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeftOrCenterRT2_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture LeftOrCenterRT3
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 10026, RefRangeEnd = 10032, XrefRangeStart = 10026, XrefRangeEnd = 10032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeftOrCenterRT3_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 32970, RefRangeEnd = 33003, XrefRangeStart = 32970, XrefRangeEnd = 33003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeftOrCenterRT3_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture RightRT1
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41560, RefRangeEnd = 41561, XrefRangeStart = 41560, XrefRangeEnd = 41560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightRT1_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41561, RefRangeEnd = 41569, XrefRangeStart = 41561, XrefRangeEnd = 41561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RightRT1_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture RightRT2
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightRT2_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41569, RefRangeEnd = 41574, XrefRangeStart = 41569, XrefRangeEnd = 41569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RightRT2_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture RightRT3
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightRT3_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 41574, RefRangeEnd = 41582, XrefRangeStart = 41574, XrefRangeEnd = 41574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RightRT3_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture LeftOrCenterDepthRT1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LeftOrCenterDepthRT1_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 29631, RefRangeEnd = 29651, XrefRangeStart = 29631, XrefRangeEnd = 29651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LeftOrCenterDepthRT1_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe RenderTexture RightDepthRT1
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RightDepthRT1_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
		}
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 41582, RefRangeEnd = 41589, XrefRangeStart = 41582, XrefRangeEnd = 41582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RightDepthRT1_Public_set_Void_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(0)]
	public unsafe RenderTextureManager([DefaultParameterValue(null)] RenderTextureSettings settings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderTextureSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSettings([DefaultParameterValue(null)] RenderTextureSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSettings_Public_Void_RenderTextureSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe RenderTextureSettings GetSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSettings_Public_RenderTextureSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(RenderTextureSettings*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41589, XrefRangeEnd = 41599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GenerateMipMaps([DefaultParameterValue(null)] StereoTargetEyeMask stereoTargetEyeMask)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&stereoTargetEyeMask);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GenerateMipMaps_Public_Void_StereoTargetEyeMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41642, RefRangeEnd = 41643, XrefRangeStart = 41599, XrefRangeEnd = 41642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateRenderTextures([DefaultParameterValue(null)] CameraManager cameraManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateRenderTextures_Public_Void_CameraManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 41662, RefRangeEnd = 41668, XrefRangeStart = 41643, XrefRangeEnd = 41662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture Create([DefaultParameterValue(null)] string name, [DefaultParameterValue(null)] int width, [DefaultParameterValue(null)] int height, [DefaultParameterValue(null)] int depth, [DefaultParameterValue(null)] RenderTextureFormat textureFormat, [DefaultParameterValue(null)] RenderTextureFormat textureFormatHDR)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(RenderTextureFormat**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormatHDR;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Private_RenderTexture_String_Int32_Int32_Int32_RenderTextureFormat_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 41677, RefRangeEnd = 41679, XrefRangeStart = 41668, XrefRangeEnd = 41677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTexture CreateDepth([DefaultParameterValue(null)] string name, [DefaultParameterValue(null)] int width, [DefaultParameterValue(null)] int height, [DefaultParameterValue(null)] int depth)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &width;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &height;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depth;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDepth_Private_RenderTexture_String_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 41723, RefRangeEnd = 41724, XrefRangeStart = 41679, XrefRangeEnd = 41723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetTextureSizes([DefaultParameterValue(null)] CameraManager cameraManager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cameraManager);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTextureSizes_Private_Il2CppStructArray_1_Int32_CameraManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41724, XrefRangeEnd = 41732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static RenderTextureManager()
	{
		Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "RenderTextureManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr);
		NativeFieldInfoPtr__leftOrCenterRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_leftOrCenterRT1");
		NativeFieldInfoPtr__leftOrCenterRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_leftOrCenterRT2");
		NativeFieldInfoPtr__leftOrCenterRT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_leftOrCenterRT3");
		NativeFieldInfoPtr__rightRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_rightRT1");
		NativeFieldInfoPtr__rightRT2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_rightRT2");
		NativeFieldInfoPtr__rightRT3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_rightRT3");
		NativeFieldInfoPtr__leftOrCenterDepthRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_leftOrCenterDepthRT1");
		NativeFieldInfoPtr__rightDepthRT1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_rightDepthRT1");
		NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, "_settings");
		NativeMethodInfoPtr_get_LeftOrCenterRT1_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665630);
		NativeMethodInfoPtr_set_LeftOrCenterRT1_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665631);
		NativeMethodInfoPtr_get_LeftOrCenterRT2_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665632);
		NativeMethodInfoPtr_set_LeftOrCenterRT2_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665633);
		NativeMethodInfoPtr_get_LeftOrCenterRT3_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665634);
		NativeMethodInfoPtr_set_LeftOrCenterRT3_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665635);
		NativeMethodInfoPtr_get_RightRT1_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665636);
		NativeMethodInfoPtr_set_RightRT1_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665637);
		NativeMethodInfoPtr_get_RightRT2_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665638);
		NativeMethodInfoPtr_set_RightRT2_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665639);
		NativeMethodInfoPtr_get_RightRT3_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665640);
		NativeMethodInfoPtr_set_RightRT3_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665641);
		NativeMethodInfoPtr_get_LeftOrCenterDepthRT1_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665642);
		NativeMethodInfoPtr_set_LeftOrCenterDepthRT1_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665643);
		NativeMethodInfoPtr_get_RightDepthRT1_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665644);
		NativeMethodInfoPtr_set_RightDepthRT1_Public_set_Void_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665645);
		NativeMethodInfoPtr__ctor_Public_Void_RenderTextureSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665646);
		NativeMethodInfoPtr_SetSettings_Public_Void_RenderTextureSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665647);
		NativeMethodInfoPtr_GetSettings_Public_RenderTextureSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665648);
		NativeMethodInfoPtr_GenerateMipMaps_Public_Void_StereoTargetEyeMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665649);
		NativeMethodInfoPtr_CreateRenderTextures_Public_Void_CameraManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665650);
		NativeMethodInfoPtr_Create_Private_RenderTexture_String_Int32_Int32_Int32_RenderTextureFormat_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665651);
		NativeMethodInfoPtr_CreateDepth_Private_RenderTexture_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665652);
		NativeMethodInfoPtr_GetTextureSizes_Private_Il2CppStructArray_1_Int32_CameraManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665653);
		NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTextureManager>.NativeClassPtr, 100665654);
	}

	public RenderTextureManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
