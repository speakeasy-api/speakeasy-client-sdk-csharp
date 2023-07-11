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
using SDK;
using SDK.Models.Security;
using SDK.Models.Metadata;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Metadata.DeleteVersionMetadata(request);
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
using SDK;
using SDK.Models.Security;
using SDK.Models.Metadata;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Metadata.GetVersionMetadata(request);
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
using SDK;
using SDK.Models.Security;
using SDK.Models.Metadata;

var sdk = new SDKSDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Metadata.InsertVersionMetadata(request);
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [InsertVersionMetadataRequest](../../Models/Shared/InsertVersionMetadataRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[InsertVersionMetadataResponse](../../Models/Metadata/InsertVersionMetadataResponse.md)**

