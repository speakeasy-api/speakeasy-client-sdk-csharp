# Suggest
(*Suggest*)

## Overview

REST APIs for managing LLM OAS suggestions

### Available Operations

* [Suggest](#suggest) - Generate suggestions for improving an OpenAPI document.
* [SuggestItems](#suggestitems) - Generate generic suggestions for a list of items.
* [SuggestOpenAPI](#suggestopenapi) - (DEPRECATED) Generate suggestions for improving an OpenAPI document.
* [SuggestOpenAPIRegistry](#suggestopenapiregistry) - Generate suggestions for improving an OpenAPI document stored in the registry.

## Suggest

Get suggestions from an LLM model for improving an OpenAPI document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="suggest" method="post" path="/v1/suggest/openapi_from_summary" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestRequest req = new SuggestRequest() {
    SuggestRequestBody = new SuggestRequestBody() {
        Diagnostics = new List<Diagnostic>() {
            new Diagnostic() {
                Message = "<value>",
                Path = new List<string>() {
                    "/usr/src",
                },
                Type = "<value>",
            },
        },
        OasSummary = new OASSummary() {
            Info = new OASInfo() {
                Description = "prioritize bell vainly",
                License = new License() {},
                Summary = "<value>",
                Title = "<value>",
                Version = "<value>",
            },
            Operations = new List<OASOperation>() {
                new OASOperation() {
                    Description = "though since instead accurate safe unnaturally charming",
                    Method = "<value>",
                    OperationId = "<id>",
                    Path = "/usr/local/bin",
                    Tags = new List<string>() {
                        "<value 1>",
                        "<value 2>",
                    },
                },
            },
        },
        SuggestionType = SuggestRequestBodySuggestionType.MethodNames,
    },
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [SuggestRequest](../../Models/Operations/SuggestRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[SuggestResponse](../../Models/Operations/SuggestResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## SuggestItems

Generate generic suggestions for a list of items.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="suggestItems" method="post" path="/v1/suggest/items" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestItemsRequestBody req = new SuggestItemsRequestBody() {
    Items = new List<string>() {
        "<value 1>",
    },
    Prompt = "<value>",
};

var res = await sdk.Suggest.SuggestItemsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [SuggestItemsRequestBody](../../Models/Shared/SuggestItemsRequestBody.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[SuggestItemsResponse](../../Models/Operations/SuggestItemsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## SuggestOpenAPI

Get suggestions from an LLM model for improving an OpenAPI document.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="suggestOpenAPI" method="post" path="/v1/suggest/openapi" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestOpenAPIRequest req = new SuggestOpenAPIRequest() {
    RequestBody = new SuggestOpenAPIRequestBody() {
        Schema = new Schema() {
            Content = System.IO.File.ReadAllBytes("example.file"),
            FileName = "example.file",
        },
    },
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestOpenAPIAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [SuggestOpenAPIRequest](../../Models/Operations/SuggestOpenAPIRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[SuggestOpenAPIResponse](../../Models/Operations/SuggestOpenAPIResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## SuggestOpenAPIRegistry

Get suggestions from an LLM model for improving an OpenAPI document stored in the registry.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="suggestOpenAPIRegistry" method="post" path="/v1/suggest/openapi/{namespace_name}/{revision_reference}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SuggestOpenAPIRegistryRequest req = new SuggestOpenAPIRegistryRequest() {
    NamespaceName = "<value>",
    RevisionReference = "<value>",
    XSessionId = "<id>",
};

var res = await sdk.Suggest.SuggestOpenAPIRegistryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [SuggestOpenAPIRegistryRequest](../../Models/Operations/SuggestOpenAPIRegistryRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[SuggestOpenAPIRegistryResponse](../../Models/Operations/SuggestOpenAPIRegistryResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |