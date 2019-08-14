using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/Param", DoNotGenerateAcw=true)]
	public sealed partial class Param : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='CUSTOMER_ID']"
		[Register ("CUSTOMER_ID")]
		public const string CustomerId = (string) "cd";


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Webtrekk.Android.Sdk.Param Instance {
			get {
				const string __id = "INSTANCE.Lwebtrekk/android/sdk/Param;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Param> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='INTERNAL_SEARCH']"
		[Register ("INTERNAL_SEARCH")]
		public const string InternalSearch = (string) "is";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='MEDIA_CODE']"
		[Register ("MEDIA_CODE")]
		public const string MediaCode = (string) "mc";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='ORDER_ID']"
		[Register ("ORDER_ID")]
		public const string OrderId = (string) "oi";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='ORDER_VALUE']"
		[Register ("ORDER_VALUE")]
		public const string OrderValue = (string) "ov";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='PRODUCT_COST']"
		[Register ("PRODUCT_COST")]
		public const string ProductCost = (string) "co";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='PRODUCT_CURRENCY']"
		[Register ("PRODUCT_CURRENCY")]
		public const string ProductCurrency = (string) "cr";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='PRODUCT_NAME']"
		[Register ("PRODUCT_NAME")]
		public const string ProductName = (string) "ba";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='PRODUCT_QUANTITY']"
		[Register ("PRODUCT_QUANTITY")]
		public const string ProductQuantity = (string) "qn";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Param']/field[@name='STATUS_OF_SHOPPING_CARD']"
		[Register ("STATUS_OF_SHOPPING_CARD")]
		public const string StatusOfShoppingCard = (string) "st";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/Param", typeof (Param));
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

		internal Param (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
