using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Standalone {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponent.DefaultImpls']"
	[global::Android.Runtime.Register ("org/koin/standalone/KoinComponent$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class KoinComponentDefaultImpls : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/standalone/KoinComponent$DefaultImpls", typeof (KoinComponentDefaultImpls));
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

		internal KoinComponentDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponent.DefaultImpls']/method[@name='getKoin' and count(parameter)=1 and parameter[1][@type='org.koin.standalone.KoinComponent']]"
		[Register ("getKoin", "(Lorg/koin/standalone/KoinComponent;)Lorg/koin/core/KoinContext;", "")]
		public static unsafe global::Org.Koin.Core.KoinContext GetKoin (global::Org.Koin.Standalone.IKoinComponent _this_)
		{
			const string __id = "getKoin.(Lorg/koin/standalone/KoinComponent;)Lorg/koin/core/KoinContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.standalone']/interface[@name='KoinComponent']"
	[Register ("org/koin/standalone/KoinComponent", "", "Org.Koin.Standalone.IKoinComponentInvoker")]
	public partial interface IKoinComponent : IJavaObject {

		global::Org.Koin.Core.KoinContext Koin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/interface[@name='KoinComponent']/method[@name='getKoin' and count(parameter)=0]"
			[Register ("getKoin", "()Lorg/koin/core/KoinContext;", "GetGetKoinHandler:Org.Koin.Standalone.IKoinComponentInvoker, SDKBinding")] get;
		}

	}

	[global::Android.Runtime.Register ("org/koin/standalone/KoinComponent", DoNotGenerateAcw=true)]
	internal class IKoinComponentInvoker : global::Java.Lang.Object, IKoinComponent {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/standalone/KoinComponent", typeof (IKoinComponentInvoker));

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

		public static IKoinComponent GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKoinComponent> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.standalone.KoinComponent"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKoinComponentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getKoin;
#pragma warning disable 0169
		static Delegate GetGetKoinHandler ()
		{
			if (cb_getKoin == null)
				cb_getKoin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKoin);
			return cb_getKoin;
		}

		static IntPtr n_GetKoin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Koin.Standalone.IKoinComponent __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Standalone.IKoinComponent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Koin);
		}
#pragma warning restore 0169

		IntPtr id_getKoin;
		public unsafe global::Org.Koin.Core.KoinContext Koin {
			get {
				if (id_getKoin == IntPtr.Zero)
					id_getKoin = JNIEnv.GetMethodID (class_ref, "getKoin", "()Lorg/koin/core/KoinContext;");
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKoin), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
