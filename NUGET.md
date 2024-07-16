# SpeakeasySDK


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetApisRequest req = new GetApisRequest() {};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

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
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

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
    });

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetWorkspaceAccessAsync(req);

// handle response
```
<!-- End Retries [retries] -->

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
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;
using SpeakeasySDK.Models.Errors;

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
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

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

<!-- Placeholder for Future Speakeasy SDK Sections -->