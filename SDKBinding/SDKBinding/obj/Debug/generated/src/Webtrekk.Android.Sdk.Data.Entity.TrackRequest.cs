using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Data.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/data/entity/TrackRequest", DoNotGenerateAcw=true)]
	public sealed partial class TrackRequest : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']"
		[global::Android.Runtime.Register ("webtrekk/android/sdk/data/entity/TrackRequest$RequestState", DoNotGenerateAcw=true)]
		public sealed partial class RequestState : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/field[@name='DONE']"
			[Register ("DONE")]
			public static global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState Done {
				get {
					const string __id = "DONE.Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/field[@name='FAILED']"
			[Register ("FAILED")]
			public static global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState Failed {
				get {
					const string __id = "FAILED.Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/field[@name='NEW']"
			[Register ("NEW")]
			public static global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState New {
				get {
					const string __id = "NEW.Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/entity/TrackRequest$RequestState", typeof (RequestState));
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

			internal RequestState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe string Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/String;", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;", "")]
			public static unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest.RequestState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;", "")]
			public static unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState[] Values ()
			{
				const string __id = "values.()[Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/data/entity/TrackRequest", typeof (TrackRequest));
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

		internal TrackRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string ApiLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getApiLevel' and count(parameter)=0]"
			[Register ("getApiLevel", "()Ljava/lang/String;", "GetGetApiLevelHandler")]
			get {
				const string __id = "getApiLevel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string AppFirstOpen {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getAppFirstOpen' and count(parameter)=0]"
			[Register ("getAppFirstOpen", "()Ljava/lang/String;", "GetGetAppFirstOpenHandler")]
			get {
				const string __id = "getAppFirstOpen.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string AppVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getAppVersionCode' and count(parameter)=0]"
			[Register ("getAppVersionCode", "()Ljava/lang/String;", "GetGetAppVersionCodeHandler")]
			get {
				const string __id = "getAppVersionCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string AppVersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getAppVersionName' and count(parameter)=0]"
			[Register ("getAppVersionName", "()Ljava/lang/String;", "GetGetAppVersionNameHandler")]
			get {
				const string __id = "getAppVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DeviceManufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getDeviceManufacturer' and count(parameter)=0]"
			[Register ("getDeviceManufacturer", "()Ljava/lang/String;", "GetGetDeviceManufacturerHandler")]
			get {
				const string __id = "getDeviceManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ForceNewSession {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getForceNewSession' and count(parameter)=0]"
			[Register ("getForceNewSession", "()Ljava/lang/String;", "GetGetForceNewSessionHandler")]
			get {
				const string __id = "getForceNewSession.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()J", "GetGetIdHandler")]
			get {
				const string __id = "getId.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setId", "(J)V", "GetSetId_JHandler")]
			set {
				const string __id = "setId.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string Language {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getLanguage' and count(parameter)=0]"
			[Register ("getLanguage", "()Ljava/lang/String;", "GetGetLanguageHandler")]
			get {
				const string __id = "getLanguage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string OsVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getOsVersion' and count(parameter)=0]"
			[Register ("getOsVersion", "()Ljava/lang/String;", "GetGetOsVersionHandler")]
			get {
				const string __id = "getOsVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string ScreenResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getScreenResolution' and count(parameter)=0]"
			[Register ("getScreenResolution", "()Ljava/lang/String;", "GetGetScreenResolutionHandler")]
			get {
				const string __id = "getScreenResolution.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string TimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getTimeStamp' and count(parameter)=0]"
			[Register ("getTimeStamp", "()Ljava/lang/String;", "GetGetTimeStampHandler")]
			get {
				const string __id = "getTimeStamp.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string TimeZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getTimeZone' and count(parameter)=0]"
			[Register ("getTimeZone", "()Ljava/lang/String;", "GetGetTimeZoneHandler")]
			get {
				const string __id = "getTimeZone.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string WebtrekkVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getWebtrekkVersion' and count(parameter)=0]"
			[Register ("getWebtrekkVersion", "()Ljava/lang/String;", "GetGetWebtrekkVersionHandler")]
			get {
				const string __id = "getWebtrekkVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()J", "")]
		public unsafe long Component1 ()
		{
			const string __id = "component1.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component10' and count(parameter)=0]"
		[Register ("component10", "()Ljava/lang/String;", "")]
		public unsafe string Component10 ()
		{
			const string __id = "component10.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component11' and count(parameter)=0]"
		[Register ("component11", "()Ljava/lang/String;", "")]
		public unsafe string Component11 ()
		{
			const string __id = "component11.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component12' and count(parameter)=0]"
		[Register ("component12", "()Ljava/lang/String;", "")]
		public unsafe string Component12 ()
		{
			const string __id = "component12.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component13' and count(parameter)=0]"
		[Register ("component13", "()Ljava/lang/String;", "")]
		public unsafe string Component13 ()
		{
			const string __id = "component13.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component14' and count(parameter)=0]"
		[Register ("component14", "()Ljava/lang/String;", "")]
		public unsafe string Component14 ()
		{
			const string __id = "component14.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component15' and count(parameter)=0]"
		[Register ("component15", "()Ljava/lang/String;", "")]
		public unsafe string Component15 ()
		{
			const string __id = "component15.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component16' and count(parameter)=0]"
		[Register ("component16", "()Ljava/lang/String;", "")]
		public unsafe string Component16 ()
		{
			const string __id = "component16.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component17' and count(parameter)=0]"
		[Register ("component17", "()Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState Component17 ()
		{
			const string __id = "component17.()Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component2' and count(parameter)=0]"
		[Register ("component2", "()Ljava/lang/String;", "")]
		public unsafe string Component2 ()
		{
			const string __id = "component2.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/lang/String;", "")]
		public unsafe string Component3 ()
		{
			const string __id = "component3.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Ljava/lang/String;", "")]
		public unsafe string Component4 ()
		{
			const string __id = "component4.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Ljava/lang/String;", "")]
		public unsafe string Component5 ()
		{
			const string __id = "component5.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Ljava/lang/String;", "")]
		public unsafe string Component6 ()
		{
			const string __id = "component6.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Ljava/lang/String;", "")]
		public unsafe string Component7 ()
		{
			const string __id = "component7.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Ljava/lang/String;", "")]
		public unsafe string Component8 ()
		{
			const string __id = "component8.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='component9' and count(parameter)=0]"
		[Register ("component9", "()Ljava/lang/String;", "")]
		public unsafe string Component9 ()
		{
			const string __id = "component9.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='getRequestState' and count(parameter)=0]"
		[Register ("getRequestState", "()Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;", "")]
		public unsafe global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState GetRequestState ()
		{
			const string __id = "getRequestState.()Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.data.entity']/class[@name='TrackRequest']/method[@name='setRequestState' and count(parameter)=1 and parameter[1][@type='webtrekk.android.sdk.data.entity.TrackRequest.RequestState']]"
		[Register ("setRequestState", "(Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;)V", "")]
		public unsafe void SetRequestState (global::Webtrekk.Android.Sdk.Data.Entity.TrackRequest.RequestState set)
		{
			const string __id = "setRequestState.(Lwebtrekk/android/sdk/data/entity/TrackRequest$RequestState;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
