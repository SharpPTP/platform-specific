## Platform Specific test attributes

### Build Status

|               |                                                                   Build Status                                                                   |
| ------------- | :----------------------------------------------------------------------------------------------------------------------------------------------: |
| **Linux/Mac** | [![Build Status](https://travis-ci.org/SharpPTP/platform-specific.svg?branch=master)](https://travis-ci.org/SharpPTP/platform-specific)                          |
| **Windows**   | [![Build Status](https://ci.appveyor.com/api/projects/status/d6n5dnvukkrrsli7?svg=true)](https://ci.appveyor.com/project/petarpetrovt/platform-specific) |

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
