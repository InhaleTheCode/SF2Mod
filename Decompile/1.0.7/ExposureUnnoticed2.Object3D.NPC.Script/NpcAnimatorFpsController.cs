using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Scripts.Util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcAnimatorFpsController : Il2CppSystem.Object
{
	public class CullingData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveDist;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level1Dist;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level1Frame;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level2Dist;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level2Frame;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level3Dist;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level3Frame;

		private static readonly System.IntPtr NativeFieldInfoPtr_Level4Frame;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe int ActiveDist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDist);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ActiveDist)) = num;
			}
		}

		public unsafe int Level1Dist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level1Dist);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level1Dist)) = num;
			}
		}

		public unsafe int Level1Frame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level1Frame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level1Frame)) = num;
			}
		}

		public unsafe int Level2Dist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level2Dist);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level2Dist)) = num;
			}
		}

		public unsafe int Level2Frame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level2Frame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level2Frame)) = num;
			}
		}

		public unsafe int Level3Dist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level3Dist);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level3Dist)) = num;
			}
		}

		public unsafe int Level3Frame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level3Frame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level3Frame)) = num;
			}
		}

		public unsafe int Level4Frame
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level4Frame);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Level4Frame)) = num;
			}
		}

		[CallerCount(0)]
		public unsafe CullingData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CullingData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static CullingData()
		{
			Il2CppClassPointerStore<CullingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "CullingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingData>.NativeClassPtr);
			NativeFieldInfoPtr_ActiveDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "ActiveDist");
			NativeFieldInfoPtr_Level1Dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level1Dist");
			NativeFieldInfoPtr_Level1Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level1Frame");
			NativeFieldInfoPtr_Level2Dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level2Dist");
			NativeFieldInfoPtr_Level2Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level2Frame");
			NativeFieldInfoPtr_Level3Dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level3Dist");
			NativeFieldInfoPtr_Level3Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level3Frame");
			NativeFieldInfoPtr_Level4Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingData>.NativeClassPtr, "Level4Frame");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingData>.NativeClassPtr, 100667355);
		}

		public CullingData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_animatorFPSController;

	private static readonly System.IntPtr NativeFieldInfoPtr_nca;

	private static readonly System.IntPtr NativeFieldInfoPtr_flame;

	private static readonly System.IntPtr NativeFieldInfoPtr_initTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingData;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe AnimatorFPSController animatorFPSController
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorFPSController);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimatorFPSController>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_animatorFPSController), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int flame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flame);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_flame)) = num;
		}
	}

	public unsafe float initTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_initTime)) = num;
		}
	}

	public unsafe CullingData cullingData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<CullingData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingData), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60786, RefRangeEnd = 60787, XrefRangeStart = 60776, XrefRangeEnd = 60786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60795, RefRangeEnd = 60798, XrefRangeStart = 60787, XrefRangeEnd = 60795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe NpcAnimatorFpsController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcAnimatorFpsController()
	{
		Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcAnimatorFpsController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr);
		NativeFieldInfoPtr_animatorFPSController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "animatorFPSController");
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "nca");
		NativeFieldInfoPtr_flame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "flame");
		NativeFieldInfoPtr_initTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "initTime");
		NativeFieldInfoPtr_cullingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, "cullingData");
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, 100667352);
		NativeMethodInfoPtr_OnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, 100667353);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAnimatorFpsController>.NativeClassPtr, 100667354);
	}

	public NpcAnimatorFpsController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
