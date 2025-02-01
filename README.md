# Speakeasy

<!-- Start Summary [summary] -->
## Summary

Speakeasy API: The Subscriptions API manages subscriptions for CLI and registry events

For more information about the API: [The Speakeasy Platform Documentation](/docs)
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Speakeasy](#speakeasy)
  * [SDK Installation](#sdk-installation)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server Selection](#server-selection)
  * [Authentication](#authentication)
  * [Global Parameters](#global-parameters)
  * [Error Handling](#error-handling)
  * [Retries](#retries)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package SpeakeasySDK
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference src/SpeakeasySDK/SpeakeasySDK.csproj
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Artifacts](docs/sdks/artifacts/README.md)

* [CreateRemoteSource](docs/sdks/artifacts/README.md#createremotesource) - Configure a new remote source
* [GetBlob](docs/sdks/artifacts/README.md#getblob) - Get blob for a particular digest
* [GetManifest](docs/sdks/artifacts/README.md#getmanifest) - Get manifest for a particular reference
* [GetNamespaces](docs/sdks/artifacts/README.md#getnamespaces) - Each namespace contains many revisions.
* [GetRevisions](docs/sdks/artifacts/README.md#getrevisions)
* [GetTags](docs/sdks/artifacts/README.md#gettags)
* [ListRemoteSources](docs/sdks/artifacts/README.md#listremotesources) - Get remote sources attached to a particular namespace
* [PostTags](docs/sdks/artifacts/README.md#posttags) - Add tags to an existing revision
* [Preflight](docs/sdks/artifacts/README.md#preflight) - Get access token for communicating with OCI distribution endpoints
* [SetArchived](docs/sdks/artifacts/README.md#setarchived) - Set whether a namespace is archived
* [SetVisibility](docs/sdks/artifacts/README.md#setvisibility) - Set visibility of a namespace with an existing metadata entry

### [Auth](docs/sdks/auth/README.md)

* [GetAccess](docs/sdks/auth/README.md#getaccess) - Get access allowances for a particular workspace
* [GetAccessToken](docs/sdks/auth/README.md#getaccesstoken) - Get or refresh an access token for the current workspace.
* [GetUser](docs/sdks/auth/README.md#getuser) - Get information about the current user.
* [ValidateApiKey](docs/sdks/auth/README.md#validateapikey) - Validate the current api key.

### [CodeSamples](docs/sdks/codesamples/README.md)

* [GenerateCodeSamplePreview](docs/sdks/codesamples/README.md#generatecodesamplepreview) - Generate Code Sample previews from a file and configuration parameters.
* [GenerateCodeSamplePreviewAsync](docs/sdks/codesamples/README.md#generatecodesamplepreviewasync) - Initiate asynchronous Code Sample preview generation from a file and configuration parameters, receiving an async JobID response for polling.
* [GetCodeSamplePreviewAsync](docs/sdks/codesamples/README.md#getcodesamplepreviewasync) - Poll for the result of an asynchronous Code Sample preview generation.

### [Events](docs/sdks/events/README.md)

* [GetEventsByTarget](docs/sdks/events/README.md#geteventsbytarget) - Load recent events for a particular workspace
* [GetTargets](docs/sdks/events/README.md#gettargets) - Load targets for a particular workspace
* [GetTargetsDeprecated](docs/sdks/events/README.md#gettargetsdeprecated) - Load targets for a particular workspace
* [Post](docs/sdks/events/README.md#post) - Post events for a specific workspace
* [Search](docs/sdks/events/README.md#search) - Search events for a particular workspace by any field

### [Github](docs/sdks/github/README.md)

* [CheckAccess](docs/sdks/github/README.md#checkaccess)
* [CheckPublishingPRs](docs/sdks/github/README.md#checkpublishingprs)
* [CheckPublishingSecrets](docs/sdks/github/README.md#checkpublishingsecrets)
* [ConfigureCodeSamples](docs/sdks/github/README.md#configurecodesamples)
* [ConfigureMintlifyRepo](docs/sdks/github/README.md#configuremintlifyrepo)
* [ConfigureTarget](docs/sdks/github/README.md#configuretarget)
* [GetAction](docs/sdks/github/README.md#getaction)
* [GetSetup](docs/sdks/github/README.md#getsetup)
* [LinkGithub](docs/sdks/github/README.md#linkgithub)
* [StorePublishingSecrets](docs/sdks/github/README.md#storepublishingsecrets)
* [TriggerAction](docs/sdks/github/README.md#triggeraction)

### [Organizations](docs/sdks/organizations/README.md)

* [Create](docs/sdks/organizations/README.md#create) - Create an organization
* [CreateFreeTrial](docs/sdks/organizations/README.md#createfreetrial) - Create a free trial for an organization
* [Get](docs/sdks/organizations/README.md#get) - Get organization
* [GetAll](docs/sdks/organizations/README.md#getall) - Get organizations for a user
* [GetUsage](docs/sdks/organizations/README.md#getusage) - Get billing usage summary for a particular organization

### [Reports](docs/sdks/reports/README.md)

* [GetChangesReportSignedUrl](docs/sdks/reports/README.md#getchangesreportsignedurl) - Get the signed access url for the change reports for a particular document.
* [GetLintingReportSignedUrl](docs/sdks/reports/README.md#getlintingreportsignedurl) - Get the signed access url for the linting reports for a particular document.
* [UploadReport](docs/sdks/reports/README.md#uploadreport) - Upload a report.


### [ShortURLs](docs/sdks/shorturls/README.md)

* [Create](docs/sdks/shorturls/README.md#create) - Shorten a URL.

### [Subscriptions](docs/sdks/subscriptions/README.md)

* [ActivateSubscriptionNamespace](docs/sdks/subscriptions/README.md#activatesubscriptionnamespace) - Activate an ignored namespace for a subscription
* [IgnoreSubscriptionNamespace](docs/sdks/subscriptions/README.md#ignoresubscriptionnamespace) - Ignored a namespace for a subscription

### [Suggest](docs/sdks/suggest/README.md)

* [Suggest](docs/sdks/suggest/README.md#suggest) - Generate suggestions for improving an OpenAPI document.
* [SuggestItems](docs/sdks/suggest/README.md#suggestitems) - Generate generic suggestions for a list of items.
* [SuggestOpenAPI](docs/sdks/suggest/README.md#suggestopenapi) - (DEPRECATED) Generate suggestions for improving an OpenAPI document.
* [SuggestOpenAPIRegistry](docs/sdks/suggest/README.md#suggestopenapiregistry) - Generate suggestions for improving an OpenAPI document stored in the registry.

### [Workspaces](docs/sdks/workspaces/README.md)

* [Create](docs/sdks/workspaces/README.md#create) - Create a workspace
* [CreateToken](docs/sdks/workspaces/README.md#createtoken) - Create a token for a particular workspace
* [DeleteToken](docs/sdks/workspaces/README.md#deletetoken) - Delete a token for a particular workspace
* [Get](docs/sdks/workspaces/README.md#get) - Get workspace by context
* [GetAll](docs/sdks/workspaces/README.md#getall) - Get workspaces for a user
* [GetByID](docs/sdks/workspaces/README.md#getbyid) - Get workspace
* [GetFeatureFlags](docs/sdks/workspaces/README.md#getfeatureflags) - Get workspace feature flags
* [GetSettings](docs/sdks/workspaces/README.md#getsettings) - Get workspace settings
* [GetTeam](docs/sdks/workspaces/README.md#getteam) - Get team members for a particular workspace
* [GetTokens](docs/sdks/workspaces/README.md#gettokens) - Get tokens for a particular workspace
* [GrantAccess](docs/sdks/workspaces/README.md#grantaccess) - Grant a user access to a particular workspace
* [RevokeAccess](docs/sdks/workspaces/README.md#revokeaccess) - Revoke a user's access to a particular workspace
* [SetFeatureFlags](docs/sdks/workspaces/README.md#setfeatureflags) - Set workspace feature flags
* [Update](docs/sdks/workspaces/README.md#update) - Update workspace details
* [UpdateSettings](docs/sdks/workspaces/README.md#updatesettings) - Update workspace settings

</details>
<!-- End Available Resources and Operations [operations] -->



<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Name

You can override the default server globally by passing a server name to the `server: string` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the names associated with the available servers:

| Name   | Server                              |
| ------ | ----------------------------------- |
| `prod` | `https://api.prod.speakeasyapi.dev` |

#### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(
    server: "prod",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(
    serverUrl: "https://api.prod.speakeasyapi.dev",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security schemes globally:

| Name                  | Type   | Scheme      |
| --------------------- | ------ | ----------- |
| `APIKey`              | apiKey | API key     |
| `Bearer`              | http   | HTTP Bearer |
| `WorkspaceIdentifier` | apiKey | API key     |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. The selected scheme will be used by default to authenticate with the API for all operations that support it. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Global Parameters [global-parameters] -->
## Global Parameters

A parameter is configured globally. This parameter may be set on the SDK client instance itself during initialization. When configured as an option during SDK initialization, This global value will be used as the default on the operations that use it. When such operations are called, there is a place in each to override the global value, if needed.

For example, you can set `workspace_id` to `"<id>"` at SDK initialization and then you do not have to pass the same value on calls to operations like `GetAccessToken`. But if you want to do so you may, which will locally override the global setting. See the example code below for a demonstration.


### Available Globals

The following global parameter is available.

| Name        | Type   | Description                |
| ----------- | ------ | -------------------------- |
| workspaceId | string | The WorkspaceId parameter. |

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK();

GetAccessTokenRequest req = new GetAccessTokenRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Auth.GetAccessTokenAsync(req);

// handle response
```
<!-- End Global Parameters [global-parameters] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `SpeakeasySDK.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `CreateRemoteSourceAsync` method throws the following exceptions:

| Error Type                              | Status Code | Content Type     |
| --------------------------------------- | ----------- | ---------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX         | application/json |
| SpeakeasySDK.Models.Errors.SDKException | 5XX         | \*/\*            |

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Errors;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

try
{
    RemoteSource req = new RemoteSource() {
        Inputs = new List<RemoteDocument>() {
            new RemoteDocument() {
                RegistryUrl = "https://productive-swine.net",
            },
        },
        Output = new RemoteDocument() {
            RegistryUrl = "https://spiteful-apricot.info",
        },
    };

    var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is Error)
    {
        // Handle exception data
        throw;
    }
    else if (ex is SpeakeasySDK.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
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
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetAccessAsync(
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
    request: req
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

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
    }
);

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetAccessAsync(req);

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
