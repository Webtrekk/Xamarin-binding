using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ActivityExtensionKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/extension/ActivityExtensionKt", DoNotGenerateAcw=true)]
	public sealed partial class ActivityExtensionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/extension/ActivityExtensionKt", typeof (ActivityExtensionKt));
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

		internal ActivityExtensionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ActivityExtensionKt']/method[@name='toTrackRequest' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("toTrackRequest", "(Landroid/app/Activity;)Lwebtrekk/android/sdk/data/entity/TrackRequest;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest ToTrackRequest (global::Android.App.Activity _this_toTrackRequest_)
		{
			const string __id = "toTrackRequest.(Landroid/app/Activity;)Lwebtrekk/android/sdk/data/entity/TrackRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_toTrackRequest_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_toTrackRequest_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
