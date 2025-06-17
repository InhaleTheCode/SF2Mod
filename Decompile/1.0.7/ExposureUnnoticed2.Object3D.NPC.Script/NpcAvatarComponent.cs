using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace ExposureUnnoticed2.Object3D.NPC.Script;

public class NpcAvatarComponent : MonoBehaviour
{
	public enum AvatarType
	{
		NewFemale,
		NewMale,
		NewOji,
		NewOba,
		PreviousFemale,
		PreviousMale
	}

	private static readonly IntPtr NativeFieldInfoPtr_MeshParent;

	private static readonly IntPtr NativeFieldInfoPtr_Head;

	private static readonly IntPtr NativeFieldInfoPtr_Eye;

	private static readonly IntPtr NativeFieldInfoPtr_HandL;

	private static readonly IntPtr NativeFieldInfoPtr_HandR;

	private static readonly IntPtr NativeFieldInfoPtr_MeshBodys;

	private static readonly IntPtr NativeFieldInfoPtr_MeshHairs;

	private static readonly IntPtr NativeFieldInfoPtr_MeshFaces;

	private static readonly IntPtr NativeFieldInfoPtr_MeshGlasses;

	private static readonly IntPtr NativeFieldInfoPtr_PoliceBody;

	private static readonly IntPtr NativeFieldInfoPtr_ConbiniBody;

	private static readonly IntPtr NativeFieldInfoPtr_Headset;

	private static readonly IntPtr NativeFieldInfoPtr_ConbiniScanner;

	private static readonly IntPtr NativeFieldInfoPtr_MeshChipo;

	private static readonly IntPtr NativeFieldInfoPtr_MeshChipoSex;

	private static readonly IntPtr NativeFieldInfoPtr_Peeticle;

	private static readonly IntPtr NativeFieldInfoPtr_HairTransformParents;

	private static readonly IntPtr NativeFieldInfoPtr_SpermColliders;

	private static readonly IntPtr NativeFieldInfoPtr_longHairSpermCollider;

	private static readonly IntPtr NativeFieldInfoPtr_policeCap;

	private static readonly IntPtr NativeFieldInfoPtr_PeeParticleSystem;

	private static readonly IntPtr NativeFieldInfoPtr__BodyRenderer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__HairRenderer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__FaceRenderer_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__bodyInitMaterial_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__hairInitMaterial_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__faceInitMaterial_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__headsetInitMaterial_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__glassesInitMaterial_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr_previousMaleMaterialDict;

	private static readonly IntPtr NativeFieldInfoPtr_bodyIndex;

	private static readonly IntPtr NativeFieldInfoPtr_hairIndex;

	private static readonly IntPtr NativeFieldInfoPtr_faceIndex;

	private static readonly IntPtr NativeFieldInfoPtr_nca;

	private static readonly IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_BodyRenderer_Private_get_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_BodyRenderer_Private_set_Void_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_HairRenderer_Private_get_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_HairRenderer_Private_set_Void_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_FaceRenderer_Private_get_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_FaceRenderer_Private_set_Void_Renderer_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_bodyInitMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_bodyInitMaterial_Private_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hairInitMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hairInitMaterial_Private_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_faceInitMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_faceInitMaterial_Private_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_headsetInitMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_headsetInitMaterial_Private_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_glassesInitMaterial_Public_get_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_glassesInitMaterial_Private_set_Void_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0;

