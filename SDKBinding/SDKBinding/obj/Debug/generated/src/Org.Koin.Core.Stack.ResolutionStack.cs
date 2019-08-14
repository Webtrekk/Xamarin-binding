using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Stack {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']"
	[global::Android.Runtime.Register ("org/koin/core/stack/ResolutionStack", DoNotGenerateAcw=true)]
	public sealed partial class ResolutionStack : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/stack/ResolutionStack", typeof (ResolutionStack));
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

		internal ResolutionStack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']/constructor[@name='ResolutionStack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResolutionStack ()
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

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']/method[@name='indent' and count(parameter)=0]"
		[Register ("indent", "()Ljava/lang/String;", "")]
		public unsafe string Indent ()
		{
			const string __id = "indent.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.stack']/class[@name='ResolutionStack']/method[@name='last' and count(parameter)=0]"
		[Register ("last", "()Lorg/koin/dsl/definition/BeanDefinition;", "")]
		public unsafe global::Org.Koin.Dsl.Definition.BeanDefinition Last ()
		{
			const string __id = "last.()Lorg/koin/dsl/definition/BeanDefinition;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.BeanDefinition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
