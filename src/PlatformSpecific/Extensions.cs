namespace PlatformSpecific
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	/// <summary>
	/// Contains extension methods.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Gets a flag indicating whether the current platform flag is contained in the specified platform flags.
		/// </summary>
		/// <param name="value">the platform flags</param>
		/// <returns>true if it's contained; otherwise false</returns>
		public static bool IsOSPlatform(this Platform value)
		{
			if (value == Platform.Unknown)
			{
				throw new PlatformNotSupportedException($"Unknown platform specified.");
			}

			if (value.HasFlag(Platform.Linux)
				&& RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
			{
				return true;
			}

			if (value.HasFlag(Platform.OSX)
				&& RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				return true;
			}

			if (value.HasFlag(Platform.Windows)
				&& RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Gets an enumeration of OS platforms for the specified platform flags.
		/// </summary>
		/// <param name="value">the platform flags</param>
		/// <returns>an enumeration of OS platforms</returns>
		public static IEnumerable<OSPlatform> GetOSPlatforms(this Platform value)
		{
			if (value == Platform.Unknown)
			{
				throw new PlatformNotSupportedException($"Unknown platform specified.");
			}

			if (value.HasFlag(Platform.Linux))
			{
				yield return OSPlatform.Linux;
			}

			if (value.HasFlag(Platform.OSX))
			{
				yield return OSPlatform.OSX;
			}

			if (value.HasFlag(Platform.Windows))
			{
				yield return OSPlatform.Windows;
			}
		}
	}
}
