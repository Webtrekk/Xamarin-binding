using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']"
	[global::Android.Runtime.Register ("org/koin/core/KoinContext", DoNotGenerateAcw=true)]
	public sealed partial class KoinContext : global::Java.Lang.Object, global::Org.Koin.Standalone.IStandAloneKoinContext {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext.Companion']"
		[global::Android.Runtime.Register ("org/koin/core/KoinContext$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/KoinContext$Companion", typeof (Companion));
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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext.Companion']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.koin.core.instance.InstanceFactory']]"
			[Register ("create", "(Lorg/koin/core/instance/InstanceFactory;)Lorg/koin/core/KoinContext;", "")]
			public unsafe global::Org.Koin.Core.KoinContext Create (global::Org.Koin.Core.Instance.InstanceFactory instanceFactory)
			{
				const string __id = "create.(Lorg/koin/core/instance/InstanceFactory;)Lorg/koin/core/KoinContext;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((instanceFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instanceFactory).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/KoinContext", typeof (KoinContext));
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

		internal KoinContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Org.Koin.Core.Instance.InstanceRegistry InstanceRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getInstanceRegistry' and count(parameter)=0]"
			[Register ("getInstanceRegistry", "()Lorg/koin/core/instance/InstanceRegistry;", "GetGetInstanceRegistryHandler")]
			get {
				const string __id = "getInstanceRegistry.()Lorg/koin/core/instance/InstanceRegistry;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.InstanceRegistry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Property.PropertyRegistry PropertyResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getPropertyResolver' and count(parameter)=0]"
			[Register ("getPropertyResolver", "()Lorg/koin/core/property/PropertyRegistry;", "GetGetPropertyResolverHandler")]
			get {
				const string __id = "getPropertyResolver.()Lorg/koin/core/property/PropertyRegistry;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Property.PropertyRegistry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Scope.ScopeRegistry ScopeRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getScopeRegistry' and count(parameter)=0]"
			[Register ("getScopeRegistry", "()Lorg/koin/core/scope/ScopeRegistry;", "GetGetScopeRegistryHandler")]
			get {
				const string __id = "getScopeRegistry.()Lorg/koin/core/scope/ScopeRegistry;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.ScopeRegistry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='createScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='detachScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("detachScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope DetachScope (string id)
		{
			const string __id = "detachScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getDetachedScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDetachedScope", "(Ljava/lang/String;)Lorg/koin/core/scope/Scope;", "")]
		public unsafe global::Org.Koin.Core.Scope.Scope GetDetachedScope (string uuid)
		{
			const string __id = "getDetachedScope.(Ljava/lang/String;)Lorg/koin/core/scope/Scope;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getOrCreateScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetProperty (string key)
		{
			const string __id = "getProperty.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("getProperty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetProperty (string key, global::Java.Lang.Object defaultValue)
		{
			const string __id = "getProperty.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='getScope' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='release' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("release", "(Ljava/lang/String;)V", "")]
		public unsafe void Release (string path)
		{
			const string __id = "release.(Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinContext']/method[@name='setProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("setProperty", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe void SetProperty (string key, global::Java.Lang.Object value)
		{
			const string __id = "setProperty.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
