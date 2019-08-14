using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/extension/DataExtensionKt", DoNotGenerateAcw=true)]
	public sealed partial class DataExtensionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/extension/DataExtensionKt", typeof (DataExtensionKt));
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

		internal DataExtensionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']/method[@name='buildCustomParams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;webtrekk.android.sdk.data.entity.CustomParam&gt;']]"
		[Register ("buildCustomParams", "(Ljava/util/List;)Ljava/lang/String;", "")]
		public static unsafe string BuildCustomParams (global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> _this_buildCustomParams_)
		{
			const string __id = "buildCustomParams.(Ljava/util/List;)Ljava/lang/String;";
			IntPtr native__this_buildCustomParams_ = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.ToLocalJniHandle (_this_buildCustomParams_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__this_buildCustomParams_);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__this_buildCustomParams_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']/method[@name='buildUrl' and count(parameter)=4 and parameter[1][@type='webtrekk.android.sdk.data.entity.DataTrack'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='java.lang.String']]"
		[Register ("buildUrl", "(Lwebtrekk/android/sdk/data/entity/DataTrack;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string BuildUrl (global::Webtrekk.Android.Sdk.Data.Entity.DataTrack _this_buildUrl_, string trackDomain, global::System.Collections.Generic.IList<string> trackIds, string currentEverId)
		{
			const string __id = "buildUrl.(Lwebtrekk/android/sdk/data/entity/DataTrack;Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_trackDomain = JNIEnv.NewString (trackDomain);
			IntPtr native_trackIds = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (trackIds);
			IntPtr native_currentEverId = JNIEnv.NewString (currentEverId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((_this_buildUrl_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_buildUrl_).Handle);
				__args [1] = new JniArgumentValue (native_trackDomain);
				__args [2] = new JniArgumentValue (native_trackIds);
				__args [3] = new JniArgumentValue (native_currentEverId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackDomain);
				JNIEnv.DeleteLocalRef (native_trackIds);
				JNIEnv.DeleteLocalRef (native_currentEverId);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']/method[@name='getUserAgent' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest']]"
		[Register ("getUserAgent", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Ljava/lang/String;", "")]
		public static unsafe string GetUserAgent (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest _this_userAgent_)
		{
			const string __id = "getUserAgent.(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_userAgent_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_userAgent_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']/method[@name='getWebtrekkRequestParams' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest']]"
		[Register ("getWebtrekkRequestParams", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Ljava/lang/String;", "")]
		public static unsafe string GetWebtrekkRequestParams (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest _this_webtrekkRequestParams_)
		{
			const string __id = "getWebtrekkRequestParams.(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_webtrekkRequestParams_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_webtrekkRequestParams_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='DataExtensionKt']/method[@name='toCustomParams' and count(parameter)=2 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='long']]"
		[Register ("toCustomParams", "(Ljava/util/Map;J)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> ToCustomParams (global::System.Collections.Generic.IDictionary<string, string> _this_toCustomParams_, long trackRequestId)
		{
			const string __id = "toCustomParams.(Ljava/util/Map;J)Ljava/util/List;";
			IntPtr native__this_toCustomParams_ = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (_this_toCustomParams_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__this_toCustomParams_);
				__args [1] = new JniArgumentValue (trackRequestId);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__this_toCustomParams_);
			}
		}

	}
}
