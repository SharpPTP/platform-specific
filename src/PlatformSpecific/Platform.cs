namespace PlatformSpecific
{
	using System;
	using System.Runtime.InteropServices;

	/// <summary>
	/// Represents an enumeration of platforms defined in <see cref="OSPlatform"/>.
	/// </summary>
	[Flags]
	public enum Platform
	{
		/// <summary>
		/// Unknown
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Linux
		/// </summary>
		Linux = 1 << 0,

		/// <summary>
		/// OSX
		/// </summary>
		OSX = 1 << 1,

		/// <summary>
		/// Windows
		/// </summary>
		Windows = 1 << 2,

		/// <summary>
		/// Unix (Linux and OSX)
		/// </summary>
		Unix = Linux | OSX,
	}
}
