# WorkspaceFeatureFlag

enum value workspace feature flag

## Example Usage

```csharp
using SpeakeasySDK.Models.Shared;

var value = WorkspaceFeatureFlag.SchemaRegistry;

// Open enum: use .Of() to create instances from custom string values
var custom = WorkspaceFeatureFlag.Of("custom_value");
```


## Values

| Name                 | Value                |
| -------------------- | -------------------- |
| `SchemaRegistry`     | schema_registry      |
| `ChangesReport`      | changes_report       |
| `SkipSchemaRegistry` | skip_schema_registry |
| `Webhooks`           | webhooks             |