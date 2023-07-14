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
        APIKey = "",
    }
);

var res = await sdk.Schemas.DeleteSchemaAsync(new DeleteSchemaRequest() {
    ApiID = "ipsa",
    RevisionID = "omnis",
    VersionID = "voluptate",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.DownloadSchemaAsync(new DownloadSchemaRequest() {
    ApiID = "cum",
    VersionID = "perferendis",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.DownloadSchemaRevisionAsync(new DownloadSchemaRevisionRequest() {
    ApiID = "doloremque",
    RevisionID = "reprehenderit",
    VersionID = "ut",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.GetSchemaAsync(new GetSchemaRequest() {
    ApiID = "maiores",
    VersionID = "dicta",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.GetSchemaDiffAsync(new GetSchemaDiffRequest() {
    ApiID = "corporis",
    BaseRevisionID = "dolore",
    TargetRevisionID = "iusto",
    VersionID = "dicta",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.GetSchemaRevisionAsync(new GetSchemaRevisionRequest() {
    ApiID = "harum",
    RevisionID = "enim",
    VersionID = "accusamus",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.GetSchemasAsync(new GetSchemasRequest() {
    ApiID = "commodi",
    VersionID = "repudiandae",
});
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
        APIKey = "",
    }
);

var res = await sdk.Schemas.RegisterSchemaAsync(new RegisterSchemaRequest() {
    RequestBody = new RegisterSchemaRequestBody() {
        File = new RegisterSchemaRequestBodyFile() {
            Content = "quae as bytes <<<>>>",
            File = "ipsum",
        },
    },
    ApiID = "quidem",
    VersionID = "molestias",
});
```

### Parameters

| Parameter                                                              | Type                                                                   | Required                                                               | Description                                                            |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| `request`                                                              | [RegisterSchemaRequest](../../Models/Schemas/RegisterSchemaRequest.md) | :heavy_check_mark:                                                     | The request object to use for the request.                             |


### Response

**[RegisterSchemaResponse](../../Models/Schemas/RegisterSchemaResponse.md)**

