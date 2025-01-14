# Workspaces
(*Workspaces*)

## Overview

REST APIs for managing Workspaces (speakeasy tenancy)

### Available Operations

* [Create](#create) - Create a workspace
* [CreateToken](#createtoken) - Create a token for a particular workspace
* [DeleteToken](#deletetoken) - Delete a token for a particular workspace
* [Get](#get) - Get workspace by context
* [GetAll](#getall) - Get workspaces for a user
* [GetByID](#getbyid) - Get workspace
* [GetFeatureFlags](#getfeatureflags) - Get workspace feature flags
* [GetSettings](#getsettings) - Get workspace settings
* [GetTeam](#getteam) - Get team members for a particular workspace
* [GetTokens](#gettokens) - Get tokens for a particular workspace
* [GrantAccess](#grantaccess) - Grant a user access to a particular workspace
* [RevokeAccess](#revokeaccess) - Revoke a user's access to a particular workspace
* [SetFeatureFlags](#setfeatureflags) - Set workspace feature flags
* [Update](#update) - Update workspace details
* [UpdateSettings](#updatesettings) - Update workspace settings

## Create

Creates a workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

Workspace req = new Workspace() {
    CreatedAt = System.DateTime.Parse("2024-06-17T07:14:55.338Z"),
    Id = "<id>",
    Name = "<value>",
    OrganizationId = "<id>",
    Slug = "<value>",
    UpdatedAt = System.DateTime.Parse("2024-11-30T17:06:07.804Z"),
    Verified = false,
};

var res = await sdk.Workspaces.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                     | Type                                          | Required                                      | Description                                   |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| `request`                                     | [Workspace](../../Models/Shared/Workspace.md) | :heavy_check_mark:                            | The request object to use for the request.    |

### Response

**[CreateWorkspaceResponse](../../Models/Operations/CreateWorkspaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## CreateToken

Create a token for a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

CreateWorkspaceTokenRequest req = new CreateWorkspaceTokenRequest() {
    WorkspaceToken = new WorkspaceToken() {
        Alg = "<value>",
        CreatedAt = System.DateTime.Parse("2023-08-16T02:33:00.784Z"),
        Id = "<id>",
        Key = "<key>",
        Name = "<value>",
        WorkspaceId = "<id>",
    },
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.CreateTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [CreateWorkspaceTokenRequest](../../Models/Operations/CreateWorkspaceTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[CreateWorkspaceTokenResponse](../../Models/Operations/CreateWorkspaceTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## DeleteToken

Delete a token for a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

DeleteWorkspaceTokenRequest req = new DeleteWorkspaceTokenRequest() {
    TokenID = "<id>",
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.DeleteTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [DeleteWorkspaceTokenRequest](../../Models/Operations/DeleteWorkspaceTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[DeleteWorkspaceTokenResponse](../../Models/Operations/DeleteWorkspaceTokenResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## Get

Get information about a particular workspace by context.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Workspaces.GetAsync();

// handle response
```

### Response

**[GetWorkspaceByContextResponse](../../Models/Operations/GetWorkspaceByContextResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetAll

Returns a list of workspaces a user has access too

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

var res = await sdk.Workspaces.GetAllAsync();

// handle response
```

### Response

**[GetWorkspacesResponse](../../Models/Operations/GetWorkspacesResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetByID

Get information about a particular workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceRequest req = new GetWorkspaceRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GetByIDAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [GetWorkspaceRequest](../../Models/Operations/GetWorkspaceRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[GetWorkspaceResponse](../../Models/Operations/GetWorkspaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetFeatureFlags

Get workspace feature flags

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceFeatureFlagsRequest req = new GetWorkspaceFeatureFlagsRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GetFeatureFlagsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetWorkspaceFeatureFlagsRequest](../../Models/Operations/GetWorkspaceFeatureFlagsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetWorkspaceFeatureFlagsResponse](../../Models/Operations/GetWorkspaceFeatureFlagsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## GetSettings

Get settings about a particular workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceSettingsRequest req = new GetWorkspaceSettingsRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GetSettingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetWorkspaceSettingsRequest](../../Models/Operations/GetWorkspaceSettingsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetWorkspaceSettingsResponse](../../Models/Operations/GetWorkspaceSettingsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetTeam

Get team members for a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceTeamRequest req = new GetWorkspaceTeamRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GetTeamAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetWorkspaceTeamRequest](../../Models/Operations/GetWorkspaceTeamRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetWorkspaceTeamResponse](../../Models/Operations/GetWorkspaceTeamResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GetTokens

Get tokens for a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GetWorkspaceTokensRequest req = new GetWorkspaceTokensRequest() {
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GetTokensAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetWorkspaceTokensRequest](../../Models/Operations/GetWorkspaceTokensRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetWorkspaceTokensResponse](../../Models/Operations/GetWorkspaceTokensResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## GrantAccess

Grant a user access to a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

GrantUserAccessToWorkspaceRequest req = new GrantUserAccessToWorkspaceRequest() {
    Email = "Lucinda.Batz8@hotmail.com",
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.GrantAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GrantUserAccessToWorkspaceRequest](../../Models/Operations/GrantUserAccessToWorkspaceRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GrantUserAccessToWorkspaceResponse](../../Models/Operations/GrantUserAccessToWorkspaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## RevokeAccess

Revoke a user's access to a particular workspace

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

RevokeUserAccessToWorkspaceRequest req = new RevokeUserAccessToWorkspaceRequest() {
    UserId = "<id>",
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.RevokeAccessAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [RevokeUserAccessToWorkspaceRequest](../../Models/Operations/RevokeUserAccessToWorkspaceRequest.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[RevokeUserAccessToWorkspaceResponse](../../Models/Operations/RevokeUserAccessToWorkspaceResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## SetFeatureFlags

Set workspace feature flags

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Shared;
using System.Collections.Generic;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

WorkspaceFeatureFlagRequest req = new WorkspaceFeatureFlagRequest() {
    FeatureFlags = new List<WorkspaceFeatureFlag>() {
        WorkspaceFeatureFlag.SkipSchemaRegistry,
    },
};

var res = await sdk.Workspaces.SetFeatureFlagsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [WorkspaceFeatureFlagRequest](../../Models/Shared/WorkspaceFeatureFlagRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[SetWorkspaceFeatureFlagsResponse](../../Models/Operations/SetWorkspaceFeatureFlagsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 5XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 4XX                                     | \*/\*                                   |

## Update

Update information about a particular workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

UpdateWorkspaceDetailsRequest req = new UpdateWorkspaceDetailsRequest() {
    Workspace = new Workspace() {
        CreatedAt = System.DateTime.Parse("2025-07-28T19:04:48.565Z"),
        Id = "<id>",
        Name = "<value>",
        OrganizationId = "<id>",
        Slug = "<value>",
        UpdatedAt = System.DateTime.Parse("2024-10-16T10:52:42.015Z"),
        Verified = false,
    },
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UpdateWorkspaceDetailsRequest](../../Models/Operations/UpdateWorkspaceDetailsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UpdateWorkspaceDetailsResponse](../../Models/Operations/UpdateWorkspaceDetailsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |

## UpdateSettings

Update settings about a particular workspace.

### Example Usage

```csharp
using SpeakeasySDK;
using SpeakeasySDK.Models.Operations;
using SpeakeasySDK.Models.Shared;
using System;

var sdk = new SDK(security: new Security() {
    APIKey = "<YOUR_API_KEY_HERE>",
});

UpdateWorkspaceSettingsRequest req = new UpdateWorkspaceSettingsRequest() {
    WorkspaceSettings = new WorkspaceSettings() {
        CreatedAt = System.DateTime.Parse("2023-07-05T11:43:28.305Z"),
        UpdatedAt = System.DateTime.Parse("2024-05-14T05:39:21.874Z"),
        WebhookUrl = "https://grown-pharmacopoeia.net",
        WorkspaceId = "<id>",
    },
    WorkspaceId = "<id>",
};

var res = await sdk.Workspaces.UpdateSettingsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UpdateWorkspaceSettingsRequest](../../Models/Operations/UpdateWorkspaceSettingsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[UpdateWorkspaceSettingsResponse](../../Models/Operations/UpdateWorkspaceSettingsResponse.md)**

### Errors

| Error Type                              | Status Code                             | Content Type                            |
| --------------------------------------- | --------------------------------------- | --------------------------------------- |
| SpeakeasySDK.Models.Errors.Error        | 4XX                                     | application/json                        |
| SpeakeasySDK.Models.Errors.SDKException | 5XX                                     | \*/\*                                   |