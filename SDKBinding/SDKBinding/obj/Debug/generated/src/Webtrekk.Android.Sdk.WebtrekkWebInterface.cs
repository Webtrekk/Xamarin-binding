using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/WebtrekkWebInterface", DoNotGenerateAcw=true)]
	public partial class WebtrekkWebInterface : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "WebtrekkAndroidWebViewCallback";
		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface.Companion']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/WebtrekkWebInterface$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/WebtrekkWebInterface$Companion", typeof (Companion));
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/WebtrekkWebInterface", typeof (WebtrekkWebInterface));
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

		protected WebtrekkWebInterface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']/constructor[@name='WebtrekkWebInterface' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.Webtrekk']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/Webtrekk;)V", "")]
		public unsafe WebtrekkWebInterface (global::Webtrekk.Android.Sdk.Webtrekk webtrekk)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/Webtrekk;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webtrekk == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webtrekk).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")]
			get {
				const string __id = "getEverId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']/method[@name='trackCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackCustomEvent", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void TrackCustomEvent (string eventName, string @params)
		{
			const string __id = "trackCustomEvent.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_eventName = JNIEnv.NewString (eventName);
			IntPtr native__params = JNIEnv.NewString (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_eventName);
				__args [1] = new JniArgumentValue (native__params);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventName);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='WebtrekkWebInterface']/method[@name='trackCustomPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("trackCustomPage", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void TrackCustomPage (string pageName, string @params)
		{
			const string __id = "trackCustomPage.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_pageName = JNIEnv.NewString (pageName);
			IntPtr native__params = JNIEnv.NewString (@params);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_pageName);
				__args [1] = new JniArgumentValue (native__params);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_pageName);
				JNIEnv.DeleteLocalRef (native__params);
			}
		}

	}
}
