using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Domain.External {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/external/AutoTrack", DoNotGenerateAcw=true)]
	public sealed partial class AutoTrack : global::Java.Lang.Object, global::Org.Koin.Standalone.IKoinComponent, global::Webtrekk.Android.Sdk.Domain.IExternalInteractor {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/domain/external/AutoTrack$Params", DoNotGenerateAcw=true)]
		public sealed partial class Params : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/external/AutoTrack$Params", typeof (Params));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/constructor[@name='AutoTrack.Params' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Landroid/content/Context;Z)V", "")]
			public unsafe Params (global::Android.Content.Context context, bool isOptOut)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (isOptOut);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			public unsafe global::Android.Content.Context Context {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/method[@name='getContext' and count(parameter)=0]"
				[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
				get {
					const string __id = "getContext.()Landroid/content/Context;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			public unsafe bool IsOptOut {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/method[@name='isOptOut' and count(parameter)=0]"
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

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/method[@name='component1' and count(parameter)=0]"
			[Register ("component1", "()Landroid/content/Context;", "")]
			public unsafe global::Android.Content.Context Component1 ()
			{
				const string __id = "component1.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/method[@name='component2' and count(parameter)=0]"
			[Register ("component2", "()Z", "")]
			public unsafe bool Component2 ()
			{
				const string __id = "component2.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack.Params']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
			[Register ("copy", "(Landroid/content/Context;Z)Lwebtrekk/android/sdk/domain/external/AutoTrack$Params;", "")]
			public unsafe global::Webtrekk.Android.Sdk.Domain.External.AutoTrack.Params Copy (global::Android.Content.Context context, bool isOptOut)
			{
				const string __id = "copy.(Landroid/content/Context;Z)Lwebtrekk/android/sdk/domain/external/AutoTrack$Params;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue (isOptOut);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Domain.External.AutoTrack.Params> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/domain/external/AutoTrack", typeof (AutoTrack));
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

		internal AutoTrack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe global::Org.Koin.Core.KoinContext Koin {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack']/method[@name='getKoin' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.domain.external']/class[@name='AutoTrack']/method[@name='invoke' and count(parameter)=2 and parameter[1][@type='webtrekk.android.sdk.domain.external.AutoTrack.Params'] and parameter[2][@type='webtrekk.android.sdk.util.CoroutineDispatchers']]"
		[Register ("invoke", "(Lwebtrekk/android/sdk/domain/external/AutoTrack$Params;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V", "")]
		public unsafe void Invoke (global::Webtrekk.Android.Sdk.Domain.External.AutoTrack.Params invokeParams, global::Webtrekk.Android.Sdk.Util.CoroutineDispatchers coroutineDispatchers)
		{
			const string __id = "invoke.(Lwebtrekk/android/sdk/domain/external/AutoTrack$Params;Lwebtrekk/android/sdk/util/CoroutineDispatchers;)V";
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
			Invoke (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Webtrekk.Android.Sdk.Domain.External.AutoTrack.Params>(p0), p1);
		}

	}
}
