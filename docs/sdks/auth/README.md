# Auth
(*Auth*)

## Overview

REST APIs for managing Authentication

### Available Operations

* [GetAccess](#getaccess) - Get access allowances for a particular workspace
* [GetAccessToken](#getaccesstoken) - Get or refresh an access token for the current workspace.
* [GetUser](#getuser) - Get information about the current user.
* [ValidateApiKey](#validateapikey) - Validate the current api key.

## GetAccess

Checks if generation is permitted for a particular run of the CLI

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetWorkspaceAccessRequest](../../Models/Operations/GetWorkspaceAccessRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetWorkspaceAccessResponse](../../Models/Operations/GetWorkspaceAccessResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.SDKException | 4XX, 5XX                                | \*/\*                                   |

## GetAccessToken

Get or refresh an access token for the current workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;

var sdk = new SDK();

GetAccessTokenRequest req = new GetAccessTokenRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Auth.GetAccessTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetAccessTokenRequest](../../Models/Operations/GetAccessTokenRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[GetAccessTokenResponse](../../Models/Operations/GetAccessTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetUser

Get information about the current user.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Auth.GetUserAsync();

// handle response
```

### Response

**[GetUserResponse](../../Models/Operations/GetUserResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## ValidateApiKey

Validate the current api key.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Auth.ValidateApiKeyAsync();

// handle response
```

### Response

**[ValidateApiKeyResponse](../../Models/Operations/ValidateApiKeyResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |