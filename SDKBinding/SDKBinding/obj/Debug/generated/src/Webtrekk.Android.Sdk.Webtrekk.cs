using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/Webtrekk", DoNotGenerateAcw=true)]
	public abstract partial class Webtrekk : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk.Companion']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/Webtrekk$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/Webtrekk$Companion", typeof (Companion));
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

			public unsafe global::Webtrekk.Android.Sdk.Webtrekk Instance {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk.Companion']/method[@name='getInstance' and count(parameter)=0]"
				[Register ("getInstance", "()Lwebtrekk/android/sdk/Webtrekk;", "GetGetInstanceHandler")]
				get {
					const string __id = "getInstance.()Lwebtrekk/android/sdk/Webtrekk;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/Webtrekk", typeof (Webtrekk));
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

		protected Webtrekk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/constructor[@name='Webtrekk' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Webtrekk ()
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

		static Delegate cb_getEverId;
#pragma warning disable 0169
		static Delegate GetGetEverIdHandler ()
		{
			if (cb_getEverId == null)
				cb_getEverId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEverId);
			return cb_getEverId;
		}

		static IntPtr n_GetEverId (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EverId);
		}
#pragma warning restore 0169

		public abstract string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='getEverId' and count(parameter)=0]"
			[Register ("getEverId", "()Ljava/lang/String;", "GetGetEverIdHandler")] get;
		}

		static Delegate cb_hasOptOut;
#pragma warning disable 0169
		static Delegate GetHasOptOutHandler ()
		{
			if (cb_hasOptOut == null)
				cb_hasOptOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasOptOut);
			return cb_hasOptOut;
		}

		static bool n_HasOptOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasOptOut;
		}
#pragma warning restore 0169

		public abstract bool HasOptOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='hasOptOut' and count(parameter)=0]"
			[Register ("hasOptOut", "()Z", "GetHasOptOutHandler")] get;
		}

		public static unsafe global::Webtrekk.Android.Sdk.Webtrekk Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lwebtrekk/android/sdk/Webtrekk;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lwebtrekk/android/sdk/Webtrekk;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_;
#pragma warning disable 0169
		static Delegate GetInit_Landroid_content_Context_Lwebtrekk_android_sdk_Config_Handler ()
		{
			if (cb_init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_ == null)
				cb_init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_);
			return cb_init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_;
		}

		static void n_Init_Landroid_content_Context_Lwebtrekk_android_sdk_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Webtrekk.Android.Sdk.IConfig p1 = (global::Webtrekk.Android.Sdk.IConfig)global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.IConfig> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='webtrekk.android.sdk.Config']]"
		[Register ("init", "(Landroid/content/Context;Lwebtrekk/android/sdk/Config;)V", "GetInit_Landroid_content_Context_Lwebtrekk_android_sdk_Config_Handler")]
		public abstract void Init (global::Android.Content.Context p0, global::Webtrekk.Android.Sdk.IConfig p1);

		static Delegate cb_optOut_ZZ;
#pragma warning disable 0169
		static Delegate GetOptOut_ZZHandler ()
		{
			if (cb_optOut_ZZ == null)
				cb_optOut_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, bool>) n_OptOut_ZZ);
			return cb_optOut_ZZ;
		}

		static void n_OptOut_ZZ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OptOut (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='optOut' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("optOut", "(ZZ)V", "GetOptOut_ZZHandler")]
		public abstract void OptOut (bool p0, bool p1);

		static Delegate cb_trackCustomEvent_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTrackCustomEvent_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_trackCustomEvent_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_trackCustomEvent_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackCustomEvent_Ljava_lang_String_Ljava_util_Map_);
			return cb_trackCustomEvent_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_TrackCustomEvent_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TrackCustomEvent (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackCustomEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCustomEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void TrackCustomEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		static Delegate cb_trackCustomPage_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTrackCustomPage_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_trackCustomPage_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_trackCustomPage_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackCustomPage_Ljava_lang_String_Ljava_util_Map_);
			return cb_trackCustomPage_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_TrackCustomPage_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TrackCustomPage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackCustomPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackCustomPage", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCustomPage_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void TrackCustomPage (string p0, global::System.Collections.Generic.IDictionary<string, string> p1);

		static Delegate cb_trackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetTrackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_trackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_trackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TrackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_);
			return cb_trackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_TrackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Webtrekk.Android.Sdk.Webtrekk __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Webtrekk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TrackPage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackPage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackPage", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "GetTrackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler")]
		public abstract void TrackPage (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2);

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/Webtrekk", DoNotGenerateAcw=true)]
	internal partial class WebtrekkInvoker : Webtrekk {

		public WebtrekkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/Webtrekk", typeof (WebtrekkInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string EverId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='getEverId' and count(parameter)=0]"
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

		public override unsafe bool HasOptOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='hasOptOut' and count(parameter)=0]"
			[Register ("hasOptOut", "()Z", "GetHasOptOutHandler")]
			get {
				const string __id = "hasOptOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='webtrekk.android.sdk.Config']]"
		[Register ("init", "(Landroid/content/Context;Lwebtrekk/android/sdk/Config;)V", "GetInit_Landroid_content_Context_Lwebtrekk_android_sdk_Config_Handler")]
		public override unsafe void Init (global::Android.Content.Context p0, global::Webtrekk.Android.Sdk.IConfig p1)
		{
			const string __id = "init.(Landroid/content/Context;Lwebtrekk/android/sdk/Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='optOut' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("optOut", "(ZZ)V", "GetOptOut_ZZHandler")]
		public override unsafe void OptOut (bool p0, bool p1)
		{
			const string __id = "optOut.(ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackCustomEvent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackCustomEvent", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCustomEvent_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void TrackCustomEvent (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "trackCustomEvent.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackCustomPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackCustomPage", "(Ljava/lang/String;Ljava/util/Map;)V", "GetTrackCustomPage_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void TrackCustomPage (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			const string __id = "trackCustomPage.(Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='Webtrekk']/method[@name='trackPage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("trackPage", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "GetTrackPage_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler")]
		public override unsafe void TrackPage (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			const string __id = "trackPage.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}

}
