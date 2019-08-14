using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Core.Property {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']"
	[global::Android.Runtime.Register ("org/koin/core/property/PropertyRegistry", DoNotGenerateAcw=true)]
	public sealed partial class PropertyRegistry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/core/property/PropertyRegistry", typeof (PropertyRegistry));
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

		internal PropertyRegistry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/constructor[@name='PropertyRegistry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PropertyRegistry ()
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

		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Properties {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='getProperties' and count(parameter)=0]"
			[Register ("getProperties", "()Ljava/util/HashMap;", "GetGetPropertiesHandler")]
			get {
				const string __id = "getProperties.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("add", "(Ljava/lang/String;Ljava/lang/Object;)V", "")]
		public unsafe void Add (string key, global::Java.Lang.Object value)
		{
			const string __id = "add.(Ljava/lang/String;Ljava/lang/Object;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, ? extends java.lang.Object&gt;']]"
		[Register ("addAll", "(Ljava/util/Map;)V", "")]
		public unsafe void AddAll (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> props)
		{
			const string __id = "addAll.(Ljava/util/Map;)V";
			IntPtr native_props = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (props);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_props);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_props);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "")]
		public unsafe bool ContainsKey (string key)
		{
			const string __id = "containsKey.(Ljava/lang/String;)Z";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='delete' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("delete", "(Ljava/lang/String;)V", "")]
		public unsafe void Delete (string key)
		{
			const string __id = "delete.(Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='deleteAll' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("deleteAll", "([Ljava/lang/String;)V", "")]
		public unsafe void DeleteAll (string[] keys)
		{
			const string __id = "deleteAll.([Ljava/lang/String;)V";
			IntPtr native_keys = JNIEnv.NewArray (keys);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_keys);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				if (keys != null) {
					JNIEnv.CopyArray (native_keys, keys);
					JNIEnv.DeleteLocalRef (native_keys);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='getProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProperty", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetProperty (string key)
		{
			const string __id = "getProperty.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='getProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='T']]"
		[Register ("getProperty", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetProperty (string key, global::Java.Lang.Object defaultValue)
		{
			const string __id = "getProperty.(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_defaultValue = JNIEnv.ToLocalJniHandle (defaultValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_defaultValue);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_defaultValue);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getValue", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetValue (string key)
		{
			const string __id = "getValue.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.core.property']/class[@name='PropertyRegistry']/method[@name='import' and count(parameter)=1 and parameter[1][@type='java.util.Properties']]"
		[Register ("import", "(Ljava/util/Properties;)I", "")]
		public unsafe int Import (global::Java.Util.Properties properties)
		{
			const string __id = "import.(Ljava/util/Properties;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((properties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) properties).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
