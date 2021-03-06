﻿namespace PlatformSpecific.MSTest.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

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

			Assert.IsTrue(result, "Invalid OS platform.");
		}
	}
}
