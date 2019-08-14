using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Scope {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.core.scope']/interface[@name='ScopeCallback']"
	[Register ("org/koin/core/scope/ScopeCallback", "", "Org.Koin.Core.Scope.IScopeCallbackInvoker")]
	public partial interface IScopeCallback : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.scope']/interface[@name='ScopeCallback']/method[@name='onClose' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("onClose", "(Ljava/lang/String;Ljava/lang/String;)V", "GetOnClose_Ljava_lang_String_Ljava_lang_String_Handler:Org.Koin.Core.Scope.IScopeCallbackInvoker, SDKBinding")]
		void OnClose (string p0, string p1);

	}

	[global::Android.Runtime.Register ("org/koin/core/scope/ScopeCallback", DoNotGenerateAcw=true)]
	internal class IScopeCallbackInvoker : global::Java.Lang.Object, IScopeCallback {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/core/scope/ScopeCallback", typeof (IScopeCallbackInvoker));

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

		public static IScopeCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScopeCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.core.scope.ScopeCallback"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IScopeCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClose_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnClose_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onClose_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onClose_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnClose_Ljava_lang_String_Ljava_lang_String_);
			return cb_onClose_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnClose_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Koin.Core.Scope.IScopeCallback __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Scope.IScopeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnClose (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onClose_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void OnClose (string p0, string p1)
		{
			if (id_onClose_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_onClose_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onClose", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClose_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
