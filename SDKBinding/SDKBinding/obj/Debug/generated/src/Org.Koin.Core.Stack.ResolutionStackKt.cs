using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Stack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStackKt']"
	[global::Android.Runtime.Register ("org/koin/core/stack/ResolutionStackKt", DoNotGenerateAcw=true)]
	public sealed partial class ResolutionStackKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/stack/ResolutionStackKt", typeof (ResolutionStackKt));
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

		internal ResolutionStackKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
