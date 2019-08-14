using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/WebtrekkSharedPrefs", DoNotGenerateAcw=true)]
	public sealed partial class WebtrekkSharedPrefs : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/field[@name='EVER_ID_KEY']"
		[Register ("EVER_ID_KEY")]
		public const string EverIdKey = (string) "everId";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/field[@name='NEW_SESSION_KEY']"
		[Register ("NEW_SESSION_KEY")]
		public const string NewSessionKey = (string) "forceNewSession";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/field[@name='SHARED_PREFS_NAME']"
		[Register ("SHARED_PREFS_NAME")]
		public const string SharedPrefsName = (string) "webtrekk_sharedPref";

		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/field[@name='USER_OPT_OUT']"
		[Register ("USER_OPT_OUT")]
		public const string UserOptOut = (string) "optOut";
		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs.Companion']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/data/WebtrekkSharedPrefs$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/WebtrekkSharedPrefs$Companion", typeof (Companion));
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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/WebtrekkSharedPrefs", typeof (WebtrekkSharedPrefs));
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

		internal WebtrekkSharedPrefs (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/constructor[@name='WebtrekkSharedPrefs' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WebtrekkSharedPrefs (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string AppFirstOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getAppFirstOpen' and count(parameter)=0]"
			[Register ("getAppFirstOpen", "()Ljava/lang/String;", "GetGetAppFirstOpenHandler")]
			get {
				const string __id = "getAppFirstOpen.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='setAppFirstOpen' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppFirstOpen", "(Ljava/lang/String;)V", "GetSetAppFirstOpen_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppFirstOpen.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string AppVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getAppVersion' and count(parameter)=0]"
			[Register ("getAppVersion", "()Ljava/lang/String;", "GetGetAppVersionHandler")]
			get {
				const string __id = "getAppVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='setAppVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppVersion", "(Ljava/lang/String;)V", "GetSetAppVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppVersion.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")]
			get {
				const string __id = "getEverId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='setEverId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEverId", "(Ljava/lang/String;)V", "GetSetEverId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setEverId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string Fns {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getFns' and count(parameter)=0]"
			[Register ("getFns", "()Ljava/lang/String;", "GetGetFnsHandler")]
			get {
				const string __id = "getFns.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='setFns' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFns", "(Ljava/lang/String;)V", "GetSetFns_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFns.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe bool OptOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getOptOut' and count(parameter)=0]"
			[Register ("getOptOut", "()Z", "GetGetOptOutHandler")]
			get {
				const string __id = "getOptOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='setOptOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOptOut", "(Z)V", "GetSetOptOut_ZHandler")]
			set {
				const string __id = "setOptOut.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Android.Content.ISharedPreferences SharedPreferences {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='getSharedPreferences' and count(parameter)=0]"
			[Register ("getSharedPreferences", "()Landroid/content/SharedPreferences;", "GetGetSharedPreferencesHandler")]
			get {
				const string __id = "getSharedPreferences.()Landroid/content/SharedPreferences;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data']/class[@name='WebtrekkSharedPrefs']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("contains", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Contains (string key)
		{
			const string __id = "contains.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

	}
}
