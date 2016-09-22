// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// PhysicsWorld.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Physics
{
	/// <summary>
	/// Physics simulation world component. Should be added only to the root scene node.
	/// </summary>
	public unsafe partial class PhysicsWorld : Component
	{
		public PhysicsWorld (IntPtr handle) : base (handle)
		{
		}

		protected PhysicsWorld (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (PhysicsWorld_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr PhysicsWorld_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (PhysicsWorld_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(PhysicsWorld));
			return new StringHash (PhysicsWorld_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr PhysicsWorld_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(PhysicsWorld));
			return Marshal.PtrToStringAnsi (PhysicsWorld_GetTypeNameStatic ());
		}

		public PhysicsWorld () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr PhysicsWorld_PhysicsWorld (IntPtr scontext);

		public PhysicsWorld (Context scontext) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(PhysicsWorld));
			handle = PhysicsWorld_PhysicsWorld ((object)scontext == null ? IntPtr.Zero : scontext.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(PhysicsWorld));
			PhysicsWorld_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_setDebugMode (IntPtr handle, int debugMode);

		/// <summary>
		/// Set debug draw flags.
		/// </summary>
		public void setDebugMode (int debugMode)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_setDebugMode (handle, debugMode);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_getDebugMode (IntPtr handle);

		/// <summary>
		/// Return debug draw flags.
		/// </summary>
		public int getDebugMode ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_getDebugMode (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_DrawDebugGeometry (IntPtr handle, IntPtr debug, bool depthTest);

		/// <summary>
		/// Visualize the component as debug geometry.
		/// </summary>
		public override void DrawDebugGeometry (DebugRenderer debug, bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_DrawDebugGeometry (handle, (object)debug == null ? IntPtr.Zero : debug.Handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Step the simulation forward.
		/// </summary>
		public void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_UpdateCollisions (IntPtr handle);

		/// <summary>
		/// Refresh collisions only without updating dynamics.
		/// </summary>
		public void UpdateCollisions ()
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_UpdateCollisions (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetFps (IntPtr handle, int fps);

		/// <summary>
		/// Set simulation substeps per second.
		/// </summary>
		private void SetFps (int fps)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetFps (handle, fps);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetGravity (IntPtr handle, ref Urho.Vector3 gravity);

		/// <summary>
		/// Set gravity.
		/// </summary>
		public void SetGravity (Urho.Vector3 gravity)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetGravity (handle, ref gravity);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetMaxSubSteps (IntPtr handle, int num);

		/// <summary>
		/// Set maximum number of physics substeps per frame. 0 (default) is unlimited. Positive values cap the amount. Use a negative value to enable an adaptive timestep. This may cause inconsistent physics behavior.
		/// </summary>
		private void SetMaxSubSteps (int num)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetMaxSubSteps (handle, num);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetNumIterations (IntPtr handle, int num);

		/// <summary>
		/// Set number of constraint solver iterations.
		/// </summary>
		private void SetNumIterations (int num)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetNumIterations (handle, num);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetUpdateEnabled (IntPtr handle, bool enable);

		/// <summary>
		/// Enable or disable automatic physics simulation during scene update. Enabled by default.
		/// </summary>
		private void SetUpdateEnabled (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetUpdateEnabled (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetInterpolation (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether to interpolate between simulation steps.
		/// </summary>
		private void SetInterpolation (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetInterpolation (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetInternalEdge (IntPtr handle, bool enable);

		/// <summary>
		/// Set whether to use Bullet's internal edge utility for trimesh collisions. Disabled by default.
		/// </summary>
		private void SetInternalEdge (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetInternalEdge (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetSplitImpulse (IntPtr handle, bool enable);

		/// <summary>
		/// Set split impulse collision mode. This is more accurate, but slower. Disabled by default.
		/// </summary>
		private void SetSplitImpulse (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetSplitImpulse (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetMaxNetworkAngularVelocity (IntPtr handle, float velocity);

		/// <summary>
		/// Set maximum angular velocity for network replication.
		/// </summary>
		private void SetMaxNetworkAngularVelocity (float velocity)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetMaxNetworkAngularVelocity (handle, velocity);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RaycastSingle (IntPtr handle, ref PhysicsRaycastResult result, ref Urho.Ray ray, float maxDistance, uint collisionMask);

		/// <summary>
		/// Perform a physics world raycast and return the closest hit.
		/// </summary>
		public void RaycastSingle (ref PhysicsRaycastResult result, Urho.Ray ray, float maxDistance, uint collisionMask)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RaycastSingle (handle, ref result, ref ray, maxDistance, collisionMask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RaycastSingleSegmented (IntPtr handle, ref PhysicsRaycastResult result, ref Urho.Ray ray, float maxDistance, float segmentDistance, uint collisionMask);

		/// <summary>
		/// Perform a physics world segmented raycast and return the closest hit. Useful for big scenes with many bodies.
		/// </summary>
		public void RaycastSingleSegmented (ref PhysicsRaycastResult result, Urho.Ray ray, float maxDistance, float segmentDistance, uint collisionMask)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RaycastSingleSegmented (handle, ref result, ref ray, maxDistance, segmentDistance, collisionMask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SphereCast (IntPtr handle, ref PhysicsRaycastResult result, ref Urho.Ray ray, float radius, float maxDistance, uint collisionMask);

		/// <summary>
		/// Perform a physics world swept sphere test and return the closest hit.
		/// </summary>
		public void SphereCast (ref PhysicsRaycastResult result, Urho.Ray ray, float radius, float maxDistance, uint collisionMask)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SphereCast (handle, ref result, ref ray, radius, maxDistance, collisionMask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_ConvexCast (IntPtr handle, ref PhysicsRaycastResult result, IntPtr shape, ref Urho.Vector3 startPos, ref Urho.Quaternion startRot, ref Urho.Vector3 endPos, ref Urho.Quaternion endRot, uint collisionMask);

		/// <summary>
		/// Perform a physics world swept convex test using a user-supplied collision shape and return the first hit.
		/// </summary>
		public void ConvexCast (ref PhysicsRaycastResult result, CollisionShape shape, Urho.Vector3 startPos, Urho.Quaternion startRot, Urho.Vector3 endPos, Urho.Quaternion endRot, uint collisionMask)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_ConvexCast (handle, ref result, (object)shape == null ? IntPtr.Zero : shape.Handle, ref startPos, ref startRot, ref endPos, ref endRot, collisionMask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RemoveCachedGeometry (IntPtr handle, IntPtr model);

		/// <summary>
		/// Invalidate cached collision geometry for a model.
		/// </summary>
		public void RemoveCachedGeometry (Model model)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RemoveCachedGeometry (handle, (object)model == null ? IntPtr.Zero : model.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 PhysicsWorld_GetGravity (IntPtr handle);

		/// <summary>
		/// Return gravity.
		/// </summary>
		private Vector3 GetGravity ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetGravity (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_GetMaxSubSteps (IntPtr handle);

		/// <summary>
		/// Return maximum number of physics substeps per frame.
		/// </summary>
		private int GetMaxSubSteps ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetMaxSubSteps (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_GetNumIterations (IntPtr handle);

		/// <summary>
		/// Return number of constraint solver iterations.
		/// </summary>
		private int GetNumIterations ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetNumIterations (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_IsUpdateEnabled (IntPtr handle);

		/// <summary>
		/// Return whether physics world will automatically simulate during scene update.
		/// </summary>
		private bool IsUpdateEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_IsUpdateEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_GetInterpolation (IntPtr handle);

		/// <summary>
		/// Return whether interpolation between simulation steps is enabled.
		/// </summary>
		private bool GetInterpolation ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetInterpolation (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_GetInternalEdge (IntPtr handle);

		/// <summary>
		/// Return whether Bullet's internal edge utility for trimesh collisions is enabled.
		/// </summary>
		private bool GetInternalEdge ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetInternalEdge (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_GetSplitImpulse (IntPtr handle);

		/// <summary>
		/// Return whether split impulse collision mode is enabled.
		/// </summary>
		private bool GetSplitImpulse ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetSplitImpulse (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int PhysicsWorld_GetFps (IntPtr handle);

		/// <summary>
		/// Return simulation steps per second.
		/// </summary>
		private int GetFps ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetFps (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float PhysicsWorld_GetMaxNetworkAngularVelocity (IntPtr handle);

		/// <summary>
		/// Return maximum angular velocity for network replication.
		/// </summary>
		private float GetMaxNetworkAngularVelocity ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_GetMaxNetworkAngularVelocity (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_AddRigidBody (IntPtr handle, IntPtr body);

		/// <summary>
		/// Add a rigid body to keep track of. Called by RigidBody.
		/// </summary>
		public void AddRigidBody (RigidBody body)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_AddRigidBody (handle, (object)body == null ? IntPtr.Zero : body.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RemoveRigidBody (IntPtr handle, IntPtr body);

		/// <summary>
		/// Remove a rigid body. Called by RigidBody.
		/// </summary>
		public void RemoveRigidBody (RigidBody body)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RemoveRigidBody (handle, (object)body == null ? IntPtr.Zero : body.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_AddCollisionShape (IntPtr handle, IntPtr shape);

		/// <summary>
		/// Add a collision shape to keep track of. Called by CollisionShape.
		/// </summary>
		public void AddCollisionShape (CollisionShape shape)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_AddCollisionShape (handle, (object)shape == null ? IntPtr.Zero : shape.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RemoveCollisionShape (IntPtr handle, IntPtr shape);

		/// <summary>
		/// Remove a collision shape. Called by CollisionShape.
		/// </summary>
		public void RemoveCollisionShape (CollisionShape shape)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RemoveCollisionShape (handle, (object)shape == null ? IntPtr.Zero : shape.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_AddConstraint (IntPtr handle, IntPtr joint);

		/// <summary>
		/// Add a constraint to keep track of. Called by Constraint.
		/// </summary>
		public void AddConstraint (Constraint joint)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_AddConstraint (handle, (object)joint == null ? IntPtr.Zero : joint.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_RemoveConstraint (IntPtr handle, IntPtr joint);

		/// <summary>
		/// Remove a constraint. Called by Constraint.
		/// </summary>
		public void RemoveConstraint (Constraint joint)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_RemoveConstraint (handle, (object)joint == null ? IntPtr.Zero : joint.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_DrawDebugGeometry0 (IntPtr handle, bool depthTest);

		/// <summary>
		/// Add debug geometry to the debug renderer.
		/// </summary>
		public void DrawDebugGeometry (bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_DrawDebugGeometry0 (handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetDebugRenderer (IntPtr handle, IntPtr debug);

		/// <summary>
		/// Set debug renderer to use. Called both by PhysicsWorld itself and physics components.
		/// </summary>
		public void SetDebugRenderer (DebugRenderer debug)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetDebugRenderer (handle, (object)debug == null ? IntPtr.Zero : debug.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetDebugDepthTest (IntPtr handle, bool enable);

		/// <summary>
		/// Set debug geometry depth test mode. Called both by PhysicsWorld itself and physics components.
		/// </summary>
		public void SetDebugDepthTest (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetDebugDepthTest (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_CleanupGeometryCache (IntPtr handle);

		/// <summary>
		/// Clean up the geometry cache.
		/// </summary>
		public void CleanupGeometryCache ()
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_CleanupGeometryCache (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void PhysicsWorld_SetApplyingTransforms (IntPtr handle, bool enable);

		/// <summary>
		/// Set node dirtying to be disregarded.
		/// </summary>
		private void SetApplyingTransforms (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			PhysicsWorld_SetApplyingTransforms (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_IsApplyingTransforms (IntPtr handle);

		/// <summary>
		/// Return whether node dirtying should be disregarded.
		/// </summary>
		private bool IsApplyingTransforms ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_IsApplyingTransforms (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool PhysicsWorld_IsSimulating (IntPtr handle);

		/// <summary>
		/// Return whether is currently inside the Bullet substep loop.
		/// </summary>
		private bool IsSimulating ()
		{
			Runtime.ValidateRefCounted (this);
			return PhysicsWorld_IsSimulating (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return simulation steps per second.
		/// Or
		/// Set simulation substeps per second.
		/// </summary>
		public int Fps {
			get {
				return GetFps ();
			}
			set {
				SetFps (value);
			}
		}

		/// <summary>
		/// Return gravity.
		/// </summary>
		public Vector3 Gravity {
			get {
				return GetGravity ();
			}
		}

		/// <summary>
		/// Return maximum number of physics substeps per frame.
		/// Or
		/// Set maximum number of physics substeps per frame. 0 (default) is unlimited. Positive values cap the amount. Use a negative value to enable an adaptive timestep. This may cause inconsistent physics behavior.
		/// </summary>
		public int MaxSubSteps {
			get {
				return GetMaxSubSteps ();
			}
			set {
				SetMaxSubSteps (value);
			}
		}

		/// <summary>
		/// Return number of constraint solver iterations.
		/// Or
		/// Set number of constraint solver iterations.
		/// </summary>
		public int NumIterations {
			get {
				return GetNumIterations ();
			}
			set {
				SetNumIterations (value);
			}
		}

		/// <summary>
		/// Return whether physics world will automatically simulate during scene update.
		/// Or
		/// Enable or disable automatic physics simulation during scene update. Enabled by default.
		/// </summary>
		public bool UpdateEnabled {
			get {
				return IsUpdateEnabled ();
			}
			set {
				SetUpdateEnabled (value);
			}
		}

		/// <summary>
		/// Return whether interpolation between simulation steps is enabled.
		/// Or
		/// Set whether to interpolate between simulation steps.
		/// </summary>
		public bool Interpolation {
			get {
				return GetInterpolation ();
			}
			set {
				SetInterpolation (value);
			}
		}

		/// <summary>
		/// Return whether Bullet's internal edge utility for trimesh collisions is enabled.
		/// Or
		/// Set whether to use Bullet's internal edge utility for trimesh collisions. Disabled by default.
		/// </summary>
		public bool InternalEdge {
			get {
				return GetInternalEdge ();
			}
			set {
				SetInternalEdge (value);
			}
		}

		/// <summary>
		/// Return whether split impulse collision mode is enabled.
		/// Or
		/// Set split impulse collision mode. This is more accurate, but slower. Disabled by default.
		/// </summary>
		public bool SplitImpulse {
			get {
				return GetSplitImpulse ();
			}
			set {
				SetSplitImpulse (value);
			}
		}

		/// <summary>
		/// Return maximum angular velocity for network replication.
		/// Or
		/// Set maximum angular velocity for network replication.
		/// </summary>
		public float MaxNetworkAngularVelocity {
			get {
				return GetMaxNetworkAngularVelocity ();
			}
			set {
				SetMaxNetworkAngularVelocity (value);
			}
		}

		/// <summary>
		/// Return whether node dirtying should be disregarded.
		/// Or
		/// Set node dirtying to be disregarded.
		/// </summary>
		public bool ApplyingTransforms {
			get {
				return IsApplyingTransforms ();
			}
			set {
				SetApplyingTransforms (value);
			}
		}

		/// <summary>
		/// Return whether is currently inside the Bullet substep loop.
		/// </summary>
		public bool Simulating {
			get {
				return IsSimulating ();
			}
		}
	}
}