using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Scope {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']"
	[global::Android.Runtime.Register ("org/koin/core/scope/ScopeRegistry", DoNotGenerateAcw=true)]
	public sealed partial class ScopeRegistry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/scope/ScopeRegistry", typeof (ScopeRegistry));
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

		internal ScopeRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/constructor[@name='ScopeRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScopeRegistry ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='createAndDetachScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createAndDetachScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope CreateAndDetachScope (string id)
		{
			const string __id = "createAndDetachScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='createScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("createScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope CreateScope (string id)
		{
			const string __id = "createScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='deleteScope' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteScope", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void DeleteScope (string id, string uuid)
		{
			const string __id = "deleteScope.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			IntPtr native_uuid = JNIEnv.NewString (uuid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue (native_uuid);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				JNIEnv.DeleteLocalRef (native_uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='getDetachScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetachScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope GetDetachScope (string uuid)
		{
			const string __id = "getDetachScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
			IntPtr native_uuid = JNIEnv.NewString (uuid);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_uuid);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_uuid);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='getOrCreateScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getOrCreateScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope GetOrCreateScope (string id)
		{
			const string __id = "getOrCreateScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='getScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope GetScope (string id)
		{
			const string __id = "getScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='ScopeRegistry']/method[@name='register' and count(parameter)=1 and parameter[1][@type='org.koin.core.scope.ScopeCallback']]"
		[Register ("register", "(Lorg/koin/core/scope/ScopeCallback;)V", "")]
		public unsafe void Register (global::Org.Koin.Core.Scope.IScopeCallback @callback)
		{
			const string __id = "register.(Lorg/koin/core/scope/ScopeCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
