using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/util/UtilKt", DoNotGenerateAcw=true)]
	public sealed partial class UtilKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/util/UtilKt", typeof (UtilKt));
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

		internal UtilKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe int CurrentApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentApiLevel' and count(parameter)=0]"
			[Register ("getCurrentApiLevel", "()I", "GetGetCurrentApiLevelHandler")]
			get {
				const string __id = "getCurrentApiLevel.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string CurrentCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentCountry' and count(parameter)=0]"
			[Register ("getCurrentCountry", "()Ljava/lang/String;", "GetGetCurrentCountryHandler")]
			get {
				const string __id = "getCurrentCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CurrentDeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentDeviceManufacturer' and count(parameter)=0]"
			[Register ("getCurrentDeviceManufacturer", "()Ljava/lang/String;", "GetGetCurrentDeviceManufacturerHandler")]
			get {
				const string __id = "getCurrentDeviceManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CurrentDeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentDeviceModel' and count(parameter)=0]"
			[Register ("getCurrentDeviceModel", "()Ljava/lang/String;", "GetGetCurrentDeviceModelHandler")]
			get {
				const string __id = "getCurrentDeviceModel.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CurrentLanguage {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentLanguage' and count(parameter)=0]"
			[Register ("getCurrentLanguage", "()Ljava/lang/String;", "GetGetCurrentLanguageHandler")]
			get {
				const string __id = "getCurrentLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CurrentOsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentOsVersion' and count(parameter)=0]"
			[Register ("getCurrentOsVersion", "()Ljava/lang/String;", "GetGetCurrentOsVersionHandler")]
			get {
				const string __id = "getCurrentOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe long CurrentTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentTimeStamp' and count(parameter)=0]"
			[Register ("getCurrentTimeStamp", "()J", "GetGetCurrentTimeStampHandler")]
			get {
				const string __id = "getCurrentTimeStamp.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int CurrentTimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentTimeZone' and count(parameter)=0]"
			[Register ("getCurrentTimeZone", "()I", "GetGetCurrentTimeZoneHandler")]
			get {
				const string __id = "getCurrentTimeZone.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string CurrentWebtrekkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='UtilKt']/method[@name='getCurrentWebtrekkVersion' and count(parameter)=0]"
			[Register ("getCurrentWebtrekkVersion", "()Ljava/lang/String;", "GetGetCurrentWebtrekkVersionHandler")]
			get {
				const string __id = "getCurrentWebtrekkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
