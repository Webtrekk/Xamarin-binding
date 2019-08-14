using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='LifecycleReceiver']"
	[Register ("webtrekk/android/sdk/core/LifecycleReceiver", "", "Webtrekk.Android.Sdk.Core.ILifecycleReceiverInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ILifecycleReceiver : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='LifecycleReceiver']/method[@name='onLifecycleEventReceived' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onLifecycleEventReceived", "(Ljava/lang/Object;)V", "GetOnLifecycleEventReceived_Ljava_lang_Object_Handler:Webtrekk.Android.Sdk.Core.ILifecycleReceiverInvoker, SDKBinding")]
		void OnLifecycleEventReceived (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/LifecycleReceiver", DoNotGenerateAcw=true)]
	internal class ILifecycleReceiverInvoker : global::Java.Lang.Object, ILifecycleReceiver {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/core/LifecycleReceiver", typeof (ILifecycleReceiverInvoker));

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

		public static ILifecycleReceiver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILifecycleReceiver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.core.LifecycleReceiver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILifecycleReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onLifecycleEventReceived_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnLifecycleEventReceived_Ljava_lang_Object_Handler ()
		{
			if (cb_onLifecycleEventReceived_Ljava_lang_Object_ == null)
				cb_onLifecycleEventReceived_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnLifecycleEventReceived_Ljava_lang_Object_);
			return cb_onLifecycleEventReceived_Ljava_lang_Object_;
		}

		static void n_OnLifecycleEventReceived_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Webtrekk.Android.Sdk.Core.ILifecycleReceiver __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.ILifecycleReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnLifecycleEventReceived (p0);
		}
#pragma warning restore 0169

		IntPtr id_onLifecycleEventReceived_Ljava_lang_Object_;
		public unsafe void OnLifecycleEventReceived (global::Java.Lang.Object p0)
		{
			if (id_onLifecycleEventReceived_Ljava_lang_Object_ == IntPtr.Zero)
				id_onLifecycleEventReceived_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onLifecycleEventReceived", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLifecycleEventReceived_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