	private static readonly IntPtr NativeMethodInfoPtr_ChangeFresnelMaterial_Public_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeNewYoung_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeNewOld_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializePrevious_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddTargetRenderer_Public_Void_List_1_Material_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe GameObject MeshParent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshParent);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshParent), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Head);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Head), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform Eye
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Eye);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Eye), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform HandL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandL);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandL), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Transform HandR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandR);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HandR), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Renderer> MeshBodys
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshBodys);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshBodys), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Renderer> MeshHairs
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshHairs);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshHairs), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<Renderer> MeshFaces
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshFaces);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Renderer>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshFaces), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer MeshGlasses
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshGlasses);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshGlasses), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer PoliceBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoliceBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PoliceBody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer ConbiniBody
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniBody);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniBody), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer Headset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Headset);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Headset), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer ConbiniScanner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniScanner);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ConbiniScanner), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MeshChipo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshChipo);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshChipo), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject MeshChipoSex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshChipoSex);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MeshChipoSex), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject Peeticle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Peeticle);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Peeticle), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> HairTransformParents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairTransformParents);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HairTransformParents), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Il2CppReferenceArray<GameObject> SpermColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermColliders);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SpermColliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject longHairSpermCollider
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairSpermCollider);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_longHairSpermCollider), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe GameObject policeCap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policeCap);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policeCap), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe ParticleSystem PeeParticleSystem
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeParticleSystem);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PeeParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer _BodyRenderer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyRenderer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BodyRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer _HairRenderer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HairRenderer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__HairRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Renderer _FaceRenderer_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FaceRenderer_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__FaceRenderer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _bodyInitMaterial_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bodyInitMaterial_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__bodyInitMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _hairInitMaterial_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hairInitMaterial_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hairInitMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _faceInitMaterial_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__faceInitMaterial_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__faceInitMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _headsetInitMaterial_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__headsetInitMaterial_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__headsetInitMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Material _glassesInitMaterial_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__glassesInitMaterial_k__BackingField);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__glassesInitMaterial_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe Dictionary<SkinnedMeshRenderer, Il2CppReferenceArray<Material>> previousMaleMaterialDict
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMaleMaterialDict);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<SkinnedMeshRenderer, Il2CppReferenceArray<Material>>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousMaleMaterialDict), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe int bodyIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_bodyIndex)) = num;
		}
	}

	public unsafe int hairIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hairIndex)) = num;
		}
	}

	public unsafe int faceIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_faceIndex)) = num;
		}
	}

	public unsafe NpcComponentAccessor nca
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<NpcComponentAccessor>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_nca), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool IsVisible
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 60798, XrefRangeEnd = 60803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}
	}

	public unsafe Renderer BodyRenderer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BodyRenderer_Private_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 60803, RefRangeEnd = 60807, XrefRangeStart = 60803, XrefRangeEnd = 60803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_BodyRenderer_Private_set_Void_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Renderer HairRenderer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_HairRenderer_Private_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_HairRenderer_Private_set_Void_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Renderer FaceRenderer
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_FaceRenderer_Private_get_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Renderer>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60807, RefRangeEnd = 60808, XrefRangeStart = 60807, XrefRangeEnd = 60807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_FaceRenderer_Private_set_Void_Renderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Material bodyInitMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_bodyInitMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60808, RefRangeEnd = 60809, XrefRangeStart = 60808, XrefRangeEnd = 60808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_bodyInitMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Material hairInitMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hairInitMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 60809, RefRangeEnd = 60810, XrefRangeStart = 60809, XrefRangeEnd = 60809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hairInitMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Material faceInitMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_faceInitMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_faceInitMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Material headsetInitMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_headsetInitMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_headsetInitMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	public unsafe Material glassesInitMaterial
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_glassesInitMaterial_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		[CallerCount(0)]
		[param: DefaultParameterValue(null)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_glassesInitMaterial_Private_set_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 60958, RefRangeEnd = 60959, XrefRangeStart = 60810, XrefRangeEnd = 60958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize([DefaultParameterValue(null)] NpcComponentAccessor nca)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(nca);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 60986, RefRangeEnd = 60989, XrefRangeStart = 60959, XrefRangeEnd = 60986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ChangeFresnelMaterial([DefaultParameterValue(null)] bool isFresnel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isFresnel);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ChangeFresnelMaterial_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61063, RefRangeEnd = 61064, XrefRangeStart = 60989, XrefRangeEnd = 61063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeNewYoung()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeNewYoung_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61064, XrefRangeEnd = 61069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeNewOld()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeNewOld_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61103, RefRangeEnd = 61104, XrefRangeStart = 61069, XrefRangeEnd = 61103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializePrevious()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializePrevious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 61128, RefRangeEnd = 61129, XrefRangeStart = 61104, XrefRangeEnd = 61128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTargetRenderer([DefaultParameterValue(null)] List<Material> list)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddTargetRenderer_Public_Void_List_1_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61129, XrefRangeEnd = 61134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAnimatorMove()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61134, XrefRangeEnd = 61143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NpcAvatarComponent()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr))
	{
		IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out IntPtr exc);
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static NpcAvatarComponent()
	{
		Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ExposureUnnoticed2.Object3D.NPC.Script", "NpcAvatarComponent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr);
		NativeFieldInfoPtr_MeshParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshParent");
		NativeFieldInfoPtr_Head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "Head");
		NativeFieldInfoPtr_Eye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "Eye");
		NativeFieldInfoPtr_HandL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "HandL");
		NativeFieldInfoPtr_HandR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "HandR");
		NativeFieldInfoPtr_MeshBodys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshBodys");
		NativeFieldInfoPtr_MeshHairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshHairs");
		NativeFieldInfoPtr_MeshFaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshFaces");
		NativeFieldInfoPtr_MeshGlasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshGlasses");
		NativeFieldInfoPtr_PoliceBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "PoliceBody");
		NativeFieldInfoPtr_ConbiniBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "ConbiniBody");
		NativeFieldInfoPtr_Headset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "Headset");
		NativeFieldInfoPtr_ConbiniScanner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "ConbiniScanner");
		NativeFieldInfoPtr_MeshChipo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshChipo");
		NativeFieldInfoPtr_MeshChipoSex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "MeshChipoSex");
		NativeFieldInfoPtr_Peeticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "Peeticle");
		NativeFieldInfoPtr_HairTransformParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "HairTransformParents");
		NativeFieldInfoPtr_SpermColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "SpermColliders");
		NativeFieldInfoPtr_longHairSpermCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "longHairSpermCollider");
		NativeFieldInfoPtr_policeCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "policeCap");
		NativeFieldInfoPtr_PeeParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "PeeParticleSystem");
		NativeFieldInfoPtr__BodyRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<BodyRenderer>k__BackingField");
		NativeFieldInfoPtr__HairRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<HairRenderer>k__BackingField");
		NativeFieldInfoPtr__FaceRenderer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<FaceRenderer>k__BackingField");
		NativeFieldInfoPtr__bodyInitMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<bodyInitMaterial>k__BackingField");
		NativeFieldInfoPtr__hairInitMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<hairInitMaterial>k__BackingField");
		NativeFieldInfoPtr__faceInitMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<faceInitMaterial>k__BackingField");
		NativeFieldInfoPtr__headsetInitMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<headsetInitMaterial>k__BackingField");
		NativeFieldInfoPtr__glassesInitMaterial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "<glassesInitMaterial>k__BackingField");
		NativeFieldInfoPtr_previousMaleMaterialDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "previousMaleMaterialDict");
		NativeFieldInfoPtr_bodyIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "bodyIndex");
		NativeFieldInfoPtr_hairIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "hairIndex");
		NativeFieldInfoPtr_faceIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "faceIndex");
		NativeFieldInfoPtr_nca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, "nca");
		NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667356);
		NativeMethodInfoPtr_get_BodyRenderer_Private_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667357);
		NativeMethodInfoPtr_set_BodyRenderer_Private_set_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667358);
		NativeMethodInfoPtr_get_HairRenderer_Private_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667359);
		NativeMethodInfoPtr_set_HairRenderer_Private_set_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667360);
		NativeMethodInfoPtr_get_FaceRenderer_Private_get_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667361);
		NativeMethodInfoPtr_set_FaceRenderer_Private_set_Void_Renderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667362);
		NativeMethodInfoPtr_get_bodyInitMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667363);
		NativeMethodInfoPtr_set_bodyInitMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667364);
		NativeMethodInfoPtr_get_hairInitMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667365);
		NativeMethodInfoPtr_set_hairInitMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667366);
		NativeMethodInfoPtr_get_faceInitMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667367);
		NativeMethodInfoPtr_set_faceInitMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667368);
		NativeMethodInfoPtr_get_headsetInitMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667369);
		NativeMethodInfoPtr_set_headsetInitMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667370);
		NativeMethodInfoPtr_get_glassesInitMaterial_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667371);
		NativeMethodInfoPtr_set_glassesInitMaterial_Private_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667372);
		NativeMethodInfoPtr_Initialize_Public_Void_NpcComponentAccessor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667373);
		NativeMethodInfoPtr_ChangeFresnelMaterial_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667374);
		NativeMethodInfoPtr_InitializeNewYoung_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667375);
		NativeMethodInfoPtr_InitializeNewOld_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667376);
		NativeMethodInfoPtr_InitializePrevious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667377);
		NativeMethodInfoPtr_AddTargetRenderer_Public_Void_List_1_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667378);
		NativeMethodInfoPtr_OnAnimatorMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667379);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NpcAvatarComponent>.NativeClassPtr, 100667380);
	}

	public NpcAvatarComponent(IntPtr pointer)
		: base(pointer)
	{
	}
}
