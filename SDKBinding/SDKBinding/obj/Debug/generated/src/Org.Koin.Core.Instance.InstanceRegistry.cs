using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']"
	[global::Android.Runtime.Register ("org/koin/core/instance/InstanceRegistry", DoNotGenerateAcw=true)]
	public sealed partial class InstanceRegistry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/InstanceRegistry", typeof (InstanceRegistry));
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

		internal InstanceRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/constructor[@name='InstanceRegistry' and count(parameter)=4 and parameter[1][@type='org.koin.core.bean.BeanRegistry'] and parameter[2][@type='org.koin.core.instance.InstanceFactory'] and parameter[3][@type='org.koin.core.path.PathRegistry'] and parameter[4][@type='org.koin.core.scope.ScopeRegistry']]"
		[Register (".ctor", "(Lorg/koin/core/bean/BeanRegistry;Lorg/koin/core/instance/InstanceFactory;Lorg/koin/core/path/PathRegistry;Lorg/koin/core/scope/ScopeRegistry;)V", "")]
		public unsafe InstanceRegistry (global::Org.Koin.Core.Bean.BeanRegistry beanRegistry, global::Org.Koin.Core.Instance.InstanceFactory instanceFactory, global::Org.Koin.Core.Path.PathRegistry pathRegistry, global::Org.Koin.Core.Scope.ScopeRegistry scopeRegistry)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/koin/core/bean/BeanRegistry;Lorg/koin/core/instance/InstanceFactory;Lorg/koin/core/path/PathRegistry;Lorg/koin/core/scope/ScopeRegistry;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((beanRegistry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) beanRegistry).Handle);
				__args [1] = new JniArgumentValue ((instanceFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instanceFactory).Handle);
				__args [2] = new JniArgumentValue ((pathRegistry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pathRegistry).Handle);
				__args [3] = new JniArgumentValue ((scopeRegistry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scopeRegistry).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Org.Koin.Core.Bean.BeanRegistry BeanRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/method[@name='getBeanRegistry' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/method[@name='getInstanceFactory' and count(parameter)=0]"
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

		public unsafe global::Org.Koin.Core.Path.PathRegistry PathRegistry {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/method[@name='getPathRegistry' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceRegistry']/method[@name='resolve' and count(parameter)=1 and parameter[1][@type='org.koin.core.instance.InstanceRequest']]"
		[Register ("resolve", "(Lorg/koin/core/instance/InstanceRequest;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Resolve (global::Org.Koin.Core.Instance.InstanceRequest request)
		{
			const string __id = "resolve.(Lorg/koin/core/instance/InstanceRequest;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
