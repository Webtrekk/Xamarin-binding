using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='FactoryInstanceHolder']"
	[global::Android.Runtime.Register ("org/koin/core/instance/holder/FactoryInstanceHolder", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class FactoryInstanceHolder : global::Java.Lang.Object, global::Org.Koin.Core.Instance.Holder.IInstanceHolder {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/holder/FactoryInstanceHolder", typeof (FactoryInstanceHolder));
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

		internal FactoryInstanceHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='FactoryInstanceHolder']/constructor[@name='FactoryInstanceHolder' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;? extends T&gt;']]"
		[Register (".ctor", "(Lorg/koin/dsl/definition/BeanDefinition;)V", "")]
		public unsafe FactoryInstanceHolder (global::Org.Koin.Dsl.Definition.BeanDefinition bean)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/koin/dsl/definition/BeanDefinition;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bean == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bean).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Org.Koin.Dsl.Definition.BeanDefinition Bean {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='FactoryInstanceHolder']/method[@name='getBean' and count(parameter)=0]"
			[Register ("getBean", "()Lorg/koin/dsl/definition/BeanDefinition;", "GetGetBeanHandler")]
			get {
				const string __id = "getBean.()Lorg/koin/dsl/definition/BeanDefinition;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.BeanDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='FactoryInstanceHolder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "")]
		public unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
