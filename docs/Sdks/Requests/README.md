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
        apiKey = "",
    }
);

var res = await sdk.Requests.GenerateRequestPostmanCollection(request);
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
        apiKey = "",
    }
);

var res = await sdk.Requests.GetRequestFromEventLog(request);
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

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Requests.QueryEventLog(request);
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [QueryEventLogRequest](../../Models/Requests/QueryEventLogRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[QueryEventLogResponse](../../Models/Requests/QueryEventLogResponse.md)**

