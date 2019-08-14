using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Logger.Level']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/Logger$Level", DoNotGenerateAcw=true)]
	public sealed partial class LoggerLevel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Logger.Level']/field[@name='BASIC']"
		[Register ("BASIC")]
		public static global::Webtrekk.Android.Sdk.LoggerLevel Basic {
			get {
				const string __id = "BASIC.Lwebtrekk/android/sdk/Logger$Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Logger.Level']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Webtrekk.Android.Sdk.LoggerLevel None {
			get {
				const string __id = "NONE.Lwebtrekk/android/sdk/Logger$Level;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/Logger$Level", typeof (LoggerLevel));
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

		internal LoggerLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Logger.Level']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lwebtrekk/android/sdk/Logger$Level;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.LoggerLevel ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lwebtrekk/android/sdk/Logger$Level;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.LoggerLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Logger.Level']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lwebtrekk/android/sdk/Logger$Level;", "")]
		public static unsafe global::Webtrekk.Android.Sdk.LoggerLevel[] Values ()
		{
			const string __id = "values.()[Lwebtrekk/android/sdk/Logger$Level;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Webtrekk.Android.Sdk.LoggerLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Webtrekk.Android.Sdk.LoggerLevel));
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Logger']"
	[Register ("webtrekk/android/sdk/Logger", "", "Webtrekk.Android.Sdk.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Logger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "GetDebug_Ljava_lang_String_Handler:Webtrekk.Android.Sdk.ILoggerInvoker, SDKBinding")]
		void Debug (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Logger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "GetError_Ljava_lang_String_Handler:Webtrekk.Android.Sdk.ILoggerInvoker, SDKBinding")]
		void Error (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Logger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Handler:Webtrekk.Android.Sdk.ILoggerInvoker, SDKBinding")]
		void Info (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/interface[@name='Logger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "GetWarn_Ljava_lang_String_Handler:Webtrekk.Android.Sdk.ILoggerInvoker, SDKBinding")]
		void Warn (string p0);

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/Logger", DoNotGenerateAcw=true)]
	internal class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/Logger", typeof (ILoggerInvoker));

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

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.Logger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_debug_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDebug_Ljava_lang_String_Handler ()
		{
			if (cb_debug_Ljava_lang_String_ == null)
				cb_debug_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Debug_Ljava_lang_String_);
			return cb_debug_Ljava_lang_String_;
		}

		static void n_Debug_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Debug (p0);
		}
#pragma warning restore 0169

		IntPtr id_debug_Ljava_lang_String_;
		public unsafe void Debug (string p0)
		{
			if (id_debug_Ljava_lang_String_ == IntPtr.Zero)
				id_debug_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "debug", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_debug_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_error_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetError_Ljava_lang_String_Handler ()
		{
			if (cb_error_Ljava_lang_String_ == null)
				cb_error_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Error_Ljava_lang_String_);
			return cb_error_Ljava_lang_String_;
		}

		static void n_Error_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Error (p0);
		}
#pragma warning restore 0169

		IntPtr id_error_Ljava_lang_String_;
		public unsafe void Error (string p0)
		{
			if (id_error_Ljava_lang_String_ == IntPtr.Zero)
				id_error_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "error", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_error_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_info_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInfo_Ljava_lang_String_Handler ()
		{
			if (cb_info_Ljava_lang_String_ == null)
				cb_info_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Info_Ljava_lang_String_);
			return cb_info_Ljava_lang_String_;
		}

		static void n_Info_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Info (p0);
		}
#pragma warning restore 0169

		IntPtr id_info_Ljava_lang_String_;
		public unsafe void Info (string p0)
		{
			if (id_info_Ljava_lang_String_ == IntPtr.Zero)
				id_info_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "info", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_info_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_warn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetWarn_Ljava_lang_String_Handler ()
		{
			if (cb_warn_Ljava_lang_String_ == null)
				cb_warn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Warn_Ljava_lang_String_);
			return cb_warn_Ljava_lang_String_;
		}

		static void n_Warn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Warn (p0);
		}
#pragma warning restore 0169

		IntPtr id_warn_Ljava_lang_String_;
		public unsafe void Warn (string p0)
		{
			if (id_warn_Ljava_lang_String_ == IntPtr.Zero)
				id_warn_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "warn", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_warn_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
