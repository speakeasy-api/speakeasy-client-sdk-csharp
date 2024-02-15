# Auth
(*Auth*)

## Overview

REST APIs for managing Authentication

### Available Operations

* [GetWorkspaceAccess](#getworkspaceaccess) - Get access allowances for a particular workspace
* [ValidateApiKey](#validateapikey) - Validate the current api key.

## GetWorkspaceAccess

Checks if generation is permitted for a particular run of the CLI

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

GetWorkspaceAccessRequest req = new GetWorkspaceAccessRequest() {};

var res = await sdk.Auth.GetWorkspaceAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetWorkspaceAccessRequest](../../Models/Operations/GetWorkspaceAccessRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetWorkspaceAccessResponse](../../Models/Operations/GetWorkspaceAccessResponse.md)**


## ValidateApiKey

Validate the current api key.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new Speakeasy(
    security: new Security() {
        APIKey = "<YOUR_API_KEY_HERE>",
    },
    workspaceID: "<value>");

var res = await sdk.Auth.ValidateApiKeyAsync();

// handle response
```


### Response

**[ValidateApiKeyResponse](../../Models/Operations/ValidateApiKeyResponse.md)**

