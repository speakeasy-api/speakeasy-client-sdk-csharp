# ApiEndpoints
(*ApiEndpoints*)

## Overview

REST APIs for managing ApiEndpoint entities

### Available Operations

* [DeleteApiEndpoint](#deleteapiendpoint) - Delete an ApiEndpoint.
* [FindApiEndpoint](#findapiendpoint) - Find an ApiEndpoint via its displayName.
* [GenerateOpenApiSpecForApiEndpoint](#generateopenapispecforapiendpoint) - Generate an OpenAPI specification for a particular ApiEndpoint.
* [GeneratePostmanCollectionForApiEndpoint](#generatepostmancollectionforapiendpoint) - Generate a Postman collection for a particular ApiEndpoint.
* [GetAllApiEndpoints](#getallapiendpoints) - Get all Api endpoints for a particular apiID.
* [GetAllForVersionApiEndpoints](#getallforversionapiendpoints) - Get all ApiEndpoints for a particular apiID and versionID.
* [GetApiEndpoint](#getapiendpoint) - Get an ApiEndpoint.
* [UpsertApiEndpoint](#upsertapiendpoint) - Upsert an ApiEndpoint.

## DeleteApiEndpoint

Delete an ApiEndpoint. This will also delete all associated Request Logs (if using a Postgres datastore).

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DeleteApiEndpointRequest req = new DeleteApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.DeleteApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [DeleteApiEndpointRequest](../../Models/Operations/DeleteApiEndpointRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[DeleteApiEndpointResponse](../../Models/Operations/DeleteApiEndpointResponse.md)**


## FindApiEndpoint

Find an ApiEndpoint via its displayName (set by operationId from a registered OpenAPI schema).
This is useful for finding the ID of an ApiEndpoint to use in the /v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID} endpoints.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

FindApiEndpointRequest req = new FindApiEndpointRequest() {
    ApiID = "string",
    DisplayName = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.FindApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [FindApiEndpointRequest](../../Models/Operations/FindApiEndpointRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[FindApiEndpointResponse](../../Models/Operations/FindApiEndpointResponse.md)**


## GenerateOpenApiSpecForApiEndpoint

This endpoint will generate a new operation in any registered OpenAPI document if the operation does not already exist in the document.
Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GenerateOpenApiSpecForApiEndpointRequest req = new GenerateOpenApiSpecForApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GenerateOpenApiSpecForApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [GenerateOpenApiSpecForApiEndpointRequest](../../Models/Operations/GenerateOpenApiSpecForApiEndpointRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |


### Response

**[GenerateOpenApiSpecForApiEndpointResponse](../../Models/Operations/GenerateOpenApiSpecForApiEndpointResponse.md)**


## GeneratePostmanCollectionForApiEndpoint

Generates a postman collection that allows the endpoint to be called from postman variables produced for any path/query/header parameters included in the OpenAPI document.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GeneratePostmanCollectionForApiEndpointRequest req = new GeneratePostmanCollectionForApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GeneratePostmanCollectionForApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [GeneratePostmanCollectionForApiEndpointRequest](../../Models/Operations/GeneratePostmanCollectionForApiEndpointRequest.md) | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |


### Response

**[GeneratePostmanCollectionForApiEndpointResponse](../../Models/Operations/GeneratePostmanCollectionForApiEndpointResponse.md)**


## GetAllApiEndpoints

Get all Api endpoints for a particular apiID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetAllApiEndpointsRequest req = new GetAllApiEndpointsRequest() {
    ApiID = "string",
};

var res = await sdk.ApiEndpoints.GetAllApiEndpointsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetAllApiEndpointsRequest](../../Models/Operations/GetAllApiEndpointsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetAllApiEndpointsResponse](../../Models/Operations/GetAllApiEndpointsResponse.md)**


## GetAllForVersionApiEndpoints

Get all ApiEndpoints for a particular apiID and versionID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetAllForVersionApiEndpointsRequest req = new GetAllForVersionApiEndpointsRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GetAllForVersionApiEndpointsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetAllForVersionApiEndpointsRequest](../../Models/Operations/GetAllForVersionApiEndpointsRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[GetAllForVersionApiEndpointsResponse](../../Models/Operations/GetAllForVersionApiEndpointsResponse.md)**


## GetApiEndpoint

Get an ApiEndpoint.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GetApiEndpointRequest req = new GetApiEndpointRequest() {
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.GetApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetApiEndpointRequest](../../Models/Operations/GetApiEndpointRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetApiEndpointResponse](../../Models/Operations/GetApiEndpointResponse.md)**


## UpsertApiEndpoint

Upsert an ApiEndpoint. If the ApiEndpoint does not exist it will be created, otherwise it will be updated.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

UpsertApiEndpointRequest req = new UpsertApiEndpointRequest() {
    ApiEndpoint = new ApiEndpointInput() {
        ApiEndpointId = "string",
        Description = "Public-key systematic attitude",
        DisplayName = "string",
        Method = "string",
        Path = "/etc/periodic",
        VersionId = "string",
    },
    ApiEndpointID = "string",
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.ApiEndpoints.UpsertApiEndpointAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpsertApiEndpointRequest](../../Models/Operations/UpsertApiEndpointRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[UpsertApiEndpointResponse](../../Models/Operations/UpsertApiEndpointResponse.md)**

