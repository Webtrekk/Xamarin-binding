using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/DefaultConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class DefaultConfiguration : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/field[@name='AUTO_TRACK_ENABLED']"
		[Register ("AUTO_TRACK_ENABLED")]
		public const bool AutoTrackEnabled = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/field[@name='FRAGMENTS_AUTO_TRACK_ENABLED']"
		[Register ("FRAGMENTS_AUTO_TRACK_ENABLED")]
		public const bool FragmentsAutoTrackEnabled = (bool) true;


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Webtrekk.Android.Sdk.DefaultConfiguration Instance {
			get {
				const string __id = "INSTANCE.Lwebtrekk/android/sdk/DefaultConfiguration;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.DefaultConfiguration> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/field[@name='REQUESTS_INTERVAL']"
		[Register ("REQUESTS_INTERVAL")]
		public const long RequestsInterval = (long) 15;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/DefaultConfiguration", typeof (DefaultConfiguration));
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

		internal DefaultConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Webtrekk.Android.Sdk.LoggerLevel LOG_LEVEL_VALUE {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/method[@name='getLOG_LEVEL_VALUE' and count(parameter)=0]"
			[Register ("getLOG_LEVEL_VALUE", "()Lwebtrekk/android/sdk/Logger$Level;", "GetGetLOG_LEVEL_VALUEHandler")]
			get {
				const string __id = "getLOG_LEVEL_VALUE.()Lwebtrekk/android/sdk/Logger$Level;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Concurrent.TimeUnit TIME_UNIT_VALUE {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='DefaultConfiguration']/method[@name='getTIME_UNIT_VALUE' and count(parameter)=0]"
			[Register ("getTIME_UNIT_VALUE", "()Ljava/util/concurrent/TimeUnit;", "GetGetTIME_UNIT_VALUEHandler")]
			get {
				const string __id = "getTIME_UNIT_VALUE.()Ljava/util/concurrent/TimeUnit;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
