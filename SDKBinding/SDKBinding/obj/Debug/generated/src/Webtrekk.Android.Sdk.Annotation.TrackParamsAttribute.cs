using System;

namespace Webtrekk.Android.Sdk.Annotation {

	[global::Android.Runtime.Annotation ("webtrekk.android.sdk.annotation.TrackParams")]
	public partial class TrackParamsAttribute : Attribute
	{
		[global::Android.Runtime.Register ("paramKey")]
		public string ParamKey { get; set; }

		[global::Android.Runtime.Register ("paramVal")]
		public string ParamVal { get; set; }

	}
}
