using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Webtrekk.Android.Sdk.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='RoomUtilKt']"
	[global::Android.Runtime.Register ("webtrekk/android/sdk/util/RoomUtilKt", DoNotGenerateAcw=true)]
	public sealed partial class RoomUtilKt : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("webtrekk/android/sdk/util/RoomUtilKt", typeof (RoomUtilKt));
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

		internal RoomUtilKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='webtrekk.android.sdk.util']/class[@name='RoomUtilKt']/method[@name='buildRoomDatabase' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("buildRoomDatabase", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends androidx.room.RoomDatabase"})]
		public static unsafe global::Java.Lang.Object BuildRoomDatabase (global::Android.Content.Context context, string databaseName, global::Java.Lang.Class database)
		{
			const string __id = "buildRoomDatabase.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_databaseName = JNIEnv.NewString (databaseName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_databaseName);
				__args [2] = new JniArgumentValue ((database == null) ? IntPtr.Zero : ((global::Java.Lang.Object) database).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_databaseName);
			}
		}

	}
}
