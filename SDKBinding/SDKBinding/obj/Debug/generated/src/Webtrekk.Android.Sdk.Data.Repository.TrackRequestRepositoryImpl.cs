using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Repository {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.repository']/class[@name='TrackRequestRepositoryImpl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/repository/TrackRequestRepositoryImpl", DoNotGenerateAcw=true)]
	public sealed partial class TrackRequestRepositoryImpl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepository {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/repository/TrackRequestRepositoryImpl", typeof (TrackRequestRepositoryImpl));
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

		internal TrackRequestRepositoryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data.repository']/class[@name='TrackRequestRepositoryImpl']/constructor[@name='TrackRequestRepositoryImpl' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.dao.TrackRequestDao']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/dao/TrackRequestDao;)V", "")]
		public unsafe TrackRequestRepositoryImpl (global::Webtrekk.Android.Sdk.Data.Dao.ITrackRequestDao trackRequestDao)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/dao/TrackRequestDao;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trackRequestDao == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequestDao).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
