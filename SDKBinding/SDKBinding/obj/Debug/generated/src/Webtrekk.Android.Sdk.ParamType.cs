using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/ParamType", DoNotGenerateAcw=true)]
	public sealed partial class ParamType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='CAMPAIGN_PARAM']"
		[Register ("CAMPAIGN_PARAM")]
		public static global::Webtrekk.Android.Sdk.ParamType CampaignParam {
			get {
				const string __id = "CAMPAIGN_PARAM.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='ECOMMERCE_PARAM']"
		[Register ("ECOMMERCE_PARAM")]
		public static global::Webtrekk.Android.Sdk.ParamType EcommerceParam {
			get {
				const string __id = "ECOMMERCE_PARAM.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='EVENT_PARAM']"
		[Register ("EVENT_PARAM")]
		public static global::Webtrekk.Android.Sdk.ParamType EventParam {
			get {
				const string __id = "EVENT_PARAM.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='PAGE_CATEGORY']"
		[Register ("PAGE_CATEGORY")]
		public static global::Webtrekk.Android.Sdk.ParamType PageCategory {
			get {
				const string __id = "PAGE_CATEGORY.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='PAGE_PARAM']"
		[Register ("PAGE_PARAM")]
		public static global::Webtrekk.Android.Sdk.ParamType PageParam {
			get {
				const string __id = "PAGE_PARAM.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='PRODUCT_CATEGORY']"
		[Register ("PRODUCT_CATEGORY")]
		public static global::Webtrekk.Android.Sdk.ParamType ProductCategory {
			get {
				const string __id = "PRODUCT_CATEGORY.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='SESSION_PARAM']"
		[Register ("SESSION_PARAM")]
		public static global::Webtrekk.Android.Sdk.ParamType SessionParam {
			get {
				const string __id = "SESSION_PARAM.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/field[@name='URM_CATEGORY']"
		[Register ("URM_CATEGORY")]
		public static global::Webtrekk.Android.Sdk.ParamType UrmCategory {
			get {
				const string __id = "URM_CATEGORY.Lwebtrekk/android/sdk/ParamType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/ParamType", typeof (ParamType));
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

		internal ParamType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lwebtrekk/android/sdk/ParamType;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.ParamType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lwebtrekk/android/sdk/ParamType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ParamType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lwebtrekk/android/sdk/ParamType;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.ParamType[] Values ()
		{
			const string __id = "values.()[Lwebtrekk/android/sdk/ParamType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Webtrekk.Android.Sdk.ParamType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Webtrekk.Android.Sdk.ParamType));
			} finally {
			}
		}

	}
}
