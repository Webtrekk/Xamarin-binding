using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Instance {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.instance']/class[@name='ResolutionRequest']"
	[global::Android.Runtime.Register ("org/koin/core/instance/ResolutionRequest", DoNotGenerateAcw=true)]
	public abstract partial class ResolutionRequest : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/instance/ResolutionRequest", typeof (ResolutionRequest));
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

		protected ResolutionRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}

	[global::Android.Runtime.Register ("org/koin/core/instance/ResolutionRequest", DoNotGenerateAcw=true)]
	internal partial class ResolutionRequestInvoker : ResolutionRequest {

		public ResolutionRequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/koin/core/instance/ResolutionRequest", typeof (ResolutionRequestInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
