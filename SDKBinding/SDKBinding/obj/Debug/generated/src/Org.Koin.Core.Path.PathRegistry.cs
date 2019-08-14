using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Path {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']"
	[global::Android.Runtime.Register ("org/koin/core/path/PathRegistry", DoNotGenerateAcw=true)]
	public sealed partial class PathRegistry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/path/PathRegistry", typeof (PathRegistry));
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

		internal PathRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/constructor[@name='PathRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PathRegistry ()
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

		public unsafe global::Java.Util.HashSet Paths {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='getPaths' and count(parameter)=0]"
			[Register ("getPaths", "()Ljava/util/HashSet;", "GetGetPathsHandler")]
			get {
				const string __id = "getPaths.()Ljava/util/HashSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.HashSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='getAllPathsFrom' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAllPathsFrom", "(Ljava/lang/String;)Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Org.Koin.Dsl.Path.Path> GetAllPathsFrom (string path)
		{
			const string __id = "getAllPathsFrom.(Ljava/lang/String;)Ljava/util/Set;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaSet<global::Org.Koin.Dsl.Path.Path>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='getPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPath", "(Ljava/lang/String;)Lorg/koin/dsl/path/Path;", "")]
		public unsafe global::Org.Koin.Dsl.Path.Path GetPath (string path)
		{
			const string __id = "getPath.(Ljava/lang/String;)Lorg/koin/dsl/path/Path;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='makePath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("makePath", "(Ljava/lang/String;Ljava/lang/String;)Lorg/koin/dsl/path/Path;", "")]
		public unsafe global::Org.Koin.Dsl.Path.Path MakePath (string path, string parentPath)
		{
			const string __id = "makePath.(Ljava/lang/String;Ljava/lang/String;)Lorg/koin/dsl/path/Path;";
			IntPtr native_path = JNIEnv.NewString (path);
			IntPtr native_parentPath = JNIEnv.NewString (parentPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (native_parentPath);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
				JNIEnv.DeleteLocalRef (native_parentPath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.path']/class[@name='PathRegistry']/method[@name='savePath' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.path.Path']]"
		[Register ("savePath", "(Lorg/koin/dsl/path/Path;)V", "")]
		public unsafe void SavePath (global::Org.Koin.Dsl.Path.Path path)
		{
			const string __id = "savePath.(Lorg/koin/dsl/path/Path;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
