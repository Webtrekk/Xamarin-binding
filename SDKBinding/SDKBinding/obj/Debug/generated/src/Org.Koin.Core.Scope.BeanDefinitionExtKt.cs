using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Scope {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']"
	[global::Android.Runtime.Register ("org/koin/core/scope/BeanDefinitionExtKt", DoNotGenerateAcw=true)]
	public sealed partial class BeanDefinitionExtKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/scope/BeanDefinitionExtKt", typeof (BeanDefinitionExtKt));
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

		internal BeanDefinitionExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']/method[@name='getScope' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("getScope", "(Lorg/koin/dsl/definition/BeanDefinition;)Ljava/lang/String;", "")]
		public static unsafe string GetScope (global::Org.Koin.Dsl.Definition.BeanDefinition _receiver_)
		{
			const string __id = "getScope.(Lorg/koin/dsl/definition/BeanDefinition;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']/method[@name='isAddedToScope' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("isAddedToScope", "(Lorg/koin/dsl/definition/BeanDefinition;)Z", "")]
		public static unsafe bool IsAddedToScope (global::Org.Koin.Dsl.Definition.BeanDefinition _receiver_)
		{
			const string __id = "isAddedToScope.(Lorg/koin/dsl/definition/BeanDefinition;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']/method[@name='isVisibleToScope' and count(parameter)=2 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;'] and parameter[2][@type='org.koin.core.scope.Scope']]"
		[Register ("isVisibleToScope", "(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Z", "")]
		public static unsafe bool IsVisibleToScope (global::Org.Koin.Dsl.Definition.BeanDefinition _receiver_, global::Org.Koin.Core.Scope.Scope scope)
		{
			const string __id = "isVisibleToScope.(Lorg/koin/dsl/definition/BeanDefinition;Lorg/koin/core/scope/Scope;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				__args [1] = new JniArgumentValue ((scope == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scope).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']/method[@name='setAddedToScope' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("setAddedToScope", "(Lorg/koin/dsl/definition/BeanDefinition;)V", "")]
		public static unsafe void SetAddedToScope (global::Org.Koin.Dsl.Definition.BeanDefinition _receiver_)
		{
			const string __id = "setAddedToScope.(Lorg/koin/dsl/definition/BeanDefinition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/class[@name='BeanDefinitionExtKt']/method[@name='setScope' and count(parameter)=2 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("setScope", "(Lorg/koin/dsl/definition/BeanDefinition;Ljava/lang/String;)V", "")]
		public static unsafe void SetScope (global::Org.Koin.Dsl.Definition.BeanDefinition _receiver_, string id)
		{
			const string __id = "setScope.(Lorg/koin/dsl/definition/BeanDefinition;Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				__args [1] = new JniArgumentValue (native_id);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
