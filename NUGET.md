# SpeakeasySDK


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Languages = new List<string>() {
        "<value>",
    },
    SchemaFile = new SchemaFile() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
        FileName = "example.file",
    },
};

var res = await sdk.GenerateCodeSamplePreviewAsync(req);

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
using System;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Languages = new List<string>() {
        "<value>",
    },
    SchemaFile = new SchemaFile() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
        FileName = "example.file",
    },
};

var res = await sdk.GenerateCodeSamplePreviewAsync(req);

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

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GenerateCodeSamplePreviewAsync` method throws the following exceptions:

| Error Type                       | Status Code | Content Type     |
| -------------------------------- | ----------- | ---------------- |
| SpeakeasySDK.Models.Errors.Error | 4XX, 5XX    | application/json |

### Example

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Errors;
using SpeakeasySDK.Models.Shared;
using System;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

try
{
    CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
        Languages = new List<string>() {
            "<value>",
        },
        SchemaFile = new SchemaFile() {
            Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
            FileName = "example.file",
        },
    };

    var res = await sdk.GenerateCodeSamplePreviewAsync(req);

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
using System;
using System.Collections.Generic;

var sdk = new SDK(
    server: "prod",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Languages = new List<string>() {
        "<value>",
    },
    SchemaFile = new SchemaFile() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
        FileName = "example.file",
    },
};

var res = await sdk.GenerateCodeSamplePreviewAsync(req);

// handle response
```

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;
using System.Collections.Generic;

var sdk = new SDK(
    serverUrl: "https://api.prod.speakeasyapi.dev",
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    }
);

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Languages = new List<string>() {
        "<value>",
    },
    SchemaFile = new SchemaFile() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xc3dD8BfBef"),
        FileName = "example.file",
    },
};

var res = await sdk.GenerateCodeSamplePreviewAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->