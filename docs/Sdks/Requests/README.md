# requests

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
using Speakeasy.Models.Security;
using Speakeasy.Models.Requests;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.GenerateRequestPostmanCollectionAsync(new GenerateRequestPostmanCollectionRequest() {
    RequestID = "quo",
});
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GenerateRequestPostmanCollectionRequest](../../Models/Requests/GenerateRequestPostmanCollectionRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |


### Response

**[GenerateRequestPostmanCollectionResponse](../../Models/Requests/GenerateRequestPostmanCollectionResponse.md)**


## GetRequestFromEventLog

Get information about a particular request.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Requests;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.GetRequestFromEventLogAsync(new GetRequestFromEventLogRequest() {
    RequestID = "sequi",
});
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetRequestFromEventLogRequest](../../Models/Requests/GetRequestFromEventLogRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetRequestFromEventLogResponse](../../Models/Requests/GetRequestFromEventLogResponse.md)**


## QueryEventLog

Supports retrieving a list of request captured by the SDK for this workspace.
Allows the filtering of requests on a number of criteria such as ApiID, VersionID, Path, Method, etc.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Requests;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Requests.QueryEventLogAsync(new QueryEventLogRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "ipsam",
                Operator = "id",
                Value = "possimus",
            },
            new Filter() {
                Key = "aut",
                Operator = "quasi",
                Value = "error",
            },
            new Filter() {
                Key = "temporibus",
                Operator = "laborum",
                Value = "quasi",
            },
            new Filter() {
                Key = "reiciendis",
                Operator = "voluptatibus",
                Value = "vero",
            },
        },
        Limit = 468651,
        Offset = 509624,
        Operator = "voluptatibus",
    },
});
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [QueryEventLogRequest](../../Models/Requests/QueryEventLogRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[QueryEventLogResponse](../../Models/Requests/QueryEventLogResponse.md)**

