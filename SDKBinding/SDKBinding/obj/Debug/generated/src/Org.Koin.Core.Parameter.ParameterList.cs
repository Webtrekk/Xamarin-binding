using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Parameter {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']"
	[global::Android.Runtime.Register ("org/koin/core/parameter/ParameterList", DoNotGenerateAcw=true)]
	public sealed partial class ParameterList : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/parameter/ParameterList", typeof (ParameterList));
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

		internal ParameterList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/constructor[@name='ParameterList' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register (".ctor", "([Ljava/lang/Object;)V", "")]
		public unsafe ParameterList (params global::Java.Lang.Object[] value)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_value = JNIEnv.NewArray (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (value != null) {
					JNIEnv.CopyArray (native_value, value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<object> Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/List;", "GetGetValuesHandler")]
			get {
				const string __id = "getValues.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Component1 ()
		{
			const string __id = "component1.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Component2 ()
		{
			const string __id = "component2.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Component3 ()
		{
			const string __id = "component3.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Component4 ()
		{
			const string __id = "component4.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Component5 ()
		{
			const string __id = "component5.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.parameter']/class[@name='ParameterList']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object Get (int i)
		{
			const string __id = "get.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
