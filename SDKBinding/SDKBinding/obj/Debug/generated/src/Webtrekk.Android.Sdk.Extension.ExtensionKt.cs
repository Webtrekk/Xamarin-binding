using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Extension {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ExtensionKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/extension/ExtensionKt", DoNotGenerateAcw=true)]
	public sealed partial class ExtensionKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/extension/ExtensionKt", typeof (ExtensionKt));
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

		internal ExtensionKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ExtensionKt']/method[@name='encodeToUTF8' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeToUTF8", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeToUTF8 (string _this_encodeToUTF8_)
		{
			const string __id = "encodeToUTF8.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native__this_encodeToUTF8_ = JNIEnv.NewString (_this_encodeToUTF8_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__this_encodeToUTF8_);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__this_encodeToUTF8_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.extension']/class[@name='ExtensionKt']/method[@name='validateEntireList' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;? extends T&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("validateEntireList", "(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ValidateEntireList (global::System.Collections.IList _this_validateEntireList_, global::Java.Lang.Object propertyName)
		{
			const string __id = "validateEntireList.(Ljava/util/List;Ljava/lang/Object;)Ljava/util/List;";
			IntPtr native__this_validateEntireList_ = global::Android.Runtime.JavaList.ToLocalJniHandle (_this_validateEntireList_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native__this_validateEntireList_);
				__args [1] = new JniArgumentValue ((propertyName == null) ? IntPtr.Zero : ((global::Java.Lang.Object) propertyName).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__this_validateEntireList_);
			}
		}

	}
}
