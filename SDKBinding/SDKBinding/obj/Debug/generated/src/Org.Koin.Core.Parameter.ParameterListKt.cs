using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Parameter {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterListKt']"
	[global::Android.Runtime.Register ("org/koin/core/parameter/ParameterListKt", DoNotGenerateAcw=true)]
	public sealed partial class ParameterListKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/parameter/ParameterListKt", typeof (ParameterListKt));
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

		internal ParameterListKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterListKt']/method[@name='parametersOf' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("parametersOf", "([Ljava/lang/Object;)Lorg/koin/core/parameter/ParameterList;", "")]
		public static unsafe global::Org.Koin.Core.Parameter.ParameterList ParametersOf (params global::Java.Lang.Object[] value)
		{
			const string __id = "parametersOf.([Ljava/lang/Object;)Lorg/koin/core/parameter/ParameterList;";
			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Parameter.ParameterList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
