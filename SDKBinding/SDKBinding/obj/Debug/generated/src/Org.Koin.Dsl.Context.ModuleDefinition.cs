using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Context {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']"
	[global::Android.Runtime.Register ("org/koin/dsl/context/ModuleDefinition", DoNotGenerateAcw=true)]
	public sealed partial class ModuleDefinition : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/context/ModuleDefinition", typeof (ModuleDefinition));
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

		internal ModuleDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/constructor[@name='ModuleDefinition' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='org.koin.core.KoinContext']]"
		[Register (".ctor", "(Ljava/lang/String;ZZLorg/koin/core/KoinContext;)V", "")]
		public unsafe ModuleDefinition (string path, bool createOnStart, bool @override, global::Org.Koin.Core.KoinContext koinContext)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;ZZLorg/koin/core/KoinContext;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (createOnStart);
				__args [2] = new JniArgumentValue (@override);
				__args [3] = new JniArgumentValue ((koinContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) koinContext).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		public unsafe bool CreateOnStart {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getCreateOnStart' and count(parameter)=0]"
			[Register ("getCreateOnStart", "()Z", "GetGetCreateOnStartHandler")]
			get {
				const string __id = "getCreateOnStart.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Org.Koin.Dsl.Definition.BeanDefinition> Definitions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getDefinitions' and count(parameter)=0]"
			[Register ("getDefinitions", "()Ljava/util/ArrayList;", "GetGetDefinitionsHandler")]
			get {
				const string __id = "getDefinitions.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Koin.Dsl.Definition.BeanDefinition>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Core.KoinContext KoinContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getKoinContext' and count(parameter)=0]"
			[Register ("getKoinContext", "()Lorg/koin/core/KoinContext;", "GetGetKoinContextHandler")]
			get {
				const string __id = "getKoinContext.()Lorg/koin/core/KoinContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Override {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getOverride' and count(parameter)=0]"
			[Register ("getOverride", "()Z", "GetGetOverrideHandler")]
			get {
				const string __id = "getOverride.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Org.Koin.Dsl.Context.ModuleDefinition> SubModules {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.context']/class[@name='ModuleDefinition']/method[@name='getSubModules' and count(parameter)=0]"
			[Register ("getSubModules", "()Ljava/util/ArrayList;", "GetGetSubModulesHandler")]
			get {
				const string __id = "getSubModules.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Org.Koin.Dsl.Context.ModuleDefinition>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
