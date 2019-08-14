using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/entity/CustomParam", DoNotGenerateAcw=true)]
	public sealed partial class CustomParam : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/entity/CustomParam", typeof (CustomParam));
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

		internal CustomParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/constructor[@name='CustomParam' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(JJLjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CustomParam (long customParamId, long trackId, string paramKey, string paramValue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JJLjava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_paramKey = JNIEnv.NewString (paramKey);
			IntPtr native_paramValue = JNIEnv.NewString (paramValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (customParamId);
				__args [1] = new JniArgumentValue (trackId);
				__args [2] = new JniArgumentValue (native_paramKey);
				__args [3] = new JniArgumentValue (native_paramValue);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_paramKey);
				JNIEnv.DeleteLocalRef (native_paramValue);
			}
		}

		public unsafe long CustomParamId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='getCustomParamId' and count(parameter)=0]"
			[Register ("getCustomParamId", "()J", "GetGetCustomParamIdHandler")]
			get {
				const string __id = "getCustomParamId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='setCustomParamId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setCustomParamId", "(J)V", "GetSetCustomParamId_JHandler")]
			set {
				const string __id = "setCustomParamId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string ParamKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='getParamKey' and count(parameter)=0]"
			[Register ("getParamKey", "()Ljava/lang/String;", "GetGetParamKeyHandler")]
			get {
				const string __id = "getParamKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ParamValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='getParamValue' and count(parameter)=0]"
			[Register ("getParamValue", "()Ljava/lang/String;", "GetGetParamValueHandler")]
			get {
				const string __id = "getParamValue.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long TrackId {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='getTrackId' and count(parameter)=0]"
			[Register ("getTrackId", "()J", "GetGetTrackIdHandler")]
			get {
				const string __id = "getTrackId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()J", "")]
		public unsafe long Component1 ()
		{
			const string __id = "component1.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()J", "")]
		public unsafe long Component2 ()
		{
			const string __id = "component2.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/String;", "")]
		public unsafe string Component4 ()
		{
			const string __id = "component4.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='CustomParam']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("copy", "(JJLjava/lang/String;Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/CustomParam;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.CustomParam Copy (long customParamId, long trackId, string paramKey, string paramValue)
		{
			const string __id = "copy.(JJLjava/lang/String;Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/CustomParam;";
			IntPtr native_paramKey = JNIEnv.NewString (paramKey);
			IntPtr native_paramValue = JNIEnv.NewString (paramValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (customParamId);
				__args [1] = new JniArgumentValue (trackId);
				__args [2] = new JniArgumentValue (native_paramKey);
				__args [3] = new JniArgumentValue (native_paramValue);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_paramKey);
				JNIEnv.DeleteLocalRef (native_paramValue);
			}
		}

	}
}
