<!-- Start SDK Example Usage [usage] -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetApisRequest req = new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "key", new List<string>() {
            "string",
        } },
    },
    Op = new QueryParamOp() {
        And = false,
    },
};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DeleteApiEndpointRequest req = new DeleteApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.DeleteApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

FindApiEndpointRequest req = new FindApiEndpointRequest() {
    ApiID = "string",
    DisplayName = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.FindApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GenerateOpenApiSpecForApiEndpointRequest req = new GenerateOpenApiSpecForApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GenerateOpenApiSpecForApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GeneratePostmanCollectionForApiEndpointRequest req = new GeneratePostmanCollectionForApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GeneratePostmanCollectionForApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetAllApiEndpointsRequest req = new GetAllApiEndpointsRequest() {
    ApiID = "string",
};

var res = await sdk.ApiEndpoints.GetAllApiEndpointsAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetAllForVersionApiEndpointsRequest req = new GetAllForVersionApiEndpointsRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GetAllForVersionApiEndpointsAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetApiEndpointRequest req = new GetApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GetApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

UpsertApiEndpointRequest req = new UpsertApiEndpointRequest() {
    ApiEndpoint = new ApiEndpointInput() {
        ApiEndpointId = "string",
        Description = "Public-key systematic attitude",
        DisplayName = "string",
        Method = "string",
        Path = "/etc/periodic",
        VersionId = "string",
    },
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.UpsertApiEndpointAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DeleteVersionMetadataRequest req = new DeleteVersionMetadataRequest() {
    ApiID = "string",
    MetaKey = "string",
    MetaValue = "string",
    VersionID = "string",
};

var res = await sdk.Metadata.DeleteVersionMetadataAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetVersionMetadataRequest req = new GetVersionMetadataRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Metadata.GetVersionMetadataAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

InsertVersionMetadataRequest req = new InsertVersionMetadataRequest() {
    VersionMetadata = new VersionMetadataInput() {
        MetaKey = "string",
        MetaValue = "string",
    },
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Metadata.InsertVersionMetadataAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DeleteSchemaRequest req = new DeleteSchemaRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DeleteSchemaAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DownloadSchemaRequest req = new DownloadSchemaRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DownloadSchemaAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DownloadSchemaRevisionRequest req = new DownloadSchemaRevisionRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DownloadSchemaRevisionAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetSchemaRequest req = new GetSchemaRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetSchemaDiffRequest req = new GetSchemaDiffRequest() {
    ApiID = "string",
    BaseRevisionID = "string",
    TargetRevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaDiffAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetSchemaRevisionRequest req = new GetSchemaRevisionRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaRevisionAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetSchemasRequest req = new GetSchemasRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemasAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

RegisterSchemaRequest req = new RegisterSchemaRequest() {
    RequestBody = new RegisterSchemaRequestBody() {
        File = new File() {
            Content = "0xCAFCA03e0e as bytes <<<>>>",
            FileName = "bronze_table_blues.m2a",
        },
    },
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.RegisterSchemaAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GenerateRequestPostmanCollectionRequest req = new GenerateRequestPostmanCollectionRequest() {
    RequestID = "string",
};

var res = await sdk.Requests.GenerateRequestPostmanCollectionAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetRequestFromEventLogRequest req = new GetRequestFromEventLogRequest() {
    RequestID = "string",
};

var res = await sdk.Requests.GetRequestFromEventLogAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

QueryEventLogRequest req = new QueryEventLogRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 241978,
        Offset = 451388,
        Operator = "string",
    },
};

var res = await sdk.Requests.QueryEventLogAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

var res = await sdk.Plugins.GetPluginsAsync();

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

RunPluginRequest req = new RunPluginRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 669298,
        Offset = 94585,
        Operator = "string",
    },
    PluginID = "string",
};

var res = await sdk.Plugins.RunPluginAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

Plugin req = new Plugin() {
    Code = "string",
    PluginId = "string",
    Title = "string",
    WorkspaceId = "string",
};

var res = await sdk.Plugins.UpsertPluginAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetEmbedAccessTokenRequest req = new GetEmbedAccessTokenRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 964408,
        Offset = 95617,
        Operator = "string",
    },
};

var res = await sdk.Embeds.GetEmbedAccessTokenAsync(req);

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

var res = await sdk.Embeds.GetValidEmbedAccessTokensAsync();

// handle response
```

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

RevokeEmbedAccessTokenRequest req = new RevokeEmbedAccessTokenRequest() {
    TokenID = "string",
};

var res = await sdk.Embeds.RevokeEmbedAccessTokenAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->