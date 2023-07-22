# apis

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
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.DeleteApiAsync(new DeleteApiRequest() {
    ApiID = "quod",
    VersionID = "esse",
});
```

### Parameters

| Parameter                                                 | Type                                                      | Required                                                  | Description                                               |
| --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- | --------------------------------------------------------- |
| `request`                                                 | [DeleteApiRequest](../../Models/Apis/DeleteApiRequest.md) | :heavy_check_mark:                                        | The request object to use for the request.                |


### Response

**[DeleteApiResponse](../../Models/Apis/DeleteApiResponse.md)**


## GenerateOpenApiSpec

This endpoint will generate any missing operations in any registered OpenAPI document if the operation does not already exist in the document.
Returns the original document and the newly generated document allowing a diff to be performed to see what has changed.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GenerateOpenApiSpecAsync(new GenerateOpenApiSpecRequest() {
    ApiID = "totam",
    VersionID = "porro",
});
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GenerateOpenApiSpecRequest](../../Models/Apis/GenerateOpenApiSpecRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GenerateOpenApiSpecResponse](../../Models/Apis/GenerateOpenApiSpecResponse.md)**


## GeneratePostmanCollection

Generates a postman collection containing all endpoints for a particular API. Includes variables produced for any path/query/header parameters included in the OpenAPI document.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GeneratePostmanCollectionAsync(new GeneratePostmanCollectionRequest() {
    ApiID = "dolorum",
    VersionID = "dicta",
});
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GeneratePostmanCollectionRequest](../../Models/Apis/GeneratePostmanCollectionRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GeneratePostmanCollectionResponse](../../Models/Apis/GeneratePostmanCollectionResponse.md)**


## GetAllApiVersions

Get all Api versions for a particular ApiEndpoint.
Supports filtering the versions based on metadata attributes.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GetAllApiVersionsAsync(new GetAllApiVersionsRequest() {
    ApiID = "nam",
    Metadata = new Dictionary<string, List<string>>() {
        { "occaecati", new List<string>() {
            "deleniti",
        } },
        { "hic", new List<string>() {
            "totam",
            "beatae",
            "commodi",
            "molestiae",
        } },
        { "modi", new List<string>() {
            "impedit",
        } },
    },
    Op = new GetAllApiVersionsOp() {
        And = false,
    },
});
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetAllApiVersionsRequest](../../Models/Apis/GetAllApiVersionsRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetAllApiVersionsResponse](../../Models/Apis/GetAllApiVersionsResponse.md)**


## GetApis

Get a list of all Apis and their versions for a given workspace.
Supports filtering the APIs based on metadata attributes.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.GetApisAsync(new GetApisRequest() {
    Metadata = new Dictionary<string, List<string>>() {
        { "esse", new List<string>() {
            "excepturi",
        } },
        { "aspernatur", new List<string>() {
            "ad",
        } },
        { "natus", new List<string>() {
            "iste",
        } },
    },
    Op = new GetApisOp() {
        And = false,
    },
});
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `request`                                             | [GetApisRequest](../../Models/Apis/GetApisRequest.md) | :heavy_check_mark:                                    | The request object to use for the request.            |


### Response

**[GetApisResponse](../../Models/Apis/GetApisResponse.md)**


## UpsertApi

Upsert an Api. If the Api does not exist, it will be created.
If the Api exists, it will be updated.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Apis;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Apis.UpsertApiAsync(new UpsertApiRequest() {
    ApiInput = new ApiInput() {
        ApiId = "dolor",
        Description = "natus",
        MetaData = new Dictionary<string, List<string>>() {
            { "hic", new List<string>() {
                "fuga",
                "in",
                "corporis",
                "iste",
            } },
            { "iure", new List<string>() {
                "quidem",
                "architecto",
                "ipsa",
                "reiciendis",
            } },
        },
        VersionId = "est",
    },
    ApiID = "mollitia",
});
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [UpsertApiRequest](../../Models/Shared/UpsertApiRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |


### Response

**[UpsertApiResponse](../../Models/Apis/UpsertApiResponse.md)**

