# Suggest
(*Suggest*)

## Overview

REST APIs for managing LLM OAS suggestions

### Available Operations

* [SuggestOperationIDs](#suggestoperationids) - Generate operation ID suggestions.

## SuggestOperationIDs

Get suggestions from an LLM model for improving the operationIDs in the provided schema.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

SuggestOperationIDsRequestBody req = new SuggestOperationIDsRequestBody() {
    Schema = new Models.Operations.Schema() {
        Content = System.Text.Encoding.UTF8.GetBytes("0xb2de88c98a"),
        FileName = "your_file_here",
    },
};

var res = await sdk.Suggest.SuggestOperationIDsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [SuggestOperationIDsRequestBody](../../Models/Operations/SuggestOperationIDsRequestBody.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[SuggestOperationIDsResponse](../../Models/Operations/SuggestOperationIDsResponse.md)**
### Errors

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
