using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamTypeKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/ParamTypeKt", DoNotGenerateAcw=true)]
	public sealed partial class ParamTypeKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/ParamTypeKt", typeof (ParamTypeKt));
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

		internal ParamTypeKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk']/class[@name='ParamTypeKt']/method[@name='createCustomParam' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.ParamType'] and parameter[2][@type='int']]"
		[Register ("createCustomParam", "(Lwebtrekk/android/sdk/ParamType;I)Ljava/lang/String;", "")]
		public static unsafe string CreateCustomParam (global::Webtrekk.Android.Sdk.ParamType paramType, int value)
		{
			const string __id = "createCustomParam.(Lwebtrekk/android/sdk/ParamType;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paramType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paramType).Handle);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
