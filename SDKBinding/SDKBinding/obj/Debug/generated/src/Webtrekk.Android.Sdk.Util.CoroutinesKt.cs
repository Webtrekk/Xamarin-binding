using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='CoroutinesKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/util/CoroutinesKt", DoNotGenerateAcw=true)]
	public sealed partial class CoroutinesKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/util/CoroutinesKt", typeof (CoroutinesKt));
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

		internal CoroutinesKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
