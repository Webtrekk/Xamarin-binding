using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/WebtrekkConfiguration", DoNotGenerateAcw=true)]
	public sealed partial class WebtrekkConfiguration : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.IConfig {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/WebtrekkConfiguration$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/WebtrekkConfiguration$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/constructor[@name='WebtrekkConfiguration.Builder' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
			public unsafe Builder (global::System.Collections.Generic.IList<string> trackIds, string trackDomain)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_trackIds = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (trackIds);
				IntPtr native_trackDomain = JNIEnv.NewString (trackDomain);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_trackIds);
					__args [1] = new JniArgumentValue (native_trackDomain);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_trackIds);
					JNIEnv.DeleteLocalRef (native_trackDomain);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lwebtrekk/android/sdk/WebtrekkConfiguration;", "")]
			public unsafe global::Webtrekk.Android.Sdk.WebtrekkConfiguration Build ()
			{
				const string __id = "build.()Lwebtrekk/android/sdk/WebtrekkConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.WebtrekkConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/method[@name='disableAutoTracking' and count(parameter)=0]"
			[Register ("disableAutoTracking", "()Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;", "")]
			public unsafe global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder DisableAutoTracking ()
			{
				const string __id = "disableAutoTracking.()Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/method[@name='disableFragmentsAutoTracking' and count(parameter)=0]"
			[Register ("disableFragmentsAutoTracking", "()Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;", "")]
			public unsafe global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder DisableFragmentsAutoTracking ()
			{
				const string __id = "disableFragmentsAutoTracking.()Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.Logger.Level']]"
			[Register ("setLogLevel", "(Lwebtrekk/android/sdk/Logger$Level;)Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;", "")]
			public unsafe global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder SetLogLevel (global::Webtrekk.Android.Sdk.LoggerLevel logLevel)
			{
				const string __id = "setLogLevel.(Lwebtrekk/android/sdk/Logger$Level;)Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((logLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) logLevel).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration.Builder']/method[@name='setRequestsInterval' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.TimeUnit'] and parameter[2][@type='long']]"
			[Register ("setRequestsInterval", "(Ljava/util/concurrent/TimeUnit;J)Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;", "")]
			public unsafe global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder SetRequestsInterval (global::Java.Util.Concurrent.TimeUnit timeUnit, long interval)
			{
				const string __id = "setRequestsInterval.(Ljava/util/concurrent/TimeUnit;J)Lwebtrekk/android/sdk/WebtrekkConfiguration$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((timeUnit == null) ? IntPtr.Zero : ((global::Java.Lang.Object) timeUnit).Handle);
					__args [1] = new JniArgumentValue (interval);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.WebtrekkConfiguration.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/WebtrekkConfiguration", typeof (WebtrekkConfiguration));
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

		internal WebtrekkConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool AutoTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getAutoTracking' and count(parameter)=0]"
			[Register ("getAutoTracking", "()Z", "GetGetAutoTrackingHandler")]
			get {
				const string __id = "getAutoTracking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool FragmentsAutoTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getFragmentsAutoTracking' and count(parameter)=0]"
			[Register ("getFragmentsAutoTracking", "()Z", "GetGetFragmentsAutoTrackingHandler")]
			get {
				const string __id = "getFragmentsAutoTracking.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Webtrekk.Android.Sdk.LoggerLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lwebtrekk/android/sdk/Logger$Level;", "GetGetLogLevelHandler")]
			get {
				const string __id = "getLogLevel.()Lwebtrekk/android/sdk/Logger$Level;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long RequestsInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getRequestsInterval' and count(parameter)=0]"
			[Register ("getRequestsInterval", "()J", "GetGetRequestsIntervalHandler")]
			get {
				const string __id = "getRequestsInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string TrackDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getTrackDomain' and count(parameter)=0]"
			[Register ("getTrackDomain", "()Ljava/lang/String;", "GetGetTrackDomainHandler")]
			get {
				const string __id = "getTrackDomain.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<string> TrackIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkConfiguration']/method[@name='getTrackIds' and count(parameter)=0]"
			[Register ("getTrackIds", "()Ljava/util/List;", "GetGetTrackIdsHandler")]
			get {
				const string __id = "getTrackIds.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
