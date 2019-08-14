using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Path {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']"
	[global::Android.Runtime.Register ("org/koin/dsl/path/Path", DoNotGenerateAcw=true)]
	public sealed partial class Path : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/field[@name='ROOT']"
		[Register ("ROOT")]
		public const string Root = (string) "";
		// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path.Companion']"
		[global::Android.Runtime.Register ("org/koin/dsl/path/Path$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/path/Path$Companion", typeof (Companion));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path.Companion']/method[@name='root' and count(parameter)=0]"
			[Register ("root", "()Lorg/koin/dsl/path/Path;", "")]
			public unsafe global::Org.Koin.Dsl.Path.Path Root ()
			{
				const string __id = "root.()Lorg/koin/dsl/path/Path;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/path/Path", typeof (Path));
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

		internal Path (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/constructor[@name='Path' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.koin.dsl.path.Path']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/koin/dsl/path/Path;)V", "")]
		public unsafe Path (string name, global::Org.Koin.Dsl.Path.Path parent)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/koin/dsl/path/Path;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Dsl.Path.Path Parent {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='getParent' and count(parameter)=0]"
			[Register ("getParent", "()Lorg/koin/dsl/path/Path;", "GetGetParentHandler")]
			get {
				const string __id = "getParent.()Lorg/koin/dsl/path/Path;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Lorg/koin/dsl/path/Path;", "")]
		public unsafe global::Org.Koin.Dsl.Path.Path Component2 ()
		{
			const string __id = "component2.()Lorg/koin/dsl/path/Path;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.koin.dsl.path.Path']]"
		[Register ("copy", "(Ljava/lang/String;Lorg/koin/dsl/path/Path;)Lorg/koin/dsl/path/Path;", "")]
		public unsafe global::Org.Koin.Dsl.Path.Path Copy (string name, global::Org.Koin.Dsl.Path.Path parent)
		{
			const string __id = "copy.(Ljava/lang/String;Lorg/koin/dsl/path/Path;)Lorg/koin/dsl/path/Path;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((parent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parent).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.path']/class[@name='Path']/method[@name='isVisible' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.path.Path']]"
		[Register ("isVisible", "(Lorg/koin/dsl/path/Path;)Z", "")]
		public unsafe bool IsVisible (global::Org.Koin.Dsl.Path.Path p)
		{
			const string __id = "isVisible.(Lorg/koin/dsl/path/Path;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
