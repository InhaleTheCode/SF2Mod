using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.Action;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace ExposureUnnoticed2.ObjectUI.InventoryPanel;

public class IEquipableMaster : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_NameKey_Public_Abstract_Virtual_New_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransAttachActionType_Public_Abstract_Virtual_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_TransDetachActionType_Public_Abstract_Virtual_New_ActionType_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_DescriptionKey_Public_Abstract_Virtual_New_get_String_0;

	public unsafe virtual string NameKey
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_get_NameKey_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	public unsafe virtual string DescriptionKey
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_get_DescriptionKey_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppException.RaiseExceptionIfNecessary(exc);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
	}

	[CallerCount(0)]
	public unsafe virtual ActionType TransAttachActionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_TransAttachActionType_Public_Abstract_Virtual_New_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	public unsafe virtual ActionType TransDetachActionType()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NativeMethodInfoPtr_TransDetachActionType_Public_Abstract_Virtual_New_ActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(ActionType*)IL2CPP.il2cpp_object_unbox(obj);
	}

	static IEquipableMaster()
	{
		Il2CppClassPointerStore<IEquipableMaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.InventoryPanel", "IEquipableMaster");
		NativeMethodInfoPtr_get_NameKey_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquipableMaster>.NativeClassPtr, 100669801);
		NativeMethodInfoPtr_TransAttachActionType_Public_Abstract_Virtual_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquipableMaster>.NativeClassPtr, 100669802);
		NativeMethodInfoPtr_TransDetachActionType_Public_Abstract_Virtual_New_ActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquipableMaster>.NativeClassPtr, 100669803);
		NativeMethodInfoPtr_get_DescriptionKey_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEquipableMaster>.NativeClassPtr, 100669804);
	}

	public IEquipableMaster(IntPtr pointer)
		: base(pointer)
	{
	}
}
