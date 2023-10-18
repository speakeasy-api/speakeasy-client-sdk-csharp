# RequestsSDK
(*Requests*)

## Overview

REST APIs for retrieving request information

### Available Operations

* [GenerateRequestPostmanCollection](#generaterequestpostmancollection) - Generate a Postman collection for a particular request.
* [GetRequestFromEventLog](#getrequestfromeventlog) - Get information about a particular request.
* [QueryEventLog](#queryeventlog) - Query the event log to retrieve a list of requests.

## GenerateRequestPostmanCollection

Generates a Postman collection for a particular request. 
Allowing it to be replayed with the same inputs that were captured by the SDK.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.GenerateRequestPostmanCollectionAsync(new GenerateRequestPostmanCollectionRequest() {
    RequestID = "Architect",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GenerateRequestPostmanCollectionRequest](../../models/operations/GenerateRequestPostmanCollectionRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GenerateRequestPostmanCollectionResponse](../../models/operations/GenerateRequestPostmanCollectionResponse.md)**


## GetRequestFromEventLog

Get information about a particular request.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.GetRequestFromEventLogAsync(new GetRequestFromEventLogRequest() {
    RequestID = "Chevrolet",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetRequestFromEventLogRequest](../../models/operations/GetRequestFromEventLogRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetRequestFromEventLogResponse](../../models/operations/GetRequestFromEventLogResponse.md)**


## QueryEventLog

Supports retrieving a list of request captured by the SDK for this workspace.
Allows the filtering of requests on a number of criteria such as ApiID, VersionID, Path, Method, etc.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.QueryEventLogAsync(new QueryEventLogRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "Cotton",
                Value = "Interactions",
            },
        },
        Limit = 6323,
        Offset = 788512,
        Operator = "Practical",
    },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [QueryEventLogRequest](../../models/operations/QueryEventLogRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[QueryEventLogResponse](../../models/operations/QueryEventLogResponse.md)**

