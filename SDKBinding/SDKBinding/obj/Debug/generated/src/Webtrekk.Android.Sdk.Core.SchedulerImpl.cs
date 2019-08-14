using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/SchedulerImpl", DoNotGenerateAcw=true)]
	public sealed partial class SchedulerImpl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Core.IScheduler {


		// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl']/field[@name='SEND_REQUESTS_WORKER']"
		[Register ("SEND_REQUESTS_WORKER")]
		public const string SendRequestsWorker = (string) "send_requests_worker";
		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl.Companion']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/core/SchedulerImpl$Companion", DoNotGenerateAcw=true)]
		public sealed partial class Companion : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/SchedulerImpl$Companion", typeof (Companion));
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

			internal Companion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/core/SchedulerImpl", typeof (SchedulerImpl));
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

		internal SchedulerImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl']/method[@name='cancelScheduleSendRequests' and count(parameter)=0]"
		[Register ("cancelScheduleSendRequests", "()V", "")]
		public unsafe void CancelScheduleSendRequests ()
		{
			const string __id = "cancelScheduleSendRequests.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl']/method[@name='scheduleCleanUp' and count(parameter)=0]"
		[Register ("scheduleCleanUp", "()V", "")]
		public unsafe void ScheduleCleanUp ()
		{
			const string __id = "scheduleCleanUp.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/class[@name='SchedulerImpl']/method[@name='sendRequestsThenCleanUp' and count(parameter)=0]"
		[Register ("sendRequestsThenCleanUp", "()V", "")]
		public unsafe void SendRequestsThenCleanUp ()
		{
			const string __id = "sendRequestsThenCleanUp.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
