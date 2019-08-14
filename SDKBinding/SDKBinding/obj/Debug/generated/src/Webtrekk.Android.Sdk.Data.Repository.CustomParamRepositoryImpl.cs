using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Repository {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.repository']/class[@name='CustomParamRepositoryImpl']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/repository/CustomParamRepositoryImpl", DoNotGenerateAcw=true)]
	public sealed partial class CustomParamRepositoryImpl : global::Java.Lang.Object, global::Webtrekk.Android.Sdk.Data.Repository.ICustomParamRepository {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/repository/CustomParamRepositoryImpl", typeof (CustomParamRepositoryImpl));
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

		internal CustomParamRepositoryImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.data.repository']/class[@name='CustomParamRepositoryImpl']/constructor[@name='CustomParamRepositoryImpl' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.dao.CustomParamDao']]"
		[Register (".ctor", "(Lwebtrekk/android/sdk/data/dao/CustomParamDao;)V", "")]
		public unsafe CustomParamRepositoryImpl (global::Webtrekk.Android.Sdk.Data.Dao.ICustomParamDao customParamDao)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lwebtrekk/android/sdk/data/dao/CustomParamDao;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((customParamDao == null) ? IntPtr.Zero : ((global::Java.Lang.Object) customParamDao).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
