# apiEndpoints

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
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.DeleteApiEndpoint(request);
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [DeleteApiEndpointRequest](../../Models/ApiEndpoints/DeleteApiEndpointRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[DeleteApiEndpointResponse](../../Models/ApiEndpoints/DeleteApiEndpointResponse.md)**


## FindApiEndpoint

Find an ApiEndpoint via its displayName (set by operationId from a registered OpenAPI schema).
This is useful for finding the ID of an ApiEndpoint to use in the /v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID} endpoints.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.FindApiEndpoint(request);
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [FindApiEndpointRequest](../../Models/ApiEndpoints/FindApiEndpointRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[FindApiEndpointResponse](../../Models/ApiEndpoints/FindApiEndpointResponse.md)**


## GenerateOpenApiSpecForApiEndpoint

This endpoint will generate a new operation in any registered OpenAPI document if the operation does not already exist in the document.
Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.GenerateOpenApiSpecForApiEndpoint(request);
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GenerateOpenApiSpecForApiEndpointRequest](../../Models/ApiEndpoints/GenerateOpenApiSpecForApiEndpointRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |


### Response

**[GenerateOpenApiSpecForApiEndpointResponse](../../Models/ApiEndpoints/GenerateOpenApiSpecForApiEndpointResponse.md)**


## GeneratePostmanCollectionForApiEndpoint

Generates a postman collection that allows the endpoint to be called from postman variables produced for any path/query/header parameters included in the OpenAPI document.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.GeneratePostmanCollectionForApiEndpoint(request);
```

### Parameters

| Parameter                                                                                                                     | Type                                                                                                                          | Required                                                                                                                      | Description                                                                                                                   |
| ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                     | [GeneratePostmanCollectionForApiEndpointRequest](../../Models/ApiEndpoints/GeneratePostmanCollectionForApiEndpointRequest.md) | :heavy_check_mark:                                                                                                            | The request object to use for the request.                                                                                    |


### Response

**[GeneratePostmanCollectionForApiEndpointResponse](../../Models/ApiEndpoints/GeneratePostmanCollectionForApiEndpointResponse.md)**


## GetAllApiEndpoints

Get all Api endpoints for a particular apiID.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.GetAllApiEndpoints(request);
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAllApiEndpointsRequest](../../Models/ApiEndpoints/GetAllApiEndpointsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetAllApiEndpointsResponse](../../Models/ApiEndpoints/GetAllApiEndpointsResponse.md)**


## GetAllForVersionApiEndpoints

Get all ApiEndpoints for a particular apiID and versionID.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.GetAllForVersionApiEndpoints(request);
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetAllForVersionApiEndpointsRequest](../../Models/ApiEndpoints/GetAllForVersionApiEndpointsRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[GetAllForVersionApiEndpointsResponse](../../Models/ApiEndpoints/GetAllForVersionApiEndpointsResponse.md)**


## GetApiEndpoint

Get an ApiEndpoint.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.GetApiEndpoint(request);
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetApiEndpointRequest](../../Models/ApiEndpoints/GetApiEndpointRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[GetApiEndpointResponse](../../Models/ApiEndpoints/GetApiEndpointResponse.md)**


## UpsertApiEndpoint

Upsert an ApiEndpoint. If the ApiEndpoint does not exist it will be created, otherwise it will be updated.

### Example Usage

```csharp
using SDK;
using SDK.Models.Security;
using SDK.Models.ApiEndpoints;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.ApiEndpoints.UpsertApiEndpoint(request);
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [UpsertApiEndpointRequest](../../Models/Shared/UpsertApiEndpointRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[UpsertApiEndpointResponse](../../Models/ApiEndpoints/UpsertApiEndpointResponse.md)**

