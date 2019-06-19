## Platform Specific MSTest attributes

### Installation

| Package Name  | Release (NuGet)                                                                                     |
| ------------- | --------------------------------------------------------------------------------------------------- |
| **PlatformSpecific.MSTest** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.MSTest.svg)](https://www.nuget.org/packages/PlatformSpecific.MSTest/) |

### Examples

```csharp
[PlatformSpecificTestMethod(Platform.Windows)]
public void TestMethod()
{
  // TODO:
}
```

```csharp
[PlatformSpecificDataTestMethod(Platform.Linux)]
[DataRow(string.Empty)]
public void DataTestMethod(string value)
{
  // TODO:
}
```
