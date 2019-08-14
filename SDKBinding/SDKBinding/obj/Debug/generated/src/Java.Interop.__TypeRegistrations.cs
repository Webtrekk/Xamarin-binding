using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"org/koin/core/instance/holder",
						"org/koin/standalone",
						"webtrekk/android/sdk",
					},
					new Converter<string, Type>[]{
						lookup_org_koin_core_instance_holder_package,
						lookup_org_koin_standalone_package,
						lookup_webtrekk_android_sdk_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_org_koin_core_instance_holder_mappings;
		static Type lookup_org_koin_core_instance_holder_package (string klass)
		{
			if (package_org_koin_core_instance_holder_mappings == null) {
				package_org_koin_core_instance_holder_mappings = new string[]{
					"org/koin/core/instance/holder/InstanceHolder$DefaultImpls:Org.Koin.Core.Instance.Holder.InstanceHolderDefaultImpls",
				};
			}

			return Lookup (package_org_koin_core_instance_holder_mappings, klass);
		}

		static string[] package_org_koin_standalone_mappings;
		static Type lookup_org_koin_standalone_package (string klass)
		{
			if (package_org_koin_standalone_mappings == null) {
				package_org_koin_standalone_mappings = new string[]{
					"org/koin/standalone/KoinComponent$DefaultImpls:Org.Koin.Standalone.KoinComponentDefaultImpls",
				};
			}

			return Lookup (package_org_koin_standalone_mappings, klass);
		}

		static string[] package_webtrekk_android_sdk_mappings;
		static Type lookup_webtrekk_android_sdk_package (string klass)
		{
			if (package_webtrekk_android_sdk_mappings == null) {
				package_webtrekk_android_sdk_mappings = new string[]{
					"webtrekk/android/sdk/Logger$Level:Webtrekk.Android.Sdk.LoggerLevel",
				};
			}

			return Lookup (package_webtrekk_android_sdk_mappings, klass);
		}
	}
}
