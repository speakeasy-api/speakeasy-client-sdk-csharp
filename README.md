# Speakeasy

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package SpeakeasySDK
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example 1

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

### Example 2

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

### Example 3

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

### Example 4

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

### Example 5

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

### Example 6

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

### Example 7

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

### Example 8

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

### Example 9

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

### Example 10

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

### Example 11

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

### Example 12

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

### Example 13

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

### Example 14

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

### Example 15

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

### Example 16

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

### Example 17

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

### Example 18

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

### Example 19

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

### Example 20

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

### Example 21

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

### Example 22

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

### Example 23

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

### Example 24

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

### Example 25

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

### Example 26

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

### Example 27

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

### Example 28

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

### Example 29

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

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Speakeasy SDK](docs/sdks/speakeasy/README.md)

* [ValidateApiKey](docs/sdks/speakeasy/README.md#validateapikey) - Validate the current api key.

### [Apis](docs/sdks/apis/README.md)

* [DeleteApi](docs/sdks/apis/README.md#deleteapi) - Delete an Api.
* [GenerateOpenApiSpec](docs/sdks/apis/README.md#generateopenapispec) - Generate an OpenAPI specification for a particular Api.
* [GeneratePostmanCollection](docs/sdks/apis/README.md#generatepostmancollection) - Generate a Postman collection for a particular Api.
* [GetAllApiVersions](docs/sdks/apis/README.md#getallapiversions) - Get all Api versions for a particular ApiEndpoint.
* [GetApis](docs/sdks/apis/README.md#getapis) - Get a list of Apis for a given workspace
* [UpsertApi](docs/sdks/apis/README.md#upsertapi) - Upsert an Api

### [ApiEndpoints](docs/sdks/apiendpoints/README.md)

* [DeleteApiEndpoint](docs/sdks/apiendpoints/README.md#deleteapiendpoint) - Delete an ApiEndpoint.
* [FindApiEndpoint](docs/sdks/apiendpoints/README.md#findapiendpoint) - Find an ApiEndpoint via its displayName.
* [GenerateOpenApiSpecForApiEndpoint](docs/sdks/apiendpoints/README.md#generateopenapispecforapiendpoint) - Generate an OpenAPI specification for a particular ApiEndpoint.
* [GeneratePostmanCollectionForApiEndpoint](docs/sdks/apiendpoints/README.md#generatepostmancollectionforapiendpoint) - Generate a Postman collection for a particular ApiEndpoint.
* [GetAllApiEndpoints](docs/sdks/apiendpoints/README.md#getallapiendpoints) - Get all Api endpoints for a particular apiID.
* [GetAllForVersionApiEndpoints](docs/sdks/apiendpoints/README.md#getallforversionapiendpoints) - Get all ApiEndpoints for a particular apiID and versionID.
* [GetApiEndpoint](docs/sdks/apiendpoints/README.md#getapiendpoint) - Get an ApiEndpoint.
* [UpsertApiEndpoint](docs/sdks/apiendpoints/README.md#upsertapiendpoint) - Upsert an ApiEndpoint.

### [Metadata](docs/sdks/metadata/README.md)

* [DeleteVersionMetadata](docs/sdks/metadata/README.md#deleteversionmetadata) - Delete metadata for a particular apiID and versionID.
* [GetVersionMetadata](docs/sdks/metadata/README.md#getversionmetadata) - Get all metadata for a particular apiID and versionID.
* [InsertVersionMetadata](docs/sdks/metadata/README.md#insertversionmetadata) - Insert metadata for a particular apiID and versionID.

### [Schemas](docs/sdks/schemas/README.md)

* [DeleteSchema](docs/sdks/schemas/README.md#deleteschema) - Delete a particular schema revision for an Api.
* [DownloadSchema](docs/sdks/schemas/README.md#downloadschema) - Download the latest schema for a particular apiID.
* [DownloadSchemaRevision](docs/sdks/schemas/README.md#downloadschemarevision) - Download a particular schema revision for an Api.
* [GetSchema](docs/sdks/schemas/README.md#getschema) - Get information about the latest schema.
* [GetSchemaDiff](docs/sdks/schemas/README.md#getschemadiff) - Get a diff of two schema revisions for an Api.
* [GetSchemaRevision](docs/sdks/schemas/README.md#getschemarevision) - Get information about a particular schema revision for an Api.
* [GetSchemas](docs/sdks/schemas/README.md#getschemas) - Get information about all schemas associated with a particular apiID.
* [RegisterSchema](docs/sdks/schemas/README.md#registerschema) - Register a schema.

### [Requests](docs/sdks/requests/README.md)

* [GenerateRequestPostmanCollection](docs/sdks/requests/README.md#generaterequestpostmancollection) - Generate a Postman collection for a particular request.
* [GetRequestFromEventLog](docs/sdks/requests/README.md#getrequestfromeventlog) - Get information about a particular request.
* [QueryEventLog](docs/sdks/requests/README.md#queryeventlog) - Query the event log to retrieve a list of requests.

### [Plugins](docs/sdks/plugins/README.md)

* [GetPlugins](docs/sdks/plugins/README.md#getplugins) - Get all plugins for the current workspace.
* [RunPlugin](docs/sdks/plugins/README.md#runplugin) - Run a plugin
* [UpsertPlugin](docs/sdks/plugins/README.md#upsertplugin) - Upsert a plugin

### [Embeds](docs/sdks/embeds/README.md)

* [GetEmbedAccessToken](docs/sdks/embeds/README.md#getembedaccesstoken) - Get an embed access token for the current workspace.
* [GetValidEmbedAccessTokens](docs/sdks/embeds/README.md#getvalidembedaccesstokens) - Get all valid embed access tokens for the current workspace.
* [RevokeEmbedAccessToken](docs/sdks/embeds/README.md#revokeembedaccesstoken) - Revoke an embed access EmbedToken.
<!-- End Available Resources and Operations [operations] -->



<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name | Server | Variables |
| ----- | ------ | --------- |
| `prod` | `https://api.prod.speakeasyapi.dev` | None |



### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
