using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Dao {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.dao']/class[@name='TrackRequestDao_Impl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/dao/TrackRequestDao_Impl", DoNotGenerateAcw=true)]
	public sealed partial class TrackRequestDao_Impl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Data.Dao.ITrackRequestDao {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/dao/TrackRequestDao_Impl", typeof (TrackRequestDao_Impl));
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

		internal TrackRequestDao_Impl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
