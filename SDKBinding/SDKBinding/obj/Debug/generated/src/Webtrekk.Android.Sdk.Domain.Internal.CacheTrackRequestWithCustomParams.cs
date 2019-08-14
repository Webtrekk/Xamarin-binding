using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams", DoNotGenerateAcw=true)]
	public sealed partial class CacheTrackRequestWithCustomParams : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Domain.IInternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams$Params", typeof (Params));
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

			internal Params (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/constructor[@name='CacheTrackRequestWithCustomParams.Params' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register (".ctor", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;)V", "")]
			public unsafe Params (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IDictionary<string, string> trackingParams)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_trackingParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (trackingParams);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					__args [1] = new JniArgumentValue (native_trackingParams);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_trackingParams);
				}
			}

			public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest TrackRequest {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/method[@name='getTrackRequest' and count(parameter)=0]"
				[Register ("getTrackRequest", "()Lwebtrekk/android/sdk/data/entity/TrackRequest;", "GetGetTrackRequestHandler")]
				get {
					const string __id = "getTrackRequest.()Lwebtrekk/android/sdk/data/entity/TrackRequest;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe global::System.Collections.Generic.IDictionary<string, string> TrackingParams {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/method[@name='getTrackingParams' and count(parameter)=0]"
				[Register ("getTrackingParams", "()Ljava/util/Map;", "GetGetTrackingParamsHandler")]
				get {
					const string __id = "getTrackingParams.()Ljava/util/Map;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Ljava/util/Map;", "")]
			public unsafe global::System.Collections.Generic.IDictionary<string, string> Component2 ()
			{
				const string __id = "component2.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams.Params']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("copy", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;)Lwebtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams$Params;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Domain.Internal.CacheTrackRequestWithCustomParams.Params Copy (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IDictionary<string, string> trackingParams)
			{
				const string __id = "copy.(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;)Lwebtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams$Params;";
				IntPtr native_trackingParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (trackingParams);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					__args [1] = new JniArgumentValue (native_trackingParams);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.Internal.CacheTrackRequestWithCustomParams.Params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_trackingParams);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/CacheTrackRequestWithCustomParams", typeof (CacheTrackRequestWithCustomParams));
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

		internal CacheTrackRequestWithCustomParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequestWithCustomParams']/constructor[@name='CacheTrackRequestWithCustomParams' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.repository.TrackRequestRepository'] and parameter[2][@type='webtrekk.android.sdk.data.repository.CustomParamRepository']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;Lwebtrekk/android/sdk/data/repository/CustomParamRepository;)V", "")]
		public unsafe CacheTrackRequestWithCustomParams (global::Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepository trackRequestRepository, global::Webtrekk.Android.Sdk.Data.Repository.ICustomParamRepository customParamRepository)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;Lwebtrekk/android/sdk/data/repository/CustomParamRepository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((trackRequestRepository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequestRepository).Handle);
				__args [1] = new JniArgumentValue ((customParamRepository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customParamRepository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
