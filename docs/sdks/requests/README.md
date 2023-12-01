# Requests
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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GenerateRequestPostmanCollectionRequest req = new GenerateRequestPostmanCollectionRequest() {
    RequestID = "string",
};

var res = await sdk.Requests.GenerateRequestPostmanCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GenerateRequestPostmanCollectionRequest](../../Models/Operations/GenerateRequestPostmanCollectionRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GenerateRequestPostmanCollectionResponse](../../Models/Operations/GenerateRequestPostmanCollectionResponse.md)**


## GetRequestFromEventLog

Get information about a particular request.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetRequestFromEventLogRequest req = new GetRequestFromEventLogRequest() {
    RequestID = "string",
};

var res = await sdk.Requests.GetRequestFromEventLogAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetRequestFromEventLogRequest](../../Models/Operations/GetRequestFromEventLogRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetRequestFromEventLogResponse](../../Models/Operations/GetRequestFromEventLogResponse.md)**


## QueryEventLog

Supports retrieving a list of request captured by the SDK for this workspace.
Allows the filtering of requests on a number of criteria such as ApiID, VersionID, Path, Method, etc.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

QueryEventLogRequest req = new QueryEventLogRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 241978,
        Offset = 451388,
        Operator = "string",
    },
};

var res = await sdk.Requests.QueryEventLogAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [QueryEventLogRequest](../../Models/Operations/QueryEventLogRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[QueryEventLogResponse](../../Models/Operations/QueryEventLogResponse.md)**

