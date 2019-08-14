using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']"
	[global::Android.Runtime.Register ("org/koin/core/instance/InstanceFactory", DoNotGenerateAcw=true)]
	public partial class InstanceFactory : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory.WhenMappings']"
		[global::Android.Runtime.Register ("org/koin/core/instance/InstanceFactory$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/InstanceFactory$WhenMappings", typeof (WhenMappings));
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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/InstanceFactory", typeof (InstanceFactory));
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

		protected InstanceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/constructor[@name='InstanceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InstanceFactory ()
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

		public unsafe global::System.Collections.Generic.IList<global::Org.Koin.Core.Instance.IModuleCallBack> Callbacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='getCallbacks' and count(parameter)=0]"
			[Register ("getCallbacks", "()Ljava/util/ArrayList;", "GetGetCallbacksHandler")]
			get {
				const string __id = "getCallbacks.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Koin.Core.Instance.IModuleCallBack>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Org.Koin.Core.Instance.Holder.IInstanceHolder> Instances {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='getInstances' and count(parameter)=0]"
			[Register ("getInstances", "()Ljava/util/ArrayList;", "GetGetInstancesHandler")]
			get {
				const string __id = "getInstances.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Koin.Core.Instance.Holder.IInstanceHolder>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_;
#pragma warning disable 0169
		static Delegate GetCreate_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_Handler ()
		{
			if (cb_create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_ == null)
				cb_create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_);
			return cb_create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_;
		}

		static IntPtr n_Create_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_ (IntPtr jnienv, IntPtr native__this, IntPtr native_def, IntPtr native_scope)
		{
			global::Org.Koin.Core.Instance.InstanceFactory __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.InstanceFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Koin.Dsl.Definition.BeanDefinition def = global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.BeanDefinition> (native_def, JniHandleOwnership.DoNotTransfer);
			global::Org.Koin.Core.Scope.Scope scope = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.Scope> (native_scope, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (def, scope));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;? extends T&gt;'] and parameter[2][@type='org.koin.core.scope.Scope']]"
		[Register ("create", "(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Lorg/koin/core/instance/holder/InstanceHolder;", "GetCreate_Lorg_koin_dsl_definition_BeanDefinition_Lorg_koin_core_scope_Scope_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Org.Koin.Core.Instance.Holder.IInstanceHolder Create (global::Org.Koin.Dsl.Definition.BeanDefinition def, global::Org.Koin.Core.Scope.Scope scope)
		{
			const string __id = "create.(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Lorg/koin/core/instance/holder/InstanceHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((def == null) ? IntPtr.Zero : ((global::Java.Lang.Object) def).Handle);
				__args [1] = new JniArgumentValue ((scope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scope).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.Holder.IInstanceHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("delete", "(Lorg/koin/dsl/definition/BeanDefinition;)V", "")]
		public unsafe void Delete (global::Org.Koin.Dsl.Definition.BeanDefinition definition)
		{
			const string __id = "delete.(Lorg/koin/dsl/definition/BeanDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='find' and count(parameter)=2 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;? extends T&gt;'] and parameter[2][@type='org.koin.core.scope.Scope']]"
		[Register ("find", "(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Lorg/koin/core/instance/holder/InstanceHolder;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Org.Koin.Core.Instance.Holder.IInstanceHolder Find (global::Org.Koin.Dsl.Definition.BeanDefinition def, global::Org.Koin.Core.Scope.Scope scope)
		{
			const string __id = "find.(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Lorg/koin/core/instance/holder/InstanceHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((def == null) ? IntPtr.Zero : ((global::Java.Lang.Object) def).Handle);
				__args [1] = new JniArgumentValue ((scope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scope).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.Holder.IInstanceHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='register' and count(parameter)=1 and parameter[1][@type='org.koin.core.instance.ModuleCallBack']]"
		[Obsolete (@"deprecated")]
		[Register ("register", "(Lorg/koin/core/instance/ModuleCallBack;)V", "")]
		public unsafe void Register (global::Org.Koin.Core.Instance.IModuleCallBack @callback)
		{
			const string __id = "register.(Lorg/koin/core/instance/ModuleCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='release' and count(parameter)=2 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;'] and parameter[2][@type='org.koin.core.scope.Scope']]"
		[Register ("release", "(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)V", "")]
		public unsafe void Release (global::Org.Koin.Dsl.Definition.BeanDefinition definition, global::Org.Koin.Core.Scope.Scope scope)
		{
			const string __id = "release.(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((definition == null) ? IntPtr.Zero : ((global::Java.Lang.Object) definition).Handle);
				__args [1] = new JniArgumentValue ((scope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scope).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/class[@name='InstanceFactory']/method[@name='releasePath' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.path.Path']]"
		[Obsolete (@"deprecated")]
		[Register ("releasePath", "(Lorg/koin/dsl/path/Path;)V", "")]
		public unsafe void ReleasePath (global::Org.Koin.Dsl.Path.Path path)
		{
			const string __id = "releasePath.(Lorg/koin/dsl/path/Path;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
