# CodeSamples
(*CodeSamples*)

## Overview

REST APIs for retrieving Code Samples

### Available Operations

* [GenerateCodeSamplePreview](#generatecodesamplepreview) - Generate Code Sample previews from a file and configuration parameters.
* [GenerateCodeSamplePreviewAsync](#generatecodesamplepreviewasync) - Initiate asynchronous Code Sample preview generation from a file and configuration parameters, receiving an async JobID response for polling.
* [GetCodeSamplePreviewAsync](#getcodesamplepreviewasync) - Poll for the result of an asynchronous Code Sample preview generation.

## GenerateCodeSamplePreview

This endpoint generates Code Sample previews from a file and configuration parameters.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Language = "<value>",
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
| SpeakeasySDK.Models.Errors.Error | 4XX                              | application/json                 |
| SpeakeasySDK.Models.Errors.Error | 5XX                              | application/json                 |

## GenerateCodeSamplePreviewAsync

This endpoint generates Code Sample previews from a file and configuration parameters, receiving an async JobID response for polling.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CodeSampleSchemaInput req = new CodeSampleSchemaInput() {
    Language = "<value>",
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
| SpeakeasySDK.Models.Errors.Error | 4XX                              | application/json                 |
| SpeakeasySDK.Models.Errors.Error | 5XX                              | application/json                 |

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
| SpeakeasySDK.Models.Errors.Error | 4XX                              | application/json                 |
| SpeakeasySDK.Models.Errors.Error | 5XX                              | application/json                 |