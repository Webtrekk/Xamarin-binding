using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance.Holder {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']"
	[global::Android.Runtime.Register ("org/koin/core/instance/holder/Instance", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class Instance : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/holder/Instance", typeof (Instance));
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

		internal Instance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/constructor[@name='Instance' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/Object;Z)V", "")]
		public unsafe Instance (global::Java.Lang.Object value, bool created)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (created);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		public unsafe bool Created {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/method[@name='getCreated' and count(parameter)=0]"
			[Register ("getCreated", "()Z", "GetGetCreatedHandler")]
			get {
				const string __id = "getCreated.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()Ljava/lang/Object;", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Component1 ()
		{
			const string __id = "component1.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Z", "")]
		public unsafe bool Component2 ()
		{
			const string __id = "component2.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.instance.holder']/class[@name='Instance']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='boolean']]"
		[Register ("copy", "(Ljava/lang/Object;Z)Lorg/koin/core/instance/holder/Instance;", "")]
		public unsafe global::Org.Koin.Core.Instance.Holder.Instance Copy (global::Java.Lang.Object value, bool created)
		{
			const string __id = "copy.(Ljava/lang/Object;Z)Lorg/koin/core/instance/holder/Instance;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_value);
				__args [1] = new JniArgumentValue (created);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.Instance.Holder.Instance> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
