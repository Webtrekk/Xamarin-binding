using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']"
	[Register ("webtrekk/android/sdk/Config", "", "Webtrekk.Android.Sdk.IConfigInvoker")]
	public partial interface IConfig : IJavaObject {

		bool AutoTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getAutoTracking' and count(parameter)=0]"
			[Register ("getAutoTracking", "()Z", "GetGetAutoTrackingHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

		bool FragmentsAutoTracking {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getFragmentsAutoTracking' and count(parameter)=0]"
			[Register ("getFragmentsAutoTracking", "()Z", "GetGetFragmentsAutoTrackingHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

		global::Webtrekk.Android.Sdk.LoggerLevel LogLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getLogLevel' and count(parameter)=0]"
			[Register ("getLogLevel", "()Lwebtrekk/android/sdk/Logger$Level;", "GetGetLogLevelHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

		long RequestsInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getRequestsInterval' and count(parameter)=0]"
			[Register ("getRequestsInterval", "()J", "GetGetRequestsIntervalHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

		string TrackDomain {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getTrackDomain' and count(parameter)=0]"
			[Register ("getTrackDomain", "()Ljava/lang/String;", "GetGetTrackDomainHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

		global::System.Collections.Generic.IList<string> TrackIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Config']/method[@name='getTrackIds' and count(parameter)=0]"
			[Register ("getTrackIds", "()Ljava/util/List;", "GetGetTrackIdsHandler:Webtrekk.Android.Sdk.IConfigInvoker, SDKBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/Config", DoNotGenerateAcw=true)]
	internal class IConfigInvoker : global::Java.Lang.Object, IConfig {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/Config", typeof (IConfigInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConfig GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConfig> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.Config"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConfigInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAutoTracking;
#pragma warning disable 0169
		static Delegate GetGetAutoTrackingHandler ()
		{
			if (cb_getAutoTracking == null)
				cb_getAutoTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoTracking);
			return cb_getAutoTracking;
		}

		static bool n_GetAutoTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoTracking;
		}
#pragma warning restore 0169

		IntPtr id_getAutoTracking;
		public unsafe bool AutoTracking {
			get {
				if (id_getAutoTracking == IntPtr.Zero)
					id_getAutoTracking = JNIEnv.GetMethodID (class_ref, "getAutoTracking", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoTracking);
			}
		}

		static Delegate cb_getFragmentsAutoTracking;
#pragma warning disable 0169
		static Delegate GetGetFragmentsAutoTrackingHandler ()
		{
			if (cb_getFragmentsAutoTracking == null)
				cb_getFragmentsAutoTracking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetFragmentsAutoTracking);
			return cb_getFragmentsAutoTracking;
		}

		static bool n_GetFragmentsAutoTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FragmentsAutoTracking;
		}
#pragma warning restore 0169

		IntPtr id_getFragmentsAutoTracking;
		public unsafe bool FragmentsAutoTracking {
			get {
				if (id_getFragmentsAutoTracking == IntPtr.Zero)
					id_getFragmentsAutoTracking = JNIEnv.GetMethodID (class_ref, "getFragmentsAutoTracking", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getFragmentsAutoTracking);
			}
		}

		static Delegate cb_getLogLevel;
#pragma warning disable 0169
		static Delegate GetGetLogLevelHandler ()
		{
			if (cb_getLogLevel == null)
				cb_getLogLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogLevel);
			return cb_getLogLevel;
		}

		static IntPtr n_GetLogLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LogLevel);
		}
#pragma warning restore 0169

		IntPtr id_getLogLevel;
		public unsafe global::Webtrekk.Android.Sdk.LoggerLevel LogLevel {
			get {
				if (id_getLogLevel == IntPtr.Zero)
					id_getLogLevel = JNIEnv.GetMethodID (class_ref, "getLogLevel", "()Lwebtrekk/android/sdk/Logger$Level;");
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogLevel), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getRequestsInterval;
#pragma warning disable 0169
		static Delegate GetGetRequestsIntervalHandler ()
		{
			if (cb_getRequestsInterval == null)
				cb_getRequestsInterval = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRequestsInterval);
			return cb_getRequestsInterval;
		}

		static long n_GetRequestsInterval (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestsInterval;
		}
#pragma warning restore 0169

		IntPtr id_getRequestsInterval;
		public unsafe long RequestsInterval {
			get {
				if (id_getRequestsInterval == IntPtr.Zero)
					id_getRequestsInterval = JNIEnv.GetMethodID (class_ref, "getRequestsInterval", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRequestsInterval);
			}
		}

		static Delegate cb_getTrackDomain;
#pragma warning disable 0169
		static Delegate GetGetTrackDomainHandler ()
		{
			if (cb_getTrackDomain == null)
				cb_getTrackDomain = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackDomain);
			return cb_getTrackDomain;
		}

		static IntPtr n_GetTrackDomain (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackDomain);
		}
#pragma warning restore 0169

		IntPtr id_getTrackDomain;
		public unsafe string TrackDomain {
			get {
				if (id_getTrackDomain == IntPtr.Zero)
					id_getTrackDomain = JNIEnv.GetMethodID (class_ref, "getTrackDomain", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackDomain), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getTrackIds;
#pragma warning disable 0169
		static Delegate GetGetTrackIdsHandler ()
		{
			if (cb_getTrackIds == null)
				cb_getTrackIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackIds);
			return cb_getTrackIds;
		}

		static IntPtr n_GetTrackIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.IConfig __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.TrackIds);
		}
#pragma warning restore 0169

		IntPtr id_getTrackIds;
		public unsafe global::System.Collections.Generic.IList<string> TrackIds {
			get {
				if (id_getTrackIds == IntPtr.Zero)
					id_getTrackIds = JNIEnv.GetMethodID (class_ref, "getTrackIds", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackIds), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
