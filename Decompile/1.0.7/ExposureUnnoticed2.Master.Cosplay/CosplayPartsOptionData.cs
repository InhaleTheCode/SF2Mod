using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace ExposureUnnoticed2.Master.Cosplay;

public class CosplayPartsOptionData : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_r;

	private static readonly System.IntPtr NativeFieldInfoPtr_g;

	private static readonly System.IntPtr NativeFieldInfoPtr_b;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadeColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_materialIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_boolOption1;

	private static readonly System.IntPtr NativeFieldInfoPtr_boolOption2;

	private static readonly System.IntPtr NativeFieldInfoPtr_uniqueId;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CosplayPartsOptionData_0;

	public unsafe int r
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_r)) = num;
		}
	}

	public unsafe int g
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_g)) = num;
		}
	}

	public unsafe int b
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_b)) = num;
		}
	}

	public unsafe int shadeColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadeColor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadeColor)) = num;
		}
	}

	public unsafe int materialIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_materialIndex)) = num;
		}
	}

	public unsafe bool boolOption1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolOption1);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolOption1)) = flag;
		}
	}

	public unsafe bool boolOption2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolOption2);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_boolOption2)) = flag;
		}
	}

	public unsafe int uniqueId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uniqueId)) = num;
		}
	}

	[CallerCount(0)]
	public unsafe CosplayPartsOptionData([DefaultParameterValue(null)] int uniqueId)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&uniqueId);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe CosplayPartsOptionData([DefaultParameterValue(null)] int uniqueId, [DefaultParameterValue(null)] CosplayPartsOptionData original)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&uniqueId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(original);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_CosplayPartsOptionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static CosplayPartsOptionData()
	{
		Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Master.Cosplay", "CosplayPartsOptionData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr);
		NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "r");
		NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "g");
		NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "b");
		NativeFieldInfoPtr_shadeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "shadeColor");
		NativeFieldInfoPtr_materialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "materialIndex");
		NativeFieldInfoPtr_boolOption1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "boolOption1");
		NativeFieldInfoPtr_boolOption2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "boolOption2");
		NativeFieldInfoPtr_uniqueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, "uniqueId");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, 100668179);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_CosplayPartsOptionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosplayPartsOptionData>.NativeClassPtr, 100668180);
	}

	public CosplayPartsOptionData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
