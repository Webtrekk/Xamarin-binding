using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Core {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Scheduler']"
	[Register ("webtrekk/android/sdk/core/Scheduler", "", "Webtrekk.Android.Sdk.Core.ISchedulerInvoker")]
	public partial interface IScheduler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Scheduler']/method[@name='cancelScheduleSendRequests' and count(parameter)=0]"
		[Register ("cancelScheduleSendRequests", "()V", "GetCancelScheduleSendRequestsHandler:Webtrekk.Android.Sdk.Core.ISchedulerInvoker, SDKBinding")]
		void CancelScheduleSendRequests ();

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Scheduler']/method[@name='scheduleCleanUp' and count(parameter)=0]"
		[Register ("scheduleCleanUp", "()V", "GetScheduleCleanUpHandler:Webtrekk.Android.Sdk.Core.ISchedulerInvoker, SDKBinding")]
		void ScheduleCleanUp ();

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.core']/interface[@name='Scheduler']/method[@name='sendRequestsThenCleanUp' and count(parameter)=0]"
		[Register ("sendRequestsThenCleanUp", "()V", "GetSendRequestsThenCleanUpHandler:Webtrekk.Android.Sdk.Core.ISchedulerInvoker, SDKBinding")]
		void SendRequestsThenCleanUp ();

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/core/Scheduler", DoNotGenerateAcw=true)]
	internal class ISchedulerInvoker : global::Java.Lang.Object, IScheduler {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/core/Scheduler", typeof (ISchedulerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IScheduler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IScheduler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.core.Scheduler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISchedulerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_cancelScheduleSendRequests;
#pragma warning disable 0169
		static Delegate GetCancelScheduleSendRequestsHandler ()
		{
			if (cb_cancelScheduleSendRequests == null)
				cb_cancelScheduleSendRequests = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelScheduleSendRequests);
			return cb_cancelScheduleSendRequests;
		}

		static void n_CancelScheduleSendRequests (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.IScheduler __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.IScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelScheduleSendRequests ();
		}
#pragma warning restore 0169

		IntPtr id_cancelScheduleSendRequests;
		public unsafe void CancelScheduleSendRequests ()
		{
			if (id_cancelScheduleSendRequests == IntPtr.Zero)
				id_cancelScheduleSendRequests = JNIEnv.GetMethodID (class_ref, "cancelScheduleSendRequests", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelScheduleSendRequests);
		}

		static Delegate cb_scheduleCleanUp;
#pragma warning disable 0169
		static Delegate GetScheduleCleanUpHandler ()
		{
			if (cb_scheduleCleanUp == null)
				cb_scheduleCleanUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ScheduleCleanUp);
			return cb_scheduleCleanUp;
		}

		static void n_ScheduleCleanUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.IScheduler __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.IScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScheduleCleanUp ();
		}
#pragma warning restore 0169

		IntPtr id_scheduleCleanUp;
		public unsafe void ScheduleCleanUp ()
		{
			if (id_scheduleCleanUp == IntPtr.Zero)
				id_scheduleCleanUp = JNIEnv.GetMethodID (class_ref, "scheduleCleanUp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_scheduleCleanUp);
		}

		static Delegate cb_sendRequestsThenCleanUp;
#pragma warning disable 0169
		static Delegate GetSendRequestsThenCleanUpHandler ()
		{
			if (cb_sendRequestsThenCleanUp == null)
				cb_sendRequestsThenCleanUp = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendRequestsThenCleanUp);
			return cb_sendRequestsThenCleanUp;
		}

		static void n_SendRequestsThenCleanUp (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Core.IScheduler __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Core.IScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendRequestsThenCleanUp ();
		}
#pragma warning restore 0169

		IntPtr id_sendRequestsThenCleanUp;
		public unsafe void SendRequestsThenCleanUp ()
		{
			if (id_sendRequestsThenCleanUp == IntPtr.Zero)
				id_sendRequestsThenCleanUp = JNIEnv.GetMethodID (class_ref, "sendRequestsThenCleanUp", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendRequestsThenCleanUp);
		}

	}

}
