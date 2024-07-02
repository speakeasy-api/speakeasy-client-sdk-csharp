# Suggest
(*Suggest*)

## Overview

REST APIs for managing LLM OAS suggestions

### Available Operations

* [ApplyOperationIDs](#applyoperationids) - Apply operation ID suggestions and download result.
* [SuggestOperationIDs](#suggestoperationids) - Generate operation ID suggestions.
* [SuggestOperationIDsRegistry](#suggestoperationidsregistry) - Generate operation ID suggestions.

## ApplyOperationIDs

Apply operation ID suggestions and download result.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

ApplyOperationIDsRequest req = new ApplyOperationIDsRequest() {
    XSessionId = "<value>",
};

var res = await sdk.Suggest.ApplyOperationIDsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ApplyOperationIDsRequest](../../Models/Operations/ApplyOperationIDsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[ApplyOperationIDsResponse](../../Models/Operations/ApplyOperationIDsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## SuggestOperationIDs

Get suggestions from an LLM model for improving the operationIDs in the provided schema.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

SuggestOperationIDsRequest req = new SuggestOperationIDsRequest() {
    RequestBody = new SuggestOperationIDsRequestBody() {
        Schema = new Models.Operations.Schema() {
            Content = System.Text.Encoding.UTF8.GetBytes("0xb2de88c98a"),
            FileName = "your_file_here",
        },
    },
    XSessionId = "<value>",
};

var res = await sdk.Suggest.SuggestOperationIDsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [SuggestOperationIDsRequest](../../Models/Operations/SuggestOperationIDsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[SuggestOperationIDsResponse](../../Models/Operations/SuggestOperationIDsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |

## SuggestOperationIDsRegistry

Get suggestions from an LLM model for improving the operationIDs in the provided schema.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

SuggestOperationIDsRegistryRequest req = new SuggestOperationIDsRegistryRequest() {
    NamespaceName = "<value>",
    RevisionReference = "<value>",
    XSessionId = "<value>",
};

var res = await sdk.Suggest.SuggestOperationIDsRegistryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [SuggestOperationIDsRegistryRequest](../../Models/Operations/SuggestOperationIDsRegistryRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |


### Response

**[SuggestOperationIDsRegistryResponse](../../Models/Operations/SuggestOperationIDsRegistryResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
