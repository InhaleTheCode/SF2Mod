using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SplineMesh;

public class ListChangedEventArgs<T> : Il2CppSystem.EventArgs
{
	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_newItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_removedItems;

	private static readonly System.IntPtr NativeFieldInfoPtr_insertIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_removeIndex;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ListChangeType type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type);
			return *(ListChangeType*)num;
		}
		set
		{
			*(ListChangeType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_type)) = listChangeType;
		}
	}

	public unsafe List<T> newItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_newItems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<T> removedItems
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedItems);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removedItems), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int insertIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insertIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_insertIndex)) = num;
		}
	}

	public unsafe int removeIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_removeIndex)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8175, XrefRangeEnd = 8178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ListChangedEventArgs()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ListChangedEventArgs()
	{
		Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SplineMesh", "ListChangedEventArgs`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr);
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "type");
		NativeFieldInfoPtr_newItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "newItems");
		NativeFieldInfoPtr_removedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "removedItems");
		NativeFieldInfoPtr_insertIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "insertIndex");
		NativeFieldInfoPtr_removeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, "removeIndex");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListChangedEventArgs<T>>.NativeClassPtr, 100664091);
	}

	public ListChangedEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
