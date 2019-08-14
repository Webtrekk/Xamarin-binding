using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.core.instance']/interface[@name='ModuleCallBack']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("org/koin/core/instance/ModuleCallBack", "", "Org.Koin.Core.Instance.IModuleCallBackInvoker")]
	public partial interface IModuleCallBack : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance']/interface[@name='ModuleCallBack']/method[@name='onRelease' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRelease", "(Ljava/lang/String;)V", "GetOnRelease_Ljava_lang_String_Handler:Org.Koin.Core.Instance.IModuleCallBackInvoker, SDKBinding")]
		void OnRelease (string p0);

	}

	[global::Android.Runtime.Register ("org/koin/core/instance/ModuleCallBack", DoNotGenerateAcw=true)]
	internal class IModuleCallBackInvoker : global::Java.Lang.Object, IModuleCallBack {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/core/instance/ModuleCallBack", typeof (IModuleCallBackInvoker));

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

		public static IModuleCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IModuleCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.core.instance.ModuleCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IModuleCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onRelease_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRelease_Ljava_lang_String_Handler ()
		{
			if (cb_onRelease_Ljava_lang_String_ == null)
				cb_onRelease_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRelease_Ljava_lang_String_);
			return cb_onRelease_Ljava_lang_String_;
		}

		static void n_OnRelease_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Koin.Core.Instance.IModuleCallBack __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.IModuleCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRelease (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRelease_Ljava_lang_String_;
		public unsafe void OnRelease (string p0)
		{
			if (id_onRelease_Ljava_lang_String_ == IntPtr.Zero)
				id_onRelease_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRelease", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRelease_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
