# GenerateBumpType

Bump type of the lock file (calculated semver delta, custom change (manual release), or prerelease/graduate)

## Example Usage

```csharp
using SpeakeasySDK.Models.Shared;

var value = GenerateBumpType.Major;
```


## Values

| Name         | Value        |
| ------------ | ------------ |
| `Major`      | major        |
| `Minor`      | minor        |
| `Patch`      | patch        |
| `Custom`     | custom       |
| `Graduate`   | graduate     |
| `Prerelease` | prerelease   |
| `None`       | none         |