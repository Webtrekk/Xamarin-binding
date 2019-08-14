using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='ExecuteRequest']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/ExecuteRequest", DoNotGenerateAcw=true)]
	public sealed partial class ExecuteRequest : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Domain.IInternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='ExecuteRequest.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/ExecuteRequest$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/ExecuteRequest$Params", typeof (Params));
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

			public unsafe global::Webtrekk.Android.Sdk.Data.Entity.DataTrack DataTrack {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='ExecuteRequest.Params']/method[@name='getDataTrack' and count(parameter)=0]"
				[Register ("getDataTrack", "()Lwebtrekk/android/sdk/data/entity/DataTrack;", "GetGetDataTrackHandler")]
				get {
					const string __id = "getDataTrack.()Lwebtrekk/android/sdk/data/entity/DataTrack;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.DataTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='ExecuteRequest.Params']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Lwebtrekk/android/sdk/data/entity/DataTrack;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Data.Entity.DataTrack Component2 ()
			{
				const string __id = "component2.()Lwebtrekk/android/sdk/data/entity/DataTrack;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.DataTrack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/ExecuteRequest", typeof (ExecuteRequest));
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

		internal ExecuteRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='ExecuteRequest']/constructor[@name='ExecuteRequest' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.data.repository.TrackRequestRepository'] and parameter[2][@type='webtrekk.android.sdk.api.datasource.SyncRequestsDataSource&lt;webtrekk.android.sdk.data.entity.DataTrack&gt;']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;Lwebtrekk/android/sdk/api/datasource/SyncRequestsDataSource;)V", "")]
		public unsafe ExecuteRequest (global::Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepository trackRequestRepository, global::Webtrekk.Android.Sdk.Api.Datasource.ISyncRequestsDataSource syncRequestsDataSource)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;Lwebtrekk/android/sdk/api/datasource/SyncRequestsDataSource;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((trackRequestRepository == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackRequestRepository).Handle);
				__args [1] = new JniArgumentValue ((syncRequestsDataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) syncRequestsDataSource).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
