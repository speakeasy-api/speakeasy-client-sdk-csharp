# ShortURLs
(*ShortURLs*)

## Overview

REST APIs for managing short URLs

### Available Operations

* [Create](#create) - Shorten a URL.

## Create

Shorten a URL.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create" method="post" path="/v1/short_urls" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CreateRequestBody req = new CreateRequestBody() {
    Url = "https://exalted-heroine.org/",
};

var res = await sdk.ShortURLs.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [CreateRequestBody](../../Models/Operations/CreateRequestBody.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[CreateResponse](../../Models/Operations/CreateResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |