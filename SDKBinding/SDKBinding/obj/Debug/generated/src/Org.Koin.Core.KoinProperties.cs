using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']"
	[global::Android.Runtime.Register ("org/koin/core/KoinProperties", DoNotGenerateAcw=true)]
	public sealed partial class KoinProperties : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/KoinProperties", typeof (KoinProperties));
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

		internal KoinProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/constructor[@name='KoinProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe KoinProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/constructor[@name='KoinProperties' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register (".ctor", "(ZZLjava/util/Map;)V", "")]
		public unsafe KoinProperties (bool useEnvironmentProperties, bool useKoinPropertiesFile, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> extraProperties)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZZLjava/util/Map;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_extraProperties = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (extraProperties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (useEnvironmentProperties);
				__args [1] = new JniArgumentValue (useKoinPropertiesFile);
				__args [2] = new JniArgumentValue (native_extraProperties);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_extraProperties);
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> ExtraProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='getExtraProperties' and count(parameter)=0]"
			[Register ("getExtraProperties", "()Ljava/util/Map;", "GetGetExtraPropertiesHandler")]
			get {
				const string __id = "getExtraProperties.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool UseEnvironmentProperties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='getUseEnvironmentProperties' and count(parameter)=0]"
			[Register ("getUseEnvironmentProperties", "()Z", "GetGetUseEnvironmentPropertiesHandler")]
			get {
				const string __id = "getUseEnvironmentProperties.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool UseKoinPropertiesFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='getUseKoinPropertiesFile' and count(parameter)=0]"
			[Register ("getUseKoinPropertiesFile", "()Z", "GetGetUseKoinPropertiesFileHandler")]
			get {
				const string __id = "getUseKoinPropertiesFile.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Z", "")]
		public unsafe bool Component1 ()
		{
			const string __id = "component1.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='component2' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='component3' and count(parameter)=0]"
		[Register ("component3", "()Ljava/util/Map;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Component3 ()
		{
			const string __id = "component3.()Ljava/util/Map;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core']/class[@name='KoinProperties']/method[@name='copy' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("copy", "(ZZLjava/util/Map;)Lorg/koin/core/KoinProperties;", "")]
		public unsafe global::Org.Koin.Core.KoinProperties Copy (bool useEnvironmentProperties, bool useKoinPropertiesFile, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> extraProperties)
		{
			const string __id = "copy.(ZZLjava/util/Map;)Lorg/koin/core/KoinProperties;";
			IntPtr native_extraProperties = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (extraProperties);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (useEnvironmentProperties);
				__args [1] = new JniArgumentValue (useKoinPropertiesFile);
				__args [2] = new JniArgumentValue (native_extraProperties);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Core.KoinProperties> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_extraProperties);
			}
		}

	}
}
