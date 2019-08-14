using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/entity/DataTrack", DoNotGenerateAcw=true)]
	public sealed partial class DataTrack : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/entity/DataTrack", typeof (DataTrack));
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

		internal DataTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/constructor[@name='DataTrack' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.List&lt;webtrekk.android.sdk.data.entity.CustomParam&gt;']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/List;)V", "")]
		public unsafe DataTrack (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> customParams)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_customParams = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.ToLocalJniHandle (customParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
				__args [1] = new JniArgumentValue (native_customParams);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_customParams);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> CustomParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='getCustomParams' and count(parameter)=0]"
			[Register ("getCustomParams", "()Ljava/util/List;", "GetGetCustomParamsHandler")]
			get {
				const string __id = "getCustomParams.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='setCustomParams' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;webtrekk.android.sdk.data.entity.CustomParam&gt;']]"
			[Register ("setCustomParams", "(Ljava/util/List;)V", "GetSetCustomParams_Ljava_util_List_Handler")]
			set {
				const string __id = "setCustomParams.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest TrackRequest {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='getTrackRequest' and count(parameter)=0]"
			[Register ("getTrackRequest", "()Lwebtrekk/android/sdk/data/entity/TrackRequest;", "GetGetTrackRequestHandler")]
			get {
				const string __id = "getTrackRequest.()Lwebtrekk/android/sdk/data/entity/TrackRequest;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='setTrackRequest' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest']]"
			[Register ("setTrackRequest", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)V", "GetSetTrackRequest_Lwebtrekk_android_sdk_data_entity_TrackRequest_Handler")]
			set {
				const string __id = "setTrackRequest.(Lwebtrekk/android/sdk/data/entity/TrackRequest;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Lwebtrekk/android/sdk/data/entity/TrackRequest;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest Component1 ()
		{
			const string __id = "component1.()Lwebtrekk/android/sdk/data/entity/TrackRequest;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> Component2 ()
		{
			const string __id = "component2.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='DataTrack']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.List&lt;webtrekk.android.sdk.data.entity.CustomParam&gt;']]"
		[Register ("copy", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/List;)Lwebtrekk/android/sdk/data/entity/DataTrack;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.DataTrack Copy (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam> customParams)
		{
			const string __id = "copy.(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/List;)Lwebtrekk/android/sdk/data/entity/DataTrack;";
			IntPtr native_customParams = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.CustomParam>.ToLocalJniHandle (customParams);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
				__args [1] = new JniArgumentValue (native_customParams);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.DataTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_customParams);
			}
		}

	}
}
