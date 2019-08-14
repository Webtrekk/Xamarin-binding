using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Standalone {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.standalone']/interface[@name='StandAloneKoinContext']"
	[Register ("org/koin/standalone/StandAloneKoinContext", "", "Org.Koin.Standalone.IStandAloneKoinContextInvoker")]
	public partial interface IStandAloneKoinContext : IJavaObject {

	}

	[global::Android.Runtime.Register ("org/koin/standalone/StandAloneKoinContext", DoNotGenerateAcw=true)]
	internal class IStandAloneKoinContextInvoker : global::Java.Lang.Object, IStandAloneKoinContext {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/standalone/StandAloneKoinContext", typeof (IStandAloneKoinContextInvoker));

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

		public static IStandAloneKoinContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStandAloneKoinContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.standalone.StandAloneKoinContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStandAloneKoinContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
