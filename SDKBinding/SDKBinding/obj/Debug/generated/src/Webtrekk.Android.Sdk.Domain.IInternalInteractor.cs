using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.domain']/interface[@name='InternalInteractor']"
	[Register ("webtrekk/android/sdk/domain/InternalInteractor", "", "Webtrekk.Android.Sdk.Domain.IInternalInteractorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IInternalInteractor : IJavaObject {

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/InternalInteractor", DoNotGenerateAcw=true)]
	internal class IInternalInteractorInvoker : global::Java.Lang.Object, IInternalInteractor {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/domain/InternalInteractor", typeof (IInternalInteractorInvoker));

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

		public static IInternalInteractor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalInteractor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.domain.InternalInteractor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalInteractorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
