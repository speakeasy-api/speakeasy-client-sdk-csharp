# embeds

## Overview

REST APIs for managing embeds

### Available Operations

* [GetEmbedAccessToken](#getembedaccesstoken) - Get an embed access token for the current workspace.
* [GetValidEmbedAccessTokens](#getvalidembedaccesstokens) - Get all valid embed access tokens for the current workspace.
* [RevokeEmbedAccessToken](#revokeembedaccesstoken) - Revoke an embed access EmbedToken.

## GetEmbedAccessToken

Returns an embed access token for the current workspace. This can be used to authenticate access to externally embedded content.
Filters can be applied allowing views to be filtered to things like particular customerIds.

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

var res = await sdk.Embeds.GetEmbedAccessTokenAsync(new GetEmbedAccessTokenRequest() {
    Description = "porro",
    Duration = 678880,
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "dicta",
                Operator = "nam",
                Value = "officia",
            },
        },
        Limit = 582020,
        Offset = 143353,
        Operator = "deleniti",
    },
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetEmbedAccessTokenRequest](../../models/operations/GetEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetEmbedAccessTokenResponse](../../models/operations/GetEmbedAccessTokenResponse.md)**


## GetValidEmbedAccessTokens

Get all valid embed access tokens for the current workspace.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Shared;

var sdk = new SpeakeasySDK(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.GetValidEmbedAccessTokensAsync();

// handle response
```


### Response

**[GetValidEmbedAccessTokensResponse](../../models/operations/GetValidEmbedAccessTokensResponse.md)**


## RevokeEmbedAccessToken

Revoke an embed access EmbedToken.

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

var res = await sdk.Embeds.RevokeEmbedAccessTokenAsync(new RevokeEmbedAccessTokenRequest() {
    TokenID = "hic",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RevokeEmbedAccessTokenRequest](../../models/operations/RevokeEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[RevokeEmbedAccessTokenResponse](../../models/operations/RevokeEmbedAccessTokenResponse.md)**

