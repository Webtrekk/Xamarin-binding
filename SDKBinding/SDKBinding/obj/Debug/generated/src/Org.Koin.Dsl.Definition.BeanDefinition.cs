using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Koin.Dsl.Definition {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']"
	[global::Android.Runtime.Register ("org/koin/dsl/definition/BeanDefinition", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class BeanDefinition : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/koin/dsl/definition/BeanDefinition", typeof (BeanDefinition));
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

		internal BeanDefinition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool AllowOverride {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='getAllowOverride' and count(parameter)=0]"
			[Register ("getAllowOverride", "()Z", "GetGetAllowOverrideHandler")]
			get {
				const string __id = "getAllowOverride.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Ljava/util/HashMap;", "GetGetAttributesHandler")]
			get {
				const string __id = "getAttributes.()Ljava/util/HashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsEager {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='isEager' and count(parameter)=0]"
			[Register ("isEager", "()Z", "GetIsEagerHandler")]
			get {
				const string __id = "isEager.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Org.Koin.Dsl.Definition.Kind Kind {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='getKind' and count(parameter)=0]"
			[Register ("getKind", "()Lorg/koin/dsl/definition/Kind;", "GetGetKindHandler")]
			get {
				const string __id = "getKind.()Lorg/koin/dsl/definition/Kind;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='getName' and count(parameter)=0]"
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

		public unsafe global::Org.Koin.Dsl.Path.Path Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Lorg/koin/dsl/path/Path;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Lorg/koin/dsl/path/Path;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component1' and count(parameter)=0]"
		[Register ("component1", "()Ljava/lang/String;", "")]
		public unsafe string Component1 ()
		{
			const string __id = "component1.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component4' and count(parameter)=0]"
		[Register ("component4", "()Lorg/koin/dsl/path/Path;", "")]
		public unsafe global::Org.Koin.Dsl.Path.Path Component4 ()
		{
			const string __id = "component4.()Lorg/koin/dsl/path/Path;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Path.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component5' and count(parameter)=0]"
		[Register ("component5", "()Lorg/koin/dsl/definition/Kind;", "")]
		public unsafe global::Org.Koin.Dsl.Definition.Kind Component5 ()
		{
			const string __id = "component5.()Lorg/koin/dsl/definition/Kind;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Org.Koin.Dsl.Definition.Kind> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component6' and count(parameter)=0]"
		[Register ("component6", "()Z", "")]
		public unsafe bool Component6 ()
		{
			const string __id = "component6.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component7' and count(parameter)=0]"
		[Register ("component7", "()Z", "")]
		public unsafe bool Component7 ()
		{
			const string __id = "component7.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='component8' and count(parameter)=0]"
		[Register ("component8", "()Ljava/util/HashMap;", "")]
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> Component8 ()
		{
			const string __id = "component8.()Ljava/util/HashMap;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.koin.dsl.definition']/class[@name='BeanDefinition']/method[@name='isVisible' and count(parameter)=1 and parameter[1][@type='org.koin.dsl.definition.BeanDefinition&lt;?&gt;']]"
		[Register ("isVisible", "(Lorg/koin/dsl/definition/BeanDefinition;)Z", "")]
		public unsafe bool IsVisible (global::Org.Koin.Dsl.Definition.BeanDefinition other)
		{
			const string __id = "isVisible.(Lorg/koin/dsl/definition/BeanDefinition;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
