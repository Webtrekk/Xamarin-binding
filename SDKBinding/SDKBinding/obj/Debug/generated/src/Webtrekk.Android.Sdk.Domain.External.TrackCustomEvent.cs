using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/external/TrackCustomEvent", DoNotGenerateAcw=true)]
	public sealed partial class TrackCustomEvent : global::Java.Lang.Object, global::Org.Koin.Standalone.IKoinComponent, global::Webtrekk.Android.Sdk.Domain.IExternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/external/TrackCustomEvent$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/external/TrackCustomEvent$Params", typeof (Params));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/constructor[@name='TrackCustomEvent.Params' and count(parameter)=3 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;Z)V", "")]
			public unsafe Params (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IDictionary<string, string> trackingParams, bool isOptOut)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_trackingParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (trackingParams);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					__args [1] = new JniArgumentValue (native_trackingParams);
					__args [2] = new JniArgumentValue (isOptOut);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_trackingParams);
				}
			}

			public unsafe bool IsOptOut {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='isOptOut' and count(parameter)=0]"
				[Register ("isOptOut", "()Z", "GetIsOptOutHandler")]
				get {
					const string __id = "isOptOut.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest TrackRequest {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='getTrackRequest' and count(parameter)=0]"
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
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='getTrackingParams' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='component2' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='component3' and count(parameter)=0]"
			[Register ("component3", "()Z", "")]
			public unsafe bool Component3 ()
			{
				const string __id = "component3.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent.Params']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='boolean']]"
			[Register ("copy", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;Z)Lwebtrekk/android/sdk/domain/external/TrackCustomEvent$Params;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Domain.External.TrackCustomEvent.Params Copy (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest, global::System.Collections.Generic.IDictionary<string, string> trackingParams, bool isOptOut)
			{
				const string __id = "copy.(Lwebtrekk/android/sdk/data/entity/TrackRequest;Ljava/util/Map;Z)Lwebtrekk/android/sdk/domain/external/TrackCustomEvent$Params;";
				IntPtr native_trackingParams = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (trackingParams);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					__args [1] = new JniArgumentValue (native_trackingParams);
					__args [2] = new JniArgumentValue (isOptOut);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.External.TrackCustomEvent.Params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_trackingParams);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/external/TrackCustomEvent", typeof (TrackCustomEvent));
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

		internal TrackCustomEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Org.Koin.Core.KoinContext Koin {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent']/method[@name='getKoin' and count(parameter)=0]"
			[Register ("getKoin", "()Lorg/koin/core/KoinContext;", "GetGetKoinHandler")]
			get {
				const string __id = "getKoin.()Lorg/koin/core/KoinContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='TrackCustomEvent']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.domain.external.TrackCustomEvent.Params'] and parameter[2][@type='webtrekk.android.sdk.util.CoroutineDispatchers']]"
		[Register ("invoke", "(Lwebtrekk/android/sdk/domain/external/TrackCustomEvent$Params;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V", "")]
		public unsafe void Invoke (global::Webtrekk.Android.Sdk.Domain.External.TrackCustomEvent.Params invokeParams, global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers coroutineDispatchers)
		{
			const string __id = "invoke.(Lwebtrekk/android/sdk/domain/external/TrackCustomEvent$Params;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((invokeParams == null) ? IntPtr.Zero : ((global::Java.Lang.Object) invokeParams).Handle);
				__args [1] = new JniArgumentValue ((coroutineDispatchers == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coroutineDispatchers).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// This method is explicitly implemented as a member of an instantiated Webtrekk.Android.Sdk.Domain.IExternalInteractor
		void global::Webtrekk.Android.Sdk.Domain.IExternalInteractor.Invoke (global::Java.Lang.Object p0, global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers p1)
		{
			Invoke (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Webtrekk.Android.Sdk.Domain.External.TrackCustomEvent.Params>(p0), p1);
		}

	}
}
