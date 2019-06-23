## Platform Specific test attributes

### Installation

| Package Name  | Release (NuGet)                                                                                     |
| ------------- | --------------------------------------------------------------------------------------------------- |
| **PlatformSpecific** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.svg)](https://www.nuget.org/packages/PlatformSpecific/) |
| **PlatformSpecific.MSTest** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.MSTest.svg)](https://www.nuget.org/packages/PlatformSpecific.MSTest/) |
| **PlatformSpecific.XUnit** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.XUnit.svg)](https://www.nuget.org/packages/PlatformSpecific.XUnit/) |

### Examples

#### MSTest

```csharp
[PlatformSpecificTestMethod(Platform.Windows)]
public void TestMethod() {}

[PlatformSpecificDataTestMethod(Platform.Linux)]
[DataRow(string.Empty)]
public void DataTestMethod(string value) {}
```

#### XUnit

```csharp
[PlatformSpecificFact(Platform.Windows)]
public void TestMethod() {}

[PlatformSpecificTheory(Platform.Linux)]
[InlineData(string.Empty)]
public void DataTestMethod(string value) {}
```
