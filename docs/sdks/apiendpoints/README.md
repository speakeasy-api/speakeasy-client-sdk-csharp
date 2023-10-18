# ApiEndpointsSDK
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
using Speakeasy;
using Speakeasy.Models.Shared;
using Speakeasy.Models.Operations;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.ApiEndpoints.DeleteApiEndpointAsync(new DeleteApiEndpointRequest() {
    ApiEndpointID = "blue",
    ApiID = "Gasoline",
    VersionID = "Southwest",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [DeleteApiEndpointRequest](../../models/operations/DeleteApiEndpointRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[DeleteApiEndpointResponse](../../models/operations/DeleteApiEndpointResponse.md)**


## FindApiEndpoint

Find an ApiEndpoint via its displayName (set by operationId from a registered OpenAPI schema).
This is useful for finding the ID of an ApiEndpoint to use in the /v1/apis/{apiID}/version/{versionID}/api_endpoints/{apiEndpointID} endpoints.

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

var res = await sdk.ApiEndpoints.FindApiEndpointAsync(new FindApiEndpointRequest() {
    ApiID = "Cotton",
    DisplayName = "Chief",
    VersionID = "Wooden",
});

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [FindApiEndpointRequest](../../models/operations/FindApiEndpointRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[FindApiEndpointResponse](../../models/operations/FindApiEndpointResponse.md)**


## GenerateOpenApiSpecForApiEndpoint

This endpoint will generate a new operation in any registered OpenAPI document if the operation does not already exist in the document.
Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.

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

var res = await sdk.ApiEndpoints.GenerateOpenApiSpecForApiEndpointAsync(new GenerateOpenApiSpecForApiEndpointRequest() {
    ApiEndpointID = "Mazda",
    ApiID = "web",
    VersionID = "explicabo",
});

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [GenerateOpenApiSpecForApiEndpointRequest](../../models/operations/GenerateOpenApiSpecForApiEndpointRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |


### Response

**[GenerateOpenApiSpecForApiEndpointResponse](../../models/operations/GenerateOpenApiSpecForApiEndpointResponse.md)**


## GeneratePostmanCollectionForApiEndpoint

Generates a postman collection that allows the endpoint to be called from postman variables produced for any path/query/header parameters included in the OpenAPI document.

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

var res = await sdk.ApiEndpoints.GeneratePostmanCollectionForApiEndpointAsync(new GeneratePostmanCollectionForApiEndpointRequest() {
    ApiEndpointID = "indigo",
    ApiID = "barring",
    VersionID = "Senior",
});

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [GeneratePostmanCollectionForApiEndpointRequest](../../models/operations/GeneratePostmanCollectionForApiEndpointRequest.md) | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |


### Response

**[GeneratePostmanCollectionForApiEndpointResponse](../../models/operations/GeneratePostmanCollectionForApiEndpointResponse.md)**


## GetAllApiEndpoints

Get all Api endpoints for a particular apiID.

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

var res = await sdk.ApiEndpoints.GetAllApiEndpointsAsync(new GetAllApiEndpointsRequest() {
    ApiID = "unless",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetAllApiEndpointsRequest](../../models/operations/GetAllApiEndpointsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetAllApiEndpointsResponse](../../models/operations/GetAllApiEndpointsResponse.md)**


## GetAllForVersionApiEndpoints

Get all ApiEndpoints for a particular apiID and versionID.

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

var res = await sdk.ApiEndpoints.GetAllForVersionApiEndpointsAsync(new GetAllForVersionApiEndpointsRequest() {
    ApiID = "now",
    VersionID = "Diesel",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetAllForVersionApiEndpointsRequest](../../models/operations/GetAllForVersionApiEndpointsRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[GetAllForVersionApiEndpointsResponse](../../models/operations/GetAllForVersionApiEndpointsResponse.md)**


## GetApiEndpoint

Get an ApiEndpoint.

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

var res = await sdk.ApiEndpoints.GetApiEndpointAsync(new GetApiEndpointRequest() {
    ApiEndpointID = "flog",
    ApiID = "synthesize",
    VersionID = "Barium",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetApiEndpointRequest](../../models/operations/GetApiEndpointRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetApiEndpointResponse](../../models/operations/GetApiEndpointResponse.md)**


## UpsertApiEndpoint

Upsert an ApiEndpoint. If the ApiEndpoint does not exist it will be created, otherwise it will be updated.

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

var res = await sdk.ApiEndpoints.UpsertApiEndpointAsync(new UpsertApiEndpointRequest() {
    ApiEndpointInput = new ApiEndpointInput() {
        ApiEndpointId = "Facilitator",
        Description = "Cross-group bottom-line productivity",
        DisplayName = "nor",
        Method = "Northwest",
        Path = "/private",
        VersionId = "what",
    },
    ApiEndpointID = "Trans",
    ApiID = "Kia",
    VersionID = "Electronic",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [UpsertApiEndpointRequest](../../models/operations/UpsertApiEndpointRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[UpsertApiEndpointResponse](../../models/operations/UpsertApiEndpointResponse.md)**

