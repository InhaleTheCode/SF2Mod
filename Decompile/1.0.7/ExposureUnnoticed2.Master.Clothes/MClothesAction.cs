using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Object3D.Player.Scripts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Master.Clothes;

[System.Serializable]
public class MClothesAction : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_NameKey;

	private static readonly System.IntPtr NativeFieldInfoPtr_Rp;

	private static readonly System.IntPtr NativeFieldInfoPtr_State;

	private static readonly System.IntPtr NativeFieldInfoPtr_FrontStrangeness;

	private static readonly System.IntPtr NativeFieldInfoPtr_SideStrangeness;

	private static readonly System.IntPtr NativeFieldInfoPtr_BackStrangeness;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsArmActionFromPrev;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsArmActionFromNext;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string NameKey
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_NameKey), IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe double Rp
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rp);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Rp)) = num;
		}
	}

	public unsafe PlayerStateModel.ClothesState State
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State);
			return *(PlayerStateModel.ClothesState*)num;
		}
		set
		{
			*(PlayerStateModel.ClothesState*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_State)) = clothesState;
		}
	}

	public unsafe double FrontStrangeness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontStrangeness);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_FrontStrangeness)) = num;
		}
	}

	public unsafe double SideStrangeness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SideStrangeness);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SideStrangeness)) = num;
		}
	}

	public unsafe double BackStrangeness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackStrangeness);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BackStrangeness)) = num;
		}
	}

	public unsafe bool IsArmActionFromPrev
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmActionFromPrev);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmActionFromPrev)) = flag;
		}
	}

	public unsafe bool IsArmActionFromNext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmActionFromNext);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IsArmActionFromNext)) = flag;
		}
	}

	[CallerCount(0)]
	public unsafe MClothesAction()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static MClothesAction()
	{
		Il2CppClassPointerStore<MClothesAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Clothes", "MClothesAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr);
		NativeFieldInfoPtr_NameKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "NameKey");
		NativeFieldInfoPtr_Rp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "Rp");
		NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "State");
		NativeFieldInfoPtr_FrontStrangeness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "FrontStrangeness");
		NativeFieldInfoPtr_SideStrangeness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "SideStrangeness");
		NativeFieldInfoPtr_BackStrangeness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "BackStrangeness");
		NativeFieldInfoPtr_IsArmActionFromPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "IsArmActionFromPrev");
		NativeFieldInfoPtr_IsArmActionFromNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, "IsArmActionFromNext");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MClothesAction>.NativeClassPtr, 100668219);
	}

	public MClothesAction(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
