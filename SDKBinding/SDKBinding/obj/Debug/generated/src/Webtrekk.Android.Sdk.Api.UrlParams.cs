using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/api/UrlParams", DoNotGenerateAcw=true)]
	public sealed partial class UrlParams : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='APP_FIRST_OPEN']"
		[Register ("APP_FIRST_OPEN")]
		public const string AppFirstOpen = (string) "one";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='EVENT_NAME']"
		[Register ("EVENT_NAME")]
		public const string EventName = (string) "ct";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='EVER_ID']"
		[Register ("EVER_ID")]
		public const string EverId = (string) "eid";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='FORCE_NEW_SESSION']"
		[Register ("FORCE_NEW_SESSION")]
		public const string ForceNewSession = (string) "fns";


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Webtrekk.Android.Sdk.Api.UrlParams Instance {
			get {
				const string __id = "INSTANCE.Lwebtrekk/android/sdk/api/UrlParams;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Api.UrlParams> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='LANGUAGE']"
		[Register ("LANGUAGE")]
		public const string Language = (string) "la";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='TIME_ZONE']"
		[Register ("TIME_ZONE")]
		public const string TimeZone = (string) "tz";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='USER_AGENT']"
		[Register ("USER_AGENT")]
		public const string UserAgent = (string) "X-WT-UA";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/field[@name='WEBTREKK_PARAM']"
		[Register ("WEBTREKK_PARAM")]
		public const string WebtrekkParam = (string) "p";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/api/UrlParams", typeof (UrlParams));
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

		internal UrlParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string ANDROID_API_LEVEL {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/method[@name='getANDROID_API_LEVEL' and count(parameter)=0]"
			[Register ("getANDROID_API_LEVEL", "()Ljava/lang/String;", "GetGetANDROID_API_LEVELHandler")]
			get {
				const string __id = "getANDROID_API_LEVEL.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string APP_UPDATED {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/method[@name='getAPP_UPDATED' and count(parameter)=0]"
			[Register ("getAPP_UPDATED", "()Ljava/lang/String;", "GetGetAPP_UPDATEDHandler")]
			get {
				const string __id = "getAPP_UPDATED.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string APP_VERSION_CODE {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/method[@name='getAPP_VERSION_CODE' and count(parameter)=0]"
			[Register ("getAPP_VERSION_CODE", "()Ljava/lang/String;", "GetGetAPP_VERSION_CODEHandler")]
			get {
				const string __id = "getAPP_VERSION_CODE.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string APP_VERSION_NAME {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.api']/class[@name='UrlParams']/method[@name='getAPP_VERSION_NAME' and count(parameter)=0]"
			[Register ("getAPP_VERSION_NAME", "()Ljava/lang/String;", "GetGetAPP_VERSION_NAMEHandler")]
			get {
				const string __id = "getAPP_VERSION_NAME.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
