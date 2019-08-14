using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Ext {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.ext']/class[@name='StringExtKt']"
	[global::Android.Runtime.Register ("org/koin/ext/StringExtKt", DoNotGenerateAcw=true)]
	public sealed partial class StringExtKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/ext/StringExtKt", typeof (StringExtKt));
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

		internal StringExtKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.ext']/class[@name='StringExtKt']/method[@name='castValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("castValue", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CastValue (string _receiver_)
		{
			const string __id = "castValue.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native__receiver_ = JNIEnv.NewString (_receiver_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__receiver_);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__receiver_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.ext']/class[@name='StringExtKt']/method[@name='checkedStringValue' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("checkedStringValue", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object CheckedStringValue (global::Java.Lang.Object _receiver_)
		{
			const string __id = "checkedStringValue.(Ljava/lang/Object;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((_receiver_ == null) ? IntPtr.Zero : ((global::Java.Lang.Object) _receiver_).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.ext']/class[@name='StringExtKt']/method[@name='isFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFloat", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFloat (string _receiver_)
		{
			const string __id = "isFloat.(Ljava/lang/String;)Z";
			IntPtr native__receiver_ = JNIEnv.NewString (_receiver_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__receiver_);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__receiver_);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.ext']/class[@name='StringExtKt']/method[@name='isInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isInt", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsInt (string _receiver_)
		{
			const string __id = "isInt.(Ljava/lang/String;)Z";
			IntPtr native__receiver_ = JNIEnv.NewString (_receiver_);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__receiver_);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native__receiver_);
			}
		}

	}
}
