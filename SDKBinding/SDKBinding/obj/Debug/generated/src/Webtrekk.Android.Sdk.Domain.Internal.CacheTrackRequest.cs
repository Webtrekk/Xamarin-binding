using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/CacheTrackRequest", DoNotGenerateAcw=true)]
	public sealed partial class CacheTrackRequest : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Domain.IInternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/CacheTrackRequest$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/CacheTrackRequest$Params", typeof (Params));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest.Params']/constructor[@name='CacheTrackRequest.Params' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest']]"
			[Register (".ctor", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)V", "")]
			public unsafe Params (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest TrackRequest {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest.Params']/method[@name='getTrackRequest' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest.Params']/method[@name='component1' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest.Params']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest']]"
			[Register ("copy", "(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Lwebtrekk/android/sdk/domain/internal/CacheTrackRequest$Params;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Domain.Internal.CacheTrackRequest.Params Copy (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest trackRequest)
			{
				const string __id = "copy.(Lwebtrekk/android/sdk/data/entity/TrackRequest;)Lwebtrekk/android/sdk/domain/internal/CacheTrackRequest$Params;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((trackRequest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequest).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.Internal.CacheTrackRequest.Params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/CacheTrackRequest", typeof (CacheTrackRequest));
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

		internal CacheTrackRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='CacheTrackRequest']/constructor[@name='CacheTrackRequest' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.repository.TrackRequestRepository']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;)V", "")]
		public unsafe CacheTrackRequest (global::Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepository trackRequestRepository)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((trackRequestRepository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequestRepository).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
