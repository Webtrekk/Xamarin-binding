using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']"
	[Register ("webtrekk/android/sdk/core/Sessions", "", "Webtrekk.Android.Sdk.Core.ISessionsInvoker")]
	public partial interface ISessions : IJavaObject {

		string AppFirstOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='getAppFirstOpen' and count(parameter)=0]"
			[Register ("getAppFirstOpen", "()Ljava/lang/String;", "GetGetAppFirstOpenHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")] get;
		}

		string CurrentSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='getCurrentSession' and count(parameter)=0]"
			[Register ("getCurrentSession", "()Ljava/lang/String;", "GetGetCurrentSessionHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")] get;
		}

		string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")] get;
		}

		bool IsOptOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='isOptOut' and count(parameter)=0]"
			[Register ("isOptOut", "()Z", "GetIsOptOutHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='isAppUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAppUpdated", "(Ljava/lang/String;)Z", "GetIsAppUpdated_Ljava_lang_String_Handler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")]
		bool IsAppUpdated (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='optOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("optOut", "(Z)V", "GetOptOut_ZHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")]
		void OptOut (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='setEverId' and count(parameter)=0]"
		[Register ("setEverId", "()V", "GetSetEverIdHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")]
		void SetEverId ();

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Sessions']/method[@name='startNewSession' and count(parameter)=0]"
		[Register ("startNewSession", "()V", "GetStartNewSessionHandler:Webtrekk.Android.Sdk.Core.ISessionsInvoker, SDKBinding")]
		void StartNewSession ();

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/Sessions", DoNotGenerateAcw=true)]
	internal class ISessionsInvoker : global::Java.Lang.Object, ISessions {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/core/Sessions", typeof (ISessionsInvoker));

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

		public static ISessions GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISessions> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.core.Sessions"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISessionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAppFirstOpen;
#pragma warning disable 0169
		static Delegate GetGetAppFirstOpenHandler ()
		{
			if (cb_getAppFirstOpen == null)
				cb_getAppFirstOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppFirstOpen);
			return cb_getAppFirstOpen;
		}

		static IntPtr n_GetAppFirstOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppFirstOpen);
		}
#pragma warning restore 0169

		IntPtr id_getAppFirstOpen;
		public unsafe string AppFirstOpen {
			get {
				if (id_getAppFirstOpen == IntPtr.Zero)
					id_getAppFirstOpen = JNIEnv.GetMethodID (class_ref, "getAppFirstOpen", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppFirstOpen), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCurrentSession;
#pragma warning disable 0169
		static Delegate GetGetCurrentSessionHandler ()
		{
			if (cb_getCurrentSession == null)
				cb_getCurrentSession = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentSession);
			return cb_getCurrentSession;
		}

		static IntPtr n_GetCurrentSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentSession);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentSession;
		public unsafe string CurrentSession {
			get {
				if (id_getCurrentSession == IntPtr.Zero)
					id_getCurrentSession = JNIEnv.GetMethodID (class_ref, "getCurrentSession", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSession), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEverId;
#pragma warning disable 0169
		static Delegate GetGetEverIdHandler ()
		{
			if (cb_getEverId == null)
				cb_getEverId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEverId);
			return cb_getEverId;
		}

		static IntPtr n_GetEverId (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EverId);
		}
#pragma warning restore 0169

		IntPtr id_getEverId;
		public unsafe string EverId {
			get {
				if (id_getEverId == IntPtr.Zero)
					id_getEverId = JNIEnv.GetMethodID (class_ref, "getEverId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEverId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isOptOut;
#pragma warning disable 0169
		static Delegate GetIsOptOutHandler ()
		{
			if (cb_isOptOut == null)
				cb_isOptOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOptOut);
			return cb_isOptOut;
		}

		static bool n_IsOptOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOptOut;
		}
#pragma warning restore 0169

		IntPtr id_isOptOut;
		public unsafe bool IsOptOut {
			get {
				if (id_isOptOut == IntPtr.Zero)
					id_isOptOut = JNIEnv.GetMethodID (class_ref, "isOptOut", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOptOut);
			}
		}

		static Delegate cb_isAppUpdated_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsAppUpdated_Ljava_lang_String_Handler ()
		{
			if (cb_isAppUpdated_Ljava_lang_String_ == null)
				cb_isAppUpdated_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAppUpdated_Ljava_lang_String_);
			return cb_isAppUpdated_Ljava_lang_String_;
		}

		static bool n_IsAppUpdated_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAppUpdated (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isAppUpdated_Ljava_lang_String_;
		public unsafe bool IsAppUpdated (string p0)
		{
			if (id_isAppUpdated_Ljava_lang_String_ == IntPtr.Zero)
				id_isAppUpdated_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isAppUpdated", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAppUpdated_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_optOut_Z;
#pragma warning disable 0169
		static Delegate GetOptOut_ZHandler ()
		{
			if (cb_optOut_Z == null)
				cb_optOut_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_OptOut_Z);
			return cb_optOut_Z;
		}

		static void n_OptOut_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptOut (p0);
		}
#pragma warning restore 0169

		IntPtr id_optOut_Z;
		public unsafe void OptOut (bool p0)
		{
			if (id_optOut_Z == IntPtr.Zero)
				id_optOut_Z = JNIEnv.GetMethodID (class_ref, "optOut", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_optOut_Z, __args);
		}

		static Delegate cb_setEverId;
#pragma warning disable 0169
		static Delegate GetSetEverIdHandler ()
		{
			if (cb_setEverId == null)
				cb_setEverId = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetEverId);
			return cb_setEverId;
		}

		static void n_SetEverId (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEverId ();
		}
#pragma warning restore 0169

		IntPtr id_setEverId;
		public unsafe void SetEverId ()
		{
			if (id_setEverId == IntPtr.Zero)
				id_setEverId = JNIEnv.GetMethodID (class_ref, "setEverId", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEverId);
		}

		static Delegate cb_startNewSession;
#pragma warning disable 0169
		static Delegate GetStartNewSessionHandler ()
		{
			if (cb_startNewSession == null)
				cb_startNewSession = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartNewSession);
			return cb_startNewSession;
		}

		static void n_StartNewSession (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.ISessions __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ISessions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartNewSession ();
		}
#pragma warning restore 0169

		IntPtr id_startNewSession;
		public unsafe void StartNewSession ()
		{
			if (id_startNewSession == IntPtr.Zero)
				id_startNewSession = JNIEnv.GetMethodID (class_ref, "startNewSession", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startNewSession);
		}

	}

}
