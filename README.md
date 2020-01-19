# Platform specific

C# library for writing platform spesific tests using MSTest or xUnit.

## Build Status

|             | Build Status |
| ----------- | ------------ |
| **Linux**   | [![Build status](https://ci.appveyor.com/api/projects/status/d03mchi7t0uqkjo0?svg=true)](https://ci.appveyor.com/project/petarpetrovt/platform-specific-ubuntu) |
| **Windows** | [![Build status](https://ci.appveyor.com/api/projects/status/qhb351ea1jih8yw8?svg=true)](https://ci.appveyor.com/project/petarpetrovt/platform-specific-windows) |

## Installation

|                      | NuGet |
| -------------------- | ----- |
| **PlatformSpecific** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.svg)](https://www.nuget.org/packages/PlatformSpecific/) |
| **PlatformSpecific.MSTest** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.MSTest.svg)](https://www.nuget.org/packages/PlatformSpecific.MSTest/) |
| **PlatformSpecific.XUnit** | [![NuGet](https://img.shields.io/nuget/v/PlatformSpecific.XUnit.svg)](https://www.nuget.org/packages/PlatformSpecific.XUnit/) |

## Examples

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

## Authors

* **Petar Petrov**

See also the list of [contributors](https://github.com/SharpPTP/platform-specific/graphs/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
