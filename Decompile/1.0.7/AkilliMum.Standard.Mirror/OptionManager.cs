using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace AkilliMum.Standard.Mirror;

public class OptionManager : ManagerBase
{
	[StructLayout(LayoutKind.Explicit)]
	public struct OptionSettings
	{
		private static readonly System.IntPtr NativeFieldInfoPtr__IsDebug_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__LODLevel_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__DisablePixelLights_k__BackingField;

		private static readonly System.IntPtr NativeFieldInfoPtr__Shadow_k__BackingField;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_LODLevel_Public_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_LODLevel_Public_set_Void_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_DisablePixelLights_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_DisablePixelLights_Public_set_Void_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Shadow_Public_get_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_set_Shadow_Public_set_Void_Boolean_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _IsDebug_k__BackingField;

		[FieldOffset(4)]
		public int _LODLevel_k__BackingField;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _DisablePixelLights_k__BackingField;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.U1)]
		public bool _Shadow_k__BackingField;

		public unsafe bool IsDebug
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
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
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe int LODLevel
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LODLevel_Public_get_Int32_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(int*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_LODLevel_Public_set_Void_Int32_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool DisablePixelLights
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DisablePixelLights_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_DisablePixelLights_Public_set_Void_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		public unsafe bool Shadow
		{
			[CallerCount(0)]
			get
			{
				System.IntPtr* param = null;
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Shadow_Public_get_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)param, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
				return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			[param: DefaultParameterValue(null)]
			set
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&value);
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Shadow_Public_set_Void_Boolean_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
				Il2CppException.RaiseExceptionIfNecessary(exc);
			}
		}

		static OptionSettings()
		{
			Il2CppClassPointerStore<OptionSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "OptionSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr);
			NativeFieldInfoPtr__IsDebug_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, "<IsDebug>k__BackingField");
			NativeFieldInfoPtr__LODLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, "<LODLevel>k__BackingField");
			NativeFieldInfoPtr__DisablePixelLights_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, "<DisablePixelLights>k__BackingField");
			NativeFieldInfoPtr__Shadow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, "<Shadow>k__BackingField");
			NativeMethodInfoPtr_get_IsDebug_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665756);
			NativeMethodInfoPtr_set_IsDebug_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665757);
			NativeMethodInfoPtr_get_LODLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665758);
			NativeMethodInfoPtr_set_LODLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665759);
			NativeMethodInfoPtr_get_DisablePixelLights_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665760);
			NativeMethodInfoPtr_set_DisablePixelLights_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665761);
			NativeMethodInfoPtr_get_Shadow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665762);
			NativeMethodInfoPtr_set_Shadow_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, 100665763);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OptionSettings>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr__previousFog;

	private static readonly System.IntPtr NativeFieldInfoPtr__previousLODLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr__previousMaxAdditionalLightsCount;

	private static readonly System.IntPtr NativeFieldInfoPtr__previousShadowDistance;

	private static readonly System.IntPtr NativeFieldInfoPtr__settings;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_OptionSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetSettings_Private_Void_OptionSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

	public unsafe bool _previousFog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousFog);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousFog)) = flag;
		}
	}

	public unsafe int _previousLODLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousLODLevel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousLODLevel)) = num;
		}
	}

	public unsafe int _previousMaxAdditionalLightsCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousMaxAdditionalLightsCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousMaxAdditionalLightsCount)) = num;
		}
	}

	public unsafe float _previousShadowDistance
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousShadowDistance);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__previousShadowDistance)) = num;
		}
	}

	public unsafe OptionSettings _settings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings);
			return *(OptionSettings*)num;
		}
		set
		{
			*(OptionSettings*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__settings)) = optionSettings;
		}
	}

	[CallerCount(0)]
	public unsafe OptionManager([DefaultParameterValue(null)] OptionSettings settings)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionManager>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_OptionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe void SetSettings([DefaultParameterValue(null)] OptionSettings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetSettings_Private_Void_OptionSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 42241, RefRangeEnd = 42242, XrefRangeStart = 42225, XrefRangeEnd = 42241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42242, XrefRangeEnd = 42258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void End()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_End_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe override void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static OptionManager()
	{
		Il2CppClassPointerStore<OptionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AkilliMum.Standard.Mirror", "OptionManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionManager>.NativeClassPtr);
		NativeFieldInfoPtr__previousFog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "_previousFog");
		NativeFieldInfoPtr__previousLODLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "_previousLODLevel");
		NativeFieldInfoPtr__previousMaxAdditionalLightsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "_previousMaxAdditionalLightsCount");
		NativeFieldInfoPtr__previousShadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "_previousShadowDistance");
		NativeFieldInfoPtr__settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, "_settings");
		NativeMethodInfoPtr__ctor_Public_Void_OptionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, 100665751);
		NativeMethodInfoPtr_SetSettings_Private_Void_OptionSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, 100665752);
		NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, 100665753);
		NativeMethodInfoPtr_End_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, 100665754);
		NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionManager>.NativeClassPtr, 100665755);
	}

	public OptionManager(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
