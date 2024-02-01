# Schemas
(*Schemas*)

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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

DeleteSchemaRequest req = new DeleteSchemaRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DeleteSchemaAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteSchemaRequest](../../Models/Operations/DeleteSchemaRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |


### Response

**[DeleteSchemaResponse](../../Models/Operations/DeleteSchemaResponse.md)**


## DownloadSchema

Download the latest schema for a particular apiID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

DownloadSchemaRequest req = new DownloadSchemaRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DownloadSchemaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [DownloadSchemaRequest](../../Models/Operations/DownloadSchemaRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[DownloadSchemaResponse](../../Models/Operations/DownloadSchemaResponse.md)**


## DownloadSchemaRevision

Download a particular schema revision for an Api.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

DownloadSchemaRevisionRequest req = new DownloadSchemaRevisionRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.DownloadSchemaRevisionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [DownloadSchemaRevisionRequest](../../Models/Operations/DownloadSchemaRevisionRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[DownloadSchemaRevisionResponse](../../Models/Operations/DownloadSchemaRevisionResponse.md)**


## GetSchema

Returns information about the last uploaded schema for a particular API version. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetSchemaRequest req = new GetSchemaRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetSchemaRequest](../../Models/Operations/GetSchemaRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[GetSchemaResponse](../../Models/Operations/GetSchemaResponse.md)**


## GetSchemaDiff

Get a diff of two schema revisions for an Api.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetSchemaDiffRequest req = new GetSchemaDiffRequest() {
    ApiID = "string",
    BaseRevisionID = "string",
    TargetRevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaDiffAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetSchemaDiffRequest](../../Models/Operations/GetSchemaDiffRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[GetSchemaDiffResponse](../../Models/Operations/GetSchemaDiffResponse.md)**


## GetSchemaRevision

Returns information about the last uploaded schema for a particular schema revision. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetSchemaRevisionRequest req = new GetSchemaRevisionRequest() {
    ApiID = "string",
    RevisionID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemaRevisionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetSchemaRevisionRequest](../../Models/Operations/GetSchemaRevisionRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetSchemaRevisionResponse](../../Models/Operations/GetSchemaRevisionResponse.md)**


## GetSchemas

Returns information the schemas associated with a particular apiID. 
This won't include the schemas themselves, they can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

GetSchemasRequest req = new GetSchemasRequest() {
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.GetSchemasAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetSchemasRequest](../../Models/Operations/GetSchemasRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetSchemasResponse](../../Models/Operations/GetSchemasResponse.md)**


## RegisterSchema

Allows uploading a schema for a particular API version.
This will be used to populate ApiEndpoints and used as a base for any schema generation if present.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    });

RegisterSchemaRequest req = new RegisterSchemaRequest() {
    RequestBody = new RegisterSchemaRequestBody() {
        File = new File() {
            Content = "0xCAFCA03e0e as bytes <<<>>>",
            FileName = "bronze_table_blues.m2a",
        },
    },
    ApiID = "string",
    VersionID = "string",
};

var res = await sdk.Schemas.RegisterSchemaAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [RegisterSchemaRequest](../../Models/Operations/RegisterSchemaRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[RegisterSchemaResponse](../../Models/Operations/RegisterSchemaResponse.md)**

