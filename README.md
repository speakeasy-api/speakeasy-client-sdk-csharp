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

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
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

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name     | Type     | Scheme   |
| -------- | -------- | -------- |
| `apiKey` | apiKey   | API key  |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

var res = await sdk.ValidateApiKeyAsync();

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
