namespace PlatformSpecific.XUnit.Tests
{
	using Xunit;

	public class PlatformSpecificTheoryAttributeTests
	{
		[PlatformSpecificTheory(Platform.Windows)]
		[InlineData(Platform.Windows)]
		public void DataTestMethod_Windows(Platform platform)
		{
			platform.AssertOSPlatform();
		}

		[PlatformSpecificTheory(Platform.Linux)]
		[InlineData(Platform.Linux)]
		public void DataTestMethod_Linux(Platform platform)
		{
			platform.AssertOSPlatform();
		}

		[PlatformSpecificTheory(Platform.OSX)]
		[InlineData(Platform.OSX)]
		public void DataTestMethod_OSX(Platform platform)
		{
			platform.AssertOSPlatform();
		}

		[PlatformSpecificTheory(Platform.Unix)]
		[InlineData(Platform.Unix)]
		public void DataTestMethod_Unix(Platform platform)
		{
			platform.AssertOSPlatform();
		}
	}
}
