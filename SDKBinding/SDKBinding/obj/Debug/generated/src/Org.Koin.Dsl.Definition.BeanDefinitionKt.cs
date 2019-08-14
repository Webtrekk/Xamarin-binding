using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Definition {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinitionKt']"
	[global::Android.Runtime.Register ("org/koin/dsl/definition/BeanDefinitionKt", DoNotGenerateAcw=true)]
	public sealed partial class BeanDefinitionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/definition/BeanDefinitionKt", typeof (BeanDefinitionKt));
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

		internal BeanDefinitionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
