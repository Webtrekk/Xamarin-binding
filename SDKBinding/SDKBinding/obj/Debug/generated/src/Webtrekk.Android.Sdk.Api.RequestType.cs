using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/api/RequestType", DoNotGenerateAcw=true)]
	public sealed partial class RequestType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']/field[@name='EVENT']"
		[Register ("EVENT")]
		public static global::Webtrekk.Android.Sdk.Api.RequestType Event {
			get {
				const string __id = "EVENT.Lwebtrekk/android/sdk/api/RequestType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Api.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']/field[@name='PAGE']"
		[Register ("PAGE")]
		public static global::Webtrekk.Android.Sdk.Api.RequestType Page {
			get {
				const string __id = "PAGE.Lwebtrekk/android/sdk/api/RequestType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Api.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/api/RequestType", typeof (RequestType));
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

		internal RequestType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lwebtrekk/android/sdk/api/RequestType;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.Api.RequestType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lwebtrekk/android/sdk/api/RequestType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Api.RequestType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='RequestType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lwebtrekk/android/sdk/api/RequestType;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.Api.RequestType[] Values ()
		{
			const string __id = "values.()[Lwebtrekk/android/sdk/api/RequestType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Webtrekk.Android.Sdk.Api.RequestType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Webtrekk.Android.Sdk.Api.RequestType));
			} finally {
			}
		}

	}
}
