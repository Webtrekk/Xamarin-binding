using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.log']/interface[@name='Logger']"
	[Register ("org/koin/log/Logger", "", "Org.Koin.Log.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/interface[@name='Logger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "GetDebug_Ljava_lang_String_Handler:Org.Koin.Log.ILoggerInvoker, SDKBinding")]
		void Debug (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/interface[@name='Logger']/method[@name='err' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("err", "(Ljava/lang/String;)V", "GetErr_Ljava_lang_String_Handler:Org.Koin.Log.ILoggerInvoker, SDKBinding")]
		void Err (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/interface[@name='Logger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "GetInfo_Ljava_lang_String_Handler:Org.Koin.Log.ILoggerInvoker, SDKBinding")]
		void Info (string p0);

	}

	[global::Android.Runtime.Register ("org/koin/log/Logger", DoNotGenerateAcw=true)]
	internal class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/log/Logger", typeof (ILoggerInvoker));

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
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.log.Logger"));
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
			global::Org.Koin.Log.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Log.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_err_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetErr_Ljava_lang_String_Handler ()
		{
			if (cb_err_Ljava_lang_String_ == null)
				cb_err_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Err_Ljava_lang_String_);
			return cb_err_Ljava_lang_String_;
		}

		static void n_Err_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Koin.Log.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Log.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Err (p0);
		}
#pragma warning restore 0169

		IntPtr id_err_Ljava_lang_String_;
		public unsafe void Err (string p0)
		{
			if (id_err_Ljava_lang_String_ == IntPtr.Zero)
				id_err_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "err", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_err_Ljava_lang_String_, __args);
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
			global::Org.Koin.Log.ILogger __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Log.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
