# ShortURLs
(*ShortURLs*)

## Overview

REST APIs for managing short URLs

### Available Operations

* [Create](#create) - Shorten a URL.

## Create

Shorten a URL.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CreateRequestBody req = new CreateRequestBody() {
    Url = "http://limp-pastry.org",
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

| Error Object                            | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4xx-5xx                                 | */*                                     |
