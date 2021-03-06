﻿namespace PlatformSpecific.XUnit
{
	using System;
	using Xunit;
	using Xunit.Sdk;

	/// <summary>
	/// Attribute that is applied to a method to indicate that it is a fact that should be run
	/// by the test runner only on a specific platform.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[XunitTestCaseDiscoverer("Xunit.Sdk.FactDiscoverer", "xunit.execution.{Platform}")]
	public class PlatformSpecificFactAttribute : FactAttribute
	{
		/// <summary>
		/// Gets the skip message.
		/// </summary>
		public new string? Skip { get; protected set; }

		/// <summary>
		/// Creates a new instance of <see cref="PlatformSpecificFactAttribute"/>.
		/// </summary>
		/// <param name="platform">the platform</param>
		public PlatformSpecificFactAttribute(Platform platform)
		{
			Skip = !platform.IsOSPlatform()
				? $"Test is `{platform}` platform specific."
				: null;
		}
	}
}
