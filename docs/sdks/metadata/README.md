# metadata

## Overview

REST APIs for managing Version Metadata entities

### Available Operations

* [DeleteVersionMetadata](#deleteversionmetadata) - Delete metadata for a particular apiID and versionID.
* [GetVersionMetadata](#getversionmetadata) - Get all metadata for a particular apiID and versionID.
* [InsertVersionMetadata](#insertversionmetadata) - Insert metadata for a particular apiID and versionID.

## DeleteVersionMetadata

Delete metadata for a particular apiID and versionID.

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

var res = await sdk.Metadata.DeleteVersionMetadataAsync(new DeleteVersionMetadataRequest() {
    ApiID = "excepturi",
    MetaKey = "accusantium",
    MetaValue = "iure",
    VersionID = "culpa",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeleteVersionMetadataRequest](../../models/operations/DeleteVersionMetadataRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[DeleteVersionMetadataResponse](../../models/operations/DeleteVersionMetadataResponse.md)**


## GetVersionMetadata

Get all metadata for a particular apiID and versionID.

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

var res = await sdk.Metadata.GetVersionMetadataAsync(new GetVersionMetadataRequest() {
    ApiID = "doloribus",
    VersionID = "sapiente",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetVersionMetadataRequest](../../models/operations/GetVersionMetadataRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetVersionMetadataResponse](../../models/operations/GetVersionMetadataResponse.md)**


## InsertVersionMetadata

Insert metadata for a particular apiID and versionID.

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

var res = await sdk.Metadata.InsertVersionMetadataAsync(new InsertVersionMetadataRequest() {
    VersionMetadataInput = new VersionMetadataInput() {
        MetaKey = "architecto",
        MetaValue = "mollitia",
    },
    ApiID = "dolorem",
    VersionID = "culpa",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [InsertVersionMetadataRequest](../../models/operations/InsertVersionMetadataRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[InsertVersionMetadataResponse](../../models/operations/InsertVersionMetadataResponse.md)**
