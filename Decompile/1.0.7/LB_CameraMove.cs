using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

public class LB_CameraMove : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_cameraSensitivity;

	private static readonly IntPtr NativeFieldInfoPtr_climbSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_normalMoveSpeed;

	private static readonly IntPtr NativeFieldInfoPtr_slowMoveFactor;

	private static readonly IntPtr NativeFieldInfoPtr_fastMoveFactor;

	private static readonly IntPtr NativeFieldInfoPtr_rotationX;

	private static readonly IntPtr NativeFieldInfoPtr_rotationY;

	private static readonly IntPtr NativeFieldInfoPtr_showCursor;

	private static readonly IntPtr NativeFieldInfoPtr_isActive;

	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe float cameraSensitivity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cameraSensitivity)) = num;
		}
	}

	public unsafe float climbSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_climbSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_climbSpeed)) = num;
		}
	}

	public unsafe float normalMoveSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_normalMoveSpeed)) = num;
		}
	}

	public unsafe float slowMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slowMoveFactor)) = num;
		}
	}

	public unsafe float fastMoveFactor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_fastMoveFactor)) = num;
		}
	}

	public unsafe float rotationX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationX)) = num;
		}
	}

	public unsafe float rotationY
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rotationY)) = num;
		}
	}

	public unsafe bool showCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCursor);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_showCursor)) = flag;
		}
	}

	public unsafe bool isActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isActive)) = flag;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6625, XrefRangeEnd = 6637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6637, XrefRangeEnd = 6773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6773, XrefRangeEnd = 6776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LB_CameraMove()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LB_CameraMove()
	{
		Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "LB_CameraMove");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr);
		NativeFieldInfoPtr_cameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "cameraSensitivity");
		NativeFieldInfoPtr_climbSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "climbSpeed");
		NativeFieldInfoPtr_normalMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "normalMoveSpeed");
		NativeFieldInfoPtr_slowMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "slowMoveFactor");
		NativeFieldInfoPtr_fastMoveFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "fastMoveFactor");
		NativeFieldInfoPtr_rotationX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "rotationX");
		NativeFieldInfoPtr_rotationY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "rotationY");
		NativeFieldInfoPtr_showCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "showCursor");
		NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, "isActive");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, 100663961);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, 100663962);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LB_CameraMove>.NativeClassPtr, 100663963);
	}

	public LB_CameraMove(IntPtr pointer)
		: base(pointer)
	{
	}
}
