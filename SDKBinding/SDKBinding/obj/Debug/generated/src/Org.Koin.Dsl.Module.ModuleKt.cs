using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Module {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.module']/class[@name='ModuleKt']"
	[global::Android.Runtime.Register ("org/koin/dsl/module/ModuleKt", DoNotGenerateAcw=true)]
	public sealed partial class ModuleKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/module/ModuleKt", typeof (ModuleKt));
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

		internal ModuleKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
