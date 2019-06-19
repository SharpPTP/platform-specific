namespace PlatformSpecific.MSTest
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;
	using System;
	using System.Runtime.InteropServices;

	/// <summary>
	/// Attribute that is applied to a method to indicate that it should be run
	/// by the test runner only on a specific platform.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public class PlatformSpecificTestMethodAttribute : TestMethodAttribute
	{
		private readonly Platform _platform;

		/// <summary>
		/// Creates a new instance of <see cref="PlatformSpecificTestMethodAttribute"/>.
		/// </summary>
		/// <param name="platform">the platform</param>
		public PlatformSpecificTestMethodAttribute(Platform platform)
		{
			_platform = platform;
		}

		/// <inheritdoc />
		public override TestResult[] Execute(ITestMethod testMethod)
		{
			if (IsOSPlatform(_platform))
			{
				return base.Execute(testMethod);
			}

			var result = new TestResult
			{
				Outcome = UnitTestOutcome.Inconclusive,
				DisplayName = $"Test is `{_platform}` platform specific.",
			};

			return new TestResult[]
			{
				result,
			};
		}

		private static bool IsOSPlatform(Platform platform)
		{
			if (platform == Platform.Unknown)
			{
				throw new PlatformNotSupportedException($"Unknown platform specified.");
			}

			bool shouldRun = false;

			if (platform.HasFlag(Platform.Linux) && !shouldRun)
			{
				shouldRun = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
			}

			if (platform.HasFlag(Platform.OSX) && !shouldRun)
			{
				shouldRun = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
			}

			if (platform.HasFlag(Platform.Windows) && !shouldRun)
			{
				shouldRun = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
			}

			return shouldRun;
		}
	}
}
