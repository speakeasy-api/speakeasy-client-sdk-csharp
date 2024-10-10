# Artifacts
(*Artifacts*)

## Overview

REST APIs for working with Registry artifacts

### Available Operations

* [GetBlob](#getblob) - Get blob for a particular digest
* [GetManifest](#getmanifest) - Get manifest for a particular reference
* [GetNamespaces](#getnamespaces) - Each namespace contains many revisions.
* [GetRevisions](#getrevisions)
* [GetTags](#gettags)
* [PostTags](#posttags) - Add tags to an existing revision
* [Preflight](#preflight) - Get access token for communicating with OCI distribution endpoints

## GetBlob

Get blob for a particular digest

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetBlobRequest req = new GetBlobRequest() {
    Digest = "<value>",
    NamespaceName = "<value>",
    OrganizationSlug = "<value>",
    WorkspaceSlug = "<value>",
};

var res = await sdk.Artifacts.GetBlobAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetBlobRequest](../../Models/Operations/GetBlobRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[GetBlobResponse](../../Models/Operations/GetBlobResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetManifest

Get manifest for a particular reference

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetManifestRequest req = new GetManifestRequest() {
    NamespaceName = "<value>",
    OrganizationSlug = "<value>",
    RevisionReference = "<value>",
    WorkspaceSlug = "<value>",
};

var res = await sdk.Artifacts.GetManifestAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetManifestRequest](../../Models/Operations/GetManifestRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetManifestResponse](../../Models/Operations/GetManifestResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetNamespaces

Each namespace contains many revisions.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Artifacts.GetNamespacesAsync();

// handle response
```

### Response

**[Models.Operations.GetNamespacesResponse](../../Models/Operations/GetNamespacesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetRevisions

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetRevisionsRequest req = new GetRevisionsRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.GetRevisionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetRevisionsRequest](../../Models/Operations/GetRevisionsRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[Models.Operations.GetRevisionsResponse](../../Models/Operations/GetRevisionsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetTags

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetTagsRequest req = new GetTagsRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.GetTagsAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [GetTagsRequest](../../Models/Operations/GetTagsRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[Models.Operations.GetTagsResponse](../../Models/Operations/GetTagsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## PostTags

Add tags to an existing revision

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

PostTagsRequest req = new PostTagsRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.PostTagsAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [PostTagsRequest](../../Models/Operations/PostTagsRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[PostTagsResponse](../../Models/Operations/PostTagsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## Preflight

Get access token for communicating with OCI distribution endpoints

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

PreflightRequest req = new PreflightRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.PreflightAsync(req);

// handle response
```

### Parameters

| Parameter                                                   | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `request`                                                   | [PreflightRequest](../../Models/Shared/PreflightRequest.md) | :heavy_check_mark:                                          | The request object to use for the request.                  |

### Response

**[PreflightResponse](../../Models/Operations/PreflightResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |