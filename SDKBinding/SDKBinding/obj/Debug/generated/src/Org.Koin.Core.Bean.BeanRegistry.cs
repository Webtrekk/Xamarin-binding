using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.bean']/class[@name='BeanRegistry']"
	[global::Android.Runtime.Register ("org/koin/core/bean/BeanRegistry", DoNotGenerateAcw=true)]
	public sealed partial class BeanRegistry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/bean/BeanRegistry", typeof (BeanRegistry));
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

		internal BeanRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.bean']/class[@name='BeanRegistry']/constructor[@name='BeanRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BeanRegistry ()
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

		public unsafe global::Java.Util.HashSet Definitions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.bean']/class[@name='BeanRegistry']/method[@name='getDefinitions' and count(parameter)=0]"
			[Register ("getDefinitions", "()Ljava/util/HashSet;", "GetGetDefinitionsHandler")]
			get {
				const string __id = "getDefinitions.()Ljava/util/HashSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.bean']/class[@name='BeanRegistry']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.bean']/class[@name='BeanRegistry']/method[@name='declare' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("declare", "(Lorg/koin/dsl/definition/BeanDefinition;)V", "")]
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

	}
}
