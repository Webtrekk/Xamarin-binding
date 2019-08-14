using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/WebtrekkLogger", DoNotGenerateAcw=true)]
	public sealed partial class WebtrekkLogger : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.ILogger {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger.Companion']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/core/WebtrekkLogger$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/WebtrekkLogger$Companion", typeof (Companion));
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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger.WhenMappings']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/core/WebtrekkLogger$WhenMappings", DoNotGenerateAcw=true)]
		public sealed partial class WhenMappings : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/WebtrekkLogger$WhenMappings", typeof (WhenMappings));
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

			internal WhenMappings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/WebtrekkLogger", typeof (WebtrekkLogger));
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

		internal WebtrekkLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']/constructor[@name='WebtrekkLogger' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.Logger.Level']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/Logger$Level;)V", "")]
		public unsafe WebtrekkLogger (global::Webtrekk.Android.Sdk.LoggerLevel level)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/Logger$Level;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((level == null) ? IntPtr.Zero : ((global::Java.Lang.Object) level).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("debug", "(Ljava/lang/String;)V", "")]
		public unsafe void Debug (string message)
		{
			const string __id = "debug.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']/method[@name='error' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("error", "(Ljava/lang/String;)V", "")]
		public unsafe void Error (string message)
		{
			const string __id = "error.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']/method[@name='info' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("info", "(Ljava/lang/String;)V", "")]
		public unsafe void Info (string message)
		{
			const string __id = "info.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='WebtrekkLogger']/method[@name='warn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("warn", "(Ljava/lang/String;)V", "")]
		public unsafe void Warn (string message)
		{
			const string __id = "warn.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
