using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='InstanceHolder.DefaultImpls']"
	[global::Android.Runtime.Register ("org/koin/core/instance/holder/InstanceHolder$DefaultImpls", DoNotGenerateAcw=true)]
	public sealed partial class InstanceHolderDefaultImpls : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/holder/InstanceHolder$DefaultImpls", typeof (InstanceHolderDefaultImpls));
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

		internal InstanceHolderDefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.koin.core.instance.holder']/interface[@name='InstanceHolder']"
	[Register ("org/koin/core/instance/holder/InstanceHolder", "", "Org.Koin.Core.Instance.Holder.IInstanceHolderInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IInstanceHolder : IJavaObject {

		global::Org.Koin.Dsl.Definition.BeanDefinition Bean {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/interface[@name='InstanceHolder']/method[@name='getBean' and count(parameter)=0]"
			[Register ("getBean", "()Lorg/koin/dsl/definition/BeanDefinition;", "GetGetBeanHandler:Org.Koin.Core.Instance.Holder.IInstanceHolderInvoker, SDKBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/interface[@name='InstanceHolder']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Org.Koin.Core.Instance.Holder.IInstanceHolderInvoker, SDKBinding")]
		void Release ();

	}

	[global::Android.Runtime.Register ("org/koin/core/instance/holder/InstanceHolder", DoNotGenerateAcw=true)]
	internal class IInstanceHolderInvoker : global::Java.Lang.Object, IInstanceHolder {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/core/instance/holder/InstanceHolder", typeof (IInstanceHolderInvoker));

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

		public static IInstanceHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstanceHolder> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.koin.core.instance.holder.InstanceHolder"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstanceHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBean;
#pragma warning disable 0169
		static Delegate GetGetBeanHandler ()
		{
			if (cb_getBean == null)
				cb_getBean = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBean);
			return cb_getBean;
		}

		static IntPtr n_GetBean (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Koin.Core.Instance.Holder.IInstanceHolder __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.Holder.IInstanceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bean);
		}
#pragma warning restore 0169

		IntPtr id_getBean;
		public unsafe global::Org.Koin.Dsl.Definition.BeanDefinition Bean {
			get {
				if (id_getBean == IntPtr.Zero)
					id_getBean = JNIEnv.GetMethodID (class_ref, "getBean", "()Lorg/koin/dsl/definition/BeanDefinition;");
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.BeanDefinition> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBean), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Koin.Core.Instance.Holder.IInstanceHolder __this = global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.Holder.IInstanceHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

	}

}
