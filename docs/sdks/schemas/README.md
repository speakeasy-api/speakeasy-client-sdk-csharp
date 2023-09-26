# Schemas

## Overview

REST APIs for managing Schema entities

### Available Operations

* [DeleteSchema](#deleteschema) - Delete a particular schema revision for an Api.
* [DownloadSchema](#downloadschema) - Download the latest schema for a particular apiID.
* [DownloadSchemaRevision](#downloadschemarevision) - Download a particular schema revision for an Api.
* [GetSchema](#getschema) - Get information about the latest schema.
* [GetSchemaDiff](#getschemadiff) - Get a diff of two schema revisions for an Api.
* [GetSchemaRevision](#getschemarevision) - Get information about a particular schema revision for an Api.
* [GetSchemas](#getschemas) - Get information about all schemas associated with a particular apiID.
* [RegisterSchema](#registerschema) - Register a schema.

## DeleteSchema

Delete a particular schema revision for an Api.

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

var res = await sdk.Schemas.DeleteSchemaAsync(new DeleteSchemaRequest() {
    ApiID = "dolores",
    RevisionID = "dolorem",
    VersionID = "corporis",
});

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteSchemaRequest](../../models/operations/DeleteSchemaRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[DeleteSchemaResponse](../../models/operations/DeleteSchemaResponse.md)**


## DownloadSchema

Download the latest schema for a particular apiID.

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

var res = await sdk.Schemas.DownloadSchemaAsync(new DownloadSchemaRequest() {
    ApiID = "explicabo",
    VersionID = "nobis",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [DownloadSchemaRequest](../../models/operations/DownloadSchemaRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[DownloadSchemaResponse](../../models/operations/DownloadSchemaResponse.md)**


## DownloadSchemaRevision

Download a particular schema revision for an Api.

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

var res = await sdk.Schemas.DownloadSchemaRevisionAsync(new DownloadSchemaRevisionRequest() {
    ApiID = "enim",
    RevisionID = "omnis",
    VersionID = "nemo",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [DownloadSchemaRevisionRequest](../../models/operations/DownloadSchemaRevisionRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[DownloadSchemaRevisionResponse](../../models/operations/DownloadSchemaRevisionResponse.md)**


## GetSchema

Returns information about the last uploaded schema for a particular API version. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

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

var res = await sdk.Schemas.GetSchemaAsync(new GetSchemaRequest() {
    ApiID = "minima",
    VersionID = "excepturi",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetSchemaRequest](../../models/operations/GetSchemaRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[GetSchemaResponse](../../models/operations/GetSchemaResponse.md)**


## GetSchemaDiff

Get a diff of two schema revisions for an Api.

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

var res = await sdk.Schemas.GetSchemaDiffAsync(new GetSchemaDiffRequest() {
    ApiID = "accusantium",
    BaseRevisionID = "iure",
    TargetRevisionID = "culpa",
    VersionID = "doloribus",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSchemaDiffRequest](../../models/operations/GetSchemaDiffRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetSchemaDiffResponse](../../models/operations/GetSchemaDiffResponse.md)**


## GetSchemaRevision

Returns information about the last uploaded schema for a particular schema revision. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

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

var res = await sdk.Schemas.GetSchemaRevisionAsync(new GetSchemaRevisionRequest() {
    ApiID = "sapiente",
    RevisionID = "architecto",
    VersionID = "mollitia",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetSchemaRevisionRequest](../../models/operations/GetSchemaRevisionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetSchemaRevisionResponse](../../models/operations/GetSchemaRevisionResponse.md)**


## GetSchemas

Returns information the schemas associated with a particular apiID. 
This won't include the schemas themselves, they can be retrieved via the downloadSchema operation.

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

var res = await sdk.Schemas.GetSchemasAsync(new GetSchemasRequest() {
    ApiID = "dolorem",
    VersionID = "culpa",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetSchemasRequest](../../models/operations/GetSchemasRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetSchemasResponse](../../models/operations/GetSchemasResponse.md)**


## RegisterSchema

Allows uploading a schema for a particular API version.
This will be used to populate ApiEndpoints and used as a base for any schema generation if present.

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

var res = await sdk.Schemas.RegisterSchemaAsync(new RegisterSchemaRequest() {
    RequestBody = new RegisterSchemaRequestBody() {
        File = new RegisterSchemaRequestBodyFile() {
            Content = "consequuntur as bytes <<<>>>",
            File = "repellat",
        },
    },
    ApiID = "mollitia",
    VersionID = "occaecati",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RegisterSchemaRequest](../../models/operations/RegisterSchemaRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RegisterSchemaResponse](../../models/operations/RegisterSchemaResponse.md)**

