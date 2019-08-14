using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DelegatesExtensionKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/extension/DelegatesExtensionKt", DoNotGenerateAcw=true)]
	public sealed partial class DelegatesExtensionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/extension/DelegatesExtensionKt", typeof (DelegatesExtensionKt));
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

		internal DelegatesExtensionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
