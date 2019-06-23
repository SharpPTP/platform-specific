namespace PlatformSpecific.XUnit.Tests
{
	using System.Collections.Generic;
	using System.Runtime.InteropServices;
	using Xunit;

	internal static class Extensions
	{
		public static void AssertOSPlatform(this Platform value)
		{
			IEnumerable<OSPlatform> platforms = value.GetOSPlatforms();

			bool result = false;

			foreach (OSPlatform platform in platforms)
			{
				result |= RuntimeInformation.IsOSPlatform(platform);
			}

			Assert.True(result, "Invalid OS platform.");
		}
	}
}
