using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/SessionsImpl", DoNotGenerateAcw=true)]
	public sealed partial class SessionsImpl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Core.ISessions {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/SessionsImpl", typeof (SessionsImpl));
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

		internal SessionsImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/constructor[@name='SessionsImpl' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.WebtrekkSharedPrefs']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/WebtrekkSharedPrefs;)V", "")]
		public unsafe SessionsImpl (global::Webtrekk.Android.Sdk.Data.WebtrekkSharedPrefs webtrekkSharedPrefs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/WebtrekkSharedPrefs;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((webtrekkSharedPrefs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) webtrekkSharedPrefs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string AppFirstOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='getAppFirstOpen' and count(parameter)=0]"
			[Register ("getAppFirstOpen", "()Ljava/lang/String;", "GetGetAppFirstOpenHandler")]
			get {
				const string __id = "getAppFirstOpen.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CurrentSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='getCurrentSession' and count(parameter)=0]"
			[Register ("getCurrentSession", "()Ljava/lang/String;", "GetGetCurrentSessionHandler")]
			get {
				const string __id = "getCurrentSession.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")]
			get {
				const string __id = "getEverId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsOptOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='isOptOut' and count(parameter)=0]"
			[Register ("isOptOut", "()Z", "GetIsOptOutHandler")]
			get {
				const string __id = "isOptOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='isAppUpdated' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAppUpdated", "(Ljava/lang/String;)Z", "")]
		public unsafe bool IsAppUpdated (string currentAppVersion)
		{
			const string __id = "isAppUpdated.(Ljava/lang/String;)Z";
			IntPtr native_currentAppVersion = JNIEnv.NewString (currentAppVersion);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_currentAppVersion);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_currentAppVersion);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='optOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("optOut", "(Z)V", "")]
		public unsafe void OptOut (bool value)
		{
			const string __id = "optOut.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='setEverId' and count(parameter)=0]"
		[Register ("setEverId", "()V", "")]
		public unsafe void SetEverId ()
		{
			const string __id = "setEverId.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SessionsImpl']/method[@name='startNewSession' and count(parameter)=0]"
		[Register ("startNewSession", "()V", "")]
		public unsafe void StartNewSession ()
		{
			const string __id = "startNewSession.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
