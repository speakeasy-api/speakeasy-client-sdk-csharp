# Speakeasy

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package SpeakeasySDK
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->


```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GetApisAsync(new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "provident", new List<string>() {
            "quibusdam",
            "unde",
            "nulla",
        } },
        { "corrupti", new List<string>() {
            "vel",
            "error",
            "deserunt",
            "suscipit",
        } },
        { "iure", new List<string>() {
            "debitis",
            "ipsa",
        } },
    },
    Op = new GetApisOp() {
        And = false,
    },
});
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations

### [Speakeasy SDK](docs/Sdks/Speakeasy/README.md)

* [ValidateApiKey](docs/Sdks/Speakeasy/README.md#validateapikey) - Validate the current api key.

### [apiEndpoints](docs/Sdks/ApiEndpoints/README.md)

* [DeleteApiEndpoint](docs/Sdks/ApiEndpoints/README.md#deleteapiendpoint) - Delete an ApiEndpoint.
* [FindApiEndpoint](docs/Sdks/ApiEndpoints/README.md#findapiendpoint) - Find an ApiEndpoint via its displayName.
* [GenerateOpenApiSpecForApiEndpoint](docs/Sdks/ApiEndpoints/README.md#generateopenapispecforapiendpoint) - Generate an OpenAPI specification for a particular ApiEndpoint.
* [GeneratePostmanCollectionForApiEndpoint](docs/Sdks/ApiEndpoints/README.md#generatepostmancollectionforapiendpoint) - Generate a Postman collection for a particular ApiEndpoint.
* [GetAllApiEndpoints](docs/Sdks/ApiEndpoints/README.md#getallapiendpoints) - Get all Api endpoints for a particular apiID.
* [GetAllForVersionApiEndpoints](docs/Sdks/ApiEndpoints/README.md#getallforversionapiendpoints) - Get all ApiEndpoints for a particular apiID and versionID.
* [GetApiEndpoint](docs/Sdks/ApiEndpoints/README.md#getapiendpoint) - Get an ApiEndpoint.
* [UpsertApiEndpoint](docs/Sdks/ApiEndpoints/README.md#upsertapiendpoint) - Upsert an ApiEndpoint.

### [apis](docs/Sdks/Apis/README.md)

* [DeleteApi](docs/Sdks/Apis/README.md#deleteapi) - Delete an Api.
* [GenerateOpenApiSpec](docs/Sdks/Apis/README.md#generateopenapispec) - Generate an OpenAPI specification for a particular Api.
* [GeneratePostmanCollection](docs/Sdks/Apis/README.md#generatepostmancollection) - Generate a Postman collection for a particular Api.
* [GetAllApiVersions](docs/Sdks/Apis/README.md#getallapiversions) - Get all Api versions for a particular ApiEndpoint.
* [GetApis](docs/Sdks/Apis/README.md#getapis) - Get a list of Apis for a given workspace
* [UpsertApi](docs/Sdks/Apis/README.md#upsertapi) - Upsert an Api

### [embeds](docs/Sdks/Embeds/README.md)

* [GetEmbedAccessToken](docs/Sdks/Embeds/README.md#getembedaccesstoken) - Get an embed access token for the current workspace.
* [GetValidEmbedAccessTokens](docs/Sdks/Embeds/README.md#getvalidembedaccesstokens) - Get all valid embed access tokens for the current workspace.
* [RevokeEmbedAccessToken](docs/Sdks/Embeds/README.md#revokeembedaccesstoken) - Revoke an embed access EmbedToken.

### [metadata](docs/Sdks/Metadata/README.md)

* [DeleteVersionMetadata](docs/Sdks/Metadata/README.md#deleteversionmetadata) - Delete metadata for a particular apiID and versionID.
* [GetVersionMetadata](docs/Sdks/Metadata/README.md#getversionmetadata) - Get all metadata for a particular apiID and versionID.
* [InsertVersionMetadata](docs/Sdks/Metadata/README.md#insertversionmetadata) - Insert metadata for a particular apiID and versionID.

### [plugins](docs/Sdks/Plugins/README.md)

* [GetPlugins](docs/Sdks/Plugins/README.md#getplugins) - Get all plugins for the current workspace.
* [RunPlugin](docs/Sdks/Plugins/README.md#runplugin) - Run a plugin
* [UpsertPlugin](docs/Sdks/Plugins/README.md#upsertplugin) - Upsert a plugin

### [requests](docs/Sdks/Requests/README.md)

* [GenerateRequestPostmanCollection](docs/Sdks/Requests/README.md#generaterequestpostmancollection) - Generate a Postman collection for a particular request.
* [GetRequestFromEventLog](docs/Sdks/Requests/README.md#getrequestfromeventlog) - Get information about a particular request.
* [QueryEventLog](docs/Sdks/Requests/README.md#queryeventlog) - Query the event log to retrieve a list of requests.

### [schemas](docs/Sdks/Schemas/README.md)

* [DeleteSchema](docs/Sdks/Schemas/README.md#deleteschema) - Delete a particular schema revision for an Api.
* [DownloadSchema](docs/Sdks/Schemas/README.md#downloadschema) - Download the latest schema for a particular apiID.
* [DownloadSchemaRevision](docs/Sdks/Schemas/README.md#downloadschemarevision) - Download a particular schema revision for an Api.
* [GetSchema](docs/Sdks/Schemas/README.md#getschema) - Get information about the latest schema.
* [GetSchemaDiff](docs/Sdks/Schemas/README.md#getschemadiff) - Get a diff of two schema revisions for an Api.
* [GetSchemaRevision](docs/Sdks/Schemas/README.md#getschemarevision) - Get information about a particular schema revision for an Api.
* [GetSchemas](docs/Sdks/Schemas/README.md#getschemas) - Get information about all schemas associated with a particular apiID.
* [RegisterSchema](docs/Sdks/Schemas/README.md#registerschema) - Register a schema.
<!-- End SDK Available Operations -->

### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
