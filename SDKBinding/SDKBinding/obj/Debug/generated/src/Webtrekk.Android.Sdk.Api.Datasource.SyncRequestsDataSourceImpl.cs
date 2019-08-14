using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Api.Datasource {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.api.datasource']/class[@name='SyncRequestsDataSourceImpl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/api/datasource/SyncRequestsDataSourceImpl", DoNotGenerateAcw=true)]
	public sealed partial class SyncRequestsDataSourceImpl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Api.Datasource.ISyncRequestsDataSource {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/api/datasource/SyncRequestsDataSourceImpl", typeof (SyncRequestsDataSourceImpl));
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

		internal SyncRequestsDataSourceImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
