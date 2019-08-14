using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='webtrekk.android.sdk.annotation']/interface[@name='Track']"
	[Register ("webtrekk/android/sdk/annotation/Track", "", "Webtrekk.Android.Sdk.Annotation.ITrackInvoker")]
	public partial interface ITrack : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.annotation']/interface[@name='Track']/method[@name='contextName' and count(parameter)=0]"
		[Register ("contextName", "()Ljava/lang/String;", "GetContextNameHandler:Webtrekk.Android.Sdk.Annotation.ITrackInvoker, SDKBinding")]
		string ContextName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.annotation']/interface[@name='Track']/method[@name='trackingParams' and count(parameter)=0]"
		[Register ("trackingParams", "()[Lwebtrekk/android/sdk/annotation/TrackParams;", "GetTrackingParamsHandler:Webtrekk.Android.Sdk.Annotation.ITrackInvoker, SDKBinding")]
		global::Webtrekk.Android.Sdk.Annotation.ITrackParams[] TrackingParams ();

	}

	[global::Android.Runtime.Register ("webtrekk/android/sdk/annotation/Track", DoNotGenerateAcw=true)]
	internal class ITrackInvoker : global::Java.Lang.Object, ITrack {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("webtrekk/android/sdk/annotation/Track", typeof (ITrackInvoker));

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

		public static ITrack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITrack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "webtrekk.android.sdk.annotation.Track"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITrackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_contextName;
#pragma warning disable 0169
		static Delegate GetContextNameHandler ()
		{
			if (cb_contextName == null)
				cb_contextName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContextName);
			return cb_contextName;
		}

		static IntPtr n_ContextName (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContextName ());
		}
#pragma warning restore 0169

		IntPtr id_contextName;
		public unsafe string ContextName ()
		{
			if (id_contextName == IntPtr.Zero)
				id_contextName = JNIEnv.GetMethodID (class_ref, "contextName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contextName), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_trackingParams;
#pragma warning disable 0169
		static Delegate GetTrackingParamsHandler ()
		{
			if (cb_trackingParams == null)
				cb_trackingParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TrackingParams);
			return cb_trackingParams;
		}

		static IntPtr n_TrackingParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.TrackingParams ());
		}
#pragma warning restore 0169

		IntPtr id_trackingParams;
		public unsafe global::Webtrekk.Android.Sdk.Annotation.ITrackParams[] TrackingParams ()
		{
			if (id_trackingParams == IntPtr.Zero)
				id_trackingParams = JNIEnv.GetMethodID (class_ref, "trackingParams", "()[Lwebtrekk/android/sdk/annotation/TrackParams;");
			return (global::Webtrekk.Android.Sdk.Annotation.ITrackParams[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_trackingParams), JniHandleOwnership.TransferLocalRef, typeof (global::Webtrekk.Android.Sdk.Annotation.ITrackParams));
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Webtrekk.Android.Sdk.Annotation.ITrack __this = global::Java.Lang.Object.GetObject<global::Webtrekk.Android.Sdk.Annotation.ITrack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
