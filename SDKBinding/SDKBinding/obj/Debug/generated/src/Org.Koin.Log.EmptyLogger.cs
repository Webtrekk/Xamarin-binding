using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Log {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.log']/class[@name='EmptyLogger']"
	[global::Android.Runtime.Register ("org/koin/log/EmptyLogger", DoNotGenerateAcw=true)]
	public sealed partial class EmptyLogger : global::Java.Lang.Object, global::Org.Koin.Log.ILogger {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/log/EmptyLogger", typeof (EmptyLogger));
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

		internal EmptyLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.log']/class[@name='EmptyLogger']/constructor[@name='EmptyLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EmptyLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/class[@name='EmptyLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public unsafe void Debug (string msg)
		{
			const string __id = "debug.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/class[@name='EmptyLogger']/method[@name='err' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("err", "(Ljava/lang/String;)V", "")]
		public unsafe void Err (string msg)
		{
			const string __id = "err.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.log']/class[@name='EmptyLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public unsafe void Info (string msg)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
