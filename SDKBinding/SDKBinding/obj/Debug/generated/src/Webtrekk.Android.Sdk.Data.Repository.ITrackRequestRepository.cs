using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Repository {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.data.repository']/interface[@name='TrackRequestRepository']"
	[Register ("webtrekk/android/sdk/data/repository/TrackRequestRepository", "", "Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepositoryInvoker")]
	public partial interface ITrackRequestRepository : IJavaObject {

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/repository/TrackRequestRepository", DoNotGenerateAcw=true)]
	internal class ITrackRequestRepositoryInvoker : global::Java.Lang.Object, ITrackRequestRepository {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/data/repository/TrackRequestRepository", typeof (ITrackRequestRepositoryInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITrackRequestRepository GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrackRequestRepository> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.data.repository.TrackRequestRepository"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackRequestRepositoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}