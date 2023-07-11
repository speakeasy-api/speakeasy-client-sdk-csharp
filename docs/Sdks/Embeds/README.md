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
using Speakeasy.Models.Security;
using Speakeasy.Models.Embeds;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Embeds.GetEmbedAccessToken(request);
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetEmbedAccessTokenRequest](../../Models/Embeds/GetEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetEmbedAccessTokenResponse](../../Models/Embeds/GetEmbedAccessTokenResponse.md)**


## GetValidEmbedAccessTokens

Get all valid embed access tokens for the current workspace.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Embeds;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Embeds.GetValidEmbedAccessTokens();
```


### Response

**[GetValidEmbedAccessTokensResponse](../../Models/Embeds/GetValidEmbedAccessTokensResponse.md)**


## RevokeEmbedAccessToken

Revoke an embed access EmbedToken.

### Example Usage

```csharp
using Speakeasy;
using Speakeasy.Models.Security;
using Speakeasy.Models.Embeds;

var sdk = new SpeakeasySDK(
    security: new Security() {
        apiKey = "",
    }
);

var res = await sdk.Embeds.RevokeEmbedAccessToken(request);
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [RevokeEmbedAccessTokenRequest](../../Models/Embeds/RevokeEmbedAccessTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[RevokeEmbedAccessTokenResponse](../../Models/Embeds/RevokeEmbedAccessTokenResponse.md)**

