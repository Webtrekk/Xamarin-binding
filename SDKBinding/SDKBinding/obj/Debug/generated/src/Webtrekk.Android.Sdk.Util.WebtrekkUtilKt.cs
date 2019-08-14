using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/util/WebtrekkUtilKt", DoNotGenerateAcw=true)]
	public sealed partial class WebtrekkUtilKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/util/WebtrekkUtilKt", typeof (WebtrekkUtilKt));
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

		internal WebtrekkUtilKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string AppFirstOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getAppFirstOpen' and count(parameter)=0]"
			[Register ("getAppFirstOpen", "()Ljava/lang/String;", "GetGetAppFirstOpenHandler")]
			get {
				const string __id = "getAppFirstOpen.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe bool AppUpdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getAppUpdated' and count(parameter)=0]"
			[Register ("getAppUpdated", "()Z", "GetGetAppUpdatedHandler")]
			get {
				const string __id = "getAppUpdated.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string CurrentEverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getCurrentEverId' and count(parameter)=0]"
			[Register ("getCurrentEverId", "()Ljava/lang/String;", "GetGetCurrentEverIdHandler")]
			get {
				const string __id = "getCurrentEverId.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string CurrentSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getCurrentSession' and count(parameter)=0]"
			[Register ("getCurrentSession", "()Ljava/lang/String;", "GetGetCurrentSessionHandler")]
			get {
				const string __id = "getCurrentSession.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string TrackDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getTrackDomain' and count(parameter)=0]"
			[Register ("getTrackDomain", "()Ljava/lang/String;", "GetGetTrackDomainHandler")]
			get {
				const string __id = "getTrackDomain.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe global::System.Collections.Generic.IList<string> TrackIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='getTrackIds' and count(parameter)=0]"
			[Register ("getTrackIds", "()Ljava/util/List;", "GetGetTrackIdsHandler")]
			get {
				const string __id = "getTrackIds.()Ljava/util/List;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='WebtrekkUtilKt']/method[@name='generateEverId' and count(parameter)=0]"
		[Register ("generateEverId", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateEverId ()
		{
			const string __id = "generateEverId.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
