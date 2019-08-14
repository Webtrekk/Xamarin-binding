using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Definition {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']"
	[global::Android.Runtime.Register ("org/koin/dsl/definition/Kind", DoNotGenerateAcw=true)]
	public sealed partial class Kind : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']/field[@name='Factory']"
		[Register ("Factory")]
		public static global::Org.Koin.Dsl.Definition.Kind Factory {
			get {
				const string __id = "Factory.Lorg/koin/dsl/definition/Kind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']/field[@name='Scope']"
		[Register ("Scope")]
		public static global::Org.Koin.Dsl.Definition.Kind Scope {
			get {
				const string __id = "Scope.Lorg/koin/dsl/definition/Kind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']/field[@name='Single']"
		[Register ("Single")]
		public static global::Org.Koin.Dsl.Definition.Kind Single {
			get {
				const string __id = "Single.Lorg/koin/dsl/definition/Kind;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/definition/Kind", typeof (Kind));
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

		internal Kind (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lorg/koin/dsl/definition/Kind;", "")]
		public static unsafe global::Org.Koin.Dsl.Definition.Kind ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lorg/koin/dsl/definition/Kind;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='Kind']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lorg/koin/dsl/definition/Kind;", "")]
		public static unsafe global::Org.Koin.Dsl.Definition.Kind[] Values ()
		{
			const string __id = "values.()[Lorg/koin/dsl/definition/Kind;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Org.Koin.Dsl.Definition.Kind[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Org.Koin.Dsl.Definition.Kind));
			} finally {
			}
		}

	}
}
