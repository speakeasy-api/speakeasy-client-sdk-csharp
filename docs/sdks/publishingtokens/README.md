# PublishingTokens

## Overview

### Available Operations

* [Create](#create) - Create a publishing token for a workspace
* [Delete](#delete) - Delete a specific publishing token
* [Get](#get) - Get a specific publishing token
* [List](#list) - Get publishing tokens for a workspace
* [ResolveMetadata](#resolvemetadata) - Get metadata about the token
* [ResolveTarget](#resolvetarget) - Get a specific publishing token target
* [Update](#update) - Updates the validitity period of a publishing token

## Create

Creates a publishing token for the current workspace

### Example Usage

<!-- UsageSnippet language="csharp" operationID="createPublishingToken" method="post" path="/v1/publishing-tokens" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CreatePublishingTokenRequestBody? req = null;

var res = await sdk.PublishingTokens.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [CreatePublishingTokenRequestBody](../../Models/Operations/CreatePublishingTokenRequestBody.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[CreatePublishingTokenResponse](../../Models/Operations/CreatePublishingTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## Delete

Delete a particular publishing token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="deletePublishingToken" method="delete" path="/v1/publishing-tokens/{tokenID}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

DeletePublishingTokenRequest req = new DeletePublishingTokenRequest() {
    TokenID = "<id>",
};

var res = await sdk.PublishingTokens.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeletePublishingTokenRequest](../../Models/Operations/DeletePublishingTokenRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DeletePublishingTokenResponse](../../Models/Operations/DeletePublishingTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## Get

Get information about a particular publishing token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPublishingTokenByID" method="get" path="/v1/publishing-tokens/{tokenID}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetPublishingTokenByIDRequest req = new GetPublishingTokenByIDRequest() {
    TokenID = "<id>",
};

var res = await sdk.PublishingTokens.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetPublishingTokenByIDRequest](../../Models/Operations/GetPublishingTokenByIDRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetPublishingTokenByIDResponse](../../Models/Operations/GetPublishingTokenByIDResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## List

Returns a publishing token for the current workspace

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPublishingToken" method="get" path="/v1/publishing-tokens" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.PublishingTokens.ListAsync();

// handle response
```

### Response

**[GetPublishingTokenResponse](../../Models/Operations/GetPublishingTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ResolveMetadata

Get information about a particular publishing token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPublishingTokenPublicMetadata" method="get" path="/v1/publishing-tokens/{tokenID}/metadata" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetPublishingTokenPublicMetadataRequest req = new GetPublishingTokenPublicMetadataRequest() {
    TokenID = "<id>",
};

var res = await sdk.PublishingTokens.ResolveMetadataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetPublishingTokenPublicMetadataRequest](../../Models/Operations/GetPublishingTokenPublicMetadataRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |

### Response

**[GetPublishingTokenPublicMetadataResponse](../../Models/Operations/GetPublishingTokenPublicMetadataResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ResolveTarget

Get information about a particular publishing token target.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="getPublishingTokenTargetByID" method="get" path="/v1/publishing-tokens/{tokenID}/target" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetPublishingTokenTargetByIDRequest req = new GetPublishingTokenTargetByIDRequest() {
    TokenID = "<id>",
};

var res = await sdk.PublishingTokens.ResolveTargetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetPublishingTokenTargetByIDRequest](../../Models/Operations/GetPublishingTokenTargetByIDRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GetPublishingTokenTargetByIDResponse](../../Models/Operations/GetPublishingTokenTargetByIDResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## Update

Updates the validity period of a particular publishing token.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="updatePublishingTokenExpiration" method="put" path="/v1/publishing-tokens/{tokenID}" -->
```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

UpdatePublishingTokenExpirationRequest req = new UpdatePublishingTokenExpirationRequest() {
    TokenID = "<id>",
};

var res = await sdk.PublishingTokens.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [UpdatePublishingTokenExpirationRequest](../../Models/Operations/UpdatePublishingTokenExpirationRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[UpdatePublishingTokenExpirationResponse](../../Models/Operations/UpdatePublishingTokenExpirationResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |