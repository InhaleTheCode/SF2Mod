using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine;

public class DynamicBone : MonoBehaviour
{
	public enum UpdateMode
	{
		Normal,
		AnimatePhysics,
		UnscaledTime,
		Default
	}

	public enum FreezeAxis
	{
		None,
		X,
		Y,
		Z
	}

	public class Particle : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Transform;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_ChildCount;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Elasticity;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Stiffness;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Inert;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Friction;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Radius;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_isCollide;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformNotNull;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_EndOffset;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InitLocalPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_InitLocalRotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformLocalPosition;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformLocalToWorldMatrix;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Transform m_Transform
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Transform);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Transform), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe int m_ParentIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParentIndex)) = num;
			}
		}

		public unsafe int m_ChildCount
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildCount);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ChildCount)) = num;
			}
		}

		public unsafe float m_Damping
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Damping);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Damping)) = num;
			}
		}

		public unsafe float m_Elasticity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elasticity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elasticity)) = num;
			}
		}

		public unsafe float m_Stiffness
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Stiffness);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Stiffness)) = num;
			}
		}

		public unsafe float m_Inert
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Inert);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Inert)) = num;
			}
		}

		public unsafe float m_Friction
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Friction);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Friction)) = num;
			}
		}

		public unsafe float m_Radius
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius)) = num;
			}
		}

		public unsafe float m_BoneLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneLength);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneLength)) = num;
			}
		}

		public unsafe bool m_isCollide
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isCollide);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_isCollide)) = flag;
			}
		}

		public unsafe bool m_TransformNotNull
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformNotNull);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformNotNull)) = flag;
			}
		}

		public unsafe Vector3 m_Position
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Position)) = vector;
			}
		}

		public unsafe Vector3 m_PrevPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrevPosition)) = vector;
			}
		}

		public unsafe Vector3 m_EndOffset
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndOffset);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndOffset)) = vector;
			}
		}

		public unsafe Vector3 m_InitLocalPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitLocalPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitLocalPosition)) = vector;
			}
		}

		public unsafe Quaternion m_InitLocalRotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitLocalRotation);
				return *(Quaternion*)num;
			}
			set
			{
				*(Quaternion*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InitLocalRotation)) = quaternion;
			}
		}

		public unsafe Vector3 m_TransformPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformPosition)) = vector;
			}
		}

		public unsafe Vector3 m_TransformLocalPosition
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLocalPosition);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLocalPosition)) = vector;
			}
		}

		public unsafe Matrix4x4 m_TransformLocalToWorldMatrix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLocalToWorldMatrix);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformLocalToWorldMatrix)) = matrix4x;
			}
		}

		[CallerCount(0)]
		public unsafe Particle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Particle>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static Particle()
		{
			Il2CppClassPointerStore<Particle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "Particle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Particle>.NativeClassPtr);
			NativeFieldInfoPtr_m_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Transform");
			NativeFieldInfoPtr_m_ParentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_ParentIndex");
			NativeFieldInfoPtr_m_ChildCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_ChildCount");
			NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Damping");
			NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Elasticity");
			NativeFieldInfoPtr_m_Stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Stiffness");
			NativeFieldInfoPtr_m_Inert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Inert");
			NativeFieldInfoPtr_m_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Friction");
			NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Radius");
			NativeFieldInfoPtr_m_BoneLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_BoneLength");
			NativeFieldInfoPtr_m_isCollide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_isCollide");
			NativeFieldInfoPtr_m_TransformNotNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_TransformNotNull");
			NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_Position");
			NativeFieldInfoPtr_m_PrevPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_PrevPosition");
			NativeFieldInfoPtr_m_EndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_EndOffset");
			NativeFieldInfoPtr_m_InitLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_InitLocalPosition");
			NativeFieldInfoPtr_m_InitLocalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_InitLocalRotation");
			NativeFieldInfoPtr_m_TransformPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_TransformPosition");
			NativeFieldInfoPtr_m_TransformLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_TransformLocalPosition");
			NativeFieldInfoPtr_m_TransformLocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Particle>.NativeClassPtr, "m_TransformLocalToWorldMatrix");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Particle>.NativeClassPtr, 100663357);
		}

		public Particle(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class ParticleTree : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Root;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalGravity;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_RootWorldToLocalMatrix;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneTotalLength;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Particles;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_RestGravity;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Transform m_Root
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Root);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Root), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector3 m_LocalGravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalGravity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_LocalGravity)) = vector;
			}
		}

		public unsafe Matrix4x4 m_RootWorldToLocalMatrix
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootWorldToLocalMatrix);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RootWorldToLocalMatrix)) = matrix4x;
			}
		}

		public unsafe float m_BoneTotalLength
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTotalLength);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneTotalLength)) = num;
			}
		}

		public unsafe List<Particle> m_Particles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Particles);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Particle>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Particles), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		public unsafe Vector3 m_RestGravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RestGravity);
				return *(Vector3*)num;
			}
			set
			{
				*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RestGravity)) = vector;
			}
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214, XrefRangeEnd = 220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleTree()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		static ParticleTree()
		{
			Il2CppClassPointerStore<ParticleTree>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "ParticleTree");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr);
			NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_Root");
			NativeFieldInfoPtr_m_LocalGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_LocalGravity");
			NativeFieldInfoPtr_m_RootWorldToLocalMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_RootWorldToLocalMatrix");
			NativeFieldInfoPtr_m_BoneTotalLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_BoneTotalLength");
			NativeFieldInfoPtr_m_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_Particles");
			NativeFieldInfoPtr_m_RestGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, "m_RestGravity");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleTree>.NativeClassPtr, 100663358);
		}

		public ParticleTree(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("DynamicBone/<>c__DisplayClass69_0")]
	public sealed class __c__DisplayClass69_0 : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_root;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__SetupParticles_b__0_Internal_Boolean_ParticleTree_0;

		public unsafe Transform root
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr(obj));
			}
		}

		[CallerCount(0)]
		public unsafe __c__DisplayClass69_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220, XrefRangeEnd = 227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetupParticles_b__0([DefaultParameterValue(null)] ParticleTree x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__SetupParticles_b__0_Internal_Boolean_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
			return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
		}

		static __c__DisplayClass69_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "<>c__DisplayClass69_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr);
			NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, "root");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, 100663359);
			NativeMethodInfoPtr__SetupParticles_b__0_Internal_Boolean_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass69_0>.NativeClassPtr, 100663360);
		}

		public __c__DisplayClass69_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Root;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Roots;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateRate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_UpdateMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Damping;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DampingDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Elasticity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ElasticityDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Stiffness;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_StiffnessDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Inert;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InertDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Friction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrictionDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_RadiusDistrib;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EndLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EndOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Gravity;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Force;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendWeight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Colliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Exclusions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreezeAxis;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DistantDisable;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReferenceObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceToObject;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Multithread;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectMove;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectPrevPosition;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DistantDisabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreUpdateCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ParticleTrees;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DeltaTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveColliders;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorkAdded;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PendingWorks;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_EffectiveWorks;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_AllWorksDoneEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RemainWorkCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_WorkQueueSemaphore;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_WorkQueueIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_UpdateCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_PrepareFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_isInitAnimationCurveKeyLenght;

	private static readonly System.IntPtr NativeFieldInfoPtr_dampKeyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_elasKeyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_stiffKeyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_inertKeyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_frictKeyLength;

	private static readonly System.IntPtr NativeFieldInfoPtr_radiusKeyLength;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prepare_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsNeedUpdate_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PreUpdate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CheckDistance_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsRootChanged_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DrawGizmos_Private_Void_ParticleTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWeight_Public_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWeight_Public_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetupParticles_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendParticleTree_Private_Void_Transform_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendParticles_Private_Void_ParticleTree_Transform_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitKey_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParameters_Private_Void_ParticleTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitTransforms_Private_Void_ParticleTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_ParticleTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles1_Private_Void_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles1_Private_Void_ParticleTree_Single_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles2_Private_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticles2_Private_Void_ParticleTree_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_ParticleTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MirrorVector_Private_Static_Vector3_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_ParticleTree_Vector3_Vector3_Vector3_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddPendingWork_Private_Static_Void_DynamicBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddWorkToQueue_Private_Static_Void_DynamicBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkFromQueue_Private_Static_DynamicBone_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitThreadPool_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteWorks_Private_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Transform m_Root
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Root);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Root), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Transform> m_Roots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Roots);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Roots), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_UpdateRate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRate);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateRate)) = num;
		}
	}

	public unsafe UpdateMode m_UpdateMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMode);
			return *(UpdateMode*)num;
		}
		set
		{
			*(UpdateMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_UpdateMode)) = updateMode;
		}
	}

	public unsafe float m_Damping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Damping);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Damping)) = num;
		}
	}

	public unsafe AnimationCurve m_DampingDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DampingDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DampingDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_Elasticity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elasticity);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Elasticity)) = num;
		}
	}

	public unsafe AnimationCurve m_ElasticityDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ElasticityDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ElasticityDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_Stiffness
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Stiffness);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Stiffness)) = num;
		}
	}

	public unsafe AnimationCurve m_StiffnessDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StiffnessDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_StiffnessDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_Inert
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Inert);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Inert)) = num;
		}
	}

	public unsafe AnimationCurve m_InertDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InertDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_InertDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_Friction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Friction);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Friction)) = num;
		}
	}

	public unsafe AnimationCurve m_FrictionDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrictionDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrictionDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_Radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Radius)) = num;
		}
	}

	public unsafe AnimationCurve m_RadiusDistrib
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RadiusDistrib);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RadiusDistrib), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_EndLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndLength);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndLength)) = num;
		}
	}

	public unsafe Vector3 m_EndOffset
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndOffset);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EndOffset)) = vector;
		}
	}

	public unsafe Vector3 m_Gravity
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Gravity);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Gravity)) = vector;
		}
	}

	public unsafe Vector3 m_Force
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Force);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Force)) = vector;
		}
	}

	public unsafe float m_BlendWeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendWeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BlendWeight)) = num;
		}
	}

	public unsafe List<DynamicBoneColliderBase> m_Colliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Colliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicBoneColliderBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Colliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe List<Transform> m_Exclusions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Exclusions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Exclusions), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe FreezeAxis m_FreezeAxis
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreezeAxis);
			return *(FreezeAxis*)num;
		}
		set
		{
			*(FreezeAxis*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreezeAxis)) = freezeAxis;
		}
	}

	public unsafe bool m_DistantDisable
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistantDisable);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistantDisable)) = flag;
		}
	}

	public unsafe Transform m_ReferenceObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReferenceObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Transform>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ReferenceObject), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_DistanceToObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistanceToObject);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistanceToObject)) = num;
		}
	}

	public unsafe bool m_Multithread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Multithread);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Multithread)) = flag;
		}
	}

	public unsafe Vector3 m_ObjectMove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectMove);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectMove)) = vector;
		}
	}

	public unsafe Vector3 m_ObjectPrevPosition
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectPrevPosition);
			return *(Vector3*)num;
		}
		set
		{
			*(Vector3*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectPrevPosition)) = vector;
		}
	}

	public unsafe float m_ObjectScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ObjectScale)) = num;
		}
	}

	public unsafe float m_Time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Time)) = num;
		}
	}

	public unsafe float m_Weight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Weight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Weight)) = num;
		}
	}

	public unsafe bool m_DistantDisabled
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistantDisabled);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DistantDisabled)) = flag;
		}
	}

	public unsafe int m_PreUpdateCount
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreUpdateCount);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreUpdateCount)) = num;
		}
	}

	public unsafe List<ParticleTree> m_ParticleTrees
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParticleTrees);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ParticleTree>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ParticleTrees), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe float m_DeltaTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeltaTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DeltaTime)) = num;
		}
	}

	public unsafe List<DynamicBoneColliderBase> m_EffectiveColliders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EffectiveColliders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicBoneColliderBase>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EffectiveColliders), IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe bool m_WorkAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorkAdded);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorkAdded)) = flag;
		}
	}

	public unsafe static List<DynamicBone> s_PendingWorks
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PendingWorks, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicBone>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PendingWorks, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static List<DynamicBone> s_EffectiveWorks
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_EffectiveWorks, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<DynamicBone>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_EffectiveWorks, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static AutoResetEvent s_AllWorksDoneEvent
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_AllWorksDoneEvent, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AutoResetEvent>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_AllWorksDoneEvent, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int s_RemainWorkCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RemainWorkCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RemainWorkCount, &num);
		}
	}

	public unsafe static Semaphore s_WorkQueueSemaphore
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_WorkQueueSemaphore, &intPtr);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Semaphore>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_WorkQueueSemaphore, (void*)IL2CPP.Il2CppObjectBaseToPtr(obj));
		}
	}

	public unsafe static int s_WorkQueueIndex
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_WorkQueueIndex, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_WorkQueueIndex, &num);
		}
	}

	public unsafe static int s_UpdateCount
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_UpdateCount, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_UpdateCount, &num);
		}
	}

	public unsafe static int s_PrepareFrame
	{
		get
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_PrepareFrame, &result);
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_PrepareFrame, &num);
		}
	}

	public unsafe bool isInitAnimationCurveKeyLenght
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitAnimationCurveKeyLenght);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isInitAnimationCurveKeyLenght)) = flag;
		}
	}

	public unsafe int dampKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dampKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dampKeyLength)) = num;
		}
	}

	public unsafe int elasKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elasKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_elasKeyLength)) = num;
		}
	}

	public unsafe int stiffKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_stiffKeyLength)) = num;
		}
	}

	public unsafe int inertKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_inertKeyLength)) = num;
		}
	}

	public unsafe int frictKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_frictKeyLength)) = num;
		}
	}

	public unsafe int radiusKeyLength
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radiusKeyLength);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_radiusKeyLength)) = num;
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227, XrefRangeEnd = 228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228, XrefRangeEnd = 229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229, XrefRangeEnd = 242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242, XrefRangeEnd = 260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 322, RefRangeEnd = 324, XrefRangeStart = 260, XrefRangeEnd = 322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Prepare()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prepare_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe bool IsNeedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsNeedUpdate_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 324, XrefRangeEnd = 325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PreUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PreUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 361, RefRangeEnd = 363, XrefRangeStart = 325, XrefRangeEnd = 361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDistance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CheckDistance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363, XrefRangeEnd = 364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364, XrefRangeEnd = 365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365, XrefRangeEnd = 373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnValidate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373, XrefRangeEnd = 428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsRootChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsRootChanged_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(bool*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 428, XrefRangeEnd = 429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDidApplyAnimationProperties()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 429, XrefRangeEnd = 440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 448, RefRangeEnd = 449, XrefRangeStart = 440, XrefRangeEnd = 448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawGizmos([DefaultParameterValue(null)] ParticleTree pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DrawGizmos_Private_Void_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449, XrefRangeEnd = 452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWeight([DefaultParameterValue(null)] float w)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&w);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWeight_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe float GetWeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWeight_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(float*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 466, RefRangeEnd = 468, XrefRangeStart = 452, XrefRangeEnd = 466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParticles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParticles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 530, RefRangeEnd = 531, XrefRangeStart = 468, XrefRangeEnd = 530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetupParticles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetupParticles_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 554, RefRangeEnd = 556, XrefRangeStart = 531, XrefRangeEnd = 554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppendParticleTree([DefaultParameterValue(null)] Transform root)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(root);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendParticleTree_Private_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 649, RefRangeEnd = 651, XrefRangeStart = 556, XrefRangeEnd = 649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AppendParticles([DefaultParameterValue(null)] ParticleTree pt, [DefaultParameterValue(null)] Transform b, [DefaultParameterValue(null)] int parentIndex, [DefaultParameterValue(null)] float boneLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr(b);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &parentIndex;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &boneLength;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AppendParticles_Private_Void_ParticleTree_Transform_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 658, RefRangeEnd = 663, XrefRangeStart = 651, XrefRangeEnd = 658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParameters()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 675, RefRangeEnd = 676, XrefRangeStart = 663, XrefRangeEnd = 675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitKey()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 696, RefRangeEnd = 697, XrefRangeStart = 676, XrefRangeEnd = 696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParameters([DefaultParameterValue(null)] ParticleTree pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParameters_Private_Void_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 707, RefRangeEnd = 715, XrefRangeStart = 697, XrefRangeEnd = 707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 715, XrefRangeEnd = 722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitTransforms([DefaultParameterValue(null)] ParticleTree pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitTransforms_Private_Void_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 730, RefRangeEnd = 736, XrefRangeStart = 722, XrefRangeEnd = 730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetParticlesPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 745, RefRangeEnd = 746, XrefRangeStart = 736, XrefRangeEnd = 745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetParticlesPosition([DefaultParameterValue(null)] ParticleTree pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746, XrefRangeEnd = 750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParticles1([DefaultParameterValue(null)] float timeVar, [DefaultParameterValue(null)] int loopIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&timeVar);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParticles1_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 758, RefRangeEnd = 760, XrefRangeStart = 750, XrefRangeEnd = 758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParticles1([DefaultParameterValue(null)] ParticleTree pt, [DefaultParameterValue(null)] float timeVar, [DefaultParameterValue(null)] int loopIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeVar;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &loopIndex;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParticles1_Private_Void_ParticleTree_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 760, XrefRangeEnd = 764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParticles2([DefaultParameterValue(null)] float timeVar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&timeVar);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParticles2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 781, RefRangeEnd = 783, XrefRangeStart = 764, XrefRangeEnd = 781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateParticles2([DefaultParameterValue(null)] ParticleTree pt, [DefaultParameterValue(null)] float timeVar)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeVar;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateParticles2_Private_Void_ParticleTree_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783, XrefRangeEnd = 787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipUpdateParticles()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 798, RefRangeEnd = 800, XrefRangeStart = 787, XrefRangeEnd = 798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipUpdateParticles([DefaultParameterValue(null)] ParticleTree pt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_ParticleTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	public unsafe static Vector3 MirrorVector([DefaultParameterValue(null)] Vector3 v, [DefaultParameterValue(null)] Vector3 axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&v);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MirrorVector_Private_Static_Vector3_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(obj);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 810, RefRangeEnd = 812, XrefRangeStart = 800, XrefRangeEnd = 810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyParticlesToTransforms()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 828, RefRangeEnd = 829, XrefRangeStart = 812, XrefRangeEnd = 828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyParticlesToTransforms([DefaultParameterValue(null)] ParticleTree pt, [DefaultParameterValue(null)] Vector3 ax, [DefaultParameterValue(null)] Vector3 ay, [DefaultParameterValue(null)] Vector3 az, [DefaultParameterValue(null)] bool nx, [DefaultParameterValue(null)] bool ny, [DefaultParameterValue(null)] bool nz)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pt);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ax;
		*(Vector3**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &ay;
		*(Vector3**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &az;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &nx;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &ny;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &nz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_ParticleTree_Vector3_Vector3_Vector3_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 829, XrefRangeEnd = 836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddPendingWork([DefaultParameterValue(null)] DynamicBone db)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(db);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddPendingWork_Private_Static_Void_DynamicBone_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836, XrefRangeEnd = 842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddWorkToQueue([DefaultParameterValue(null)] DynamicBone db)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(db);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddWorkToQueue_Private_Static_Void_DynamicBone_0, (System.IntPtr)0, (void**)ptr, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842, XrefRangeEnd = 848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DynamicBone GetWorkFromQueue()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetWorkFromQueue_Private_Static_DynamicBone_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DynamicBone>(intPtr) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 848, XrefRangeEnd = 872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThreadProc()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 899, RefRangeEnd = 900, XrefRangeStart = 872, XrefRangeEnd = 899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitThreadPool()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitThreadPool_Private_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 961, RefRangeEnd = 962, XrefRangeStart = 900, XrefRangeEnd = 961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ExecuteWorks()
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExecuteWorks_Private_Static_Void_0, (System.IntPtr)0, (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 962, XrefRangeEnd = 977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DynamicBone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr))
	{
		System.IntPtr* param = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr exc);
		System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref exc);
		Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(exc);
	}

	static DynamicBone()
	{
		Il2CppClassPointerStore<DynamicBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DynamicBone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr);
		NativeFieldInfoPtr_m_Root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Root");
		NativeFieldInfoPtr_m_Roots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Roots");
		NativeFieldInfoPtr_m_UpdateRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_UpdateRate");
		NativeFieldInfoPtr_m_UpdateMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_UpdateMode");
		NativeFieldInfoPtr_m_Damping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Damping");
		NativeFieldInfoPtr_m_DampingDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_DampingDistrib");
		NativeFieldInfoPtr_m_Elasticity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Elasticity");
		NativeFieldInfoPtr_m_ElasticityDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ElasticityDistrib");
		NativeFieldInfoPtr_m_Stiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Stiffness");
		NativeFieldInfoPtr_m_StiffnessDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_StiffnessDistrib");
		NativeFieldInfoPtr_m_Inert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Inert");
		NativeFieldInfoPtr_m_InertDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_InertDistrib");
		NativeFieldInfoPtr_m_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Friction");
		NativeFieldInfoPtr_m_FrictionDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_FrictionDistrib");
		NativeFieldInfoPtr_m_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Radius");
		NativeFieldInfoPtr_m_RadiusDistrib = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_RadiusDistrib");
		NativeFieldInfoPtr_m_EndLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_EndLength");
		NativeFieldInfoPtr_m_EndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_EndOffset");
		NativeFieldInfoPtr_m_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Gravity");
		NativeFieldInfoPtr_m_Force = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Force");
		NativeFieldInfoPtr_m_BlendWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_BlendWeight");
		NativeFieldInfoPtr_m_Colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Colliders");
		NativeFieldInfoPtr_m_Exclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Exclusions");
		NativeFieldInfoPtr_m_FreezeAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_FreezeAxis");
		NativeFieldInfoPtr_m_DistantDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_DistantDisable");
		NativeFieldInfoPtr_m_ReferenceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ReferenceObject");
		NativeFieldInfoPtr_m_DistanceToObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_DistanceToObject");
		NativeFieldInfoPtr_m_Multithread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Multithread");
		NativeFieldInfoPtr_m_ObjectMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ObjectMove");
		NativeFieldInfoPtr_m_ObjectPrevPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ObjectPrevPosition");
		NativeFieldInfoPtr_m_ObjectScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ObjectScale");
		NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Time");
		NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_Weight");
		NativeFieldInfoPtr_m_DistantDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_DistantDisabled");
		NativeFieldInfoPtr_m_PreUpdateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_PreUpdateCount");
		NativeFieldInfoPtr_m_ParticleTrees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_ParticleTrees");
		NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_DeltaTime");
		NativeFieldInfoPtr_m_EffectiveColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_EffectiveColliders");
		NativeFieldInfoPtr_m_WorkAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "m_WorkAdded");
		NativeFieldInfoPtr_s_PendingWorks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_PendingWorks");
		NativeFieldInfoPtr_s_EffectiveWorks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_EffectiveWorks");
		NativeFieldInfoPtr_s_AllWorksDoneEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_AllWorksDoneEvent");
		NativeFieldInfoPtr_s_RemainWorkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_RemainWorkCount");
		NativeFieldInfoPtr_s_WorkQueueSemaphore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_WorkQueueSemaphore");
		NativeFieldInfoPtr_s_WorkQueueIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_WorkQueueIndex");
		NativeFieldInfoPtr_s_UpdateCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_UpdateCount");
		NativeFieldInfoPtr_s_PrepareFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "s_PrepareFrame");
		NativeFieldInfoPtr_isInitAnimationCurveKeyLenght = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "isInitAnimationCurveKeyLenght");
		NativeFieldInfoPtr_dampKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "dampKeyLength");
		NativeFieldInfoPtr_elasKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "elasKeyLength");
		NativeFieldInfoPtr_stiffKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "stiffKeyLength");
		NativeFieldInfoPtr_inertKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "inertKeyLength");
		NativeFieldInfoPtr_frictKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "frictKeyLength");
		NativeFieldInfoPtr_radiusKeyLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, "radiusKeyLength");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663312);
		NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663313);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663314);
		NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663315);
		NativeMethodInfoPtr_Prepare_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_IsNeedUpdate_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_PreUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_CheckDistance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663321);
		NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663322);
		NativeMethodInfoPtr_IsRootChanged_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663323);
		NativeMethodInfoPtr_OnDidApplyAnimationProperties_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663324);
		NativeMethodInfoPtr_OnDrawGizmosSelected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663325);
		NativeMethodInfoPtr_DrawGizmos_Private_Void_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663326);
		NativeMethodInfoPtr_SetWeight_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_GetWeight_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_UpdateParticles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_SetupParticles_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_AppendParticleTree_Private_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_AppendParticles_Private_Void_ParticleTree_Transform_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_InitKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_UpdateParameters_Private_Void_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_InitTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_InitTransforms_Private_Void_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_ResetParticlesPosition_Private_Void_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_UpdateParticles1_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_UpdateParticles1_Private_Void_ParticleTree_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_UpdateParticles2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_UpdateParticles2_Private_Void_ParticleTree_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_SkipUpdateParticles_Private_Void_ParticleTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_MirrorVector_Private_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_ApplyParticlesToTransforms_Private_Void_ParticleTree_Vector3_Vector3_Vector3_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_AddPendingWork_Private_Static_Void_DynamicBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr_AddWorkToQueue_Private_Static_Void_DynamicBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_GetWorkFromQueue_Private_Static_DynamicBone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_ThreadProc_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_InitThreadPool_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_ExecuteWorks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicBone>.NativeClassPtr, 100663355);
	}

	public DynamicBone(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
