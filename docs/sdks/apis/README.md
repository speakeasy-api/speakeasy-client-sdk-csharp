# Apis

## Overview

REST APIs for managing Api entities

### Available Operations

* [DeleteApi](#deleteapi) - Delete an Api.
* [GenerateOpenApiSpec](#generateopenapispec) - Generate an OpenAPI specification for a particular Api.
* [GeneratePostmanCollection](#generatepostmancollection) - Generate a Postman collection for a particular Api.
* [GetAllApiVersions](#getallapiversions) - Get all Api versions for a particular ApiEndpoint.
* [GetApis](#getapis) - Get a list of Apis for a given workspace
* [UpsertApi](#upsertapi) - Upsert an Api

## DeleteApi

Delete a particular version of an Api. The will also delete all associated ApiEndpoints, Metadata, Schemas & Request Logs (if using a Postgres datastore).

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

var res = await sdk.Apis.DeleteApiAsync(new DeleteApiRequest() {
    ApiID = "quis",
    VersionID = "veritatis",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [DeleteApiRequest](../../models/operations/DeleteApiRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[DeleteApiResponse](../../models/operations/DeleteApiResponse.md)**


## GenerateOpenApiSpec

This endpoint will generate any missing operations in any registered OpenAPI document if the operation does not already exist in the document.
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

var res = await sdk.Apis.GenerateOpenApiSpecAsync(new GenerateOpenApiSpecRequest() {
    ApiID = "deserunt",
    VersionID = "perferendis",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateOpenApiSpecRequest](../../models/operations/GenerateOpenApiSpecRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateOpenApiSpecResponse](../../models/operations/GenerateOpenApiSpecResponse.md)**


## GeneratePostmanCollection

Generates a postman collection containing all endpoints for a particular API. Includes variables produced for any path/query/header parameters included in the OpenAPI document.

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

var res = await sdk.Apis.GeneratePostmanCollectionAsync(new GeneratePostmanCollectionRequest() {
    ApiID = "ipsam",
    VersionID = "repellendus",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GeneratePostmanCollectionRequest](../../models/operations/GeneratePostmanCollectionRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GeneratePostmanCollectionResponse](../../models/operations/GeneratePostmanCollectionResponse.md)**


## GetAllApiVersions

Get all Api versions for a particular ApiEndpoint.
Supports filtering the versions based on metadata attributes.

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

var res = await sdk.Apis.GetAllApiVersionsAsync(new GetAllApiVersionsRequest() {
    ApiID = "sapiente",
    Metadata = new Dictionary<string, List<string>>() {
        { "quo", new List<string>() {
            "odit",
        } },
    },
    Op = new GetAllApiVersionsOp() {
        And = false,
    },
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetAllApiVersionsRequest](../../models/operations/GetAllApiVersionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetAllApiVersionsResponse](../../models/operations/GetAllApiVersionsResponse.md)**


## GetApis

Get a list of all Apis and their versions for a given workspace.
Supports filtering the APIs based on metadata attributes.

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

var res = await sdk.Apis.GetApisAsync(new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "at", new List<string>() {
            "at",
        } },
    },
    Op = new GetApisOp() {
        And = false,
    },
});

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetApisRequest](../../models/operations/GetApisRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[GetApisResponse](../../models/operations/GetApisResponse.md)**


## UpsertApi

Upsert an Api. If the Api does not exist, it will be created.
If the Api exists, it will be updated.

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

var res = await sdk.Apis.UpsertApiAsync(new UpsertApiRequest() {
    ApiInput = new ApiInput() {
        ApiId = "maiores",
        Description = "molestiae",
        MetaData = new Dictionary<string, List<string>>() {
            { "quod", new List<string>() {
                "quod",
            } },
        },
        VersionId = "esse",
    },
    ApiID = "totam",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [UpsertApiRequest](../../models/operations/UpsertApiRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[UpsertApiResponse](../../models/operations/UpsertApiResponse.md)**

