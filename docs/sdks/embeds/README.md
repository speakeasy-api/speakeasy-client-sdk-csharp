# Embeds
(*Embeds*)

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
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;
using System.Collections.Generic;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.GetEmbedAccessTokenAsync(new GetEmbedAccessTokenRequest() {
    Filters = new Filters() {
        Filters = new List<Filter>() {
            new Filter() {
                Key = "<key>",
                Operator = "string",
                Value = "string",
            },
        },
        Limit = 964408,
        Offset = 95617,
        Operator = "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetEmbedAccessTokenRequest](../../Models/Operations/GetEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetEmbedAccessTokenResponse](../../Models/Operations/GetEmbedAccessTokenResponse.md)**


## GetValidEmbedAccessTokens

Get all valid embed access tokens for the current workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.GetValidEmbedAccessTokensAsync();

// handle response
```


### Response

**[GetValidEmbedAccessTokensResponse](../../Models/Operations/GetValidEmbedAccessTokensResponse.md)**


## RevokeEmbedAccessToken

Revoke an embed access EmbedToken.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using SpeakeasySDK.Models.Operations;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "",
    }
);

var res = await sdk.Embeds.RevokeEmbedAccessTokenAsync(new RevokeEmbedAccessTokenRequest() {
    TokenID = "string",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [RevokeEmbedAccessTokenRequest](../../Models/Operations/RevokeEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[RevokeEmbedAccessTokenResponse](../../Models/Operations/RevokeEmbedAccessTokenResponse.md)**

