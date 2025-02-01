# Artifacts
(*Artifacts*)

## Overview

REST APIs for working with Registry artifacts

### Available Operations

* [CreateRemoteSource](#createremotesource) - Configure a new remote source
* [GetBlob](#getblob) - Get blob for a particular digest
* [GetManifest](#getmanifest) - Get manifest for a particular reference
* [GetNamespaces](#getnamespaces) - Each namespace contains many revisions.
* [GetRevisions](#getrevisions)
* [GetTags](#gettags)
* [ListRemoteSources](#listremotesources) - Get remote sources attached to a particular namespace
* [PostTags](#posttags) - Add tags to an existing revision
* [Preflight](#preflight) - Get access token for communicating with OCI distribution endpoints
* [SetArchived](#setarchived) - Set whether a namespace is archived
* [SetVisibility](#setvisibility) - Set visibility of a namespace with an existing metadata entry

## CreateRemoteSource

Configure a new remote source

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RemoteSource req = new RemoteSource() {
    Inputs = new List<RemoteDocument>() {
        new RemoteDocument() {
            RegistryUrl = "https://productive-swine.net",
        },
    },
    Output = new RemoteDocument() {
        RegistryUrl = "https://spiteful-apricot.info",
    },
};

var res = await sdk.Artifacts.CreateRemoteSourceAsync(req);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [RemoteSource](../../Models/Shared/RemoteSource.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[CreateRemoteSourceResponse](../../Models/Operations/CreateRemoteSourceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

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

## ListRemoteSources

Get remote sources attached to a particular namespace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

ListRemoteSourcesRequest req = new ListRemoteSourcesRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.ListRemoteSourcesAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListRemoteSourcesRequest](../../Models/Operations/ListRemoteSourcesRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListRemoteSourcesResponse](../../Models/Operations/ListRemoteSourcesResponse.md)**

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

## SetArchived

Set whether a namespace is archived

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

ArchiveNamespaceRequest req = new ArchiveNamespaceRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.SetArchivedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ArchiveNamespaceRequest](../../Models/Operations/ArchiveNamespaceRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[ArchiveNamespaceResponse](../../Models/Operations/ArchiveNamespaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## SetVisibility

Set visibility of a namespace with an existing metadata entry

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

SetVisibilityRequest req = new SetVisibilityRequest() {
    NamespaceName = "<value>",
};

var res = await sdk.Artifacts.SetVisibilityAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [SetVisibilityRequest](../../Models/Operations/SetVisibilityRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[SetVisibilityResponse](../../Models/Operations/SetVisibilityResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |