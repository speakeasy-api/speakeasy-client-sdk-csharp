# CodeSamples
(*CodeSamples*)

## Overview

REST APIs for retrieving Code Samples

### Available Operations

* [GenerateCodeSamplePreview](#generatecodesamplepreview) - Generate Code Sample previews from a file and configuration parameters.
* [GenerateCodeSamplePreviewAsync](#generatecodesamplepreviewasync) - Initiate asynchronous Code Sample preview generation from a file and configuration parameters, receiving an async JobID response for polling.
* [Get](#get) - Retrieve usage snippets from document stored in the registry
* [GetCodeSamplePreviewAsync](#getcodesamplepreviewasync) - Poll for the result of an asynchronous Code Sample preview generation.

## GenerateCodeSamplePreview

This endpoint generates Code Sample previews from a file and configuration parameters.

### Example Usage

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

var res = await sdk.CodeSamples.GenerateCodeSamplePreviewAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CodeSampleSchemaInput](../../Models/Shared/CodeSampleSchemaInput.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GenerateCodeSamplePreviewResponse](../../Models/Operations/GenerateCodeSamplePreviewResponse.md)**

### Errors

| Error Type                       | Status Code                      | Content Type                     |
| -------------------------------- | -------------------------------- | -------------------------------- |
| SpeakeasySDK.Models.Errors.Error | 4XX, 5XX                         | application/json                 |

## GenerateCodeSamplePreviewAsync

This endpoint generates Code Sample previews from a file and configuration parameters, receiving an async JobID response for polling.

### Example Usage

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
        Content = System.Text.Encoding.UTF8.GetBytes("0xED5CDd177E"),
        FileName = "example.file",
    },
};

var res = await sdk.CodeSamples.GenerateCodeSamplePreviewAsyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CodeSampleSchemaInput](../../Models/Shared/CodeSampleSchemaInput.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GenerateCodeSamplePreviewAsyncResponse](../../Models/Operations/GenerateCodeSamplePreviewAsyncResponse.md)**

### Errors

| Error Type                       | Status Code                      | Content Type                     |
| -------------------------------- | -------------------------------- | -------------------------------- |
| SpeakeasySDK.Models.Errors.Error | 4XX, 5XX                         | application/json                 |

## Get

Retrieve usage snippets from document stored in the registry. Supports filtering by language and operation ID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetCodeSamplesRequest req = new GetCodeSamplesRequest() {
    RegistryUrl = "https://normal-making.name",
};

var res = await sdk.CodeSamples.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetCodeSamplesRequest](../../Models/Operations/GetCodeSamplesRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetCodeSamplesResponse](../../Models/Operations/GetCodeSamplesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetCodeSamplePreviewAsync

Poll for the result of an asynchronous Code Sample preview generation.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetCodeSamplePreviewAsyncRequest req = new GetCodeSamplePreviewAsyncRequest() {
    JobID = "<id>",
};

var res = await sdk.CodeSamples.GetCodeSamplePreviewAsyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GetCodeSamplePreviewAsyncRequest](../../Models/Operations/GetCodeSamplePreviewAsyncRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[GetCodeSamplePreviewAsyncResponse](../../Models/Operations/GetCodeSamplePreviewAsyncResponse.md)**

### Errors

| Error Type                       | Status Code                      | Content Type                     |
| -------------------------------- | -------------------------------- | -------------------------------- |
| SpeakeasySDK.Models.Errors.Error | 4XX, 5XX                         | application/json                 |