using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Standalone {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']"
	[global::Android.Runtime.Register ("org/koin/standalone/StandAloneContext", DoNotGenerateAcw=true)]
	public sealed partial class StandAloneContext : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Org.Koin.Standalone.StandAloneContext Instance {
			get {
				const string __id = "INSTANCE.Lorg/koin/standalone/StandAloneContext;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Standalone.StandAloneContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/standalone/StandAloneContext", typeof (StandAloneContext));
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

		internal StandAloneContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Org.Koin.Core.Koin Koin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='getKoin' and count(parameter)=0]"
			[Register ("getKoin", "()Lorg/koin/core/Koin;", "GetGetKoinHandler")]
			get {
				const string __id = "getKoin.()Lorg/koin/core/Koin;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Koin> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='closeKoin' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("closeKoin", "()V", "")]
		public unsafe void CloseKoin ()
		{
			const string __id = "closeKoin.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='registerModuleCallBack' and count(parameter)=1 and parameter[1][@type='org.koin.core.instance.ModuleCallBack']]"
		[Obsolete (@"deprecated")]
		[Register ("registerModuleCallBack", "(Lorg/koin/core/instance/ModuleCallBack;)V", "")]
		public unsafe void RegisterModuleCallBack (global::Org.Koin.Core.Instance.IModuleCallBack @callback)
		{
			const string __id = "registerModuleCallBack.(Lorg/koin/core/instance/ModuleCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='registerScopeCallback' and count(parameter)=1 and parameter[1][@type='org.koin.core.scope.ScopeCallback']]"
		[Register ("registerScopeCallback", "(Lorg/koin/core/scope/ScopeCallback;)V", "")]
		public unsafe void RegisterScopeCallback (global::Org.Koin.Core.Scope.IScopeCallback @callback)
		{
			const string __id = "registerScopeCallback.(Lorg/koin/core/scope/ScopeCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='setup' and count(parameter)=1 and parameter[1][@type='org.koin.core.Koin']]"
		[Register ("setup", "(Lorg/koin/core/Koin;)V", "")]
		public unsafe void Setup (global::Org.Koin.Core.Koin newKoinInstance)
		{
			const string __id = "setup.(Lorg/koin/core/Koin;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newKoinInstance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newKoinInstance).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.standalone']/class[@name='StandAloneContext']/method[@name='stopKoin' and count(parameter)=0]"
		[Register ("stopKoin", "()V", "")]
		public unsafe void StopKoin ()
		{
			const string __id = "stopKoin.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
