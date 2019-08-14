using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/GetCachedDataTracks", DoNotGenerateAcw=true)]
	public sealed partial class GetCachedDataTracks : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Domain.IInternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/internal/GetCachedDataTracks$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/GetCachedDataTracks$Params", typeof (Params));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks.Params']/constructor[@name='GetCachedDataTracks.Params' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends webtrekk.android.sdk.data.entity.TrackRequest.RequestState&gt;']]"
			[Register (".ctor", "(Ljava/util/List;)V", "")]
			public unsafe Params (global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> requestStates)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/util/List;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_requestStates = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState>.ToLocalJniHandle (requestStates);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_requestStates);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_requestStates);
				}
			}

			public unsafe global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> RequestStates {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks.Params']/method[@name='getRequestStates' and count(parameter)=0]"
				[Register ("getRequestStates", "()Ljava/util/List;", "GetGetRequestStatesHandler")]
				get {
					const string __id = "getRequestStates.()Ljava/util/List;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks.Params']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Ljava/util/List;", "")]
			public unsafe global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> Component1 ()
			{
				const string __id = "component1.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks.Params']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;? extends webtrekk.android.sdk.data.entity.TrackRequest.RequestState&gt;']]"
			[Register ("copy", "(Ljava/util/List;)Lwebtrekk/android/sdk/domain/internal/GetCachedDataTracks$Params;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Domain.Internal.GetCachedDataTracks.Params Copy (global::System.Collections.Generic.IList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> requestStates)
			{
				const string __id = "copy.(Ljava/util/List;)Lwebtrekk/android/sdk/domain/internal/GetCachedDataTracks$Params;";
				IntPtr native_requestStates = global::Android.Runtime.JavaList<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState>.ToLocalJniHandle (requestStates);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_requestStates);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.Internal.GetCachedDataTracks.Params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_requestStates);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/internal/GetCachedDataTracks", typeof (GetCachedDataTracks));
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

		internal GetCachedDataTracks (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.internal']/class[@name='GetCachedDataTracks']/constructor[@name='GetCachedDataTracks' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.repository.TrackRequestRepository']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/repository/TrackRequestRepository;)V", "")]
		public unsafe GetCachedDataTracks (global::Webtrekk.Android.Sdk.Data.Repository.ITrackRequestRepository trackRequestRepository)
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
