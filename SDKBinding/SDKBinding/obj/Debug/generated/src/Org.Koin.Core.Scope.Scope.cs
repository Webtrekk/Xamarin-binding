using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Scope {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']"
	[global::Android.Runtime.Register ("org/koin/core/scope/Scope", DoNotGenerateAcw=true)]
	public sealed partial class Scope : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/scope/Scope", typeof (Scope));
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

		internal Scope (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/constructor[@name='Scope' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Z)V", "")]
		public unsafe Scope (string id, string uuid, bool isDetached)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_uuid = JNIEnv.NewString (uuid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_uuid);
				__args [2] = new JniArgumentValue (isDetached);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_uuid);
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsDetached {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='isDetached' and count(parameter)=0]"
			[Register ("isDetached", "()Z", "GetIsDetachedHandler")]
			get {
				const string __id = "isDetached.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Parameters {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='getParameters' and count(parameter)=0]"
			[Register ("getParameters", "()Ljava/util/HashMap;", "GetGetParametersHandler")]
			get {
				const string __id = "getParameters.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Uuid {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='getUuid' and count(parameter)=0]"
			[Register ("getUuid", "()Ljava/lang/String;", "GetGetUuidHandler")]
			get {
				const string __id = "getUuid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='component1' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Z", "")]
		public unsafe bool Component3 ()
		{
			const string __id = "component3.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='Scope']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("copy", "(Ljava/lang/String;Ljava/lang/String;Z)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope Copy (string id, string uuid, bool isDetached)
		{
			const string __id = "copy.(Ljava/lang/String;Ljava/lang/String;Z)Lorg/koin/core/scope/Scope;";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_uuid = JNIEnv.NewString (uuid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_uuid);
				__args [2] = new JniArgumentValue (isDetached);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_uuid);
			}
		}

	}
}
