using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ContextExtensionKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/extension/ContextExtensionKt", DoNotGenerateAcw=true)]
	public sealed partial class ContextExtensionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/extension/ContextExtensionKt", typeof (ContextExtensionKt));
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

		internal ContextExtensionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ContextExtensionKt']/method[@name='getAppVersionCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionCode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersionCode (global::Android.Content.Context _this_appVersionCode_)
		{
			const string __id = "getAppVersionCode.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_appVersionCode_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_appVersionCode_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ContextExtensionKt']/method[@name='getAppVersionName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersionName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppVersionName (global::Android.Content.Context _this_appVersionName_)
		{
			const string __id = "getAppVersionName.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_appVersionName_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_appVersionName_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ContextExtensionKt']/method[@name='isPortrait' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isPortrait", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsPortrait (global::Android.Content.Context _this_isPortrait_)
		{
			const string __id = "isPortrait.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_isPortrait_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_isPortrait_).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ContextExtensionKt']/method[@name='resolution' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("resolution", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string Resolution (global::Android.Content.Context _this_resolution_)
		{
			const string __id = "resolution.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_this_resolution_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _this_resolution_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
