using System;
using System.Runtime.CompilerServices;
using ExposureUnnoticed2.Master.BodyPaint;
using ExposureUnnoticed2.Master.Hair;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu;

public class LoadoutCustomizeData : Il2CppSystem.Object
{
	[System.Serializable]
	[ObfuscatedName("ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu.LoadoutCustomizeData/<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__63_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ApplyToGameState_b__63_0_Internal_Void_0;

		public unsafe static __c __9
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe static Il2CppSystem.Action __9__63_0
		{
			get
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__63_0, &intPtr);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__63_0, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98786, XrefRangeEnd = 98794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ApplyToGameState_b__63_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ApplyToGameState_b__63_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__63_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670564);
			NativeMethodInfoPtr__ApplyToGameState_b__63_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100670565);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeHead;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeNeck;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeNeckThick;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeBoobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeSuperBoobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeHyperBoobs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeNipple;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeButt;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeWaist;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeLegInterval;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeThighs;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeThighsLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeLowerLeg;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeLowerLegLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeUpperBody;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeUpperBody2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeUpperBodyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeUpperBodyLength2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeArm;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeShoulder;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeInmou1;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeInmou2;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeInmouColorR;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeInmouColorG;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeInmouColorB;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeSkinColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeIsSkinColorFree;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeSkinColorR;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeSkinColorG;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeSkinColorB;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeFutanariSaoSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeFutanariTamaSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeFutanariTamaVisible;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeBlowColorR;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeBlowColorG;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeBlowColorB;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeLashColorR;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeLashColorG;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeLashColorB;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeLoliFace;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeOpenness;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeHitomiSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeTareme;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeDist;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeHeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeDark;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeOddEye;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeMatsugeThick;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeMatsugeLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeMayuThick;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeMayuDog;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeCheekFat;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEarElf;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeChinLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyePattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeEyeLeftPattern;

	private static readonly System.IntPtr NativeFieldInfoPtr_CustomizeYaeba;

	private static readonly System.IntPtr NativeFieldInfoPtr_CurrentHair;

	private static readonly System.IntPtr NativeFieldInfoPtr_HairCustomize;

	private static readonly System.IntPtr NativeFieldInfoPtr_BodyPaintTypeDict;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyToGameState_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveCurrentCustomize_Public_Void_0;

