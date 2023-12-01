# Apis
(*Apis*)

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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

DeleteApiRequest req = new DeleteApiRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Apis.DeleteApiAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [DeleteApiRequest](../../Models/Operations/DeleteApiRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[DeleteApiResponse](../../Models/Operations/DeleteApiResponse.md)**


## GenerateOpenApiSpec

This endpoint will generate any missing operations in any registered OpenAPI document if the operation does not already exist in the document.
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

GenerateOpenApiSpecRequest req = new GenerateOpenApiSpecRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Apis.GenerateOpenApiSpecAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateOpenApiSpecRequest](../../Models/Operations/GenerateOpenApiSpecRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateOpenApiSpecResponse](../../Models/Operations/GenerateOpenApiSpecResponse.md)**


## GeneratePostmanCollection

Generates a postman collection containing all endpoints for a particular API. Includes variables produced for any path/query/header parameters included in the OpenAPI document.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    });

GeneratePostmanCollectionRequest req = new GeneratePostmanCollectionRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Apis.GeneratePostmanCollectionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [GeneratePostmanCollectionRequest](../../Models/Operations/GeneratePostmanCollectionRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[GeneratePostmanCollectionResponse](../../Models/Operations/GeneratePostmanCollectionResponse.md)**


## GetAllApiVersions

Get all Api versions for a particular ApiEndpoint.
Supports filtering the versions based on metadata attributes.

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

GetAllApiVersionsRequest req = new GetAllApiVersionsRequest() {
    ApiID = "string",
    Metadata = new Dictionary<string, List<string>>() {
        { "key", new List<string>() {
            "string",
        } },
    },
    Op = new Op() {
        And = false,
    },
};

var res = await sdk.Apis.GetAllApiVersionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetAllApiVersionsRequest](../../Models/Operations/GetAllApiVersionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetAllApiVersionsResponse](../../Models/Operations/GetAllApiVersionsResponse.md)**


## GetApis

Get a list of all Apis and their versions for a given workspace.
Supports filtering the APIs based on metadata attributes.

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

GetApisRequest req = new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "key", new List<string>() {
            "string",
        } },
    },
    Op = new QueryParamOp() {
        And = false,
    },
};

var res = await sdk.Apis.GetApisAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetApisRequest](../../Models/Operations/GetApisRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[GetApisResponse](../../Models/Operations/GetApisResponse.md)**


## UpsertApi

Upsert an Api. If the Api does not exist, it will be created.
If the Api exists, it will be updated.

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

UpsertApiRequest req = new UpsertApiRequest() {
    Api = new ApiInput() {
        ApiId = "string",
        Description = "Synchronised 5th generation knowledge user",
        MetaData = new Dictionary<string, List<string>>() {
            { "key", new List<string>() {
                "string",
            } },
        },
        VersionId = "string",
    },
    ApiID = "string",
};

var res = await sdk.Apis.UpsertApiAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [UpsertApiRequest](../../Models/Operations/UpsertApiRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[UpsertApiResponse](../../Models/Operations/UpsertApiResponse.md)**

