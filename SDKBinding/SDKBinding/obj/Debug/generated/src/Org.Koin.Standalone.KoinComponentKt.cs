using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Standalone {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponentKt']"
	[global::Android.Runtime.Register ("org/koin/standalone/KoinComponentKt", DoNotGenerateAcw=true)]
	public sealed partial class KoinComponentKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/standalone/KoinComponentKt", typeof (KoinComponentKt));
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

		internal KoinComponentKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponentKt']/method[@name='release' and count(parameter)=2 and parameter[1][@type='org.koin.standalone.KoinComponent'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("release", "(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;)V", "")]
		public static unsafe void Release (global::Org.Koin.Standalone.IKoinComponent _receiver_, string path)
		{
			const string __id = "release.(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				__args [1] = new JniArgumentValue (native_path);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponentKt']/method[@name='releaseContext' and count(parameter)=2 and parameter[1][@type='org.koin.standalone.KoinComponent'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("releaseContext", "(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;)V", "")]
		public static unsafe void ReleaseContext (global::Org.Koin.Standalone.IKoinComponent _receiver_, string path)
		{
			const string __id = "releaseContext.(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;)V";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				__args [1] = new JniArgumentValue (native_path);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='KoinComponentKt']/method[@name='setProperty' and count(parameter)=3 and parameter[1][@type='org.koin.standalone.KoinComponent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Object']]"
		[Register ("setProperty", "(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public static unsafe void SetProperty (global::Org.Koin.Standalone.IKoinComponent _receiver_, string key, global::Java.Lang.Object value)
		{
			const string __id = "setProperty.(Lorg/koin/standalone/KoinComponent;Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				__args [1] = new JniArgumentValue (native_key);
				__args [2] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