	public unsafe int CustomizeHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHeight)) = num;
		}
	}

	public unsafe int CustomizeHead
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHead);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHead)) = num;
		}
	}

	public unsafe int CustomizeNeck
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNeck);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNeck)) = num;
		}
	}

	public unsafe int CustomizeNeckThick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNeckThick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNeckThick)) = num;
		}
	}

	public unsafe int CustomizeBoobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeBoobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeBoobs)) = num;
		}
	}

	public unsafe int CustomizeSuperBoobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSuperBoobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSuperBoobs)) = num;
		}
	}

	public unsafe int CustomizeHyperBoobs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHyperBoobs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHyperBoobs)) = num;
		}
	}

	public unsafe int CustomizeNipple
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNipple);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeNipple)) = num;
		}
	}

	public unsafe int CustomizeButt
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeButt);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeButt)) = num;
		}
	}

	public unsafe int CustomizeWaist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeWaist);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeWaist)) = num;
		}
	}

	public unsafe int CustomizeLegInterval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLegInterval);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLegInterval)) = num;
		}
	}

	public unsafe int CustomizeThighs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeThighs);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeThighs)) = num;
		}
	}

	public unsafe int CustomizeThighsLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeThighsLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeThighsLength)) = num;
		}
	}

	public unsafe int CustomizeLowerLeg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLowerLeg);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLowerLeg)) = num;
		}
	}

	public unsafe int CustomizeLowerLegLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLowerLegLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLowerLegLength)) = num;
		}
	}

	public unsafe int CustomizeUpperBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBody);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBody)) = num;
		}
	}

	public unsafe int CustomizeUpperBody2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBody2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBody2)) = num;
		}
	}

	public unsafe int CustomizeUpperBodyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBodyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBodyLength)) = num;
		}
	}

	public unsafe int CustomizeUpperBodyLength2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBodyLength2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeUpperBodyLength2)) = num;
		}
	}

	public unsafe int CustomizeArm
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeArm);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeArm)) = num;
		}
	}

	public unsafe int CustomizeShoulder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeShoulder);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeShoulder)) = num;
		}
	}

	public unsafe int CustomizeInmou1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmou1);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmou1)) = num;
		}
	}

	public unsafe int CustomizeInmou2
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmou2);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmou2)) = num;
		}
	}

	public unsafe int CustomizeInmouColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorR)) = num;
		}
	}

	public unsafe int CustomizeInmouColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorG)) = num;
		}
	}

	public unsafe int CustomizeInmouColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeInmouColorB)) = num;
		}
	}

	public unsafe int CustomizeSkinColor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColor)) = num;
		}
	}

	public unsafe bool CustomizeIsSkinColorFree
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeIsSkinColorFree);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeIsSkinColorFree)) = flag;
		}
	}

	public unsafe int CustomizeSkinColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorR)) = num;
		}
	}

	public unsafe int CustomizeSkinColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorG)) = num;
		}
	}

	public unsafe int CustomizeSkinColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeSkinColorB)) = num;
		}
	}

	public unsafe int CustomizeFutanariSaoSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariSaoSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariSaoSize)) = num;
		}
	}

	public unsafe int CustomizeFutanariTamaSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariTamaSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariTamaSize)) = num;
		}
	}

	public unsafe bool CustomizeFutanariTamaVisible
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariTamaVisible);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeFutanariTamaVisible)) = flag;
		}
	}

	public unsafe int CustomizeEyeBlowColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorR)) = num;
		}
	}

	public unsafe int CustomizeEyeBlowColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorG)) = num;
		}
	}

	public unsafe int CustomizeEyeBlowColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeBlowColorB)) = num;
		}
	}

	public unsafe int CustomizeEyeLashColorR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorR)) = num;
		}
	}

	public unsafe int CustomizeEyeLashColorG
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorG);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorG)) = num;
		}
	}

	public unsafe int CustomizeEyeLashColorB
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorB);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLashColorB)) = num;
		}
	}

	public unsafe int CustomizeLoliFace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLoliFace);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeLoliFace)) = num;
		}
	}

	public unsafe int CustomizeEyeOpenness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeOpenness);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeOpenness)) = num;
		}
	}

	public unsafe int CustomizeEyeSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeSize)) = num;
		}
	}

	public unsafe int CustomizeHitomiSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHitomiSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeHitomiSize)) = num;
		}
	}

	public unsafe int CustomizeTareme
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeTareme);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeTareme)) = num;
		}
	}

	public unsafe int CustomizeEyeDist
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeDist);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeDist)) = num;
		}
	}

	public unsafe int CustomizeEyeHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeHeight);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeHeight)) = num;
		}
	}

	public unsafe bool CustomizeEyeDark
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeDark);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeDark)) = flag;
		}
	}

	public unsafe bool CustomizeOddEye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeOddEye);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeOddEye)) = flag;
		}
	}

	public unsafe int CustomizeMatsugeThick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMatsugeThick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMatsugeThick)) = num;
		}
	}

	public unsafe int CustomizeMatsugeLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMatsugeLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMatsugeLength)) = num;
		}
	}

	public unsafe int CustomizeMayuThick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMayuThick);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMayuThick)) = num;
		}
	}

	public unsafe int CustomizeMayuDog
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMayuDog);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeMayuDog)) = num;
		}
	}

	public unsafe int CustomizeCheekFat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeCheekFat);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeCheekFat)) = num;
		}
	}

	public unsafe int CustomizeEarElf
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEarElf);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEarElf)) = num;
		}
	}

	public unsafe int CustomizeChinLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeChinLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeChinLength)) = num;
		}
	}

	public unsafe int CustomizeEyePattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyePattern);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyePattern)) = num;
		}
	}

	public unsafe int CustomizeEyeLeftPattern
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLeftPattern);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeEyeLeftPattern)) = num;
		}
	}

	public unsafe bool CustomizeYaeba
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeYaeba);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CustomizeYaeba)) = flag;
		}
	}

	public unsafe HairType CurrentHair
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentHair);
			return *(HairType*)num;
		}
		set
		{
			*(HairType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CurrentHair)) = hairType;
		}
	}

	public unsafe MHairRecord.HairCustomizeData HairCustomize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairCustomize);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<MHairRecord.HairCustomizeData>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairCustomize), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<BodyPaintType, bool> BodyPaintTypeDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPaintTypeDict);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<BodyPaintType, bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BodyPaintTypeDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98794, XrefRangeEnd = 98795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadoutCustomizeData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 98913, RefRangeEnd = 98918, XrefRangeStart = 98795, XrefRangeEnd = 98913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyToGameState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyToGameState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 98993, RefRangeEnd = 99001, XrefRangeStart = 98918, XrefRangeEnd = 98993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SaveCurrentCustomize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveCurrentCustomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static LoadoutCustomizeData()
	{
		Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.ObjectUI.ClosetMenu.CustomizeMenu", "LoadoutCustomizeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr);
		NativeFieldInfoPtr_CustomizeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeHeight");
		NativeFieldInfoPtr_CustomizeHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeHead");
		NativeFieldInfoPtr_CustomizeNeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeNeck");
		NativeFieldInfoPtr_CustomizeNeckThick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeNeckThick");
		NativeFieldInfoPtr_CustomizeBoobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeBoobs");
		NativeFieldInfoPtr_CustomizeSuperBoobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeSuperBoobs");
		NativeFieldInfoPtr_CustomizeHyperBoobs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeHyperBoobs");
		NativeFieldInfoPtr_CustomizeNipple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeNipple");
		NativeFieldInfoPtr_CustomizeButt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeButt");
		NativeFieldInfoPtr_CustomizeWaist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeWaist");
		NativeFieldInfoPtr_CustomizeLegInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeLegInterval");
		NativeFieldInfoPtr_CustomizeThighs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeThighs");
		NativeFieldInfoPtr_CustomizeThighsLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeThighsLength");
		NativeFieldInfoPtr_CustomizeLowerLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeLowerLeg");
		NativeFieldInfoPtr_CustomizeLowerLegLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeLowerLegLength");
		NativeFieldInfoPtr_CustomizeUpperBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeUpperBody");
		NativeFieldInfoPtr_CustomizeUpperBody2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeUpperBody2");
		NativeFieldInfoPtr_CustomizeUpperBodyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeUpperBodyLength");
		NativeFieldInfoPtr_CustomizeUpperBodyLength2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeUpperBodyLength2");
		NativeFieldInfoPtr_CustomizeArm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeArm");
		NativeFieldInfoPtr_CustomizeShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeShoulder");
		NativeFieldInfoPtr_CustomizeInmou1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeInmou1");
		NativeFieldInfoPtr_CustomizeInmou2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeInmou2");
		NativeFieldInfoPtr_CustomizeInmouColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeInmouColorR");
		NativeFieldInfoPtr_CustomizeInmouColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeInmouColorG");
		NativeFieldInfoPtr_CustomizeInmouColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeInmouColorB");
		NativeFieldInfoPtr_CustomizeSkinColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeSkinColor");
		NativeFieldInfoPtr_CustomizeIsSkinColorFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeIsSkinColorFree");
		NativeFieldInfoPtr_CustomizeSkinColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeSkinColorR");
		NativeFieldInfoPtr_CustomizeSkinColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeSkinColorG");
		NativeFieldInfoPtr_CustomizeSkinColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeSkinColorB");
		NativeFieldInfoPtr_CustomizeFutanariSaoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeFutanariSaoSize");
		NativeFieldInfoPtr_CustomizeFutanariTamaSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeFutanariTamaSize");
		NativeFieldInfoPtr_CustomizeFutanariTamaVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeFutanariTamaVisible");
		NativeFieldInfoPtr_CustomizeEyeBlowColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeBlowColorR");
		NativeFieldInfoPtr_CustomizeEyeBlowColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeBlowColorG");
		NativeFieldInfoPtr_CustomizeEyeBlowColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeBlowColorB");
		NativeFieldInfoPtr_CustomizeEyeLashColorR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeLashColorR");
		NativeFieldInfoPtr_CustomizeEyeLashColorG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeLashColorG");
		NativeFieldInfoPtr_CustomizeEyeLashColorB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeLashColorB");
		NativeFieldInfoPtr_CustomizeLoliFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeLoliFace");
		NativeFieldInfoPtr_CustomizeEyeOpenness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeOpenness");
		NativeFieldInfoPtr_CustomizeEyeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeSize");
		NativeFieldInfoPtr_CustomizeHitomiSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeHitomiSize");
		NativeFieldInfoPtr_CustomizeTareme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeTareme");
		NativeFieldInfoPtr_CustomizeEyeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeDist");
		NativeFieldInfoPtr_CustomizeEyeHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeHeight");
		NativeFieldInfoPtr_CustomizeEyeDark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeDark");
		NativeFieldInfoPtr_CustomizeOddEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeOddEye");
		NativeFieldInfoPtr_CustomizeMatsugeThick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeMatsugeThick");
		NativeFieldInfoPtr_CustomizeMatsugeLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeMatsugeLength");
		NativeFieldInfoPtr_CustomizeMayuThick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeMayuThick");
		NativeFieldInfoPtr_CustomizeMayuDog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeMayuDog");
		NativeFieldInfoPtr_CustomizeCheekFat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeCheekFat");
		NativeFieldInfoPtr_CustomizeEarElf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEarElf");
		NativeFieldInfoPtr_CustomizeChinLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeChinLength");
		NativeFieldInfoPtr_CustomizeEyePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyePattern");
		NativeFieldInfoPtr_CustomizeEyeLeftPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeEyeLeftPattern");
		NativeFieldInfoPtr_CustomizeYaeba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CustomizeYaeba");
		NativeFieldInfoPtr_CurrentHair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "CurrentHair");
		NativeFieldInfoPtr_HairCustomize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "HairCustomize");
		NativeFieldInfoPtr_BodyPaintTypeDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, "BodyPaintTypeDict");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, 100670560);
		NativeMethodInfoPtr_ApplyToGameState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, 100670561);
		NativeMethodInfoPtr_SaveCurrentCustomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadoutCustomizeData>.NativeClassPtr, 100670562);
	}

	public LoadoutCustomizeData(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
