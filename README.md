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
  * [Custom HTTP Client](#custom-http-client)

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

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource? req = null;

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
* [CreateBillingAddOns](docs/sdks/organizations/README.md#createbillingaddons) - Create billing add ons
* [CreateFreeTrial](docs/sdks/organizations/README.md#createfreetrial) - Create a free trial for an organization
* [DeleteBillingAddOn](docs/sdks/organizations/README.md#deletebillingaddon) - Delete billing add ons
* [Get](docs/sdks/organizations/README.md#get) - Get organization
* [GetAll](docs/sdks/organizations/README.md#getall) - Get organizations for a user
* [GetBillingAddOns](docs/sdks/organizations/README.md#getbillingaddons) - Get billing add ons
* [GetUsage](docs/sdks/organizations/README.md#getusage) - Get billing usage summary for a particular organization

### [PublishingTokens](docs/sdks/publishingtokens/README.md)

* [Create](docs/sdks/publishingtokens/README.md#create) - Create a publishing token for a workspace
* [Delete](docs/sdks/publishingtokens/README.md#delete) - Delete a specific publishing token
* [Get](docs/sdks/publishingtokens/README.md#get) - Get a specific publishing token
* [List](docs/sdks/publishingtokens/README.md#list) - Get publishing tokens for a workspace
* [ResolveMetadata](docs/sdks/publishingtokens/README.md#resolvemetadata) - Get metadata about the token
* [ResolveTarget](docs/sdks/publishingtokens/README.md#resolvetarget) - Get a specific publishing token target
* [Update](docs/sdks/publishingtokens/README.md#update) - Updates the validitity period of a publishing token

### [Reports](docs/sdks/reports/README.md)

* [GetChangesReportSignedUrl](docs/sdks/reports/README.md#getchangesreportsignedurl) - Get the signed access url for the change reports for a particular document.
* [GetLintingReportSignedUrl](docs/sdks/reports/README.md#getlintingreportsignedurl) - Get the signed access url for the linting reports for a particular document.
* [UploadReport](docs/sdks/reports/README.md#uploadreport) - Upload a report.

### [SchemaStore](docs/sdks/schemastore/README.md)

* [CreateSchemaStoreItem](docs/sdks/schemastore/README.md#createschemastoreitem) - Create a schema in the schema store
* [GetSchemaStoreItem](docs/sdks/schemastore/README.md#getschemastoreitem) - Get a OAS schema from the schema store

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

| Name   | Server                           | Description |
| ------ | -------------------------------- | ----------- |
| `prod` | `https://api.prod.speakeasy.com` |             |

#### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    server: SDKConfig.Server.Prod,
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

RemoteSource? req = null;

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(
    serverUrl: "https://api.prod.speakeasy.com",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

RemoteSource? req = null;

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

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource? req = null;

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

var sdk = new SDK(workspaceId: "<id>");

GetAccessTokenRequest req = new GetAccessTokenRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Auth.GetAccessTokenAsync(req);

// handle response
```
<!-- End Global Parameters [global-parameters] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`SDKBaseException`](./src/SpeakeasySDK/Models/Errors/SDKBaseException.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `StatusCode`  | *int*                 | HTTP status code      |
| `Headers`     | *HttpResponseHeaders* | HTTP headers          |
| `ContentType` | *string?*             | HTTP content type     |
| `RawResponse` | *HttpResponseMessage* | HTTP response object  |
| `Body`        | *string*              | HTTP response body    |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Errors;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

try
{
    RemoteSource? req = null;

    var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

    // handle response
}
catch (SDKBaseException ex)  // all SDK exceptions inherit from SDKBaseException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is Error) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        ErrorPayload payload = ex.Payload;
        string Message = payload.Message;
        int StatusCode = payload.StatusCode;
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exceptions:**
* [`SDKBaseException`](./src/SpeakeasySDK/Models/Errors/SDKBaseException.cs): The base class for HTTP error responses.
  * [`Error`](./src/SpeakeasySDK/Models/Errors/Error.cs): The `Status` type defines a logical error model. *

<details><summary>Less common exceptions (2)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`SDKBaseException`](./src/SpeakeasySDK/Models/Errors/SDKBaseException.cs):
  * [`ResponseValidationError`](./src/SpeakeasySDK/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

\* Refer to the [relevant documentation](#available-resources-and-operations) to determine whether an exception applies to a specific operation.
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

GetWorkspaceAccessRequest? req = null;

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

GetWorkspaceAccessRequest? req = null;

var res = await sdk.Auth.GetAccessAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new SDK(client: customHttpClient);
```

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using SpeakeasySDK.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = SDK.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by implementing a custom client:</summary>

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new SDK(client: new LoggingHttpClient());
```
</details>

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->



### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
