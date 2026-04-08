# BillingAddOn

## Example Usage

```csharp
using SpeakeasySDK.Models.Shared;

var value = BillingAddOn.Webhooks;

// Open enum: use .Of() to create instances from custom string values
var custom = BillingAddOn.Of("custom_value");
```


## Values

| Name                | Value               |
| ------------------- | ------------------- |
| `Webhooks`          | webhooks            |
| `SDKTesting`        | sdk_testing         |
| `CustomCodeRegions` | custom_code_regions |
| `SnippetAi`         | snippet_ai          |