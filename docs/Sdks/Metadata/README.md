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
using Speakeasy.Models.Security;
using Speakeasy.Models.Metadata;

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
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [DeleteVersionMetadataRequest](../../Models/Metadata/DeleteVersionMetadataRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[DeleteVersionMetadataResponse](../../Models/Metadata/DeleteVersionMetadataResponse.md)**


## GetVersionMetadata

Get all metadata for a particular apiID and versionID.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Metadata;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Metadata.GetVersionMetadataAsync(new GetVersionMetadataRequest() {
    ApiID = "doloribus",
    VersionID = "sapiente",
});
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetVersionMetadataRequest](../../Models/Metadata/GetVersionMetadataRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetVersionMetadataResponse](../../Models/Metadata/GetVersionMetadataResponse.md)**


## InsertVersionMetadata

Insert metadata for a particular apiID and versionID.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Metadata;
using Speakeasy.Models.Shared;

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
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [InsertVersionMetadataRequest](../../Models/Shared/InsertVersionMetadataRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[InsertVersionMetadataResponse](../../Models/Metadata/InsertVersionMetadataResponse.md)**

