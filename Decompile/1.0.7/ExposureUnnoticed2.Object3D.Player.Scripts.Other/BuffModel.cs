using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Object3D.Player.Scripts.Other;

public class BuffModel : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SourceName;

	private static readonly System.IntPtr NativeFieldInfoPtr_BuffSourceType;

	private static readonly System.IntPtr NativeFieldInfoPtr_SpecialType;

	private static readonly System.IntPtr NativeFieldInfoPtr_RpBonus100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Strange100;

	private static readonly System.IntPtr NativeFieldInfoPtr_Dokidoki100;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsActive;

	private static readonly System.IntPtr NativeFieldInfoPtr_ItemIdParseInt;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string SourceName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SourceName), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe BuffSourceType BuffSourceType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuffSourceType);
			return *(BuffSourceType*)num;
		}
		set
		{
			*(BuffSourceType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BuffSourceType)) = buffSourceType;
		}
	}

	public unsafe SpecialType SpecialType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialType);
			return *(SpecialType*)num;
		}
		set
		{
			*(SpecialType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpecialType)) = specialType;
		}
	}

	public unsafe int RpBonus100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_RpBonus100)) = num;
		}
	}

	public unsafe int Strange100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strange100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Strange100)) = num;
		}
	}

	public unsafe int Dokidoki100
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dokidoki100);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Dokidoki100)) = num;
		}
	}

	public unsafe bool IsActive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActive);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsActive)) = flag;
		}
	}

	public unsafe int ItemIdParseInt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemIdParseInt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ItemIdParseInt)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe BuffModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModel>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static BuffModel()
	{
		Il2CppClassPointerStore<BuffModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.Player.Scripts.Other", "BuffModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModel>.NativeClassPtr);
		NativeFieldInfoPtr_SourceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "SourceName");
		NativeFieldInfoPtr_BuffSourceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "BuffSourceType");
		NativeFieldInfoPtr_SpecialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "SpecialType");
		NativeFieldInfoPtr_RpBonus100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "RpBonus100");
		NativeFieldInfoPtr_Strange100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "Strange100");
		NativeFieldInfoPtr_Dokidoki100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "Dokidoki100");
		NativeFieldInfoPtr_IsActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "IsActive");
		NativeFieldInfoPtr_ItemIdParseInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, "ItemIdParseInt");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModel>.NativeClassPtr, 100666982);
	}

	public BuffModel(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
