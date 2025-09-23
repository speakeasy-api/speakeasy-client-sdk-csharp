# SpeakeasySDK


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

<!-- Placeholder for Future Speakeasy SDK Sections -->