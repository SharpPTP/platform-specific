namespace PlatformSpecific.XUnit.Tests
{
	public class PlatformSpecificFactAttributeTests
	{
		[PlatformSpecificFact(Platform.Windows)]
		public void TestMethod_Windows()
		{
			Platform.Windows.AssertOSPlatform();
		}

		[PlatformSpecificFact(Platform.Linux)]
		public void TestMethod_Linux()
		{
			Platform.Linux.AssertOSPlatform();
		}

		[PlatformSpecificFact(Platform.OSX)]
		public void TestMethod_OSX()
		{
			Platform.OSX.AssertOSPlatform();
		}

		[PlatformSpecificFact(Platform.Unix)]
		public void TestMethod_Unix()
		{
			Platform.Unix.AssertOSPlatform();
		}
	}
}
