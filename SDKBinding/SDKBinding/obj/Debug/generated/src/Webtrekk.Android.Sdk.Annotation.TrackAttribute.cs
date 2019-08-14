using System;

namespace Webtrekk.Android.Sdk.Annotation {

	[global::Android.Runtime.Annotation ("webtrekk.android.sdk.annotation.Track")]
	public partial class TrackAttribute : Attribute
	{
		[global::Android.Runtime.Register ("contextName")]
		public string ContextName { get; set; }

	}
}
