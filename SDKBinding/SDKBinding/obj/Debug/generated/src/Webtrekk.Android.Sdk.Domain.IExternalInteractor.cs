using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.domain']/interface[@name='ExternalInteractor']"
	[Register ("webtrekk/android/sdk/domain/ExternalInteractor", "", "Webtrekk.Android.Sdk.Domain.IExternalInteractorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IExternalInteractor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain']/interface[@name='ExternalInteractor']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='webtrekk.android.sdk.util.CoroutineDispatchers']]"
		[Register ("invoke", "(Ljava/lang/Object;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V", "GetInvoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_Handler:Webtrekk.Android.Sdk.Domain.IExternalInteractorInvoker, SDKBinding")]
		void Invoke (global::Java.Lang.Object p0, global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers p1);

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/ExternalInteractor", DoNotGenerateAcw=true)]
	internal class IExternalInteractorInvoker : global::Java.Lang.Object, IExternalInteractor {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/domain/ExternalInteractor", typeof (IExternalInteractorInvoker));

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

		public static IExternalInteractor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExternalInteractor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.domain.ExternalInteractor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExternalInteractorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_Handler ()
		{
			if (cb_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_ == null)
				cb_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_);
			return cb_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_;
		}

		static void n_Invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Webtrekk.Android.Sdk.Domain.IExternalInteractor __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.IExternalInteractor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers p1 = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Invoke (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_;
		public unsafe void Invoke (global::Java.Lang.Object p0, global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers p1)
		{
			if (id_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_ == IntPtr.Zero)
				id_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/Object;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_Object_Lwebtrekk_android_sdk_util_CoroutineDispatchers_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
