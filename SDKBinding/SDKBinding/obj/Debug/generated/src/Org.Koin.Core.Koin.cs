using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']"
	[global::Android.Runtime.Register ("org/koin/core/Koin", DoNotGenerateAcw=true)]
	public sealed partial class Koin : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core']/class[@name='Koin.Companion']"
		[global::Android.Runtime.Register ("org/koin/core/Koin$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/Koin$Companion", typeof (Companion));
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

			public unsafe global::Org.Koin.Log.ILogger Logger {
				// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin.Companion']/method[@name='getLogger' and count(parameter)=0]"
				[Register ("getLogger", "()Lorg/koin/log/Logger;", "GetGetLoggerHandler")]
				get {
					const string __id = "getLogger.()Lorg/koin/log/Logger;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Org.Koin.Log.ILogger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin.Companion']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='org.koin.log.Logger']]"
				[Register ("setLogger", "(Lorg/koin/log/Logger;)V", "GetSetLogger_Lorg_koin_log_Logger_Handler")]
				set {
					const string __id = "setLogger.(Lorg/koin/log/Logger;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin.Companion']/method[@name='create' and count(parameter)=1 and parameter[1][@type='org.koin.core.KoinContext']]"
			[Register ("create", "(Lorg/koin/core/KoinContext;)Lorg/koin/core/Koin;", "")]
			public unsafe global::Org.Koin.Core.Koin Create (global::Org.Koin.Core.KoinContext koinContext)
			{
				const string __id = "create.(Lorg/koin/core/KoinContext;)Lorg/koin/core/Koin;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((koinContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) koinContext).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Koin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/Koin", typeof (Koin));
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

		internal Koin (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Org.Koin.Core.Bean.BeanRegistry BeanRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='getBeanRegistry' and count(parameter)=0]"
			[Register ("getBeanRegistry", "()Lorg/koin/core/bean/BeanRegistry;", "GetGetBeanRegistryHandler")]
			get {
				const string __id = "getBeanRegistry.()Lorg/koin/core/bean/BeanRegistry;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Bean.BeanRegistry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Instance.InstanceFactory InstanceFactory {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='getInstanceFactory' and count(parameter)=0]"
			[Register ("getInstanceFactory", "()Lorg/koin/core/instance/InstanceFactory;", "GetGetInstanceFactoryHandler")]
			get {
				const string __id = "getInstanceFactory.()Lorg/koin/core/instance/InstanceFactory;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.InstanceFactory> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.KoinContext KoinContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='getKoinContext' and count(parameter)=0]"
			[Register ("getKoinContext", "()Lorg/koin/core/KoinContext;", "GetGetKoinContextHandler")]
			get {
				const string __id = "getKoinContext.()Lorg/koin/core/KoinContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Path.PathRegistry PathRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='getPathRegistry' and count(parameter)=0]"
			[Register ("getPathRegistry", "()Lorg/koin/core/path/PathRegistry;", "GetGetPathRegistryHandler")]
			get {
				const string __id = "getPathRegistry.()Lorg/koin/core/path/PathRegistry;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Path.PathRegistry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.Property.PropertyRegistry PropertyResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='getPropertyResolver' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='declare' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;? extends T&gt;']]"
		[Register ("declare", "(Lorg/koin/dsl/definition/BeanDefinition;)V", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe void Declare (global::Org.Koin.Dsl.Definition.BeanDefinition definition)
		{
			const string __id = "declare.(Lorg/koin/dsl/definition/BeanDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='loadExtraProperties' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("loadExtraProperties", "(Ljava/util/Map;)Lorg/koin/core/Koin;", "")]
		public unsafe global::Org.Koin.Core.Koin LoadExtraProperties (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> props)
		{
			const string __id = "loadExtraProperties.(Ljava/util/Map;)Lorg/koin/core/Koin;";
			IntPtr native_props = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (props);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_props);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Koin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_props);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='loadProperties' and count(parameter)=1 and parameter[1][@type='org.koin.core.KoinProperties']]"
		[Register ("loadProperties", "(Lorg/koin/core/KoinProperties;)Lorg/koin/core/Koin;", "")]
		public unsafe global::Org.Koin.Core.Koin LoadProperties (global::Org.Koin.Core.KoinProperties koinProps)
		{
			const string __id = "loadProperties.(Lorg/koin/core/KoinProperties;)Lorg/koin/core/Koin;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((koinProps == null) ? IntPtr.Zero : ((global::Java.Lang.Object) koinProps).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Koin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='registerModuleCallBack' and count(parameter)=1 and parameter[1][@type='org.koin.core.instance.ModuleCallBack']]"
		[Register ("registerModuleCallBack", "(Lorg/koin/core/instance/ModuleCallBack;)V", "")]
		public unsafe void RegisterModuleCallBack (global::Org.Koin.Core.Instance.IModuleCallBack @callback)
		{
			const string __id = "registerModuleCallBack.(Lorg/koin/core/instance/ModuleCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='Koin']/method[@name='registerScopeCallback' and count(parameter)=1 and parameter[1][@type='org.koin.core.scope.ScopeCallback']]"
		[Register ("registerScopeCallback", "(Lorg/koin/core/scope/ScopeCallback;)V", "")]
		public unsafe void RegisterScopeCallback (global::Org.Koin.Core.Scope.IScopeCallback @callback)
		{
			const string __id = "registerScopeCallback.(Lorg/koin/core/scope/ScopeCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
