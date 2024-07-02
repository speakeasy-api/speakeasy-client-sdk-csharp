# Speakeasy

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

```bash
dotnet add package SpeakeasySDK
```

### Locally

```bash
dotnet add reference path/to/SpeakeasySDK.csproj
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

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetApisRequest req = new GetApisRequest() {};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

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

### [Artifacts](docs/sdks/artifacts/README.md)

* [GetBlob](docs/sdks/artifacts/README.md#getblob) - Get blob for a particular digest
* [GetManifest](docs/sdks/artifacts/README.md#getmanifest) - Get manifest for a particular reference
* [GetNamespaces](docs/sdks/artifacts/README.md#getnamespaces) - Each namespace contains many revisions.
* [GetOASSummary](docs/sdks/artifacts/README.md#getoassummary)
* [GetRevisions](docs/sdks/artifacts/README.md#getrevisions)
* [GetTags](docs/sdks/artifacts/README.md#gettags)
* [PostTags](docs/sdks/artifacts/README.md#posttags) - Add tags to an existing revision
* [Preflight](docs/sdks/artifacts/README.md#preflight) - Get access token for communicating with OCI distribution endpoints

### [Auth](docs/sdks/auth/README.md)

* [GetAccessToken](docs/sdks/auth/README.md#getaccesstoken) - Get or refresh an access token for the current workspace.
* [GetUser](docs/sdks/auth/README.md#getuser) - Get information about the current user.
* [GetWorkspaceAccess](docs/sdks/auth/README.md#getworkspaceaccess) - Get access allowances for a particular workspace
* [ValidateApiKey](docs/sdks/auth/README.md#validateapikey) - Validate the current api key.

### [Requests](docs/sdks/requests/README.md)

* [GenerateRequestPostmanCollection](docs/sdks/requests/README.md#generaterequestpostmancollection) - Generate a Postman collection for a particular request.
* [GetRequestFromEventLog](docs/sdks/requests/README.md#getrequestfromeventlog) - Get information about a particular request.
* [QueryEventLog](docs/sdks/requests/README.md#queryeventlog) - Query the event log to retrieve a list of requests.

### [Github](docs/sdks/github/README.md)

* [CheckAccess](docs/sdks/github/README.md#checkaccess)
* [ConfigureCodeSamples](docs/sdks/github/README.md#configurecodesamples)
* [ConfigureMintlifyRepo](docs/sdks/github/README.md#configuremintlifyrepo)
* [ConfigureTarget](docs/sdks/github/README.md#configuretarget)
* [FetchPublishingPRs](docs/sdks/github/README.md#fetchpublishingprs)
* [GetAction](docs/sdks/github/README.md#getaction)
* [GithubCheckPublishingSecrets](docs/sdks/github/README.md#githubcheckpublishingsecrets)
* [GithubStorePublishingSecrets](docs/sdks/github/README.md#githubstorepublishingsecrets)
* [TriggerAction](docs/sdks/github/README.md#triggeraction)

### [Organizations](docs/sdks/organizations/README.md)

* [CreateFreeTrial](docs/sdks/organizations/README.md#createfreetrial) - Create a free trial for an organization
* [GetOrganizationUsage](docs/sdks/organizations/README.md#getorganizationusage) - Get billing usage summary for a particular organization
* [GetOrganizations](docs/sdks/organizations/README.md#getorganizations) - Get organizations for a user

### [Reports](docs/sdks/reports/README.md)

* [GetChangesReportSignedUrl](docs/sdks/reports/README.md#getchangesreportsignedurl) - Get the signed access url for the change reports for a particular document.
* [GetLintingReportSignedUrl](docs/sdks/reports/README.md#getlintingreportsignedurl) - Get the signed access url for the linting reports for a particular document.
* [UploadReport](docs/sdks/reports/README.md#uploadreport) - Upload a report.

### [Suggest](docs/sdks/suggest/README.md)

* [ApplyOperationIDs](docs/sdks/suggest/README.md#applyoperationids) - Apply operation ID suggestions and download result.
* [SuggestOperationIDs](docs/sdks/suggest/README.md#suggestoperationids) - Generate operation ID suggestions.
* [SuggestOperationIDsRegistry](docs/sdks/suggest/README.md#suggestoperationidsregistry) - Generate operation ID suggestions.

### [Embeds](docs/sdks/embeds/README.md)

* [GetEmbedAccessToken](docs/sdks/embeds/README.md#getembedaccesstoken) - Get an embed access token for the current workspace.
* [GetValidEmbedAccessTokens](docs/sdks/embeds/README.md#getvalidembedaccesstokens) - Get all valid embed access tokens for the current workspace.
* [RevokeEmbedAccessToken](docs/sdks/embeds/README.md#revokeembedaccesstoken) - Revoke an embed access EmbedToken.

### [Events](docs/sdks/events/README.md)

* [GetWorkspaceEventsByTarget](docs/sdks/events/README.md#getworkspaceeventsbytarget) - Load recent events for a particular workspace
* [GetWorkspaceTargets](docs/sdks/events/README.md#getworkspacetargets) - Load targets for a particular workspace
* [PostWorkspaceEvents](docs/sdks/events/README.md#postworkspaceevents) - Post events for a specific workspace
* [SearchWorkspaceEvents](docs/sdks/events/README.md#searchworkspaceevents) - Search events for a particular workspace by any field
<!-- End Available Resources and Operations [operations] -->



<!-- Start Server Selection [server] -->
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

This SDK supports the following security schemes globally:

| Name        | Type        | Scheme      |
| ----------- | ----------- | ----------- |
| `APIKey`    | apiKey      | API key     |
| `Bearer`    | http        | HTTP Bearer |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. The selected scheme will be used by default to authenticate with the API for all operations that support it. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

DeleteApiRequest req = new DeleteApiRequest() {
    ApiID = "<value>",
    VersionID = "<value>",
};

var res = await sdk.Apis.DeleteApiAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Global Parameters [global-parameters] -->
## Global Parameters

## Global Parameters

A parameter is configured globally. This parameter may be set on the SDK client instance itself during initialization. When configured as an option during SDK initialization, This global value will be used as the default on the operations that use it. When such operations are called, there is a place in each to override the global value, if needed.

For example, you can set `workspaceID` to `"<value>"` at SDK initialization and then you do not have to pass the same value on calls to operations like `GetWorkspaceEventsByTarget`. But if you want to do so you may, which will locally override the global setting. See the example code below for a demonstration.


### Available Globals

The following global parameter is available.

| Name | Type | Required | Description |
| ---- | ---- |:--------:| ----------- |
| workspaceID | string |  | The WorkspaceID parameter. |


### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetWorkspaceEventsByTargetRequest req = new GetWorkspaceEventsByTargetRequest() {
    TargetID = "<value>",
};

var res = await sdk.Events.GetWorkspaceEventsByTargetAsync(req);

// handle response
```
<!-- End Global Parameters [global-parameters] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;
using SpeakeasySDK.Models.Errors;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetWorkspaceEventsByTargetRequest req = new GetWorkspaceEventsByTargetRequest() {
    TargetID = "<value>",
};

try
{
    var res = await sdk.Events.GetWorkspaceEventsByTargetAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is Error)
    {
        // handle exception
    }
    else if (ex is SpeakeasySDK.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetWorkspaceAccessAsync(req,
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
));

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
),
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetWorkspaceAccessAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
