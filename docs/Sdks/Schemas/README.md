# schemas

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
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.DeleteSchema(request);
```

### Parameters

| Parameter                                                          | Type                                                               | Required                                                           | Description                                                        |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `request`                                                          | [DeleteSchemaRequest](../../Models/Schemas/DeleteSchemaRequest.md) | :heavy_check_mark:                                                 | The request object to use for the request.                         |


### Response

**[DeleteSchemaResponse](../../Models/Schemas/DeleteSchemaResponse.md)**


## DownloadSchema

Download the latest schema for a particular apiID.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.DownloadSchema(request);
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [DownloadSchemaRequest](../../Models/Schemas/DownloadSchemaRequest.md) | :heavy_check_mark:                                                     | The request object to use for the request.                             |


### Response

**[DownloadSchemaResponse](../../Models/Schemas/DownloadSchemaResponse.md)**


## DownloadSchemaRevision

Download a particular schema revision for an Api.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.DownloadSchemaRevision(request);
```

### Parameters

| Parameter                                                                              | Type                                                                                   | Required                                                                               | Description                                                                            |
| -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------- |
| `request`                                                                              | [DownloadSchemaRevisionRequest](../../Models/Schemas/DownloadSchemaRevisionRequest.md) | :heavy_check_mark:                                                                     | The request object to use for the request.                                             |


### Response

**[DownloadSchemaRevisionResponse](../../Models/Schemas/DownloadSchemaRevisionResponse.md)**


## GetSchema

Returns information about the last uploaded schema for a particular API version. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.GetSchema(request);
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [GetSchemaRequest](../../Models/Schemas/GetSchemaRequest.md) | :heavy_check_mark:                                           | The request object to use for the request.                   |


### Response

**[GetSchemaResponse](../../Models/Schemas/GetSchemaResponse.md)**


## GetSchemaDiff

Get a diff of two schema revisions for an Api.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.GetSchemaDiff(request);
```

### Parameters

| Parameter                                                            | Type                                                                 | Required                                                             | Description                                                          |
| -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- | -------------------------------------------------------------------- |
| `request`                                                            | [GetSchemaDiffRequest](../../Models/Schemas/GetSchemaDiffRequest.md) | :heavy_check_mark:                                                   | The request object to use for the request.                           |


### Response

**[GetSchemaDiffResponse](../../Models/Schemas/GetSchemaDiffResponse.md)**


## GetSchemaRevision

Returns information about the last uploaded schema for a particular schema revision. 
This won't include the schema itself, that can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.GetSchemaRevision(request);
```

### Parameters

| Parameter                                                                    | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `request`                                                                    | [GetSchemaRevisionRequest](../../Models/Schemas/GetSchemaRevisionRequest.md) | :heavy_check_mark:                                                           | The request object to use for the request.                                   |


### Response

**[GetSchemaRevisionResponse](../../Models/Schemas/GetSchemaRevisionResponse.md)**


## GetSchemas

Returns information the schemas associated with a particular apiID. 
This won't include the schemas themselves, they can be retrieved via the downloadSchema operation.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.GetSchemas(request);
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [GetSchemasRequest](../../Models/Schemas/GetSchemasRequest.md) | :heavy_check_mark:                                             | The request object to use for the request.                     |


### Response

**[GetSchemasResponse](../../Models/Schemas/GetSchemasResponse.md)**


## RegisterSchema

Allows uploading a schema for a particular API version.
This will be used to populate ApiEndpoints and used as a base for any schema generation if present.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Schemas;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Schemas.RegisterSchema(request);
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [RegisterSchemaRequest](../../Models/Schemas/RegisterSchemaRequest.md) | :heavy_check_mark:                                                     | The request object to use for the request.                             |


### Response

**[RegisterSchemaResponse](../../Models/Schemas/RegisterSchemaResponse.md)**

