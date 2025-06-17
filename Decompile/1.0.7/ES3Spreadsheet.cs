using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Reflection;

public class ES3Spreadsheet : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Index
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_col;

		private static readonly System.IntPtr NativeFieldInfoPtr_row;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		[FieldOffset(0)]
		public int col;

		[FieldOffset(4)]
		public int row;

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 3881, RefRangeEnd = 3884, XrefRangeStart = 3881, XrefRangeEnd = 3881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Index([DefaultParameterValue(null)] int col, [DefaultParameterValue(null)] int row)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&col);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Index()
		{
			Il2CppClassPointerStore<Index>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "Index");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Index>.NativeClassPtr);
			NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "col");
			NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Index>.NativeClassPtr, "row");
			NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Index>.NativeClassPtr, 100663646);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Index>.NativeClassPtr, (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this)));
		}
	}

	private sealed class MethodInfoStoreGeneric_GetCell_Public_T_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetCell_Public_T_Int32_Int32_0, Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_cols;

	private static readonly System.IntPtr NativeFieldInfoPtr_rows;

	private static readonly System.IntPtr NativeFieldInfoPtr_cells;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUOTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_QUOTE_CHAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_COMMA_CHAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_NEWLINE_CHAR;

	private static readonly System.IntPtr NativeFieldInfoPtr_ESCAPED_QUOTE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHARS_TO_ESCAPE;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetColumnLength_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRowLength_Public_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCell_Public_Void_Int32_Int32_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCellString_Private_Void_Int32_Int32_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCell_Public_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCell_Public_Object_Type_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRaw_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadRaw_Public_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Private_Void_Stream_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_ES3Settings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_ES3Settings_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Escape_Private_Static_String_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unescape_Private_Static_String_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToArray_Private_Il2CppObjectBase_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe int cols
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cols);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cols)) = num;
		}
	}

	public unsafe int rows
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rows)) = num;
		}
	}

	public unsafe Dictionary<Index, string> cells
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Index, string>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cells), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static string QUOTE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUOTE, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUOTE, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static char QUOTE_CHAR
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_QUOTE_CHAR, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_QUOTE_CHAR, &c);
		}
	}

	public unsafe static char COMMA_CHAR
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_COMMA_CHAR, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_COMMA_CHAR, &c);
		}
	}

	public unsafe static char NEWLINE_CHAR
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out char result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_NEWLINE_CHAR, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_NEWLINE_CHAR, &c);
		}
	}

	public unsafe static string ESCAPED_QUOTE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr il2CppString);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ESCAPED_QUOTE, &il2CppString);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ESCAPED_QUOTE, (void*)IL2CPP.ManagedStringToIl2Cpp(str));
		}
	}

	public unsafe static Il2CppStructArray<char> CHARS_TO_ESCAPE
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHARS_TO_ESCAPE, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHARS_TO_ESCAPE, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int ColumnCount
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 3884, RefRangeEnd = 3888, XrefRangeStart = 3884, XrefRangeEnd = 3884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe int RowCount
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(int*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3888, XrefRangeEnd = 3897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetColumnLength([DefaultParameterValue(null)] int col)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&col);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetColumnLength_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3897, XrefRangeEnd = 3906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRowLength([DefaultParameterValue(null)] int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&row);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRowLength_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(int*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3934, RefRangeEnd = 3935, XrefRangeStart = 3906, XrefRangeEnd = 3934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCell([DefaultParameterValue(null)] int col, [DefaultParameterValue(null)] int row, [DefaultParameterValue(null)] Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&col);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCell_Public_Void_Int32_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3938, RefRangeEnd = 3939, XrefRangeStart = 3935, XrefRangeEnd = 3938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCellString([DefaultParameterValue(null)] int col, [DefaultParameterValue(null)] int row, [DefaultParameterValue(null)] string value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&col);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(value);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCellString_Private_Void_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3939, XrefRangeEnd = 3962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T GetCell<T>([DefaultParameterValue(null)] int col, [DefaultParameterValue(null)] int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&col);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr objectPointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetCell_Public_T_Int32_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.PointerToValueGeneric<T>(objectPointer, isFieldPointer: false, valueTypeWouldBeBoxed: true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 3980, RefRangeEnd = 3981, XrefRangeStart = 3962, XrefRangeEnd = 3980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.Object GetCell([DefaultParameterValue(null)] Il2CppSystem.Type type, [DefaultParameterValue(null)] int col, [DefaultParameterValue(null)] int row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &col;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &row;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCell_Public_Object_Type_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3981, XrefRangeEnd = 3987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load([DefaultParameterValue(null)] string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3987, XrefRangeEnd = 3994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3994, XrefRangeEnd = 3996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load([DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Void_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 3996, XrefRangeEnd = 4009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadRaw([DefaultParameterValue(null)] string str)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRaw_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4009, XrefRangeEnd = 4015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadRaw([DefaultParameterValue(null)] string str, [DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadRaw_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 4049, RefRangeEnd = 4054, XrefRangeStart = 4015, XrefRangeEnd = 4049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Load([DefaultParameterValue(null)] Stream stream, [DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Private_Void_Stream_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4054, XrefRangeEnd = 4059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] string filePath)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4059, XrefRangeEnd = 4065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4065, XrefRangeEnd = 4066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] ES3Settings settings)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4066, XrefRangeEnd = 4071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] bool append)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4071, XrefRangeEnd = 4077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] string filePath, [DefaultParameterValue(null)] ES3Settings settings, [DefaultParameterValue(null)] bool append)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(filePath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(settings);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 4100, RefRangeEnd = 4105, XrefRangeStart = 4077, XrefRangeEnd = 4100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save([DefaultParameterValue(null)] ES3Settings settings, [DefaultParameterValue(null)] bool append)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &append;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Save_Public_Void_ES3Settings_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4122, RefRangeEnd = 4123, XrefRangeStart = 4105, XrefRangeEnd = 4122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Escape([DefaultParameterValue(null)] string str, bool isAlreadyWrappedInQuotes = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &isAlreadyWrappedInQuotes;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Escape_Private_Static_String_String_Boolean_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4123, XrefRangeEnd = 4135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Unescape([DefaultParameterValue(null)] string str)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unescape_Private_Static_String_String_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return IL2CPP.Il2CppStringToManaged(il2CppString);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 4148, RefRangeEnd = 4149, XrefRangeStart = 4135, XrefRangeEnd = 4148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppObjectBase ToArray()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToArray_Private_Il2CppObjectBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 4149, XrefRangeEnd = 4155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ES3Spreadsheet()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static ES3Spreadsheet()
	{
		Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ES3Spreadsheet");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr);
		NativeFieldInfoPtr_cols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "cols");
		NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "rows");
		NativeFieldInfoPtr_cells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "cells");
		NativeFieldInfoPtr_QUOTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "QUOTE");
		NativeFieldInfoPtr_QUOTE_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "QUOTE_CHAR");
		NativeFieldInfoPtr_COMMA_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "COMMA_CHAR");
		NativeFieldInfoPtr_NEWLINE_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "NEWLINE_CHAR");
		NativeFieldInfoPtr_ESCAPED_QUOTE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "ESCAPED_QUOTE");
		NativeFieldInfoPtr_CHARS_TO_ESCAPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, "CHARS_TO_ESCAPE");
		NativeMethodInfoPtr_get_ColumnCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_get_RowCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663622);
		NativeMethodInfoPtr_GetColumnLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663623);
		NativeMethodInfoPtr_GetRowLength_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663624);
		NativeMethodInfoPtr_SetCell_Public_Void_Int32_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663625);
		NativeMethodInfoPtr_SetCellString_Private_Void_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663626);
		NativeMethodInfoPtr_GetCell_Public_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr_GetCell_Public_Object_Type_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663628);
		NativeMethodInfoPtr_Load_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663629);
		NativeMethodInfoPtr_Load_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663630);
		NativeMethodInfoPtr_Load_Public_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_LoadRaw_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_LoadRaw_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_Load_Private_Void_Stream_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_Save_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_Save_Public_Void_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_Save_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_Save_Public_Void_String_ES3Settings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_Save_Public_Void_ES3Settings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_Escape_Private_Static_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_Unescape_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_ToArray_Private_Il2CppObjectBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ES3Spreadsheet>.NativeClassPtr, 100663644);
	}

	public ES3Spreadsheet(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
