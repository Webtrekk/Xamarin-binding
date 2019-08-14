using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRequest']"
	[global::Android.Runtime.Register ("org/koin/core/instance/InstanceRequest", DoNotGenerateAcw=true)]
	public sealed partial class InstanceRequest : global::Org.Koin.Core.Instance.ResolutionRequest {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/InstanceRequest", typeof (InstanceRequest));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal InstanceRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRequest']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Scope.Scope Scope {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRequest']/method[@name='getScope' and count(parameter)=0]"
			[Register ("getScope", "()Lorg/koin/core/scope/Scope;", "GetGetScopeHandler")]
			get {
				const string __id = "getScope.()Lorg/koin/core/scope/Scope;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRequest']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRequest']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope Component3 ()
		{
			const string __id = "component3.()Lorg/koin/core/scope/Scope;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
