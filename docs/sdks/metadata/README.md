# Metadata
(*Metadata*)

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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

DeleteVersionMetadataRequest req = new DeleteVersionMetadataRequest() {
    ApiID = "<value>",
    MetaKey = "<value>",
    MetaValue = "<value>",
    VersionID = "<value>",
};

var res = await sdk.Metadata.DeleteVersionMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeleteVersionMetadataRequest](../../Models/Operations/DeleteVersionMetadataRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[DeleteVersionMetadataResponse](../../Models/Operations/DeleteVersionMetadataResponse.md)**


## GetVersionMetadata

Get all metadata for a particular apiID and versionID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

GetVersionMetadataRequest req = new GetVersionMetadataRequest() {
    ApiID = "<value>",
    VersionID = "<value>",
};

var res = await sdk.Metadata.GetVersionMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetVersionMetadataRequest](../../Models/Operations/GetVersionMetadataRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetVersionMetadataResponse](../../Models/Operations/GetVersionMetadataResponse.md)**


## InsertVersionMetadata

Insert metadata for a particular apiID and versionID.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

InsertVersionMetadataRequest req = new InsertVersionMetadataRequest() {
    VersionMetadata = new VersionMetadataInput() {
        MetaKey = "<value>",
        MetaValue = "<value>",
    },
    ApiID = "<value>",
    VersionID = "<value>",
};

var res = await sdk.Metadata.InsertVersionMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [InsertVersionMetadataRequest](../../Models/Operations/InsertVersionMetadataRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[InsertVersionMetadataResponse](../../Models/Operations/InsertVersionMetadataResponse.md)**

