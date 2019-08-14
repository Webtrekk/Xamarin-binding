using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Converter {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.converter']/class[@name='RequestStateConverter']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/converter/RequestStateConverter", DoNotGenerateAcw=true)]
	public sealed partial class RequestStateConverter : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/converter/RequestStateConverter", typeof (RequestStateConverter));
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

		internal RequestStateConverter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data.converter']/class[@name='RequestStateConverter']/constructor[@name='RequestStateConverter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RequestStateConverter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.converter']/class[@name='RequestStateConverter']/method[@name='requestStateToString' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest.RequestState']]"
		[Register ("requestStateToString", "(Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;)Ljava/lang/String;", "")]
		public unsafe string RequestStateToString (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState requestState)
		{
			const string __id = "requestStateToString.(Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((requestState == null) ? IntPtr.Zero : ((global::Java.Lang.Object) requestState).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.converter']/class[@name='RequestStateConverter']/method[@name='stringToRequestState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToRequestState", "(Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState StringToRequestState (string value)
		{
			const string __id = "stringToRequestState.(Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
